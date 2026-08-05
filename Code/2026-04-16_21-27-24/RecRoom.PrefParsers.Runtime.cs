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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD10080", Offset = "0xD0EE80", VA = "0x180D10080")]
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
		[Cpp2IlInjected.Address(RVA = "0xD100C0", Offset = "0xD0EEC0", VA = "0x180D100C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C41F30", Offset = "0x9C40D30", VA = "0x189C41F30", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9C41F60", Offset = "0x9C40D60", VA = "0x189C41F60", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9C41FB0", Offset = "0x9C40DB0", VA = "0x189C41FB0")]
		public FEEBILXGSKK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class RSRZYYLCOFZ : XSDXOWNJGCN<DateTime>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9C423F0", Offset = "0x9C411F0", VA = "0x189C423F0", Slot = "9")]
		public override string Serialize(DateTime input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9C42480", Offset = "0x9C41280", VA = "0x189C42480", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] DateTime value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9C42520", Offset = "0x9C41320", VA = "0x189C42520")]
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
		[Cpp2IlInjected.Address(RVA = "0x6ED40D0", Offset = "0x6ED2ED0", VA = "0x186ED40D0")]
		[Preserve]
		public MHLPDCRKSHV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3AD0", Offset = "0x6ED28D0", VA = "0x186ED3AD0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6ED3D60", Offset = "0x6ED2B60", VA = "0x186ED3D60", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x7108440", Offset = "0x7107240", VA = "0x187108440")]
		[Preserve]
		public NFYWRNEVIDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7107CD0", Offset = "0x7106AD0", VA = "0x187107CD0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7107DA0", Offset = "0x7106BA0", VA = "0x187107DA0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C411A0", Offset = "0x9C3FFA0", VA = "0x189C411A0")]
		public static ITHBMAFSKCW KOFOMKDGOQT(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class DCBEJGKWNUQ<a> : XSDXOWNJGCN<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4092990", Offset = "0x4091790", VA = "0x184092990", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5329BF0", Offset = "0x53289F0", VA = "0x185329BF0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5329DE0", Offset = "0x5328BE0", VA = "0x185329DE0")]
		public DCBEJGKWNUQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class XWZFHIKPTGW<a, b> : XSDXOWNJGCN<a> where a : IEnumerable<b>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly OHSUVITLQCJ<b> QEHODTUTVAI;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5091E70", Offset = "0x5090C70", VA = "0x185091E70")]
		protected XWZFHIKPTGW(OHSUVITLQCJ<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x508E7F0", Offset = "0x508D5F0", VA = "0x18508E7F0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x50914A0", Offset = "0x50902A0", VA = "0x1850914A0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract a WECZZWICSBD(IEnumerable<b> a);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x508E400", Offset = "0x508D200", VA = "0x18508E400", Slot = "12")]
		internal virtual IEnumerable<string> SVYRVFQWDZX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x508E140", Offset = "0x508CF40", VA = "0x18508E140")]
		[CompilerGenerated]
		private string RIOMAKRGIZA(b a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class NXFJCXDWJPQ<a> : XWZFHIKPTGW<a[], a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x710E760", Offset = "0x710D560", VA = "0x18710E760")]
		[Preserve]
		public NXFJCXDWJPQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x710E780", Offset = "0x710D580", VA = "0x18710E780")]
		[Preserve]
		public NXFJCXDWJPQ(OHSUVITLQCJ<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x714AAE0", Offset = "0x71498E0", VA = "0x18714AAE0", Slot = "11")]
		protected override a[] WECZZWICSBD(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class NKCQJOSKSAV<a> : XWZFHIKPTGW<List<a>, a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x710E760", Offset = "0x710D560", VA = "0x18710E760")]
		[Preserve]
		public NKCQJOSKSAV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x710E780", Offset = "0x710D580", VA = "0x18710E780")]
		[Preserve]
		public NKCQJOSKSAV([Optional] OHSUVITLQCJ<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x710E120", Offset = "0x710CF20", VA = "0x18710E120", Slot = "11")]
		protected override List<a> WECZZWICSBD(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class GVBHCPZYIKN<a> : XSDXOWNJGCN<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly JsonSerializerSettings? BIAFONKPZFE;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6391000", Offset = "0x638FE00", VA = "0x186391000")]
		public GVBHCPZYIKN(JsonSerializerSettings? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6390C40", Offset = "0x638FA40", VA = "0x186390C40", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6390D90", Offset = "0x638FB90", VA = "0x186390D90", Slot = "10")]
		protected override bool TryParseInternal([NotNull] string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class VZPVUWETLKE : XSDXOWNJGCN<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9C42840", Offset = "0x9C41640", VA = "0x189C42840", Slot = "9")]
		public override string Serialize(byte input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9C428A0", Offset = "0x9C416A0", VA = "0x189C428A0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] byte value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9C42930", Offset = "0x9C41730", VA = "0x189C42930")]
		public VZPVUWETLKE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class EZXCHWOMIXI : XSDXOWNJGCN<short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9C41DF0", Offset = "0x9C40BF0", VA = "0x189C41DF0", Slot = "9")]
		public override string Serialize(short input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9C41E50", Offset = "0x9C40C50", VA = "0x189C41E50", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] short value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9C41EF0", Offset = "0x9C40CF0", VA = "0x189C41EF0")]
		public EZXCHWOMIXI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class TZMHAABYVOZ : XSDXOWNJGCN<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9C426A0", Offset = "0x9C414A0", VA = "0x189C426A0", Slot = "9")]
		public override string Serialize(ushort input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9C42700", Offset = "0x9C41500", VA = "0x189C42700", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ushort value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9C427A0", Offset = "0x9C415A0", VA = "0x189C427A0")]
		public TZMHAABYVOZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class DZLWRGVESTX : XSDXOWNJGCN<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9C41B80", Offset = "0x9C40980", VA = "0x189C41B80", Slot = "9")]
		public override string Serialize(int input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9C41BE0", Offset = "0x9C409E0", VA = "0x189C41BE0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9C41C70", Offset = "0x9C40A70", VA = "0x189C41C70")]
		public DZLWRGVESTX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class NCTIYDDBKEK : XSDXOWNJGCN<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9C42210", Offset = "0x9C41010", VA = "0x189C42210", Slot = "9")]
		public override string Serialize(uint input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9C42270", Offset = "0x9C41070", VA = "0x189C42270", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] uint value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9C42300", Offset = "0x9C41100", VA = "0x189C42300")]
		public NCTIYDDBKEK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class TXFVESCIXVK : XSDXOWNJGCN<long>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9C42560", Offset = "0x9C41360", VA = "0x189C42560", Slot = "9")]
		public override string Serialize(long input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9C425C0", Offset = "0x9C413C0", VA = "0x189C425C0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] long value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9C42660", Offset = "0x9C41460", VA = "0x189C42660")]
		public TXFVESCIXVK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class EXGVNPMORDD : XSDXOWNJGCN<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9C41CB0", Offset = "0x9C40AB0", VA = "0x189C41CB0", Slot = "9")]
		public override string Serialize(ulong input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9C41D10", Offset = "0x9C40B10", VA = "0x189C41D10", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ulong value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9C41DB0", Offset = "0x9C40BB0", VA = "0x189C41DB0")]
		public EXGVNPMORDD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class HTCCLNZTCYO : XSDXOWNJGCN<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9C41FF0", Offset = "0x9C40DF0", VA = "0x189C41FF0", Slot = "9")]
		public override string Serialize(float input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9C42060", Offset = "0x9C40E60", VA = "0x189C42060", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9C420F0", Offset = "0x9C40EF0", VA = "0x189C420F0")]
		public HTCCLNZTCYO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface ITHBMAFSKCW
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string SCSVBGJZDSC(object a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool ZONTVYUMGZI([CanBeNull] string input, [Out] object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface OHSUVITLQCJ<a> : ITHBMAFSKCW
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool PPXSQRKLNWN([CanBeNull] string input, [Out] a a);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		a WTKCFYLSTVC([CanBeNull] string input, [Optional] a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class XSDXOWNJGCN<a> : OHSUVITLQCJ<a>, ITHBMAFSKCW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Type ISJZVNIGNMT;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5087360", Offset = "0x5086160", VA = "0x185087360")]
		protected XSDXOWNJGCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5085D30", Offset = "0x5084B30", VA = "0x185085D30")]
		private a JXBDOSVGYEH(object a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x50866A0", Offset = "0x50854A0", VA = "0x1850866A0", Slot = "7")]
		public string SCSVBGJZDSC(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5086200", Offset = "0x5085000", VA = "0x185086200", Slot = "5")]
		public bool PPXSQRKLNWN(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool TryParseInternal([NotNull] string input, [Out] a value);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5086B70", Offset = "0x5085970", VA = "0x185086B70", Slot = "8")]
		private bool TCBENCDRPRS(string a, [Out] object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5087170", Offset = "0x5085F70", VA = "0x185087170", Slot = "6")]
		public a WTKCFYLSTVC(string a, [Optional] a b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class VPHEZYOCAOM<b>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static OHSUVITLQCJ<b> DOFDCVCRMAS
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5B6E0B0", Offset = "0x5B6CEB0", VA = "0x185B6E0B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x41681D0", Offset = "0x4166FD0", VA = "0x1841681D0")]
		public static OHSUVITLQCJ<a> HLATCQIVBYJ<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7EAD670", Offset = "0x7EAC470", VA = "0x187EAD670")]
		public static ITHBMAFSKCW HLATCQIVBYJ(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7EBB300", Offset = "0x7EBA100", VA = "0x187EBB300")]
		private static ITHBMAFSKCW SRYTIFGCEEC(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7EB3C00", Offset = "0x7EB2A00", VA = "0x187EB3C00")]
		private static ITHBMAFSKCW RQTFIMUMBJX(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class XMRVCQGPZNJ<a> : XWZFHIKPTGW<a, string> where a : IEnumerable<string>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
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
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x1008CC0", Offset = "0x1007AC0", VA = "0x181008CC0")]
			[DebuggerHidden]
			public ENALUICQIMU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x5B076B0", Offset = "0x5B064B0", VA = "0x185B076B0", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x5B06DA0", Offset = "0x5B05BA0", VA = "0x185B06DA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5B07920", Offset = "0x5B06720", VA = "0x185B07920")]
			private void RHNDEQIOOEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x4ED8500", Offset = "0x4ED7300", VA = "0x184ED8500", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x5B07810", Offset = "0x5B06610", VA = "0x185B07810", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> RDNWMZXGDML()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x5B07970", Offset = "0x5B06770", VA = "0x185B07970", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly bool UWFFQLQEJEW;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5082AC0", Offset = "0x50818C0", VA = "0x185082AC0")]
		protected XMRVCQGPZNJ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x50827D0", Offset = "0x50815D0", VA = "0x1850827D0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5082390", Offset = "0x5081190", VA = "0x185082390", Slot = "12")]
		[IteratorStateMachine(typeof(XMRVCQGPZNJ<>.ENALUICQIMU))]
		internal override IEnumerable<string> SVYRVFQWDZX(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5082310", Offset = "0x5081110", VA = "0x185082310")]
		[CompilerGenerated]
		internal static string NVMYBTYBNBP(StringBuilder a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class KHPEEAEJHHN : XMRVCQGPZNJ<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9C421C0", Offset = "0x9C40FC0", VA = "0x189C421C0")]
		[Preserve]
		public KHPEEAEJHHN(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9C42130", Offset = "0x9C40F30", VA = "0x189C42130", Slot = "11")]
		protected override List<string> WECZZWICSBD(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class NQTGLTGEXEG : XMRVCQGPZNJ<string[]>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9C423A0", Offset = "0x9C411A0", VA = "0x189C423A0")]
		[Preserve]
		public NQTGLTGEXEG(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9C42340", Offset = "0x9C41140", VA = "0x189C42340", Slot = "11")]
		protected override string[] WECZZWICSBD(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal class VLJISDBRCDF : XSDXOWNJGCN<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xD4BB40", Offset = "0xD4A940", VA = "0x180D4BB40", Slot = "9")]
		public override string Serialize(string input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9C427E0", Offset = "0x9C415E0", VA = "0x189C427E0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9C42800", Offset = "0x9C41600", VA = "0x189C42800")]
		public VLJISDBRCDF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class DNOYLGSXCWU : XSDXOWNJGCN<TimeSpan>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9C418B0", Offset = "0x9C406B0", VA = "0x189C418B0", Slot = "9")]
		public override string Serialize(TimeSpan input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9C419D0", Offset = "0x9C407D0", VA = "0x189C419D0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] TimeSpan value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9C41B40", Offset = "0x9C40940", VA = "0x189C41B40")]
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
