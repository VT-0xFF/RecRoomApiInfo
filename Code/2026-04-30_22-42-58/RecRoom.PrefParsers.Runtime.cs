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
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1EA70", Offset = "0xD1DE70", VA = "0x180D1EA70")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1EAB0", Offset = "0xD1DEB0", VA = "0x180D1EAB0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Utils.PrefParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class PZGPQBERQXP : UDKPKAVGNYS<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9B92A90", Offset = "0x9B91E90", VA = "0x189B92A90", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9B92AC0", Offset = "0x9B91EC0", VA = "0x189B92AC0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9B92B10", Offset = "0x9B91F10", VA = "0x189B92B10")]
		public PZGPQBERQXP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class EEYLHNMQSFC : UDKPKAVGNYS<DateTime>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9B922F0", Offset = "0x9B916F0", VA = "0x189B922F0", Slot = "9")]
		public override string Serialize(DateTime input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9B92380", Offset = "0x9B91780", VA = "0x189B92380", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] DateTime value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9B92420", Offset = "0x9B91820", VA = "0x189B92420")]
		public EEYLHNMQSFC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class AOTASQSQROI<a> : UDKPKAVGNYS<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Type EYTBTFBRZQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly bool JKZVIOWMOMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly a[] CNEXRUBOKSQ;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72677C0", Offset = "0x7266BC0", VA = "0x1872677C0")]
		[Preserve]
		public AOTASQSQROI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72673A0", Offset = "0x72667A0", VA = "0x1872673A0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7267630", Offset = "0x7266A30", VA = "0x187267630", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class UENEYUTSLAP<a> : UDKPKAVGNYS<a> where a : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Type EYTBTFBRZQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly NRAIBALSJLN ISBIJQTGYBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly bool JKZVIOWMOMC;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7D4EDB0", Offset = "0x7D4E1B0", VA = "0x187D4EDB0")]
		[Preserve]
		public UENEYUTSLAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7D4E650", Offset = "0x7D4DA50", VA = "0x187D4E650", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7D4EB60", Offset = "0x7D4DF60", VA = "0x187D4EB60", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class BAEBOOMSVMM
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Dictionary<Type, NRAIBALSJLN> DGOGMYRHKOQ;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9B91AD0", Offset = "0x9B90ED0", VA = "0x189B91AD0")]
		public static NRAIBALSJLN UNQUSCAOTCY(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class EHJVMCYPIVG : UDKPKAVGNYS<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9B92460", Offset = "0x9B91860", VA = "0x189B92460", Slot = "9")]
		public override string Serialize(Guid input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9B924A0", Offset = "0x9B918A0", VA = "0x189B924A0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] Guid value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9B924C0", Offset = "0x9B918C0", VA = "0x189B924C0")]
		public EHJVMCYPIVG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class TQVOUWDSCCR<a> : UDKPKAVGNYS<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4088CE0", Offset = "0x40880E0", VA = "0x184088CE0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7AB9A10", Offset = "0x7AB8E10", VA = "0x187AB9A10", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7AB9C00", Offset = "0x7AB9000", VA = "0x187AB9C00")]
		public TQVOUWDSCCR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public abstract class LHNLQBFVKDD<a, b> : UDKPKAVGNYS<a> where a : IEnumerable<b>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly NFGIDDCCSWQ<b> UEUMULEKIBH;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x689AAC0", Offset = "0x6899EC0", VA = "0x18689AAC0")]
		protected LHNLQBFVKDD(NFGIDDCCSWQ<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6897200", Offset = "0x6896600", VA = "0x186897200", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6897DE0", Offset = "0x68971E0", VA = "0x186897DE0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract a HBQLDGHLUUC(IEnumerable<b> a);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6896B50", Offset = "0x6895F50", VA = "0x186896B50", Slot = "12")]
		internal virtual IEnumerable<string> HRDAFMSODSS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6896550", Offset = "0x6895950", VA = "0x186896550")]
		[CompilerGenerated]
		private string CBAPOCZAUJN(b a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MCFFSAZAYHN<a> : LHNLQBFVKDD<a[], a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F897D0", Offset = "0x6F88BD0", VA = "0x186F897D0")]
		[Preserve]
		public MCFFSAZAYHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6F897F0", Offset = "0x6F88BF0", VA = "0x186F897F0")]
		[Preserve]
		public MCFFSAZAYHN(NFGIDDCCSWQ<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F89650", Offset = "0x6F88A50", VA = "0x186F89650", Slot = "11")]
		protected override a[] HBQLDGHLUUC(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ANWLDAJIYKG<a> : LHNLQBFVKDD<List<a>, a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6F897D0", Offset = "0x6F88BD0", VA = "0x186F897D0")]
		[Preserve]
		public ANWLDAJIYKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6F897F0", Offset = "0x6F88BF0", VA = "0x186F897F0")]
		[Preserve]
		public ANWLDAJIYKG([Optional] NFGIDDCCSWQ<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x725C340", Offset = "0x725B740", VA = "0x18725C340", Slot = "11")]
		protected override List<a> HBQLDGHLUUC(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class YNPEICWLKHI<a> : UDKPKAVGNYS<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly JsonSerializerSettings? MMUIWXOAXNX;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x506E720", Offset = "0x506DB20", VA = "0x18506E720")]
		public YNPEICWLKHI(JsonSerializerSettings? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x506E360", Offset = "0x506D760", VA = "0x18506E360", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x506E4B0", Offset = "0x506D8B0", VA = "0x18506E4B0", Slot = "10")]
		protected override bool TryParseInternal([NotNull] string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class MELTXZKSRWL : UDKPKAVGNYS<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9B92770", Offset = "0x9B91B70", VA = "0x189B92770", Slot = "9")]
		public override string Serialize(byte input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9B927D0", Offset = "0x9B91BD0", VA = "0x189B927D0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] byte value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9B92860", Offset = "0x9B91C60", VA = "0x189B92860")]
		public MELTXZKSRWL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class ZFJWQYZJTZZ : UDKPKAVGNYS<short>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9B931E0", Offset = "0x9B925E0", VA = "0x189B931E0", Slot = "9")]
		public override string Serialize(short input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9B93240", Offset = "0x9B92640", VA = "0x189B93240", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] short value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9B932E0", Offset = "0x9B926E0", VA = "0x189B932E0")]
		public ZFJWQYZJTZZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class XHDIRQKWEYO : UDKPKAVGNYS<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9B930A0", Offset = "0x9B924A0", VA = "0x189B930A0", Slot = "9")]
		public override string Serialize(ushort input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9B93100", Offset = "0x9B92500", VA = "0x189B93100", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ushort value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9B931A0", Offset = "0x9B925A0", VA = "0x189B931A0")]
		public XHDIRQKWEYO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class IRYDZOUUGKM : UDKPKAVGNYS<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9B92640", Offset = "0x9B91A40", VA = "0x189B92640", Slot = "9")]
		public override string Serialize(int input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9B926A0", Offset = "0x9B91AA0", VA = "0x189B926A0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9B92730", Offset = "0x9B91B30", VA = "0x189B92730")]
		public IRYDZOUUGKM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class CRQMDSKDWEF : UDKPKAVGNYS<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9B921C0", Offset = "0x9B915C0", VA = "0x189B921C0", Slot = "9")]
		public override string Serialize(uint input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9B92220", Offset = "0x9B91620", VA = "0x189B92220", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] uint value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9B922B0", Offset = "0x9B916B0", VA = "0x189B922B0")]
		public CRQMDSKDWEF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class RFGWFKLXUHZ : UDKPKAVGNYS<long>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9B92C90", Offset = "0x9B92090", VA = "0x189B92C90", Slot = "9")]
		public override string Serialize(long input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9B92CF0", Offset = "0x9B920F0", VA = "0x189B92CF0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] long value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9B92D90", Offset = "0x9B92190", VA = "0x189B92D90")]
		public RFGWFKLXUHZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class OPDRJIVJXEM : UDKPKAVGNYS<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9B928A0", Offset = "0x9B91CA0", VA = "0x189B928A0", Slot = "9")]
		public override string Serialize(ulong input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9B92900", Offset = "0x9B91D00", VA = "0x189B92900", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ulong value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9B929A0", Offset = "0x9B91DA0", VA = "0x189B929A0")]
		public OPDRJIVJXEM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal class QSIFFSUQUVJ : UDKPKAVGNYS<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9B92B50", Offset = "0x9B91F50", VA = "0x189B92B50", Slot = "9")]
		public override string Serialize(float input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9B92BC0", Offset = "0x9B91FC0", VA = "0x189B92BC0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9B92C50", Offset = "0x9B92050", VA = "0x189B92C50")]
		public QSIFFSUQUVJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface NRAIBALSJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string DURQSJLCUIZ(object a);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool NDIFKEEXMHB([CanBeNull] string input, [Out] object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface NFGIDDCCSWQ<a> : NRAIBALSJLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool SYQOKEJVQMS([CanBeNull] string input, [Out] a a);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "2")]
		a YKKZUNDNKRP([CanBeNull] string input, [Optional] a a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class UDKPKAVGNYS<a> : NFGIDDCCSWQ<a>, NRAIBALSJLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Type OGXKJORFAEW;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7D4E5F0", Offset = "0x7D4D9F0", VA = "0x187D4E5F0")]
		protected UDKPKAVGNYS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7D4DB50", Offset = "0x7D4CF50", VA = "0x187D4DB50")]
		private a NNHFQTFKKFI(object a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7D4CBC0", Offset = "0x7D4BFC0", VA = "0x187D4CBC0", Slot = "7")]
		public string DURQSJLCUIZ(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7D4E060", Offset = "0x7D4D460", VA = "0x187D4E060", Slot = "5")]
		public bool SYQOKEJVQMS(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool TryParseInternal([NotNull] string input, [Out] a value);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7D4D6C0", Offset = "0x7D4CAC0", VA = "0x187D4D6C0", Slot = "8")]
		private bool KEPDIQVLTNX(string a, [Out] object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7D4E290", Offset = "0x7D4D690", VA = "0x187D4E290", Slot = "6")]
		public a YKKZUNDNKRP(string a, [Optional] a b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class TDJXVJMICJV<b>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static NFGIDDCCSWQ<b> AESEIRAUIMD
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5B3BE30", Offset = "0x5B3B230", VA = "0x185B3BE30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x416E810", Offset = "0x416DC10", VA = "0x18416E810")]
		public static NFGIDDCCSWQ<a> EPZXTPUYKFO<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7A884A0", Offset = "0x7A878A0", VA = "0x187A884A0")]
		public static NRAIBALSJLN EPZXTPUYKFO(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7A89F30", Offset = "0x7A89330", VA = "0x187A89F30")]
		private static NRAIBALSJLN QZZMFYVBILD(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CBD0", Offset = "0x7A8BFD0", VA = "0x187A8CBD0")]
		private static NRAIBALSJLN RRPOICJRWCY(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class JZZUBYJQQXM<a> : LHNLQBFVKDD<a, string> where a : IEnumerable<string>
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class PALLXIWVLYT : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private string BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int YTKXRPSSEMX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private string ORZTKEYPIJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public string JIIEMGMSEQF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public JZZUBYJQQXM<a> IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private PooledObject<StringBuilder> ZBXCNKMSQSW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private StringBuilder DBVZOXGKWZI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private bool FONSDDEGPIY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int ZYGJMSXQDCF;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private string KRJYKHHYAMR
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x1021410", Offset = "0x1020810", VA = "0x181021410")]
			[DebuggerHidden]
			public PALLXIWVLYT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x744A7E0", Offset = "0x7449BE0", VA = "0x18744A7E0", Slot = "7")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7449E10", Offset = "0x7449210", VA = "0x187449E10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7449BF0", Offset = "0x7448FF0", VA = "0x187449BF0")]
			private void ALJGYZPBIVB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x4E89280", Offset = "0x4E88680", VA = "0x184E89280", Slot = "10")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7449D50", Offset = "0x7449150", VA = "0x187449D50", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> MFQFCXRZFYC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x744A6A0", Offset = "0x7449AA0", VA = "0x18744A6A0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator SJAOULXGYMP()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly bool GCJBCOCERMN;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x664D150", Offset = "0x664C550", VA = "0x18664D150")]
		protected JZZUBYJQQXM(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x664CC60", Offset = "0x664C060", VA = "0x18664CC60", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x664CBB0", Offset = "0x664BFB0", VA = "0x18664CBB0", Slot = "12")]
		[IteratorStateMachine(typeof(JZZUBYJQQXM<>.PALLXIWVLYT))]
		internal override IEnumerable<string> HRDAFMSODSS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x664CA80", Offset = "0x664BE80", VA = "0x18664CA80")]
		[CompilerGenerated]
		internal static string GRTDUYVFOHO(StringBuilder a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class HIQWKOJHAHG : JZZUBYJQQXM<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9B925F0", Offset = "0x9B919F0", VA = "0x189B925F0")]
		[Preserve]
		public HIQWKOJHAHG(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9B92560", Offset = "0x9B91960", VA = "0x189B92560", Slot = "11")]
		protected override List<string> HBQLDGHLUUC(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class PZCYLQLOVXF : JZZUBYJQQXM<string[]>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9B92A40", Offset = "0x9B91E40", VA = "0x189B92A40")]
		[Preserve]
		public PZCYLQLOVXF(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9B929E0", Offset = "0x9B91DE0", VA = "0x189B929E0", Slot = "11")]
		protected override string[] HBQLDGHLUUC(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class GKGOLUIPZNK : UDKPKAVGNYS<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xD59C20", Offset = "0xD59020", VA = "0x180D59C20", Slot = "9")]
		public override string Serialize(string input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9B92500", Offset = "0x9B91900", VA = "0x189B92500", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9B92520", Offset = "0x9B91920", VA = "0x189B92520")]
		public GKGOLUIPZNK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class SMPHBMFTBSP : UDKPKAVGNYS<TimeSpan>
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9B92DD0", Offset = "0x9B921D0", VA = "0x189B92DD0", Slot = "9")]
		public override string Serialize(TimeSpan input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9B92EF0", Offset = "0x9B922F0", VA = "0x189B92EF0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] TimeSpan value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9B93060", Offset = "0x9B92460", VA = "0x189B93060")]
		public SMPHBMFTBSP()
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
