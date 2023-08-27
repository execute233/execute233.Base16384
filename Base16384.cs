﻿namespace LC6464.Base16384;

/// <summary>
/// Base16384 编解码器。
/// </summary>
public static partial class Base16384 {
	/// <summary>
	/// 编码二进制数据到 Base16384 UTF-16 BE 编码数据。<br/>
	/// 特别注意：此方法无法处理过大的数据，如需处理过大数据请使用不包含此提示的方法（如包含 <see cref="Stream"/> 的）！
	/// 否则可能导致意外的结果或引发异常！
	/// </summary>
	/// <param name="data">二进制数据</param>
	/// <param name="dataLength">二进制数据有效长度</param>
	/// <param name="bufferPtr">输出缓冲区指针</param>
	/// <returns>已写入输出缓冲区的内容的长度</returns>
	public static unsafe int Encode(ReadOnlySpan<byte> data, int dataLength, byte* bufferPtr) {
		fixed (byte* dataPtr = data) {
			return Encode(dataPtr, dataLength, bufferPtr);
		}
	}

	/// <summary>
	/// 解码 Base16384 UTF-16 BE 编码数据到二进制数据。<br/>
	/// 特别注意：此方法无法处理过大的数据，如需处理过大数据请使用不包含此提示的方法（如包含 <see cref="Stream"/> 的）！
	/// 否则可能导致意外的结果或引发异常！
	/// </summary>
	/// <param name="data">Base16384 UTF-16 BE 编码数据</param>
	/// <param name="dataLength">Base16384 UTF-16 BE 编码数据有效长度</param>
	/// <param name="bufferPtr">输出缓冲区指针</param>
	/// <returns>已写入输出缓冲区的内容的长度</returns>
	public static unsafe int Decode(ReadOnlySpan<byte> data, int dataLength, byte* bufferPtr) {
		fixed (byte* dataPtr = data) {
			return Decode(dataPtr, dataLength, bufferPtr);
		}
	}


	/// <summary>
	/// 编码二进制数据到 Base16384 UTF-16 BE 编码数据。<br/>
	/// 特别注意：此方法无法处理过大的数据，如需处理过大数据请使用不包含此提示的方法（如包含 <see cref="Stream"/> 的）！
	/// 否则可能导致意外的结果或引发异常！
	/// </summary>
	/// <param name="data">二进制数据</param>
	/// <param name="bufferPtr">输出缓冲区指针</param>
	/// <returns>已写入输出缓冲区的内容的长度</returns>
	public static unsafe int Encode(ReadOnlySpan<byte> data, byte* bufferPtr) => Encode(data, data.Length, bufferPtr);

	/// <summary>
	/// 解码 Base16384 UTF-16 BE 编码数据到二进制数据。<br/>
	/// 特别注意：此方法无法处理过大的数据，如需处理过大数据请使用不包含此提示的方法（如包含 <see cref="Stream"/> 的）！
	/// 否则可能导致意外的结果或引发异常！
	/// </summary>
	/// <param name="data">Base16384 UTF-16 BE 编码数据</param>
	/// <param name="bufferPtr">输出缓冲区指针</param>
	/// <returns>已写入输出缓冲区的内容的长度</returns>
	public static unsafe int Decode(ReadOnlySpan<byte> data, byte* bufferPtr) => Decode(data, data.Length, bufferPtr);


	/// <summary>
	/// 编码二进制数据到 Base16384 UTF-16 BE 编码数据。<br/>
	/// 特别注意：此方法无法处理过大的数据，如需处理过大数据请使用不包含此提示的方法（如包含 <see cref="Stream"/> 的）！
	/// 否则可能导致意外的结果或引发异常！
	/// </summary>
	/// <param name="data">二进制数据</param>
	/// <param name="dataLength">二进制数据有效长度</param>
	/// <param name="buffer">输出缓冲区</param>
	/// <returns>已写入输出缓冲区的内容的长度</returns>
	public static unsafe int Encode(ReadOnlySpan<byte> data, int dataLength, ReadOnlySpan<byte> buffer) {
		fixed (byte* dataPtr = data) {
			fixed (byte* bufferPtr = buffer) {
				return Encode(dataPtr, dataLength, bufferPtr);
			}
		}
	}

	/// <summary>
	/// 解码 Base16384 UTF-16 BE 编码数据到二进制数据。<br/>
	/// 特别注意：此方法无法处理过大的数据，如需处理过大数据请使用不包含此提示的方法（如包含 <see cref="Stream"/> 的）！
	/// 否则可能导致意外的结果或引发异常！
	/// </summary>
	/// <param name="data">Base16384 UTF-16 BE 编码数据</param>
	/// <param name="dataLength">Base16384 UTF-16 BE 编码数据有效长度</param>
	/// <param name="buffer">输出缓冲区</param>
	/// <returns>已写入输出缓冲区的内容的长度</returns>
	public static unsafe int Decode(ReadOnlySpan<byte> data, int dataLength, ReadOnlySpan<byte> buffer) {
		fixed (byte* dataPtr = data) {
			fixed (byte* bufferPtr = buffer) {
				return Decode(dataPtr, dataLength, bufferPtr);
			}
		}
	}


	/// <summary>
	/// 编码二进制数据到 Base16384 UTF-16 BE 编码数据。<br/>
	/// 特别注意：此方法无法处理过大的数据，如需处理过大数据请使用不包含此提示的方法（如包含 <see cref="Stream"/> 的）！
	/// 否则可能导致意外的结果或引发异常！
	/// </summary>
	/// <param name="data">二进制数据</param>
	/// <param name="buffer">输出缓冲区</param>
	/// <returns>已写入输出缓冲区的内容的长度</returns>
	public static unsafe int Encode(ReadOnlySpan<byte> data, ReadOnlySpan<byte> buffer) => Encode(data, data.Length, buffer);

