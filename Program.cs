
var writer = new Writer("Hello, world!");

// Step in here: everything works as expected:
writer.Write();

// But step here: the parameters are not "watch-able":
await writer.WriteAsync();
