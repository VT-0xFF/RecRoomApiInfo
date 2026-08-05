using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Circuits.Static.Core.TypeSystem.Factory;
using Circuits.Static.Core.TypeSystem.Type;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;

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
namespace Circuits.Static.Core.TypeSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class QNRWKFGEPMB : IEquatable<QNRWKFGEPMB>, VHVQTMURGOZ<QNRWKFGEPMB>, FSUVRUUTBIE
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static bool GRDZIXFLGWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool XCLRTPLZDWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int SUAKFQEWYNX;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public TypeKind DKWEGDBOTPS
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAA2110", Offset = "0xAA1510", VA = "0x180AA2110")]
			[CompilerGenerated]
			get
			{
				return default(TypeKind);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAA5C90", Offset = "0xAA5090", VA = "0x180AA5C90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual int? QIKSBRUQSVB
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x28E5070", Offset = "0x28E4470", VA = "0x1828E5070", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public virtual QNRWKFGEPMB ROWNOYXLQYZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xB44840", Offset = "0xB43C40", VA = "0x180B44840", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public virtual bool BUQHWTRKOUY
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x28E4FA0", Offset = "0x28E43A0", VA = "0x1828E4FA0")]
		public static void HGSJECSPXBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAA7100", Offset = "0xAA6500", VA = "0x180AA7100")]
		protected QNRWKFGEPMB(TypeKind a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x28E5120", Offset = "0x28E4520", VA = "0x1828E5120")]
		public static QNRWKFGEPMB New(TypeKind kind)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xB44840", Offset = "0xB43C40", VA = "0x180B44840")]
		protected static a OCBEOBXCLTD<a>(a a) where a : QNRWKFGEPMB
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB44840", Offset = "0xB43C40", VA = "0x180B44840", Slot = "9")]
		public virtual QNRWKFGEPMB QZRIQXSKSDU(IReadOnlyDictionary<string, QNRWKFGEPMB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x28E4F70", Offset = "0x28E4370", VA = "0x1828E4F70", Slot = "11")]
		public virtual void HAXQZBWHRZM(Action<QNRWKFGEPMB> a, Action<QNRWKFGEPMB> b, Action<QNRWKFGEPMB> c, Action<QNRWKFGEPMB> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x28E5190", Offset = "0x28E4590", VA = "0x1828E5190", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x28E5300", Offset = "0x28E4700", VA = "0x1828E5300", Slot = "12")]
		public virtual bool UEETEZFSGGI([In] QNRWKFGEPMB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x28E4E90", Offset = "0x28E4290", VA = "0x1828E4E90", Slot = "4")]
		public bool Equals(QNRWKFGEPMB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x28E4E40", Offset = "0x28E4240", VA = "0x1828E4E40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x28E50E0", Offset = "0x28E44E0", VA = "0x1828E50E0")]
		public static bool NAQFJJXEQSO(QNRWKFGEPMB a, QNRWKFGEPMB b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x28E5030", Offset = "0x28E4430", VA = "0x1828E5030")]
		public static bool IMKWXPVUUOB(QNRWKFGEPMB a, QNRWKFGEPMB b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x28E4EC0", Offset = "0x28E42C0", VA = "0x1828E4EC0", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x28E5440", Offset = "0x28E4840", VA = "0x1828E5440", Slot = "13")]
		public virtual int ZQBTNATPPTH(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x28E5440", Offset = "0x28E4840", VA = "0x1828E5440", Slot = "14")]
		protected virtual int ZUYWFXBSALX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x376DA60", Offset = "0x376CE60", VA = "0x18376DA60")]
		public b GGGWQQWPTWB<b>() where b : QNRWKFGEPMB
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28E17F0", Offset = "0x28E0BF0", VA = "0x1828E17F0", Slot = "15")]
		public virtual string MEHLBYWTUHU(IReadOnlyList<QNRWKFGEPMB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x28E53F0", Offset = "0x28E47F0", VA = "0x1828E53F0", Slot = "16")]
		public virtual int YIHGAAKQDKN(IReadOnlyList<QNRWKFGEPMB> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28E53A0", Offset = "0x28E47A0", VA = "0x1828E53A0", Slot = "17")]
		public virtual bool YDAIVXSYAWU(IReadOnlyList<QNRWKFGEPMB> a, IReadOnlyList<QNRWKFGEPMB> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x28E4D00", Offset = "0x28E4100", VA = "0x1828E4D00")]
		public RMUCOODOUOA EJTPNVUYCUS(params CircuitTypeOrString[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x28E4CF0", Offset = "0x28E40F0", VA = "0x1828E4CF0")]
		public RMUCOODOUOA EJTPNVUYCUS(params QNRWKFGEPMB[] typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x28E4CF0", Offset = "0x28E40F0", VA = "0x1828E4CF0")]
		public RMUCOODOUOA EJTPNVUYCUS(IEnumerable<QNRWKFGEPMB> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface UCTXXJIHGPQ<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a AANKKOOLKGQ(b a, IOKind b);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "1")]
		b AWHOXIIGUZE([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IOKind EVPENHFTMMA([In] a directedType);

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "3")]
		PerfScopeDelegates YKTKFDDBKJF(c a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface FSUVRUUTBIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int ZQBTNATPPTH(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class ZQBTNATPPTH
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class QLJHXDGEACX<a> where a : FSUVRUUTBIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public int TKRHHUJCGHA;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public QLJHXDGEACX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5AE9400", Offset = "0x5AE8800", VA = "0x185AE9400")]
			internal int PZZILVTJOYA(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class JFMBGIKBHTP<a, b> where b : FSUVRUUTBIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public int TKRHHUJCGHA;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public JFMBGIKBHTP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x50E2C40", Offset = "0x50E2040", VA = "0x1850E2C40")]
			internal int PZZILVTJOYA(int a, KeyValuePair<a, b> b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class RTJFAHUETXD<a> where a : FSUVRUUTBIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public int TKRHHUJCGHA;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public RTJFAHUETXD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5B83C30", Offset = "0x5B83030", VA = "0x185B83C30")]
			internal int BFPZBQVCNHH(int a, a b)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3C0E6B0", Offset = "0x3C0DAB0", VA = "0x183C0E6B0")]
		public static int HGMJGACGSJA<a>(this IEnumerable<a> a, int b = 0) where a : FSUVRUUTBIE
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3C0E5E0", Offset = "0x3C0D9E0", VA = "0x183C0E5E0")]
		public static int HGMJGACGSJA<b, c>(this IEnumerable<KeyValuePair<b, c>> a, int b = 0) where c : FSUVRUUTBIE
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3C0E6B0", Offset = "0x3C0DAB0", VA = "0x183C0E6B0")]
		public static int NWCQMOUEKTT<d>(this IEnumerable<d> a, int b = 0) where d : FSUVRUUTBIE
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct TypeSys<TDirectedType, TRoot, TDeps> where TDeps : UCTXXJIHGPQ<TDirectedType, QNRWKFGEPMB, TRoot>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal TDeps _deps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly bool _checkReferentialEquality;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4065500", Offset = "0x4064900", VA = "0x184065500")]
		private TypeSys(TDeps deps, bool checkReferentialEquality)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x60AB1E0", Offset = "0x60AA5E0", VA = "0x1860AB1E0")]
		public static TypeSys<TDirectedType, TRoot, TDeps> New(TDeps deps, bool checkReferentialEquality = true)
		{
			return default(TypeSys<TDirectedType, TRoot, TDeps>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public static class SVAPKRVOHZB
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public delegate V ZipDelegate<TArg1, TArg2, T, U, V>([In] TArg1 arg1, [In] TArg2 arg2, T first, U second);

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public delegate TResult MultiswitchFunc<TArg1, TArg2, T, TResult>([In] TArg1 arg1, TArg2 arg2, T lhs, T rhs);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class MEWUSUSWVFX<a, b, c> where c : UCTXXJIHGPQ<a, QNRWKFGEPMB, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public QNRWKFGEPMB EEQDHCJNYDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public IReadOnlyList<QNRWKFGEPMB> YJDSSEPSBRK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public QNRWKFGEPMB BEXFKIYRTPW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public IReadOnlyList<QNRWKFGEPMB> OVAWVMPGJGN;

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public MEWUSUSWVFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x57CC9F0", Offset = "0x57CBDF0", VA = "0x1857CC9F0")]
			internal bool PQHBACCREJF([In] TypeSys<a, b, c> self_, QNRWKFGEPMB a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x57CCA80", Offset = "0x57CBE80", VA = "0x1857CCA80")]
			internal bool PQMHXIWONUO([In] TypeSys<a, b, c> self_, QNRWKFGEPMB a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x57CC890", Offset = "0x57CBC90", VA = "0x1857CC890")]
			internal bool PPLZLBBBSPV([In] TypeSys<a, b, c> self_, QNRWKFGEPMB a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class XGEUBHNDUZA<a, b, c> where c : UCTXXJIHGPQ<a, QNRWKFGEPMB, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public QNRWKFGEPMB PGBJSUHWTGZ;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public XGEUBHNDUZA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x3D9FDB0", Offset = "0x3D9F1B0", VA = "0x183D9FDB0")]
			internal bool PPGSNUHEJEM([In] TypeSys<a, b, c> self__, QNRWKFGEPMB a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class CBKLXRPYLRV<a, b, c> where c : UCTXXJIHGPQ<a, QNRWKFGEPMB, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public b BRWFJBTAWNM;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public CBKLXRPYLRV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x3CC5C10", Offset = "0x3CC5010", VA = "0x183CC5C10")]
			internal QNRWKFGEPMB HUXUYKYNMRC([In] TypeSys<a, b, c> self_, [In] b root_, QNRWKFGEPMB a, QNRWKFGEPMB b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class NCSLGEKFLKY<a, b, c> where c : UCTXXJIHGPQ<a, QNRWKFGEPMB, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public WYQCGJGFTYO QHDUJBMDHHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public WYQCGJGFTYO ONNRNIKIBOY;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public NCSLGEKFLKY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x5841980", Offset = "0x5840D80", VA = "0x185841980")]
			internal a HVNPQFGFOZD([In] TypeSys<a, b, c> self_, IOKind a, WYQCGJGFTYO b, WYQCGJGFTYO c)
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class HSZHAFEBKKN<a, b, c> where c : UCTXXJIHGPQ<a, QNRWKFGEPMB, b>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public HashSet<WYQCGJGFTYO> QREWJBUKBMK;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public HSZHAFEBKKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4F1B940", Offset = "0x4F1AD40", VA = "0x184F1B940")]
			internal bool EJGSILISBAJ(bool a, WYQCGJGFTYO b)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly TypeKind[] OVFBJEJRWIM;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3A15480", Offset = "0x3A14880", VA = "0x183A15480")]
		public static bool NIFBSUZCUJT<a, b, c>([In] this TypeSys<a, b, c> _, QNRWKFGEPMB a) where c : UCTXXJIHGPQ<a, QNRWKFGEPMB, b>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3A14A20", Offset = "0x3A13E20", VA = "0x183A14A20")]
		public static bool CCKMYXCCSJQ<d, e, f>([In] this TypeSys<d, e, f> _, QNRWKFGEPMB a) where f : UCTXXJIHGPQ<d, QNRWKFGEPMB, e>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3A152E0", Offset = "0x3A146E0", VA = "0x183A152E0")]
		public static bool KGXGGYXYMTY<g, h, i>([In] this TypeSys<g, h, i> self, QNRWKFGEPMB a, QNRWKFGEPMB b) where i : UCTXXJIHGPQ<g, QNRWKFGEPMB, h>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3A1D0D0", Offset = "0x3A1C4D0", VA = "0x183A1D0D0")]
		private static bool ZHGDJSQHEBZ<j, k, l>([In] this TypeSys<j, k, l> self, QNRWKFGEPMB a, QNRWKFGEPMB b, IReadOnlyList<QNRWKFGEPMB> c, IReadOnlyList<QNRWKFGEPMB> d) where l : UCTXXJIHGPQ<j, QNRWKFGEPMB, k>
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3A18290", Offset = "0x3A17690", VA = "0x183A18290")]
		public static QNRWKFGEPMB TOOBLRGEKXX<m, n, o>([In] this TypeSys<m, n, o> self, n a, QNRWKFGEPMB b, QNRWKFGEPMB c) where o : UCTXXJIHGPQ<m, QNRWKFGEPMB, n>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3A154A0", Offset = "0x3A148A0", VA = "0x183A154A0")]
		public static p TOOBLRGEKXX<p, q, r>([In] this TypeSys<p, q, r> self, q a, [In] p typeAWithIO, [In] p typeBWithIO) where r : UCTXXJIHGPQ<p, QNRWKFGEPMB, q>
		{
			return (p)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3A14F00", Offset = "0x3A14300", VA = "0x183A14F00")]
		private static List<w> JQDCFOPUFQF<w, t, u, v, s>([In] TypeSys<t, u, v> self, [In] u root, IEnumerable<s> a, IEnumerable<s> b, ZipDelegate<TypeSys<t, u, v>, u, s, s, w> c) where v : UCTXXJIHGPQ<t, QNRWKFGEPMB, u>
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3A14880", Offset = "0x3A13C80", VA = "0x183A14880")]
		private static ba BGWFTHDGLIH<ba, x, y, z>([In] x arg1, y a, IOKind b, [In] z dataA, IOKind c, [In] z dataB, MultiswitchFunc<x, y, z, ba> d, MultiswitchFunc<x, y, z, ba> e, MultiswitchFunc<x, y, z, ba> f)
		{
			return (ba)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class ENABWGKCTHU
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public static QNRWKFGEPMB HCJKYGTINID
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x28E2330", Offset = "0x28E1730", VA = "0x1828E2330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static QNRWKFGEPMB UGICZMEZNJB
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x28E20C0", Offset = "0x28E14C0", VA = "0x1828E20C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static QNRWKFGEPMB TENINZOZMUM
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x28E2820", Offset = "0x28E1C20", VA = "0x1828E2820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static QNRWKFGEPMB SSFZFZDGUOK
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x28E27D0", Offset = "0x28E1BD0", VA = "0x1828E27D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static QNRWKFGEPMB JOLFMJEOBWA
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x28E25B0", Offset = "0x28E19B0", VA = "0x1828E25B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static QNRWKFGEPMB KHTGDNMRQVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x28E2650", Offset = "0x28E1A50", VA = "0x1828E2650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static QNRWKFGEPMB VHULCQLCKTA
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x28E2600", Offset = "0x28E1A00", VA = "0x1828E2600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static QNRWKFGEPMB MRFRIXDBFFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x28E2110", Offset = "0x28E1510", VA = "0x1828E2110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x28E26A0", Offset = "0x28E1AA0", VA = "0x1828E26A0")]
		public static RMUCOODOUOA NICNQJENHCA([In] CircuitTypeOrString elementType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x28E2900", Offset = "0x28E1D00", VA = "0x1828E2900")]
		public static RMUCOODOUOA ZYMCGBKDCVM(IEnumerable<QNRWKFGEPMB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x28E2380", Offset = "0x28E1780", VA = "0x1828E2380")]
		public static RMUCOODOUOA HGVFUOTYWWO(IEnumerable<QNRWKFGEPMB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x28E2410", Offset = "0x28E1810", VA = "0x1828E2410")]
		public static RMUCOODOUOA HGVFUOTYWWO(params CircuitTypeOrString[] types)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x28E2870", Offset = "0x28E1C70", VA = "0x1828E2870")]
		public static RMUCOODOUOA ZAKNLPJHYRB(IEnumerable<QNRWKFGEPMB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x28E2160", Offset = "0x28E1560", VA = "0x1828E2160")]
		public static BZCOEZMOZWN GEQURURIUZO(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return null;
		}
	}
}
namespace Circuits.Static.Core.TypeSystem.Type
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class RMUCOODOUOA : QNRWKFGEPMB, IEquatable<RMUCOODOUOA>, VHVQTMURGOZ<RMUCOODOUOA>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class GEAWGGTCVVK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public IReadOnlyDictionary<string, QNRWKFGEPMB> VZZSZUHESHW;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public GEAWGGTCVVK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x28E3160", Offset = "0x28E2560", VA = "0x1828E3160")]
			internal QNRWKFGEPMB IWDSQJSAUPS(QNRWKFGEPMB a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public QNRWKFGEPMB ZTTSLTXVMOC
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public sealed override QNRWKFGEPMB ROWNOYXLQYZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public IReadOnlyList<QNRWKFGEPMB> FEKJECEFUOF
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BE0", Offset = "0xAA2FE0", VA = "0x180AA3BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public sealed override bool BUQHWTRKOUY
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x28E5740", Offset = "0x28E4B40", VA = "0x1828E5740", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x28E58D0", Offset = "0x28E4CD0", VA = "0x1828E58D0", Slot = "9")]
		public sealed override QNRWKFGEPMB QZRIQXSKSDU(IReadOnlyDictionary<string, QNRWKFGEPMB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x28E54E0", Offset = "0x28E48E0", VA = "0x1828E54E0", Slot = "11")]
		public sealed override void HAXQZBWHRZM(Action<QNRWKFGEPMB> a, Action<QNRWKFGEPMB> b, Action<QNRWKFGEPMB> c, Action<QNRWKFGEPMB> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x28E5BE0", Offset = "0x28E4FE0", VA = "0x1828E5BE0")]
		private RMUCOODOUOA(QNRWKFGEPMB a, IEnumerable<QNRWKFGEPMB> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x28E5850", Offset = "0x28E4C50", VA = "0x1828E5850")]
		public static RMUCOODOUOA New(QNRWKFGEPMB originalType, IEnumerable<QNRWKFGEPMB> typeParameterAssignments)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x28E59F0", Offset = "0x28E4DF0", VA = "0x1828E59F0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x28E5A30", Offset = "0x28E4E30", VA = "0x1828E5A30", Slot = "12")]
		public override bool UEETEZFSGGI([In] QNRWKFGEPMB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x28E5A80", Offset = "0x28E4E80", VA = "0x1828E5A80")]
		public bool UEETEZFSGGI([In] RMUCOODOUOA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x28E54C0", Offset = "0x28E48C0", VA = "0x1828E54C0", Slot = "18")]
		public bool Equals(RMUCOODOUOA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x28E5470", Offset = "0x28E4870", VA = "0x1828E5470", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x28E5B30", Offset = "0x28E4F30", VA = "0x1828E5B30", Slot = "14")]
		protected override int ZUYWFXBSALX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x28E5B20", Offset = "0x28E4F20", VA = "0x1828E5B20", Slot = "19")]
		private bool VYBRPEOQBWZ([In] RMUCOODOUOA other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public sealed class IDLDRMQETTR : QNRWKFGEPMB, IEquatable<IDLDRMQETTR>, VHVQTMURGOZ<IDLDRMQETTR>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x28E33F0", Offset = "0x28E27F0", VA = "0x1828E33F0")]
		private IDLDRMQETTR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x28E3290", Offset = "0x28E2690", VA = "0x1828E3290")]
		public static IDLDRMQETTR New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x28E3340", Offset = "0x28E2740", VA = "0x1828E3340", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x28E3200", Offset = "0x28E2600", VA = "0x1828E3200", Slot = "15")]
		public sealed override string MEHLBYWTUHU(IReadOnlyList<QNRWKFGEPMB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x28E3300", Offset = "0x28E2700", VA = "0x1828E3300")]
		private static string SWXYYGOKAGE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x28E33A0", Offset = "0x28E27A0", VA = "0x1828E33A0", Slot = "12")]
		public override bool UEETEZFSGGI([In] QNRWKFGEPMB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x28E31A0", Offset = "0x28E25A0", VA = "0x1828E31A0")]
		public bool UEETEZFSGGI([In] IDLDRMQETTR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xCA3190", Offset = "0xCA2590", VA = "0x180CA3190", Slot = "18")]
		public bool Equals(IDLDRMQETTR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x28E31B0", Offset = "0x28E25B0", VA = "0x1828E31B0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x28E31A0", Offset = "0x28E25A0", VA = "0x1828E31A0", Slot = "19")]
		private bool DNRMOYUDTWU([In] IDLDRMQETTR other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class BATUMAKPFYI
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class KTYJSXNJOKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public QNRWKFGEPMB GFWXSMUMUBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public Func<QNRWKFGEPMB, RMUCOODOUOA> LTWOLSLIAXW;

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public KTYJSXNJOKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x28E4140", Offset = "0x28E3540", VA = "0x1828E4140")]
			internal RMUCOODOUOA QWTKWRBNBNK(QNRWKFGEPMB a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class KTTCVQTMEZC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public QNRWKFGEPMB LUMHRZUWBXU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public Func<QNRWKFGEPMB, RMUCOODOUOA> SEFAYQHBXVW;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public KTTCVQTMEZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x28E3FC0", Offset = "0x28E33C0", VA = "0x1828E3FC0")]
			internal RMUCOODOUOA MNAXTGMTOTS(QNRWKFGEPMB a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x28DE6D0", Offset = "0x28DDAD0", VA = "0x1828DE6D0")]
		public static IEnumerable<WYQCGJGFTYO> KGRGDLFNJPW(this WYQCGJGFTYO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x28DD650", Offset = "0x28DCA50", VA = "0x1828DD650")]
		private static IEnumerable<WYQCGJGFTYO> AFFNSXTYOCK(this WYQCGJGFTYO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x28DE4C0", Offset = "0x28DD8C0", VA = "0x1828DE4C0")]
		public static (QNRWKFGEPMB, IReadOnlyList<QNRWKFGEPMB>, bool) EPWINYHPQSU(this QNRWKFGEPMB a, [Optional] IReadOnlyList<QNRWKFGEPMB> b)
		{
			return default((QNRWKFGEPMB, IReadOnlyList<QNRWKFGEPMB>, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x28DE900", Offset = "0x28DDD00", VA = "0x1828DE900")]
		public static TypeKind OXBQZNFATBZ(this QNRWKFGEPMB a)
		{
			return default(TypeKind);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x28DD710", Offset = "0x28DCB10", VA = "0x1828DD710")]
		private static QNRWKFGEPMB ConvertClassesToIntersections(this QNRWKFGEPMB self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x28DE1B0", Offset = "0x28DD5B0", VA = "0x1828DE1B0")]
		private static QNRWKFGEPMB DistributeUnionIntoIntersection(this RMUCOODOUOA self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x28DDD40", Offset = "0x28DD140", VA = "0x1828DDD40")]
		private static QNRWKFGEPMB DistributeIntersectionIntoIntersection(this RMUCOODOUOA self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x28DE050", Offset = "0x28DD450", VA = "0x1828DE050")]
		private static QNRWKFGEPMB DistributeIntoIntersection(this QNRWKFGEPMB self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x28DE930", Offset = "0x28DDD30", VA = "0x1828DE930")]
		private static bool OtherIsAssignableToOther(this QNRWKFGEPMB self, [In] PerfScopeDelegates perfScopes, QNRWKFGEPMB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x28DFD90", Offset = "0x28DF190", VA = "0x1828DFD90")]
		private static bool UnionIsAssignableToOther(this QNRWKFGEPMB self, [In] PerfScopeDelegates perfScopes, QNRWKFGEPMB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x28DEAC0", Offset = "0x28DDEC0", VA = "0x1828DEAC0")]
		private static bool OtherIsAssignableToUnion(this QNRWKFGEPMB self, [In] PerfScopeDelegates perfScopes, QNRWKFGEPMB union)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x28E00B0", Offset = "0x28DF4B0", VA = "0x1828E00B0")]
		private static bool UnionIsAssignableToUnion(this QNRWKFGEPMB self, [In] PerfScopeDelegates perfScopes, QNRWKFGEPMB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x28DFB00", Offset = "0x28DEF00", VA = "0x1828DFB00")]
		public static QNRWKFGEPMB RemoveCommonTypesFromIntersectionDistribution(this QNRWKFGEPMB self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x28DEE60", Offset = "0x28DE260", VA = "0x1828DEE60")]
		public static QNRWKFGEPMB RemoveCommonTypesFromIntersectionDistributionInternal(this QNRWKFGEPMB self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x28DFC30", Offset = "0x28DF030", VA = "0x1828DFC30")]
		public static QNRWKFGEPMB SimplifyIntersectionUnion(this QNRWKFGEPMB self, [In] PerfScopeDelegates perfScopes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x28DE680", Offset = "0x28DDA80", VA = "0x1828DE680")]
		public static IEnumerable<QNRWKFGEPMB> FEKJECEFUOF(this QNRWKFGEPMB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x28DFD00", Offset = "0x28DF100", VA = "0x1828DFD00")]
		public static IEnumerable<QNRWKFGEPMB> UAZTKAJEPLM(this QNRWKFGEPMB a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public sealed class WYQCGJGFTYO : FEFXCAZHZKT, IEquatable<WYQCGJGFTYO>, VHVQTMURGOZ<WYQCGJGFTYO>
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class KRPQHLZDHMJ : IEnumerable<WYQCGJGFTYO>, IEnumerable, IEnumerator<WYQCGJGFTYO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private int HEQVXHRXEOS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private WYQCGJGFTYO FKBMGWISUJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private int QYTMAKYNUQD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public WYQCGJGFTYO ZFLSXXSLHFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private IEnumerator<WYQCGJGFTYO> DJOJRFZZVTY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private WYQCGJGFTYO USVZJMSFDSJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			private IEnumerator<WYQCGJGFTYO> DJDVWSMFCXG;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private WYQCGJGFTYO WSBNAMMLBSR
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private object HOQQBVEZJSM
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xD3EE90", Offset = "0xD3E290", VA = "0x180D3EE90")]
			[DebuggerHidden]
			public KRPQHLZDHMJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x28E3930", Offset = "0x28E2D30", VA = "0x1828E3930", Slot = "7")]
			[DebuggerHidden]
			private void HQQAIWMTMBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x28E3B60", Offset = "0x28E2F60", VA = "0x1828E3B60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x28E3F20", Offset = "0x28E3320", VA = "0x1828E3F20")]
			private void UOGOWTTYZFR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x28E3F70", Offset = "0x28E3370", VA = "0x1828E3F70")]
			private void UOLVUANWIRA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x28E3A80", Offset = "0x28E2E80", VA = "0x1828E3A80", Slot = "10")]
			[DebuggerHidden]
			private void IWYQKYBWKKW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x28E3AC0", Offset = "0x28E2EC0", VA = "0x1828E3AC0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<WYQCGJGFTYO> WVCNZFKRJDU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x28E3AC0", Offset = "0x28E2EC0", VA = "0x1828E3AC0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KHITEENQWKX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private static readonly Dictionary<Guid, string> IHQXINNJWXY;

		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private static readonly Dictionary<Guid, WYQCGJGFTYO> CJRPSQRHDSD;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static IReadOnlyDictionary<Guid, WYQCGJGFTYO> RXDQWKJTKXF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x28E9000", Offset = "0x28E8400", VA = "0x1828E9000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override int? QIKSBRUQSVB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BE0", Offset = "0xAA2FE0", VA = "0x180AA3BE0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Guid KVDFRQPXLVJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xC97F60", Offset = "0xC97360", VA = "0x180C97F60")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xC97EB0", Offset = "0xC972B0", VA = "0x180C97EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string OVNHSEVRRUV
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xAA9FA0", Offset = "0xAA93A0", VA = "0x180AA9FA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xAA9AB0", Offset = "0xAA8EB0", VA = "0x180AA9AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IEnumerable<WYQCGJGFTYO> GJRZWJRTQGZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xAAE8F0", Offset = "0xAADCF0", VA = "0x180AAE8F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xAAE8C0", Offset = "0xAADCC0", VA = "0x180AAE8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IEnumerable<WYQCGJGFTYO> VFVMSFXHQUI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x28E8A70", Offset = "0x28E7E70", VA = "0x1828E8A70")]
			[IteratorStateMachine(typeof(KRPQHLZDHMJ))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IReadOnlyDictionary<string, Property> JLCRPLVBGMX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xAA6650", Offset = "0xAA5A50", VA = "0x180AA6650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xAA68B0", Offset = "0xAA5CB0", VA = "0x180AA68B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IReadOnlyDictionary<string, DWSSBPFWIDI> NKETVNQRVAT
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xAA6680", Offset = "0xAA5A80", VA = "0x180AA6680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAA6660", Offset = "0xAA5A60", VA = "0x180AA6660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x28E9590", Offset = "0x28E8990", VA = "0x1828E9590")]
		public WYQCGJGFTYO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x28E94E0", Offset = "0x28E88E0", VA = "0x1828E94E0")]
		public WYQCGJGFTYO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x28E8650", Offset = "0x28E7A50", VA = "0x1828E8650")]
		public static WYQCGJGFTYO MIXGRZIHHRF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x28E8A20", Offset = "0x28E7E20", VA = "0x1828E8A20")]
		public static WYQCGJGFTYO QHKMURCENXV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x28E8390", Offset = "0x28E7790", VA = "0x1828E8390")]
		public void Initialize(WYQCGJGFTYO from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x28E9240", Offset = "0x28E8640", VA = "0x1828E9240")]
		private WYQCGJGFTYO([Optional] Guid? a, [Optional] string b, [Optional] IEnumerable<BZCOEZMOZWN> c, [Optional] IEnumerable<WYQCGJGFTYO> d, [Optional] IEnumerable<KeyValuePair<string, Property>> e, [Optional] IEnumerable<KeyValuePair<string, DWSSBPFWIDI>> f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x28E86A0", Offset = "0x28E7AA0", VA = "0x1828E86A0")]
		public static WYQCGJGFTYO New([Optional] Guid? id, [Optional] string name, [Optional] IEnumerable<BZCOEZMOZWN> typeParameters, [Optional] IEnumerable<WYQCGJGFTYO> baseClasses, [Optional] IEnumerable<KeyValuePair<string, Property>> properties, [Optional] IEnumerable<KeyValuePair<string, DWSSBPFWIDI>> functions)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x28E8AF0", Offset = "0x28E7EF0", VA = "0x1828E8AF0", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x28E81F0", Offset = "0x28E75F0", VA = "0x1828E81F0")]
		private string AEDPBVENHNL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x28E82D0", Offset = "0x28E76D0", VA = "0x1828E82D0")]
		private static string FITKGSPWDVE(IEnumerable<QNRWKFGEPMB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x28E8770", Offset = "0x28E7B70", VA = "0x1828E8770")]
		private string OHFGDPGQILP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x28E8D50", Offset = "0x28E8150", VA = "0x1828E8D50")]
		private string ULPMHCASIUU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x28E8580", Offset = "0x28E7980", VA = "0x1828E8580", Slot = "15")]
		public sealed override string MEHLBYWTUHU(IReadOnlyList<QNRWKFGEPMB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x28E8BE0", Offset = "0x28E7FE0", VA = "0x1828E8BE0", Slot = "12")]
		public override bool UEETEZFSGGI([In] QNRWKFGEPMB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x28E8C30", Offset = "0x28E8030", VA = "0x1828E8C30")]
		public bool UEETEZFSGGI([In] WYQCGJGFTYO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x28E82B0", Offset = "0x28E76B0", VA = "0x1828E82B0", Slot = "18")]
		public bool Equals(WYQCGJGFTYO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x28E8260", Offset = "0x28E7660", VA = "0x1828E8260", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x28E9050", Offset = "0x28E8450", VA = "0x1828E9050", Slot = "14")]
		protected override int ZUYWFXBSALX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x28E8250", Offset = "0x28E7650", VA = "0x1828E8250", Slot = "19")]
		private bool EZJYGXKDXRH([In] WYQCGJGFTYO other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class EXUUGFHZTNZ
	{
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public static readonly IReadOnlyList<QNRWKFGEPMB> YTJCZLZONJE;

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public static readonly IEnumerable<WYQCGJGFTYO> KONODILVNKH;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public static readonly IReadOnlyDictionary<string, BZCOEZMOZWN> WAZKFRYECSG;

		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public static readonly IReadOnlyDictionary<string, Property> OFPHJFWYRCS;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly IReadOnlyDictionary<string, DWSSBPFWIDI> WYZDWWQVZPF;
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public sealed class NYCESKETMPM : IEquatable<NYCESKETMPM>, VHVQTMURGOZ<NYCESKETMPM>, FSUVRUUTBIE
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public QNRWKFGEPMB FHKJLFTGJNM
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xAAF9B0", Offset = "0xAAEDB0", VA = "0x180AAF9B0")]
		private NYCESKETMPM(QNRWKFGEPMB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x28E43B0", Offset = "0x28E37B0", VA = "0x1828E43B0")]
		public static NYCESKETMPM New(QNRWKFGEPMB type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x289E430", Offset = "0x289D830", VA = "0x18289E430", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x28E42C0", Offset = "0x28E36C0", VA = "0x1828E42C0")]
		public bool UEETEZFSGGI([In] NYCESKETMPM other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x28E4360", Offset = "0x28E3760", VA = "0x1828E4360", Slot = "4")]
		public bool Equals(NYCESKETMPM other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x28E4310", Offset = "0x28E3710", VA = "0x1828E4310", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x28B6E70", Offset = "0x28B6270", VA = "0x1828B6E70", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x28E4410", Offset = "0x28E3810", VA = "0x1828E4410", Slot = "6")]
		public int ZQBTNATPPTH(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x28E42C0", Offset = "0x28E36C0", VA = "0x1828E42C0", Slot = "5")]
		private bool ALIAKYAHMMN([In] NYCESKETMPM other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public sealed class TCZCIFCFLZR : IEquatable<TCZCIFCFLZR>, VHVQTMURGOZ<TCZCIFCFLZR>, FSUVRUUTBIE
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public QNRWKFGEPMB FHKJLFTGJNM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xAAF9B0", Offset = "0xAAEDB0", VA = "0x180AAF9B0")]
		private TCZCIFCFLZR(QNRWKFGEPMB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x28E6070", Offset = "0x28E5470", VA = "0x1828E6070")]
		public static TCZCIFCFLZR New(QNRWKFGEPMB type)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x289E430", Offset = "0x289D830", VA = "0x18289E430", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x28E42C0", Offset = "0x28E36C0", VA = "0x1828E42C0")]
		public bool UEETEZFSGGI([In] TCZCIFCFLZR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x28E4360", Offset = "0x28E3760", VA = "0x1828E4360", Slot = "4")]
		public bool Equals(TCZCIFCFLZR other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x28E6020", Offset = "0x28E5420", VA = "0x1828E6020", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x28B6E70", Offset = "0x28B6270", VA = "0x1828B6E70", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x28E4410", Offset = "0x28E3810", VA = "0x1828E4410", Slot = "6")]
		public int ZQBTNATPPTH(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x28E42C0", Offset = "0x28E36C0", VA = "0x1828E42C0", Slot = "5")]
		private bool XLJOAHELECK([In] TCZCIFCFLZR other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public sealed class DWSSBPFWIDI : FEFXCAZHZKT, IEquatable<DWSSBPFWIDI>, VHVQTMURGOZ<DWSSBPFWIDI>, FSUVRUUTBIE
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public IReadOnlyList<KeyValuePair<string, NYCESKETMPM>> RRYSHSHPAOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BE0", Offset = "0xAA2FE0", VA = "0x180AA3BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IReadOnlyList<KeyValuePair<string, TCZCIFCFLZR>> QUTTGNLZPPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BC0", Offset = "0xAA2FC0", VA = "0x180AA3BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x28E1FD0", Offset = "0x28E13D0", VA = "0x1828E1FD0")]
		private DWSSBPFWIDI(IEnumerable<BZCOEZMOZWN> a, IEnumerable<KeyValuePair<string, NYCESKETMPM>> b, IEnumerable<KeyValuePair<string, TCZCIFCFLZR>> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x28E1810", Offset = "0x28E0C10", VA = "0x1828E1810")]
		public static DWSSBPFWIDI New(IEnumerable<BZCOEZMOZWN> typeParameters, IEnumerable<KeyValuePair<string, NYCESKETMPM>> inputs, IEnumerable<KeyValuePair<string, TCZCIFCFLZR>> outputs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x28E1940", Offset = "0x28E0D40", VA = "0x1828E1940", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x28E17F0", Offset = "0x28E0BF0", VA = "0x1828E17F0", Slot = "15")]
		public sealed override string MEHLBYWTUHU(IReadOnlyList<QNRWKFGEPMB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x28E1670", Offset = "0x28E0A70", VA = "0x1828E1670")]
		private string LAWKWIUGUYD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x28E1D70", Offset = "0x28E1170", VA = "0x1828E1D70")]
		private string UHPKFTJHYWA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x28E1C40", Offset = "0x28E1040", VA = "0x1828E1C40", Slot = "12")]
		public override bool UEETEZFSGGI([In] QNRWKFGEPMB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x28E1C90", Offset = "0x28E1090", VA = "0x1828E1C90")]
		public bool UEETEZFSGGI([In] DWSSBPFWIDI other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x28E15F0", Offset = "0x28E09F0", VA = "0x1828E15F0", Slot = "18")]
		public bool Equals(DWSSBPFWIDI other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x28E1610", Offset = "0x28E0A10", VA = "0x1828E1610", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x28E1EF0", Offset = "0x28E12F0", VA = "0x1828E1EF0", Slot = "14")]
		protected sealed override int ZUYWFXBSALX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x28E1660", Offset = "0x28E0A60", VA = "0x1828E1660", Slot = "19")]
		private bool KNDCEXLJSZF([In] DWSSBPFWIDI other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public sealed class VAGYNLGTLDV : QNRWKFGEPMB, IEquatable<VAGYNLGTLDV>, VHVQTMURGOZ<VAGYNLGTLDV>
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x28E81D0", Offset = "0x28E75D0", VA = "0x1828E81D0")]
		private VAGYNLGTLDV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x28E8040", Offset = "0x28E7440", VA = "0x1828E8040")]
		public static VAGYNLGTLDV New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x28E80B0", Offset = "0x28E74B0", VA = "0x1828E80B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x28E7F50", Offset = "0x28E7350", VA = "0x1828E7F50", Slot = "15")]
		public override string MEHLBYWTUHU(IReadOnlyList<QNRWKFGEPMB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x28E8180", Offset = "0x28E7580", VA = "0x1828E8180", Slot = "16")]
		public override int YIHGAAKQDKN(IReadOnlyList<QNRWKFGEPMB> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x28E8130", Offset = "0x28E7530", VA = "0x1828E8130", Slot = "17")]
		public override bool YDAIVXSYAWU(IReadOnlyList<QNRWKFGEPMB> a, IReadOnlyList<QNRWKFGEPMB> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x28E80E0", Offset = "0x28E74E0", VA = "0x1828E80E0", Slot = "12")]
		public override bool UEETEZFSGGI([In] QNRWKFGEPMB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x28E31A0", Offset = "0x28E25A0", VA = "0x1828E31A0")]
		public bool UEETEZFSGGI([In] VAGYNLGTLDV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xCA3190", Offset = "0xCA2590", VA = "0x180CA3190", Slot = "18")]
		public bool Equals(VAGYNLGTLDV other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x28E7F00", Offset = "0x28E7300", VA = "0x1828E7F00", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x28E31A0", Offset = "0x28E25A0", VA = "0x1828E31A0", Slot = "19")]
		private bool HYVSPCENSPA([In] VAGYNLGTLDV other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class Property : IEquatable<Property>, VHVQTMURGOZ<Property>, FSUVRUUTBIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool XCLRTPLZDWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private int SUAKFQEWYNX;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public QNRWKFGEPMB FHKJLFTGJNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool AQPAATTJYNU
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xBFA2C0", Offset = "0xBF96C0", VA = "0x180BFA2C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool WZSKLFFVIZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xF789C0", Offset = "0xF77DC0", VA = "0x180F789C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x28E4C90", Offset = "0x28E4090", VA = "0x1828E4C90")]
		private Property(QNRWKFGEPMB type, bool get, bool set)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x28E4810", Offset = "0x28E3C10", VA = "0x1828E4810")]
		public static Property New(QNRWKFGEPMB type, bool get, bool set)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x28E4940", Offset = "0x28E3D40", VA = "0x1828E4940", Slot = "3")]
		public sealed override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x28E48F0", Offset = "0x28E3CF0", VA = "0x1828E48F0")]
		private string SPHTPNVQYKS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x28E48A0", Offset = "0x28E3CA0", VA = "0x1828E48A0")]
		private string SIVWINHBBIW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x28E4A20", Offset = "0x28E3E20", VA = "0x1828E4A20")]
		public bool UEETEZFSGGI([In] Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x28E4720", Offset = "0x28E3B20", VA = "0x1828E4720", Slot = "4")]
		public bool Equals(Property other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x28E46D0", Offset = "0x28E3AD0", VA = "0x1828E46D0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x28E4740", Offset = "0x28E3B40", VA = "0x1828E4740", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x28E4BE0", Offset = "0x28E3FE0", VA = "0x1828E4BE0")]
		private int ZUYWFXBSALX()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x28E4B20", Offset = "0x28E3F20", VA = "0x1828E4B20", Slot = "6")]
		public int ZQBTNATPPTH(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x28E4800", Offset = "0x28E3C00", VA = "0x1828E4800", Slot = "5")]
		private bool KTFTURBOQPI([In] Property other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class JTGXDGYBHXC : QNRWKFGEPMB, IEquatable<JTGXDGYBHXC>, VHVQTMURGOZ<JTGXDGYBHXC>
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x28E3910", Offset = "0x28E2D10", VA = "0x1828E3910")]
		private JTGXDGYBHXC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x28E3820", Offset = "0x28E2C20", VA = "0x1828E3820")]
		public static JTGXDGYBHXC New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x28E3890", Offset = "0x28E2C90", VA = "0x1828E3890", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x28E37A0", Offset = "0x28E2BA0", VA = "0x1828E37A0", Slot = "15")]
		public override string MEHLBYWTUHU(IReadOnlyList<QNRWKFGEPMB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x28E38C0", Offset = "0x28E2CC0", VA = "0x1828E38C0", Slot = "12")]
		public override bool UEETEZFSGGI([In] QNRWKFGEPMB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x28E31A0", Offset = "0x28E25A0", VA = "0x1828E31A0")]
		public bool UEETEZFSGGI([In] JTGXDGYBHXC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xCA3190", Offset = "0xCA2590", VA = "0x180CA3190", Slot = "18")]
		public bool Equals(JTGXDGYBHXC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x28E3750", Offset = "0x28E2B50", VA = "0x1828E3750", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x28E31A0", Offset = "0x28E25A0", VA = "0x1828E31A0", Slot = "19")]
		private bool PDUASKMBBAL([In] JTGXDGYBHXC other)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public enum TypeKind
	{
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		Any,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		Boolean,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		Int32,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		Single,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		String,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Exec,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Error,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		Array,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		Tuple,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		Union,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		Class,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		Function,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		TypeParameter,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		TypeParameterReference,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		AppliedGeneric,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		Intersection
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public sealed class ODCDBDVUTTA : QNRWKFGEPMB, IEquatable<ODCDBDVUTTA>, VHVQTMURGOZ<ODCDBDVUTTA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string OVNHSEVRRUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public sealed override bool BUQHWTRKOUY
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xABDC90", Offset = "0xABD090", VA = "0x180ABDC90", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x28E4540", Offset = "0x28E3940", VA = "0x1828E4540", Slot = "9")]
		public sealed override QNRWKFGEPMB QZRIQXSKSDU(IReadOnlyDictionary<string, QNRWKFGEPMB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x28E4490", Offset = "0x28E3890", VA = "0x1828E4490", Slot = "11")]
		public sealed override void HAXQZBWHRZM(Action<QNRWKFGEPMB> a, Action<QNRWKFGEPMB> b, Action<QNRWKFGEPMB> c, Action<QNRWKFGEPMB> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x28E4690", Offset = "0x28E3A90", VA = "0x1828E4690")]
		private ODCDBDVUTTA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x28E44C0", Offset = "0x28E38C0", VA = "0x1828E44C0")]
		public static ODCDBDVUTTA New(string name)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x28E4620", Offset = "0x28E3A20", VA = "0x1828E4620", Slot = "12")]
		public override bool UEETEZFSGGI([In] QNRWKFGEPMB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x28E31A0", Offset = "0x28E25A0", VA = "0x1828E31A0")]
		public bool UEETEZFSGGI([In] ODCDBDVUTTA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xCA3190", Offset = "0xCA2590", VA = "0x180CA3190", Slot = "18")]
		public bool Equals(ODCDBDVUTTA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x28E4440", Offset = "0x28E3840", VA = "0x1828E4440", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x28E4670", Offset = "0x28E3A70", VA = "0x1828E4670", Slot = "14")]
		protected sealed override int ZUYWFXBSALX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x28E31A0", Offset = "0x28E25A0", VA = "0x1828E31A0", Slot = "19")]
		private bool NVBABVVLDIH([In] ODCDBDVUTTA other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public abstract class FEFXCAZHZKT : QNRWKFGEPMB
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public IEnumerable<BZCOEZMOZWN> FMSFUZQXQIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C00", Offset = "0xAA3000", VA = "0x180AA3C00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x28E2F60", Offset = "0x28E2360", VA = "0x1828E2F60")]
		public void Initialize(FEFXCAZHZKT from)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x28E30F0", Offset = "0x28E24F0", VA = "0x1828E30F0")]
		protected FEFXCAZHZKT(IEnumerable<BZCOEZMOZWN> a, TypeKind b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract override bool UEETEZFSGGI([In] QNRWKFGEPMB other);

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x28E2F90", Offset = "0x28E2390", VA = "0x1828E2F90")]
		protected bool UEETEZFSGGI([In] FEFXCAZHZKT other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x28E3070", Offset = "0x28E2470", VA = "0x1828E3070", Slot = "14")]
		protected override int ZUYWFXBSALX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x28E2FF0", Offset = "0x28E23F0", VA = "0x1828E2FF0")]
		protected int VFAEXBRXELN(int a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public sealed class BZCOEZMOZWN : QNRWKFGEPMB, IEquatable<BZCOEZMOZWN>, VHVQTMURGOZ<BZCOEZMOZWN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string OVNHSEVRRUV
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public QNRWKFGEPMB XPGWJFOQOLL
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BE0", Offset = "0xAA2FE0", VA = "0x180AA3BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x28E08D0", Offset = "0x28DFCD0", VA = "0x1828E08D0")]
		private BZCOEZMOZWN(string a, [Optional] QNRWKFGEPMB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x28E05B0", Offset = "0x28DF9B0", VA = "0x1828E05B0")]
		public static BZCOEZMOZWN New(string name, [Optional] QNRWKFGEPMB constraint)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x28E0700", Offset = "0x28DFB00", VA = "0x1828E0700", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x28E0790", Offset = "0x28DFB90", VA = "0x1828E0790", Slot = "12")]
		public override bool UEETEZFSGGI([In] QNRWKFGEPMB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x28E06B0", Offset = "0x28DFAB0", VA = "0x1828E06B0")]
		public bool UEETEZFSGGI([In] BZCOEZMOZWN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x28E0560", Offset = "0x28DF960", VA = "0x1828E0560", Slot = "18")]
		public bool Equals(BZCOEZMOZWN other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x28E0510", Offset = "0x28DF910", VA = "0x1828E0510", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x28E0850", Offset = "0x28DFC50", VA = "0x1828E0850", Slot = "14")]
		protected override int ZUYWFXBSALX(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x28E07E0", Offset = "0x28DFBE0", VA = "0x1828E07E0", Slot = "13")]
		public override int ZQBTNATPPTH(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x28E06B0", Offset = "0x28DFAB0", VA = "0x1828E06B0", Slot = "19")]
		private bool QLXRPQPEKHY([In] BZCOEZMOZWN other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public sealed class RZPSSINKPDP : QNRWKFGEPMB, IEquatable<RZPSSINKPDP>, VHVQTMURGOZ<RZPSSINKPDP>
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x28E5F70", Offset = "0x28E5370", VA = "0x1828E5F70")]
		private RZPSSINKPDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x28E5DE0", Offset = "0x28E51E0", VA = "0x1828E5DE0")]
		public static RZPSSINKPDP New()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x28E5E50", Offset = "0x28E5250", VA = "0x1828E5E50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x28E5CF0", Offset = "0x28E50F0", VA = "0x1828E5CF0", Slot = "15")]
		public override string MEHLBYWTUHU(IReadOnlyList<QNRWKFGEPMB> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x28E5F20", Offset = "0x28E5320", VA = "0x1828E5F20", Slot = "16")]
		public override int YIHGAAKQDKN(IReadOnlyList<QNRWKFGEPMB> a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x28E5ED0", Offset = "0x28E52D0", VA = "0x1828E5ED0", Slot = "17")]
		public override bool YDAIVXSYAWU(IReadOnlyList<QNRWKFGEPMB> a, IReadOnlyList<QNRWKFGEPMB> b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x28E5E80", Offset = "0x28E5280", VA = "0x1828E5E80", Slot = "12")]
		public override bool UEETEZFSGGI([In] QNRWKFGEPMB other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x28E31A0", Offset = "0x28E25A0", VA = "0x1828E31A0")]
		public bool UEETEZFSGGI([In] RZPSSINKPDP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xCA3190", Offset = "0xCA2590", VA = "0x180CA3190", Slot = "18")]
		public bool Equals(RZPSSINKPDP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x28E5CA0", Offset = "0x28E50A0", VA = "0x1828E5CA0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x28E31A0", Offset = "0x28E25A0", VA = "0x1828E31A0", Slot = "19")]
		private bool QSEOWUSJVVE([In] RZPSSINKPDP other)
		{
			return default(bool);
		}
	}
}
namespace Circuits.Static.Core.TypeSystem.Factory
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public readonly struct CircuitTypeOrString
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		private readonly struct Impl
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public readonly QNRWKFGEPMB CircuitType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public readonly string TypeParameterReference;

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xE16830", Offset = "0xE15C30", VA = "0x180E16830")]
			internal Impl(QNRWKFGEPMB circuitType, string typeParameterReference)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		private enum TypeOrStringKind
		{
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			CircuitType,
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			TypeParameterReference
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly Impl _impl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly TypeOrStringKind _kind;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x28E0C20", Offset = "0x28E0020", VA = "0x1828E0C20")]
		private CircuitTypeOrString([In] Impl impl, TypeOrStringKind kind)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x28E0B50", Offset = "0x28DFF50", VA = "0x1828E0B50")]
		public static CircuitTypeOrString YSDZFNHCUER(string a)
		{
			return default(CircuitTypeOrString);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x28E0BC0", Offset = "0x28DFFC0", VA = "0x1828E0BC0")]
		public static CircuitTypeOrString YSDZFNHCUER(QNRWKFGEPMB a)
		{
			return default(CircuitTypeOrString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x28E0990", Offset = "0x28DFD90", VA = "0x1828E0990")]
		public QNRWKFGEPMB LIIAMZPZYNC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x28E0A30", Offset = "0x28DFE30", VA = "0x1828E0A30")]
		public static QNRWKFGEPMB[] RNNLLHCDXAL(CircuitTypeOrString[] a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct ClassFactoryBaseClasses
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly INGNSGGDQWI _data;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
		private ClassFactoryBaseClasses(INGNSGGDQWI data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xE07730", Offset = "0xE06B30", VA = "0x180E07730")]
		public static ClassFactoryBaseClasses New(INGNSGGDQWI data)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x28E0C50", Offset = "0x28E0050", VA = "0x1828E0C50")]
		public ClassFactoryBaseClasses DPSZFOMVOLQ(WYQCGJGFTYO a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x159D1E0", Offset = "0x159C5E0", VA = "0x18159D1E0")]
		public ClassFactoryProps GYVZBSLETRP()
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x28E0D10", Offset = "0x28E0110", VA = "0x1828E0D10")]
		public ClassFactoryProps RATOHZLYJHE(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x28E0D70", Offset = "0x28E0170", VA = "0x1828E0D70")]
		public WYQCGJGFTYO SMCVKRDMXBZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public sealed class INGNSGGDQWI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly Guid? KVDFRQPXLVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly string OVNHSEVRRUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public List<BZCOEZMOZWN> FMSFUZQXQIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public List<WYQCGJGFTYO> GJRZWJRTQGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public List<KeyValuePair<string, Property>> JLCRPLVBGMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public List<KeyValuePair<string, DWSSBPFWIDI>> NKETVNQRVAT;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x28E35C0", Offset = "0x28E29C0", VA = "0x1828E35C0")]
		private INGNSGGDQWI([In] Guid? id, string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x28E3410", Offset = "0x28E2810", VA = "0x1828E3410")]
		public static INGNSGGDQWI New([In] Guid? id, string name)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public readonly struct ClassFactoryFuncs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly INGNSGGDQWI _data;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
		private ClassFactoryFuncs(INGNSGGDQWI data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xE07730", Offset = "0xE06B30", VA = "0x180E07730")]
		public static ClassFactoryFuncs New(INGNSGGDQWI data)
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x28E0DC0", Offset = "0x28E01C0", VA = "0x1828E0DC0")]
		public WYQCGJGFTYO SMCVKRDMXBZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public readonly struct ClassFactoryProps
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private readonly INGNSGGDQWI _data;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
		public ClassFactoryProps(INGNSGGDQWI data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x28E0F10", Offset = "0x28E0310", VA = "0x1828E0F10")]
		public ClassFactoryProps RATOHZLYJHE(string a, [In] CircuitTypeOrString type, GetSet b = GetSet.Get)
		{
			return default(ClassFactoryProps);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x159D1E0", Offset = "0x159C5E0", VA = "0x18159D1E0")]
		public ClassFactoryFuncs XONGRRWRCLS()
		{
			return default(ClassFactoryFuncs);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x28E10A0", Offset = "0x28E04A0", VA = "0x1828E10A0")]
		public WYQCGJGFTYO SMCVKRDMXBZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public readonly struct ClassFactoryTypeParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly INGNSGGDQWI _data;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
		private ClassFactoryTypeParams(INGNSGGDQWI data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x28E13C0", Offset = "0x28E07C0", VA = "0x1828E13C0")]
		public static ClassFactoryTypeParams New(Guid? id, string name)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x28E1120", Offset = "0x28E0520", VA = "0x1828E1120")]
		public ClassFactoryTypeParams GEQURURIUZO(string a, [Optional][In] CircuitTypeOrString? constraint)
		{
			return default(ClassFactoryTypeParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x159D1E0", Offset = "0x159C5E0", VA = "0x18159D1E0")]
		public ClassFactoryBaseClasses JNQNSBFWSZG()
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x28E10E0", Offset = "0x28E04E0", VA = "0x1828E10E0")]
		public ClassFactoryBaseClasses DPSZFOMVOLQ(WYQCGJGFTYO a)
		{
			return default(ClassFactoryBaseClasses);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x28E1590", Offset = "0x28E0990", VA = "0x1828E1590")]
		public WYQCGJGFTYO SMCVKRDMXBZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[Flags]
	public enum GetSet
	{
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		Get = 1,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		Set = 2,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		GetSet = 3
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
