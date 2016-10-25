
# Pràctica "Map Editor"

__OBJECTIU:__ Es desitja construir una aplicació per editar/mantenir els mapes d'un joc d'aventures en 2D. El programa ens ha de permetre dos grans funcionalitats:
 * Gestionar items que es poden col·locar en un mapa ( crear-los/modificar-los i esborrar-los ). Cada Item té un nom, una descripció i una fotografia.
 * Posicionar els ítems en el mapa. Cada ítem pot aparèixer MULTIPLES vegades al mapa, amb diferents valors de quantitat (amount) , posició i visibilitat.

![Captura de pantalla](resources/pac2_screenshot.png "Captura de pantalla")

Arxius de prova proporcionats:
 * [Mapes i icones d'exemple ](resources/resources.jar)
 * [Classes d'exemple](resources/classes.jar)

 
## Codi proporcionat 

Es proporciona el codi que permet obrir un selector d'arxius, llegir-lo i desar-lo
en un string.

```c#
		/// How to program a File Picker, and read the selected file
		/// into a string.
        private async void btnFile1_Click(object sender, RoutedEventArgs e)
        {
            FileOpenPicker fp = new FileOpenPicker();
            fp.FileTypeFilter.Add(".txt");
            fp.FileTypeFilter.Add(".rtf");

            StorageFile sf = await fp.PickSingleFileAsync();
            string textReadFromFile = await readTextFile(sf);
            
			// ..... YOUR CODE HERE ...........
        }
		
		

        /// <summary>
        /// Read the storage file in text mode, returning it as string.
        /// Carriage return and line feed are supressed, and replaced by spaces.
        /// </summary>
        /// <param name="sf"></param>
        /// <returns></returns>
        private async Task<string> readTextFile(StorageFile sf)
        {
            StringWriter sw = new StringWriter();
            IRandomAccessStream stream = await sf.OpenAsync(FileAccessMode.Read);
            using (StreamReader streamReader = new StreamReader(stream.AsStream()))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    //txt += line + Environment.NewLine;
                    sw.Write(line + " ");
                }

                return sw.ToString();
            }
        }
		
```		