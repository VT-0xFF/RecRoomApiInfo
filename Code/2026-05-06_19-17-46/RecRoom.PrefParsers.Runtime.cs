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
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD007A0", Offset = "0xCFF1A0", VA = "0x180D007A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD007E0", Offset = "0xCFF1E0", VA = "0x180D007E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C674D0", Offset = "0x9C65ED0", VA = "0x189C674D0", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9C67500", Offset = "0x9C65F00", VA = "0x189C67500", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9C67550", Offset = "0x9C65F50", VA = "0x189C67550")]
		public PZGPQBERQXP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class EEYLHNMQSFC : UDKPKAVGNYS<DateTime>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9C66D30", Offset = "0x9C65730", VA = "0x189C66D30", Slot = "9")]
		public override string Serialize(DateTime input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9C66DC0", Offset = "0x9C657C0", VA = "0x189C66DC0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] DateTime value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9C66E60", Offset = "0x9C65860", VA = "0x189C66E60")]
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
		[Cpp2IlInjected.Address(RVA = "0x72F9E00", Offset = "0x72F8800", VA = "0x1872F9E00")]
		[Preserve]
		public AOTASQSQROI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72F99E0", Offset = "0x72F83E0", VA = "0x1872F99E0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72F9C70", Offset = "0x72F8670", VA = "0x1872F9C70", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DF5B40", Offset = "0x7DF4540", VA = "0x187DF5B40")]
		[Preserve]
		public UENEYUTSLAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7DF53F0", Offset = "0x7DF3DF0", VA = "0x187DF53F0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7DF58F0", Offset = "0x7DF42F0", VA = "0x187DF58F0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C664E0", Offset = "0x9C64EE0", VA = "0x189C664E0")]
		public static NRAIBALSJLN UNQUSCAOTCY(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class EHJVMCYPIVG : UDKPKAVGNYS<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9C66EA0", Offset = "0x9C658A0", VA = "0x189C66EA0", Slot = "9")]
		public override string Serialize(Guid input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9C66EE0", Offset = "0x9C658E0", VA = "0x189C66EE0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] Guid value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9C66F00", Offset = "0x9C65900", VA = "0x189C66F00")]
		public EHJVMCYPIVG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class TQVOUWDSCCR<a> : UDKPKAVGNYS<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4093DD0", Offset = "0x40927D0", VA = "0x184093DD0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7B56770", Offset = "0x7B55170", VA = "0x187B56770", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7B56960", Offset = "0x7B55360", VA = "0x187B56960")]
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
		[Cpp2IlInjected.Address(RVA = "0x6927EB0", Offset = "0x69268B0", VA = "0x186927EB0")]
		protected LHNLQBFVKDD(NFGIDDCCSWQ<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6924690", Offset = "0x6923090", VA = "0x186924690", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6925250", Offset = "0x6923C50", VA = "0x186925250", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract a HBQLDGHLUUC(IEnumerable<b> a);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6923FE0", Offset = "0x69229E0", VA = "0x186923FE0", Slot = "12")]
		internal virtual IEnumerable<string> HRDAFMSODSS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x69239E0", Offset = "0x69223E0", VA = "0x1869239E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x701A750", Offset = "0x7019150", VA = "0x18701A750")]
		[Preserve]
		public MCFFSAZAYHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x701A770", Offset = "0x7019170", VA = "0x18701A770")]
		[Preserve]
		public MCFFSAZAYHN(NFGIDDCCSWQ<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x701A5D0", Offset = "0x7018FD0", VA = "0x18701A5D0", Slot = "11")]
		protected override a[] HBQLDGHLUUC(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ANWLDAJIYKG<a> : LHNLQBFVKDD<List<a>, a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x701A750", Offset = "0x7019150", VA = "0x18701A750")]
		[Preserve]
		public ANWLDAJIYKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x701A770", Offset = "0x7019170", VA = "0x18701A770")]
		[Preserve]
		public ANWLDAJIYKG([Optional] NFGIDDCCSWQ<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x72EE920", Offset = "0x72ED320", VA = "0x1872EE920", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x50EEFA0", Offset = "0x50ED9A0", VA = "0x1850EEFA0")]
		public YNPEICWLKHI(JsonSerializerSettings? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x50EEBE0", Offset = "0x50ED5E0", VA = "0x1850EEBE0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x50EED30", Offset = "0x50ED730", VA = "0x1850EED30", Slot = "10")]
		protected override bool TryParseInternal([NotNull] string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class MELTXZKSRWL : UDKPKAVGNYS<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9C671B0", Offset = "0x9C65BB0", VA = "0x189C671B0", Slot = "9")]
		public override string Serialize(byte input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9C67210", Offset = "0x9C65C10", VA = "0x189C67210", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] byte value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9C672A0", Offset = "0x9C65CA0", VA = "0x189C672A0")]
		public MELTXZKSRWL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class ZFJWQYZJTZZ : UDKPKAVGNYS<short>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9C67C20", Offset = "0x9C66620", VA = "0x189C67C20", Slot = "9")]
		public override string Serialize(short input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9C67C80", Offset = "0x9C66680", VA = "0x189C67C80", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] short value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9C67D20", Offset = "0x9C66720", VA = "0x189C67D20")]
		public ZFJWQYZJTZZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class XHDIRQKWEYO : UDKPKAVGNYS<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9C67AE0", Offset = "0x9C664E0", VA = "0x189C67AE0", Slot = "9")]
		public override string Serialize(ushort input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9C67B40", Offset = "0x9C66540", VA = "0x189C67B40", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ushort value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9C67BE0", Offset = "0x9C665E0", VA = "0x189C67BE0")]
		public XHDIRQKWEYO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class IRYDZOUUGKM : UDKPKAVGNYS<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9C67080", Offset = "0x9C65A80", VA = "0x189C67080", Slot = "9")]
		public override string Serialize(int input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9C670E0", Offset = "0x9C65AE0", VA = "0x189C670E0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9C67170", Offset = "0x9C65B70", VA = "0x189C67170")]
		public IRYDZOUUGKM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class CRQMDSKDWEF : UDKPKAVGNYS<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9C66C00", Offset = "0x9C65600", VA = "0x189C66C00", Slot = "9")]
		public override string Serialize(uint input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9C66C60", Offset = "0x9C65660", VA = "0x189C66C60", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] uint value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9C66CF0", Offset = "0x9C656F0", VA = "0x189C66CF0")]
		public CRQMDSKDWEF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class RFGWFKLXUHZ : UDKPKAVGNYS<long>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9C676D0", Offset = "0x9C660D0", VA = "0x189C676D0", Slot = "9")]
		public override string Serialize(long input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9C67730", Offset = "0x9C66130", VA = "0x189C67730", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] long value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9C677D0", Offset = "0x9C661D0", VA = "0x189C677D0")]
		public RFGWFKLXUHZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class OPDRJIVJXEM : UDKPKAVGNYS<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9C672E0", Offset = "0x9C65CE0", VA = "0x189C672E0", Slot = "9")]
		public override string Serialize(ulong input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9C67340", Offset = "0x9C65D40", VA = "0x189C67340", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ulong value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9C673E0", Offset = "0x9C65DE0", VA = "0x189C673E0")]
		public OPDRJIVJXEM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal class QSIFFSUQUVJ : UDKPKAVGNYS<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9C67590", Offset = "0x9C65F90", VA = "0x189C67590", Slot = "9")]
		public override string Serialize(float input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9C67600", Offset = "0x9C66000", VA = "0x189C67600", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9C67690", Offset = "0x9C66090", VA = "0x189C67690")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DF5390", Offset = "0x7DF3D90", VA = "0x187DF5390")]
		protected UDKPKAVGNYS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7DF48F0", Offset = "0x7DF32F0", VA = "0x187DF48F0")]
		private a NNHFQTFKKFI(object a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7DF3960", Offset = "0x7DF2360", VA = "0x187DF3960", Slot = "7")]
		public string DURQSJLCUIZ(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7DF4E00", Offset = "0x7DF3800", VA = "0x187DF4E00", Slot = "5")]
		public bool SYQOKEJVQMS(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool TryParseInternal([NotNull] string input, [Out] a value);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7DF4460", Offset = "0x7DF2E60", VA = "0x187DF4460", Slot = "8")]
		private bool KEPDIQVLTNX(string a, [Out] object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7DF5030", Offset = "0x7DF3A30", VA = "0x187DF5030", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5BC2100", Offset = "0x5BC0B00", VA = "0x185BC2100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x417A230", Offset = "0x4178C30", VA = "0x18417A230")]
		public static NFGIDDCCSWQ<a> EPZXTPUYKFO<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7B24B80", Offset = "0x7B23580", VA = "0x187B24B80")]
		public static NRAIBALSJLN EPZXTPUYKFO(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7B26650", Offset = "0x7B25050", VA = "0x187B26650")]
		private static NRAIBALSJLN QZZMFYVBILD(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7B293B0", Offset = "0x7B27DB0", VA = "0x187B293B0")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x100B6B0", Offset = "0x100A0B0", VA = "0x18100B6B0")]
			[DebuggerHidden]
			public PALLXIWVLYT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x74DEF00", Offset = "0x74DD900", VA = "0x1874DEF00", Slot = "7")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x74DE530", Offset = "0x74DCF30", VA = "0x1874DE530", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x74DE310", Offset = "0x74DCD10", VA = "0x1874DE310")]
			private void ALJGYZPBIVB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x4F08450", Offset = "0x4F06E50", VA = "0x184F08450", Slot = "10")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x74DE470", Offset = "0x74DCE70", VA = "0x1874DE470", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> MFQFCXRZFYC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x74DEDC0", Offset = "0x74DD7C0", VA = "0x1874DEDC0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7680", Offset = "0x66D6080", VA = "0x1866D7680")]
		protected JZZUBYJQQXM(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x66D7170", Offset = "0x66D5B70", VA = "0x1866D7170", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x66D70C0", Offset = "0x66D5AC0", VA = "0x1866D70C0", Slot = "12")]
		[IteratorStateMachine(typeof(JZZUBYJQQXM<>.PALLXIWVLYT))]
		internal override IEnumerable<string> HRDAFMSODSS(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x66D6F90", Offset = "0x66D5990", VA = "0x1866D6F90")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C67030", Offset = "0x9C65A30", VA = "0x189C67030")]
		[Preserve]
		public HIQWKOJHAHG(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9C66FA0", Offset = "0x9C659A0", VA = "0x189C66FA0", Slot = "11")]
		protected override List<string> HBQLDGHLUUC(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class PZCYLQLOVXF : JZZUBYJQQXM<string[]>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9C67480", Offset = "0x9C65E80", VA = "0x189C67480")]
		[Preserve]
		public PZCYLQLOVXF(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9C67420", Offset = "0x9C65E20", VA = "0x189C67420", Slot = "11")]
		protected override string[] HBQLDGHLUUC(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class GKGOLUIPZNK : UDKPKAVGNYS<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xD3BAF0", Offset = "0xD3A4F0", VA = "0x180D3BAF0", Slot = "9")]
		public override string Serialize(string input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9C66F40", Offset = "0x9C65940", VA = "0x189C66F40", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9C66F60", Offset = "0x9C65960", VA = "0x189C66F60")]
		public GKGOLUIPZNK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class SMPHBMFTBSP : UDKPKAVGNYS<TimeSpan>
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9C67810", Offset = "0x9C66210", VA = "0x189C67810", Slot = "9")]
		public override string Serialize(TimeSpan input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9C67930", Offset = "0x9C66330", VA = "0x189C67930", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] TimeSpan value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9C67AA0", Offset = "0x9C664A0", VA = "0x189C67AA0")]
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
