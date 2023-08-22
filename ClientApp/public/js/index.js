$(document).ready(function () {



  if (window.location.href.includes('get')) {
    fetch(window.location.href)
      .then(response => response.text())
      .then(data => {
        const html = data;
        const editor = grapesjs.init({
          container: '#root',
          components: html,

          storageManager: {
            type: 'remote',
            autosave: true,
            stepsBeforeSave: 1,
            urlStore: 'projectEndpoint',
            urlLoad: 'projectEndpoint',

          },
          plugins: [
            'gjs-preset-newsletter',
            'gjs-blocks-basic',
            'grapesjs-plugin-forms',
            'grapesjs-component-countdown',
            'grapesjs-plugin-export',
            'grapesjs-tabs',
            'grapesjs-custom-code',
            'grapesjs-touch',
            'grapesjs-parser-postcss',
            'grapesjs-tooltip',
            'grapesjs-tui-image-editor',
            'grapesjs-typed',
            'grapesjs-typed',
            'grapesjs-style-bg',
            'grapesjs-preset-webpage'

          ],
          pluginsOpts: {
            'gjs-blocks-basic': { flexGrid: true },
            'grapesjs-tui-image-editor': {
              script: [
                // 'https://cdnjs.cloudflare.com/ajax/libs/fabric.js/1.6.7/fabric.min.js',
                'https://uicdn.toast.com/tui.code-snippet/v1.5.2/tui-code-snippet.min.js',
                'https://uicdn.toast.com/tui-color-picker/v2.2.7/tui-color-picker.min.js',
                'https://uicdn.toast.com/tui-image-editor/v3.15.2/tui-image-editor.min.js'
              ],
              style: [
                'https://uicdn.toast.com/tui-color-picker/v2.2.7/tui-color-picker.min.css',
                'https://uicdn.toast.com/tui-image-editor/v3.15.2/tui-image-editor.min.css',
              ],
            },
            'grapesjs-tabs': {
              tabsBlock: { category: 'Extra' }
            },
            'grapesjs-typed': {
              block: {
                category: 'Extra',
                content: {
                  type: 'typed',
                  'type-speed': 40,
                  strings: [
                    'Text row one',
                    'Text row two',
                    'Text row three',
                  ],
                }
              }
            },
            'grapesjs-preset-webpage': {
            },
            'gjs-preset-newsletter': {

            },
            'grapesjs-plugin-export': {

            },

          },


        });


        editor.Panels.addButton('options', [{
          id: 'options-toggle',
          className: 'dropdownicon',
          command: 'toggle-options',
          text: 'Sélectionner un champ de fusion',
          attributes: { title: 'Champs de fusion', id: 'optionschamp', name: 'optionschamp', class: 'dropdown-container' },
          tagName: 'select',
          traits: ['name', 'value'],

        }]);

        editor.Commands.add('toggle-options', {

          run(editor) {


            $.ajax({
              type: 'GET',
              url: 'LoadListChamp',

              success: function (jsonData) {
                if (jsonData == "") {
                  dropdownList.style.display = 'none';
                }
                else {
                  var dropdownList = $('#optionschamp');
                  var dropdownHtml = jsonData;
                  $("#optionschamp").html(dropdownHtml);
                  dropdownList.style.display = 'block';
                  dropdownList.bind();
                }
              },

            });
          },
        });









        //    const bm = editor.Blocks;
        //   bm.add(text, {
        //       label: text,
        //   category: 'Custom',
        //attributes: { class: 'dropdown-container'},
        //  style: {
        //      display: 'block',
        //       color: 'black',
        //       backgroundColor: '#f5f5f5',
        //       padding: '10px',
        //       borderRadius: '5px',
        //   },
        //  content:  '<span>'+'{[' +text + ']}'+'</span>',
        //  editable: '<span>' + '{[' + text + ']}' + '</span>',
        //  droppable: true,
        //       draggable: true,

        //   wrapper: {
        //       name: 'span',
        //           attributes: {
        //           class: 'my-wrapper-class',
        //           id: 'my-wrapper-id',
        //           'data-custom-attribute': 'my-custom-value',
        //           style: 'color: red; font-size: 16px;box-sizing: revert;'






        editor.Panels.addButton('options', [{
          id: 'htmlEn',
          className: 'englishlangicon',
          command: 'htmlEn',
          title: 'Charger le contenu en anglais'

        }]);
        editor.Commands.add('htmlEn', {
          run: function (editor) {

            fetch('TransEn')
              .then(response => response.text())
              .then(data => {
                editor.setComponents([]);
                editor.setComponents(data);

              });

          }
        });
        editor.Panels.addButton('options', [{
          id: 'htmlFr',
          className: 'frenchlangicon',
          command: 'htmlFr',
          attributes: {
            title: 'Charger le contenu en français'
          }

        }]);

        editor.Commands.add('htmlFr', {
          run: function (editor) {

            fetch('TransFr')
              .then(response => response.text())
              .then(data => {
                editor.setComponents([]);
                editor.setComponents(data);

              });

          }
        });
        editor.Panels.addButton('options', [{
          id: 'export',
          className: 'sauvegardericon',
          command: 'export',
          attributes: { title: 'Sauvegarder en base' }
        }]);

        editor.Commands.add('export', {

          run: function (editor) {
            const url = window.location.href;
            if (url.includes('getcamp')) {
              const designData2 = editor.getHtml();
              const data2 = {
                Fichier: designData2,
                FichierUs: designData2,

              };
              fetch('/SaveCamp/', {
                method: 'post',
                headers: {
                  'Content-Type': 'application/json'
                },
                body: JSON.stringify(data2)
              })
                .then(response => response.json())
                .then(data2 => {
                  alert(`New user added: ${data2.Description}`);
                });


            }

            else {
              const designData = editor.getHtml();
              const data = {
                ContenuFr: designData,
                ContenuUs: designData,

              };


              fetch('/Save/', {
                method: 'post',
                headers: {
                  'Content-Type': 'application/json'
                },
                body: JSON.stringify(data)
              })
                .then(response => response.json())
                .then(data => {
                  alert(`New user added: ${data.Description}`);
                });
            }
          }



        });

      })
  }

});
   






