$cmd = "$env:APPLICATION_PATH" + "\Sklad.Silverlight.exe"

& $cmd "uninstall"
& $cmd "install"
& $cmd "start"