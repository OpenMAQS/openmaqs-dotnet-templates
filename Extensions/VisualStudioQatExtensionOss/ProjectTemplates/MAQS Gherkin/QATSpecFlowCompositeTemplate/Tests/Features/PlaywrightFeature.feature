# This tags scopes the feature so that only BasePlaywrightTestSteps classes are instantiated when any scenario in this feature is run
@MAQS_Playwright

Feature: PlaywrightFeature
	In order to do something
	As a tester
	I want to do stuff

# This tags scopes the Scenario so that only BasePlaywrightTestSteps classes are instantiated when this scenario is run
@MAQS_Playwright
Scenario: PlaywrightFeatureScenario
	Given I login as the 'standard' user
	Then The home page is loaded
