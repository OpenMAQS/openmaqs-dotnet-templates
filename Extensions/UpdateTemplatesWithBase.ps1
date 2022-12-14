<#
.SYNOPSIS
    Zips the MAQS project templates.
.DESCRIPTION
    This powershell script is used to update the core and framework templates from the base content.  
    This way we can just update base content and not core and framework seperately.
.NOTES
  Version:        1.0
  Author:         Magenic
  Creation Date:  05/10/2021
  Purpose/Change: Initial script development. 

  Version:        2.0
  Author:         MAQS
  Creation Date:  01/18/2022
  Purpose/Change: Update for MAQS. 
  
  Version:        3.0
  Author:         MAQS
  Creation Date:  04/18/2022
  Purpose/Change: Add Playwright. 
#>

Function UpdateCore {
    Param ($source, $dest)
    $source = $source +"\*"
    Copy-Item -Path $source -Destination $dest -Recurse -force
    Get-ChildItem -Path $dest -Filter App.config -Recurse | Remove-Item -Force
 }

 Function UpdateCoreStudio {
    Param ($source, $dest)
    UpdateCore $source $dest

    $testsFiles = $dest + "\Tests\*\"  
    Get-ChildItem -Path $testsFiles -Include *.cs -Recurse | ForEach-Object {

    $find = 'namespace Tests'
    $replace = 'namespace $safeprojectname$'

    (Get-Content -Path $_.FullName) -replace $find, $replace | Set-Content -Path $_.FullName
   }
 }

 Function UpdateFrameworkStudio {
        Param ($source, $dest)

    $source = $source +"\*"
    Copy-Item -Path $source -Destination $dest -Recurse -force
    Get-ChildItem -Path $dest -Filter appsettings.json -Recurse | Remove-Item -Force

    $testsFiles = $dest + "\Tests\*\"  
    Get-ChildItem -Path $testsFiles -Include *.cs -Recurse | ForEach-Object {
        $find = 'namespace Tests'
        $replace = 'namespace $safeprojectname$'

        (Get-Content -Path $_.FullName) -replace $find, $replace | Set-Content -Path $_.FullName
    }

    Get-ChildItem -Path $dest -Include *.csproj -Recurse | ForEach-Object {
        $findVer = 'netcoreapp3.1'
        $replaceVer = 'net471'

        $findConfig = 'appsettings.json'
        $replaceConfig = 'App.config'

        (Get-Content -Path $_.FullName) -replace $findVer, $replaceVer | Set-Content -Path $_.FullName
        (Get-Content -Path $_.FullName) -replace $findConfig, $replaceConfig | Set-Content -Path $_.FullName
    }
 }

 UpdateCoreStudio $PSScriptRoot"\BaseContent\Maqs.Appium.Template" $PSScriptRoot"\VisualStudioQatExtensionOss\ProjectTemplates\MAQS Core\QATAppiumTemplate"
 UpdateFrameworkStudio $PSScriptRoot"\BaseContent\Maqs.Appium.Template" $PSScriptRoot"\VisualStudioQatExtensionOss\ProjectTemplates\MAQS Framework\QATAppiumTemplate"
 UpdateCore $PSScriptRoot"\BaseContent\Maqs.Appium.Template" $PSScriptRoot"\CoreTemplates\Maqs.Appium.Template"

 UpdateCoreStudio $PSScriptRoot"\BaseContent\Maqs.Base.Template" $PSScriptRoot"\VisualStudioQatExtensionOss\ProjectTemplates\MAQS Core\QATBaseTemplate"
 UpdateFrameworkStudio $PSScriptRoot"\BaseContent\Maqs.Base.Template" $PSScriptRoot"\VisualStudioQatExtensionOss\ProjectTemplates\MAQS Framework\QATBaseTemplate"
 UpdateCore $PSScriptRoot"\BaseContent\Maqs.Base.Template" $PSScriptRoot"\CoreTemplates\Maqs.Base.Template"

 UpdateCoreStudio $PSScriptRoot"\BaseContent\Maqs.Composite.Template" $PSScriptRoot"\VisualStudioQatExtensionOss\ProjectTemplates\MAQS Core\QATCompositeTemplate"
 UpdateFrameworkStudio $PSScriptRoot"\BaseContent\Maqs.Composite.Template" $PSScriptRoot"\VisualStudioQatExtensionOss\ProjectTemplates\MAQS Framework\QATCompositeTemplate"
 UpdateCore $PSScriptRoot"\BaseContent\Maqs.Composite.Template" $PSScriptRoot"\CoreTemplates\Maqs.Composite.Template"

 UpdateCoreStudio $PSScriptRoot"\BaseContent\Maqs.Database.Template" $PSScriptRoot"\VisualStudioQatExtensionOss\ProjectTemplates\MAQS Core\QATDatabaseTemplate"
 UpdateFrameworkStudio $PSScriptRoot"\BaseContent\Maqs.Database.Template" $PSScriptRoot"\VisualStudioQatExtensionOss\ProjectTemplates\MAQS Framework\QATDatabaseTemplate"
 UpdateCore $PSScriptRoot"\BaseContent\Maqs.Database.Template" $PSScriptRoot"\CoreTemplates\Maqs.Database.Template"

 UpdateCoreStudio $PSScriptRoot"\BaseContent\Maqs.Email.Template" $PSScriptRoot"\VisualStudioQatExtensionOss\ProjectTemplates\MAQS Core\QATEmailTemplate"
 UpdateFrameworkStudio $PSScriptRoot"\BaseContent\Maqs.Email.Template" $PSScriptRoot"\VisualStudioQatExtensionOss\ProjectTemplates\MAQS Framework\QATEmailTemplate"
 UpdateCore $PSScriptRoot"\BaseContent\Maqs.Email.Template" $PSScriptRoot"\CoreTemplates\Maqs.Email.Template"

 UpdateCoreStudio $PSScriptRoot"\BaseContent\Maqs.Selenium.Template" $PSScriptRoot"\VisualStudioQatExtensionOss\ProjectTemplates\MAQS Core\QATSeleniumTemplate"
 UpdateFrameworkStudio $PSScriptRoot"\BaseContent\Maqs.Selenium.Template" $PSScriptRoot"\VisualStudioQatExtensionOss\ProjectTemplates\MAQS Framework\QATSeleniumTemplate"
 UpdateCore $PSScriptRoot"\BaseContent\Maqs.Selenium.Template" $PSScriptRoot"\CoreTemplates\Maqs.Selenium.Template"
 
 UpdateCoreStudio $PSScriptRoot"\BaseContent\Maqs.Webservice.Template" $PSScriptRoot"\VisualStudioQatExtensionOss\ProjectTemplates\MAQS Core\QATWebserviceTemplate"
 UpdateFrameworkStudio $PSScriptRoot"\BaseContent\Maqs.Webservice.Template" $PSScriptRoot"\VisualStudioQatExtensionOss\ProjectTemplates\MAQS Framework\QATWebserviceTemplate"
 UpdateCore $PSScriptRoot"\BaseContent\Maqs.Webservice.Template" $PSScriptRoot"\CoreTemplates\Maqs.Webservice.Template"
 
 UpdateCoreStudio $PSScriptRoot"\BaseContent\Maqs.Playwright.Template" $PSScriptRoot"\VisualStudioQatExtensionOss\ProjectTemplates\MAQS Core\QATPlaywrightTemplate"
 UpdateFrameworkStudio $PSScriptRoot"\BaseContent\Maqs.Playwright.Template" $PSScriptRoot"\VisualStudioQatExtensionOss\ProjectTemplates\MAQS Framework\QATPlaywrightTemplate"
 UpdateCore $PSScriptRoot"\BaseContent\Maqs.Playwright.Template" $PSScriptRoot"\CoreTemplates\Maqs.Playwright.Template"
