# `CreateProcessAsUser` in C\#

This uses the Win32 API to:

1. Find the currently active user session
2. Spawn a new process in that session

This allows a process running in a different session (such as a windows service) to start a process with a graphical user interface that the user must see.

Note that the process must have the appropriate (admin) privileges for this to work correctly.

## Usage

```C#
using ProcessExtensions;
// ...
ProcessExtensions.StartProcessAsCurrentUser("calc.exe");
```

### Parameters

The second argument is used to pass the command line arguments as a string. Depending on the target
application, `argv[0]` might be expected to be the executable name, or it might be the first parameter.
See [this stack overflow answer](https://stackoverflow.com/a/14001282) for details. When in doubt, try it both ways.

## Tasks

Merge the following:

* [Change the dwFlags of STARTUPINFO · KamenRiderKuuga/CreateProcessAsUser@4368584](https://github.com/KamenRiderKuuga/CreateProcessAsUser/commit/4368584683fd2d595367ad0f2a557bad704577d7)
* [Create CreateProcessAsUser.cpp · syn4ps/CreateProcessAsUser@dd96f01](https://github.com/syn4ps/CreateProcessAsUser/commit/dd96f01d4989fb634f1a4c1fcc3b5ad587f92ac2)
* [Throw specific exception instead of a generic one · mmiszczyk/CreateProcessAsUser@378080b](https://github.com/mmiszczyk/CreateProcessAsUser/commit/378080ba865d3a62eef7e476c8c1d32153a8311d)
* [Clarify required permissions · 0x53A/CreateProcessAsUser@828509e](https://github.com/0x53A/CreateProcessAsUser/commit/828509e7ff66fef69475b9a2740f2ae2aca5d689)
