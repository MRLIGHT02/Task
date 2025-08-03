






string path = @"C:\Users\saif ali\sample.txt";


string content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc tincidunt risus et risus feugiat, sagittis congue nisl varius. Cras egestas nec orci sed iaculis. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc scelerisque augue eu justo elementum, sit amet imperdiet arcu euismod. Praesent ultricies suscipit suscipit. Praesent eu augue faucibus, interdum arcu imperdiet, molestie tortor. Nunc semper faucibus velit, vel cursus augue lobortis a. In in vehicula felis, et rhoncus risus. Proin et nulla at velit facilisis sagittis et ornare justo. Morbi non ipsum tristique, euismod nisl quis, sollicitudin sapien. Proin sit amet metus lobortis nulla condimentum rutrum." +
    " Sed vitae malesuada lorem.\r\n\r\nFusce tortor augue, auctor a ligula sit amet, varius porta orci. Vestibulum velit diam, finibus id ornare et, efficitur in turpis. Ut dolor nisl, placerat quis facilisis non, venenatis ac nibh. Duis ut tortor sed velit porttitor hendrerit vitae eu turpis. Sed nisi nunc, consequat a fermentum eu, cursus non dui. Donec non commodo sapien, at efficitur felis. Quisque ante ipsum, mollis vel semper in, venenatis sit amet quam.\r\n\r\nAliquam eu ipsum eros. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Ut consequat maximus ante, a pharetra quam finibus at. Aliquam vestibulum justo non ligula posuere, id cursus erat auctor. Sed imperdiet, ante in fermentum gravida, libero nisi mattis felis, et cursus dolor augue sed urna. Praesent at dolor eleifend, viverra purus vitae, ornare nisi. Pellentesque sollicitudin augue nunc, quis tincidunt mi pretium sed. Phasellus fringilla, nisl ac accumsan imperdiet, diam ex volutpat lacus, ut sodales mi diam quis quam. Praesent eget enim lacus. Quisque interdum ultrices turpis, nec ornare lorem ullamcorper vel. Fusce id porttitor augue. Cras vitae massa ipsum. Suspendisse ullamcorper commodo metus nec egestas.";

FileWriterExample fileWriter = new FileWriterExample();
Task write= fileWriter.WriteFile(path, content);
write.Wait();
FileReaderExample fileReader = new FileReaderExample();
Task read = fileReader.ReadFile(path);
read.Wait();
class FileWriterExample { 

    public Task WriteFile(string path, string content)
    {
       StreamWriter writer = new(path);
        Task writetask = writer.WriteLineAsync(content);
        writer.FlushAsync();
        return writetask;
        writer.Close();
    }


   
}
class FileReaderExample
{
    public Task ReadFile(string path)
    {
        using StreamReader Reader = new(path);
        Task read = Reader.ReadToEndAsync();

        Reader.Close();
        return read;
    }

}
