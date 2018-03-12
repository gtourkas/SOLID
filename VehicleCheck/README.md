### Vehicle Check

##### Bad

A typical violation of the LSP since a client of the IVehicle abstraction will have to bypass the call of
the ElectricVehicle.IsEngineOilOk method that throws a NotSupportedException.

##### Good

Refactoring with ISP by builting two separate interfaces: One for conventional vehicles (IConventionalVehicle)
that does engine oil checking and another for electic vehicles (IElectricVehicle). 