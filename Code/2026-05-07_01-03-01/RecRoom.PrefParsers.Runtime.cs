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
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFB710", Offset = "0xCFA110", VA = "0x180CFB710")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFB750", Offset = "0xCFA150", VA = "0x180CFB750")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Utils.PrefParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class FEYCVINNNHZ : DCDRIKKOMXS<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F3A0", Offset = "0x9C3DDA0", VA = "0x189C3F3A0", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F3D0", Offset = "0x9C3DDD0", VA = "0x189C3F3D0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F420", Offset = "0x9C3DE20", VA = "0x189C3F420")]
		public FEYCVINNNHZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class IMMZHPACLKG : DCDRIKKOMXS<DateTime>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F590", Offset = "0x9C3DF90", VA = "0x189C3F590", Slot = "9")]
		public override string Serialize(DateTime input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F620", Offset = "0x9C3E020", VA = "0x189C3F620", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] DateTime value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F6C0", Offset = "0x9C3E0C0", VA = "0x189C3F6C0")]
		public IMMZHPACLKG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class EKHSTCCHTFM<a> : DCDRIKKOMXS<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Type ZQLMIRETBBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly bool FKRZHKSTWNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly a[] YAWLLSKDKPE;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5BF4A80", Offset = "0x5BF3480", VA = "0x185BF4A80")]
		[Preserve]
		public EKHSTCCHTFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5BF4300", Offset = "0x5BF2D00", VA = "0x185BF4300", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5BF4820", Offset = "0x5BF3220", VA = "0x185BF4820", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class MDYCQWVFBAF<a> : DCDRIKKOMXS<a> where a : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Type ZQLMIRETBBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly OLHAIIVXHTD IJQNTPMIMDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly bool FKRZHKSTWNG;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F6F5A0", Offset = "0x6F6DFA0", VA = "0x186F6F5A0")]
		[Preserve]
		public MDYCQWVFBAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6F6ED10", Offset = "0x6F6D710", VA = "0x186F6ED10", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F6F210", Offset = "0x6F6DC10", VA = "0x186F6F210", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class RGIELHQREEK
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Dictionary<Type, OLHAIIVXHTD> HVAAQFFLKNA;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9C3FB60", Offset = "0x9C3E560", VA = "0x189C3FB60")]
		public static OLHAIIVXHTD ZPYSPIVTWQK(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class OTMJPAXQESC : DCDRIKKOMXS<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9C3FAC0", Offset = "0x9C3E4C0", VA = "0x189C3FAC0", Slot = "9")]
		public override string Serialize(Guid input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9C3FB00", Offset = "0x9C3E500", VA = "0x189C3FB00", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] Guid value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9C3FB20", Offset = "0x9C3E520", VA = "0x189C3FB20")]
		public OTMJPAXQESC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class CYWUYVMIYCH<a> : DCDRIKKOMXS<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4085210", Offset = "0x4083C10", VA = "0x184085210", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x52160A0", Offset = "0x5214AA0", VA = "0x1852160A0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5216290", Offset = "0x5214C90", VA = "0x185216290")]
		public CYWUYVMIYCH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public abstract class ZDNWDRGJXJN<a, b> : DCDRIKKOMXS<a> where a : IEnumerable<b>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly XMNUSNLGNCS<b> VBUIJVNNBLJ;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5178B20", Offset = "0x5177520", VA = "0x185178B20")]
		protected ZDNWDRGJXJN(XMNUSNLGNCS<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5174D50", Offset = "0x5173750", VA = "0x185174D50", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5177DE0", Offset = "0x51767E0", VA = "0x185177DE0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract a GUIRXEVJQPK(IEnumerable<b> a);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x51745A0", Offset = "0x5172FA0", VA = "0x1851745A0", Slot = "12")]
		internal virtual IEnumerable<string> FZPFMNSQSPC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5178690", Offset = "0x5177090", VA = "0x185178690")]
		[CompilerGenerated]
		private string XJSQURZFPPD(b a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class WOLUHIWFCAJ<a> : ZDNWDRGJXJN<a[], a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F76970", Offset = "0x6F75370", VA = "0x186F76970")]
		[Preserve]
		public WOLUHIWFCAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6F76990", Offset = "0x6F75390", VA = "0x186F76990")]
		[Preserve]
		public WOLUHIWFCAJ(XMNUSNLGNCS<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x85A76D0", Offset = "0x85A60D0", VA = "0x1885A76D0", Slot = "11")]
		protected override a[] GUIRXEVJQPK(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MIDMPWBWWSU<a> : ZDNWDRGJXJN<List<a>, a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6F76970", Offset = "0x6F75370", VA = "0x186F76970")]
		[Preserve]
		public MIDMPWBWWSU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6F76990", Offset = "0x6F75390", VA = "0x186F76990")]
		[Preserve]
		public MIDMPWBWWSU([Optional] XMNUSNLGNCS<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6F76570", Offset = "0x6F74F70", VA = "0x186F76570", Slot = "11")]
		protected override List<a> GUIRXEVJQPK(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class BROAIUIMVEQ<a> : DCDRIKKOMXS<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly JsonSerializerSettings? AUZCZYMOGSX;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4EAF260", Offset = "0x4EADC60", VA = "0x184EAF260")]
		public BROAIUIMVEQ(JsonSerializerSettings? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4EAEEA0", Offset = "0x4EAD8A0", VA = "0x184EAEEA0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4EAF170", Offset = "0x4EADB70", VA = "0x184EAF170", Slot = "10")]
		protected override bool TryParseInternal([NotNull] string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class FYQQAHSXBPX : DCDRIKKOMXS<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F460", Offset = "0x9C3DE60", VA = "0x189C3F460", Slot = "9")]
		public override string Serialize(byte input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F4C0", Offset = "0x9C3DEC0", VA = "0x189C3F4C0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] byte value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F550", Offset = "0x9C3DF50", VA = "0x189C3F550")]
		public FYQQAHSXBPX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class LUTFKCQDIVP : DCDRIKKOMXS<short>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F700", Offset = "0x9C3E100", VA = "0x189C3F700", Slot = "9")]
		public override string Serialize(short input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F760", Offset = "0x9C3E160", VA = "0x189C3F760", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] short value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F800", Offset = "0x9C3E200", VA = "0x189C3F800")]
		public LUTFKCQDIVP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class MWBBZRVNCSI : DCDRIKKOMXS<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F980", Offset = "0x9C3E380", VA = "0x189C3F980", Slot = "9")]
		public override string Serialize(ushort input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F9E0", Offset = "0x9C3E3E0", VA = "0x189C3F9E0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ushort value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9C3FA80", Offset = "0x9C3E480", VA = "0x189C3FA80")]
		public MWBBZRVNCSI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class TZTMAZTDMNI : DCDRIKKOMXS<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9C40500", Offset = "0x9C3EF00", VA = "0x189C40500", Slot = "9")]
		public override string Serialize(int input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9C40560", Offset = "0x9C3EF60", VA = "0x189C40560", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9C405F0", Offset = "0x9C3EFF0", VA = "0x189C405F0")]
		public TZTMAZTDMNI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class WAXDMXHTONZ : DCDRIKKOMXS<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9C40710", Offset = "0x9C3F110", VA = "0x189C40710", Slot = "9")]
		public override string Serialize(uint input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9C40770", Offset = "0x9C3F170", VA = "0x189C40770", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] uint value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9C40800", Offset = "0x9C3F200", VA = "0x189C40800")]
		public WAXDMXHTONZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class TMIMWAGGQYF : DCDRIKKOMXS<long>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9C403C0", Offset = "0x9C3EDC0", VA = "0x189C403C0", Slot = "9")]
		public override string Serialize(long input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9C40420", Offset = "0x9C3EE20", VA = "0x189C40420", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] long value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9C404C0", Offset = "0x9C3EEC0", VA = "0x189C404C0")]
		public TMIMWAGGQYF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class TKXBBLWWDVU : DCDRIKKOMXS<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9C40280", Offset = "0x9C3EC80", VA = "0x189C40280", Slot = "9")]
		public override string Serialize(ulong input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9C402E0", Offset = "0x9C3ECE0", VA = "0x189C402E0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ulong value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9C40380", Offset = "0x9C3ED80", VA = "0x189C40380")]
		public TKXBBLWWDVU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal class LVQSFHYGLDX : DCDRIKKOMXS<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F840", Offset = "0x9C3E240", VA = "0x189C3F840", Slot = "9")]
		public override string Serialize(float input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F8B0", Offset = "0x9C3E2B0", VA = "0x189C3F8B0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F940", Offset = "0x9C3E340", VA = "0x189C3F940")]
		public LVQSFHYGLDX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface OLHAIIVXHTD
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string PTJOKQVQDET(object a);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool NVHKWIKSVEN([CanBeNull] string input, [Out] object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface XMNUSNLGNCS<a> : OLHAIIVXHTD
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CDBQJAFJOGY([CanBeNull] string input, [Out] a a);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "2")]
		a KCLNZMAQWZB([CanBeNull] string input, [Optional] a a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class DCDRIKKOMXS<a> : XMNUSNLGNCS<a>, OLHAIIVXHTD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Type BBAZJZHWZGY;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x547BE50", Offset = "0x547A850", VA = "0x18547BE50")]
		protected DCDRIKKOMXS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x547BAA0", Offset = "0x547A4A0", VA = "0x18547BAA0")]
		private a VGPRWGMOOGM(object a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x547B1C0", Offset = "0x5479BC0", VA = "0x18547B1C0", Slot = "7")]
		public string PTJOKQVQDET(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x547A560", Offset = "0x5478F60", VA = "0x18547A560", Slot = "5")]
		public bool CDBQJAFJOGY(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool TryParseInternal([NotNull] string input, [Out] a value);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x547AF00", Offset = "0x5479900", VA = "0x18547AF00", Slot = "8")]
		private bool MVAZBVNXTHB(string a, [Out] object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x547A790", Offset = "0x5479190", VA = "0x18547A790", Slot = "6")]
		public a KCLNZMAQWZB(string a, [Optional] a b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class XMJEUBXXZGZ<b>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static XMNUSNLGNCS<b> KLCPKUHGTRT
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5091130", Offset = "0x508FB30", VA = "0x185091130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x336D1B0", Offset = "0x336BBB0", VA = "0x18336D1B0")]
		public static XMNUSNLGNCS<a> IZAPWADTWVQ<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x50775E0", Offset = "0x5075FE0", VA = "0x1850775E0")]
		public static OLHAIIVXHTD IZAPWADTWVQ(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5084500", Offset = "0x5082F00", VA = "0x185084500")]
		private static OLHAIIVXHTD PIINHTXKJJR(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5090210", Offset = "0x508EC10", VA = "0x185090210")]
		private static OLHAIIVXHTD QTKUAPPNPMW(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class AOJYDBHTGVG<a> : ZDNWDRGJXJN<a, string> where a : IEnumerable<string>
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class UIOZMXINDSV : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private string AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int TCMGCAWGCHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private string ISPXSEBEUQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public string VYDWPZIGPVZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public AOJYDBHTGVG<a> AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private PooledObject<StringBuilder> SLVRZOISWKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private StringBuilder CZTLQYIKFEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private bool PHKYALCSLKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int OSWLSMKKPOD;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private string VUFSVYKOYVJ
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x1007340", Offset = "0x1005D40", VA = "0x181007340")]
			[DebuggerHidden]
			public UIOZMXINDSV(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7DAF9F0", Offset = "0x7DAE3F0", VA = "0x187DAF9F0", Slot = "7")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7DAFA90", Offset = "0x7DAE490", VA = "0x187DAFA90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7DB0370", Offset = "0x7DAED70", VA = "0x187DB0370")]
			private void SMVYKFBVGYB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x4EAEBC0", Offset = "0x4EAD5C0", VA = "0x184EAEBC0", Slot = "10")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7DB03C0", Offset = "0x7DAEDC0", VA = "0x187DB03C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> WXHIMBXTBKY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7DAF8B0", Offset = "0x7DAE2B0", VA = "0x187DAF8B0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator DKFMUHWUXGJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly bool JZQEDQXRFYP;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7222310", Offset = "0x7220D10", VA = "0x187222310")]
		protected AOJYDBHTGVG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x72220A0", Offset = "0x7220AA0", VA = "0x1872220A0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7221C10", Offset = "0x7220610", VA = "0x187221C10", Slot = "12")]
		[IteratorStateMachine(typeof(AOJYDBHTGVG<>.UIOZMXINDSV))]
		internal override IEnumerable<string> FZPFMNSQSPC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7221D40", Offset = "0x7220740", VA = "0x187221D40")]
		[CompilerGenerated]
		internal static string JGYWZHQELZU(StringBuilder a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class VVDVFDZUKYO : AOJYDBHTGVG<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9C406C0", Offset = "0x9C3F0C0", VA = "0x189C406C0")]
		[Preserve]
		public VVDVFDZUKYO(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9C40630", Offset = "0x9C3F030", VA = "0x189C40630", Slot = "11")]
		protected override List<string> GUIRXEVJQPK(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class DGRJANAVWXD : AOJYDBHTGVG<string[]>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F350", Offset = "0x9C3DD50", VA = "0x189C3F350")]
		[Preserve]
		public DGRJANAVWXD(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F2F0", Offset = "0x9C3DCF0", VA = "0x189C3F2F0", Slot = "11")]
		protected override string[] GUIRXEVJQPK(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class DEGNHCVSHXI : DCDRIKKOMXS<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xD36250", Offset = "0xD34C50", VA = "0x180D36250", Slot = "9")]
		public override string Serialize(string input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F290", Offset = "0x9C3DC90", VA = "0x189C3F290", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F2B0", Offset = "0x9C3DCB0", VA = "0x189C3F2B0")]
		public DEGNHCVSHXI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class YJEDPTZRVTP : DCDRIKKOMXS<TimeSpan>
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9C40840", Offset = "0x9C3F240", VA = "0x189C40840", Slot = "9")]
		public override string Serialize(TimeSpan input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9C40960", Offset = "0x9C3F360", VA = "0x189C40960", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] TimeSpan value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9C40AD0", Offset = "0x9C3F4D0", VA = "0x189C40AD0")]
		public YJEDPTZRVTP()
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
