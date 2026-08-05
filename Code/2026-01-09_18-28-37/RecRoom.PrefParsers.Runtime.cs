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
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		[Cpp2IlInjected.Address(RVA = "0xACDAC0", Offset = "0xACCEC0", VA = "0x180ACDAC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xACDB00", Offset = "0xACCF00", VA = "0x180ACDB00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Utils.PrefParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class UBZEKOXDKSF : LORNUUFMEZY<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x85FECB0", Offset = "0x85FE0B0", VA = "0x1885FECB0", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85FECE0", Offset = "0x85FE0E0", VA = "0x1885FECE0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85FED30", Offset = "0x85FE130", VA = "0x1885FED30")]
		public UBZEKOXDKSF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class CQEVRHDFJKA : LORNUUFMEZY<DateTime>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85FD760", Offset = "0x85FCB60", VA = "0x1885FD760", Slot = "9")]
		public override string Serialize(DateTime input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85FD7F0", Offset = "0x85FCBF0", VA = "0x1885FD7F0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] DateTime value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x85FD890", Offset = "0x85FCC90", VA = "0x1885FD890")]
		public CQEVRHDFJKA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class KMNPEIHSYLG<a> : LORNUUFMEZY<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Type FQUUWYQPMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly bool RKYQRIKRPNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly a[] GJMQFINSCIA;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5243520", Offset = "0x5242920", VA = "0x185243520")]
		[Preserve]
		public KMNPEIHSYLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5242F20", Offset = "0x5242320", VA = "0x185242F20", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x52431B0", Offset = "0x52425B0", VA = "0x1852431B0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class EJKFYEUSIPZ<a> : LORNUUFMEZY<a> where a : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Type FQUUWYQPMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly RNEENRHJWHV AWZQIEITUMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly bool RKYQRIKRPNY;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4749750", Offset = "0x4748B50", VA = "0x184749750")]
		[Preserve]
		public EJKFYEUSIPZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4749120", Offset = "0x4748520", VA = "0x184749120", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4749500", Offset = "0x4748900", VA = "0x184749500", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class IJIZVFPXGVC
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Dictionary<Type, RNEENRHJWHV> QUPOLTHDUFW;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x85FDE10", Offset = "0x85FD210", VA = "0x1885FDE10")]
		public static RNEENRHJWHV OPRFVLFYJLS(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class NMGGYYWNVMV<a> : LORNUUFMEZY<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5845280", Offset = "0x5844680", VA = "0x185845280", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x58453A0", Offset = "0x58447A0", VA = "0x1858453A0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3D4C540", Offset = "0x3D4B940", VA = "0x183D4C540")]
		public NMGGYYWNVMV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class WZJOFWVLYPP<a, b> : LORNUUFMEZY<a> where a : IEnumerable<b>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly MZLJZYFRGEY<b> IZSWMFMJLBH;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x65E7600", Offset = "0x65E6A00", VA = "0x1865E7600")]
		protected WZJOFWVLYPP(MZLJZYFRGEY<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x65E3F50", Offset = "0x65E3350", VA = "0x1865E3F50", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x65E7200", Offset = "0x65E6600", VA = "0x1865E7200", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract a MMIBFOUTXQS(IEnumerable<b> a);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x65E3500", Offset = "0x65E2900", VA = "0x1865E3500", Slot = "12")]
		internal virtual IEnumerable<string> OCLLCSLKWNM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x65E39B0", Offset = "0x65E2DB0", VA = "0x1865E39B0")]
		[CompilerGenerated]
		private string SFXUYHGFITF(b a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class BNHHHUGGHVR<a> : WZJOFWVLYPP<a[], a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4D62250", Offset = "0x4D61650", VA = "0x184D62250")]
		[Preserve]
		public BNHHHUGGHVR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4D62270", Offset = "0x4D61670", VA = "0x184D62270")]
		[Preserve]
		public BNHHHUGGHVR(MZLJZYFRGEY<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F8E0", Offset = "0x6E6ECE0", VA = "0x186E6F8E0", Slot = "11")]
		protected override a[] MMIBFOUTXQS(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class FIPUFUUJMBM<a> : WZJOFWVLYPP<List<a>, a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4D62250", Offset = "0x4D61650", VA = "0x184D62250")]
		[Preserve]
		public FIPUFUUJMBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4D62270", Offset = "0x4D61670", VA = "0x184D62270")]
		[Preserve]
		public FIPUFUUJMBM([Optional] MZLJZYFRGEY<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4D62090", Offset = "0x4D61490", VA = "0x184D62090", Slot = "11")]
		protected override List<a> MMIBFOUTXQS(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class GKIREWKRSHU<a> : LORNUUFMEZY<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly JsonSerializerSettings? ILVHZTNGBKR;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4E95AD0", Offset = "0x4E94ED0", VA = "0x184E95AD0")]
		public GKIREWKRSHU(JsonSerializerSettings? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4E95800", Offset = "0x4E94C00", VA = "0x184E95800", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4E95860", Offset = "0x4E94C60", VA = "0x184E95860", Slot = "10")]
		protected override bool TryParseInternal([NotNull] string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class TXZJWPAAEJF : LORNUUFMEZY<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x85FEB80", Offset = "0x85FDF80", VA = "0x1885FEB80", Slot = "9")]
		public override string Serialize(byte input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x85FEBE0", Offset = "0x85FDFE0", VA = "0x1885FEBE0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] byte value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x85FEC70", Offset = "0x85FE070", VA = "0x1885FEC70")]
		public TXZJWPAAEJF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class NHHUDKUYYNB : LORNUUFMEZY<short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x85FE5B0", Offset = "0x85FD9B0", VA = "0x1885FE5B0", Slot = "9")]
		public override string Serialize(short input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x85FE610", Offset = "0x85FDA10", VA = "0x1885FE610", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] short value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x85FE6B0", Offset = "0x85FDAB0", VA = "0x1885FE6B0")]
		public NHHUDKUYYNB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class QMPVFYTIJPQ : LORNUUFMEZY<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x85FE7D0", Offset = "0x85FDBD0", VA = "0x1885FE7D0", Slot = "9")]
		public override string Serialize(ushort input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x85FE830", Offset = "0x85FDC30", VA = "0x1885FE830", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ushort value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x85FE8D0", Offset = "0x85FDCD0", VA = "0x1885FE8D0")]
		public QMPVFYTIJPQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class QTJXEWQUHQY : LORNUUFMEZY<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x85FE910", Offset = "0x85FDD10", VA = "0x1885FE910", Slot = "9")]
		public override string Serialize(int input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x85FE970", Offset = "0x85FDD70", VA = "0x1885FE970", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x85FEA00", Offset = "0x85FDE00", VA = "0x1885FEA00")]
		public QTJXEWQUHQY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class HEKYMBKQPBT : LORNUUFMEZY<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x85FDBA0", Offset = "0x85FCFA0", VA = "0x1885FDBA0", Slot = "9")]
		public override string Serialize(uint input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x85FDC00", Offset = "0x85FD000", VA = "0x1885FDC00", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] uint value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x85FDC90", Offset = "0x85FD090", VA = "0x1885FDC90")]
		public HEKYMBKQPBT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class HYNSMDLXHFV : LORNUUFMEZY<long>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x85FDCD0", Offset = "0x85FD0D0", VA = "0x1885FDCD0", Slot = "9")]
		public override string Serialize(long input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85FDD30", Offset = "0x85FD130", VA = "0x1885FDD30", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] long value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85FDDD0", Offset = "0x85FD1D0", VA = "0x1885FDDD0")]
		public HYNSMDLXHFV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class ZNELQORRJDS : LORNUUFMEZY<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85FEDD0", Offset = "0x85FE1D0", VA = "0x1885FEDD0", Slot = "9")]
		public override string Serialize(ulong input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85FEE30", Offset = "0x85FE230", VA = "0x1885FEE30", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ulong value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x85FEED0", Offset = "0x85FE2D0", VA = "0x1885FEED0")]
		public ZNELQORRJDS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class RPPMQXHGVWH : LORNUUFMEZY<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85FEA40", Offset = "0x85FDE40", VA = "0x1885FEA40", Slot = "9")]
		public override string Serialize(float input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x85FEAB0", Offset = "0x85FDEB0", VA = "0x1885FEAB0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x85FEB40", Offset = "0x85FDF40", VA = "0x1885FEB40")]
		public RPPMQXHGVWH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface RNEENRHJWHV
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string PXGCWUTHXGF(object a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CXVKRRWBKKH([CanBeNull] string input, [Out] object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface MZLJZYFRGEY<a> : RNEENRHJWHV
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool WSHLCSULDZQ([CanBeNull] string input, [Out] a a);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		a STIHZWYCHLL([CanBeNull] string input, [Optional] a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class LORNUUFMEZY<a> : MZLJZYFRGEY<a>, RNEENRHJWHV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Type ESHTIDQSORA;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x53284C0", Offset = "0x53278C0", VA = "0x1853284C0")]
		protected LORNUUFMEZY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x53282A0", Offset = "0x53276A0", VA = "0x1853282A0")]
		private a ZPUTGWUGVUC(object a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5327300", Offset = "0x5326700", VA = "0x185327300", Slot = "7")]
		public string PXGCWUTHXGF(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5327E60", Offset = "0x5327260", VA = "0x185327E60", Slot = "5")]
		public bool WSHLCSULDZQ(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool TryParseInternal([NotNull] string input, [Out] a value);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5327750", Offset = "0x5326B50", VA = "0x185327750", Slot = "8")]
		private bool QRVCQZAOMSN(string a, [Out] object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5327B20", Offset = "0x5326F20", VA = "0x185327B20", Slot = "6")]
		public a STIHZWYCHLL(string a, [Optional] a b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class QKFXXBTANXB<b>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static MZLJZYFRGEY<b> HGWXKXVBWLR
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x4D39610", Offset = "0x4D38A10", VA = "0x184D39610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3647150", Offset = "0x3646550", VA = "0x183647150")]
		public static MZLJZYFRGEY<a> GCAVPDQHFKM<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5ACEF10", Offset = "0x5ACE310", VA = "0x185ACEF10")]
		public static RNEENRHJWHV GCAVPDQHFKM(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5AD56F0", Offset = "0x5AD4AF0", VA = "0x185AD56F0")]
		private static RNEENRHJWHV HTJSMIHZFHD(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5AD8B00", Offset = "0x5AD7F00", VA = "0x185AD8B00")]
		private static RNEENRHJWHV YABCVDLJOPK(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class PFERUGDHSWS<a> : WZJOFWVLYPP<a, string> where a : IEnumerable<string>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class EXYZMDVXYZB : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int HEQVXHRXEOS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private string FKBMGWISUJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int QYTMAKYNUQD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private string AXYHCTJCEHQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public string PMNFVZOBVVL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public PFERUGDHSWS<a> ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private PooledObject<StringBuilder> EVZPNEZEXIS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private StringBuilder XOBSXHBPSZU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private bool AHZKLQSISZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int LPFUVYTSTTP;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private string ENARBZMVDAJ
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xD3EE90", Offset = "0xD3E290", VA = "0x180D3EE90")]
			[DebuggerHidden]
			public EXYZMDVXYZB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x4768760", Offset = "0x4767B60", VA = "0x184768760", Slot = "7")]
			[DebuggerHidden]
			private void HQQAIWMTMBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x4768F30", Offset = "0x4768330", VA = "0x184768F30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x47693C0", Offset = "0x47687C0", VA = "0x1847693C0")]
			private void UOGOWTTYZFR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3CC4DC0", Offset = "0x3CC41C0", VA = "0x183CC4DC0", Slot = "10")]
			[DebuggerHidden]
			private void IWYQKYBWKKW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x4768960", Offset = "0x4767D60", VA = "0x184768960", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> MXWGMYNXTOS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x4768880", Offset = "0x4767C80", VA = "0x184768880", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KHITEENQWKX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly bool RWYGIGBKWWZ;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5A44B90", Offset = "0x5A43F90", VA = "0x185A44B90")]
		protected PFERUGDHSWS(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5A446A0", Offset = "0x5A43AA0", VA = "0x185A446A0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5A44540", Offset = "0x5A43940", VA = "0x185A44540", Slot = "12")]
		[IteratorStateMachine(typeof(PFERUGDHSWS<>.EXYZMDVXYZB))]
		internal override IEnumerable<string> OCLLCSLKWNM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5A44440", Offset = "0x5A43840", VA = "0x185A44440")]
		[CompilerGenerated]
		internal static string ARTZNRFHRTO(StringBuilder a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class NYWXWYNNGQY : PFERUGDHSWS<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x85FE780", Offset = "0x85FDB80", VA = "0x1885FE780")]
		[Preserve]
		public NYWXWYNNGQY(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x85FE6F0", Offset = "0x85FDAF0", VA = "0x1885FE6F0", Slot = "11")]
		protected override List<string> MMIBFOUTXQS(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class KWHRBHIKOQD : PFERUGDHSWS<string[]>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x85FE560", Offset = "0x85FD960", VA = "0x1885FE560")]
		[Preserve]
		public KWHRBHIKOQD(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x85FE500", Offset = "0x85FD900", VA = "0x1885FE500", Slot = "11")]
		protected override string[] MMIBFOUTXQS(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal class XKNMYABVXMI : LORNUUFMEZY<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB04BE0", Offset = "0xB03FE0", VA = "0x180B04BE0", Slot = "9")]
		public override string Serialize(string input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x85FED70", Offset = "0x85FE170", VA = "0x1885FED70", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x85FED90", Offset = "0x85FE190", VA = "0x1885FED90")]
		public XKNMYABVXMI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class CYYEXNFOVSL : LORNUUFMEZY<TimeSpan>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x85FD8D0", Offset = "0x85FCCD0", VA = "0x1885FD8D0", Slot = "9")]
		public override string Serialize(TimeSpan input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x85FD9F0", Offset = "0x85FCDF0", VA = "0x1885FD9F0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] TimeSpan value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x85FDB60", Offset = "0x85FCF60", VA = "0x1885FDB60")]
		public CYYEXNFOVSL()
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
