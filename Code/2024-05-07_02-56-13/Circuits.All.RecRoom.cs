using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Circuits.Shared.Api;
using Circuits.Static.Api;
using Cpp2IlInjected;
using Google.Protobuf;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1E24F00", Offset = "0x1E24100", VA = "0x181E24F00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DF880", Offset = "0x7DEA80", VA = "0x1807DF880")]
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

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DF8C0", Offset = "0x7DEAC0", VA = "0x1807DF8C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class FKPPOCEMHDG : IDisposable, LJFDDMKPFNK, EDDGEPLIMPB, JPBBMHHIAJI, PLEPLMHHNFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class BFDHIKFHKMP : ABNLECENPCO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public abstract int DGEOLJJLLIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1E0B500", Offset = "0x1E0A700", VA = "0x181E0B500", Slot = "5")]
		public CLDLIPEIJJP BKEIGKGCHNK(PLJJCEDCEKJ.DPLJPOABHEK NMAKCOKENKA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "11")]
		public abstract void LBDGOJPEEIA();

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "12")]
		public abstract void DBBADELHNLA();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1E0B650", Offset = "0x1E0A850", VA = "0x181E0B650", Slot = "13")]
		public virtual void NCDKMAGKJDH(FKPPOCEMHDG GDABCJDBLDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1E0B690", Offset = "0x1E0A890", VA = "0x181E0B690", Slot = "14")]
		public virtual void NEJBKHMBFHL(FKPPOCEMHDG GDABCJDBLDL, DIGPMMNJEIB GKGLDBAJJCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		protected BFDHIKFHKMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface ABNLECENPCO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		int DGEOLJJLLIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		CLDLIPEIJJP BKEIGKGCHNK(PLJJCEDCEKJ.DPLJPOABHEK NMAKCOKENKA);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LBDGOJPEEIA();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void DBBADELHNLA();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void NCDKMAGKJDH(FKPPOCEMHDG GDABCJDBLDL);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void NEJBKHMBFHL(FKPPOCEMHDG GDABCJDBLDL, DIGPMMNJEIB GKGLDBAJJCH);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct MKAHGGAODNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly GJFNHENNBOO<GBPKHNJBGED, DIGPMMNJEIB, FKPPOCEMHDG, MDFHMEIIDDC.HIKMGFAPFPD<GBPKHNJBGED, DIGPMMNJEIB, FKPPOCEMHDG>> DBCBMKAAOGI;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1E23E10", Offset = "0x1E23010", VA = "0x181E23E10")]
		internal MKAHGGAODNG(GJFNHENNBOO<GBPKHNJBGED, DIGPMMNJEIB, FKPPOCEMHDG, MDFHMEIIDDC.HIKMGFAPFPD<GBPKHNJBGED, DIGPMMNJEIB, FKPPOCEMHDG>> PFGBPGKFOLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public sealed class IBKAFHHBOKI : MDFHMEIIDDC.HIKMGFAPFPD<GBPKHNJBGED, DIGPMMNJEIB, FKPPOCEMHDG>
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public static readonly IBKAFHHBOKI KMGHIJMKCHH;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		private IBKAFHHBOKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xAC6ED0", Offset = "0xAC60D0", VA = "0x180AC6ED0", Slot = "4")]
		public GBPKHNJBGED MJDLEDELCFK(DIGPMMNJEIB KNKOEEEKHDK)
		{
			return default(GBPKHNJBGED);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1E13F60", Offset = "0x1E13160", VA = "0x181E13F60", Slot = "5")]
		public void NCDKMAGKJDH(FKPPOCEMHDG MIAAKEAGJGI, DIGPMMNJEIB GKGLDBAJJCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1E14070", Offset = "0x1E13270", VA = "0x181E14070", Slot = "6")]
		public void NEJBKHMBFHL(FKPPOCEMHDG MIAAKEAGJGI, DIGPMMNJEIB GKGLDBAJJCH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct CAKLDNIGGKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public JLEBMEOEKFB<GBPKHNJBGED, DIGPMMNJEIB, FKPPOCEMHDG, MDFHMEIIDDC.HIKMGFAPFPD<GBPKHNJBGED, DIGPMMNJEIB, FKPPOCEMHDG>> DBCBMKAAOGI;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1E0C420", Offset = "0x1E0B620", VA = "0x181E0C420")]
		internal CAKLDNIGGKD(JLEBMEOEKFB<GBPKHNJBGED, DIGPMMNJEIB, FKPPOCEMHDG, MDFHMEIIDDC.HIKMGFAPFPD<GBPKHNJBGED, DIGPMMNJEIB, FKPPOCEMHDG>> PFGBPGKFOLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1E0C3D0", Offset = "0x1E0B5D0", VA = "0x181E0C3D0")]
		public static CAKLDNIGGKD MIJABIECKKD()
		{
			return default(CAKLDNIGGKD);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public readonly struct MFFDFDFNGKG : MJAHKGBLMAK.MMGEAFANICP<DIGPMMNJEIB, FKPPOCEMHDG>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct KHAHNCPBNME : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public AsyncTaskMethodBuilder<NFMFLMAOFMP<object, CEGADOEINOB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public FKPPOCEMHDG receiver;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public DIGPMMNJEIB action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public MFFDFDFNGKG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private TaskAwaiter<NFMFLMAOFMP<object, CEGADOEINOB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x1E1F850", Offset = "0x1E1EA50", VA = "0x181E1F850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x1E1FA30", Offset = "0x1E1EC30", VA = "0x181E1FA30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xAEAF80", Offset = "0xAEA180", VA = "0x180AEAF80", Slot = "4")]
		public EIPPGFCFCGI<JMEIIMJEHGK> JKODCJBKNKB(FKPPOCEMHDG LNCHGILPLKL)
		{
			return default(EIPPGFCFCGI<JMEIIMJEHGK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1E235E0", Offset = "0x1E227E0", VA = "0x181E235E0", Slot = "5")]
		[AsyncStateMachine(typeof(KHAHNCPBNME))]
		public Task<NFMFLMAOFMP<object, CEGADOEINOB>> APAHPNBMFEJ(FKPPOCEMHDG LNCHGILPLKL, DIGPMMNJEIB GKGLDBAJJCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1E23710", Offset = "0x1E22910", VA = "0x181E23710", Slot = "6")]
		public DIGPMMNJEIB[] FLDGMLDNHFJ(FKPPOCEMHDG LNCHGILPLKL)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct CAHOCBBLIGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<bool, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public FKPPOCEMHDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public GFJGOLELJHO rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public DJDLMEOOMEF circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public CCLNCFGAMPK superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<NFMFLMAOFMP<bool, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1E0C0E0", Offset = "0x1E0B2E0", VA = "0x181E0C0E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1E0C360", Offset = "0x1E0B560", VA = "0x181E0C360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct LHGACABIMPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<bool, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public FKPPOCEMHDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter<NFMFLMAOFMP<bool, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1E22580", Offset = "0x1E21780", VA = "0x181E22580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1E22810", Offset = "0x1E21A10", VA = "0x181E22810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct HPPPIFNJMKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public FKPPOCEMHDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1E13D10", Offset = "0x1E12F10", VA = "0x181E13D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1E13EF0", Offset = "0x1E130F0", VA = "0x181E13EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct GALDLCCNFNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<object, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public FKPPOCEMHDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public DIGPMMNJEIB action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<NFMFLMAOFMP<object, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1E119D0", Offset = "0x1E10BD0", VA = "0x181E119D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1E11BC0", Offset = "0x1E10DC0", VA = "0x181E11BC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct LGLEHJPJILB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public FKPPOCEMHDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Guid rootGraphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private TaskAwaiter<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private TaskAwaiter<NFMFLMAOFMP<bool, CEGADOEINOB>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1E21D20", Offset = "0x1E20F20", VA = "0x181E21D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x1E22510", Offset = "0x1E21710", VA = "0x181E22510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly EIPPGFCFCGI<JMEIIMJEHGK> OIOLBIHLHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly MKAHGGAODNG PNKCNPAAEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly AMFBLGPKICG PJPJDMOFALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal readonly OLELGNMHKCE JBPEEMFOBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11B0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal readonly BJDHOEFBLAH OOEJLJJBLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11B8")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal readonly EAIIAMCBMDN.HGIKPGOCGMK DOFALJLPGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11D8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal readonly JDDJGCBHEBI NDNLIPNNDML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11E0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal readonly OKNNAKCPKIP GPHIEEJHMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11E8")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal readonly DEBCCENOCPC KIBGAONCJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11F0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	internal readonly PCFDNJHGACP ELOGAHCLIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11F8")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	internal readonly DPIEHCMAHJP IDDGKNFBHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1200")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private PEBGGPPIEBH LEGJIHCOKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1210")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private GNPCOMEKKME MEMNDKMABEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1230")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	internal readonly AMFBLGPKICG.AJBBELFIHEG GMNLJOBAIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1238")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	internal readonly HHCLIDDFNIF HOGBKPNFHFJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public AMFBLGPKICG BKBFGDHFOAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1E0FC70", Offset = "0x1E0EE70", VA = "0x181E0FC70")]
		get
		{
			return default(AMFBLGPKICG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	internal ABNLECENPCO FMDKOOAGBEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1E10080", Offset = "0x1E0F280", VA = "0x181E10080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	internal CLDLIPEIJJP BEPAMMOMDFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1E10B00", Offset = "0x1E0FD00", VA = "0x181E10B00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1E10060", Offset = "0x1E0F260", VA = "0x181E10060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	internal bool BLHBDHAGMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1E10B10", Offset = "0x1E0FD10", VA = "0x181E10B10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1E0FC80", Offset = "0x1E0EE80", VA = "0x181E0FC80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public NAFFMBHJLAJ AHNBOGCDPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1E11420", Offset = "0x1E10620", VA = "0x181E11420", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JDJBJIGCLGK FALLMGMMJKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1E11440", Offset = "0x1E10640", VA = "0x181E11440", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JALLCABCOMH NBHJCMKLAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1E11460", Offset = "0x1E10660", VA = "0x181E11460", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HHPBEBCFENC BBGJFOHJHKD
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1E11430", Offset = "0x1E10630", VA = "0x181E11430", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public ALKODGDMFJE ELBNMEBEDCG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1E11450", Offset = "0x1E10650", VA = "0x181E11450", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private GAKHKEICBEM? IIHIAMHBEJB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1E0FB40", Offset = "0x1E0ED40", VA = "0x181E0FB40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private AEENHPBKOMB? BFKJDBCBNPG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1E10B20", Offset = "0x1E0FD20", VA = "0x181E10B20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1E110E0", Offset = "0x1E102E0", VA = "0x181E110E0")]
	private FKPPOCEMHDG(BJDHOEFBLAH PAPKKIABFGP, EIPPGFCFCGI<JMEIIMJEHGK> BMIJGDHAHBI, [In] MKAHGGAODNG OEOGIAAPLHH, [In] AMFBLGPKICG OAPLEAAIAID, [In] OLELGNMHKCE KKGBLCONAIA, CLDLIPEIJJP KLBHHAIPODM, [In] EAIIAMCBMDN.HGIKPGOCGMK ABAMDHCBKKM, AMFBLGPKICG.AJBBELFIHEG CFHJDJJIGOE, HHCLIDDFNIF BLHPCOMJBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1E10C50", Offset = "0x1E0FE50", VA = "0x181E10C50")]
	public static FKPPOCEMHDG MIJABIECKKD(BJDHOEFBLAH NMAKCOKENKA, [In] IBMBPODCFCG LPELOOFKLIA, ACINADBALPO OHBFFFICCFD, [In] CFHDJEFBFEI NFFKJHAMILL, GIILNPDBKNL HDGGLKOEGKI, EIPPGFCFCGI<JMEIIMJEHGK> BMIJGDHAHBI, EIPPGFCFCGI<PCGKILKNHFD> MCBFBACEICH, DKEELGMMLPH NLAJPGFICGO, BOLCPOCGNAG JKCMGJDDALN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1E10D90", Offset = "0x1E0FF90", VA = "0x181E10D90")]
	public static FKPPOCEMHDG MIJABIECKKD(BJDHOEFBLAH PAPKKIABFGP, [In] AMFBLGPKICG OAPLEAAIAID, [In] OLELGNMHKCE KKGBLCONAIA, EIPPGFCFCGI<JMEIIMJEHGK> BMIJGDHAHBI, EIPPGFCFCGI<PCGKILKNHFD> MCBFBACEICH, DKEELGMMLPH NLAJPGFICGO, BOLCPOCGNAG JKCMGJDDALN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1E0FE70", Offset = "0x1E0F070", VA = "0x181E0FE70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1E0FC90", Offset = "0x1E0EE90", VA = "0x181E0FC90")]
	[AsyncStateMachine(typeof(CAHOCBBLIGC))]
	internal Task<NFMFLMAOFMP<bool, CEGADOEINOB>> CCHNHLHIGAF(GFJGOLELJHO PJICPHGJFFE, DJDLMEOOMEF BLPMIMDGIJB, CCLNCFGAMPK JFLFEABOIJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1E10900", Offset = "0x1E0FB00", VA = "0x181E10900")]
	[AsyncStateMachine(typeof(LHGACABIMPN))]
	public Task<NFMFLMAOFMP<bool, CEGADOEINOB>> JGHBDOIAMOM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1E101F0", Offset = "0x1E0F3F0", VA = "0x181E101F0")]
	[AsyncStateMachine(typeof(HPPPIFNJMKL))]
	public Task<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> FAPLPJCJBAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1E106F0", Offset = "0x1E0F8F0", VA = "0x181E106F0")]
	internal void HGIGKNLGDKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x1E10670", Offset = "0x1E0F870", VA = "0x181E10670")]
	internal PKNGEFGGMEI<DIGPMMNJEIB> GKAIAOFAEKA([In] AOEFCMEHINK HCLEICNBIAC)
	{
		return default(PKNGEFGGMEI<DIGPMMNJEIB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1E11070", Offset = "0x1E10270", VA = "0x181E11070")]
	internal bool POBOMLIFDFL([In] AOEFCMEHINK HCLEICNBIAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1E0FDF0", Offset = "0x1E0EFF0", VA = "0x181E0FDF0")]
	internal PKNGEFGGMEI<DIGPMMNJEIB> DMMLNCMMEJP([In] BOKCGLPLFFB JIPCIHEKKJG)
	{
		return default(PKNGEFGGMEI<DIGPMMNJEIB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1E109F0", Offset = "0x1E0FBF0", VA = "0x181E109F0")]
	[AsyncStateMachine(typeof(GALDLCCNFNG))]
	internal Task<NFMFLMAOFMP<object, CEGADOEINOB>> KNLGKPEDAFO(DIGPMMNJEIB GKGLDBAJJCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1E102E0", Offset = "0x1E0F4E0", VA = "0x181E102E0")]
	private DIGPMMNJEIB[] FLDGMLDNHFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1E100D0", Offset = "0x1E0F2D0", VA = "0x181E100D0")]
	[AsyncStateMachine(typeof(LGLEHJPJILB))]
	public Task<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> ELGPAHIDLPF(Guid GLBICENLAPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class PLBEGBOLGKK
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2A6CEF0", Offset = "0x2A6C0F0", VA = "0x182A6CEF0")]
	public static ILBDAPNGKND<(TPrev?, FKPPOCEMHDG?), AEENHPBKOMB> FAFFEAAEMDE<TPrev>([In] this ILBDAPNGKND<TPrev, FKPPOCEMHDG> KNKOEEEKHDK)
	{
		return default(ILBDAPNGKND<(TPrev, FKPPOCEMHDG), AEENHPBKOMB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x2A6D190", Offset = "0x2A6C390", VA = "0x182A6D190")]
	public static ILBDAPNGKND<TPrev?, FKPPOCEMHDG?> JDNDKMJLDBM<TPrev>([In] this ILBDAPNGKND<TPrev, FKPPOCEMHDG> KNKOEEEKHDK)
	{
		return default(ILBDAPNGKND<TPrev, FKPPOCEMHDG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class GBEPGFOOEGN<TData> : OMPNGPMCKPG, GOKDIBNJCLA, LNFCDOMCNGI where TData : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly BCFHHBLPOPP<FKGCAMGPCBC>? NKNDDENOHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly string EBIHFAEPEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly TData HCKHOAGNJJN;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public BCFHHBLPOPP<FKGCAMGPCBC>? EFBDPMOJGPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2012BA0", Offset = "0x2011DA0", VA = "0x182012BA0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7BE1A0", Offset = "0x7BD3A0", VA = "0x1807BE1A0", Slot = "7")]
	public override string FIHEJJCABJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x389E520", Offset = "0x389D720", VA = "0x18389E520")]
	internal GBEPGFOOEGN([In] BCFHHBLPOPP<FKGCAMGPCBC>? EOJLFOODHAI, EIPPGFCFCGI<HKCAPACBGFO>? FOJLACEJCGC, IOKind? FHPFGFHAOIA, string JGNAJPMGGNE, [In] TData FODGEDCJIDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class LDNHLOBEHDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1E203A0", Offset = "0x1E1F5A0", VA = "0x181E203A0")]
	public static NFMFLMAOFMP<DABDIBMGAMP, GOKDIBNJCLA> CCMADGFBOND([In] this HJPAIBIIKOP<HOHFCKNLABI> EHIAHPCMPAC)
	{
		return default(NFMFLMAOFMP<DABDIBMGAMP, GOKDIBNJCLA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x2980390", Offset = "0x297F590", VA = "0x182980390")]
	public static NFMFLMAOFMP<TOk, GOKDIBNJCLA> PHONFHICKMB<TOk>([In] this NFMFLMAOFMP<TOk, GOKDIBNJCLA> KNKOEEEKHDK, [In] BCFHHBLPOPP<FKGCAMGPCBC>? EOJLFOODHAI, EIPPGFCFCGI<HKCAPACBGFO>? FOJLACEJCGC, IOKind? FHPFGFHAOIA, string JGNAJPMGGNE) where TOk : notnull
	{
		return default(NFMFLMAOFMP<TOk, GOKDIBNJCLA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BJDHOEFBLAH
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	GJMJHGCJNDO.BLELGHKLNIO EJHADOLKOFN
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	PLJJCEDCEKJ.DPLJPOABHEK CMDGPBGMKCA
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	FKPPOCEMHDG.ABNLECENPCO PLBNNGGLCPL
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	IIEKEJODDAJ.CMEGGFNEODE DFFELDJPCDF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	MDFHMEIIDDC.HIKMGFAPFPD<GBPKHNJBGED, DIGPMMNJEIB, FKPPOCEMHDG> CGLADMNNHKE
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	OHAIMHJPJEG OJBJAGKOEAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	DHBKLDMOGOK MKPPLKKKDOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	NOGOJOLKHJB LGNMKEDKEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	CFHGLCGHIKK AAHJHLHLDKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	OMMKBCOOJFE BAPDMDOFBJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class HFOCEDLELEP
{
	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1E131D0", Offset = "0x1E123D0", VA = "0x181E131D0")]
	public static DIGPMMNJEIB MFOMLHPAOFD(this DIGPMMNJEIB KNKOEEEKHDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1E13100", Offset = "0x1E12300", VA = "0x181E13100")]
	public static DIGPMMNJEIB HMHKJBFEEOG(this LANJDAJJIGG KNKOEEEKHDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public readonly struct LANJDAJJIGG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct LPPGIDNJNNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<object, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public FKPPOCEMHDG root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public LANJDAJJIGG self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TaskAwaiter<NFMFLMAOFMP<object, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1E22C10", Offset = "0x1E21E10", VA = "0x181E22C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1E22ED0", Offset = "0x1E220D0", VA = "0x181E22ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly ByteString FJJHODHBEGH;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x94F0A0", Offset = "0x94E2A0", VA = "0x18094F0A0")]
	private LANJDAJJIGG(ByteString NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1E201F0", Offset = "0x1E1F3F0", VA = "0x181E201F0")]
	public static DIGPMMNJEIB PDGOGCHHDEL(ByteString NICEPFIEJED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1E20140", Offset = "0x1E1F340", VA = "0x181E20140")]
	public static GBKNCFEJMKO<GBPKHNJBGED, LANJDAJJIGG> KPAOMKFKLJO(DIGPMMNJEIB LODLPIONDBP)
	{
		return default(GBKNCFEJMKO<GBPKHNJBGED, LANJDAJJIGG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1E20030", Offset = "0x1E1F230", VA = "0x181E20030")]
	[AsyncStateMachine(typeof(LPPGIDNJNNM))]
	public static Task<NFMFLMAOFMP<object, CEGADOEINOB>> KNLGKPEDAFO(FKPPOCEMHDG MIAAKEAGJGI, LANJDAJJIGG KNKOEEEKHDK)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public readonly struct IMPGDIJLCJN
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1E17A40", Offset = "0x1E16C40", VA = "0x181E17A40")]
	public static DIGPMMNJEIB PDGOGCHHDEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1E179D0", Offset = "0x1E16BD0", VA = "0x181E179D0")]
	public static GBKNCFEJMKO<GBPKHNJBGED, IMPGDIJLCJN> KPAOMKFKLJO(DIGPMMNJEIB LODLPIONDBP)
	{
		return default(GBKNCFEJMKO<GBPKHNJBGED, IMPGDIJLCJN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x1E17950", Offset = "0x1E16B50", VA = "0x181E17950")]
	public static NFMFLMAOFMP<LKEAICJEMFK, NNADKGMIMDE> JBFFLKBLKCL(FKPPOCEMHDG MIAAKEAGJGI, [In] IMPGDIJLCJN KNKOEEEKHDK)
	{
		return default(NFMFLMAOFMP<LKEAICJEMFK, NNADKGMIMDE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public readonly struct NGEPNGKPGHE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private struct DGGIADBCEBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<LKEAICJEMFK, NNADKGMIMDE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public FKPPOCEMHDG root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NGEPNGKPGHE self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private NFMFLMAOFMP<LKEAICJEMFK, NNADKGMIMDE> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1E0EB00", Offset = "0x1E0DD00", VA = "0x181E0EB00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x1E0EE70", Offset = "0x1E0E070", VA = "0x181E0EE70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly GFJGOLELJHO? MCCFPKNFMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly DJDLMEOOMEF? PDIIFPFPAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly CCLNCFGAMPK? LBLOLBEMBOP;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1B72450", Offset = "0x1B71650", VA = "0x181B72450")]
	private NGEPNGKPGHE(GFJGOLELJHO? PJICPHGJFFE, DJDLMEOOMEF? BLPMIMDGIJB, CCLNCFGAMPK? JFLFEABOIJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x1E24E00", Offset = "0x1E24000", VA = "0x181E24E00")]
	public static DIGPMMNJEIB? PDGOGCHHDEL(GFJGOLELJHO? PJICPHGJFFE, DJDLMEOOMEF? BLPMIMDGIJB, CCLNCFGAMPK? JFLFEABOIJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1E24CF0", Offset = "0x1E23EF0", VA = "0x181E24CF0")]
	public static GBKNCFEJMKO<GBPKHNJBGED, NGEPNGKPGHE> KPAOMKFKLJO(DIGPMMNJEIB LODLPIONDBP)
	{
		return default(GBKNCFEJMKO<GBPKHNJBGED, NGEPNGKPGHE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1E24BB0", Offset = "0x1E23DB0", VA = "0x181E24BB0")]
	[AsyncStateMachine(typeof(DGGIADBCEBE))]
	public static Task<NFMFLMAOFMP<LKEAICJEMFK, NNADKGMIMDE>> KNLGKPEDAFO(FKPPOCEMHDG MIAAKEAGJGI, NGEPNGKPGHE KNKOEEEKHDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public readonly struct CCCKNINEDDG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private struct MFGLLCGJOEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<EDLPBBJOGBF, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CCCKNINEDDG self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public FKPPOCEMHDG root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private NFMFLMAOFMP<EDLPBBJOGBF, CEGADOEINOB> <r1>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private NFMFLMAOFMP<object, LNFCDOMCNGI>[] <aggregateResult>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private NFMFLMAOFMP<object, LNFCDOMCNGI> <r2>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private NFMFLMAOFMP<object, LNFCDOMCNGI>[] <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<NFMFLMAOFMP<object, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1E23730", Offset = "0x1E22930", VA = "0x181E23730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1E23BA0", Offset = "0x1E22DA0", VA = "0x181E23BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly IReadOnlyList<DIGPMMNJEIB> CLLPLMICAPF;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x94F0A0", Offset = "0x94E2A0", VA = "0x18094F0A0")]
	private CCCKNINEDDG(IReadOnlyList<DIGPMMNJEIB> KHONCCLLIFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1E0C610", Offset = "0x1E0B810", VA = "0x181E0C610")]
	public static DIGPMMNJEIB PDGOGCHHDEL(IReadOnlyList<DIGPMMNJEIB> KHONCCLLIFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1E0C570", Offset = "0x1E0B770", VA = "0x181E0C570")]
	public static GBKNCFEJMKO<GBPKHNJBGED, CCCKNINEDDG> KPAOMKFKLJO(DIGPMMNJEIB LODLPIONDBP)
	{
		return default(GBKNCFEJMKO<GBPKHNJBGED, CCCKNINEDDG>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1E0C430", Offset = "0x1E0B630", VA = "0x181E0C430")]
	[AsyncStateMachine(typeof(MFGLLCGJOEF))]
	public static Task<NFMFLMAOFMP<EDLPBBJOGBF, CEGADOEINOB>> KNLGKPEDAFO(FKPPOCEMHDG MIAAKEAGJGI, CCCKNINEDDG KNKOEEEKHDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct BOKCGLPLFFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly int PIKJCOKEANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly int JPDBMMOIFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly byte[] HCKHOAGNJJN;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x19093F0", Offset = "0x19085F0", VA = "0x1819093F0")]
	private BOKCGLPLFFB(int KIGJDGACGDD, int HMFNCGHECPG, byte[] FODGEDCJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x1E0C000", Offset = "0x1E0B200", VA = "0x181E0C000")]
	public static DIGPMMNJEIB PDGOGCHHDEL(int KIGJDGACGDD, int HMFNCGHECPG, ByteString FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1E0BCD0", Offset = "0x1E0AED0", VA = "0x181E0BCD0")]
	public static DIGPMMNJEIB[] HOHDFCGGHEJ(DIGPMMNJEIB GKGLDBAJJCH, int IHHODCFJLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1E0BF20", Offset = "0x1E0B120", VA = "0x181E0BF20")]
	public static GBKNCFEJMKO<GBPKHNJBGED, BOKCGLPLFFB> KPAOMKFKLJO(DIGPMMNJEIB LODLPIONDBP)
	{
		return default(GBKNCFEJMKO<GBPKHNJBGED, BOKCGLPLFFB>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1E0BE00", Offset = "0x1E0B000", VA = "0x181E0BE00")]
	public static NFMFLMAOFMP<DIGPMMNJEIB, NNADKGMIMDE> JBFFLKBLKCL(FKPPOCEMHDG MIAAKEAGJGI, [In] BOKCGLPLFFB KNKOEEEKHDK)
	{
		return default(NFMFLMAOFMP<DIGPMMNJEIB, NNADKGMIMDE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public readonly struct AOEFCMEHINK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct ACMECIFDHCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<bool, NNADKGMIMDE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public FKPPOCEMHDG root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public AOEFCMEHINK self;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private NFMFLMAOFMP<bool, NNADKGMIMDE> <r>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private TaskAwaiter<NFMFLMAOFMP<LKEAICJEMFK, NNADKGMIMDE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1E09BF0", Offset = "0x1E08DF0", VA = "0x181E09BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1E0A230", Offset = "0x1E09430", VA = "0x181E0A230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly int PIKJCOKEANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly int JPDBMMOIFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly byte[] HCKHOAGNJJN;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x19093F0", Offset = "0x19085F0", VA = "0x1819093F0")]
	private AOEFCMEHINK(int KIGJDGACGDD, int HMFNCGHECPG, byte[] FODGEDCJIDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x1E0B360", Offset = "0x1E0A560", VA = "0x181E0B360")]
	public static DIGPMMNJEIB PDGOGCHHDEL(int KIGJDGACGDD, int HMFNCGHECPG, ByteString FODGEDCJIDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1E0B170", Offset = "0x1E0A370", VA = "0x181E0B170")]
	public static DIGPMMNJEIB?[]? MMJMJKFMMLH(int IHHODCFJLJM, GFJGOLELJHO? PJICPHGJFFE, DJDLMEOOMEF? BLPMIMDGIJB, CCLNCFGAMPK? JFLFEABOIJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1E0B090", Offset = "0x1E0A290", VA = "0x181E0B090")]
	public static GBKNCFEJMKO<GBPKHNJBGED, AOEFCMEHINK> KPAOMKFKLJO(DIGPMMNJEIB LODLPIONDBP)
	{
		return default(GBKNCFEJMKO<GBPKHNJBGED, AOEFCMEHINK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1E0AF60", Offset = "0x1E0A160", VA = "0x181E0AF60")]
	[AsyncStateMachine(typeof(ACMECIFDHCN))]
	public static Task<NFMFLMAOFMP<bool, NNADKGMIMDE>> KNLGKPEDAFO(FKPPOCEMHDG MIAAKEAGJGI, AOEFCMEHINK KNKOEEEKHDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public sealed class JDDJGCBHEBI : NAFFMBHJLAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly FKPPOCEMHDG JDIMNKODJPN;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public BFDHDLJJOEK? KMGHIJMKCHH
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1E18080", Offset = "0x1E17280", VA = "0x181E18080", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
	internal JDDJGCBHEBI(FKPPOCEMHDG GDABCJDBLDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public sealed class JANMLJJOJKE : BFDHDLJJOEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly FKPPOCEMHDG JDIMNKODJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly BDIHEFKILKN AAKDOEOCILC;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7B7CF0", Offset = "0x7B6EF0", VA = "0x1807B7CF0")]
	public JANMLJJOJKE(FKPPOCEMHDG GDABCJDBLDL, BDIHEFKILKN LLPNCFFFKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x1E17AE0", Offset = "0x1E16CE0", VA = "0x181E17AE0", Slot = "4")]
	public NFMFLMAOFMP<DABDIBMGAMP, GOKDIBNJCLA> JMACMALKNEI(BCFHHBLPOPP<FKGCAMGPCBC> EPGOCEDJKAG, EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME, EIPPGFCFCGI<EJKCAAAPMFI> LFBBIJDDIAH)
	{
		return default(NFMFLMAOFMP<DABDIBMGAMP, GOKDIBNJCLA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1E17DB0", Offset = "0x1E16FB0", VA = "0x181E17DB0", Slot = "5")]
	public NFMFLMAOFMP<DABDIBMGAMP, GOKDIBNJCLA> PDMMHDBBEIJ(BCFHHBLPOPP<FKGCAMGPCBC> EPGOCEDJKAG, EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME, EIPPGFCFCGI<HFKDCDEJJMH> JECBHFPMAIO)
	{
		return default(NFMFLMAOFMP<DABDIBMGAMP, GOKDIBNJCLA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public sealed class GJMJHGCJNDO : EIGPCEJFFAF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public interface BLELGHKLNIO
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<BDIHEFKILKN> LGAJHCPDLHP(FKPPOCEMHDG GDABCJDBLDL, DJDLMEOOMEF? AKIDIKGFICM, CCLNCFGAMPK? HNCNDFLICIG, CancellationToken AIHJHMPAHCH);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		DKFOHDAGDJD HNLIBAAPGLB(FKPPOCEMHDG GDABCJDBLDL, GFJGOLELJHO OJJCIHKCPNF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public sealed class FNKJAAIALJF : BLELGHKLNIO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private struct LJBAGPMKHDM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public AsyncTaskMethodBuilder<BDIHEFKILKN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public FKPPOCEMHDG circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public DJDLMEOOMEF cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public CCLNCFGAMPK cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			private TaskAwaiter<IIEKEJODDAJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1E22880", Offset = "0x1E21A80", VA = "0x181E22880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x1E22BA0", Offset = "0x1E21DA0", VA = "0x181E22BA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public static readonly FNKJAAIALJF KMGHIJMKCHH;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		private FNKJAAIALJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1E11800", Offset = "0x1E10A00", VA = "0x181E11800", Slot = "4")]
		[AsyncStateMachine(typeof(LJBAGPMKHDM))]
		public Task<BDIHEFKILKN> LGAJHCPDLHP(FKPPOCEMHDG GDABCJDBLDL, DJDLMEOOMEF? AKIDIKGFICM, CCLNCFGAMPK? HNCNDFLICIG, CancellationToken AIHJHMPAHCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1E117E0", Offset = "0x1E109E0", VA = "0x181E117E0", Slot = "5")]
		public DKFOHDAGDJD HNLIBAAPGLB(FKPPOCEMHDG GDABCJDBLDL, GFJGOLELJHO OJJCIHKCPNF)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private struct AIKMNLIGMNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AsyncTaskMethodBuilder<GJMJHGCJNDO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public FKPPOCEMHDG circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public DJDLMEOOMEF cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public CCLNCFGAMPK cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GFJGOLELJHO evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private BLELGHKLNIO <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private TaskAwaiter<BDIHEFKILKN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1E0A2A0", Offset = "0x1E094A0", VA = "0x181E0A2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1E0A7F0", Offset = "0x1E099F0", VA = "0x181E0A7F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly BDIHEFKILKN AAKDOEOCILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly DKFOHDAGDJD DFIBBBLOPCF;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public GAKHKEICBEM OLGOJOMEPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x1E121B0", Offset = "0x1E113B0", VA = "0x181E121B0", Slot = "4")]
		get
		{
			return default(GAKHKEICBEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public AEENHPBKOMB MFAHEOLEGKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1E120F0", Offset = "0x1E112F0", VA = "0x181E120F0", Slot = "5")]
		get
		{
			return default(AEENHPBKOMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public JANMLJJOJKE BANMFIGAHOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public DDPCAIJOGMI JKGHIKMEMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7B6010", Offset = "0x7B5210", VA = "0x1807B6010", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public ADKNAKCLBKJ NMGLJLNPBBO
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x1E12380", Offset = "0x1E11580", VA = "0x181E12380")]
	private GJMJHGCJNDO(BDIHEFKILKN LLPNCFFFKDE, DKFOHDAGDJD KNEEKPGPNMF, JANMLJJOJKE EPFCCPBCHIP, DDPCAIJOGMI NLNAHEPAABM, ADKNAKCLBKJ GOKCJICIKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x1E12210", Offset = "0x1E11410", VA = "0x181E12210")]
	[AsyncStateMachine(typeof(AIKMNLIGMNC))]
	public static Task<GJMJHGCJNDO> NPMEBIAKFKD(FKPPOCEMHDG GDABCJDBLDL, GFJGOLELJHO OJJCIHKCPNF, DJDLMEOOMEF? AKIDIKGFICM, CCLNCFGAMPK? HNCNDFLICIG, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1E12090", Offset = "0x1E11290", VA = "0x181E12090", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public sealed class PLJJCEDCEKJ : CLDLIPEIJJP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface DPLJPOABHEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<EIGPCEJFFAF> MMBNLFAKKJG(FKPPOCEMHDG GDABCJDBLDL, GFJGOLELJHO OJJCIHKCPNF, DJDLMEOOMEF? AKIDIKGFICM, CCLNCFGAMPK? HNCNDFLICIG, CancellationToken AIHJHMPAHCH);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HBMGAOOEOJO();

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PONIJFCPJCL();
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public abstract class KDBNMAHAGPB : DPLJPOABHEK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct CHLIFCHNCEI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<EIGPCEJFFAF> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public FKPPOCEMHDG circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public GFJGOLELJHO evRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public DJDLMEOOMEF cv2RoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public CCLNCFGAMPK cv2SuperRoomData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private TaskAwaiter<GJMJHGCJNDO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x1E0C6D0", Offset = "0x1E0B8D0", VA = "0x181E0C6D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x1E0CA10", Offset = "0x1E0BC10", VA = "0x181E0CA10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1E1F380", Offset = "0x1E1E580", VA = "0x181E1F380", Slot = "4")]
		[AsyncStateMachine(typeof(CHLIFCHNCEI))]
		public Task<EIGPCEJFFAF> MMBNLFAKKJG(FKPPOCEMHDG GDABCJDBLDL, GFJGOLELJHO OJJCIHKCPNF, DJDLMEOOMEF? AKIDIKGFICM, CCLNCFGAMPK? HNCNDFLICIG, CancellationToken AIHJHMPAHCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void HBMGAOOEOJO();

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void PONIJFCPJCL();

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		protected KDBNMAHAGPB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct GGDPMCLOMOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public AsyncTaskMethodBuilder<EIGPCEJFFAF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public PLJJCEDCEKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private TaskAwaiter<LKEAICJEMFK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x1E11D00", Offset = "0x1E10F00", VA = "0x181E11D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1E11F00", Offset = "0x1E11100", VA = "0x181E11F00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct JPEADFBLBKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public PLJJCEDCEKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public FKPPOCEMHDG circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public GFJGOLELJHO evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public DJDLMEOOMEF cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public CCLNCFGAMPK cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter<EIGPCEJFFAF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1E18A20", Offset = "0x1E17C20", VA = "0x181E18A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1E18F50", Offset = "0x1E18150", VA = "0x181E18F50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly DPLJPOABHEK KDDFIFIFPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly TaskCompletionSource<LKEAICJEMFK> PBOGCIHBECB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly TaskCompletionSource<LKEAICJEMFK> KDLPDDILDJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly CancellationTokenSource ENDMCBKGBMN;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool BLHBDHAGMHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8772A0", Offset = "0x8764A0", VA = "0x1808772A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x96F200", Offset = "0x96E400", VA = "0x18096F200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool FLFFMMHGNFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x98BD80", Offset = "0x98AF80", VA = "0x18098BD80", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x98BDA0", Offset = "0x98AFA0", VA = "0x18098BDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool KNILIDOJJOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xF84E40", Offset = "0xF84040", VA = "0x180F84E40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1E25B30", Offset = "0x1E24D30", VA = "0x181E25B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EIGPCEJFFAF? AFJHCKDIGDE
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7B62D0", Offset = "0x7B54D0", VA = "0x1807B62D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7B6310", Offset = "0x7B5510", VA = "0x1807B6310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1E258D0", Offset = "0x1E24AD0", VA = "0x181E258D0", Slot = "7")]
	[AsyncStateMachine(typeof(GGDPMCLOMOO))]
	public Task<EIGPCEJFFAF> BDDDFMBCEFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1E25CA0", Offset = "0x1E24EA0", VA = "0x181E25CA0")]
	public PLJJCEDCEKJ(DPLJPOABHEK NMAKCOKENKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1E25B40", Offset = "0x1E24D40", VA = "0x181E25B40", Slot = "8")]
	[AsyncStateMachine(typeof(JPEADFBLBKB))]
	public Task PPODGHIHEBM(FKPPOCEMHDG GDABCJDBLDL, GFJGOLELJHO OJJCIHKCPNF, DJDLMEOOMEF? AKIDIKGFICM, CCLNCFGAMPK? HNCNDFLICIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x1E259C0", Offset = "0x1E24BC0", VA = "0x181E259C0", Slot = "9")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal sealed class MGFKIEMFLCK : DPFBGNABDKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly DDPCAIJOGMI DEPGINHEBON;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
	public MGFKIEMFLCK(DDPCAIJOGMI NLNAHEPAABM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal static class DPJFELCLGKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private class CPDFHOBPDNL<TGraph> : NNAAFNOPBFN where TGraph : BMJGAPINNKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		protected readonly TGraph JDDPEFEGJAD;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual MJOGJGHPMGC? AHGHKEDALNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xDCD5C0", Offset = "0xDCC7C0", VA = "0x180DCD5C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public EIPPGFCFCGI<LOIIILALBLN> PANPDPPCEFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x4C3FB80", Offset = "0x4C3ED80", VA = "0x184C3FB80", Slot = "4")]
			get
			{
				return default(EIPPGFCFCGI<LOIIILALBLN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
		public CPDFHOBPDNL(TGraph PPIENIHGEEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class GMLCLLKJEPC : CPDFHOBPDNL<JBNCBNFAPEB>
	{
		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public override MJOGJGHPMGC? AHGHKEDALNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x1E127D0", Offset = "0x1E119D0", VA = "0x181E127D0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1E127F0", Offset = "0x1E119F0", VA = "0x181E127F0")]
		public GMLCLLKJEPC(JBNCBNFAPEB ANKAHNOJNCN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x1E0F3C0", Offset = "0x1E0E5C0", VA = "0x181E0F3C0")]
	public static NNAAFNOPBFN MIJABIECKKD(BMJGAPINNKH PPIENIHGEEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class IJMEFFIIKHE : LEBPGBODEOH, IMNOFHILKPL, KNGOLIJFIEN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class LBBMMGIGGLH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private struct <<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public LBBMMGIGGLH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public OHAIMHJPJEG errReporting_;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private TaskAwaiter<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1E260C0", Offset = "0x1E252C0", VA = "0x181E260C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x1E26330", Offset = "0x1E25530", VA = "0x181E26330", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public IJMEFFIIKHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public bool value;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public LBBMMGIGGLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x1E202B0", Offset = "0x1E1F4B0", VA = "0x181E202B0")]
		[AsyncStateMachine(typeof(<<RequestSetBoolDefaultValue>g__requestSetBoolDefaultValueInternal|0>d))]
		internal Task GMNFCFFFHMH(OHAIMHJPJEG errReporting_)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct IIFIKGBNLJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public bool checkStringPurity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public IJMEFFIIKHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x1E144F0", Offset = "0x1E136F0", VA = "0x181E144F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1E14970", Offset = "0x1E13B70", VA = "0x181E14970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class HECKFFLMAOM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		private struct <<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public HECKFFLMAOM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private TaskAwaiter<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1E26390", Offset = "0x1E25590", VA = "0x181E26390", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x1E26670", Offset = "0x1E25870", VA = "0x181E26670", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public IJMEFFIIKHE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public int value;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public HECKFFLMAOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x1E12930", Offset = "0x1E11B30", VA = "0x181E12930")]
		[AsyncStateMachine(typeof(<<RequestSetIntDefaultValue>g__requestSetIntDefaultValueInternal|0>d))]
		internal Task OLOOJNNHPDN(OHAIMHJPJEG errReporting_)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly OBDLDHNDHKD EGLMJOLIENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly ICollection<DEHLLGEMLIC> PPCDPIIKCMN;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private BJDHOEFBLAH GKFJOCMLIHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x1E14E20", Offset = "0x1E14020", VA = "0x181E14E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public EIPPGFCFCGI<EJKCAAAPMFI> AANNPGGJIIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xAEBD70", Offset = "0xAEAF70", VA = "0x180AEBD70", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(EIPPGFCFCGI<EJKCAAAPMFI>);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xB3A210", Offset = "0xB39410", VA = "0x180B3A210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private EIPPGFCFCGI<NAMMKHHGCFO> JEIIDLJJKCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x948AE0", Offset = "0x947CE0", VA = "0x180948AE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public EIPPGFCFCGI<KJNHCLAFOIE> OHBAAAPGHLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1B0", Offset = "0x7DB3B0", VA = "0x1807DC1B0", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(EIPPGFCFCGI<KJNHCLAFOIE>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public override EIPPGFCFCGI<HKCAPACBGFO> IPJDHDAHGHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1E14D90", Offset = "0x1E13F90", VA = "0x181E14D90", Slot = "20")]
		get
		{
			return default(EIPPGFCFCGI<HKCAPACBGFO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool FNNOGGCELDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1E14E50", Offset = "0x1E14050", VA = "0x181E14E50", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1E177D0", Offset = "0x1E169D0", VA = "0x181E177D0")]
	private IJMEFFIIKHE(FKPPOCEMHDG GDABCJDBLDL, OLNAEHBJPHD CLKPBALPCKM, OBDLDHNDHKD KCDMNHGDOHM, EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME, EIPPGFCFCGI<EJKCAAAPMFI> LFBBIJDDIAH, EIPPGFCFCGI<NAMMKHHGCFO> PMANMCEJNMD, bool DNCHFGEMHOE, string IKEFBMMMAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1E17050", Offset = "0x1E16250", VA = "0x181E17050")]
	public static IJMEFFIIKHE MIJABIECKKD(FKPPOCEMHDG GDABCJDBLDL, OLNAEHBJPHD CLKPBALPCKM, OBDLDHNDHKD CCAOJBHBKKC, EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME, EIPPGFCFCGI<NAMMKHHGCFO> PMANMCEJNMD, EIPPGFCFCGI<EJKCAAAPMFI> LFBBIJDDIAH, bool DNCHFGEMHOE, bool ODLPNCJKBLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1E15550", Offset = "0x1E14750", VA = "0x181E15550", Slot = "21")]
	protected override void GEJAFFIMNGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1E152C0", Offset = "0x1E144C0", VA = "0x181E152C0", Slot = "22")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1E15710", Offset = "0x1E14910", VA = "0x181E15710", Slot = "30")]
	public void GLBAJFKOICH(DEHLLGEMLIC LLEDPLCMFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1E16250", Offset = "0x1E15450", VA = "0x181E16250", Slot = "27")]
	public void HMDHDELNPBA(CAKIAOMFKAE OPMGKDDHGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x1E15770", Offset = "0x1E14970", VA = "0x181E15770", Slot = "28")]
	public void GPAADOFPLHE(NNGMNHDFKFM GOHPEODAKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x1E17460", Offset = "0x1E16660", VA = "0x181E17460", Slot = "23")]
	protected override void OCOAOFKLHJJ(BEKJFHAFPHG JGHLBOHENIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1E16950", Offset = "0x1E15B50", VA = "0x181E16950", Slot = "32")]
	public string JGIEBEDIOFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x1E16D20", Offset = "0x1E15F20", VA = "0x181E16D20", Slot = "29")]
	public string MHAAGOFKNJN(int EPLLLIOIBOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1E15090", Offset = "0x1E14290", VA = "0x181E15090")]
	private void DLGLKFFILOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1E17560", Offset = "0x1E16760", VA = "0x181E17560", Slot = "31")]
	public void OIOGNJDJHGP(DEHLLGEMLIC LLEDPLCMFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x1E16710", Offset = "0x1E15910", VA = "0x181E16710")]
	private void ILFENBFJFFI(bool NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x1E16C10", Offset = "0x1E15E10", VA = "0x181E16C10", Slot = "33")]
	[AsyncStateMachine(typeof(IIFIKGBNLJM))]
	public Task LOFACFAIFHJ(string NICEPFIEJED, bool BEJBJKPICLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x1E14AF0", Offset = "0x1E13CF0", VA = "0x181E14AF0")]
	public void BEDFOGLHEJI(string NICEPFIEJED, bool BEJBJKPICLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x1E17630", Offset = "0x1E16830", VA = "0x181E17630")]
	private void OKIFKJPHGHI(int NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0xB3A210", Offset = "0xB39410", VA = "0x180B3A210")]
	internal void IMHDFIJEEHK(EIPPGFCFCGI<EJKCAAAPMFI> NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x1E16C00", Offset = "0x1E15E00", VA = "0x181E16C00")]
	[CompilerGenerated]
	private void LIFILKAHIPH(string NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x1E16100", Offset = "0x1E15300", VA = "0x181E16100")]
	[CompilerGenerated]
	private bool HGPIPHLFIJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x1E14C40", Offset = "0x1E13E40", VA = "0x181E14C40")]
	[CompilerGenerated]
	private bool BGPPNBDLDOA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x1E14AA0", Offset = "0x1E13CA0", VA = "0x181E14AA0")]
	[CompilerGenerated]
	private int AJMCCDPECNM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x1E15000", Offset = "0x1E14200", VA = "0x181E15000")]
	[CompilerGenerated]
	private bool DCAOJJDAEGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x1E14E40", Offset = "0x1E14040", VA = "0x181E14E40")]
	[CompilerGenerated]
	private void CFIOPAPHOGG(string NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x1E16AB0", Offset = "0x1E15CB0", VA = "0x181E16AB0")]
	[CompilerGenerated]
	private bool KLBPNAFPFOC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x1E166C0", Offset = "0x1E158C0", VA = "0x181E166C0")]
	[CompilerGenerated]
	private bool IGBABMCBCDF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x1E16630", Offset = "0x1E15830", VA = "0x181E16630")]
	[CompilerGenerated]
	private bool IBKGIHHFHBH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x1E14AA0", Offset = "0x1E13CA0", VA = "0x181E14AA0")]
	[CompilerGenerated]
	private int IDDACNEDHGP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x1E149D0", Offset = "0x1E13BD0", VA = "0x181E149D0")]
	[CompilerGenerated]
	private bool ABNLDDKPIGM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x1E14DD0", Offset = "0x1E13FD0", VA = "0x181E14DD0")]
	[CompilerGenerated]
	private int CADGPOLNCNF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1E168D0", Offset = "0x1E15AD0", VA = "0x181E168D0")]
	[CompilerGenerated]
	private void JBDEPLFGICP(object NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x1E15480", Offset = "0x1E14680", VA = "0x181E15480")]
	[CompilerGenerated]
	private bool FPIFCGGDGIL()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class NDJBCAPEPPL
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class FEBOBJCILIA : EAJNPHBPPON<MADPMDLDACF>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override GBCFODFHNAP IMOHKCDLOLH
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x9157A0", Offset = "0x9149A0", VA = "0x1809157A0", Slot = "125")]
			get
			{
				return default(GBCFODFHNAP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1E0F620", Offset = "0x1E0E820", VA = "0x181E0F620")]
		public FEBOBJCILIA(FKPPOCEMHDG GDABCJDBLDL, MADPMDLDACF PFGBPGKFOLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class GJOOOALHAIF : KFIHKGIFOPC<JIKBDAENNIP>
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1E12700", Offset = "0x1E11900", VA = "0x181E12700")]
		public GJOOOALHAIF(FKPPOCEMHDG GDABCJDBLDL, JIKBDAENNIP CLKPBALPCKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1E12410", Offset = "0x1E11610", VA = "0x181E12410", Slot = "119")]
		protected override void AEJEAAPCAKI(NEGACBHCGDA LGEGIEIBAEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1E126B0", Offset = "0x1E118B0", VA = "0x181E126B0")]
		[CompilerGenerated]
		private bool HPMIEJHKLBO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x1E12590", Offset = "0x1E11790", VA = "0x181E12590")]
		[CompilerGenerated]
		private void FMONEKKGEKD(bool NICEPFIEJED)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class KFCMDFFCKCK : KFIHKGIFOPC<NBNOIPMIDMB>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class KKAOAGKMMEA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public GMMJIAGDPFO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public KFCMDFFCKCK <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public KKAOAGKMMEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x1E1FC60", Offset = "0x1E1EE60", VA = "0x181E1FC60")]
			internal void NNALGCNIMGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x1E1FCB0", Offset = "0x1E1EEB0", VA = "0x181E1FCB0")]
			internal bool PGJLPLBMKHM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x1E1FC10", Offset = "0x1E1EE10", VA = "0x181E1FC10")]
			internal bool JAJHGDHODNB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x1E1FAA0", Offset = "0x1E1ECA0", VA = "0x181E1FAA0")]
			internal void DLHEKMGMDGI(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x1E1FBC0", Offset = "0x1E1EDC0", VA = "0x181E1FBC0")]
			internal bool FBDLGDADONG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x1E1F7E0", Offset = "0x1E1E9E0", VA = "0x181E1F7E0")]
		public KFCMDFFCKCK(FKPPOCEMHDG GDABCJDBLDL, NBNOIPMIDMB CLKPBALPCKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1E1F4E0", Offset = "0x1E1E6E0", VA = "0x181E1F4E0", Slot = "119")]
		protected override void AEJEAAPCAKI(NEGACBHCGDA LGEGIEIBAEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public sealed class MBNEJCEMEMO : KFIHKGIFOPC<NJAOMAMEDMA>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class CLIDKDAIECP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public GMMJIAGDPFO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public MBNEJCEMEMO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public Predicate<Guid> <>9__11;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public CLIDKDAIECP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x1E0D220", Offset = "0x1E0C420", VA = "0x181E0D220")]
			internal object NNALGCNIMGD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x1E0CF50", Offset = "0x1E0C150", VA = "0x181E0CF50")]
			internal bool HPGNMPBBJCN(Guid id)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1E0D320", Offset = "0x1E0C520", VA = "0x181E0D320")]
			internal void PGJLPLBMKHM(object value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1E0D070", Offset = "0x1E0C270", VA = "0x181E0D070")]
			internal string JAJHGDHODNB(object key)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x1E0CEB0", Offset = "0x1E0C0B0", VA = "0x181E0CEB0")]
			internal IReadOnlyList<object> DLHEKMGMDGI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x1E0CF00", Offset = "0x1E0C100", VA = "0x181E0CF00")]
			internal bool FBDLGDADONG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x1E0D5C0", Offset = "0x1E0C7C0", VA = "0x181E0D5C0")]
			internal bool PLKNDPJBKKP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x1E0CFD0", Offset = "0x1E0C1D0", VA = "0x181E0CFD0")]
			internal void IKPNLGDKJKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x1E0D570", Offset = "0x1E0C770", VA = "0x181E0D570")]
			internal bool PJCIJLNCLJP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x1E0D1D0", Offset = "0x1E0C3D0", VA = "0x181E0D1D0")]
			internal bool KKNPDFEBBLN()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x1E0D630", Offset = "0x1E0C830", VA = "0x181E0D630")]
			internal void POOFKGNDANH(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x1E0D020", Offset = "0x1E0C220", VA = "0x181E0D020")]
			internal bool JACOFEGGNJG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1E23570", Offset = "0x1E22770", VA = "0x181E23570")]
		public MBNEJCEMEMO(FKPPOCEMHDG GDABCJDBLDL, NJAOMAMEDMA CLKPBALPCKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1E22F40", Offset = "0x1E22140", VA = "0x181E22F40", Slot = "119")]
		protected override void AEJEAAPCAKI(NEGACBHCGDA LGEGIEIBAEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public sealed class FMNDKGKGGHH : KFIHKGIFOPC<GCPBOAACHGM>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private sealed class KLAMNEIIHFH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public FMNDKGKGGHH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public GMMJIAGDPFO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public KLAMNEIIHFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x1E1FEC0", Offset = "0x1E1F0C0", VA = "0x181E1FEC0")]
			internal bool NNALGCNIMGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x1E1FF10", Offset = "0x1E1F110", VA = "0x181E1FF10")]
			internal void PGJLPLBMKHM(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x1E1FE70", Offset = "0x1E1F070", VA = "0x181E1FE70")]
			internal bool JAJHGDHODNB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x1E1FD00", Offset = "0x1E1EF00", VA = "0x181E1FD00")]
			internal void DLHEKMGMDGI(bool value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x1E1FE20", Offset = "0x1E1F020", VA = "0x181E1FE20")]
			internal bool FBDLGDADONG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x1E11770", Offset = "0x1E10970", VA = "0x181E11770")]
		public FMNDKGKGGHH(FKPPOCEMHDG GDABCJDBLDL, GCPBOAACHGM PFGBPGKFOLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1E11470", Offset = "0x1E10670", VA = "0x181E11470", Slot = "119")]
		protected override void AEJEAAPCAKI(NEGACBHCGDA LGEGIEIBAEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public abstract class KNJANLECPDJ<TNode> : KFIHKGIFOPC<TNode> where TNode : notnull, BCNHLOHIONI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct JMOFHHFKNGL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public AsyncTaskMethodBuilder<NFMFLMAOFMP<EIPPGFCFCGI<OFLCOGGIINH>, CEGADOEINOB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public KNJANLECPDJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<NFMFLMAOFMP<EIPPGFCFCGI<OFLCOGGIINH>, CEGADOEINOB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x3C2EFD0", Offset = "0x3C2E1D0", VA = "0x183C2EFD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x3C2F390", Offset = "0x3C2E590", VA = "0x183C2F390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct EKKOKFCHIJN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public AsyncTaskMethodBuilder<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public KNJANLECPDJ<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public EIPPGFCFCGI<OFLCOGGIINH> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private TaskAwaiter<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x348B2E0", Offset = "0x348A4E0", VA = "0x18348B2E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x348B6A0", Offset = "0x348A8A0", VA = "0x18348B6A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public sealed override bool LAPBEKIIAJE
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public sealed override EIPPGFCFCGI<OFLCOGGIINH>? GFOEGMKADPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x3CB8DE0", Offset = "0x3CB7FE0", VA = "0x183CB8DE0", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x37FB710", Offset = "0x37FA910", VA = "0x1837FB710")]
		protected KNJANLECPDJ(FKPPOCEMHDG GDABCJDBLDL, TNode CLKPBALPCKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3CB89D0", Offset = "0x3CB7BD0", VA = "0x183CB89D0", Slot = "99")]
		[AsyncStateMachine(typeof(KNJANLECPDJ<>.JMOFHHFKNGL))]
		public override Task<NFMFLMAOFMP<EIPPGFCFCGI<OFLCOGGIINH>, CEGADOEINOB>> APLMKFFCEHH(string IKEFBMMMAJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x3CB8D40", Offset = "0x3CB7F40", VA = "0x183CB8D40", Slot = "123")]
		public sealed override bool OPDNNHFKMCD(EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x3CB8C00", Offset = "0x3CB7E00", VA = "0x183CB8C00", Slot = "111")]
		protected sealed override bool DANMMFOMNCO(EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x3CB8CA0", Offset = "0x3CB7EA0", VA = "0x183CB8CA0", Slot = "112")]
		protected override bool KPIIGNODJMM(EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x3CB8AF0", Offset = "0x3CB7CF0", VA = "0x183CB8AF0", Slot = "100")]
		[AsyncStateMachine(typeof(KNJANLECPDJ<>.EKKOKFCHIJN))]
		public override Task<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> BJPKLALDOHL(EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class BNCLHIBCFDI : CBMOGBIOCEG<OMBDFEJHDFC>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private sealed class MJGBPNCODHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public BNCLHIBCFDI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public GMMJIAGDPFO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public MJGBPNCODHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x1E23CD0", Offset = "0x1E22ED0", VA = "0x181E23CD0")]
			internal bool DCNHHMJAHDG()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x1E23D50", Offset = "0x1E22F50", VA = "0x181E23D50")]
			internal void NNEOEJEGLMN(bool v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x1E0BC70", Offset = "0x1E0AE70", VA = "0x181E0BC70")]
		public BNCLHIBCFDI(FKPPOCEMHDG GDABCJDBLDL, OMBDFEJHDFC PFGBPGKFOLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x1E0BA20", Offset = "0x1E0AC20", VA = "0x181E0BA20", Slot = "125")]
		protected override void KPLLAMOLKMG(NEGACBHCGDA LGEGIEIBAEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class JNDHPNFMNBD : FFOEFCLIBOI<MMOBPDPGKJD>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override NodeVisualizationKey OGJDOBGGLGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x872860", Offset = "0x871A60", VA = "0x180872860", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x1E18960", Offset = "0x1E17B60", VA = "0x181E18960")]
		public JNDHPNFMNBD(FKPPOCEMHDG GDABCJDBLDL, MMOBPDPGKJD CLKPBALPCKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private abstract class FFOEFCLIBOI<TNode> : KFIHKGIFOPC<TNode> where TNode : notnull, OIBIAMFODDE
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct LNAKJLHNCAM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public AsyncTaskMethodBuilder<NFMFLMAOFMP<EIPPGFCFCGI<OFLCOGGIINH>, CEGADOEINOB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public FFOEFCLIBOI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private TaskAwaiter<NFMFLMAOFMP<EIPPGFCFCGI<OFLCOGGIINH>, CEGADOEINOB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x3D93050", Offset = "0x3D92250", VA = "0x183D93050", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x3D933B0", Offset = "0x3D925B0", VA = "0x183D933B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct PLJPPEFJEJO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public AsyncTaskMethodBuilder<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public FFOEFCLIBOI<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public EIPPGFCFCGI<OFLCOGGIINH> portGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			private TaskAwaiter<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x4276330", Offset = "0x4275530", VA = "0x184276330", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x4276660", Offset = "0x4275860", VA = "0x184276660", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override EIPPGFCFCGI<LOIIILALBLN>? AABEKGJBOCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x37FB740", Offset = "0x37FA940", VA = "0x1837FB740", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public override EIPPGFCFCGI<OFLCOGGIINH>? GFOEGMKADPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x37FB7F0", Offset = "0x37FA9F0", VA = "0x1837FB7F0", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x37FB710", Offset = "0x37FA910", VA = "0x1837FB710")]
		public FFOEFCLIBOI(FKPPOCEMHDG GDABCJDBLDL, TNode CLKPBALPCKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x37FB300", Offset = "0x37FA500", VA = "0x1837FB300", Slot = "99")]
		[AsyncStateMachine(typeof(FFOEFCLIBOI<>.LNAKJLHNCAM))]
		public override Task<NFMFLMAOFMP<EIPPGFCFCGI<OFLCOGGIINH>, CEGADOEINOB>> APLMKFFCEHH(string IKEFBMMMAJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x37FB670", Offset = "0x37FA870", VA = "0x1837FB670", Slot = "123")]
		public sealed override bool OPDNNHFKMCD(EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x37FB530", Offset = "0x37FA730", VA = "0x1837FB530", Slot = "111")]
		protected sealed override bool DANMMFOMNCO(EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x37FB5D0", Offset = "0x37FA7D0", VA = "0x1837FB5D0", Slot = "112")]
		protected override bool KPIIGNODJMM(EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x37FB420", Offset = "0x37FA620", VA = "0x1837FB420", Slot = "100")]
		[AsyncStateMachine(typeof(FFOEFCLIBOI<>.PLJPPEFJEJO))]
		public override Task<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> BJPKLALDOHL(EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class BFKCJEFNOCA : CBMOGBIOCEG<NNOBGIPCMND>
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class DEACPPPMCGA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public BFKCJEFNOCA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public GMMJIAGDPFO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public DEACPPPMCGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x1E0E9E0", Offset = "0x1E0DBE0", VA = "0x181E0E9E0")]
			internal int DCNHHMJAHDG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1E0EA60", Offset = "0x1E0DC60", VA = "0x181E0EA60")]
			internal void NNEOEJEGLMN(int colorIndex)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x1E0B9C0", Offset = "0x1E0ABC0", VA = "0x181E0B9C0")]
		public BFKCJEFNOCA(FKPPOCEMHDG GDABCJDBLDL, NNOBGIPCMND PFGBPGKFOLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x1E0B710", Offset = "0x1E0A910", VA = "0x181E0B710", Slot = "125")]
		protected override void KPLLAMOLKMG(NEGACBHCGDA LGEGIEIBAEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class HJAJNDBCJFA : KFIHKGIFOPC<IOCCHFNDMNL>
	{
		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public override NodeVisualizationKey OGJDOBGGLGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0xA53240", Offset = "0xA52440", VA = "0x180A53240", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x1E136A0", Offset = "0x1E128A0", VA = "0x181E136A0")]
		public HJAJNDBCJFA(FKPPOCEMHDG GDABCJDBLDL, IOCCHFNDMNL CLKPBALPCKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private sealed class HLJOJAHKINC : FFOEFCLIBOI<MDBMFFNEADG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public override bool KNFFMHPNOIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override bool BIMLOKGBONF
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x1E13C70", Offset = "0x1E12E70", VA = "0x181E13C70", Slot = "116")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override NodeVisualizationKey OGJDOBGGLGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x917C30", Offset = "0x916E30", VA = "0x180917C30", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1E13C10", Offset = "0x1E12E10", VA = "0x181E13C10")]
		public HLJOJAHKINC(FKPPOCEMHDG GDABCJDBLDL, MDBMFFNEADG CLKPBALPCKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private sealed class EMDBPGJEGLD : KFIHKGIFOPC<DBJOEEFJBPO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override NodeVisualizationKey OGJDOBGGLGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x1082AC0", Offset = "0x1081CC0", VA = "0x181082AC0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1E0F550", Offset = "0x1E0E750", VA = "0x181E0F550")]
		public EMDBPGJEGLD(FKPPOCEMHDG GDABCJDBLDL, DBJOEEFJBPO CLKPBALPCKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private sealed class CKLHNMMPLAJ : KFIHKGIFOPC<NIMMLMKLGFP>
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public override NodeVisualizationKey OGJDOBGGLGA
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x928F00", Offset = "0x928100", VA = "0x180928F00", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1E0CE40", Offset = "0x1E0C040", VA = "0x181E0CE40")]
		public CKLHNMMPLAJ(FKPPOCEMHDG GDABCJDBLDL, NIMMLMKLGFP CLKPBALPCKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850", Slot = "111")]
		protected override bool DANMMFOMNCO(EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private sealed class FJAIJLHGNMD : KFIHKGIFOPC<NBDKDMNJPAD>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override NodeVisualizationKey OGJDOBGGLGA
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x9265C0", Offset = "0x9257C0", VA = "0x1809265C0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override bool DNNEGFIGAME
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x1E0FAF0", Offset = "0x1E0ECF0", VA = "0x181E0FAF0", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		protected override bool DAAFOPMHEEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x1E0FA80", Offset = "0x1E0EC80", VA = "0x181E0FA80")]
		public FJAIJLHGNMD(FKPPOCEMHDG GDABCJDBLDL, NBDKDMNJPAD CLKPBALPCKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private sealed class MHCLPBFPLPP : KFIHKGIFOPC<EHKINJIOMHC>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NodeVisualizationKey OGJDOBGGLGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x9157A0", Offset = "0x9149A0", VA = "0x1809157A0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override bool DNNEGFIGAME
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x1E23C80", Offset = "0x1E22E80", VA = "0x181E23C80", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		protected override bool DAAFOPMHEEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x1E23C10", Offset = "0x1E22E10", VA = "0x181E23C10")]
		public MHCLPBFPLPP(FKPPOCEMHDG GDABCJDBLDL, EHKINJIOMHC CLKPBALPCKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public sealed class EPHKDCBJBGG : KNJANLECPDJ<BOCACCLPHOG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override NodeVisualizationKey OGJDOBGGLGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x935150", Offset = "0x934350", VA = "0x180935150", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x1E0F5C0", Offset = "0x1E0E7C0", VA = "0x181E0F5C0")]
		public EPHKDCBJBGG(FKPPOCEMHDG GDABCJDBLDL, BOCACCLPHOG CLKPBALPCKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class JEIHEAJENHB : CBMOGBIOCEG<KDMALJGJLEN>
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class GIBEFJCNMGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public JEIHEAJENHB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public GMMJIAGDPFO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public GIBEFJCNMGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x1E11F70", Offset = "0x1E11170", VA = "0x181E11F70")]
			internal int DCNHHMJAHDG()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x1E11FF0", Offset = "0x1E111F0", VA = "0x181E11FF0")]
			internal void NNEOEJEGLMN(int value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x1E18490", Offset = "0x1E17690", VA = "0x181E18490")]
		public JEIHEAJENHB(FKPPOCEMHDG GDABCJDBLDL, KDMALJGJLEN PFGBPGKFOLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x1E18190", Offset = "0x1E17390", VA = "0x181E18190", Slot = "125")]
		protected override void KPLLAMOLKMG(NEGACBHCGDA LGEGIEIBAEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public sealed class HPOOGAHLGFN : EAJNPHBPPON<LPPNLLJNADJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override GBCFODFHNAP IMOHKCDLOLH
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x872860", Offset = "0x871A60", VA = "0x180872860", Slot = "125")]
			get
			{
				return default(GBCFODFHNAP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x1E13CB0", Offset = "0x1E12EB0", VA = "0x181E13CB0")]
		public HPOOGAHLGFN(FKPPOCEMHDG GDABCJDBLDL, LPPNLLJNADJ PFGBPGKFOLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class NCPAMEEFKFL : KFIHKGIFOPC<OLNAEHBJPHD>
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x1E23E20", Offset = "0x1E23020", VA = "0x181E23E20")]
		public NCPAMEEFKFL(FKPPOCEMHDG GDABCJDBLDL, OLNAEHBJPHD CLKPBALPCKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public abstract class KFIHKGIFOPC<TNode> : NKPBMKEEPNC, IDisposable where TNode : notnull, OLNAEHBJPHD
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		protected readonly struct HEAAHGKLKBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public readonly string CBGHAJEGHNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public readonly string EOOOALGMBDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public readonly string JKJJOCLODHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public readonly DGHNDLIBHBE MPFCHGJHFJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public readonly MPBBOGLJOCO EPKMMODMPON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public readonly Func<string, bool> FAHNBBOGOFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public readonly string GALEMKHOPPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public readonly Func<string, bool> HHIFHIHHPDP;

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x391F780", Offset = "0x391E980", VA = "0x18391F780")]
			public HEAAHGKLKBM(string PDHKBOBNNOA, string JLGNILDEEOD, string BLFAKNGIDHA, DGHNDLIBHBE FDFIIPJNADC, MPBBOGLJOCO NDBLDMEBLPC, Func<string, bool> EBLPKKOFGOG, string KPLHMNKEACN, Func<string, bool> ANAPKHLICBC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class BFNOJFFDFJE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public KFIHKGIFOPC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public FKPPOCEMHDG circuitsManager;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public TNode node;

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public BFNOJFFDFJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x4897D20", Offset = "0x4896F20", VA = "0x184897D20")]
			internal JPIFAGIGLOH GDHPMJLKDEC(BCAKLPOGMDM portGroup, int id)
			{
				return null;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private struct ANENJCIFFGH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public KFIHKGIFOPC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public int newColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private TaskAwaiter<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x3AFB760", Offset = "0x3AFA960", VA = "0x183AFB760", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x8A5FC0", Offset = "0x8A51C0", VA = "0x1808A5FC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private struct DFDOHNIFEJJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public AsyncTaskMethodBuilder<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public KFIHKGIFOPC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public GAJMFIFOLMF? localPosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public DKJMCLNAPDB? localRotation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			private TaskAwaiter<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x5113E00", Offset = "0x5113000", VA = "0x185113E00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x5114090", Offset = "0x5113290", VA = "0x185114090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class NHFGNNLAILD
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000060")]
			private struct <<BuildStringChangeMenuInternal>b__2>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public NHFGNNLAILD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x60001D5")]
				[Cpp2IlInjected.Address(RVA = "0x32734D0", Offset = "0x32726D0", VA = "0x1832734D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001D6")]
				[Cpp2IlInjected.Address(RVA = "0x8A5FC0", Offset = "0x8A51C0", VA = "0x1808A5FC0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public Func<string, bool> submitValidator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public GMMJIAGDPFO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public KFIHKGIFOPC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public Func<string> getConfigurableName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public NEGACBHCGDA configure;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public Action<string> setConfigurableName;

			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public NHFGNNLAILD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
			internal string LCCEDBKIEHI()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x7B6300", Offset = "0x7B5500", VA = "0x1807B6300")]
			internal void JIGDCLACHIK(string value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x406BFE0", Offset = "0x406B1E0", VA = "0x18406BFE0")]
			[AsyncStateMachine(typeof(KFIHKGIFOPC<>.NHFGNNLAILD.<<BuildStringChangeMenuInternal>b__2>d))]
			internal void PIEOJNPOKPM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class PCGIJMLLGMB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public GMMJIAGDPFO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public PCGIJMLLGMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x425D460", Offset = "0x425C660", VA = "0x18425D460")]
			internal bool FENJILPHMIA(string text)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x425D390", Offset = "0x425C590", VA = "0x18425D390")]
			internal bool CNEGKPDGNCB(string text)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		[CompilerGenerated]
		private struct JNHGIMAGBLJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public AsyncTaskMethodBuilder<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public KFIHKGIFOPC<TNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public string newName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private TaskAwaiter<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0x3C333F0", Offset = "0x3C325F0", VA = "0x183C333F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0x3C33750", Offset = "0x3C32950", VA = "0x183C33750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly FKPPOCEMHDG JDIMNKODJPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly bool KAHCHEFJIDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private ACAILBEAMDF<OFLCOGGIINH, JPIFAGIGLOH> IJBOMBOHKLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private ACAILBEAMDF<OFLCOGGIINH, HFIKGBNIADG> PHIKELLKDIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private List<Action> GBOPNGMEPIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[CompilerGenerated]
		private Action<EIPPGFCFCGI<OFLCOGGIINH>>? LLHFCLNGEKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[CompilerGenerated]
		private Action<EIPPGFCFCGI<OFLCOGGIINH>, HFIKGBNIADG>? CGBAGLCNOFG;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		protected GMMJIAGDPFO JOHCJPHCDAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x3C75760", Offset = "0x3C74960", VA = "0x183C75760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected TNode FLBKFFJHCGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public BCFHHBLPOPP<ODLLPEBONPI> OCNDJDDNGJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x9CC400", Offset = "0x9CB600", VA = "0x1809CC400", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(BCFHHBLPOPP<ODLLPEBONPI>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public EIPPGFCFCGI<OOOHOCOEIIE> EPCPIMLGHAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x3C791D0", Offset = "0x3C783D0", VA = "0x183C791D0", Slot = "6")]
			get
			{
				return default(EIPPGFCFCGI<OOOHOCOEIIE>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public object HGMDLMKNDIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x34EEA30", Offset = "0x34EDC30", VA = "0x1834EEA30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public virtual bool HBAPAGBKNGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850", Slot = "88")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public int MKJPAJDIBPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x3C78EF0", Offset = "0x3C780F0", VA = "0x183C78EF0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public ENNHINMHKAK MMMOMDJENJH
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x3C78EB0", Offset = "0x3C780B0", VA = "0x183C78EB0", Slot = "10")]
			get
			{
				return default(ENNHINMHKAK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public string PGFMJFAGGJD
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x3C79360", Offset = "0x3C78560", VA = "0x183C79360", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		protected virtual bool DAAFOPMHEEK
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public virtual NodeVisualizationKey OGJDOBGGLGA
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public EIPPGFCFCGI<KMNFKMCBPAP> LFAIBJELGCN
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x9556B0", Offset = "0x9548B0", VA = "0x1809556B0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return default(EIPPGFCFCGI<KMNFKMCBPAP>);
			}
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x9C4480", Offset = "0x9C3680", VA = "0x1809C4480")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public virtual bool DNNEGFIGAME
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual bool KNFFMHPNOIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "92")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public virtual GMLJKBLFPAO NIKHKGDABAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x90A0E0", Offset = "0x9092E0", VA = "0x18090A0E0", Slot = "93")]
			get
			{
				return default(GMLJKBLFPAO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public bool OEDKDFMMPGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x3C78CE0", Offset = "0x3C77EE0", VA = "0x183C78CE0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool CGFONKMMMGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x3C78D30", Offset = "0x3C77F30", VA = "0x183C78D30", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public bool POHPPPGACEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x3C78D80", Offset = "0x3C77F80", VA = "0x183C78D80", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public int KLGNGMEINPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x3C79190", Offset = "0x3C78390", VA = "0x183C79190", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool JGOOEOPIHPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x3C79020", Offset = "0x3C78220", VA = "0x183C79020", Slot = "21")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public bool GOEAODGKAIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x3C78E10", Offset = "0x3C78010", VA = "0x183C78E10", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public bool DHJJLKOIEHL
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xB0A2E0", Offset = "0xB094E0", VA = "0x180B0A2E0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xB0A200", Offset = "0xB09400", VA = "0x180B0A200")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool DHNLODEAKHH
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "94")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public virtual bool GCBOLHECNMA
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x3C78DD0", Offset = "0x3C77FD0", VA = "0x183C78DD0", Slot = "95")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public bool HMHODJBBFIK
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x3C78F80", Offset = "0x3C78180", VA = "0x183C78F80", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public GAJMFIFOLMF APOIDAPMEHH
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x3C790F0", Offset = "0x3C782F0", VA = "0x183C790F0", Slot = "27")]
			get
			{
				return default(GAJMFIFOLMF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public DKJMCLNAPDB CDOBGHCOBEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x3C79140", Offset = "0x3C78340", VA = "0x183C79140", Slot = "29")]
			get
			{
				return default(DKJMCLNAPDB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual bool KNPKBHKHNCB
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "107")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public virtual PNPOMHELLGG? OIPDDDAGOEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "108")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public virtual JACBIDBHGNJ? HHLHHOLNCND
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "109")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public virtual IEnumerable<BCFHHBLPOPP<FKGCAMGPCBC>>? MLNNIMABBLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool MFBBHILIPNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x3C78E60", Offset = "0x3C78060", VA = "0x183C78E60", Slot = "113")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public BCFHHBLPOPP<LOIIILALBLN> DOOENIPGCGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x3C79060", Offset = "0x3C78260", VA = "0x183C79060", Slot = "55")]
			get
			{
				return default(BCFHHBLPOPP<LOIIILALBLN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public EIPPGFCFCGI<LOIIILALBLN> PANPDPPCEFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x3C78F30", Offset = "0x3C78130", VA = "0x183C78F30", Slot = "56")]
			get
			{
				return default(EIPPGFCFCGI<LOIIILALBLN>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual bool LAPBEKIIAJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "114")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public virtual EIPPGFCFCGI<LOIIILALBLN>? AABEKGJBOCH
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "115")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool BIMLOKGBONF
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "116")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool GJBMCJAJDFA
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x3C78FD0", Offset = "0x3C781D0", VA = "0x183C78FD0", Slot = "61")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public string ECHFBJHACCL
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x7C10A0", Offset = "0x7C02A0", VA = "0x1807C10A0", Slot = "63")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x7C1050", Offset = "0x7C0250", VA = "0x1807C1050")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public BCFHHBLPOPP<FKGCAMGPCBC> OMAIHEMGPCG
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x3C790B0", Offset = "0x3C782B0", VA = "0x183C790B0", Slot = "62")]
			get
			{
				return default(BCFHHBLPOPP<FKGCAMGPCBC>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public BCFHHBLPOPP<FKGCAMGPCBC>? KHDGKINEFKE
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x3C79240", Offset = "0x3C78440", VA = "0x183C79240", Slot = "117")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public HDCLKODNOCA<OFLCOGGIINH, HFIKGBNIADG> DFEFNMFGFLH
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x3C79320", Offset = "0x3C78520", VA = "0x183C79320", Slot = "64")]
			get
			{
				return default(HDCLKODNOCA<OFLCOGGIINH, HFIKGBNIADG>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public virtual EIPPGFCFCGI<OFLCOGGIINH>? GFOEGMKADPO
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "118")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public virtual bool NECHLECNBIE
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "121")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public virtual bool FBDHMAPICCN
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850", Slot = "122")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action EMFHEMHAAGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x3C761E0", Offset = "0x3C753E0", VA = "0x183C761E0", Slot = "36")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x3C76280", Offset = "0x3C75480", VA = "0x183C76280", Slot = "37")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event CJJKHMLCLNA AOEALLKBNAE
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3C77800", Offset = "0x3C76A00", VA = "0x183C77800", Slot = "38")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x3C74BF0", Offset = "0x3C73DF0", VA = "0x183C74BF0", Slot = "39")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event HEOGNMLHOFC ANPJPOBKFLB
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x3C77080", Offset = "0x3C76280", VA = "0x183C77080", Slot = "40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x3C77F40", Offset = "0x3C77140", VA = "0x183C77F40", Slot = "41")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action DGDLDGJEMAP
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x3C77700", Offset = "0x3C76900", VA = "0x183C77700", Slot = "42")]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x3C74A20", Offset = "0x3C73C20", VA = "0x183C74A20", Slot = "43")]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action BLLADNPGEEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x3C77A70", Offset = "0x3C76C70", VA = "0x183C77A70", Slot = "44")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x3C74490", Offset = "0x3C73690", VA = "0x183C74490", Slot = "45")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action<EIPPGFCFCGI<OFLCOGGIINH>, HFIKGBNIADG> DLCAIEKCHJG
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x3C76770", Offset = "0x3C75970", VA = "0x183C76770", Slot = "66")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x3C746C0", Offset = "0x3C738C0", VA = "0x183C746C0", Slot = "67")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<EIPPGFCFCGI<OFLCOGGIINH>, HFIKGBNIADG> PEMIPEJDLLA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x3C78750", Offset = "0x3C77950", VA = "0x183C78750", Slot = "70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x3C77530", Offset = "0x3C76730", VA = "0x183C77530", Slot = "71")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		public event Action<EIPPGFCFCGI<OFLCOGGIINH>> CBILDEGBDEO
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x3C785D0", Offset = "0x3C777D0", VA = "0x183C785D0", Slot = "68")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x3C77C10", Offset = "0x3C76E10", VA = "0x183C77C10", Slot = "69")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<EIPPGFCFCGI<OFLCOGGIINH>, EIPPGFCFCGI<OFLCOGGIINH>> MAGCIFEEDDM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x3C77470", Offset = "0x3C76670", VA = "0x183C77470", Slot = "72")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x3C77FE0", Offset = "0x3C771E0", VA = "0x183C77FE0", Slot = "73")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		public event Action<EIPPGFCFCGI<OFLCOGGIINH>, HFIKGBNIADG> AMNMFMLALDJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x3C77260", Offset = "0x3C76460", VA = "0x183C77260", Slot = "74")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x3C78690", Offset = "0x3C77890", VA = "0x183C78690", Slot = "75")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		public event Action<EIPPGFCFCGI<OFLCOGGIINH>, EIPPGFCFCGI<OFLCOGGIINH>> CPHEMKMKAIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x3C766B0", Offset = "0x3C758B0", VA = "0x183C766B0", Slot = "76")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x3C74530", Offset = "0x3C73730", VA = "0x183C74530", Slot = "77")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3C78810", Offset = "0x3C77A10", VA = "0x183C78810")]
		[HHAPCIPDAID("Creating the port adapter needs to actually read the `canInteract` state rather than just passing in `true`.")]
		[HHAPCIPDAID("Need to handle `Name` better.")]
		protected KFIHKGIFOPC(FKPPOCEMHDG GDABCJDBLDL, TNode CLKPBALPCKM, bool ODLPNCJKBLC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x3C76860", Offset = "0x3C75A60", VA = "0x183C76860", Slot = "86")]
		protected virtual void GEJAFFIMNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3C759E0", Offset = "0x3C74BE0", VA = "0x183C759E0", Slot = "87")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x3C77120", Offset = "0x3C76320", VA = "0x183C77120", Slot = "9")]
		[AsyncStateMachine(typeof(KFIHKGIFOPC<>.ANENJCIFFGH))]
		public void IBIHFAPHFJK(int ODCMDPKOBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x3C777B0", Offset = "0x3C769B0", VA = "0x183C777B0")]
		public bool LGPOCLAELFE([In] GAJMFIFOLMF NICEPFIEJED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x3C73F90", Offset = "0x3C73190", VA = "0x183C73F90")]
		public bool ACFFKPKOHOL([In] DKJMCLNAPDB NICEPFIEJED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x3C778A0", Offset = "0x3C76AA0", VA = "0x183C778A0", Slot = "31")]
		public void MAOIIPBAJGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x3C77320", Offset = "0x3C76520", VA = "0x183C77320", Slot = "32")]
		[AsyncStateMachine(typeof(KFIHKGIFOPC<>.DFDOHNIFEJJ))]
		public Task<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> JLPLAIJJDEO(GAJMFIFOLMF? CMGCCDJMKGB, DKJMCLNAPDB? MGHFLNIAHPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "96")]
		public virtual void BBMNDJDFCJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "97")]
		public virtual void OIMFHPHACCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "98")]
		public virtual void OCFEJABBGLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1B69950", Offset = "0x1B68B50", VA = "0x181B69950")]
		protected void IJIEJPBBCKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3C775F0", Offset = "0x3C767F0", VA = "0x183C775F0")]
		protected void KMPDDCDCLMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2004B20", Offset = "0x2003D20", VA = "0x182004B20")]
		private void GKKLLFJMGAI([In] DKJMCLNAPDB HBCECKEGCGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3C745F0", Offset = "0x3C737F0", VA = "0x183C745F0", Slot = "99")]
		public virtual Task<NFMFLMAOFMP<EIPPGFCFCGI<OFLCOGGIINH>, CEGADOEINOB>> APLMKFFCEHH(string IKEFBMMMAJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3C74AF0", Offset = "0x3C73CF0", VA = "0x183C74AF0", Slot = "100")]
		public virtual Task<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> BJPKLALDOHL(EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "101")]
		public virtual void CGGKIPHCIPF(EIPPGFCFCGI<OFLCOGGIINH> JBLJLKACLCB, EIPPGFCFCGI<OFLCOGGIINH> PDNMIBHFCLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3C771D0", Offset = "0x3C763D0", VA = "0x183C771D0", Slot = "102")]
		public virtual IEnumerable<DIGPMMNJEIB> IIHJFMCCOLI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3C76630", Offset = "0x3C75830", VA = "0x183C76630", Slot = "103")]
		public NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB> FEPEJOCECAA(string BAGHNKBMGLF)
		{
			return default(NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3C77CD0", Offset = "0x3C76ED0", VA = "0x183C77CD0", Slot = "46")]
		public bool NEFDGDNMCAD([Out] Guid LCIFLCGALAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3C74780", Offset = "0x3C73980", VA = "0x183C74780")]
		public bool BDLPEDMMANL([In] Guid NMEFCALOOLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "104")]
		public virtual void MNHGCJGIAKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "105")]
		public virtual void KNKMFLBFPDE(bool GDBJNDJMJID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "106")]
		public virtual OOFDOFJIDMM HECEGIPEIPL([In] ACHJIKEAFEE HEDCNLPKAOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3C74C90", Offset = "0x3C73E90", VA = "0x183C74C90")]
		protected void CHMLEMIAIKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3C75320", Offset = "0x3C74520", VA = "0x183C75320", Slot = "111")]
		protected virtual bool DANMMFOMNCO(EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "112")]
		protected virtual bool KPIIGNODJMM(EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "119")]
		protected virtual void AEJEAAPCAKI(NEGACBHCGDA IIDPNFDLGKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x3C74E50", Offset = "0x3C74050", VA = "0x183C74E50")]
		protected void CIAIKINGPMM(NEGACBHCGDA LGEGIEIBAEC, Func<string> LDBAEGFIIOB, Action<string> OJIIAMPLINJ, HEAAHGKLKBM JPEJCADBOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x3C76320", Offset = "0x3C75520", VA = "0x183C76320")]
		protected void EGKGMHALJOM(NEGACBHCGDA LGEGIEIBAEC, Func<string> LDBAEGFIIOB, Action<string> OJIIAMPLINJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x3C77E10", Offset = "0x3C77010", VA = "0x183C77E10", Slot = "120")]
		protected virtual void NGDIAFKPGMK(NEGACBHCGDA LGEGIEIBAEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x3C77010", Offset = "0x3C76210", VA = "0x183C77010", Slot = "79")]
		public void GPAADOFPLHE(NEGACBHCGDA LGEGIEIBAEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3C73FE0", Offset = "0x3C731E0", VA = "0x183C73FE0", Slot = "80")]
		public LHGJHELBJFO AEFHIKHHEJG()
		{
			return default(LHGJHELBJFO);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "123")]
		public virtual bool OPDNNHFKMCD(EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x126E920", Offset = "0x126DB20", VA = "0x18126E920")]
		private void HCICLCEABDG([In] GAJMFIFOLMF DHMMMGDKPCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x3C77610", Offset = "0x3C76810", VA = "0x183C77610")]
		private void KPHLLENLPLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3C780A0", Offset = "0x3C772A0", VA = "0x183C780A0")]
		private void NMPAGPCDMMC(EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME, BCAKLPOGMDM CGMOHKMHOJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x3C77060", Offset = "0x3C76260", VA = "0x183C77060")]
		private void HLDKEGJPOCP(EIPPGFCFCGI<OFLCOGGIINH> JNIKIHKLGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x3C76EF0", Offset = "0x3C760F0", VA = "0x183C76EF0")]
		private void GGBPPEDIBHL(EIPPGFCFCGI<OFLCOGGIINH> JNIKIHKLGAD, BCAKLPOGMDM PKKCEGFCOPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3C740E0", Offset = "0x3C732E0", VA = "0x183C740E0")]
		private void AJFDJIIGCLD(EIPPGFCFCGI<OFLCOGGIINH> JBLJLKACLCB, EIPPGFCFCGI<OFLCOGGIINH> PDNMIBHFCLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x1FF2F80", Offset = "0x1FF2180", VA = "0x181FF2F80")]
		private void POJKAIIDCLE(EIPPGFCFCGI<OFLCOGGIINH> JBLJLKACLCB, EIPPGFCFCGI<OFLCOGGIINH> PDNMIBHFCLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xC0D040", Offset = "0xC0C240", VA = "0x180C0D040")]
		private void DBGNEDKIEEC(EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3C75350", Offset = "0x3C74550", VA = "0x183C75350")]
		private void DCGMCINAKGK(EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME, BCAKLPOGMDM CGMOHKMHOJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x3C77B10", Offset = "0x3C76D10", VA = "0x183C77B10")]
		private void MFGKEOOHIOC(EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME, BCAKLPOGMDM PKKCEGFCOPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x3C758C0", Offset = "0x3C74AC0", VA = "0x183C758C0", Slot = "124")]
		[AsyncStateMachine(typeof(KFIHKGIFOPC<>.JNHGIMAGBLJ))]
		public Task<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> DKOBMMNKFAH(string BAGHNKBMGLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3C74A80", Offset = "0x3C73C80", VA = "0x183C74A80", Slot = "53")]
		private void BJNDOMLMIIA(object IBIAFLEJCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3C75850", Offset = "0x3C74A50", VA = "0x183C75850", Slot = "54")]
		private void DDAHFMHACOD(object IBIAFLEJCBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x3C752F0", Offset = "0x3C744F0", VA = "0x183C752F0", Slot = "28")]
		private bool COHGKMIAHPK([In] GAJMFIFOLMF NICEPFIEJED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x3C76830", Offset = "0x3C75A30", VA = "0x183C76830", Slot = "30")]
		private bool GBBBMEGBMDI([In] DKJMCLNAPDB NICEPFIEJED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3C74BC0", Offset = "0x3C73DC0", VA = "0x183C74BC0", Slot = "47")]
		private bool BKHANMFHHBJ([In] Guid NMEFCALOOLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3C740B0", Offset = "0x3C732B0", VA = "0x183C740B0")]
		[CompilerGenerated]
		private string AFGDHJIDHON()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3C77B80", Offset = "0x3C76D80", VA = "0x183C77B80")]
		[CompilerGenerated]
		private void MGGDLEPJIFI(string IKEFBMMMAJB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class IGCDGBHIFPL : KNJANLECPDJ<MLMAMDNGONN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public override NodeVisualizationKey OGJDOBGGLGA
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0xC09A70", Offset = "0xC08C70", VA = "0x180C09A70", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x1E14310", Offset = "0x1E13510", VA = "0x181E14310")]
		public IGCDGBHIFPL(FKPPOCEMHDG GDABCJDBLDL, MLMAMDNGONN CLKPBALPCKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	private sealed class ONBEGCAPBKE : FFOEFCLIBOI<BDNDLGELDKN>
	{
		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public override NodeVisualizationKey OGJDOBGGLGA
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x872860", Offset = "0x871A60", VA = "0x180872860", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x1E24F80", Offset = "0x1E24180", VA = "0x181E24F80")]
		public ONBEGCAPBKE(FKPPOCEMHDG GDABCJDBLDL, BDNDLGELDKN CLKPBALPCKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public abstract class EAJNPHBPPON<T> : KFIHKGIFOPC<T> where T : notnull, OBFGBGOFKKL
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class EDCFGDNCNPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public IReadOnlyList<KeyValuePair<string, GNJHHMGGNHB>> clipOptions;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public EAJNPHBPPON<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public IReadOnlyDictionary<Guid, int> clipGuidToIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public IReadOnlyDictionary<int, Guid> clipIndexToGuid;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public GMMJIAGDPFO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public GBCFODFHNAP clipType;

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public EDCFGDNCNPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
			internal IReadOnlyList<KeyValuePair<string, GNJHHMGGNHB>> NNALGCNIMGD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x345EAA0", Offset = "0x345DCA0", VA = "0x18345EAA0")]
			internal int PGJLPLBMKHM()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x345E830", Offset = "0x345DA30", VA = "0x18345E830")]
			internal void JAJHGDHODNB(int clipIndex)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x345E740", Offset = "0x345D940", VA = "0x18345E740")]
			internal void DLHEKMGMDGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x345E790", Offset = "0x345D990", VA = "0x18345E790")]
			internal float FBDLGDADONG()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x345ECA0", Offset = "0x345DEA0", VA = "0x18345ECA0")]
			internal void PLKNDPJBKKP(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x345E7E0", Offset = "0x345D9E0", VA = "0x18345E7E0")]
			internal float IKPNLGDKJKE()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0x345EBF0", Offset = "0x345DDF0", VA = "0x18345EBF0")]
			internal void PJCIJLNCLJP(float value)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x345EA50", Offset = "0x345DC50", VA = "0x18345EA50")]
			internal float KKNPDFEBBLN()
			{
				return default(float);
			}

			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0x345ED50", Offset = "0x345DF50", VA = "0x18345ED50")]
			internal void POOFKGNDANH(float value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public override NodeVisualizationKey OGJDOBGGLGA
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x8E27A0", Offset = "0x8E19A0", VA = "0x1808E27A0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public abstract GBCFODFHNAP IMOHKCDLOLH
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(Slot = "125")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3457310", Offset = "0x3456510", VA = "0x183457310")]
		public EAJNPHBPPON(FKPPOCEMHDG GDABCJDBLDL, T CLKPBALPCKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x3456B60", Offset = "0x3455D60", VA = "0x183456B60", Slot = "119")]
		protected sealed override void AEJEAAPCAKI(NEGACBHCGDA LGEGIEIBAEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	private sealed class DDDFOJMCKHA : KFIHKGIFOPC<LHGPNMMLIAC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public override NodeVisualizationKey OGJDOBGGLGA
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x8E2B00", Offset = "0x8E1D00", VA = "0x1808E2B00", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x1E0E970", Offset = "0x1E0DB70", VA = "0x181E0E970")]
		public DDDFOJMCKHA(FKPPOCEMHDG GDABCJDBLDL, LHGPNMMLIAC CLKPBALPCKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public sealed class JONPDIDENAH : EAJNPHBPPON<LFEHMFKOJCC>
	{
		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public override GBCFODFHNAP IMOHKCDLOLH
		{
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "125")]
			get
			{
				return default(GBCFODFHNAP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1E189C0", Offset = "0x1E17BC0", VA = "0x181E189C0")]
		public JONPDIDENAH(FKPPOCEMHDG GDABCJDBLDL, LFEHMFKOJCC PFGBPGKFOLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	private sealed class PHGBEFJLIEJ : FFOEFCLIBOI<GFPDADEBGNN>
	{
		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public override NodeVisualizationKey OGJDOBGGLGA
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x872860", Offset = "0x871A60", VA = "0x180872860", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x1E25870", Offset = "0x1E24A70", VA = "0x181E25870")]
		public PHGBEFJLIEJ(FKPPOCEMHDG GDABCJDBLDL, GFPDADEBGNN CLKPBALPCKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private sealed class BBAFIPNCONC : FFOEFCLIBOI<OJJKLLCMKIA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public override NodeVisualizationKey OGJDOBGGLGA
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x872860", Offset = "0x871A60", VA = "0x180872860", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x1E0B4A0", Offset = "0x1E0A6A0", VA = "0x181E0B4A0")]
		public BBAFIPNCONC(FKPPOCEMHDG GDABCJDBLDL, OJJKLLCMKIA CLKPBALPCKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public sealed class HFKLCGIICFF : CBMOGBIOCEG<JDKDAHMBCGM>
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class GBNGEGOKELK
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200006D")]
			private struct <<AddHomeValueSetting>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				public AsyncVoidMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				public GBNGEGOKELK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				public string value;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				private TaskAwaiter<bool> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				private TaskAwaiter<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x60001FB")]
				[Cpp2IlInjected.Address(RVA = "0x1E25DB0", Offset = "0x1E24FB0", VA = "0x181E25DB0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60001FC")]
				[Cpp2IlInjected.Address(RVA = "0x8A5FC0", Offset = "0x8A51C0", VA = "0x1808A5FC0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public GMMJIAGDPFO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public HFKLCGIICFF <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public GBNGEGOKELK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x1E11C30", Offset = "0x1E10E30", VA = "0x181E11C30")]
			[AsyncStateMachine(typeof(<<AddHomeValueSetting>b__0>d))]
			internal void DCNHHMJAHDG(string value)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x1E130A0", Offset = "0x1E122A0", VA = "0x181E130A0")]
		public HFKLCGIICFF(FKPPOCEMHDG GDABCJDBLDL, JDKDAHMBCGM PFGBPGKFOLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x1E12DC0", Offset = "0x1E11FC0", VA = "0x181E12DC0", Slot = "125")]
		protected override void KPLLAMOLKMG(NEGACBHCGDA LGEGIEIBAEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public sealed class GKKHCOOCAEJ : EAJNPHBPPON<HONDMJFIIBI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public override GBCFODFHNAP IMOHKCDLOLH
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x9265C0", Offset = "0x9257C0", VA = "0x1809265C0", Slot = "125")]
			get
			{
				return default(GBCFODFHNAP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x1E12770", Offset = "0x1E11970", VA = "0x181E12770")]
		public GKKHCOOCAEJ(FKPPOCEMHDG GDABCJDBLDL, HONDMJFIIBI PFGBPGKFOLN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private sealed class GOCNJCHEGBB : KFIHKGIFOPC<OHIOJKBMGBH>
	{
		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public override NodeVisualizationKey OGJDOBGGLGA
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0xC59F60", Offset = "0xC59160", VA = "0x180C59F60", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x1E128C0", Offset = "0x1E11AC0", VA = "0x181E128C0")]
		public GOCNJCHEGBB(FKPPOCEMHDG GDABCJDBLDL, OHIOJKBMGBH CLKPBALPCKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public sealed class AKHJIKDJHCO : KFIHKGIFOPC<OOLKPFMABDE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private readonly Dictionary<string, GNJHHMGGNHB> EMNEBGFFLNF;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public sealed override NodeVisualizationKey OGJDOBGGLGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public sealed override bool DNNEGFIGAME
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850", Slot = "91")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected sealed override bool DAAFOPMHEEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850", Slot = "89")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x1E0AB30", Offset = "0x1E09D30", VA = "0x181E0AB30")]
		public AKHJIKDJHCO(FKPPOCEMHDG GDABCJDBLDL, OOLKPFMABDE CLKPBALPCKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x1E0A860", Offset = "0x1E09A60", VA = "0x181E0A860", Slot = "119")]
		protected override void AEJEAAPCAKI(NEGACBHCGDA LGEGIEIBAEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x1E0AA90", Offset = "0x1E09C90", VA = "0x181E0AA90")]
		private int CAMGEDLBFPJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x1E0AAD0", Offset = "0x1E09CD0", VA = "0x181E0AAD0")]
		private void LGKOFAAMOCE(int LILHNKAIGNI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public sealed class APABMBPCEJL : CBMOGBIOCEG<IAONADDDKFO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x1E0B440", Offset = "0x1E0A640", VA = "0x181E0B440")]
		public APABMBPCEJL(FKPPOCEMHDG GDABCJDBLDL, IAONADDDKFO CLKPBALPCKM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public abstract class CBMOGBIOCEG<TVariableNode> : KFIHKGIFOPC<TVariableNode> where TVariableNode : notnull, IAONADDDKFO
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class DMALJLINGPI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public CBMOGBIOCEG<TVariableNode> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public GMMJIAGDPFO nodeAdapterDeps;

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public DMALJLINGPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x5135420", Offset = "0x5134620", VA = "0x185135420")]
			internal bool NNALGCNIMGD()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x5135470", Offset = "0x5134670", VA = "0x185135470")]
			internal void PGJLPLBMKHM(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x51353D0", Offset = "0x51345D0", VA = "0x1851353D0")]
			internal bool JAJHGDHODNB()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x5135280", Offset = "0x5134480", VA = "0x185135280")]
			internal void DLHEKMGMDGI(bool v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x5135330", Offset = "0x5134530", VA = "0x185135330")]
			internal bool FBDLGDADONG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class BLALNFBLHGD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public GMMJIAGDPFO nodeAdapterDeps;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public CBMOGBIOCEG<TVariableNode> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public BLALNFBLHGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x48A9110", Offset = "0x48A8310", VA = "0x1848A9110")]
			internal void DCNHHMJAHDG(string v)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public override NodeVisualizationKey OGJDOBGGLGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x9284F0", Offset = "0x9276F0", VA = "0x1809284F0", Slot = "90")]
			get
			{
				return default(NodeVisualizationKey);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public override GMLJKBLFPAO NIKHKGDABAK
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x4B50E70", Offset = "0x4B50070", VA = "0x184B50E70", Slot = "93")]
			get
			{
				return default(GMLJKBLFPAO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x4B50D20", Offset = "0x4B4FF20", VA = "0x184B50D20")]
		protected CBMOGBIOCEG(FKPPOCEMHDG GDABCJDBLDL, TVariableNode CLKPBALPCKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x4B507D0", Offset = "0x4B4F9D0", VA = "0x184B507D0", Slot = "87")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x4B50380", Offset = "0x4B4F580", VA = "0x184B50380", Slot = "119")]
		protected override void AEJEAAPCAKI(NEGACBHCGDA LGEGIEIBAEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x4B50910", Offset = "0x4B4FB10", VA = "0x184B50910", Slot = "125")]
		protected virtual void KPLLAMOLKMG(NEGACBHCGDA LGEGIEIBAEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4B50C60", Offset = "0x4B4FE60", VA = "0x184B50C60", Slot = "104")]
		public override void MNHGCJGIAKL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x1E23E90", Offset = "0x1E23090", VA = "0x181E23E90")]
	internal static NKPBMKEEPNC MIJABIECKKD(FKPPOCEMHDG GDABCJDBLDL, OLNAEHBJPHD CLKPBALPCKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public sealed class HJNPEHAIGLI : LEBPGBODEOH, DHPNMBLJEAJ, KNGOLIJFIEN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public EIPPGFCFCGI<PAOCCIMMJDB> LBNPNHBEKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xDCF750", Offset = "0xDCE950", VA = "0x180DCF750", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(EIPPGFCFCGI<PAOCCIMMJDB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public EIPPGFCFCGI<HFKDCDEJJMH> ACMPBOKENOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1050920", Offset = "0x104FB20", VA = "0x181050920", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return default(EIPPGFCFCGI<HFKDCDEJJMH>);
		}
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1E13750", Offset = "0x1E12950", VA = "0x181E13750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	private EIPPGFCFCGI<POPDDCCDEEM> KKKFHEGFNOA
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0xA58F60", Offset = "0xA58160", VA = "0x180A58F60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public override EIPPGFCFCGI<HKCAPACBGFO> IPJDHDAHGHK
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x1E13710", Offset = "0x1E12910", VA = "0x181E13710", Slot = "20")]
		get
		{
			return default(EIPPGFCFCGI<HKCAPACBGFO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x1E13B00", Offset = "0x1E12D00", VA = "0x181E13B00")]
	private HJNPEHAIGLI(FKPPOCEMHDG GDABCJDBLDL, OLNAEHBJPHD CLKPBALPCKM, MIGGDFPHEII BAJNBBIKGOH, EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME, EIPPGFCFCGI<HFKDCDEJJMH> JECBHFPMAIO, EIPPGFCFCGI<POPDDCCDEEM> NEOBBBKDHJA, bool DNCHFGEMHOE, string IKEFBMMMAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x1E13760", Offset = "0x1E12960", VA = "0x181E13760")]
	public static HJNPEHAIGLI MIJABIECKKD(FKPPOCEMHDG GDABCJDBLDL, OLNAEHBJPHD CLKPBALPCKM, MIGGDFPHEII JOANOPHIHDM, EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME, EIPPGFCFCGI<POPDDCCDEEM> NEOBBBKDHJA, EIPPGFCFCGI<HFKDCDEJJMH> JECBHFPMAIO, bool DNCHFGEMHOE, bool ODLPNCJKBLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x1E13750", Offset = "0x1E12950", VA = "0x181E13750")]
	internal void OPFDHJEDHCG(EIPPGFCFCGI<HFKDCDEJJMH> NICEPFIEJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public abstract class LEBPGBODEOH : KNGOLIJFIEN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	private struct JLEOIJMODNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private ANFPGPBPMKK? IGELNFBEEED;

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x1E18950", Offset = "0x1E17B50", VA = "0x181E18950")]
		public void NDGKPACNNFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x1E188B0", Offset = "0x1E17AB0", VA = "0x181E188B0")]
		public ANFPGPBPMKK GCNBOIGPKGF(LEBPGBODEOH FDBOOBDJGEA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	protected readonly FKPPOCEMHDG JDIMNKODJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	protected readonly OLNAEHBJPHD KNGCIKLCNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private JLEOIJMODNN LPPFJIHAFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private readonly LPMOILPLCEH EMILCJKJDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private readonly List<LEKCBKNFIMG> HLKFLCHODPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private readonly List<BNIDGFBIENM> EKKCDABBDNK;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	[HHAPCIPDAID("To be deprecated with NodeConnection")]
	public IEnumerable<StaticEdge> AOCIHACBHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x1E21000", Offset = "0x1E20200", VA = "0x181E21000", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public DisplayKind FFFDCKHNOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7C4120", Offset = "0x7C3320", VA = "0x1807C4120", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(DisplayKind);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public EIPPGFCFCGI<LOIIILALBLN> PANPDPPCEFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x1E218D0", Offset = "0x1E20AD0", VA = "0x181E218D0", Slot = "6")]
		get
		{
			return default(EIPPGFCFCGI<LOIIILALBLN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public BCFHHBLPOPP<LOIIILALBLN> DOOENIPGCGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x1E21580", Offset = "0x1E20780", VA = "0x181E21580", Slot = "7")]
		get
		{
			return default(BCFHHBLPOPP<LOIIILALBLN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public JDOJBAPBPOD GJNACKCIEDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x1A07190", Offset = "0x1A06390", VA = "0x181A07190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public CHBLAFOJNPB OEGFIJIMEHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x1E21140", Offset = "0x1E20340", VA = "0x181E21140", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	protected ANFPGPBPMKK NCBLBLHOJCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x1E21140", Offset = "0x1E20340", VA = "0x181E21140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public PortImage EAPDKCBBDJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x1E217A0", Offset = "0x1E209A0", VA = "0x181E217A0", Slot = "13")]
		get
		{
			return default(PortImage);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public string ECHFBJHACCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7B6020", Offset = "0x7B5220", VA = "0x1807B6020", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7B6270", Offset = "0x7B5470", VA = "0x1807B6270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public BCFHHBLPOPP<FKGCAMGPCBC> OMAIHEMGPCG
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x1E21780", Offset = "0x1E20980", VA = "0x181E21780", Slot = "9")]
		get
		{
			return default(BCFHHBLPOPP<FKGCAMGPCBC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public EIPPGFCFCGI<OFLCOGGIINH> DIFJJFKEGMN
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x867E70", Offset = "0x867070", VA = "0x180867E70", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(EIPPGFCFCGI<OFLCOGGIINH>);
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xD17370", Offset = "0xD16570", VA = "0x180D17370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public abstract EIPPGFCFCGI<HKCAPACBGFO> IPJDHDAHGHK
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x1E21BC0", Offset = "0x1E20DC0", VA = "0x181E21BC0")]
	protected LEBPGBODEOH(FKPPOCEMHDG GDABCJDBLDL, OLNAEHBJPHD CLKPBALPCKM, LPMOILPLCEH GFJEDKIAAJH, EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME, bool DNCHFGEMHOE, string IKEFBMMMAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x1E21240", Offset = "0x1E20440", VA = "0x181E21240", Slot = "21")]
	protected virtual void GEJAFFIMNGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x1E20EB0", Offset = "0x1E200B0", VA = "0x181E20EB0", Slot = "22")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x1E20780", Offset = "0x1E1F980", VA = "0x181E20780", Slot = "14")]
	public void BAKBGOELDMH(LEKCBKNFIMG KLDIIAKIDAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x1E21960", Offset = "0x1E20B60", VA = "0x181E21960", Slot = "15")]
	public void OEKCNPDKMGE(BNIDGFBIENM KLDIIAKIDAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x1E20830", Offset = "0x1E1FA30", VA = "0x181E20830", Slot = "16")]
	public void CHHEOIOIMIJ(BEKJFHAFPHG JGHLBOHENIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x1E21900", Offset = "0x1E20B00", VA = "0x181E21900", Slot = "23")]
	protected virtual void OCOAOFKLHJJ(BEKJFHAFPHG JGHLBOHENIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x1E21390", Offset = "0x1E20590", VA = "0x181E21390")]
	private void GHGNPBBLBOH(bool PMBMOONGPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x1E21A10", Offset = "0x1E20C10", VA = "0x181E21A10")]
	private void PCFNFNMILOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x1E215D0", Offset = "0x1E207D0", VA = "0x181E215D0")]
	private void JGKPIAFBIPL([In] LCPCEHIAGHA FKNHHIJNJMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x1E21520", Offset = "0x1E20720", VA = "0x181E21520", Slot = "17")]
	public void HMFOIMGFEGN(LEKCBKNFIMG KLDIIAKIDAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x1E211E0", Offset = "0x1E203E0", VA = "0x181E211E0", Slot = "18")]
	public void GAJHPEPKPBC(BNIDGFBIENM KLDIIAKIDAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x7B6270", Offset = "0x7B5470", VA = "0x1807B6270")]
	internal void DAADGDODEJM(string IKEFBMMMAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x1E215B0", Offset = "0x1E207B0", VA = "0x181E215B0")]
	internal void JDLBGJDOBHH(BIIPJKDIAFE NMAKCOKENKA, JDOJBAPBPOD FLPJMDMACMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0xD17370", Offset = "0xD16570", VA = "0x180D17370")]
	internal void GJABHJJGEKE(EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public sealed class JPIFAGIGLOH : HFIKGBNIADG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class IEJMEJKCJGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public FKPPOCEMHDG circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public OLNAEHBJPHD node;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public EIPPGFCFCGI<OFLCOGGIINH> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public bool canInteract;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public bool ignoreChipConfigPortNames;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public IEJMEJKCJGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x1E14280", Offset = "0x1E13480", VA = "0x181E14280")]
		internal IJMEFFIIKHE PKMIGAPCIDF((int PortDescIndex, int PortIndex, OBDLDHNDHKD InputPort) i)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x1E141F0", Offset = "0x1E133F0", VA = "0x181E141F0")]
		internal HJNPEHAIGLI GHEFOGIAMNF(MIGGDFPHEII i, int idx)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct PDPOGLPAFDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public JPIFAGIGLOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private OHAIMHJPJEG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private TaskAwaiter<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x1E24FE0", Offset = "0x1E241E0", VA = "0x181E24FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x1E25440", Offset = "0x1E24640", VA = "0x181E25440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct JGNIIFDBOFI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public JPIFAGIGLOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public EIPPGFCFCGI<NAMMKHHGCFO> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private OHAIMHJPJEG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private TaskAwaiter<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x1E184F0", Offset = "0x1E176F0", VA = "0x181E184F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x1E18840", Offset = "0x1E17A40", VA = "0x181E18840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private struct PEECOMEDGJM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public JPIFAGIGLOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public EIPPGFCFCGI<POPDDCCDEEM> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private OHAIMHJPJEG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private TaskAwaiter<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x1E254B0", Offset = "0x1E246B0", VA = "0x181E254B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x1E25800", Offset = "0x1E24A00", VA = "0x181E25800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct DCKBHMMJMBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public JPIFAGIGLOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public EIPPGFCFCGI<NAMMKHHGCFO> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public EIPPGFCFCGI<NAMMKHHGCFO> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private OHAIMHJPJEG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private TaskAwaiter<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x1E0E5B0", Offset = "0x1E0D7B0", VA = "0x181E0E5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x1E0E900", Offset = "0x1E0DB00", VA = "0x181E0E900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct CKFKHFHNJLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public JPIFAGIGLOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public EIPPGFCFCGI<POPDDCCDEEM> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public EIPPGFCFCGI<POPDDCCDEEM> targetIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private OHAIMHJPJEG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private TaskAwaiter<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x1E0CA80", Offset = "0x1E0BC80", VA = "0x181E0CA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x1E0CDD0", Offset = "0x1E0BFD0", VA = "0x181E0CDD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private struct DNKCHEGDKLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public JPIFAGIGLOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private OHAIMHJPJEG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private TaskAwaiter<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x1E0EEE0", Offset = "0x1E0E0E0", VA = "0x181E0EEE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x1E0F350", Offset = "0x1E0E550", VA = "0x181E0F350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private struct CNNDBKGGOKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public JPIFAGIGLOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public string newName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private OHAIMHJPJEG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private TaskAwaiter<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x1E0D750", Offset = "0x1E0C950", VA = "0x181E0D750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x1E0DAA0", Offset = "0x1E0CCA0", VA = "0x181E0DAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private struct HICJLEDNCPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public JPIFAGIGLOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public EIPPGFCFCGI<NAMMKHHGCFO> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private OHAIMHJPJEG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private TaskAwaiter<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1E132E0", Offset = "0x1E124E0", VA = "0x181E132E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x1E13630", Offset = "0x1E12830", VA = "0x181E13630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private struct HEMCFLICEKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public JPIFAGIGLOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public EIPPGFCFCGI<POPDDCCDEEM> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private OHAIMHJPJEG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private TaskAwaiter<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x1E12A00", Offset = "0x1E11C00", VA = "0x181E12A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x1E12D50", Offset = "0x1E11F50", VA = "0x181E12D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private struct KAHJFBLLFDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public JPIFAGIGLOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public POEJGKDJFJL type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public EIPPGFCFCGI<NAMMKHHGCFO> inputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private OHAIMHJPJEG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private TaskAwaiter<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x1E1EF80", Offset = "0x1E1E180", VA = "0x181E1EF80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x1E1F310", Offset = "0x1E1E510", VA = "0x181E1F310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct FFKNPEALDPI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public JPIFAGIGLOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public POEJGKDJFJL type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public EIPPGFCFCGI<POPDDCCDEEM> outputDefId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private OHAIMHJPJEG <errReporting>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private TaskAwaiter<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x1E0F680", Offset = "0x1E0E880", VA = "0x181E0F680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x1E0FA10", Offset = "0x1E0EC10", VA = "0x181E0FA10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly bool CKGNFEKMDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly FKPPOCEMHDG JDIMNKODJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly bool AJJPJHPKFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private HDCLKODNOCA<EJKCAAAPMFI, IJMEFFIIKHE> KIFPJMLAMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private HDCLKODNOCA<EJKCAAAPMFI, IMNOFHILKPL> JMNHJCDPDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly OLNAEHBJPHD KNGCIKLCNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private HDCLKODNOCA<HFKDCDEJJMH, HJNPEHAIGLI> GPMMCBNBKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private HDCLKODNOCA<HFKDCDEJJMH, DHPNMBLJEAJ> LIBGAIHKCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private string? ABPANLEBKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly BCAKLPOGMDM JCMNGDAHGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private EIPPGFCFCGI<OFLCOGGIINH> FPAAFLEINKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly bool KAHCHEFJIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	[CompilerGenerated]
	private Action? MJDOMPEEPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	[CompilerGenerated]
	private Action? NAOPMELLOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	[CompilerGenerated]
	private Action<EIPPGFCFCGI<EJKCAAAPMFI>>? LPFOLMOAODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	[CompilerGenerated]
	private Action<EIPPGFCFCGI<HFKDCDEJJMH>>? BKJCKJDOCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	[CompilerGenerated]
	private HFIKGBNIADG.IFNBMIFJNHB? HICAJOJOMHP;

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public bool GDLGLGPOJDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x1E1D010", Offset = "0x1E1C210", VA = "0x181E1D010", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool PAEHEMMOHHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x1E19720", Offset = "0x1E18920", VA = "0x181E19720", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public bool ANBCJFIFCMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x1E1E610", Offset = "0x1E1D810", VA = "0x181E1E610", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public BCFHHBLPOPP<LOIIILALBLN> DOOENIPGCGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x1E1CEF0", Offset = "0x1E1C0F0", VA = "0x181E1CEF0", Slot = "7")]
		get
		{
			return default(BCFHHBLPOPP<LOIIILALBLN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool GNBLNKFHHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x1E1EA70", Offset = "0x1E1DC70", VA = "0x181E1EA70", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public HDCLKODNOCA<EJKCAAAPMFI, IMNOFHILKPL> FCJPDPFIEBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "9")]
		get
		{
			return default(HDCLKODNOCA<EJKCAAAPMFI, IMNOFHILKPL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public string ECHFBJHACCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x1E1E5E0", Offset = "0x1E1D7E0", VA = "0x181E1E5E0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public BCFHHBLPOPP<FKGCAMGPCBC> OMAIHEMGPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x1E1D0D0", Offset = "0x1E1C2D0", VA = "0x181E1D0D0", Slot = "11")]
		get
		{
			return default(BCFHHBLPOPP<FKGCAMGPCBC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public HDCLKODNOCA<HFKDCDEJJMH, DHPNMBLJEAJ> GJCGBIBILJC
	{
		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x7B6020", Offset = "0x7B5220", VA = "0x1807B6020", Slot = "12")]
		get
		{
			return default(HDCLKODNOCA<HFKDCDEJJMH, DHPNMBLJEAJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public EIPPGFCFCGI<OFLCOGGIINH> DIFJJFKEGMN
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xA591E0", Offset = "0xA583E0", VA = "0x180A591E0", Slot = "13")]
		get
		{
			return default(EIPPGFCFCGI<OFLCOGGIINH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	public event Action MJAPLHOEEFK
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x1E18FD0", Offset = "0x1E181D0", VA = "0x181E18FD0", Slot = "14")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x1E1D8E0", Offset = "0x1E1CAE0", VA = "0x181E1D8E0", Slot = "15")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	public event Action APJIPJDEDPM
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x1E1DA40", Offset = "0x1E1CC40", VA = "0x181E1DA40", Slot = "16")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x1E1C540", Offset = "0x1E1B740", VA = "0x181E1C540", Slot = "17")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	public event Action<EIPPGFCFCGI<EJKCAAAPMFI>, EIPPGFCFCGI<EJKCAAAPMFI>> PFBIFPKLKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x1E1D760", Offset = "0x1E1C960", VA = "0x181E1D760", Slot = "18")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x1E19070", Offset = "0x1E18270", VA = "0x181E19070", Slot = "19")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	public event Action<EIPPGFCFCGI<EJKCAAAPMFI>, EIPPGFCFCGI<EJKCAAAPMFI>> IBGNMAAPDJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x1E1ECD0", Offset = "0x1E1DED0", VA = "0x181E1ECD0", Slot = "20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x1E1B560", Offset = "0x1E1A760", VA = "0x181E1B560", Slot = "21")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	public event Action<EIPPGFCFCGI<HFKDCDEJJMH>, EIPPGFCFCGI<HFKDCDEJJMH>> KKHIOGDABGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x1E1E6D0", Offset = "0x1E1D8D0", VA = "0x181E1E6D0", Slot = "22")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x1E1DE90", Offset = "0x1E1D090", VA = "0x181E1DE90", Slot = "23")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action<EIPPGFCFCGI<HFKDCDEJJMH>, EIPPGFCFCGI<HFKDCDEJJMH>> DKFDJBGIGMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x1E1B1B0", Offset = "0x1E1A3B0", VA = "0x181E1B1B0", Slot = "24")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x1E1CB40", Offset = "0x1E1BD40", VA = "0x181E1CB40", Slot = "25")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action<EIPPGFCFCGI<EJKCAAAPMFI>, IMNOFHILKPL> GIJCNLPIDKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x1E1CC60", Offset = "0x1E1BE60", VA = "0x181E1CC60", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x1E1CD20", Offset = "0x1E1BF20", VA = "0x181E1CD20", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event Action<EIPPGFCFCGI<EJKCAAAPMFI>> CEGFJGEPGCG
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x1E1D820", Offset = "0x1E1CA20", VA = "0x181E1D820", Slot = "28")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x1E1B270", Offset = "0x1E1A470", VA = "0x181E1B270", Slot = "29")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<EIPPGFCFCGI<EJKCAAAPMFI>, IMNOFHILKPL> NADAKMKNJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x1E19B80", Offset = "0x1E18D80", VA = "0x181E19B80", Slot = "30")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x1E19990", Offset = "0x1E18B90", VA = "0x181E19990", Slot = "31")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<EIPPGFCFCGI<HFKDCDEJJMH>, DHPNMBLJEAJ> GJCDFJFHCAK
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x1E1D980", Offset = "0x1E1CB80", VA = "0x181E1D980", Slot = "32")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x1E19C40", Offset = "0x1E18E40", VA = "0x181E19C40", Slot = "33")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<EIPPGFCFCGI<HFKDCDEJJMH>> MOOEMJGLPKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x1E1A0B0", Offset = "0x1E192B0", VA = "0x181E1A0B0", Slot = "34")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x1E19130", Offset = "0x1E18330", VA = "0x181E19130", Slot = "35")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<EIPPGFCFCGI<HFKDCDEJJMH>, DHPNMBLJEAJ> LMLEPLANEID
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x1E1CA80", Offset = "0x1E1BC80", VA = "0x181E1CA80", Slot = "36")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x1E1EC10", Offset = "0x1E1DE10", VA = "0x181E1EC10", Slot = "37")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x1E1EE80", Offset = "0x1E1E080", VA = "0x181E1EE80")]
	private JPIFAGIGLOH(bool DNCHFGEMHOE, FKPPOCEMHDG GDABCJDBLDL, bool GNMOODJGHGP, HDCLKODNOCA<EJKCAAAPMFI, IJMEFFIIKHE> AOMGHNALNKP, HDCLKODNOCA<EJKCAAAPMFI, IMNOFHILKPL> LPLEAJFKDED, OLNAEHBJPHD CLKPBALPCKM, HDCLKODNOCA<HFKDCDEJJMH, HJNPEHAIGLI> DNLOJHNFNEH, HDCLKODNOCA<HFKDCDEJJMH, DHPNMBLJEAJ> EKIJDFDBGKE, string? ENHIKHAMKJK, BCAKLPOGMDM CGMOHKMHOJN, EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME, bool ODLPNCJKBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x1E1DF50", Offset = "0x1E1D150", VA = "0x181E1DF50")]
	public static JPIFAGIGLOH MIJABIECKKD(bool DNCHFGEMHOE, FKPPOCEMHDG GDABCJDBLDL, bool GNMOODJGHGP, OLNAEHBJPHD CLKPBALPCKM, BCAKLPOGMDM CGMOHKMHOJN, EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME, bool ODLPNCJKBLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x1E1B9C0", Offset = "0x1E1ABC0", VA = "0x181E1B9C0")]
	private void GEJAFFIMNGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A6B0", Offset = "0x1E198B0", VA = "0x181E1A6B0", Slot = "49")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x1E1CF20", Offset = "0x1E1C120", VA = "0x181E1CF20", Slot = "38")]
	[AsyncStateMachine(typeof(PDPOGLPAFDP))]
	public Task<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> IHDCOFCCAME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x1E19760", Offset = "0x1E18960", VA = "0x181E19760")]
	private (IJOLOIINFGM, int)? CCOJEIAONPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x1E1ED90", Offset = "0x1E1DF90", VA = "0x181E1ED90")]
	private void POMOLLJLJMD(int EKLDDDODIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x1289D20", Offset = "0x1288F20", VA = "0x181289D20")]
	private void LCOMHNDIPHO(int EKLDDDODIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x1E1DAF0", Offset = "0x1E1CCF0", VA = "0x181E1DAF0")]
	private void MDCDICFONMI(int JDKAOGPMHEM, int JLEKPODGLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x1E1CC00", Offset = "0x1E1BE00", VA = "0x181E1CC00")]
	private void HGEBGFGJNFO(int JDKAOGPMHEM, int JLEKPODGLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x1E191F0", Offset = "0x1E183F0", VA = "0x181E191F0")]
	private void BMKIACKOOAP(int EKLDDDODIIG, EIPPGFCFCGI<EJKCAAAPMFI> GPLIIIGJNPH, OBDLDHNDHKD MBFPHKFMHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x1E1CED0", Offset = "0x1E1C0D0", VA = "0x181E1CED0")]
	private void HNHJNJNMNCA(int PMBMOONGPPJ, EIPPGFCFCGI<EJKCAAAPMFI> GPLIIIGJNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x1E1C5F0", Offset = "0x1E1B7F0", VA = "0x181E1C5F0")]
	private void GNOOCEBEKOB(int PMBMOONGPPJ, EIPPGFCFCGI<EJKCAAAPMFI> GPLIIIGJNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x1E1D0F0", Offset = "0x1E1C2F0", VA = "0x181E1D0F0")]
	private void KENHLJHMLJC(int EKLDDDODIIG, EIPPGFCFCGI<EJKCAAAPMFI> GPLIIIGJNPH, OBDLDHNDHKD MBFPHKFMHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x1E19F60", Offset = "0x1E19160", VA = "0x181E19F60")]
	private void DBDLBCNGCNP(int EKLDDDODIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x8941E0", Offset = "0x8933E0", VA = "0x1808941E0")]
	private void BIPJFDOGKAH(int EKLDDDODIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x1E1D670", Offset = "0x1E1C870", VA = "0x181E1D670")]
	private void LBBJHCGMAAD(int EKLDDDODIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x1289D20", Offset = "0x1288F20", VA = "0x181289D20")]
	private void BPHPBGDCGDP(int EKLDDDODIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x1E1B620", Offset = "0x1E1A820", VA = "0x181E1B620")]
	private void GDOONPMOOCB(int JDKAOGPMHEM, int JLEKPODGLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x1E1EA10", Offset = "0x1E1DC10", VA = "0x181E1EA10")]
	private void OKKCGFNCGNB(int JDKAOGPMHEM, int JLEKPODGLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x1E1A170", Offset = "0x1E19370", VA = "0x181E1A170")]
	private void DIKHPJNIMLO(int EKLDDDODIIG, EIPPGFCFCGI<HFKDCDEJJMH> GPLIIIGJNPH, MIGGDFPHEII MBFPHKFMHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x1E18FB0", Offset = "0x1E181B0", VA = "0x181E18FB0")]
	private void ADDPOHBPMEA(int PMBMOONGPPJ, EIPPGFCFCGI<HFKDCDEJJMH> GPLIIIGJNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x1E19E30", Offset = "0x1E19030", VA = "0x181E19E30")]
	private void CNLAFCOOIBF(int PMBMOONGPPJ, EIPPGFCFCGI<HFKDCDEJJMH> GPLIIIGJNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x1E1C610", Offset = "0x1E1B810", VA = "0x181E1C610")]
	private void GPEAKODGHCD(int EKLDDDODIIG, EIPPGFCFCGI<HFKDCDEJJMH> GPLIIIGJNPH, MIGGDFPHEII MBFPHKFMHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x1E1E8C0", Offset = "0x1E1DAC0", VA = "0x181E1E8C0")]
	private void OHHMHIIMBEC(int EKLDDDODIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x8941E0", Offset = "0x8933E0", VA = "0x1808941E0")]
	private void KOKKPEOIFLD(int EKLDDDODIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x1E19E50", Offset = "0x1E19050", VA = "0x181E19E50", Slot = "39")]
	[AsyncStateMachine(typeof(JGNIIFDBOFI))]
	public Task<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> CPOMLDLIAGH(EIPPGFCFCGI<NAMMKHHGCFO> PMANMCEJNMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x1E1B330", Offset = "0x1E1A530", VA = "0x181E1B330", Slot = "40")]
	[AsyncStateMachine(typeof(PEECOMEDGJM))]
	public Task<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> FBGJPLJJOMB(EIPPGFCFCGI<POPDDCCDEEM> NEOBBBKDHJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x1E1E4C0", Offset = "0x1E1D6C0", VA = "0x181E1E4C0", Slot = "41")]
	[AsyncStateMachine(typeof(DCKBHMMJMBI))]
	public Task<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> MJHLPHKEBPO(EIPPGFCFCGI<NAMMKHHGCFO> PMANMCEJNMD, EIPPGFCFCGI<NAMMKHHGCFO> OFMHAMMNLIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x1E1EAF0", Offset = "0x1E1DCF0", VA = "0x181E1EAF0", Slot = "42")]
	[AsyncStateMachine(typeof(CKFKHFHNJLI))]
	public Task<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> PBJIJMLEOEH(EIPPGFCFCGI<POPDDCCDEEM> NEOBBBKDHJA, EIPPGFCFCGI<POPDDCCDEEM> OFMHAMMNLIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x1E1CDE0", Offset = "0x1E1BFE0", VA = "0x181E1CDE0", Slot = "43")]
	[AsyncStateMachine(typeof(DNKCHEGDKLL))]
	public Task<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> HLEOICPKDFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x1E1B440", Offset = "0x1E1A640", VA = "0x181E1B440", Slot = "44")]
	[AsyncStateMachine(typeof(CNNDBKGGOKD))]
	public Task<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> FDDPJGFEGAM(string BAGHNKBMGLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x1E19A50", Offset = "0x1E18C50", VA = "0x181E19A50", Slot = "45")]
	[AsyncStateMachine(typeof(HICJLEDNCPM))]
	public Task<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> CEAAFOLHINK(EIPPGFCFCGI<NAMMKHHGCFO> PMANMCEJNMD, string IKEFBMMMAJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x1E1D540", Offset = "0x1E1C740", VA = "0x181E1D540", Slot = "46")]
	[AsyncStateMachine(typeof(HEMCFLICEKA))]
	public Task<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> KMDFLDMLLBF(EIPPGFCFCGI<POPDDCCDEEM> NEOBBBKDHJA, string IKEFBMMMAJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x1E1E790", Offset = "0x1E1D990", VA = "0x181E1E790", Slot = "47")]
	[AsyncStateMachine(typeof(KAHJFBLLFDG))]
	public Task<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> OCIKJFJGMKL(EIPPGFCFCGI<NAMMKHHGCFO> PMANMCEJNMD, POEJGKDJFJL FLPJMDMACMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x1E19D00", Offset = "0x1E18F00", VA = "0x181E19D00", Slot = "48")]
	[AsyncStateMachine(typeof(FFKNPEALDPI))]
	public Task<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> CJLCNLFNBCM(EIPPGFCFCGI<POPDDCCDEEM> NEOBBBKDHJA, POEJGKDJFJL FLPJMDMACMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x1E1C170", Offset = "0x1E1B370", VA = "0x181E1C170")]
	internal void GJABHJJGEKE(EIPPGFCFCGI<OFLCOGGIINH> NICEPFIEJED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public sealed class IIEKEJODDAJ : BDIHEFKILKN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public interface CMEGGFNEODE
	{
		[Cpp2IlInjected.Token(Token = "0x17000097")]
		BIIPJKDIAFE IJEFLKKDCOD
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<DJDLMEOOMEF> PBPNNOHFAKA(CancellationToken AIHJHMPAHCH);

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<CCLNCFGAMPK> KJNCCHAJGJH(CancellationToken AIHJHMPAHCH);

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<DMKGPPKGBPE> DNCFIPLNEDA(CancellationToken AIHJHMPAHCH);
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct COEOLEHDDDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public AsyncTaskMethodBuilder<IIEKEJODDAJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public FKPPOCEMHDG circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public DJDLMEOOMEF roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public CCLNCFGAMPK superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private CMEGGFNEODE <selfDeps>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private CCLNCFGAMPK <finalSuperRoomData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private TaskAwaiter<DJDLMEOOMEF> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private TaskAwaiter<CCLNCFGAMPK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private TaskAwaiter<DMKGPPKGBPE> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private TaskAwaiter<EAIIAMCBMDN> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x1E0DB10", Offset = "0x1E0CD10", VA = "0x181E0DB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1E0E540", Offset = "0x1E0D740", VA = "0x181E0E540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly EAIIAMCBMDN OLFJMABLFED;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public EAIIAMCBMDN PIEHCCKNIEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
	private IIEKEJODDAJ(EAIIAMCBMDN AMHFPKGODKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x1E14390", Offset = "0x1E13590", VA = "0x181E14390")]
	[AsyncStateMachine(typeof(COEOLEHDDDN))]
	public static Task<IIEKEJODDAJ> NPMEBIAKFKD(FKPPOCEMHDG GDABCJDBLDL, DJDLMEOOMEF? JENPAMGBIKD, CCLNCFGAMPK? JFLFEABOIJJ, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x1E14370", Offset = "0x1E13570", VA = "0x181E14370", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public readonly struct HHCLIDDFNIF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private struct FMBDGNOFBLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<object, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public HHCLIDDFNIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public DIGPMMNJEIB action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private TaskAwaiter<NFMFLMAOFMP<object, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x1E2D020", Offset = "0x1E2C220", VA = "0x181E2D020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x1E2D220", Offset = "0x1E2C420", VA = "0x181E2D220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct DDBNKDENIHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<bool, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public int splitSizeBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public GFJGOLELJHO rootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public DJDLMEOOMEF circuitRootData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public CCLNCFGAMPK superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public HHCLIDDFNIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private DIGPMMNJEIB[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private TaskAwaiter<NFMFLMAOFMP<object, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x1E29790", Offset = "0x1E28990", VA = "0x181E29790", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x1E29B70", Offset = "0x1E28D70", VA = "0x181E29B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct OCLLBIFMPLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public HHCLIDDFNIF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private TaskAwaiter<NFMFLMAOFMP<object, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x1E30640", Offset = "0x1E2F840", VA = "0x181E30640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x1E30880", Offset = "0x1E2FA80", VA = "0x181E30880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private readonly DKEELGMMLPH PACHPCGKFPG;

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x94F0A0", Offset = "0x94E2A0", VA = "0x18094F0A0")]
	public HHCLIDDFNIF(DKEELGMMLPH NLAJPGFICGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x1E2DDA0", Offset = "0x1E2CFA0", VA = "0x181E2DDA0")]
	[AsyncStateMachine(typeof(FMBDGNOFBLA))]
	private Task<NFMFLMAOFMP<object, CEGADOEINOB>> OAJPLADHDCP(DIGPMMNJEIB GKGLDBAJJCH, bool OCHKIPLOHCF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x1E2DC40", Offset = "0x1E2CE40", VA = "0x181E2DC40")]
	[AsyncStateMachine(typeof(DDBNKDENIHL))]
	public Task<NFMFLMAOFMP<bool, CEGADOEINOB?>>? NFMNNHFFJHD(int IHHODCFJLJM, GFJGOLELJHO? PJICPHGJFFE, DJDLMEOOMEF? BLPMIMDGIJB, CCLNCFGAMPK? JFLFEABOIJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x1E2DB50", Offset = "0x1E2CD50", VA = "0x181E2DB50")]
	[AsyncStateMachine(typeof(OCLLBIFMPLD))]
	public Task<NFMFLMAOFMP<LKEAICJEMFK, CEGADOEINOB>> HDPILJBHDHI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public sealed class CGHBLOCIBHA : DKFOHDAGDJD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private readonly KLMNFLPHHDB GEGEIJOPPIN;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public KLMNFLPHHDB ILLCMGFCINE
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
	private CGHBLOCIBHA(KLMNFLPHHDB PPJOPAKBIEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x1E295B0", Offset = "0x1E287B0", VA = "0x181E295B0")]
	public static CGHBLOCIBHA LKMADFBDLGL(FKPPOCEMHDG GDABCJDBLDL, GFJGOLELJHO OJJCIHKCPNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x1E29590", Offset = "0x1E28790", VA = "0x181E29590", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public interface EIGPCEJFFAF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000099")]
	GAKHKEICBEM OLGOJOMEPDP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	AEENHPBKOMB MFAHEOLEGKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	JANMLJJOJKE BANMFIGAHOP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	ADKNAKCLBKJ NMGLJLNPBBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	DDPCAIJOGMI JKGHIKMEMBK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public interface CLDLIPEIJJP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	EIGPCEJFFAF? AFJHCKDIGDE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	bool FLFFMMHGNFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	bool BLHBDHAGMHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<EIGPCEJFFAF?>? BDDDFMBCEFE();

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task PPODGHIHEBM(FKPPOCEMHDG GDABCJDBLDL, GFJGOLELJHO OJJCIHKCPNF, DJDLMEOOMEF? AKIDIKGFICM, CCLNCFGAMPK? HNCNDFLICIG);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[JFKICBKCEJP("IStaticCV2Instance")]
public interface BDIHEFKILKN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	EAIIAMCBMDN PIEHCCKNIEE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[JFKICBKCEJP("IStaticEVInstance")]
public interface DKFOHDAGDJD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	KLMNFLPHHDB ILLCMGFCINE
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public sealed class DPIEHCMAHJP : HHPBEBCFENC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private readonly FKPPOCEMHDG JDIMNKODJPN;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public DGOFAFDEANK? KMGHIJMKCHH
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x1E2CB60", Offset = "0x1E2BD60", VA = "0x181E2CB60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
	internal DPIEHCMAHJP(FKPPOCEMHDG GDABCJDBLDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public sealed class ADKNAKCLBKJ : DGOFAFDEANK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private readonly BDIHEFKILKN AAKDOEOCILC;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public BEJHEHIPCGE OAJPLADHDCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x1E27280", Offset = "0x1E26480", VA = "0x181E27280", Slot = "4")]
		get
		{
			return default(BEJHEHIPCGE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public GBBGPCPBBLC GPLOGKNCACI
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x1E27220", Offset = "0x1E26420", VA = "0x181E27220", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public BCFHHBLPOPP<LOIIILALBLN> BLMEAOELFDK
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x1E272E0", Offset = "0x1E264E0", VA = "0x181E272E0", Slot = "6")]
		get
		{
			return default(BCFHHBLPOPP<LOIIILALBLN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public EAIIAMCBMDN PJAIGADGNKC
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x1E271D0", Offset = "0x1E263D0", VA = "0x181E271D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
	public ADKNAKCLBKJ(BDIHEFKILKN LLPNCFFFKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x1E27160", Offset = "0x1E26360", VA = "0x181E27160")]
	public bool EDKCFALDKNF([In] BCFHHBLPOPP<LOIIILALBLN> NMEFCALOOLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x1E27160", Offset = "0x1E26360", VA = "0x181E27160", Slot = "8")]
	private bool GKGKGHDLACP([In] BCFHHBLPOPP<LOIIILALBLN> NMEFCALOOLI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public static class LNKMPHDHAJN
{
	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x1E2FB90", Offset = "0x1E2ED90", VA = "0x181E2FB90")]
	public static JLEBMEOEKFB<GBPKHNJBGED, DIGPMMNJEIB, FKPPOCEMHDG, MDFHMEIIDDC.HIKMGFAPFPD<GBPKHNJBGED, DIGPMMNJEIB, FKPPOCEMHDG>> PPAMHHMFGCA([In] this JLEBMEOEKFB<GBPKHNJBGED, DIGPMMNJEIB, FKPPOCEMHDG, MDFHMEIIDDC.HIKMGFAPFPD<GBPKHNJBGED, DIGPMMNJEIB, FKPPOCEMHDG>> MECFHFGLICI)
	{
		return default(JLEBMEOEKFB<GBPKHNJBGED, DIGPMMNJEIB, FKPPOCEMHDG, MDFHMEIIDDC.HIKMGFAPFPD<GBPKHNJBGED, DIGPMMNJEIB, FKPPOCEMHDG>>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public sealed class OKNNAKCPKIP : JDJBJIGCLGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private readonly FKPPOCEMHDG JDIMNKODJPN;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool BLHBDHAGMHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x1E308F0", Offset = "0x1E2FAF0", VA = "0x181E308F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
	internal OKNNAKCPKIP(FKPPOCEMHDG GDABCJDBLDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
internal sealed class DEBCCENOCPC : ALKODGDMFJE
{
	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x1E2CAC0", Offset = "0x1E2BCC0", VA = "0x181E2CAC0", Slot = "4")]
	public PFHPFDNILHN? INIKNHDJHDA(string? EENAJONDOIE, string? EMBHDFJAFHI, string? LIGNFDNLBLE, KJKKCMMMKID.PBFKKOCJLED.FFBKJMCPJCE PBGGDGAEELP, bool KENJJAFANFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public DEBCCENOCPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public sealed class PCFDNJHGACP : JALLCABCOMH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private struct GBBEDMKDLLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		public AsyncTaskMethodBuilder<AAJEDNIHHDO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		public PCFDNJHGACP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private TaskAwaiter<EIGPCEJFFAF?> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x1E2D3E0", Offset = "0x1E2C5E0", VA = "0x181E2D3E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x1E2D690", Offset = "0x1E2C890", VA = "0x181E2D690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private readonly FKPPOCEMHDG JDIMNKODJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private IReadOnlyList<BCFHHBLPOPP<ODLLPEBONPI>>? GKONIAJDPJI;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public AAJEDNIHHDO? KMGHIJMKCHH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x1E31750", Offset = "0x1E30950", VA = "0x181E31750", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public DDPCAIJOGMI? BKPHFBPPKLB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x1E31320", Offset = "0x1E30520", VA = "0x181E31320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool DMFLPFAPBKI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x1E30DC0", Offset = "0x1E2FFC0", VA = "0x181E30DC0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool EDIGBIHDJAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x1E317D0", Offset = "0x1E309D0", VA = "0x181E317D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
	internal PCFDNJHGACP(FKPPOCEMHDG GDABCJDBLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x1E30CD0", Offset = "0x1E2FED0", VA = "0x181E30CD0", Slot = "7")]
	[AsyncStateMachine(typeof(GBBEDMKDLLK))]
	public Task<AAJEDNIHHDO> CHJGLNDJCKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x1E313A0", Offset = "0x1E305A0", VA = "0x181E313A0")]
	internal Dictionary<BCFHHBLPOPP<LOIIILALBLN>, Guid> MAINPNHMKNO(IEnumerable<EEMANFFCIOG> MCIBNHKPABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x1E310B0", Offset = "0x1E302B0", VA = "0x181E310B0")]
	public NFMFLMAOFMP<GKDONJEJPKD, LNFCDOMCNGI> LGEDDEOCLAD([In] GKDONJEJPKD DMCFNOOBNLG, IEnumerable<EEMANFFCIOG> CIFFMDOJHEO, int PJGCBPDNEPD)
	{
		return default(NFMFLMAOFMP<GKDONJEJPKD, LNFCDOMCNGI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x1E31710", Offset = "0x1E30910", VA = "0x181E31710")]
	internal static LHGJHELBJFO MIJEFLLONGK(ACFOCMBEAJF MKNFMNOIMDF, OLNAEHBJPHD CLKPBALPCKM)
	{
		return default(LHGJHELBJFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x1E30E20", Offset = "0x1E30020", VA = "0x181E30E20", Slot = "8")]
	private NFMFLMAOFMP<GKDONJEJPKD, LNFCDOMCNGI> FDBFNJDNHJM([In] GKDONJEJPKD DMCFNOOBNLG, IEnumerable<EEMANFFCIOG> CIFFMDOJHEO, int PJGCBPDNEPD)
	{
		return default(NFMFLMAOFMP<GKDONJEJPKD, LNFCDOMCNGI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x1E30E60", Offset = "0x1E30060", VA = "0x181E30E60")]
	[CompilerGenerated]
	internal static LHGJHELBJFO FFFNBLKNNGP(ACFOCMBEAJF EEJOCCIEEAL, OLNAEHBJPHD PLPCHKPJLEM)
	{
		return default(LHGJHELBJFO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public sealed class DDPCAIJOGMI : AAJEDNIHHDO
{
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	internal static class HJMBKDONJEB
	{
		[Cpp2IlInjected.Token(Token = "0x200009C")]
		[CompilerGenerated]
		private sealed class ICMGBEPMOBG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			public EAIIAMCBMDN state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public BMJGAPINNKH spawnIntoGraph;

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public ICMGBEPMOBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x1E2FAA0", Offset = "0x1E2ECA0", VA = "0x181E2FAA0")]
			internal bool NFECFAGOILD(LPOODDAHIAM n)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009D")]
		[CompilerGenerated]
		private sealed class FADGGEJFKAP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public int makerPenInteractionFilterKeyValue;

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public FADGGEJFKAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x1E2CF60", Offset = "0x1E2C160", VA = "0x181E2CF60")]
			internal void FOOCKEBJPPA(LPOODDAHIAM n)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x1E2DFC0", Offset = "0x1E2D1C0", VA = "0x181E2DFC0")]
		public static NFMFLMAOFMP<AAJEDNIHHDO.BBAMIGPPNJG, LNFCDOMCNGI> FPBPNKPIOLJ(DDPCAIJOGMI KNKOEEEKHDK, [In] AAJEDNIHHDO.MDNAONIJMFE JPEJCADBOCG)
		{
			return default(NFMFLMAOFMP<AAJEDNIHHDO.BBAMIGPPNJG, LNFCDOMCNGI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x1E2E910", Offset = "0x1E2DB10", VA = "0x181E2E910")]
		internal static NFMFLMAOFMP<(NCJFNNNNPPE, PLMEAOBKHGN), CEGADOEINOB> NPBFONOCJFM(DDPCAIJOGMI KNKOEEEKHDK, PLMEAOBKHGN NFLKIEDPLPG, bool FBNLBKJPACF, [In] BCFHHBLPOPP<LOIIILALBLN> PPIHACGMDGF, [In] int? KMJNLLDGJJG, [In] LHGJHELBJFO? IPKOFBAICFM, [In] LHGJHELBJFO? ANPMHKCOFOL)
		{
			return default(NFMFLMAOFMP<(NCJFNNNNPPE, PLMEAOBKHGN), CEGADOEINOB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x1E2F660", Offset = "0x1E2E860", VA = "0x181E2F660")]
		private static void PDDOPAEDCAP(bool FBNLBKJPACF, EEMANFFCIOG BDCBKPHIOMI, NCJFNNNNPPE HOGMGOPALOG, [In] BCFHHBLPOPP<LOIIILALBLN> PPIHACGMDGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x1E2E500", Offset = "0x1E2D700", VA = "0x181E2E500")]
		public static void JJOFMFOHEMB(NIPPBJMNOKA CMBNDMMHBDG, [In] AAJEDNIHHDO.NKAHHNFDHEA ABBLKNPMDJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x1E2DED0", Offset = "0x1E2D0D0", VA = "0x181E2DED0")]
		[CompilerGenerated]
		internal static bool DHOMOIGDDJG(EAIIAMCBMDN GEADPDMLKON, BMJGAPINNKH DOMBMBPAGEP, LPOODDAHIAM FAGFDNMFNMC)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private readonly FKPPOCEMHDG JDIMNKODJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private readonly BDIHEFKILKN AAKDOEOCILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private readonly DKFOHDAGDJD DFIBBBLOPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private readonly MGEIOIGGGPF IOPNMKOJBNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private readonly PCFDNJHGACP HNHCACKIMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private Dictionary<BCFHHBLPOPP<FKGCAMGPCBC>, NKPBMKEEPNC> MEHAKBAPJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	[CompilerGenerated]
	private Action<BCFHHBLPOPP<FKGCAMGPCBC>>? DGDLDGJEMAP;

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C750", Offset = "0x1E2B950", VA = "0x181E2C750")]
	public DDPCAIJOGMI(FKPPOCEMHDG GDABCJDBLDL, BDIHEFKILKN LLPNCFFFKDE, DKFOHDAGDJD KNEEKPGPNMF, PCFDNJHGACP LPLKMECEEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B7D0", Offset = "0x1E2A9D0", VA = "0x181E2B7D0", Slot = "4")]
	public bool LKCKPFLEGOH(EIPPGFCFCGI<LOIIILALBLN> NMEFCALOOLI, EIPPGFCFCGI<PAOCCIMMJDB> CKFEAOMNMAL, EIPPGFCFCGI<KJNHCLAFOIE> GCDCBLIMMCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B050", Offset = "0x1E2A250", VA = "0x181E2B050")]
	public NKPBMKEEPNC? IHGABDKJOJE([In] BCFHHBLPOPP<FKGCAMGPCBC> EPGOCEDJKAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A9A0", Offset = "0x1E29BA0", VA = "0x181E2A9A0")]
	private void FEFOCJFLFEA(BCFHHBLPOPP<FKGCAMGPCBC> EPGOCEDJKAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x1E2AF70", Offset = "0x1E2A170", VA = "0x181E2AF70")]
	public IEnumerable<NKPBMKEEPNC> HHOKGICPBEM([In] BCFHHBLPOPP<LOIIILALBLN> NMEFCALOOLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x1E2AE00", Offset = "0x1E2A000", VA = "0x181E2AE00")]
	private NKPBMKEEPNC? GBDBCJGHOOI([In] BCFHHBLPOPP<FKGCAMGPCBC> EPGOCEDJKAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B1C0", Offset = "0x1E2A3C0", VA = "0x181E2B1C0")]
	private NKPBMKEEPNC JBKHECBGBCI([In] BCFHHBLPOPP<FKGCAMGPCBC> EPGOCEDJKAG, OLNAEHBJPHD CLKPBALPCKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A630", Offset = "0x1E29830", VA = "0x181E2A630")]
	public OLNAEHBJPHD? CCEJLPCLLPO([In] BCFHHBLPOPP<FKGCAMGPCBC> EPGOCEDJKAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A7C0", Offset = "0x1E299C0", VA = "0x181E2A7C0")]
	public NNAAFNOPBFN? HAPPILJPFIA([In] BCFHHBLPOPP<LOIIILALBLN> NMEFCALOOLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x1E2BD90", Offset = "0x1E2AF90", VA = "0x181E2BD90")]
	private BMJGAPINNKH? MAECPCALBAC([In] BCFHHBLPOPP<LOIIILALBLN> NMEFCALOOLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A7C0", Offset = "0x1E299C0", VA = "0x181E2A7C0")]
	private NNAAFNOPBFN? NLMKKNMFHEO([In] BCFHHBLPOPP<LOIIILALBLN> NMEFCALOOLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x1E2BD20", Offset = "0x1E2AF20", VA = "0x181E2BD20", Slot = "10")]
	public BCFHHBLPOPP<LOIIILALBLN> LKJCJFPGLAP(EIPPGFCFCGI<LOIIILALBLN> NMEFCALOOLI)
	{
		return default(BCFHHBLPOPP<LOIIILALBLN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x1E2AEB0", Offset = "0x1E2A0B0", VA = "0x181E2AEB0")]
	public EIPPGFCFCGI<KJNHCLAFOIE> GKODILBEAKE(EIPPGFCFCGI<LOIIILALBLN> NMEFCALOOLI, EIPPGFCFCGI<FKGCAMGPCBC> EPGOCEDJKAG, int NDBNGFNEMFE)
	{
		return default(EIPPGFCFCGI<KJNHCLAFOIE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A6C0", Offset = "0x1E298C0", VA = "0x181E2A6C0")]
	public EIPPGFCFCGI<PAOCCIMMJDB> CLPODGAFGNL(EIPPGFCFCGI<LOIIILALBLN> NMEFCALOOLI, EIPPGFCFCGI<FKGCAMGPCBC> EPGOCEDJKAG, int CMJIKJFJHFK)
	{
		return default(EIPPGFCFCGI<PAOCCIMMJDB>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x1E29FD0", Offset = "0x1E291D0", VA = "0x181E29FD0", Slot = "8")]
	public IEnumerable<POEJGKDJFJL> BGPAKAPEDDG(OGKAGNDOFIJ HPNPIFCMKGD, bool ACMOIGKAGDB, bool GHKHLJFHOFO, bool HDJAALFOIGK, bool AGPOCHGOFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x1E2BE30", Offset = "0x1E2B030", VA = "0x181E2BE30", Slot = "9")]
	public POEJGKDJFJL MBAKOLPGKDI(OGKAGNDOFIJ HPNPIFCMKGD, KNGOLIJFIEN KDEPJCCHLMH, bool ACMOIGKAGDB, bool GHKHLJFHOFO, bool HDJAALFOIGK, bool AGPOCHGOFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x1E2AF40", Offset = "0x1E2A140", VA = "0x181E2AF40")]
	public NFMFLMAOFMP<AAJEDNIHHDO.BBAMIGPPNJG, LNFCDOMCNGI> GMLHJHAFGBD([In] AAJEDNIHHDO.MDNAONIJMFE JPEJCADBOCG)
	{
		return default(NFMFLMAOFMP<AAJEDNIHHDO.BBAMIGPPNJG, LNFCDOMCNGI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x1E29BE0", Offset = "0x1E28DE0", VA = "0x181E29BE0", Slot = "12")]
	public NFMFLMAOFMP<CDFHCNNKCKK, LNFCDOMCNGI> AIBJLAAIKED(BCFHHBLPOPP<LOIIILALBLN> NMEFCALOOLI, CDFHCNNKCKK NMIDIGDGLID, DKJMCLNAPDB NMKOGFMEEAA)
	{
		return default(NFMFLMAOFMP<CDFHCNNKCKK, LNFCDOMCNGI>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B5E0", Offset = "0x1E2A7E0", VA = "0x181E2B5E0", Slot = "13")]
	public FIFNKEMMNOA LJADKIJIFID(IEnumerable<EEMANFFCIOG> CIFFMDOJHEO)
	{
		return default(FIFNKEMMNOA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B2F0", Offset = "0x1E2A4F0", VA = "0x181E2B2F0", Slot = "14")]
	public FIFNKEMMNOA KFMMJMIPDAM()
	{
		return default(FIFNKEMMNOA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A0D0", Offset = "0x1E292D0", VA = "0x181E2A0D0")]
	private KKPCANAPFMD BKGBCOEKCHL(OPJOCFHFLLA FGFPNMCDCBP, EIPPGFCFCGI<LOIIILALBLN> GPAAICGCEIL, IEnumerable<BCFHHBLPOPP<LOIIILALBLN>> GAGJEDMNBKL, IEnumerable<BCFHHBLPOPP<FKGCAMGPCBC>> OPGEJLECNEF)
	{
		return default(KKPCANAPFMD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A280", Offset = "0x1E29480", VA = "0x181E2A280", Slot = "15")]
	public KKPCANAPFMD BKGBCOEKCHL(OPJOCFHFLLA FGFPNMCDCBP, EIPPGFCFCGI<LOIIILALBLN> GPAAICGCEIL, IEnumerable<BCFHHBLPOPP<FKGCAMGPCBC>> OPGEJLECNEF, IEnumerable<EEMANFFCIOG> CIFFMDOJHEO)
	{
		return default(KKPCANAPFMD);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x1E2AA80", Offset = "0x1E29C80", VA = "0x181E2AA80")]
	private static IEnumerable<BCFHHBLPOPP<LOIIILALBLN>> FOEELKEBEPA(IEnumerable<EEMANFFCIOG> CIFFMDOJHEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C2A0", Offset = "0x1E2B4A0", VA = "0x181E2C2A0")]
	private IEnumerable<BCFHHBLPOPP<FKGCAMGPCBC>> OJKLPDPMGMH(IEnumerable<EEMANFFCIOG> CIFFMDOJHEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C120", Offset = "0x1E2B320", VA = "0x181E2C120", Slot = "16")]
	public List<FJCMMHFDKKJ> NENMNFMECKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A8D0", Offset = "0x1E29AD0", VA = "0x181E2A8D0", Slot = "17")]
	public bool FBLODEMDDFJ(EIPPGFCFCGI<LOIIILALBLN> NMEFCALOOLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B290", Offset = "0x1E2A490", VA = "0x181E2B290")]
	internal void JGHNFENFANC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x1E2AA20", Offset = "0x1E29C20", VA = "0x181E2AA20")]
	internal Task FKBNHCBBCJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A7C0", Offset = "0x1E299C0", VA = "0x181E2A7C0", Slot = "5")]
	private NNAAFNOPBFN DEDNDHFAOOO([In] BCFHHBLPOPP<LOIIILALBLN> NMEFCALOOLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B410", Offset = "0x1E2A610", VA = "0x181E2B410", Slot = "6")]
	private NKPBMKEEPNC KIOLFLPKJGJ([In] BCFHHBLPOPP<FKGCAMGPCBC> EPGOCEDJKAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A7F0", Offset = "0x1E299F0", VA = "0x181E2A7F0", Slot = "7")]
	private IEnumerable<NKPBMKEEPNC> EAHJDKAHFIK([In] BCFHHBLPOPP<LOIIILALBLN> NMEFCALOOLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x1E2AF40", Offset = "0x1E2A140", VA = "0x181E2AF40", Slot = "11")]
	private NFMFLMAOFMP<AAJEDNIHHDO.BBAMIGPPNJG, LNFCDOMCNGI> HOCKNOGDPCK([In] AAJEDNIHHDO.MDNAONIJMFE JPEJCADBOCG)
	{
		return default(NFMFLMAOFMP<AAJEDNIHHDO.BBAMIGPPNJG, LNFCDOMCNGI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x1E2C1B0", Offset = "0x1E2B3B0", VA = "0x181E2C1B0")]
	[CompilerGenerated]
	private NKPBMKEEPNC NLCEIDMCMNE(OLNAEHBJPHD GJIHJJPNBNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B560", Offset = "0x1E2A760", VA = "0x181E2B560")]
	[CompilerGenerated]
	private NOAEOHLIDGK KLLOMCHEFJI(JDOJBAPBPOD GJIHJJPNBNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A5C0", Offset = "0x1E297C0", VA = "0x181E2A5C0")]
	[CompilerGenerated]
	private OLNAEHBJPHD BPKDIJAHGJG(BCFHHBLPOPP<FKGCAMGPCBC> GJIHJJPNBNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A750", Offset = "0x1E29950", VA = "0x181E2A750")]
	[CompilerGenerated]
	private BMJGAPINNKH DAEDCIBJCGD(BCFHHBLPOPP<LOIIILALBLN> GJIHJJPNBNJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public sealed class NOAEOHLIDGK : POEJGKDJFJL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private struct EEKEPBHHMGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<EIPPGFCFCGI<NAMMKHHGCFO>, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public NOAEOHLIDGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public BCFHHBLPOPP<LOIIILALBLN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public BCFHHBLPOPP<FKGCAMGPCBC> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public EIPPGFCFCGI<OFLCOGGIINH> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private TaskAwaiter<NFMFLMAOFMP<EIPPGFCFCGI<NAMMKHHGCFO>, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x1E2CC70", Offset = "0x1E2BE70", VA = "0x181E2CC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x1E2CEF0", Offset = "0x1E2C0F0", VA = "0x181E2CEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private struct BGFHNBKAEBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<EIPPGFCFCGI<POPDDCCDEEM>, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public NOAEOHLIDGK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public BCFHHBLPOPP<LOIIILALBLN> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public BCFHHBLPOPP<FKGCAMGPCBC> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public EIPPGFCFCGI<OFLCOGGIINH> portGroupId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private TaskAwaiter<NFMFLMAOFMP<EIPPGFCFCGI<POPDDCCDEEM>, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x1E292A0", Offset = "0x1E284A0", VA = "0x181E292A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x1E29520", Offset = "0x1E28720", VA = "0x181E29520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private readonly JDOJBAPBPOD JHNJFKNHAHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private readonly BDIHEFKILKN AAKDOEOCILC;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public TypeKey LGICJINNCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x821ED0", Offset = "0x8210D0", VA = "0x180821ED0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public string ABKFKEJLBDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x1E28030", Offset = "0x1E27230", VA = "0x181E28030", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public JDOJBAPBPOD HGFJNONLPMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x1E305A0", Offset = "0x1E2F7A0", VA = "0x181E305A0")]
	public NOAEOHLIDGK(JDOJBAPBPOD NNMHLHKFJDL, BDIHEFKILKN LLPNCFFFKDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x1E302C0", Offset = "0x1E2F4C0", VA = "0x181E302C0", Slot = "6")]
	[AsyncStateMachine(typeof(EEKEPBHHMGE))]
	public Task<NFMFLMAOFMP<EIPPGFCFCGI<NAMMKHHGCFO>, CEGADOEINOB>> DFFIJNOEBEG(BCFHHBLPOPP<LOIIILALBLN> NMEFCALOOLI, BCFHHBLPOPP<FKGCAMGPCBC> EPGOCEDJKAG, EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME, string IKEFBMMMAJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x1E30430", Offset = "0x1E2F630", VA = "0x181E30430", Slot = "7")]
	[AsyncStateMachine(typeof(BGFHNBKAEBC))]
	public Task<NFMFLMAOFMP<EIPPGFCFCGI<POPDDCCDEEM>, CEGADOEINOB>> JCJKKHAGEOP(BCFHHBLPOPP<LOIIILALBLN> NMEFCALOOLI, BCFHHBLPOPP<FKGCAMGPCBC> EPGOCEDJKAG, EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME, string IKEFBMMMAJB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public sealed class ANFPGPBPMKK : CHBLAFOJNPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private readonly JDOJBAPBPOD PIPHLMIAIEA;

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private static readonly HashSet<JDOJBAPBPOD> CEJACDGHLCD;

	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private static readonly HashSet<JDOJBAPBPOD> JOEACHDPLDC;

	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	private static readonly HashSet<JDOJBAPBPOD> BHNLAGFFBIE;

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public TypeKey OGJDOBGGLGA
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x1E29130", Offset = "0x1E28330", VA = "0x181E29130", Slot = "6")]
		get
		{
			return default(TypeKey);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool LKDHMCKJHGA
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x1E29120", Offset = "0x1E28320", VA = "0x181E29120", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool DHIIEEMPJHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x1E29180", Offset = "0x1E28380", VA = "0x181E29180", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool BIBFJFDAGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x1E290A0", Offset = "0x1E282A0", VA = "0x181E290A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x1E27DC0", Offset = "0x1E26FC0", VA = "0x181E27DC0")]
	public bool LHGFEOGGFEC(string NICEPFIEJED, [Out] FLJLIOLDHBA GOPFDLHNLGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
	public ANFPGPBPMKK(JDOJBAPBPOD PFGBPGKFOLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x1E27C30", Offset = "0x1E26E30", VA = "0x181E27C30")]
	internal static TypeKey IFMGGKEPFGJ(JDOJBAPBPOD FLPJMDMACMC)
	{
		return default(TypeKey);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x1E28030", Offset = "0x1E27230", VA = "0x181E28030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public readonly struct FNPMBLADHBI : MJAHKGBLMAK.MHBHJFCKOBB<DIGPMMNJEIB, LKEAICJEMFK>
{
	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x1E2D350", Offset = "0x1E2C550", VA = "0x181E2D350", Slot = "4")]
	public int MBOBLMGHEFL(LKEAICJEMFK PMBMOONGPPJ, DIGPMMNJEIB GKGLDBAJJCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x1E2D330", Offset = "0x1E2C530", VA = "0x181E2D330", Slot = "5")]
	public DIGPMMNJEIB HABELLFHOAJ(LKEAICJEMFK PMBMOONGPPJ, DIGPMMNJEIB GKGLDBAJJCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x1E2D370", Offset = "0x1E2C570", VA = "0x181E2D370", Slot = "6")]
	public DIGPMMNJEIB MGOPJPOKCKN(LKEAICJEMFK PMBMOONGPPJ, DIGPMMNJEIB GKGLDBAJJCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x1E2D290", Offset = "0x1E2C490", VA = "0x181E2D290", Slot = "7")]
	public IReadOnlyList<DIGPMMNJEIB> AEKPHNFOEFK(LKEAICJEMFK PMBMOONGPPJ, DIGPMMNJEIB GKGLDBAJJCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x1E2D340", Offset = "0x1E2C540", VA = "0x181E2D340", Slot = "8")]
	public DIGPMMNJEIB[] JEGLBKGAIOC(LKEAICJEMFK PMBMOONGPPJ, DIGPMMNJEIB GKGLDBAJJCH, int FPNPAFHHCPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x1E2D2B0", Offset = "0x1E2C4B0", VA = "0x181E2D2B0", Slot = "9")]
	public bool AKFPCGDEGGA(LKEAICJEMFK PMBMOONGPPJ, DIGPMMNJEIB GKGLDBAJJCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x1E2D2D0", Offset = "0x1E2C4D0", VA = "0x181E2D2D0", Slot = "10")]
	public bool CENFPOBKGOP(LKEAICJEMFK PMBMOONGPPJ, DIGPMMNJEIB GKGLDBAJJCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x1E2D3C0", Offset = "0x1E2C5C0", VA = "0x181E2D3C0", Slot = "11")]
	public bool OMIIEFMFAPB(LKEAICJEMFK PMBMOONGPPJ, DIGPMMNJEIB GKGLDBAJJCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x1E2D2F0", Offset = "0x1E2C4F0", VA = "0x181E2D2F0", Slot = "12")]
	public bool GGABGOCJLBE(LKEAICJEMFK PMBMOONGPPJ, DIGPMMNJEIB GKGLDBAJJCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x1E2D3A0", Offset = "0x1E2C5A0", VA = "0x181E2D3A0", Slot = "13")]
	public bool NEOMNMJEJBK(LKEAICJEMFK HAFOMDBJDBF, DIGPMMNJEIB GKGLDBAJJCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x1E2D310", Offset = "0x1E2C510", VA = "0x181E2D310", Slot = "14")]
	public bool GJDLHAMGNML(LKEAICJEMFK PMBMOONGPPJ, DIGPMMNJEIB GKGLDBAJJCH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public abstract class FBPIMIBJLHA : BJDHOEFBLAH
{
	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public GJMJHGCJNDO.BLELGHKLNIO EJHADOLKOFN
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x1E2CFD0", Offset = "0x1E2C1D0", VA = "0x181E2CFD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public abstract PLJJCEDCEKJ.DPLJPOABHEK CMDGPBGMKCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public abstract FKPPOCEMHDG.ABNLECENPCO PLBNNGGLCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public abstract IIEKEJODDAJ.CMEGGFNEODE DFFELDJPCDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public MDFHMEIIDDC.HIKMGFAPFPD<GBPKHNJBGED, DIGPMMNJEIB, FKPPOCEMHDG> CGLADMNNHKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x1E2CF80", Offset = "0x1E2C180", VA = "0x181E2CF80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public abstract OHAIMHJPJEG OJBJAGKOEAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public abstract DHBKLDMOGOK MKPPLKKKDOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public abstract NOGOJOLKHJB LGNMKEDKEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public abstract CFHGLCGHIKK AAHJHLHLDKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public abstract OMMKBCOOJFE BAPDMDOFBJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	protected FBPIMIBJLHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
public sealed class PHADHLDJCLN : GBBGPCPBBLC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private struct NCMDKFGEDHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<object, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public PHADHLDJCLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public DIGPMMNJEIB action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private TaskAwaiter<NFMFLMAOFMP<object, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x1E30040", Offset = "0x1E2F240", VA = "0x181E30040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x1E30250", Offset = "0x1E2F450", VA = "0x181E30250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct GCHHKFFCCBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public AsyncTaskMethodBuilder<NFMFLMAOFMP<EDLPBBJOGBF, CEGADOEINOB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public PHADHLDJCLN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public IReadOnlyList<DIGPMMNJEIB> actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private TaskAwaiter<NFMFLMAOFMP<object, CEGADOEINOB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x1E2D700", Offset = "0x1E2C900", VA = "0x181E2D700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x1E2DA80", Offset = "0x1E2CC80", VA = "0x181E2DA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	private readonly DKEELGMMLPH PACHPCGKFPG;

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
	public PHADHLDJCLN(DKEELGMMLPH NLAJPGFICGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x1E31890", Offset = "0x1E30A90", VA = "0x181E31890")]
	[AsyncStateMachine(typeof(NCMDKFGEDHG))]
	private Task<NFMFLMAOFMP<object, CEGADOEINOB>> OAJPLADHDCP(DIGPMMNJEIB GKGLDBAJJCH, bool OCHKIPLOHCF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x1E319C0", Offset = "0x1E30BC0", VA = "0x181E319C0", Slot = "4")]
	[AsyncStateMachine(typeof(GCHHKFFCCBM))]
	public Task<NFMFLMAOFMP<EDLPBBJOGBF, CEGADOEINOB>> PHHMFOBNIMN(IReadOnlyList<DIGPMMNJEIB> KHONCCLLIFA, bool OCHKIPLOHCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public struct GNPCOMEKKME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	internal JNEIBOCCAPI<BOKCGLPLFFB, DIGPMMNJEIB, ONOIBBJIDKG> PIPHLMIAIEA;

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x1E23E10", Offset = "0x1E23010", VA = "0x181E23E10")]
	private GNPCOMEKKME([In] JNEIBOCCAPI<BOKCGLPLFFB, DIGPMMNJEIB, ONOIBBJIDKG> AEAMJINFJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x1E2DAF0", Offset = "0x1E2CCF0", VA = "0x181E2DAF0")]
	public static GNPCOMEKKME MIJABIECKKD()
	{
		return default(GNPCOMEKKME);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public static class CGJINOGKKHD
{
	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x81F220", Offset = "0x81E420", VA = "0x18081F220")]
	public static JNEIBOCCAPI<BOKCGLPLFFB, DIGPMMNJEIB, ONOIBBJIDKG> MAFFOJBPLII(this GNPCOMEKKME KNKOEEEKHDK)
	{
		return default(JNEIBOCCAPI<BOKCGLPLFFB, DIGPMMNJEIB, ONOIBBJIDKG>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public struct ONOIBBJIDKG : INAMNCOIDAJ.GEJCBPMJGGA<BOKCGLPLFFB, DIGPMMNJEIB>
{
	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x1E30AF0", Offset = "0x1E2FCF0", VA = "0x181E30AF0", Slot = "5")]
	public DIGPMMNJEIB JDLJLJNIBFE(BOKCGLPLFFB[] FAJJFEHMODK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x1408570", Offset = "0x1407770", VA = "0x181408570")]
	public int CJHINBJIINH([In] BOKCGLPLFFB LEMLAGDKCNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x1408570", Offset = "0x1407770", VA = "0x181408570", Slot = "4")]
	private int GPMOJGJKMLL([In] BOKCGLPLFFB LKEDIBHLMPC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public struct PEBGGPPIEBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	internal NFLBDBNOJJB<AOEFCMEHINK, DIGPMMNJEIB, OLDINAOBLKC> PIPHLMIAIEA;

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x1E23E10", Offset = "0x1E23010", VA = "0x181E23E10")]
	private PEBGGPPIEBH([In] NFLBDBNOJJB<AOEFCMEHINK, DIGPMMNJEIB, OLDINAOBLKC> OPNOPCCGDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x1E31830", Offset = "0x1E30A30", VA = "0x181E31830")]
	public static PEBGGPPIEBH MIJABIECKKD()
	{
		return default(PEBGGPPIEBH);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public static class DHDJDGDJDMF
{
	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x81F220", Offset = "0x81E420", VA = "0x18081F220")]
	public static NFLBDBNOJJB<AOEFCMEHINK, DIGPMMNJEIB, OLDINAOBLKC> MAFFOJBPLII(this PEBGGPPIEBH KNKOEEEKHDK)
	{
		return default(NFLBDBNOJJB<AOEFCMEHINK, DIGPMMNJEIB, OLDINAOBLKC>);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public struct OLDINAOBLKC : PJJPJAOJNCG.NFLLPKCHPKM<AOEFCMEHINK, DIGPMMNJEIB>
{
	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x1408570", Offset = "0x1407770", VA = "0x181408570")]
	public int PBLFINKNFBB([In] AOEFCMEHINK LEMLAGDKCNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x1E30910", Offset = "0x1E2FB10", VA = "0x181E30910", Slot = "5")]
	public DIGPMMNJEIB NGKPHMMOPKI(AOEFCMEHINK[] AGCJACPAOEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x1408570", Offset = "0x1407770", VA = "0x181408570", Slot = "4")]
	private int KPCLMONLABM([In] AOEFCMEHINK LEMLAGDKCNH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public interface OHAIMHJPJEG
{
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DDGBLHJGCKF([In] NFMFLMAOFMP<LKEAICJEMFK, LNFCDOMCNGI> HCIDHCBMOPD);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public static class LMOJLPPEHOI
{
	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x298BF20", Offset = "0x298B120", VA = "0x18298BF20")]
	public static bool DDGBLHJGCKF<TOk, TErr>(this OHAIMHJPJEG KNKOEEEKHDK, [In] NFMFLMAOFMP<TOk, TErr> HCIDHCBMOPD) where TOk : notnull where TErr : notnull, LNFCDOMCNGI
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public interface DHBKLDMOGOK
{
	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	FAPKBCOJCEP KBHFMKBKDAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public interface NOGOJOLKHJB
{
	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ENNHINMHKAK GNDGODCCLBN(int INNOPDFFMFO);
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public interface OGDOLMJDNOJ
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	string ECHFBJHACCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public interface IFLHBMIHCDG
{
	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MHGNPLPKJFO? MAMLALJLOLI(EIPPGFCFCGI<OFLCOGGIINH> PFAKHMIDMME);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public interface EHPAACKGMOJ
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	string ECHFBJHACCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public interface MHGNPLPKJFO
{
	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	string ECHFBJHACCL
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EHPAACKGMOJ? FFDCJOKEMHE(EIPPGFCFCGI<NAMMKHHGCFO> PMANMCEJNMD);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OGDOLMJDNOJ? DEONDJCJCDJ(EIPPGFCFCGI<POPDDCCDEEM> NEOBBBKDHJA);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public interface CFHGLCGHIKK
{
	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> MBPNKEOBIMF(string NICEPFIEJED, string KAEEGPAIBEC);
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public interface OMMKBCOOJFE
{
	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IFLHBMIHCDG? MJEBLFFECFO([In] BCFHHBLPOPP<ODLLPEBONPI> EAICCDPOEIB);
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public sealed class ADPBOLMEOPJ
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private struct PHOMMMHKDMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public int JPDBMMOIFEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public DJDLMEOOMEF? EAMJHLCBPKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public DJDLMEOOMEF? MBFOAFHNOMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public readonly List<DIGPMMNJEIB> CLLPLMICAPF;

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x1E31BB0", Offset = "0x1E30DB0", VA = "0x181E31BB0")]
		private PHOMMMHKDMJ(int HMFNCGHECPG, DJDLMEOOMEF? EOPEGJLNFJB, DJDLMEOOMEF? GMHJHPKOMMA, List<DIGPMMNJEIB> KHONCCLLIFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x1E31AF0", Offset = "0x1E30CF0", VA = "0x181E31AF0")]
		public static PHOMMMHKDMJ MIJABIECKKD()
		{
			return default(PHOMMMHKDMJ);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	private readonly MAPHDHMBCMB<PHOMMMHKDMJ> LOCDHKIKBNN;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public static ADPBOLMEOPJ KMGHIJMKCHH
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x1E27A30", Offset = "0x1E26C30", VA = "0x181E27A30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public bool JDFBIDHNJJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x827680", Offset = "0x826880", VA = "0x180827680")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x88CAB0", Offset = "0x88BCB0", VA = "0x18088CAB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x1E27340", Offset = "0x1E26540", VA = "0x181E27340")]
	public void BOMOBPICFPD(EAIIAMCBMDN GMHJHPKOMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x1E27740", Offset = "0x1E26940", VA = "0x181E27740")]
	public void LPLGIHHHANF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x1E27400", Offset = "0x1E26600", VA = "0x181E27400")]
	private static string? IOMLLNMLDKE([In] PHOMMMHKDMJ ONICCOLKMCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x1E27B80", Offset = "0x1E26D80", VA = "0x181E27B80")]
	public ADPBOLMEOPJ()
	{
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
