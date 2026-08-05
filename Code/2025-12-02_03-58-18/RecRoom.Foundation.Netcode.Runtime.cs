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
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class OPFYJNMMZGZ
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
	[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
	public OPFYJNMMZGZ()
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
		[Cpp2IlInjected.Address(RVA = "0x4649A00", Offset = "0x4648600", VA = "0x184649A00")]
		public BitReader(Unity.Netcode.BitReader reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x81F3360", Offset = "0x81F1F60", VA = "0x1881F3360")]
		public void SHLRVJQOSQV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x81F3370", Offset = "0x81F1F70", VA = "0x1881F3370")]
		public void ZVVCEFKEPNI([Out] bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x81F3350", Offset = "0x81F1F50", VA = "0x1881F3350")]
		public void CNCXSTEBOLB([Out] ulong a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x81F3340", Offset = "0x81F1F40", VA = "0x1881F3340")]
		public void CNCXSTEBOLB([Out] byte a, uint b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class OMDDUHYMLNV
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x81F3A70", Offset = "0x81F2670", VA = "0x1881F3A70")]
		public static bool LKQGYRWFVLV(this BitReader a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x81F3B80", Offset = "0x81F2780", VA = "0x1881F3B80")]
		public static uint UYKJGSQMDQX(this BitReader a, uint b, uint c)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x81F3C10", Offset = "0x81F2810", VA = "0x1881F3C10")]
		public static uint VWZTXPMKTBK(this BitReader a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x81F3AC0", Offset = "0x81F26C0", VA = "0x1881F3AC0")]
		public static ulong TCKNYWUREXL(this BitReader a)
		{
			return default(ulong);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class WOAXTLUQMDQ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x81F3EA0", Offset = "0x81F2AA0", VA = "0x1881F3EA0")]
		public static void NCDAQGIMSMB(this BitWriter a, uint b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x81F40B0", Offset = "0x81F2CB0", VA = "0x1881F40B0")]
		public static uint THMCWOKLWLW(this BitReader a, bool b = false)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class YPZYNQJCDRQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly int[] VHKPDFCXSRZ;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x81F4A20", Offset = "0x81F3620", VA = "0x1881F4A20")]
		public static int LOAMMKZWSSB(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x709A250", Offset = "0x7098E50", VA = "0x18709A250")]
		public static int VZLTYXDQUBA(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x808B7E0", Offset = "0x808A3E0", VA = "0x18808B7E0")]
		public static long QBZMDJTSVQT(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x70BCE30", Offset = "0x70BBA30", VA = "0x1870BCE30")]
		public static uint VBQXOMCCBKW(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x808A630", Offset = "0x8089230", VA = "0x18808A630")]
		public static ulong ETUNYAWPTCL(long a)
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
		[Cpp2IlInjected.Address(RVA = "0x4649A00", Offset = "0x4648600", VA = "0x184649A00")]
		public BitWriter(Unity.Netcode.BitWriter writer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x81F3440", Offset = "0x81F2040", VA = "0x1881F3440")]
		public void SHLRVJQOSQV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x81F33D0", Offset = "0x81F1FD0", VA = "0x1881F33D0")]
		public void ADESTEVJOAF(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x81F3430", Offset = "0x81F2030", VA = "0x1881F3430")]
		public void FWSHVONQQLE(ulong a, uint b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public static class YFXZSZDFLYP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x81F4830", Offset = "0x81F3430", VA = "0x1881F4830")]
		public static ReadOnlySpan<byte> ETTFUKQXHUB(this FastBufferWriter a)
		{
			return default(ReadOnlySpan<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x81F4640", Offset = "0x81F3240", VA = "0x1881F4640")]
		public static NativeArray<byte> BVRLTXFHTXU(this FastBufferWriter a, Allocator b)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x81F33D0", Offset = "0x81F1FD0", VA = "0x1881F33D0")]
		public static void AJJHAVIJFSW(this BitWriter a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x81F4910", Offset = "0x81F3510", VA = "0x1881F4910")]
		public static void KWVLCGFZCFU(this BitWriter a, uint b, uint c, uint d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x81F49B0", Offset = "0x81F35B0", VA = "0x1881F49B0")]
		public static void YKGIKKVJICL(this BitWriter a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x81F47C0", Offset = "0x81F33C0", VA = "0x1881F47C0")]
		public static void BWRJDHKQJCI(this BitWriter a, ulong b)
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
		public int EYPZHMQDKRN
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x46530C0", Offset = "0x4651CC0", VA = "0x1846530C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x81F3580", Offset = "0x81F2180", VA = "0x1881F3580")]
		public FastBufferReader(NativeArray<byte> src, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x81F3490", Offset = "0x81F2090", VA = "0x1881F3490")]
		public bool QMWBYPAHZIM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x81F34C0", Offset = "0x81F20C0", VA = "0x1881F34C0")]
		public BitReader SGWEWDFAWOV()
		{
			return default(BitReader);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x81F3450", Offset = "0x81F2050", VA = "0x1881F3450")]
		public void CKSOHTVNDFT([Out] byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x81F34F0", Offset = "0x81F20F0", VA = "0x1881F34F0")]
		public void TOGCCMOHKPY(NativeArray<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3670B70", Offset = "0x366F770", VA = "0x183670B70")]
		public unsafe void TOGCCMOHKPY(byte* a, int b, int c = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3689030", Offset = "0x3687C30", VA = "0x183689030")]
		public void EENMLXFHBNH<T>([Out] T a) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x36892C0", Offset = "0x3687EC0", VA = "0x1836892C0")]
		public void MIFWAETLPJM<T>([Out] T a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3689230", Offset = "0x3687E30", VA = "0x183689230")]
		public void EENMLXFHBNH<T>(NativeArray<T> a) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x36890F0", Offset = "0x3687CF0", VA = "0x1836890F0")]
		public void EENMLXFHBNH<T>(NativeList<T> a, int b) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x81F3480", Offset = "0x81F2080", VA = "0x1881F3480", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class JQKUGXXXVEO
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x81F38F0", Offset = "0x81F24F0", VA = "0x1881F38F0")]
		public static int NYDGMSLLJSR(this FastBufferReader a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x81F3A10", Offset = "0x81F2610", VA = "0x1881F3A10")]
		public static long ZRCRBEUZFZY(this FastBufferReader a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x81F3A00", Offset = "0x81F2600", VA = "0x1881F3A00")]
		public static uint VWZTXPMKTBK(this FastBufferReader a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x81F3950", Offset = "0x81F2550", VA = "0x1881F3950")]
		public static ulong TCKNYWUREXL(this FastBufferReader a)
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
		public int EYPZHMQDKRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x81F36F0", Offset = "0x81F22F0", VA = "0x1881F36F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x81F38B0", Offset = "0x81F24B0", VA = "0x1881F38B0")]
		public FastBufferWriter(int capacity, Allocator allocator)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x81F37E0", Offset = "0x81F23E0", VA = "0x1881F37E0")]
		public bool QMWBYPAHZIM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x81F3840", Offset = "0x81F2440", VA = "0x1881F3840")]
		public BitWriter SGWEWDFAWOV()
		{
			return default(BitWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x81F35D0", Offset = "0x81F21D0", VA = "0x1881F35D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x81F3690", Offset = "0x81F2290", VA = "0x1881F3690")]
		public unsafe byte* LLCEJOQPUXB()
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x81F3620", Offset = "0x81F2220", VA = "0x1881F3620")]
		public void HQVYMTEHLXG(byte a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x81F3750", Offset = "0x81F2350", VA = "0x1881F3750")]
		public void PGNXMZTRYLT(NativeArray<byte> a, int b = -1, int c = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3691570", Offset = "0x3690170", VA = "0x183691570")]
		public void RTUXPIAAZZM<T>([In] T value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3691180", Offset = "0x368FD80", VA = "0x183691180")]
		public void LEIDHZBRIJZ<T>([In] T value, int a) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3691610", Offset = "0x3690210", VA = "0x183691610")]
		public void RTUXPIAAZZM<T>(NativeList<T> a) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x36916D0", Offset = "0x36902D0", VA = "0x1836916D0")]
		public void RTUXPIAAZZM<T>(NativeArray<T> a) where T : struct
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class VGGRHYZBAFY
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x81F3DC0", Offset = "0x81F29C0", VA = "0x1881F3DC0")]
		public static void QXVBQFVSBKA(this FastBufferWriter a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x81F3E30", Offset = "0x81F2A30", VA = "0x1881F3E30")]
		public static void YPISGODZEZP(this FastBufferWriter a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x81F3E20", Offset = "0x81F2A20", VA = "0x1881F3E20")]
		public static void YKGIKKVJICL(this FastBufferWriter a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x81F3CD0", Offset = "0x81F28D0", VA = "0x1881F3CD0")]
		public static void BWRJDHKQJCI(this FastBufferWriter a, ulong b)
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
