# OdooNetFramework
Test Odoo with net framework 4.7.2 using ODOO V12 and V14 Cloud

## Packages used
- https://github.com/patricoos/PortaCapena.OdooJsonRpcClient

## Config App.config
- host (an url api https)
- database
- username
- password

## Steps
0. Config your appsettings (if you need, create a environment cloud in https://www.odoo.com/es_ES/trial )
1. Know your models or tables
2. Get initial full Model using ```OdooModelMapper.GetDotNetModel(tableName, modelResult.Value);```
3. Create your own custom models for get less data
4. Start coding
