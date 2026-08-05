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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE0A40", Offset = "0xADFC40", VA = "0x180AE0A40")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE0A80", Offset = "0xADFC80", VA = "0x180AE0A80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Utils.PrefParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class PPDHYNGGRLB : IYQVSTAWREU<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x88256A0", Offset = "0x88248A0", VA = "0x1888256A0", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x88256D0", Offset = "0x88248D0", VA = "0x1888256D0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8825720", Offset = "0x8824920", VA = "0x188825720")]
		public PPDHYNGGRLB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class KXIMEUELBFQ : IYQVSTAWREU<DateTime>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8824E10", Offset = "0x8824010", VA = "0x188824E10", Slot = "9")]
		public override string Serialize(DateTime input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8824EA0", Offset = "0x88240A0", VA = "0x188824EA0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] DateTime value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8824F40", Offset = "0x8824140", VA = "0x188824F40")]
		public KXIMEUELBFQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class BGTLGYQDTYG<a> : IYQVSTAWREU<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Type VYXTGHITZCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly bool OASWMUKHEJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly a[] KPPPSOCERYO;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x705C0C0", Offset = "0x705B2C0", VA = "0x18705C0C0")]
		[Preserve]
		public BGTLGYQDTYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x705B920", Offset = "0x705AB20", VA = "0x18705B920", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x705BE60", Offset = "0x705B060", VA = "0x18705BE60", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class OWQZJKWPSNX<a> : IYQVSTAWREU<a> where a : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Type VYXTGHITZCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly QFPKHYRJIBL PSWYOKSUBJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly bool OASWMUKHEJO;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5B12BA0", Offset = "0x5B11DA0", VA = "0x185B12BA0")]
		[Preserve]
		public OWQZJKWPSNX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5B12430", Offset = "0x5B11630", VA = "0x185B12430", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5B12640", Offset = "0x5B11840", VA = "0x185B12640", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class MAQWYXVZAUS
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Dictionary<Type, QFPKHYRJIBL> LQROVIPYYRA;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8824F80", Offset = "0x8824180", VA = "0x188824F80")]
		public static QFPKHYRJIBL VEEMOWPOYTE(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class UCDECZWPCNR<a> : IYQVSTAWREU<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3BFF400", Offset = "0x3BFE600", VA = "0x183BFF400", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6267100", Offset = "0x6266300", VA = "0x186267100", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x62672A0", Offset = "0x62664A0", VA = "0x1862672A0")]
		public UCDECZWPCNR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class QNZMWALYGVJ<a, b> : IYQVSTAWREU<a> where a : IEnumerable<b>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly RDLNPBOQBUW<b> UOKTDPEFWRR;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5CBA480", Offset = "0x5CB9680", VA = "0x185CBA480")]
		protected QNZMWALYGVJ(RDLNPBOQBUW<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5CB6D10", Offset = "0x5CB5F10", VA = "0x185CB6D10", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5CB98F0", Offset = "0x5CB8AF0", VA = "0x185CB98F0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract a MRHNHVLTGZG(IEnumerable<b> a);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5CB6920", Offset = "0x5CB5B20", VA = "0x185CB6920", Slot = "12")]
		internal virtual IEnumerable<string> JMGTSDFYKIQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5CB6440", Offset = "0x5CB5640", VA = "0x185CB6440")]
		[CompilerGenerated]
		private string HQGWVNSTZMR(b a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class GBTHTZZCZXH<a> : QNZMWALYGVJ<a[], a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3E6CE30", Offset = "0x3E6C030", VA = "0x183E6CE30")]
		[Preserve]
		public GBTHTZZCZXH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3E6CE70", Offset = "0x3E6C070", VA = "0x183E6CE70")]
		[Preserve]
		public GBTHTZZCZXH(RDLNPBOQBUW<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4EAE920", Offset = "0x4EADB20", VA = "0x184EAE920", Slot = "11")]
		protected override a[] MRHNHVLTGZG(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class XTCYNEPVBKI<a> : QNZMWALYGVJ<List<a>, a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3E6CE30", Offset = "0x3E6C030", VA = "0x183E6CE30")]
		[Preserve]
		public XTCYNEPVBKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3E6CE70", Offset = "0x3E6C070", VA = "0x183E6CE70")]
		[Preserve]
		public XTCYNEPVBKI([Optional] RDLNPBOQBUW<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3E6CA40", Offset = "0x3E6BC40", VA = "0x183E6CA40", Slot = "11")]
		protected override List<a> MRHNHVLTGZG(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class EBYCNVHDIGA<a> : IYQVSTAWREU<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly JsonSerializerSettings? RZWHWJUWZFV;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x46FE290", Offset = "0x46FD490", VA = "0x1846FE290")]
		public EBYCNVHDIGA(JsonSerializerSettings? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x46FDEF0", Offset = "0x46FD0F0", VA = "0x1846FDEF0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x46FE050", Offset = "0x46FD250", VA = "0x1846FE050", Slot = "10")]
		protected override bool TryParseInternal([NotNull] string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class CRKYYQPYDQV : IYQVSTAWREU<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8824A70", Offset = "0x8823C70", VA = "0x188824A70", Slot = "9")]
		public override string Serialize(byte input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8824AD0", Offset = "0x8823CD0", VA = "0x188824AD0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] byte value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8824B60", Offset = "0x8823D60", VA = "0x188824B60")]
		public CRKYYQPYDQV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class RKWBZSETJBL : IYQVSTAWREU<short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8825810", Offset = "0x8824A10", VA = "0x188825810", Slot = "9")]
		public override string Serialize(short input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8825870", Offset = "0x8824A70", VA = "0x188825870", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] short value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8825910", Offset = "0x8824B10", VA = "0x188825910")]
		public RKWBZSETJBL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class IHVYOXKBZHC : IYQVSTAWREU<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8824CD0", Offset = "0x8823ED0", VA = "0x188824CD0", Slot = "9")]
		public override string Serialize(ushort input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8824D30", Offset = "0x8823F30", VA = "0x188824D30", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ushort value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8824DD0", Offset = "0x8823FD0", VA = "0x188824DD0")]
		public IHVYOXKBZHC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class BCUGUEYTGOO : IYQVSTAWREU<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8824800", Offset = "0x8823A00", VA = "0x188824800", Slot = "9")]
		public override string Serialize(int input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8824860", Offset = "0x8823A60", VA = "0x188824860", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x88248F0", Offset = "0x8823AF0", VA = "0x1888248F0")]
		public BCUGUEYTGOO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class DQFRSNKTIFZ : IYQVSTAWREU<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8824BA0", Offset = "0x8823DA0", VA = "0x188824BA0", Slot = "9")]
		public override string Serialize(uint input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8824C00", Offset = "0x8823E00", VA = "0x188824C00", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] uint value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8824C90", Offset = "0x8823E90", VA = "0x188824C90")]
		public DQFRSNKTIFZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class TTJRPZKVBKN : IYQVSTAWREU<long>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8825950", Offset = "0x8824B50", VA = "0x188825950", Slot = "9")]
		public override string Serialize(long input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x88259B0", Offset = "0x8824BB0", VA = "0x1888259B0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] long value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8825A50", Offset = "0x8824C50", VA = "0x188825A50")]
		public TTJRPZKVBKN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class BWUUGDJFCJQ : IYQVSTAWREU<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8824930", Offset = "0x8823B30", VA = "0x188824930", Slot = "9")]
		public override string Serialize(ulong input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8824990", Offset = "0x8823B90", VA = "0x188824990", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ulong value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8824A30", Offset = "0x8823C30", VA = "0x188824A30")]
		public BWUUGDJFCJQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class APWJEISPEUJ : IYQVSTAWREU<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x88246C0", Offset = "0x88238C0", VA = "0x1888246C0", Slot = "9")]
		public override string Serialize(float input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8824730", Offset = "0x8823930", VA = "0x188824730", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x88247C0", Offset = "0x88239C0", VA = "0x1888247C0")]
		public APWJEISPEUJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface QFPKHYRJIBL
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string JAKKDJPEZGP(object a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool FXTWMSOFQSF([CanBeNull] string input, [Out] object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface RDLNPBOQBUW<a> : QFPKHYRJIBL
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool XLHEPGXBSHG([CanBeNull] string input, [Out] a a);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		a JQSDGCHQKHN([CanBeNull] string input, [Optional] a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class IYQVSTAWREU<a> : RDLNPBOQBUW<a>, QFPKHYRJIBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Type LNIARLUZYSE;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5012DD0", Offset = "0x5011FD0", VA = "0x185012DD0")]
		protected IYQVSTAWREU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5012BC0", Offset = "0x5011DC0", VA = "0x185012BC0")]
		private a WVHINDRAYOM(object a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5012780", Offset = "0x5011980", VA = "0x185012780", Slot = "7")]
		public string JAKKDJPEZGP(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5012DB0", Offset = "0x5011FB0", VA = "0x185012DB0", Slot = "5")]
		public bool XLHEPGXBSHG(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool TryParseInternal([NotNull] string input, [Out] a value);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5012B30", Offset = "0x5011D30", VA = "0x185012B30", Slot = "8")]
		private bool PXOSLPRSEQD(string a, [Out] object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5012900", Offset = "0x5011B00", VA = "0x185012900", Slot = "6")]
		public a JQSDGCHQKHN(string a, [Optional] a b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class FHBVCPYPOXD<b>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static RDLNPBOQBUW<b> XTXDOOBWSYJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x4D2FF60", Offset = "0x4D2F160", VA = "0x184D2FF60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x35E82A0", Offset = "0x35E74A0", VA = "0x1835E82A0")]
		public static RDLNPBOQBUW<a> XAGZDTPMQDM<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4D49FC0", Offset = "0x4D491C0", VA = "0x184D49FC0")]
		public static QFPKHYRJIBL XAGZDTPMQDM(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4D3E080", Offset = "0x4D3D280", VA = "0x184D3E080")]
		private static QFPKHYRJIBL KMXGVGYKXJR(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4D46110", Offset = "0x4D45310", VA = "0x184D46110")]
		private static QFPKHYRJIBL VTPXUDNBNYO(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class LZVMDVVCDJK<a> : QNZMWALYGVJ<a, string> where a : IEnumerable<string>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class HGPXKJAVERT : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int HDIOWKWRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private string HVLGGEUBMPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int SQEAAJZHTMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private string GJZURVRHQOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public string FCIHPVOHTKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public LZVMDVVCDJK<a> LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private PooledObject<StringBuilder> CFSSCPABLKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private StringBuilder DRUEWGPGMWM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private bool FHIPUDRYISS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int RGHWUWLGTKT;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private string KUYIZNZFFWL
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xDC8510", Offset = "0xDC7710", VA = "0x180DC8510")]
			[DebuggerHidden]
			public HGPXKJAVERT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x4F14E80", Offset = "0x4F14080", VA = "0x184F14E80", Slot = "7")]
			[DebuggerHidden]
			private void JZSTYLGWFSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x4F14FF0", Offset = "0x4F141F0", VA = "0x184F14FF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4F158F0", Offset = "0x4F14AF0", VA = "0x184F158F0")]
			private void RKOKQQOFJWR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3D9CBF0", Offset = "0x3D9BDF0", VA = "0x183D9CBF0", Slot = "10")]
			[DebuggerHidden]
			private void ZJSIHLTIANO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x4F14C50", Offset = "0x4F13E50", VA = "0x184F14C50", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> ILEQMUNYVSI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x4F14F20", Offset = "0x4F14120", VA = "0x184F14F20", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KRQKAOMZCCF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly bool CLRPBJVDDYP;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x53D6ED0", Offset = "0x53D60D0", VA = "0x1853D6ED0")]
		protected LZVMDVVCDJK(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x53D6BA0", Offset = "0x53D5DA0", VA = "0x1853D6BA0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x53D6750", Offset = "0x53D5950", VA = "0x1853D6750", Slot = "12")]
		[IteratorStateMachine(typeof(LZVMDVVCDJK<>.HGPXKJAVERT))]
		internal override IEnumerable<string> JMGTSDFYKIQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x53D6E50", Offset = "0x53D6050", VA = "0x1853D6E50")]
		[CompilerGenerated]
		internal static string YULTAZYUMKO(StringBuilder a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class ZCZNPCAWFVI : LZVMDVVCDJK<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8825DF0", Offset = "0x8824FF0", VA = "0x188825DF0")]
		[Preserve]
		public ZCZNPCAWFVI(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8825D60", Offset = "0x8824F60", VA = "0x188825D60", Slot = "11")]
		protected override List<string> MRHNHVLTGZG(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class QOQREKTNHGB : LZVMDVVCDJK<string[]>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x88257C0", Offset = "0x88249C0", VA = "0x1888257C0")]
		[Preserve]
		public QOQREKTNHGB(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8825760", Offset = "0x8824960", VA = "0x188825760", Slot = "11")]
		protected override string[] MRHNHVLTGZG(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal class AHSWHRRYHKS : IYQVSTAWREU<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB19E90", Offset = "0xB19090", VA = "0x180B19E90", Slot = "9")]
		public override string Serialize(string input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8824660", Offset = "0x8823860", VA = "0x188824660", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8824680", Offset = "0x8823880", VA = "0x188824680")]
		public AHSWHRRYHKS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class VISFCMHKSNH : IYQVSTAWREU<TimeSpan>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8825A90", Offset = "0x8824C90", VA = "0x188825A90", Slot = "9")]
		public override string Serialize(TimeSpan input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8825BB0", Offset = "0x8824DB0", VA = "0x188825BB0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] TimeSpan value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8825D20", Offset = "0x8824F20", VA = "0x188825D20")]
		public VISFCMHKSNH()
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
