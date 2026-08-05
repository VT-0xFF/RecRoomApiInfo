using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Collections;
using Unity.Netcode;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class IXBFVIJSSFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
	public IXBFVIJSSFJ()
	{
	}
}
namespace RecRoom.Foundation.Bitstream
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public ref struct BitReader
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Unity.Netcode.BitReader reader;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5AEE0A0", Offset = "0x5AECAA0", VA = "0x185AEE0A0")]
		public BitReader(Unity.Netcode.BitReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x99EC2E0", Offset = "0x99EACE0", VA = "0x1899EC2E0")]
		public void VXIGYTRTUBV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x99EC260", Offset = "0x99EAC60", VA = "0x1899EC260")]
		public void FQZHOWYVMPG([Out] bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x99EC2C0", Offset = "0x99EACC0", VA = "0x1899EC2C0")]
		public void PEEVVQQGQYV([Out] ulong a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x99EC2D0", Offset = "0x99EACD0", VA = "0x1899EC2D0")]
		public void PEEVVQQGQYV([Out] byte a, uint b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class KWMTDHEQGTL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x99ECD70", Offset = "0x99EB770", VA = "0x1899ECD70")]
		public static bool DMRPOXCKUAJ(this BitReader a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x99ECDC0", Offset = "0x99EB7C0", VA = "0x1899ECDC0")]
		public static uint JOSGKCYHLXD(this BitReader a, uint b, uint c)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x99ECF10", Offset = "0x99EB910", VA = "0x1899ECF10")]
		public static uint ZVCSQBZGEJE(this BitReader a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x99ECE50", Offset = "0x99EB850", VA = "0x1899ECE50")]
		public static ulong QIBQPIPKHNF(this BitReader a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class XYOUGSMDOCI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x99ED730", Offset = "0x99EC130", VA = "0x1899ED730")]
		public static void ZCNFUAYRIHV(this BitWriter a, uint b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x99ED1A0", Offset = "0x99EBBA0", VA = "0x1899ED1A0")]
		public static uint MZLAFNJCNLM(this BitReader a, bool b = false)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class BKBGBDIOKPW
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly int[] EIJRHUFPAQN;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x99EC120", Offset = "0x99EAB20", VA = "0x1899EC120")]
		public static int OZIILGIDOQX(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x87FD5C0", Offset = "0x87FBFC0", VA = "0x1887FD5C0")]
		public static int CNEZZGHCVEI(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9874880", Offset = "0x9873280", VA = "0x189874880")]
		public static long JYLTKBUHMCZ(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8820530", Offset = "0x881EF30", VA = "0x188820530")]
		public static uint BRCYBBLRBKM(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9874B20", Offset = "0x9873520", VA = "0x189874B20")]
		public static ulong ICRHKAIRBUJ(long a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public ref struct BitWriter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public Unity.Netcode.BitWriter writer;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5AEE0A0", Offset = "0x5AECAA0", VA = "0x185AEE0A0")]
		public BitWriter(Unity.Netcode.BitWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x99EC2F0", Offset = "0x99EACF0", VA = "0x1899EC2F0")]
		public void VXIGYTRTUBV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x99EC310", Offset = "0x99EAD10", VA = "0x1899EC310")]
		public void WPIWTZQGBHB(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x99EC300", Offset = "0x99EAD00", VA = "0x1899EC300")]
		public void WJUSEHRXXRK(ulong a, uint b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class DVBNVCMMEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x99EC370", Offset = "0x99EAD70", VA = "0x1899EC370")]
		public static ReadOnlySpan<byte> GUOUWQVGAHZ(this FastBufferWriter a)
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x99EC450", Offset = "0x99EAE50", VA = "0x1899EC450")]
		public static NativeArray<byte> OPEOQZMPNPG(this FastBufferWriter a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x99EC310", Offset = "0x99EAD10", VA = "0x1899EC310")]
		public static void PRFKKNJHBCA(this BitWriter a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x99EC5D0", Offset = "0x99EAFD0", VA = "0x1899EC5D0")]
		public static void TCTXZXJIXOI(this BitWriter a, uint b, uint c, uint d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x99EC6E0", Offset = "0x99EB0E0", VA = "0x1899EC6E0")]
		public static void YZTAZOTNXAB(this BitWriter a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x99EC670", Offset = "0x99EB070", VA = "0x1899EC670")]
		public static void TLJMXKSEGAS(this BitWriter a, ulong b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct FastBufferReader : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public Unity.Netcode.FastBufferReader reader;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int ORLIDGXUSPD
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5AF8870", Offset = "0x5AF7270", VA = "0x185AF8870")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x99EC880", Offset = "0x99EB280", VA = "0x1899EC880")]
		public FastBufferReader(NativeArray<byte> src, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x99EC750", Offset = "0x99EB150", VA = "0x1899EC750")]
		public bool AZAFAXRXEYK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x99EC850", Offset = "0x99EB250", VA = "0x1899EC850")]
		public BitReader TPGAKQATMXJ()
		{
			return default(BitReader);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x99EC820", Offset = "0x99EB220", VA = "0x1899EC820")]
		public void HZUHYQXJVSD([Out] byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x99EC790", Offset = "0x99EB190", VA = "0x1899EC790")]
		public void EIUZOSTGJRS(NativeArray<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3AEC6A0", Offset = "0x3AEB0A0", VA = "0x183AEC6A0")]
		public unsafe void EIUZOSTGJRS(byte* a, int b, int c = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3AF46A0", Offset = "0x3AF30A0", VA = "0x183AF46A0")]
		public void LMUZZGHIMKH<T>([Out] T a) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3AF68A0", Offset = "0x3AF52A0", VA = "0x183AF68A0")]
		public void YHSBHLIZZJS<T>([Out] T a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3AF4700", Offset = "0x3AF3100", VA = "0x183AF4700")]
		public void LMUZZGHIMKH<T>(NativeArray<T> a) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3AF47F0", Offset = "0x3AF31F0", VA = "0x183AF47F0")]
		public void LMUZZGHIMKH<T>(NativeList<T> a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x99EC780", Offset = "0x99EB180", VA = "0x1899EC780", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class IZJPIFWRMHS
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x99ECBF0", Offset = "0x99EB5F0", VA = "0x1899ECBF0")]
		public static int JYDXORXYWLF(this FastBufferReader a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x99ECC50", Offset = "0x99EB650", VA = "0x1899ECC50")]
		public static long LRXVAYWBLQI(this FastBufferReader a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x99ECD60", Offset = "0x99EB760", VA = "0x1899ECD60")]
		public static uint ZVCSQBZGEJE(this FastBufferReader a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x99ECCB0", Offset = "0x99EB6B0", VA = "0x1899ECCB0")]
		public static ulong QIBQPIPKHNF(this FastBufferReader a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct FastBufferWriter : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public Unity.Netcode.FastBufferWriter writer;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int ORLIDGXUSPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x99ECB50", Offset = "0x99EB550", VA = "0x1899ECB50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x99ECBB0", Offset = "0x99EB5B0", VA = "0x1899ECBB0")]
		public FastBufferWriter(int capacity, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x99EC8D0", Offset = "0x99EB2D0", VA = "0x1899EC8D0")]
		public bool AZAFAXRXEYK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x99ECA50", Offset = "0x99EB450", VA = "0x1899ECA50")]
		public BitWriter TPGAKQATMXJ()
		{
			return default(BitWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x99EC930", Offset = "0x99EB330", VA = "0x1899EC930", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x99EC980", Offset = "0x99EB380", VA = "0x1899EC980")]
		public unsafe byte* OMOMUNPPJQB()
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x99EC9E0", Offset = "0x99EB3E0", VA = "0x1899EC9E0")]
		public void PHVJALDVLQW(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x99ECAC0", Offset = "0x99EB4C0", VA = "0x1899ECAC0")]
		public void WEPJPVJZGCH(NativeArray<byte> a, int b = -1, int c = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3AF6D40", Offset = "0x3AF5740", VA = "0x183AF6D40")]
		public void JTDREBVHTVK<T>([In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3AF68F0", Offset = "0x3AF52F0", VA = "0x183AF68F0")]
		public void DUILBZLLBHX<T>([In] T value, int a) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3AF6D90", Offset = "0x3AF5790", VA = "0x183AF6D90")]
		public void JTDREBVHTVK<T>(NativeList<T> a) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3AF6EA0", Offset = "0x3AF58A0", VA = "0x183AF6EA0")]
		public void JTDREBVHTVK<T>(NativeArray<T> a) where T : struct
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class NXLPOEQSEUM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x99ED040", Offset = "0x99EBA40", VA = "0x1899ED040")]
		public static void FYNASIKQSMS(this FastBufferWriter a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x99ECFD0", Offset = "0x99EB9D0", VA = "0x1899ECFD0")]
		public static void CMRERJZCGKD(this FastBufferWriter a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x99ED190", Offset = "0x99EBB90", VA = "0x1899ED190")]
		public static void YZTAZOTNXAB(this FastBufferWriter a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x99ED0A0", Offset = "0x99EBAA0", VA = "0x1899ED0A0")]
		public static void TLJMXKSEGAS(this FastBufferWriter a, ulong b)
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