	/// <summary>
	/// 解码 Base16384 UTF-16 BE 编码数据到二进制数据。<br/>
	/// 特别注意：此方法无法处理过大的数据，如需处理过大数据请使用不包含此提示的方法（如包含 <see cref="Stream"/> 的）！
	/// 否则可能导致意外的结果或引发异常！
	/// </summary>
	/// <param name="data">Base16384 UTF-16 BE 编码数据</param>
	/// <param name="buffer">输出缓冲区</param>
	/// <returns>已写入输出缓冲区的内容的长度</returns>
	public static unsafe int Decode(ReadOnlySpan<byte> data, ReadOnlySpan<byte> buffer) => Decode(data, data.Length, buffer);


	/// <summary>
	/// 编码二进制数据到 Base16384 UTF-16 BE 编码数据。<br/>
	/// 特别注意：此方法无法处理过大的数据，如需处理过大数据请使用不包含此提示的方法（如包含 <see cref="Stream"/> 的）！
	/// 否则可能导致意外的结果或引发异常！
	/// </summary>
	/// <param name="dataPtr">二进制数据指针</param>
	/// <param name="dataLength">二进制数据长度</param>
	/// <returns>编码结果</returns>
	public static unsafe ReadOnlySpan<byte> Encode(byte* dataPtr, int dataLength) {
		var bufferLength = (int)EncodeLength(dataLength);
		var bufferPtr = (byte*)Marshal.AllocHGlobal(bufferLength);

		ReadOnlySpan<byte> result = new(bufferPtr, Encode(dataPtr, dataLength, bufferPtr));

		Marshal.FreeHGlobal((nint)bufferPtr); // 这里或许会把 result 的内存释放了，可能导致问题，@execute233 测试一下

		return result;
	}

	/// <summary>
	/// 解码 Base16384 UTF-16 BE 编码数据到二进制数据。<br/>
	/// 特别注意：此方法无法处理过大的数据，如需处理过大数据请使用不包含此提示的方法（如包含 <see cref="Stream"/> 的）！
	/// 否则可能导致意外的结果或引发异常！
	/// </summary>
	/// <param name="dataPtr">Base16384 UTF-16 BE 编码数据指针</param>
	/// <param name="dataLength">Base16384 UTF-16 BE 编码数据长度</param>
	/// <returns>解码结果</returns>
	public static unsafe ReadOnlySpan<byte> Decode(byte* dataPtr, int dataLength) {
		var bufferLength = (int)DecodeLength(dataLength);
		var bufferPtr = (byte*)Marshal.AllocHGlobal(bufferLength);

		ReadOnlySpan<byte> result = new(bufferPtr, Decode(dataPtr, dataLength, bufferPtr));

		Marshal.FreeHGlobal((nint)bufferPtr); // 这里或许会把 result 的内存释放了，可能导致问题，@execute233 测试一下

		return result;
	}


	/// <summary>
	/// 编码二进制数据到 Base16384 UTF-16 BE 编码数据。<br/>
	/// 特别注意：此方法无法处理过大的数据，如需处理过大数据请使用不包含此提示的方法（如包含 <see cref="Stream"/> 的）！
	/// 否则可能导致意外的结果或引发异常！
	/// </summary>
	/// <param name="data">二进制数据</param>
	/// <param name="dataLength">二进制数据有效长度</param>
	/// <returns>编码结果</returns>
	public static unsafe ReadOnlySpan<byte> Encode(ReadOnlySpan<byte> data, int dataLength) {
		fixed (byte* dataPtr = data) {
			return Encode(dataPtr, dataLength);
		}
	}

	/// <summary>
	/// 解码 Base16384 UTF-16 BE 编码数据到二进制数据。<br/>
	/// 特别注意：此方法无法处理过大的数据，如需处理过大数据请使用不包含此提示的方法（如包含 <see cref="Stream"/> 的）！
	/// 否则可能导致意外的结果或引发异常！
	/// </summary>
	/// <param name="data">Base16384 UTF-16 BE 编码数据</param>
	/// <param name="dataLength">Base16384 UTF-16 BE 编码数据有效长度</param>
	/// <returns>解码结果</returns>
	public static unsafe ReadOnlySpan<byte> Decode(ReadOnlySpan<byte> data, int dataLength) {
		fixed (byte* dataPtr = data) {
			return Decode(dataPtr, dataLength);
		}
	}


	/// <summary>
	/// 编码二进制数据到 Base16384 UTF-16 BE 编码数据。<br/>
	/// 特别注意：此方法无法处理过大的数据，如需处理过大数据请使用不包含此提示的方法（如包含 <see cref="Stream"/> 的）！
	/// 否则可能导致意外的结果或引发异常！
	/// </summary>
	/// <param name="data">二进制数据</param>
	/// <returns>编码结果</returns>
	public static unsafe ReadOnlySpan<byte> Encode(ReadOnlySpan<byte> data) => Encode(data, data.Length);

	/// <summary>
	/// 解码 Base16384 UTF-16 BE 编码数据到二进制数据。<br/>
	/// 特别注意：此方法无法处理过大的数据，如需处理过大数据请使用不包含此提示的方法（如包含 <see cref="Stream"/> 的）！
	/// 否则可能导致意外的结果或引发异常！
	/// </summary>
	/// <param name="data">Base16384 UTF-16 BE 编码数据</param>
	/// <returns>解码结果</returns>
	public static unsafe ReadOnlySpan<byte> Decode(ReadOnlySpan<byte> data) => Decode(data, data.Length);
}