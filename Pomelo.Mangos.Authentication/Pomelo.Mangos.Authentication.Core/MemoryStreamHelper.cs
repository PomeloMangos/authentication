using System.IO;

namespace Pomelo.Mangos.Authentication
{
	/// <summary>
	/// Provide helper method for <see cref="MemoryStream"/>. This class is static.
	/// </summary>
	public static class MemoryStreamHelper
	{
		/// <summary>
		/// Write an entire byte sequence into the memory stream.
		/// </summary>
		/// <param name="stream">The memory stream.</param>
		/// <param name="buffer">The buffer to be written.</param>
		public static void Write(this MemoryStream stream, byte[] buffer) => stream.Write(buffer, 0, buffer.Length);
	}
}