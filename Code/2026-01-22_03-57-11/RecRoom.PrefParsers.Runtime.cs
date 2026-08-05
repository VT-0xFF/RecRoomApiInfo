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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7810", Offset = "0xAD6010", VA = "0x180AD7810")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Utils.PrefParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class JBXQAOXLBAU : CNQKQSPMGJN<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86EE450", Offset = "0x86ECC50", VA = "0x1886EE450", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x86EE480", Offset = "0x86ECC80", VA = "0x1886EE480", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x86EE4D0", Offset = "0x86ECCD0", VA = "0x1886EE4D0")]
		public JBXQAOXLBAU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class FTLJGPOLINP : CNQKQSPMGJN<DateTime>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x86EDED0", Offset = "0x86EC6D0", VA = "0x1886EDED0", Slot = "9")]
		public override string Serialize(DateTime input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86EDF60", Offset = "0x86EC760", VA = "0x1886EDF60", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] DateTime value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x86EE000", Offset = "0x86EC800", VA = "0x1886EE000")]
		public FTLJGPOLINP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class TIIGFVHTNJD<a> : CNQKQSPMGJN<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Type DAVATSWRMIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly bool NDZQMXJXWYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly a[] AUPOVBQUABH;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5F9BBD0", Offset = "0x5F9A3D0", VA = "0x185F9BBD0")]
		[Preserve]
		public TIIGFVHTNJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B270", Offset = "0x5F99A70", VA = "0x185F9B270", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B790", Offset = "0x5F99F90", VA = "0x185F9B790", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class YHJSIDCYQNI<a> : CNQKQSPMGJN<a> where a : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Type DAVATSWRMIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly DUXVGDRSDGM LPIJEMBUCFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly bool NDZQMXJXWYR;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3E4A7E0", Offset = "0x3E48FE0", VA = "0x183E4A7E0")]
		[Preserve]
		public YHJSIDCYQNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3E49F40", Offset = "0x3E48740", VA = "0x183E49F40", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3E4A450", Offset = "0x3E48C50", VA = "0x183E4A450", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class RWQXHKXUIZD
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Dictionary<Type, DUXVGDRSDGM> FDDFFDSAHIF;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x86EE5C0", Offset = "0x86ECDC0", VA = "0x1886EE5C0")]
		public static DUXVGDRSDGM ZDFWHJNPYWF(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class KXAORSFMBVA<a> : CNQKQSPMGJN<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3BB0F00", Offset = "0x3BAF700", VA = "0x183BB0F00", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x523BFF0", Offset = "0x523A7F0", VA = "0x18523BFF0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x523C1E0", Offset = "0x523A9E0", VA = "0x18523C1E0")]
		public KXAORSFMBVA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class TRJLVNNFGTW<a, b> : CNQKQSPMGJN<a> where a : IEnumerable<b>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly IWSXLDXORPN<b> RYJUIHQNWUC;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5FACC40", Offset = "0x5FAB440", VA = "0x185FACC40")]
		protected TRJLVNNFGTW(IWSXLDXORPN<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5FAB060", Offset = "0x5FA9860", VA = "0x185FAB060", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5FAB4E0", Offset = "0x5FA9CE0", VA = "0x185FAB4E0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract a PREOTBPCFVB(IEnumerable<b> a);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5FACC10", Offset = "0x5FAB410", VA = "0x185FACC10", Slot = "12")]
		internal virtual IEnumerable<string> XQHRQCQQNFR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5FAAC80", Offset = "0x5FA9480", VA = "0x185FAAC80")]
		[CompilerGenerated]
		private string QFFHCQSCLOM(b a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class XSWNCNKYCAU<a> : TRJLVNNFGTW<a[], a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3E405D0", Offset = "0x3E3EDD0", VA = "0x183E405D0")]
		[Preserve]
		public XSWNCNKYCAU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3E405C0", Offset = "0x3E3EDC0", VA = "0x183E405C0")]
		[Preserve]
		public XSWNCNKYCAU(IWSXLDXORPN<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3E404A0", Offset = "0x3E3ECA0", VA = "0x183E404A0", Slot = "11")]
		protected override a[] PREOTBPCFVB(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class GWTXUWFXFFB<a> : TRJLVNNFGTW<List<a>, a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3E405D0", Offset = "0x3E3EDD0", VA = "0x183E405D0")]
		[Preserve]
		public GWTXUWFXFFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3E405C0", Offset = "0x3E3EDC0", VA = "0x183E405C0")]
		[Preserve]
		public GWTXUWFXFFB([Optional] IWSXLDXORPN<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4EB7820", Offset = "0x4EB6020", VA = "0x184EB7820", Slot = "11")]
		protected override List<a> PREOTBPCFVB(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class TCBUKGBQBXB<a> : CNQKQSPMGJN<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly JsonSerializerSettings? NTOMIGIYDCM;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5F97FC0", Offset = "0x5F967C0", VA = "0x185F97FC0")]
		public TCBUKGBQBXB(JsonSerializerSettings? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5F97C40", Offset = "0x5F96440", VA = "0x185F97C40", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5F97F10", Offset = "0x5F96710", VA = "0x185F97F10", Slot = "10")]
		protected override bool TryParseInternal([NotNull] string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class EGUKJUEIAAG : CNQKQSPMGJN<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x86EDDA0", Offset = "0x86EC5A0", VA = "0x1886EDDA0", Slot = "9")]
		public override string Serialize(byte input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x86EDE00", Offset = "0x86EC600", VA = "0x1886EDE00", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] byte value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x86EDE90", Offset = "0x86EC690", VA = "0x1886EDE90")]
		public EGUKJUEIAAG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class EFNIXWBDGAU : CNQKQSPMGJN<short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x86EDC60", Offset = "0x86EC460", VA = "0x1886EDC60", Slot = "9")]
		public override string Serialize(short input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x86EDCC0", Offset = "0x86EC4C0", VA = "0x1886EDCC0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] short value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x86EDD60", Offset = "0x86EC560", VA = "0x1886EDD60")]
		public EFNIXWBDGAU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class ZMFTIKFDAAD : CNQKQSPMGJN<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x86EF1B0", Offset = "0x86ED9B0", VA = "0x1886EF1B0", Slot = "9")]
		public override string Serialize(ushort input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x86EF210", Offset = "0x86EDA10", VA = "0x1886EF210", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ushort value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x86EF2B0", Offset = "0x86EDAB0", VA = "0x1886EF2B0")]
		public ZMFTIKFDAAD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class VFTYCTTHGRJ : CNQKQSPMGJN<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x86EECD0", Offset = "0x86ED4D0", VA = "0x1886EECD0", Slot = "9")]
		public override string Serialize(int input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x86EED30", Offset = "0x86ED530", VA = "0x1886EED30", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x86EEDC0", Offset = "0x86ED5C0", VA = "0x1886EEDC0")]
		public VFTYCTTHGRJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class HRUFLAAUHTC : CNQKQSPMGJN<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x86EE2C0", Offset = "0x86ECAC0", VA = "0x1886EE2C0", Slot = "9")]
		public override string Serialize(uint input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x86EE320", Offset = "0x86ECB20", VA = "0x1886EE320", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] uint value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x86EE3B0", Offset = "0x86ECBB0", VA = "0x1886EE3B0")]
		public HRUFLAAUHTC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class HQFHUASPHFU : CNQKQSPMGJN<long>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x86EE180", Offset = "0x86EC980", VA = "0x1886EE180", Slot = "9")]
		public override string Serialize(long input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x86EE1E0", Offset = "0x86EC9E0", VA = "0x1886EE1E0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] long value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x86EE280", Offset = "0x86ECA80", VA = "0x1886EE280")]
		public HQFHUASPHFU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class GNKGBWZDCJZ : CNQKQSPMGJN<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x86EE040", Offset = "0x86EC840", VA = "0x1886EE040", Slot = "9")]
		public override string Serialize(ulong input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x86EE0A0", Offset = "0x86EC8A0", VA = "0x1886EE0A0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ulong value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x86EE140", Offset = "0x86EC940", VA = "0x1886EE140")]
		public GNKGBWZDCJZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class CJNNSFWMJVK : CNQKQSPMGJN<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x86EDB20", Offset = "0x86EC320", VA = "0x1886EDB20", Slot = "9")]
		public override string Serialize(float input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x86EDB90", Offset = "0x86EC390", VA = "0x1886EDB90", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x86EDC20", Offset = "0x86EC420", VA = "0x1886EDC20")]
		public CJNNSFWMJVK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface DUXVGDRSDGM
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string YFGHFSABMYE(object a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool QVJEKRPCKVW([CanBeNull] string input, [Out] object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface IWSXLDXORPN<a> : DUXVGDRSDGM
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool OJCDRUUEASX([CanBeNull] string input, [Out] a a);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		a PGXYYDRPUEO([CanBeNull] string input, [Optional] a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class CNQKQSPMGJN<a> : IWSXLDXORPN<a>, DUXVGDRSDGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Type XIDALUDBHBX;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8F10", Offset = "0x3EF7710", VA = "0x183EF8F10")]
		protected CNQKQSPMGJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3EF85A0", Offset = "0x3EF6DA0", VA = "0x183EF85A0")]
		private a XGYFOTQKXAN(object a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8B30", Offset = "0x3EF7330", VA = "0x183EF8B30", Slot = "7")]
		public string YFGHFSABMYE(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7830", Offset = "0x3EF6030", VA = "0x183EF7830", Slot = "5")]
		public bool OJCDRUUEASX(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool TryParseInternal([NotNull] string input, [Out] a value);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3EF7D50", Offset = "0x3EF6550", VA = "0x183EF7D50", Slot = "8")]
		private bool SOWVYWZFIEC(string a, [Out] object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3EF78F0", Offset = "0x3EF60F0", VA = "0x183EF78F0", Slot = "6")]
		public a PGXYYDRPUEO(string a, [Optional] a b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class NLAPZRQNVBA<b>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static IWSXLDXORPN<b> BIGUOPIZRYA
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x4D70B20", Offset = "0x4D6F320", VA = "0x184D70B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3639DB0", Offset = "0x36385B0", VA = "0x183639DB0")]
		public static IWSXLDXORPN<a> CMXAELVWGCX<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5889AC0", Offset = "0x58882C0", VA = "0x185889AC0")]
		public static DUXVGDRSDGM CMXAELVWGCX(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x588BC40", Offset = "0x588A440", VA = "0x18588BC40")]
		private static DUXVGDRSDGM GIMNUQPAPZW(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5887AE0", Offset = "0x58862E0", VA = "0x185887AE0")]
		private static DUXVGDRSDGM BKWIHWTFYGD(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class FINJRCQAKTL<a> : TRJLVNNFGTW<a, string> where a : IEnumerable<string>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class WHILJMSFENE : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private string VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int AWPKGSEYDWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private string WQCWRJIOYHT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public string UJEMLFQEPVC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public FINJRCQAKTL<a> BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private PooledObject<StringBuilder> FZDQPQZQZWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private StringBuilder VAJRFZXHMDX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private bool EAEEYWXCDLX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int BVRIHOEXGUW;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private string YFNFUBIVZOG
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xD7D9E0", Offset = "0xD7C1E0", VA = "0x180D7D9E0")]
			[DebuggerHidden]
			public WHILJMSFENE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x66B5530", Offset = "0x66B3D30", VA = "0x1866B5530", Slot = "7")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x66B50F0", Offset = "0x66B38F0", VA = "0x1866B50F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x66B5650", Offset = "0x66B3E50", VA = "0x1866B5650")]
			private void YQEVNPXUUBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3D66D30", Offset = "0x3D65530", VA = "0x183D66D30", Slot = "10")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x66B4B20", Offset = "0x66B3320", VA = "0x1866B4B20", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> LLBBLQJYWFT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x66B4BE0", Offset = "0x66B33E0", VA = "0x1866B4BE0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator LRASTPXJBWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly bool GLJVLBJQNFK;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4D7CC90", Offset = "0x4D7B490", VA = "0x184D7CC90")]
		protected FINJRCQAKTL(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4D7C910", Offset = "0x4D7B110", VA = "0x184D7C910", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4D7CB30", Offset = "0x4D7B330", VA = "0x184D7CB30", Slot = "12")]
		[IteratorStateMachine(typeof(FINJRCQAKTL<>.WHILJMSFENE))]
		internal override IEnumerable<string> XQHRQCQQNFR(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4D7C540", Offset = "0x4D7AD40", VA = "0x184D7C540")]
		[CompilerGenerated]
		internal static string PWHHRODZXRZ(StringBuilder a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class XGOAIRZJZTD : FINJRCQAKTL<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x86EF160", Offset = "0x86ED960", VA = "0x1886EF160")]
		[Preserve]
		public XGOAIRZJZTD(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x86EF0D0", Offset = "0x86ED8D0", VA = "0x1886EF0D0", Slot = "11")]
		protected override List<string> PREOTBPCFVB(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class QANLJCGBGMQ : FINJRCQAKTL<string[]>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x86EE570", Offset = "0x86ECD70", VA = "0x1886EE570")]
		[Preserve]
		public QANLJCGBGMQ(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x86EE510", Offset = "0x86ECD10", VA = "0x1886EE510", Slot = "11")]
		protected override string[] PREOTBPCFVB(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal class IPASZOEMNRL : CNQKQSPMGJN<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB10420", Offset = "0xB0EC20", VA = "0x180B10420", Slot = "9")]
		public override string Serialize(string input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x86EE3F0", Offset = "0x86ECBF0", VA = "0x1886EE3F0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x86EE410", Offset = "0x86ECC10", VA = "0x1886EE410")]
		public IPASZOEMNRL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class WLERXPXEKIO : CNQKQSPMGJN<TimeSpan>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x86EEE00", Offset = "0x86ED600", VA = "0x1886EEE00", Slot = "9")]
		public override string Serialize(TimeSpan input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x86EEF20", Offset = "0x86ED720", VA = "0x1886EEF20", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] TimeSpan value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x86EF090", Offset = "0x86ED890", VA = "0x1886EF090")]
		public WLERXPXEKIO()
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
