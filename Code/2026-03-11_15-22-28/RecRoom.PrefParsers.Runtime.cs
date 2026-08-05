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
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF5A10", Offset = "0xAF4A10", VA = "0x180AF5A10")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF5A50", Offset = "0xAF4A50", VA = "0x180AF5A50")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Utils.PrefParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class TNJJVUMBJQA : FGOWNLCBRIP<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x88902D0", Offset = "0x888F2D0", VA = "0x1888902D0", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8890300", Offset = "0x888F300", VA = "0x188890300", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8890350", Offset = "0x888F350", VA = "0x188890350")]
		public TNJJVUMBJQA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class KPLCORHENZP : FGOWNLCBRIP<DateTime>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x888FA80", Offset = "0x888EA80", VA = "0x18888FA80", Slot = "9")]
		public override string Serialize(DateTime input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x888FB10", Offset = "0x888EB10", VA = "0x18888FB10", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] DateTime value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x888FBB0", Offset = "0x888EBB0", VA = "0x18888FBB0")]
		public KPLCORHENZP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class TFRVHSFMMKB<a> : FGOWNLCBRIP<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Type USGZPJKHZCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly bool KGQURNVMYRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly a[] UGVWVNIQPZH;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x61D3200", Offset = "0x61D2200", VA = "0x1861D3200")]
		[Preserve]
		public TFRVHSFMMKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x61D2DC0", Offset = "0x61D1DC0", VA = "0x1861D2DC0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x61D3070", Offset = "0x61D2070", VA = "0x1861D3070", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class WBCOWRJALLU<a> : FGOWNLCBRIP<a> where a : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Type USGZPJKHZCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly NLAAZGUIJME BWIJFIBYYUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly bool KGQURNVMYRD;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x68612A0", Offset = "0x68602A0", VA = "0x1868612A0")]
		[Preserve]
		public WBCOWRJALLU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6860C60", Offset = "0x685FC60", VA = "0x186860C60", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6860D40", Offset = "0x685FD40", VA = "0x186860D40", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class FXCTVQAWKNP
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Dictionary<Type, NLAAZGUIJME> VOJTRRYYNNP;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x888F360", Offset = "0x888E360", VA = "0x18888F360")]
		public static NLAAZGUIJME BSFZDYIWMSR(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class NCTEOAAYQLE<a> : FGOWNLCBRIP<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3C153A0", Offset = "0x3C143A0", VA = "0x183C153A0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5B032E0", Offset = "0x5B022E0", VA = "0x185B032E0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5B03390", Offset = "0x5B02390", VA = "0x185B03390")]
		public NCTEOAAYQLE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class CGAWBJSTEII<a, b> : FGOWNLCBRIP<a> where a : IEnumerable<b>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly SAUETGUVVDZ<b> JNXJMFUXPES;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3EC5470", Offset = "0x3EC4470", VA = "0x183EC5470")]
		protected CGAWBJSTEII(SAUETGUVVDZ<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3EC1B50", Offset = "0x3EC0B50", VA = "0x183EC1B50", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3EC2AF0", Offset = "0x3EC1AF0", VA = "0x183EC2AF0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract a EKEFUNYXBNN(IEnumerable<b> a);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3EC1230", Offset = "0x3EC0230", VA = "0x183EC1230", Slot = "12")]
		internal virtual IEnumerable<string> CEGDBOFQKGH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3EC1310", Offset = "0x3EC0310", VA = "0x183EC1310")]
		[CompilerGenerated]
		private string OZAKGLNLCXC(b a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AMOYBNKSLAM<a> : CGAWBJSTEII<a[], a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x51898D0", Offset = "0x51888D0", VA = "0x1851898D0")]
		[Preserve]
		public AMOYBNKSLAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x51898F0", Offset = "0x51888F0", VA = "0x1851898F0")]
		[Preserve]
		public AMOYBNKSLAM(SAUETGUVVDZ<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x58B5AD0", Offset = "0x58B4AD0", VA = "0x1858B5AD0", Slot = "11")]
		protected override a[] EKEFUNYXBNN(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IJXYMBYBXFN<a> : CGAWBJSTEII<List<a>, a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x51898D0", Offset = "0x51888D0", VA = "0x1851898D0")]
		[Preserve]
		public IJXYMBYBXFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x51898F0", Offset = "0x51888F0", VA = "0x1851898F0")]
		[Preserve]
		public IJXYMBYBXFN([Optional] SAUETGUVVDZ<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5189440", Offset = "0x5188440", VA = "0x185189440", Slot = "11")]
		protected override List<a> EKEFUNYXBNN(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class RPLDZSOFWGL<a> : FGOWNLCBRIP<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly JsonSerializerSettings? STAXQFKEOKU;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5E8CEC0", Offset = "0x5E8BEC0", VA = "0x185E8CEC0")]
		public RPLDZSOFWGL(JsonSerializerSettings? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5E8CC20", Offset = "0x5E8BC20", VA = "0x185E8CC20", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5E8CE10", Offset = "0x5E8BE10", VA = "0x185E8CE10", Slot = "10")]
		protected override bool TryParseInternal([NotNull] string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class CUTFSYFDNNM : FGOWNLCBRIP<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x888F230", Offset = "0x888E230", VA = "0x18888F230", Slot = "9")]
		public override string Serialize(byte input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x888F290", Offset = "0x888E290", VA = "0x18888F290", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] byte value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x888F320", Offset = "0x888E320", VA = "0x18888F320")]
		public CUTFSYFDNNM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class SNNCJSOYWII : FGOWNLCBRIP<short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8890130", Offset = "0x888F130", VA = "0x188890130", Slot = "9")]
		public override string Serialize(short input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8890190", Offset = "0x888F190", VA = "0x188890190", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] short value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8890230", Offset = "0x888F230", VA = "0x188890230")]
		public SNNCJSOYWII()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class KSKYOMIJNFZ : FGOWNLCBRIP<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x888FBF0", Offset = "0x888EBF0", VA = "0x18888FBF0", Slot = "9")]
		public override string Serialize(ushort input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x888FC50", Offset = "0x888EC50", VA = "0x18888FC50", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ushort value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x888FCF0", Offset = "0x888ECF0", VA = "0x18888FCF0")]
		public KSKYOMIJNFZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class TPWGWGIMABF : FGOWNLCBRIP<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8890390", Offset = "0x888F390", VA = "0x188890390", Slot = "9")]
		public override string Serialize(int input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x88903F0", Offset = "0x888F3F0", VA = "0x1888903F0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8890480", Offset = "0x888F480", VA = "0x188890480")]
		public TPWGWGIMABF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class MBVWFOXJVKI : FGOWNLCBRIP<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x888FE70", Offset = "0x888EE70", VA = "0x18888FE70", Slot = "9")]
		public override string Serialize(uint input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x888FED0", Offset = "0x888EED0", VA = "0x18888FED0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] uint value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x888FF60", Offset = "0x888EF60", VA = "0x18888FF60")]
		public MBVWFOXJVKI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class AGWMZZWNKDA : FGOWNLCBRIP<long>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x888F0F0", Offset = "0x888E0F0", VA = "0x18888F0F0", Slot = "9")]
		public override string Serialize(long input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x888F150", Offset = "0x888E150", VA = "0x18888F150", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] long value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x888F1F0", Offset = "0x888E1F0", VA = "0x18888F1F0")]
		public AGWMZZWNKDA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class UEQMQEBIHVJ : FGOWNLCBRIP<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x88904C0", Offset = "0x888F4C0", VA = "0x1888904C0", Slot = "9")]
		public override string Serialize(ulong input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8890520", Offset = "0x888F520", VA = "0x188890520", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ulong value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x88905C0", Offset = "0x888F5C0", VA = "0x1888905C0")]
		public UEQMQEBIHVJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class LEZYTRCHQLG : FGOWNLCBRIP<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x888FD30", Offset = "0x888ED30", VA = "0x18888FD30", Slot = "9")]
		public override string Serialize(float input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x888FDA0", Offset = "0x888EDA0", VA = "0x18888FDA0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x888FE30", Offset = "0x888EE30", VA = "0x18888FE30")]
		public LEZYTRCHQLG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface NLAAZGUIJME
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string JBOWDLZCIUQ(object a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool VWZRERZORPS([CanBeNull] string input, [Out] object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface SAUETGUVVDZ<a> : NLAAZGUIJME
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool FMGGDPLVGDZ([CanBeNull] string input, [Out] a a);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		a CTTOYTVXFKK([CanBeNull] string input, [Optional] a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class FGOWNLCBRIP<a> : SAUETGUVVDZ<a>, NLAAZGUIJME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Type ECJOHRDVOTT;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4F0D860", Offset = "0x4F0C860", VA = "0x184F0D860")]
		protected FGOWNLCBRIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4F0D230", Offset = "0x4F0C230", VA = "0x184F0D230")]
		private a XWSTSBOTBSF(object a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4F0CB50", Offset = "0x4F0BB50", VA = "0x184F0CB50", Slot = "7")]
		public string JBOWDLZCIUQ(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4F0C410", Offset = "0x4F0B410", VA = "0x184F0C410", Slot = "5")]
		public bool FMGGDPLVGDZ(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool TryParseInternal([NotNull] string input, [Out] a value);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4F0CE80", Offset = "0x4F0BE80", VA = "0x184F0CE80", Slot = "8")]
		private bool TOXCXBARJVY(string a, [Out] object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4F0C250", Offset = "0x4F0B250", VA = "0x184F0C250", Slot = "6")]
		public a CTTOYTVXFKK(string a, [Optional] a b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class CELHWSZTIOG<b>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static SAUETGUVVDZ<b> GOGYEQDLKEI
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3E7F220", Offset = "0x3E7E220", VA = "0x183E7F220")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3482F40", Offset = "0x3481F40", VA = "0x183482F40")]
		public static SAUETGUVVDZ<a> HTZDTECZXWH<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3E78E30", Offset = "0x3E77E30", VA = "0x183E78E30")]
		public static NLAAZGUIJME HTZDTECZXWH(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3E70890", Offset = "0x3E6F890", VA = "0x183E70890")]
		private static NLAAZGUIJME GEEOFLMYUAI(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C580", Offset = "0x3E7B580", VA = "0x183E7C580")]
		private static NLAAZGUIJME KRFOSHCOOEL(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class HYDFUGVLSIN<a> : CGAWBJSTEII<a, string> where a : IEnumerable<string>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class BOQPPOISLZE : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private string GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int CYUNKNWTKTU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private string XLBVCBEIAWZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public string MCHIKJCJKLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public HYDFUGVLSIN<a> SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private PooledObject<StringBuilder> VVAAORTICER;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private StringBuilder UYOHEIDCQTT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private bool ETAXTPCCENT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int RSJNPUBUHBM;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private string IGNDDUPMRQO
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xD9D550", Offset = "0xD9C550", VA = "0x180D9D550")]
			[DebuggerHidden]
			public BOQPPOISLZE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3D53B20", Offset = "0x3D52B20", VA = "0x183D53B20", Slot = "7")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x3D53CC0", Offset = "0x3D52CC0", VA = "0x183D53CC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x3D54570", Offset = "0x3D53570", VA = "0x183D54570")]
			private void QJEWXGNEXZS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3D47630", Offset = "0x3D46630", VA = "0x183D47630", Slot = "10")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x3D546E0", Offset = "0x3D536E0", VA = "0x183D546E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> SZHOQXVBNDH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x3D53BC0", Offset = "0x3D52BC0", VA = "0x183D53BC0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator HKYUJZELIWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly bool MKXUXGGRPMY;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x50C4BF0", Offset = "0x50C3BF0", VA = "0x1850C4BF0")]
		protected HYDFUGVLSIN(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x50C49C0", Offset = "0x50C39C0", VA = "0x1850C49C0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x50C4520", Offset = "0x50C3520", VA = "0x1850C4520", Slot = "12")]
		[IteratorStateMachine(typeof(HYDFUGVLSIN<>.BOQPPOISLZE))]
		internal override IEnumerable<string> CEGDBOFQKGH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x50C45D0", Offset = "0x50C35D0", VA = "0x1850C45D0")]
		[CompilerGenerated]
		internal static string ROYJMVLHKBB(StringBuilder a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class QCJJCUKSOPD : HYDFUGVLSIN<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x88900E0", Offset = "0x888F0E0", VA = "0x1888900E0")]
		[Preserve]
		public QCJJCUKSOPD(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8890050", Offset = "0x888F050", VA = "0x188890050", Slot = "11")]
		protected override List<string> EKEFUNYXBNN(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class NWAPUTSSXIY : HYDFUGVLSIN<string[]>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8890000", Offset = "0x888F000", VA = "0x188890000")]
		[Preserve]
		public NWAPUTSSXIY(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x888FFA0", Offset = "0x888EFA0", VA = "0x18888FFA0", Slot = "11")]
		protected override string[] EKEFUNYXBNN(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal class TMDWFNXDEKZ : FGOWNLCBRIP<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB310D0", Offset = "0xB300D0", VA = "0x180B310D0", Slot = "9")]
		public override string Serialize(string input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8890270", Offset = "0x888F270", VA = "0x188890270", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8890290", Offset = "0x888F290", VA = "0x188890290")]
		public TMDWFNXDEKZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class AGILRRUOCLU : FGOWNLCBRIP<TimeSpan>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x888EE20", Offset = "0x888DE20", VA = "0x18888EE20", Slot = "9")]
		public override string Serialize(TimeSpan input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x888EF40", Offset = "0x888DF40", VA = "0x18888EF40", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] TimeSpan value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x888F0B0", Offset = "0x888E0B0", VA = "0x18888F0B0")]
		public AGILRRUOCLU()
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
