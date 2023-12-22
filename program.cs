public sealed class ByteStream : IDisposable
{
    private readonly Stream stream;
    private readonly byte[] buffer;
    private int position;


    private int bufferedBytes;

    public ByteStream(Stream  stream)
    {
        this.stream = stream;
        buffer = new byte[1024 * 8];
    }


    public  async ValueTask<byte?> ReadByteAsync()
    {
        if(position == bufferedBytes)
        
        {
            position = 0;

            bufferedBytes = await 
                    stream.ReadAsync(buffer,0,buffer.Length)
                        .ConfigureAwait(false);

            if(bufferedBytes == 0)
            {
                return null;
            }
        }
        return buffer[position++];
    }

    public void Dispose()
    {
        stream.Dispose();
    }





}