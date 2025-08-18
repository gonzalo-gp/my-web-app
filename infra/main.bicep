param location string = resourceGroup().location
param appServicePlanName string = 'myWebAppServicePlan'
param webAppName string = 'my-web-app-${uniqueString(resourceGroup().id)}'
param skuName string = 'B1' // Basic tier

resource appServicePlan 'Microsoft.Web/serverfarms@2022-03-01' = {
  name: appServicePlanName
  location: location
  sku: {
    name: skuName
    tier: 'Basic'
  }
  kind: 'app'
  properties: {
    reserved: false
  }
}

resource webApp 'Microsoft.Web/sites@2022-03-01' = {
  name: webAppName
  location: location
  kind: 'app'
  properties: {
    serverFarmId: appServicePlan.id
    httpsOnly: true
    siteConfig: {
      linuxFxVersion: '' // For Windows, leave blank. For Linux, e.g. 'DOTNETCORE|6.0'
    }
  }
}

output webAppUrl string = webApp.properties.defaultHostName