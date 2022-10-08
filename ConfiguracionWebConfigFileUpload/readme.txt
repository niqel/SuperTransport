Esta configuracion se agrega desde la consola:Kudu

Esta en la siguiente ruta el web.config:
site/wwwroot/web.config

***Las lineas de importancia son:

<security>
      <requestFiltering>
        <!-- Measured in Bytes -->
        <requestLimits maxAllowedContentLength="1073741824" />  <!-- 1 GB-->
      </requestFiltering>
</security>