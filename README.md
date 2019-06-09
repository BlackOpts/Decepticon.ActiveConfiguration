### Introduction

Provides current configuration value at build time that can be utilized for changing test environment for automation testing. The value is the current configuration dropdown value or the configuration variable.

### Requirements
Requires .NetFramework 4.6 or higher or any version of .NetCore

### Usage

If you have `Debug`, `Release`, `Staging` in the configuration dropdown, then select 'Staging'. Then build the project. Then do

```csharp
string stagingConfigName = ActiveConfiguration.Value;
```

### Notes

If you're on .NetFramework, make sure your custom configuration is available for the project.
See [Configuration Manager](https://docs.microsoft.com/en-us/visualstudio/ide/how-to-create-and-edit-configurations)
