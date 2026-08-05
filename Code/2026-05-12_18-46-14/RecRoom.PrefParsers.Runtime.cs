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
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34A80", Offset = "0xD33480", VA = "0x180D34A80")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34AC0", Offset = "0xD334C0", VA = "0x180D34AC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D9D5F0", Offset = "0x9D9BFF0", VA = "0x189D9D5F0", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D620", Offset = "0x9D9C020", VA = "0x189D9D620", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D670", Offset = "0x9D9C070", VA = "0x189D9D670")]
		public FEYCVINNNHZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class IMMZHPACLKG : DCDRIKKOMXS<DateTime>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D7E0", Offset = "0x9D9C1E0", VA = "0x189D9D7E0", Slot = "9")]
		public override string Serialize(DateTime input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D870", Offset = "0x9D9C270", VA = "0x189D9D870", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] DateTime value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D910", Offset = "0x9D9C310", VA = "0x189D9D910")]
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
		[Cpp2IlInjected.Address(RVA = "0x5C68400", Offset = "0x5C66E00", VA = "0x185C68400")]
		[Preserve]
		public EKHSTCCHTFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5C67C40", Offset = "0x5C66640", VA = "0x185C67C40", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5C681A0", Offset = "0x5C66BA0", VA = "0x185C681A0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x7064250", Offset = "0x7062C50", VA = "0x187064250")]
		[Preserve]
		public MDYCQWVFBAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x70639A0", Offset = "0x70623A0", VA = "0x1870639A0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7063EC0", Offset = "0x70628C0", VA = "0x187063EC0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D9DDB0", Offset = "0x9D9C7B0", VA = "0x189D9DDB0")]
		public static OLHAIIVXHTD ZPYSPIVTWQK(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class OTMJPAXQESC : DCDRIKKOMXS<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9D9DD10", Offset = "0x9D9C710", VA = "0x189D9DD10", Slot = "9")]
		public override string Serialize(Guid input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9D9DD50", Offset = "0x9D9C750", VA = "0x189D9DD50", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] Guid value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9D9DD70", Offset = "0x9D9C770", VA = "0x189D9DD70")]
		public OTMJPAXQESC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class CYWUYVMIYCH<a> : DCDRIKKOMXS<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x40A87A0", Offset = "0x40A71A0", VA = "0x1840A87A0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x525AB60", Offset = "0x5259560", VA = "0x18525AB60", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x525AD70", Offset = "0x5259770", VA = "0x18525AD70")]
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
		[Cpp2IlInjected.Address(RVA = "0x519AD40", Offset = "0x5199740", VA = "0x18519AD40")]
		protected ZDNWDRGJXJN(XMNUSNLGNCS<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5196E00", Offset = "0x5195800", VA = "0x185196E00", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5199FD0", Offset = "0x51989D0", VA = "0x185199FD0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract a GUIRXEVJQPK(IEnumerable<b> a);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x51965B0", Offset = "0x5194FB0", VA = "0x1851965B0", Slot = "12")]
		internal virtual IEnumerable<string> FZPFMNSQSPC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x519A8A0", Offset = "0x51992A0", VA = "0x18519A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x706BA00", Offset = "0x706A400", VA = "0x18706BA00")]
		[Preserve]
		public WOLUHIWFCAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x706BA20", Offset = "0x706A420", VA = "0x18706BA20")]
		[Preserve]
		public WOLUHIWFCAJ(XMNUSNLGNCS<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8729E90", Offset = "0x8728890", VA = "0x188729E90", Slot = "11")]
		protected override a[] GUIRXEVJQPK(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MIDMPWBWWSU<a> : ZDNWDRGJXJN<List<a>, a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x706BA00", Offset = "0x706A400", VA = "0x18706BA00")]
		[Preserve]
		public MIDMPWBWWSU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x706BA20", Offset = "0x706A420", VA = "0x18706BA20")]
		[Preserve]
		public MIDMPWBWWSU([Optional] XMNUSNLGNCS<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x706B600", Offset = "0x706A000", VA = "0x18706B600", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F02AF0", Offset = "0x4F014F0", VA = "0x184F02AF0")]
		public BROAIUIMVEQ(JsonSerializerSettings? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4F02710", Offset = "0x4F01110", VA = "0x184F02710", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4F02A00", Offset = "0x4F01400", VA = "0x184F02A00", Slot = "10")]
		protected override bool TryParseInternal([NotNull] string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class FYQQAHSXBPX : DCDRIKKOMXS<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D6B0", Offset = "0x9D9C0B0", VA = "0x189D9D6B0", Slot = "9")]
		public override string Serialize(byte input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D710", Offset = "0x9D9C110", VA = "0x189D9D710", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] byte value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D7A0", Offset = "0x9D9C1A0", VA = "0x189D9D7A0")]
		public FYQQAHSXBPX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class LUTFKCQDIVP : DCDRIKKOMXS<short>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D950", Offset = "0x9D9C350", VA = "0x189D9D950", Slot = "9")]
		public override string Serialize(short input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D9B0", Offset = "0x9D9C3B0", VA = "0x189D9D9B0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] short value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9D9DA50", Offset = "0x9D9C450", VA = "0x189D9DA50")]
		public LUTFKCQDIVP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class MWBBZRVNCSI : DCDRIKKOMXS<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9D9DBD0", Offset = "0x9D9C5D0", VA = "0x189D9DBD0", Slot = "9")]
		public override string Serialize(ushort input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9D9DC30", Offset = "0x9D9C630", VA = "0x189D9DC30", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ushort value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9D9DCD0", Offset = "0x9D9C6D0", VA = "0x189D9DCD0")]
		public MWBBZRVNCSI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class TZTMAZTDMNI : DCDRIKKOMXS<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9D9E760", Offset = "0x9D9D160", VA = "0x189D9E760", Slot = "9")]
		public override string Serialize(int input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9D9E7C0", Offset = "0x9D9D1C0", VA = "0x189D9E7C0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9D9E850", Offset = "0x9D9D250", VA = "0x189D9E850")]
		public TZTMAZTDMNI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class WAXDMXHTONZ : DCDRIKKOMXS<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9D9E970", Offset = "0x9D9D370", VA = "0x189D9E970", Slot = "9")]
		public override string Serialize(uint input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9D9E9D0", Offset = "0x9D9D3D0", VA = "0x189D9E9D0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] uint value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9D9EA60", Offset = "0x9D9D460", VA = "0x189D9EA60")]
		public WAXDMXHTONZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class TMIMWAGGQYF : DCDRIKKOMXS<long>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9D9E620", Offset = "0x9D9D020", VA = "0x189D9E620", Slot = "9")]
		public override string Serialize(long input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9D9E680", Offset = "0x9D9D080", VA = "0x189D9E680", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] long value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9D9E720", Offset = "0x9D9D120", VA = "0x189D9E720")]
		public TMIMWAGGQYF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class TKXBBLWWDVU : DCDRIKKOMXS<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9D9E4E0", Offset = "0x9D9CEE0", VA = "0x189D9E4E0", Slot = "9")]
		public override string Serialize(ulong input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9D9E540", Offset = "0x9D9CF40", VA = "0x189D9E540", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ulong value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9D9E5E0", Offset = "0x9D9CFE0", VA = "0x189D9E5E0")]
		public TKXBBLWWDVU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal class LVQSFHYGLDX : DCDRIKKOMXS<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9D9DA90", Offset = "0x9D9C490", VA = "0x189D9DA90", Slot = "9")]
		public override string Serialize(float input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9D9DB00", Offset = "0x9D9C500", VA = "0x189D9DB00", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9D9DB90", Offset = "0x9D9C590", VA = "0x189D9DB90")]
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
		[Cpp2IlInjected.Address(RVA = "0x54D0600", Offset = "0x54CF000", VA = "0x1854D0600")]
		protected DCDRIKKOMXS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x54D0240", Offset = "0x54CEC40", VA = "0x1854D0240")]
		private a VGPRWGMOOGM(object a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x54CF8E0", Offset = "0x54CE2E0", VA = "0x1854CF8E0", Slot = "7")]
		public string PTJOKQVQDET(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x54CEC30", Offset = "0x54CD630", VA = "0x1854CEC30", Slot = "5")]
		public bool CDBQJAFJOGY(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool TryParseInternal([NotNull] string input, [Out] a value);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x54CF600", Offset = "0x54CE000", VA = "0x1854CF600", Slot = "8")]
		private bool MVAZBVNXTHB(string a, [Out] object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x54CEE70", Offset = "0x54CD870", VA = "0x1854CEE70", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x50A6590", Offset = "0x50A4F90", VA = "0x1850A6590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x33848B0", Offset = "0x33832B0", VA = "0x1833848B0")]
		public static XMNUSNLGNCS<a> IZAPWADTWVQ<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x50954A0", Offset = "0x5093EA0", VA = "0x1850954A0")]
		public static OLHAIIVXHTD IZAPWADTWVQ(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x509DD70", Offset = "0x509C770", VA = "0x18509DD70")]
		private static OLHAIIVXHTD PIINHTXKJJR(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x50A5670", Offset = "0x50A4070", VA = "0x1850A5670")]
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
				[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x104AC00", Offset = "0x1049600", VA = "0x18104AC00")]
			[DebuggerHidden]
			public UIOZMXINDSV(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7F015C0", Offset = "0x7EFFFC0", VA = "0x187F015C0", Slot = "7")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7F01660", Offset = "0x7F00060", VA = "0x187F01660", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7F01F60", Offset = "0x7F00960", VA = "0x187F01F60")]
			private void SMVYKFBVGYB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x4EFA810", Offset = "0x4EF9210", VA = "0x184EFA810", Slot = "10")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7F01FB0", Offset = "0x7F009B0", VA = "0x187F01FB0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> WXHIMBXTBKY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7F01450", Offset = "0x7EFFE50", VA = "0x187F01450", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x7353C50", Offset = "0x7352650", VA = "0x187353C50")]
		protected AOJYDBHTGVG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x73539E0", Offset = "0x73523E0", VA = "0x1873539E0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7353530", Offset = "0x7351F30", VA = "0x187353530", Slot = "12")]
		[IteratorStateMachine(typeof(AOJYDBHTGVG<>.UIOZMXINDSV))]
		internal override IEnumerable<string> FZPFMNSQSPC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7353660", Offset = "0x7352060", VA = "0x187353660")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D9E920", Offset = "0x9D9D320", VA = "0x189D9E920")]
		[Preserve]
		public VVDVFDZUKYO(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9D9E890", Offset = "0x9D9D290", VA = "0x189D9E890", Slot = "11")]
		protected override List<string> GUIRXEVJQPK(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class DGRJANAVWXD : AOJYDBHTGVG<string[]>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D5A0", Offset = "0x9D9BFA0", VA = "0x189D9D5A0")]
		[Preserve]
		public DGRJANAVWXD(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D540", Offset = "0x9D9BF40", VA = "0x189D9D540", Slot = "11")]
		protected override string[] GUIRXEVJQPK(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class DEGNHCVSHXI : DCDRIKKOMXS<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xD6F5E0", Offset = "0xD6DFE0", VA = "0x180D6F5E0", Slot = "9")]
		public override string Serialize(string input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D4E0", Offset = "0x9D9BEE0", VA = "0x189D9D4E0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9D9D500", Offset = "0x9D9BF00", VA = "0x189D9D500")]
		public DEGNHCVSHXI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class YJEDPTZRVTP : DCDRIKKOMXS<TimeSpan>
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9D9EAA0", Offset = "0x9D9D4A0", VA = "0x189D9EAA0", Slot = "9")]
		public override string Serialize(TimeSpan input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9D9EBC0", Offset = "0x9D9D5C0", VA = "0x189D9EBC0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] TimeSpan value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9D9ED30", Offset = "0x9D9D730", VA = "0x189D9ED30")]
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
