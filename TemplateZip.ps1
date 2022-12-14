<#
.SYNOPSIS
    Zips the MAQS project templates.
.DESCRIPTION
    This powershell script is used to zip the MAQS project templates. Editing of parameters in the powershell file may be necessary.
.PARAMETER openSource
    Set true if the openSource version of MAQS should be updated
.PARAMETER specSource
    Set true if the SpecFlow version of MAQS should be updated
.NOTES
  Version:        1.0
  Author:         Magenic
  Creation Date:  05/16/2017
  Purpose/Change: Initial script development. 

  Version:        2.0
  Author:         Magenic
  Creation Date:  07/9/2018
  Purpose/Change: Add SpecFlow build support. Add item template support.

  Version:        3.0
  Author:         Magenic
  Creation Date:  10/11/2019
  Purpose/Change: Remove depracated template.
  
  Version:        4.0
  Author:         Magenic
  Creation Date:  11/6/2021
  Purpose/Change: Add SpecFlow templates.

  Version:        5.0
  Author:         Cognizant Softvision
  Creation Date:  01/18/2022
  Purpose/Change: Update for MAQS Framework. 
  
.EXAMPLE
  ./TemplateUpdates

  This command will zip to the open or closed source version of MAQs, depending on which flags are hardcoded to default to true.
.EXAMPLE
  ./TemplateUpdates -openSource $true

  This command will zip the open source templates.
#>

param (
    [bool]$openSource = $true,
    [bool]$specSource = $true
)

###################################################################################################################
function ZipFiles($inputDirectory, $outputDirectory) {
    $nunitDir1 = $inputDirectory + "\NUnit"
    $nunitDir2 = $inputDirectory + "\NUnit Only"

    Set-Location $inputDirectory
    $relativePath = Get-ChildItem $inputDirectory -Directory | Resolve-Path -Relative
    ForEach ($file in $relativePath) {
        $file = $file.TrimStart(".", " ", "\")
        $input = $inputDirectory + "\" + $file
        $inputDir = $input + "\*"
        $destination = $outputDirectory + "\" + $file + ".zip"

        if (($input -ne $nunitDir1) -and ($input -ne $nunitDir2) -and ($input -ne $outputDirectory)) {
            Write-Host "Zipping " $input
            Compress-Archive -Path $inputDir -DestinationPath $destination -Force
            ##Copy-Item "C:\Users\TroyW\Desktop\QATBaseTemplate.zip" -Destination $destination -Force
        }
    }
}

function WorkflowFunction($openSource, $specSource) {
    if ($openSource) {
        ZipFiles $PSScriptRoot"\Extensions\VisualStudioQatExtensionOss\ProjectTemplates\MAQS Gherkin" $PSScriptRoot"\Extensions\VisualStudioQatExtensionOss\ProjectTemplates\MAQS Gherkin"
        ZipFiles $PSScriptRoot"\Extensions\VisualStudioQatExtensionOss\ProjectTemplates\MAQS Gherkin\NUnit" $PSScriptRoot"\Extensions\VisualStudioQatExtensionOss\ProjectTemplates\MAQS Gherkin\NUnit"
        ZipFiles $PSScriptRoot"\Extensions\VisualStudioQatExtensionOss\ProjectTemplates\MAQS Framework" $PSScriptRoot"\Extensions\VisualStudioQatExtensionOss\ProjectTemplates\MAQS Framework"
        ZipFiles $PSScriptRoot"\Extensions\VisualStudioQatExtensionOss\ProjectTemplates\MAQS Core" $PSScriptRoot"\Extensions\VisualStudioQatExtensionOss\ProjectTemplates\MAQS Core"
        ZipFiles $PSScriptRoot"\Extensions\VisualStudioQatExtensionOss\ItemTemplates\MAQS" $PSScriptRoot"\Extensions\VisualStudioQatExtensionOss\ItemTemplates\MAQS"
        ZipFiles $PSScriptRoot"\Extensions\VisualStudioQatExtensionOss\ItemTemplates\MAQS Gherkin" $PSScriptRoot"\Extensions\VisualStudioQatExtensionOss\ItemTemplates\MAQS Gherkin"        
    }
    
}

WorkflowFunction $openSource $specSource
