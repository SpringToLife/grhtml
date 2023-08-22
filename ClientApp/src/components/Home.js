import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render() {
    return (

      <html lang="fr">
        <head>
          <meta charset="utf-8" />
          <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
          <meta name="theme-color" content="#000000" />
          <base href="%PUBLIC_URL%/" />
          <link rel="manifest" href="%PUBLIC_URL%/manifest.json" />
          <link rel="shortcut icon" href="%PUBLIC_URL%/favicon.ico" />
          <link rel="stylesheet" href="%PUBLIC_URL%/css/grapes.min.css" />
          <link rel="stylesheet" href="%PUBLIC_URL%/css/grapesjs-preset-newsletter.css" />
          <link rel="stylesheet" href="%PUBLIC_URL%/css/grapesjs-preset-webpage.min.css" />
          <link rel="stylesheet" href="%PUBLIC_URL%/style/material.css" />
          <link rel="stylesheet" href="%PUBLIC_URL%/style/tooltip.css" />
          <link rel="stylesheet" href="%PUBLIC_URL%/style/toastr.min.css" />
          <link rel="stylesheet" href="%PUBLIC_URL%/js/index.js.map" />
       <script  src="https://code.jquery.com/jquery-3.7.0.min.js"  integrity="sha256-2Pmvv0kuTBOenSvLm6bvfBSSHrUJ+3A7x6P5Ebd07/g="  crossorigin="anonymous"></script>
          <script src="%PUBLIC_URL%/js/grapes.min.js"></script>
          <script src="//ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
          <script src="%PUBLIC_URL%/js/grapesjs-preset-newsletter.min.js"></script>
          <script src="%PUBLIC_URL%/js/grapesjs-preset-webpage.min.js"></script>
          <script src="https://unpkg.com/grapesjs-preset-webpage@1.0.2"></script>
          <script src="https://unpkg.com/grapesjs-blocks-basic@1.0.1"></script>
          <script src="https://unpkg.com/grapesjs-plugin-forms@2.0.5"></script>
          <script src="https://unpkg.com/grapesjs-component-countdown@1.0.1"></script>
          <script src="https://unpkg.com/grapesjs-plugin-export@1.0.11"></script>
          <script src="https://unpkg.com/grapesjs-tabs@1.0.6"></script>
          <script src="https://unpkg.com/grapesjs-custom-code@1.0.1"></script>
          <script src="https://unpkg.com/grapesjs-touch@0.1.1"></script>
          <script src="https://unpkg.com/grapesjs-parser-postcss@1.0.1"></script>
          <script src="https://unpkg.com/grapesjs-tooltip@0.1.7"></script>
          <script src="https://unpkg.com/grapesjs-tui-image-editor@0.1.3"></script>
          <script src="https://unpkg.com/grapesjs-typed@1.0.5"></script>
          <script src="https://unpkg.com/grapesjs-style-bg@2.0.1"></script>
          <script src="https://cdn.jsdelivr.net/npm/file-saver@2.0.5/dist/FileSaver.min.js"></script>

     

        </head>
        <body>


          <div id="root"  >
            <div id="description"></div></div>

       

        </body>
      </html>

    );
  }
}

export default Home;