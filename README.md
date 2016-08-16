# dotnative

Experiments with dotnet, specifically invoking native libs and JNI

Before running the app, set the `LD_LIBRARY_PATH` environment variable
(or `DYLD_LIBRARY_PATH` if on OSX) to the location of your `libjvm.so`
file.

    $ export LD_LIBRARY_PATH=/usr/java/default/jre/lib/amd64/server
    $ dotnet restore
    $ dotnet run
