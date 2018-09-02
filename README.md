## c# mvc demo

no terminado.

## conexion sin asistente
- En web.config
```
<add name="DefaultConnection" connectionString="Data Source=sejo-PC\SQLEXPRESS;Initial Catalog=BodegaProductos;Integrated Security=True" providerName="System.Data.SqlClient" />

<add name="DataStore" connectionString="Data Source=sejo-PC\SQLEXPRESS;Initial Catalog=BodegaProductos;Integrated Security=True"
  providerName="System.Data.SqlClient" />

<entityFramework>
  <defaultConnectionFactory type="System.Data.Entity.Infrastructure.SqlConnectionFactory, EntityFramework">
    <parameters>
      <parameter value="Data Source=sejo-PC\SQLEXPRESS;Initial Catalog=BodegaProductos;Integrated Security=True"/>
    </parameters>
  </defaultConnectionFactory>
  <providers>
    <provider invariantName="System.Data.SqlClient" type="System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer"/>
  </providers>
</entityFramework>
```

- carpeta context, dentro clase DataStore que herede DbContext

- bara que crear automaticamente las migraciones por consola

```
Enable-Migrations -ContextTypeName DataStore -EnableAutomaticMigrations
```
- crea la carpeta migratins con un archivo configuration
//permita perdida de datos
AutomaticMigrationDataLossAllowed
//si hay cambios en la structura global.asax agregar
Database.SetInitializer(New Migrate...)
