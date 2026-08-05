using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using RecRoom.NoEngine.DataStructures.Runtime.Caching;
using UnityEngine.Scripting;

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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD3A120", Offset = "0xD38B20", VA = "0x180D3A120")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3A160", Offset = "0xD38B60", VA = "0x180D3A160")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Utils.PrefParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class FEEBILXGSKK : XSDXOWNJGCN<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4F80", Offset = "0x9DC3980", VA = "0x189DC4F80", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4FB0", Offset = "0x9DC39B0", VA = "0x189DC4FB0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5000", Offset = "0x9DC3A00", VA = "0x189DC5000")]
		public FEEBILXGSKK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class RSRZYYLCOFZ : XSDXOWNJGCN<DateTime>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5440", Offset = "0x9DC3E40", VA = "0x189DC5440", Slot = "9")]
		public override string Serialize(DateTime input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9DC54D0", Offset = "0x9DC3ED0", VA = "0x189DC54D0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] DateTime value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5570", Offset = "0x9DC3F70", VA = "0x189DC5570")]
		public RSRZYYLCOFZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class MHLPDCRKSHV<a> : XSDXOWNJGCN<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Type AZXZVIRNNMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly bool VECSINIWPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly a[] QCPMWTQNNNB;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6FE0B70", Offset = "0x6FDF570", VA = "0x186FE0B70")]
		[Preserve]
		public MHLPDCRKSHV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6FE0530", Offset = "0x6FDEF30", VA = "0x186FE0530", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FE07E0", Offset = "0x6FDF1E0", VA = "0x186FE07E0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class NFYWRNEVIDC<a> : XSDXOWNJGCN<a> where a : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Type AZXZVIRNNMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly ITHBMAFSKCW WXPGWVVLLIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly bool VECSINIWPKP;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7226100", Offset = "0x7224B00", VA = "0x187226100")]
		[Preserve]
		public NFYWRNEVIDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7225970", Offset = "0x7224370", VA = "0x187225970", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7225A50", Offset = "0x7224450", VA = "0x187225A50", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class BZZWBTBGBTF
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Dictionary<Type, ITHBMAFSKCW> DFITGWJSYBN;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9DC41C0", Offset = "0x9DC2BC0", VA = "0x189DC41C0")]
		public static ITHBMAFSKCW KOFOMKDGOQT(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class WVLAEWFWWOL : XSDXOWNJGCN<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9DC59C0", Offset = "0x9DC43C0", VA = "0x189DC59C0", Slot = "9")]
		public override string Serialize(Guid input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5A00", Offset = "0x9DC4400", VA = "0x189DC5A00", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] Guid value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5A20", Offset = "0x9DC4420", VA = "0x189DC5A20")]
		public WVLAEWFWWOL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class DCBEJGKWNUQ<a> : XSDXOWNJGCN<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x40E3370", Offset = "0x40E1D70", VA = "0x1840E3370", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x538D900", Offset = "0x538C300", VA = "0x18538D900", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x538DB10", Offset = "0x538C510", VA = "0x18538DB10")]
		public DCBEJGKWNUQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public abstract class XWZFHIKPTGW<a, b> : XSDXOWNJGCN<a> where a : IEnumerable<b>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly OHSUVITLQCJ<b> QEHODTUTVAI;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x50E8890", Offset = "0x50E7290", VA = "0x1850E8890")]
		protected XWZFHIKPTGW(OHSUVITLQCJ<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x50E4C00", Offset = "0x50E3600", VA = "0x1850E4C00", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x50E7E90", Offset = "0x50E6890", VA = "0x1850E7E90", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract a WECZZWICSBD(IEnumerable<b> a);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x50E47C0", Offset = "0x50E31C0", VA = "0x1850E47C0", Slot = "12")]
		internal virtual IEnumerable<string> SVYRVFQWDZX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x50E4400", Offset = "0x50E2E00", VA = "0x1850E4400")]
		[CompilerGenerated]
		private string RIOMAKRGIZA(b a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class NXFJCXDWJPQ<a> : XWZFHIKPTGW<a[], a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x722C790", Offset = "0x722B190", VA = "0x18722C790")]
		[Preserve]
		public NXFJCXDWJPQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x722C7B0", Offset = "0x722B1B0", VA = "0x18722C7B0")]
		[Preserve]
		public NXFJCXDWJPQ(OHSUVITLQCJ<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x726AB00", Offset = "0x7269500", VA = "0x18726AB00", Slot = "11")]
		protected override a[] WECZZWICSBD(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class NKCQJOSKSAV<a> : XWZFHIKPTGW<List<a>, a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x722C790", Offset = "0x722B190", VA = "0x18722C790")]
		[Preserve]
		public NKCQJOSKSAV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x722C7B0", Offset = "0x722B1B0", VA = "0x18722C7B0")]
		[Preserve]
		public NKCQJOSKSAV([Optional] OHSUVITLQCJ<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x722C0C0", Offset = "0x722AAC0", VA = "0x18722C0C0", Slot = "11")]
		protected override List<a> WECZZWICSBD(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class GVBHCPZYIKN<a> : XSDXOWNJGCN<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly JsonSerializerSettings? BIAFONKPZFE;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x64516F0", Offset = "0x64500F0", VA = "0x1864516F0")]
		public GVBHCPZYIKN(JsonSerializerSettings? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6451310", Offset = "0x644FD10", VA = "0x186451310", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6451470", Offset = "0x644FE70", VA = "0x186451470", Slot = "10")]
		protected override bool TryParseInternal([NotNull] string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class VZPVUWETLKE : XSDXOWNJGCN<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5890", Offset = "0x9DC4290", VA = "0x189DC5890", Slot = "9")]
		public override string Serialize(byte input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9DC58F0", Offset = "0x9DC42F0", VA = "0x189DC58F0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] byte value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5980", Offset = "0x9DC4380", VA = "0x189DC5980")]
		public VZPVUWETLKE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class EZXCHWOMIXI : XSDXOWNJGCN<short>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4E40", Offset = "0x9DC3840", VA = "0x189DC4E40", Slot = "9")]
		public override string Serialize(short input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4EA0", Offset = "0x9DC38A0", VA = "0x189DC4EA0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] short value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4F40", Offset = "0x9DC3940", VA = "0x189DC4F40")]
		public EZXCHWOMIXI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class TZMHAABYVOZ : XSDXOWNJGCN<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9DC56F0", Offset = "0x9DC40F0", VA = "0x189DC56F0", Slot = "9")]
		public override string Serialize(ushort input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5750", Offset = "0x9DC4150", VA = "0x189DC5750", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ushort value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9DC57F0", Offset = "0x9DC41F0", VA = "0x189DC57F0")]
		public TZMHAABYVOZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class DZLWRGVESTX : XSDXOWNJGCN<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4BD0", Offset = "0x9DC35D0", VA = "0x189DC4BD0", Slot = "9")]
		public override string Serialize(int input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4C30", Offset = "0x9DC3630", VA = "0x189DC4C30", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4CC0", Offset = "0x9DC36C0", VA = "0x189DC4CC0")]
		public DZLWRGVESTX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class NCTIYDDBKEK : XSDXOWNJGCN<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5260", Offset = "0x9DC3C60", VA = "0x189DC5260", Slot = "9")]
		public override string Serialize(uint input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9DC52C0", Offset = "0x9DC3CC0", VA = "0x189DC52C0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] uint value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5350", Offset = "0x9DC3D50", VA = "0x189DC5350")]
		public NCTIYDDBKEK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class TXFVESCIXVK : XSDXOWNJGCN<long>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9DC55B0", Offset = "0x9DC3FB0", VA = "0x189DC55B0", Slot = "9")]
		public override string Serialize(long input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5610", Offset = "0x9DC4010", VA = "0x189DC5610", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] long value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9DC56B0", Offset = "0x9DC40B0", VA = "0x189DC56B0")]
		public TXFVESCIXVK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class EXGVNPMORDD : XSDXOWNJGCN<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4D00", Offset = "0x9DC3700", VA = "0x189DC4D00", Slot = "9")]
		public override string Serialize(ulong input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4D60", Offset = "0x9DC3760", VA = "0x189DC4D60", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ulong value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4E00", Offset = "0x9DC3800", VA = "0x189DC4E00")]
		public EXGVNPMORDD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal class HTCCLNZTCYO : XSDXOWNJGCN<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5040", Offset = "0x9DC3A40", VA = "0x189DC5040", Slot = "9")]
		public override string Serialize(float input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9DC50B0", Offset = "0x9DC3AB0", VA = "0x189DC50B0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5140", Offset = "0x9DC3B40", VA = "0x189DC5140")]
		public HTCCLNZTCYO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface ITHBMAFSKCW
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string SCSVBGJZDSC(object a);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool ZONTVYUMGZI([CanBeNull] string input, [Out] object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface OHSUVITLQCJ<a> : ITHBMAFSKCW
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool PPXSQRKLNWN([CanBeNull] string input, [Out] a a);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "2")]
		a WTKCFYLSTVC([CanBeNull] string input, [Optional] a a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class XSDXOWNJGCN<a> : OHSUVITLQCJ<a>, ITHBMAFSKCW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Type ISJZVNIGNMT;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x50DCE70", Offset = "0x50DB870", VA = "0x1850DCE70")]
		protected XSDXOWNJGCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x50DB4C0", Offset = "0x50D9EC0", VA = "0x1850DB4C0")]
		private a JXBDOSVGYEH(object a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x50DC050", Offset = "0x50DAA50", VA = "0x1850DC050", Slot = "7")]
		public string SCSVBGJZDSC(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x50DBA90", Offset = "0x50DA490", VA = "0x1850DBA90", Slot = "5")]
		public bool PPXSQRKLNWN(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool TryParseInternal([NotNull] string input, [Out] a value);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x50DC540", Offset = "0x50DAF40", VA = "0x1850DC540", Slot = "8")]
		private bool TCBENCDRPRS(string a, [Out] object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x50DCC00", Offset = "0x50DB600", VA = "0x1850DCC00", Slot = "6")]
		public a WTKCFYLSTVC(string a, [Optional] a b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class VPHEZYOCAOM<b>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static OHSUVITLQCJ<b> DOFDCVCRMAS
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5C09220", Offset = "0x5C07C20", VA = "0x185C09220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x41B5DF0", Offset = "0x41B47F0", VA = "0x1841B5DF0")]
		public static OHSUVITLQCJ<a> HLATCQIVBYJ<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7FFE6A0", Offset = "0x7FFD0A0", VA = "0x187FFE6A0")]
		public static ITHBMAFSKCW HLATCQIVBYJ(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x800CC20", Offset = "0x800B620", VA = "0x18800CC20")]
		private static ITHBMAFSKCW SRYTIFGCEEC(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8005520", Offset = "0x8003F20", VA = "0x188005520")]
		private static ITHBMAFSKCW RQTFIMUMBJX(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class XMRVCQGPZNJ<a> : XWZFHIKPTGW<a, string> where a : IEnumerable<string>
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class ENALUICQIMU : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private string OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int AYLQLTGRUAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private string QJUYXKIFRRZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public string GDQPWLVZYPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public XMRVCQGPZNJ<a> XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private PooledObject<StringBuilder> KGZXNLETNZV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private StringBuilder UZVPLYDXXDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private bool UWXEPCWZBNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int GQPXNMBDWEU;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private string ALEULOWHDAE
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x1031740", Offset = "0x1030140", VA = "0x181031740")]
			[DebuggerHidden]
			public ENALUICQIMU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x5B9F300", Offset = "0x5B9DD00", VA = "0x185B9F300", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x5B9E9B0", Offset = "0x5B9D3B0", VA = "0x185B9E9B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x5B9F580", Offset = "0x5B9DF80", VA = "0x185B9F580")]
			private void RHNDEQIOOEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x4F23E00", Offset = "0x4F22800", VA = "0x184F23E00", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5B9F470", Offset = "0x5B9DE70", VA = "0x185B9F470", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> RDNWMZXGDML()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5B9F5D0", Offset = "0x5B9DFD0", VA = "0x185B9F5D0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly bool UWFFQLQEJEW;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x50D8140", Offset = "0x50D6B40", VA = "0x1850D8140")]
		protected XMRVCQGPZNJ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x50D7E30", Offset = "0x50D6830", VA = "0x1850D7E30", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x50D79D0", Offset = "0x50D63D0", VA = "0x1850D79D0", Slot = "12")]
		[IteratorStateMachine(typeof(XMRVCQGPZNJ<>.ENALUICQIMU))]
		internal override IEnumerable<string> SVYRVFQWDZX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x50D7950", Offset = "0x50D6350", VA = "0x1850D7950")]
		[CompilerGenerated]
		internal static string NVMYBTYBNBP(StringBuilder a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class KHPEEAEJHHN : XMRVCQGPZNJ<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5210", Offset = "0x9DC3C10", VA = "0x189DC5210")]
		[Preserve]
		public KHPEEAEJHHN(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5180", Offset = "0x9DC3B80", VA = "0x189DC5180", Slot = "11")]
		protected override List<string> WECZZWICSBD(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class NQTGLTGEXEG : XMRVCQGPZNJ<string[]>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9DC53F0", Offset = "0x9DC3DF0", VA = "0x189DC53F0")]
		[Preserve]
		public NQTGLTGEXEG(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5390", Offset = "0x9DC3D90", VA = "0x189DC5390", Slot = "11")]
		protected override string[] WECZZWICSBD(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class VLJISDBRCDF : XSDXOWNJGCN<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xD75D90", Offset = "0xD74790", VA = "0x180D75D90", Slot = "9")]
		public override string Serialize(string input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5830", Offset = "0x9DC4230", VA = "0x189DC5830", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9DC5850", Offset = "0x9DC4250", VA = "0x189DC5850")]
		public VLJISDBRCDF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class DNOYLGSXCWU : XSDXOWNJGCN<TimeSpan>
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4900", Offset = "0x9DC3300", VA = "0x189DC4900", Slot = "9")]
		public override string Serialize(TimeSpan input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4A20", Offset = "0x9DC3420", VA = "0x189DC4A20", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] TimeSpan value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9DC4B90", Offset = "0x9DC3590", VA = "0x189DC4B90")]
		public DNOYLGSXCWU()
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
