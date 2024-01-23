
var writer = new Writer("Hello, world!");

// Here everything works as expected:
writer.Write();

// But here the parameters are not "watch-able":
await writer.WriteAsync();
