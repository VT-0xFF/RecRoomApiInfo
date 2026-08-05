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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE8B20", Offset = "0xAE7920", VA = "0x180AE8B20")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE8B60", Offset = "0xAE7960", VA = "0x180AE8B60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Utils.PrefParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class OVWHUMSXDMQ : GXCXYZPRHKT<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8985DD0", Offset = "0x8984BD0", VA = "0x188985DD0", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8985D80", Offset = "0x8984B80", VA = "0x188985D80", Slot = "10")]
		protected override bool FBBQUPAPSVM(string a, [Out] bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8985E00", Offset = "0x8984C00", VA = "0x188985E00")]
		public OVWHUMSXDMQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class ISXPQYJJDSF : GXCXYZPRHKT<DateTime>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8985310", Offset = "0x8984110", VA = "0x188985310", Slot = "9")]
		public override string Serialize(DateTime input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8985270", Offset = "0x8984070", VA = "0x188985270", Slot = "10")]
		protected override bool FBBQUPAPSVM(string a, [Out] DateTime b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x89853A0", Offset = "0x89841A0", VA = "0x1889853A0")]
		public ISXPQYJJDSF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class HRPWBEFCIOZ<a> : GXCXYZPRHKT<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Type RVHFRPFYUEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly bool PDSZPDDEBJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly a[] MIKCMZWBJTT;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x520A450", Offset = "0x5209250", VA = "0x18520A450")]
		[Preserve]
		public HRPWBEFCIOZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5209E20", Offset = "0x5208C20", VA = "0x185209E20", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5209D60", Offset = "0x5208B60", VA = "0x185209D60", Slot = "10")]
		protected override bool FBBQUPAPSVM(string a, [Out] a b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class CQOHYRQIVES<a> : GXCXYZPRHKT<a> where a : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Type RVHFRPFYUEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly RYCZEALOLVS IOLLJERXDDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly bool PDSZPDDEBJP;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x739BC30", Offset = "0x739AA30", VA = "0x18739BC30")]
		[Preserve]
		public CQOHYRQIVES()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x739BA10", Offset = "0x739A810", VA = "0x18739BA10", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x739B680", Offset = "0x739A480", VA = "0x18739B680", Slot = "10")]
		protected override bool FBBQUPAPSVM(string a, [Out] a b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class MAECQQJMCNP
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Dictionary<Type, RYCZEALOLVS> LIVHZKASDVX;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x89853E0", Offset = "0x89841E0", VA = "0x1889853E0")]
		public static RYCZEALOLVS FMYOFUCFFCV(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class WBDTBTALABQ<a> : GXCXYZPRHKT<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x68D2F40", Offset = "0x68D1D40", VA = "0x1868D2F40", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x68D2D60", Offset = "0x68D1B60", VA = "0x1868D2D60", Slot = "10")]
		protected override bool FBBQUPAPSVM(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3FBD920", Offset = "0x3FBC720", VA = "0x183FBD920")]
		public WBDTBTALABQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class KFKPVHRBTWA<a, b> : GXCXYZPRHKT<a> where a : IEnumerable<b>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly ZXDWIEXBMRB<b> LJMUQJMPQHA;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x54BF7A0", Offset = "0x54BE5A0", VA = "0x1854BF7A0")]
		protected KFKPVHRBTWA(ZXDWIEXBMRB<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x54BF6A0", Offset = "0x54BE4A0", VA = "0x1854BF6A0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x54BF1D0", Offset = "0x54BDFD0", VA = "0x1854BF1D0", Slot = "10")]
		protected override bool FBBQUPAPSVM(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract a AXLOBGCYTAP(IEnumerable<b> a);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x54BF770", Offset = "0x54BE570", VA = "0x1854BF770", Slot = "12")]
		internal virtual IEnumerable<string> TVULIYLXWNJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x54BF5E0", Offset = "0x54BE3E0", VA = "0x1854BF5E0")]
		[CompilerGenerated]
		private string MEABELKTFRC(b a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PXHYUDHPITS<a> : KFKPVHRBTWA<a[], a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5D719A0", Offset = "0x5D707A0", VA = "0x185D719A0")]
		[Preserve]
		public PXHYUDHPITS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5D71980", Offset = "0x5D70780", VA = "0x185D71980")]
		[Preserve]
		public PXHYUDHPITS(ZXDWIEXBMRB<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5D715F0", Offset = "0x5D703F0", VA = "0x185D715F0", Slot = "11")]
		protected override a[] AXLOBGCYTAP(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class BWIWYRNGKLN<a> : KFKPVHRBTWA<List<a>, a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5D719A0", Offset = "0x5D707A0", VA = "0x185D719A0")]
		[Preserve]
		public BWIWYRNGKLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5D71980", Offset = "0x5D70780", VA = "0x185D71980")]
		[Preserve]
		public BWIWYRNGKLN([Optional] ZXDWIEXBMRB<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x70F7460", Offset = "0x70F6260", VA = "0x1870F7460", Slot = "11")]
		protected override List<a> AXLOBGCYTAP(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class DSXIBBLMANF<a> : GXCXYZPRHKT<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly JsonSerializerSettings? GCHJCKHZFYU;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x430F8B0", Offset = "0x430E6B0", VA = "0x18430F8B0")]
		public DSXIBBLMANF(JsonSerializerSettings? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x430F750", Offset = "0x430E550", VA = "0x18430F750", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x430F6A0", Offset = "0x430E4A0", VA = "0x18430F6A0", Slot = "10")]
		protected override bool FBBQUPAPSVM([NotNull] string input, [Out] a a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class GHICIIOZIOG : GXCXYZPRHKT<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8984C80", Offset = "0x8983A80", VA = "0x188984C80", Slot = "9")]
		public override string Serialize(byte input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8984BF0", Offset = "0x89839F0", VA = "0x188984BF0", Slot = "10")]
		protected override bool FBBQUPAPSVM(string a, [Out] byte b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8984CE0", Offset = "0x8983AE0", VA = "0x188984CE0")]
		public GHICIIOZIOG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class HGSKDXDAEUI : GXCXYZPRHKT<short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8984DC0", Offset = "0x8983BC0", VA = "0x188984DC0", Slot = "9")]
		public override string Serialize(short input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8984D20", Offset = "0x8983B20", VA = "0x188984D20", Slot = "10")]
		protected override bool FBBQUPAPSVM(string a, [Out] short b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8984E20", Offset = "0x8983C20", VA = "0x188984E20")]
		public HGSKDXDAEUI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class QYGDEXTSBOH : GXCXYZPRHKT<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8985EE0", Offset = "0x8984CE0", VA = "0x188985EE0", Slot = "9")]
		public override string Serialize(ushort input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8985E40", Offset = "0x8984C40", VA = "0x188985E40", Slot = "10")]
		protected override bool FBBQUPAPSVM(string a, [Out] ushort b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8985F40", Offset = "0x8984D40", VA = "0x188985F40")]
		public QYGDEXTSBOH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class RMNYPCQDVBZ : GXCXYZPRHKT<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8986010", Offset = "0x8984E10", VA = "0x188986010", Slot = "9")]
		public override string Serialize(int input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8985F80", Offset = "0x8984D80", VA = "0x188985F80", Slot = "10")]
		protected override bool FBBQUPAPSVM(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8986070", Offset = "0x8984E70", VA = "0x188986070")]
		public RMNYPCQDVBZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class VCUMHHZMMVW : GXCXYZPRHKT<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8986140", Offset = "0x8984F40", VA = "0x188986140", Slot = "9")]
		public override string Serialize(uint input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x89860B0", Offset = "0x8984EB0", VA = "0x1889860B0", Slot = "10")]
		protected override bool FBBQUPAPSVM(string a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x89861A0", Offset = "0x8984FA0", VA = "0x1889861A0")]
		public VCUMHHZMMVW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class NTCPJIWTUTI : GXCXYZPRHKT<long>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8985CE0", Offset = "0x8984AE0", VA = "0x188985CE0", Slot = "9")]
		public override string Serialize(long input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8985C40", Offset = "0x8984A40", VA = "0x188985C40", Slot = "10")]
		protected override bool FBBQUPAPSVM(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8985D40", Offset = "0x8984B40", VA = "0x188985D40")]
		public NTCPJIWTUTI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class IPEHBQGQXHF : GXCXYZPRHKT<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8984F00", Offset = "0x8983D00", VA = "0x188984F00", Slot = "9")]
		public override string Serialize(ulong input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8984E60", Offset = "0x8983C60", VA = "0x188984E60", Slot = "10")]
		protected override bool FBBQUPAPSVM(string a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8984F60", Offset = "0x8983D60", VA = "0x188984F60")]
		public IPEHBQGQXHF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class YNKFONTDHUQ : GXCXYZPRHKT<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8986320", Offset = "0x8985120", VA = "0x188986320", Slot = "9")]
		public override string Serialize(float input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8986290", Offset = "0x8985090", VA = "0x188986290", Slot = "10")]
		protected override bool FBBQUPAPSVM(string a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8986390", Offset = "0x8985190", VA = "0x188986390")]
		public YNKFONTDHUQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface RYCZEALOLVS
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string AXIDAZJXJPG(object a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool UQGDVKKZFMI([CanBeNull] string input, [Out] object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface ZXDWIEXBMRB<a> : RYCZEALOLVS
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool JWCZNXMOHLN([CanBeNull] string input, [Out] a a);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		a BROTXETFDPA([CanBeNull] string input, [Optional] a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class GXCXYZPRHKT<a> : ZXDWIEXBMRB<a>, RYCZEALOLVS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Type NFEIBIXSCBP;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5190730", Offset = "0x518F530", VA = "0x185190730")]
		protected GXCXYZPRHKT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x518F9E0", Offset = "0x518E7E0", VA = "0x18518F9E0")]
		private a EFEVIYFFSVT(object a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x518EFD0", Offset = "0x518DDD0", VA = "0x18518EFD0", Slot = "7")]
		public string AXIDAZJXJPG(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x51906E0", Offset = "0x518F4E0", VA = "0x1851906E0", Slot = "5")]
		public bool JWCZNXMOHLN(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool FBBQUPAPSVM([NotNull] string input, [Out] a a);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5190090", Offset = "0x518EE90", VA = "0x185190090", Slot = "8")]
		private bool GWCMXDZBBBQ(string a, [Out] object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x518F5C0", Offset = "0x518E3C0", VA = "0x18518F5C0", Slot = "6")]
		public a BROTXETFDPA(string a, [Optional] a b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class ZFQDVCPQYSW<b>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static ZXDWIEXBMRB<b> GUTFKAZYITC
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x41252C0", Offset = "0x41240C0", VA = "0x1841252C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x328C290", Offset = "0x328B090", VA = "0x18328C290")]
		public static ZXDWIEXBMRB<a> OVVFPSFDMVN<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x411DCF0", Offset = "0x411CAF0", VA = "0x18411DCF0")]
		public static RYCZEALOLVS OVVFPSFDMVN(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4110F00", Offset = "0x410FD00", VA = "0x184110F00")]
		private static RYCZEALOLVS EHBSAKOTAYQ(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4118D70", Offset = "0x4117B70", VA = "0x184118D70")]
		private static RYCZEALOLVS KDVVXETVCCH(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class IABRQECWCJL<a> : KFKPVHRBTWA<a, string> where a : IEnumerable<string>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class CQTFEIRFMMK : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int YSBBACYODYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private string QSNUDDCEMPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int DQRPPGNAYPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private string WAIDITLKRDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public string VMWONOFNRNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public IABRQECWCJL<a> WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private PooledObject<StringBuilder> VSAAMOZVOSN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private StringBuilder PRUUWUJGDEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private bool YOHABQGWYCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int ZUXDXCLVSEK;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private string OKRCHDZTANI
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private object OXAJVRVSDJL
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xC11E40", Offset = "0xC10C40", VA = "0x180C11E40")]
			[DebuggerHidden]
			public CQTFEIRFMMK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x739BD70", Offset = "0x739AB70", VA = "0x18739BD70", Slot = "7")]
			[DebuggerHidden]
			private void HQYJSAUBZEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x739BE60", Offset = "0x739AC60", VA = "0x18739BE60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x739BE10", Offset = "0x739AC10", VA = "0x18739BE10")]
			private void LKISUJFCFYE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3F770A0", Offset = "0x3F75EA0", VA = "0x183F770A0", Slot = "10")]
			[DebuggerHidden]
			private void EYXYBZSNHNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x739C2B0", Offset = "0x739B0B0", VA = "0x18739C2B0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> RBKDWSRDIQZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x739C370", Offset = "0x739B170", VA = "0x18739C370", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UYQUPSIMXFE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly bool ZCKBIJRTQSY;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x52C6B10", Offset = "0x52C5910", VA = "0x1852C6B10")]
		protected IABRQECWCJL(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x52C6740", Offset = "0x52C5540", VA = "0x1852C6740", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x52C6970", Offset = "0x52C5770", VA = "0x1852C6970", Slot = "12")]
		[IteratorStateMachine(typeof(IABRQECWCJL<>.CQTFEIRFMMK))]
		internal override IEnumerable<string> TVULIYLXWNJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x52C6350", Offset = "0x52C5150", VA = "0x1852C6350")]
		[CompilerGenerated]
		internal static string EBZNLGGXFDR(StringBuilder a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class MVBLEDCDSRX : IABRQECWCJL<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8985B90", Offset = "0x8984990", VA = "0x188985B90")]
		[Preserve]
		public MVBLEDCDSRX(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8985B00", Offset = "0x8984900", VA = "0x188985B00", Slot = "11")]
		protected override List<string> AXLOBGCYTAP(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class XEBLFXUYTAI : IABRQECWCJL<string[]>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8986240", Offset = "0x8985040", VA = "0x188986240")]
		[Preserve]
		public XEBLFXUYTAI(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x89861E0", Offset = "0x8984FE0", VA = "0x1889861E0", Slot = "11")]
		protected override string[] AXLOBGCYTAP(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal class NSCDLNDCESR : GXCXYZPRHKT<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB1EFA0", Offset = "0xB1DDA0", VA = "0x180B1EFA0", Slot = "9")]
		public override string Serialize(string input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8985BE0", Offset = "0x89849E0", VA = "0x188985BE0", Slot = "10")]
		protected override bool FBBQUPAPSVM(string a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8985C00", Offset = "0x8984A00", VA = "0x188985C00")]
		public NSCDLNDCESR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class ISBVTDWSRJM : GXCXYZPRHKT<TimeSpan>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8985110", Offset = "0x8983F10", VA = "0x188985110", Slot = "9")]
		public override string Serialize(TimeSpan input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8984FA0", Offset = "0x8983DA0", VA = "0x188984FA0", Slot = "10")]
		protected override bool FBBQUPAPSVM(string a, [Out] TimeSpan b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8985230", Offset = "0x8984030", VA = "0x188985230")]
		public ISBVTDWSRJM()
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
