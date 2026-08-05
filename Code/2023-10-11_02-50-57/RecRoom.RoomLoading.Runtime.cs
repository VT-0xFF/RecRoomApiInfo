using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using Google.Protobuf;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecNet;
using RecRoom.NoEngine.Common;
using RecRoom.Persistence;
using UnityEngine;
using UnityEngine.SceneManagement;
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
		[Cpp2IlInjected.Address(RVA = "0x78C450", Offset = "0x78B250", VA = "0x18078C450")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x62614A0", Offset = "0x62602A0", VA = "0x1862614A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x78C910", Offset = "0x78B710", VA = "0x18078C910")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x78C950", Offset = "0x78B750", VA = "0x18078C950")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CCCHMHCNIFC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6251640", Offset = "0x6250440", VA = "0x186251640")]
	public CCCHMHCNIFC(string JIGBFCEILIK, Exception OJPBGLOHKFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class BJLIBNPDLBD : BFIJAFHMCFJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct ENPHALMLFAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public AsyncTaskMethodBuilder<IReadOnlyList<GBFOHGAHICD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private TaskAwaiter<NBFPLENANBH<GBFOHGAHICD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6259270", Offset = "0x6258070", VA = "0x186259270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x62594B0", Offset = "0x62582B0", VA = "0x1862594B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private struct IPIBEONFEBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public AsyncTaskMethodBuilder<IReadOnlyList<CPIHDJGEJDI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TaskAwaiter<List<CPIHDJGEJDI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x625CE40", Offset = "0x625BC40", VA = "0x18625CE40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x625D050", Offset = "0x625BE50", VA = "0x18625D050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	[UnityEngine.Scripting.Preserve]
	public BJLIBNPDLBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6250070", Offset = "0x624EE70", VA = "0x186250070", Slot = "4")]
	[AsyncStateMachine(typeof(ENPHALMLFAN))]
	public Task<IReadOnlyList<GBFOHGAHICD>> ELDFFHLEDAI(long NGLNDFKLBFL, long PIJEGGFFPOI, [Optional] CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6250190", Offset = "0x624EF90", VA = "0x186250190", Slot = "5")]
	[AsyncStateMachine(typeof(IPIBEONFEBA))]
	public Task<IReadOnlyList<CPIHDJGEJDI>> JHAJFGGCEBM(IReadOnlyList<int> BFIBJCGLOGI, [Optional] CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NKGLJFKNJKJ : IEquatable<NKGLJFKNJKJ>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int ICPFMJPCKIC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	CPIHDJGEJDI CJKDHFJDJGD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime PMIAHOCKJKL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	FDJEILEBGBK? GNHGHAOLNOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	MCAHPODDANJ? AJLPFCAFDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	BDHMCKNABBG OGNJEHHBKAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<HNLJAOBELNP> KMGCCHJJFCP();
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum BDHMCKNABBG
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BFIJAFHMCFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<GBFOHGAHICD>> ELDFFHLEDAI(long NGLNDFKLBFL, long PIJEGGFFPOI, [Optional] CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<CPIHDJGEJDI>> JHAJFGGCEBM(IReadOnlyList<int> BFIBJCGLOGI, [Optional] CancellationToken BIBHFGFDEGJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ONHNDFPEPKF
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class EPKMKEODENO : NKGLJFKNJKJ, IEquatable<NKGLJFKNJKJ>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct DCACJCNBEEH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AsyncTaskMethodBuilder<HNLJAOBELNP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public EPKMKEODENO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private EDPCKDKBIGC <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private TaskAwaiter<OABHNCNHAAJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private TaskAwaiter<HNLJAOBELNP> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6252E90", Offset = "0x6251C90", VA = "0x186252E90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6253330", Offset = "0x6252130", VA = "0x186253330", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly GBFOHGAHICD FDENAPHPDGG;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int ICPFMJPCKIC
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7658E0", Offset = "0x7646E0", VA = "0x1807658E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public CPIHDJGEJDI CJKDHFJDJGD
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x761660", Offset = "0x760460", VA = "0x180761660", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime JBOFMBPOJPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8D45D0", Offset = "0x8D33D0", VA = "0x1808D45D0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public FDJEILEBGBK? GNHGHAOLNOH
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x17A7E00", Offset = "0x17A6C00", VA = "0x1817A7E00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public MCAHPODDANJ? AJLPFCAFDCI
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x1F542C0", Offset = "0x1F530C0", VA = "0x181F542C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public BDHMCKNABBG OGNJEHHBKAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7DEC30", Offset = "0x7DDA30", VA = "0x1807DEC30", Slot = "10")]
			get
			{
				return default(BDHMCKNABBG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x62596D0", Offset = "0x62584D0", VA = "0x1862596D0", Slot = "9")]
		[AsyncStateMachine(typeof(DCACJCNBEEH))]
		public Task<HNLJAOBELNP> KMGCCHJJFCP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6259810", Offset = "0x6258610", VA = "0x186259810")]
		public EPKMKEODENO(int FPGNJDPMEIL, CPIHDJGEJDI FFIKBEDANGH, GBFOHGAHICD FDENAPHPDGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x62595C0", Offset = "0x62583C0", VA = "0x1862595C0", Slot = "11")]
		public bool Equals(NKGLJFKNJKJ MFMJJEFODHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6259520", Offset = "0x6258320", VA = "0x186259520", Slot = "0")]
		public override bool Equals(object HBDENJGMDDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x62597D0", Offset = "0x62585D0", VA = "0x1862597D0")]
		private bool NBKAAFEGGJJ(EPKMKEODENO MFMJJEFODHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6259650", Offset = "0x6258450", VA = "0x186259650", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class GMAFKFJLCKD : NKGLJFKNJKJ, IEquatable<NKGLJFKNJKJ>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct AKMPOLCDJEL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder<HNLJAOBELNP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public GMAFKFJLCKD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<HNLJAOBELNP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x624A660", Offset = "0x6249460", VA = "0x18624A660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x624A890", Offset = "0x6249690", VA = "0x18624A890", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly JBIBDPPGHNE DEMPLOOBMIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly FDJEILEBGBK EDIAFNGCDOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly MCAHPODDANJ JABGMGMIIIA;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int ICPFMJPCKIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x625AE30", Offset = "0x6259C30", VA = "0x18625AE30", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public CPIHDJGEJDI CJKDHFJDJGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x625A990", Offset = "0x6259790", VA = "0x18625A990", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime JBOFMBPOJPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x625AD80", Offset = "0x6259B80", VA = "0x18625AD80", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public FDJEILEBGBK? GNHGHAOLNOH
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x625ABF0", Offset = "0x62599F0", VA = "0x18625ABF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public MCAHPODDANJ? AJLPFCAFDCI
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x625AC40", Offset = "0x6259A40", VA = "0x18625AC40", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public BDHMCKNABBG OGNJEHHBKAK
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7D0CD0", Offset = "0x7CFAD0", VA = "0x1807D0CD0", Slot = "10")]
			get
			{
				return default(BDHMCKNABBG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xD34E30", Offset = "0xD33C30", VA = "0x180D34E30")]
		public GMAFKFJLCKD(JBIBDPPGHNE KEFDGELDJDB, FDJEILEBGBK MDMNDMNBCCO, MCAHPODDANJ NNMDCICGFHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x625AC90", Offset = "0x6259A90", VA = "0x18625AC90", Slot = "9")]
		[AsyncStateMachine(typeof(AKMPOLCDJEL))]
		public Task<HNLJAOBELNP> KMGCCHJJFCP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x625AAD0", Offset = "0x62598D0", VA = "0x18625AAD0", Slot = "11")]
		public bool Equals(NKGLJFKNJKJ MFMJJEFODHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x625AA20", Offset = "0x6259820", VA = "0x18625AA20", Slot = "0")]
		public override bool Equals(object HBDENJGMDDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x625ADD0", Offset = "0x6259BD0", VA = "0x18625ADD0")]
		private bool NBKAAFEGGJJ(GMAFKFJLCKD MFMJJEFODHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x625AB70", Offset = "0x6259970", VA = "0x18625AB70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class FDHLAHONHBJ : NKGLJFKNJKJ, IEquatable<NKGLJFKNJKJ>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct HMKHDEGLKCD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<HNLJAOBELNP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter<HNLJAOBELNP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x625BA10", Offset = "0x625A810", VA = "0x18625BA10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x625BC50", Offset = "0x625AA50", VA = "0x18625BC50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CPIHDJGEJDI LBDEAJADAIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly FDJEILEBGBK EDIAFNGCDOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly MCAHPODDANJ JABGMGMIIIA;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int ICPFMJPCKIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6259CB0", Offset = "0x6258AB0", VA = "0x186259CB0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public CPIHDJGEJDI CJKDHFJDJGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime JBOFMBPOJPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x762EF0", Offset = "0x761CF0", VA = "0x180762EF0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public FDJEILEBGBK? GNHGHAOLNOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6259A10", Offset = "0x6258810", VA = "0x186259A10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public MCAHPODDANJ? AJLPFCAFDCI
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6259A60", Offset = "0x6258860", VA = "0x186259A60", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public BDHMCKNABBG OGNJEHHBKAK
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x762EF0", Offset = "0x761CF0", VA = "0x180762EF0", Slot = "10")]
			get
			{
				return default(BDHMCKNABBG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xD34E30", Offset = "0xD33C30", VA = "0x180D34E30")]
		public FDHLAHONHBJ(CPIHDJGEJDI FFIKBEDANGH, FDJEILEBGBK MDMNDMNBCCO, MCAHPODDANJ NNMDCICGFHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6259AB0", Offset = "0x62588B0", VA = "0x186259AB0", Slot = "9")]
		[AsyncStateMachine(typeof(HMKHDEGLKCD))]
		public Task<HNLJAOBELNP> KMGCCHJJFCP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x62598F0", Offset = "0x62586F0", VA = "0x1862598F0", Slot = "11")]
		public bool Equals(NKGLJFKNJKJ MFMJJEFODHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6259870", Offset = "0x6258670", VA = "0x186259870", Slot = "0")]
		public override bool Equals(object HBDENJGMDDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6259960", Offset = "0x6258760", VA = "0x186259960", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6259B80", Offset = "0x6258980", VA = "0x186259B80")]
		private bool NBKAAFEGGJJ(FDHLAHONHBJ MFMJJEFODHB)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct EBINGAEAKHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<IList<NKGLJFKNJKJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public bool forceRefreshSaveHistoryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public ONHNDFPEPKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private IReadOnlyList<GBFOHGAHICD> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private TaskAwaiter<IReadOnlyList<GBFOHGAHICD>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter<IReadOnlyList<(int accountId, CPIHDJGEJDI account, GBFOHGAHICD roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6255E40", Offset = "0x6254C40", VA = "0x186255E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6256C20", Offset = "0x6255A20", VA = "0x186256C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct BOJCEMAPEDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, CPIHDJGEJDI account, GBFOHGAHICD roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IReadOnlyList<GBFOHGAHICD> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public ONHNDFPEPKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<IReadOnlyList<CPIHDJGEJDI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x62502A0", Offset = "0x624F0A0", VA = "0x1862502A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6250CE0", Offset = "0x624FAE0", VA = "0x186250CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly CAAKLDCIGMG DDFBCMBMEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly BFIJAFHMCFJ EMFJLEKKAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly JFLIKILMHEH KKALKJKEGBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly PFFBOKGKIDF<(long, long), IReadOnlyList<GBFOHGAHICD>> HNHLDOGJNEH;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x62621E0", Offset = "0x6260FE0", VA = "0x1862621E0")]
	[UnityEngine.Scripting.Preserve]
	public ONHNDFPEPKF([NMBHAKGIBHG(null)] BFIJAFHMCFJ CNIDHABAAFM, [NMBHAKGIBHG(null)] JFLIKILMHEH MNKLEHAJMIE, [NMBHAKGIBHG(null)] CAAKLDCIGMG NEIOCHHBDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6262090", Offset = "0x6260E90", VA = "0x186262090")]
	[AsyncStateMachine(typeof(EBINGAEAKHG))]
	public Task<IList<NKGLJFKNJKJ>> GOONJNILJDI(long NGLNDFKLBFL, long OBPCIAFLNJK, bool EAMIOAHCFNC = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6261DE0", Offset = "0x6260BE0", VA = "0x186261DE0")]
	private bool AIMJNJJGLBJ(DateTime? GACEBIHOFDO, long NGLNDFKLBFL, long OBPCIAFLNJK, [Out] JBIBDPPGHNE OEAGFPFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6261F80", Offset = "0x6260D80", VA = "0x186261F80")]
	[AsyncStateMachine(typeof(BOJCEMAPEDL))]
	private Task<IReadOnlyList<(int, CPIHDJGEJDI, GBFOHGAHICD)>> EPBOHLLDKHH(IReadOnlyList<GBFOHGAHICD> LCGIGDGBPDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface JFLIKILMHEH
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<JBIBDPPGHNE> BDNIAGMKNGP;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HMIDDKFCKJF(long NGLNDFKLBFL, long OBPCIAFLNJK, CCPPDIFNJBM OBDJDLGBOHF, KCBBPOFPKPE CCEKALLPEJN);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DHMAACHMBAJ(long NGLNDFKLBFL, long OBPCIAFLNJK, [Out] JBIBDPPGHNE OEAGFPFKGKF);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ONFMAACNEMG(long NGLNDFKLBFL, long OBPCIAFLNJK, KCBBPOFPKPE CCEKALLPEJN, [Out] JBIBDPPGHNE OEAGFPFKGKF);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FIBPMHLMFAC(long NGLNDFKLBFL, long OBPCIAFLNJK);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal interface PANHNKJODMC : GGAELEIAKGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool CEFOHAKBBIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task MAKKHJFDBFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CEPGKPCGMJD(Task CKLPGPGBFPF, string MGICKGFIBHP);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
internal interface GHCLEKEDAHM : GGAELEIAKGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HNLJAOBELNP> OIJGANPFEML(JBIBDPPGHNE OEAGFPFKGKF);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task HICKKPIJKJB(CancellationToken BIBHFGFDEGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
internal interface DOHKLGBDCAM : GGAELEIAKGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	AKMHPCJDBNK JDNPDEIGCOI
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PAHEFJPAHOP();

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BBAOEGKHIOA();
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface GGAELEIAKGO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOCIGOIJKNJ(DNDAMAFFFKG HJDDMPFEAJK);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface NHJOPKHKEBD
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan GJMHAGADLNN
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan CJAOHJEMOHB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan MPIHBLGLHLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan ONDJKGIBOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool PMACCKEKNDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool PGHPPBHFPGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool PDDCIAPOHBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int EICLHHCBNHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool MMKGGMMOIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum EBODJOKILPP
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum EDHHCKCKEHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	InitialRoomLoad,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	AutoSave,
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	SaveToDisk,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	SaveToRecNet,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	RestoreAutoSave,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public struct MDPBNPLCIHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly long LOMBOBCNNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly long PIJEGGFFPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly EBODJOKILPP PEMNIEMPPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[CanBeNull]
	public readonly Exception PKHCIODBICI;

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x625E830", Offset = "0x625D630", VA = "0x18625E830")]
	public MDPBNPLCIHC(long LOMBOBCNNPE, long PIJEGGFFPOI, EBODJOKILPP PEMNIEMPPLO, [CanBeNull] Exception PKHCIODBICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x625E7E0", Offset = "0x625D5E0", VA = "0x18625E7E0")]
	public static MDPBNPLCIHC ELGLCHHLLKA(JCOMCEDKFBJ EHCHOJJHPEJ, EBODJOKILPP PEMNIEMPPLO, [Optional] Exception PKHCIODBICI)
	{
		return default(MDPBNPLCIHC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public delegate void CDDMAIAAIPE(MDPBNPLCIHC HAPHPPAHEDI);
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal interface DMJIIPIJGLE : GGAELEIAKGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action MNGDHEFNEAN;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event CDDMAIAAIPE HDKMCPCNDKL;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event CDDMAIAAIPE BCOODKMOMAB;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event CDDMAIAAIPE KFJMDDEEABE;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<EDHHCKCKEHJ, bool> AHEGLMGDJBI;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ECAPMENHGGJ();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NLBKGHKINBJ(MDPBNPLCIHC HAPHPPAHEDI);

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void FCLENOGOBGE(MDPBNPLCIHC HAPHPPAHEDI);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void JIHKNIGENHE(MDPBNPLCIHC HAPHPPAHEDI);

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JKGDMJKAFFE(EDHHCKCKEHJ LANJILPEPCC, bool BPGAINDNDCK);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
internal interface OPOBPIDEDPH : GGAELEIAKGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task JEEAALPEJKM();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HEDEDKGKALH();
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal interface OABGDCJKBCI : GGAELEIAKGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	TaskStatus LIMLOGJKAKB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BHKFPJFNECD(JCOMCEDKFBJ NMOCHEEIGMK, JJCNDJJFHEJ OLCEOMOCFJP, CancellationToken MGHJMBBEFKK);
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal static class JOHMBPLEDGH
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x625D670", Offset = "0x625C470", VA = "0x18625D670")]
	public static bool EENFNNPBBKO(this OABGDCJKBCI LEBLGKEKICC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public delegate Task AECEECPPOFG(EAHIPFGMIPN MFKPIJLKLHA, CancellationToken PFKLELGAJPH);
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface BCMCIFBKNFK : GGAELEIAKGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FHCGKCMMJJM(AECEECPPOFG LNAMNGLJHCL);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal interface DNDAMAFFFKG : EDPCKDKBIGC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	CancellationToken HKJDBPPEFMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	OILPPPCALMB PEFHMNHDLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	HEJEKJPNGFL DHHNJONBIAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	DOPLIFPLHHG FNLIBEJLBDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	CJIBMGCPPCM FHMIKKFADBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	LKGIKKGGCBC PAFFJGKLBKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	BFNLIFGMJBO DPDDMPAJNNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	EEEIAIDPIAO FOKKNDHNPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	FNIHCJMFGHB DBAGHIJEKAB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	PANHNKJODMC JDDNLIJKCJD
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	GHCLEKEDAHM BIJHGIJNPGA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	DMJIIPIJGLE EMCDBJJLCNG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	OPOBPIDEDPH ACEBIALEFNB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	OABGDCJKBCI PJDNBGMCKAM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	BCMCIFBKNFK DDBCNJALMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	IHJDAIENJFM PBPEMIONJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	NNJEDNLBDMH COFCHCDMJNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	JFCENMOBGOK IGLJBFAPLAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	BKHOIOIJIII FPJNHMFEAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	DFALPJPJPOL OJBBEEBIHAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	DAOOKEHLCHM JPCKHLNCOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	JAEPFJOJMJK ELKJDPIKNGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	NKELGJIFBCJ IKAGAFEDJCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	AEAMMPAOHPO DJEKDJAOKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	NBJGOIMDMKC NLKMMDJINDO
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	DOHKLGBDCAM PBCIMJGPPKN
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	NHJOPKHKEBD CLHIEKAAFIH
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	FBGJGNJLLDO BEEFIKEGEBP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	JFLIKILMHEH PDOJPJGBCDC
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	PMDLPPPGAMK JGEBJNKHGHK
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	KKPLOELDIBK AOPAIPNJBHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void AILCGIGKBJE(JJCNDJJFHEJ OECCIMHNFDC);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
internal interface IHJDAIENJFM : GGAELEIAKGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DCIDDJKPLKA AAFNAGDLNDC(Guid HMFDPJCPEKL);

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ILBKIBAINPM(Guid HMFDPJCPEKL);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EIEHADFPIEC(Guid HMFDPJCPEKL, Task OGIBLKPPKOF);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LDIGJGMOGFL(Guid HMFDPJCPEKL, HNLJAOBELNP OMJAFNFHLIK);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(HNLJAOBELNP, Task)> AONPHNDNCAN(Guid HMFDPJCPEKL);
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface LJJBHHOGIGD : GGAELEIAKGO, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface NNJEDNLBDMH : GGAELEIAKGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HJEIDKNDJMG(KPCIENPMIHC JIGBFCEILIK);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IGIIBDGIBCK(KPCIENPMIHC JIGBFCEILIK);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<CCGFFOEKILI> AHBJDLMFAFG(CancellationToken POEMIEOJADA);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface JFCENMOBGOK : GGAELEIAKGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DCIDDJKPLKA FHFPOKMOGCI(KPCIENPMIHC BENEGGEOCDK);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALOICFJKJFE(Guid HMFDPJCPEKL, Task OGIBLKPPKOF);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface BKHOIOIJIII : GGAELEIAKGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HNLJAOBELNP> FPJNHMFEAGO(KPCIENPMIHC NOIOAJMKMIN);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface DFALPJPJPOL : GGAELEIAKGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FGGFFJJDOJP> GMFJJAEFJIM(EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, JCOMCEDKFBJ NMOCHEEIGMK, CancellationToken BIBHFGFDEGJ);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface JAEPFJOJMJK : GGAELEIAKGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HNLJAOBELNP CEENHKAIGHK(GHMIEPPMENM DKANGFLOOAP);

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task BMILLFPEILE(string GKNFKOKBKMK);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface DAOOKEHLCHM : GGAELEIAKGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<KPCIENPMIHC> GMBDOOMBGNF(KPCIENPMIHC GDHOLDPNHCL, JNFCFFOONNK PCENDCBKBHC, CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<KPCIENPMIHC> PGBKBEHJBHP(CancellationToken BIBHFGFDEGJ, JNFCFFOONNK PCENDCBKBHC);

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ODJJEDEFBFH EPFGMICGEJG(GCAFIKPGAJD LIMOELMDOEI, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ODJJEDEFBFH BHHNILAPAAF(GCAFIKPGAJD LIMOELMDOEI, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface NKELGJIFBCJ : GGAELEIAKGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HNLJAOBELNP IADAJEPLAFG(GHMIEPPMENM DKANGFLOOAP, CCGFFOEKILI AJEBLIPDGBH);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HNLJAOBELNP EEBKAJMHFEG(GHMIEPPMENM ODDGNEHIEGA);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface AEAMMPAOHPO
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IMEIGILADFI(AACHMDLCILJ ADAHLIALBKK);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CFLIJHNCOJG(AACHMDLCILJ ADAHLIALBKK);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BLJCCMEACPD(AACHMDLCILJ ADAHLIALBKK);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BCGJOCJJAKC(AACHMDLCILJ ADAHLIALBKK);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class AACHMDLCILJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly JCOMCEDKFBJ PLJELKKNPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private Dictionary<string, string> EOLFEGHHOHN;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public EIIPDELDDBE<string> CDPCLMIFMFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x761660", Offset = "0x760460", VA = "0x180761660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x761680", Offset = "0x760480", VA = "0x180761680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x763A40", Offset = "0x762840", VA = "0x180763A40")]
	public AACHMDLCILJ(JCOMCEDKFBJ AFGDLPFNIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6244AB0", Offset = "0x62438B0", VA = "0x186244AB0")]
	public AACHMDLCILJ GKPNFPFJCEF(string JLDFGFPAIIN, string GNLEHBFFNFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6244B80", Offset = "0x6243980", VA = "0x186244B80")]
	public bool PFNHLOLBJIA([Out] IEnumerable<KeyValuePair<string, string>> JPIEDCCPOMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5693500", Offset = "0x5692300", VA = "0x185693500")]
	public AACHMDLCILJ OPGLMPHMFPH(EIIPDELDDBE<string> JICPEFHJENB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface FBGJGNJLLDO
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	bool MICBOPMHBPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	string OGEBFAJBLDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DOKOOMPAIMP();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FGLPGPFPCNM FBMKJOMFHEJ(long KIPHFANLMBH);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IOCJEHKDFCC<GENLCBECCME, KOEJGCBBPJC> HFLODDGGJPO(long KIPHFANLMBH);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IOCJEHKDFCC<GENLCBECCME, BNNAHCBMALA> HCPJBFJNIGF(long KIPHFANLMBH);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IOCJEHKDFCC<long, DPNLDOHHJNG> KMGKNMHDIIG();

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task<bool> MBKHHAEJMLK(byte[] NEFJKEGBDFC, byte[] NIAIMECGJLJ, CancellationToken BIBHFGFDEGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface EDPCKDKBIGC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	bool EENFNNPBBKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	bool OOFHALIOJNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	JJCNDJJFHEJ JBKBEFLBJEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action MNGDHEFNEAN;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event CDDMAIAAIPE HDKMCPCNDKL;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event CDDMAIAAIPE BCOODKMOMAB;

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event CDDMAIAAIPE KFJMDDEEABE;

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<EDHHCKCKEHJ, bool> AHEGLMGDJBI;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HEDEDKGKALH();

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	CKFEPBOEKJB BGLPEEFLJCI();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	FDIKFKHJJGH EDJCELDAOAI();

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task<HNLJAOBELNP> OIJGANPFEML(JBIBDPPGHNE KEFDGELDJDB);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task HICKKPIJKJB(CancellationToken BIBHFGFDEGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface LKGIKKGGCBC
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool IONPAMDOFCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string HCHFMOAJIOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IOPINAIMKJL(Scene LIIJPCAJPAJ);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task PDLNAKFDDEP(HDCEIMDCGJK DMCNEDOECIJ, CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task LDCFEOOKJAJ();
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface CJIBMGCPPCM
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	GHGDBFAHECB KOBHDJCOPLN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool FDNCBGANMGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	bool GHGNEKGMNAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool BPLHIODPMMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool AGCHICFABOA
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool EKLLKCFAOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "51")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool APBCJOLHDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "52")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	float APGILCENNGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "56")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<float> HMKNAJCIDLN;

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OILPPPCALMB GOCEOGJBFLC(OILPPPCALMB LCEHHHGNPPG);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GJLKCFEPAFA(OILPPPCALMB NFDHIFFHPGD);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NAPBDIPBEAG();

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task BIAICENMEDC(EIIPDELDDBE<string>.OABKDIIPOLN IGOOEFLNONA, CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CJCPKJKAKJP(float AAFIFKJHGBH);

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FHNPKBLLLPI(string JFGIJEKPOBI);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<DODNIFLIGFN> IEEGBNGHFAL();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable NFOFIHDCOCE(object GMNCNEPJHHN, DODNIFLIGFN GGJAKCFGJEB);

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	KOEJGCBBPJC JONOGHLIDMH(IEnumerable<MEEBAJFNOLB> EJHDEDCBBCG);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void KMNBLOCBKAH(int BNPNMCOOHLL);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task PABGNHNPCMF();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OAALBGBHDCO();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool MLACFDDDJIM();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task NHEBKNGLJEC(CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Task JFMJIAIEOCJ(CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task<LBPCLKMJNHK> EGJGLJNBIIG(DateTime DJHOADBJEMG, CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task<bool> GKBFEAALEDN(CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void POCBBHECOPI(string DFDHGDGHDAL = "", float IBPBGABDEAO = 3f);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "22")]
	HMAKMLLEGCB FEONLGMHOEM(LGCKKPDPBBM BBOBBFHBGOJ, HBIMDAADLCM LJGFDMBCNCG, BNNAHCBMALA FONIHPPLBKB, IEnumerable<PersistenceView> JBNPHDAKIKC, OKKKKFEMHMB JEKDEGEELKH);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void JCNJHLAADJK(BNNAHCBMALA FONIHPPLBKB);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void MDILNGGJJGD(MEEBAJFNOLB CHKCMEOEOJO, [In] HMAKMLLEGCB HHNIDIHBAFA);

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Task DFKEIOKEIGC(BNNAHCBMALA PDOAMGFMMJI, bool MAGFNANODPJ, CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Task GFKDKMNDJPN(CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void MDGFFGAKHNF(long NGLNDFKLBFL, long PIJEGGFFPOI, OABHNCNHAAJ LPPHACPIBIA, GBFOHGAHICD CANMHKDMMFK, CCPPDIFNJBM OBDJDLGBOHF, LEMPGINLPKF? GNMNCHGMMOK, PPGCPHJKJOD? HFCHACAOOHA);

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void LMNGHIBBNMI(long NGLNDFKLBFL, long PIJEGGFFPOI, PPGCPHJKJOD? HFCHACAOOHA);

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void AHIHEIPCICK(PersistenceView OFPJMFEJKMB);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool PDFHGIPJPHO(PersistenceView IHHDBAHIMPL);

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "31")]
	bool IDGBAIEJDHJ(MEEBAJFNOLB CHKCMEOEOJO, GBHCGBLPNAE OEHHLNMNHMO, [Out] NAGGCEGLFLP CLOFIGECFHG);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "32")]
	Task JJPBKOJABNP(CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void ACMMILMBBCO();

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "34")]
	IDisposable OBLNGBHBEDK();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void MCELLALBFJF(BNNAHCBMALA PDOAMGFMMJI, GBHCGBLPNAE OEHHLNMNHMO);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task<bool> FGDMAEFOHAB(HEJEKJPNGFL COFDFOKIOPK, CancellationToken BIBHFGFDEGJ, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN);

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void FDPLGKJOIGG(CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "38")]
	Task<EDLOAKHJMNO> DJLMBELJKJE(GJPMHGHLOIP GDHOLDPNHCL);

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "39")]
	Task<OABHNCNHAAJ> MJFCCOEHDGD(long NGLNDFKLBFL, bool HAMCBHMHBEA, CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<GBFOHGAHICD> CIMMFOOOLJN(long NGLNDFKLBFL, long PIJEGGFFPOI, long KICFIJPIOII, CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "41")]
	Task<JDABFNMFCMB> EPABKDNPDOG(string KHKBFBOFMIB, CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<JDABFNMFCMB> DEPEFCOPKFH(string KHKBFBOFMIB, long NGLNDFKLBFL, long PIJEGGFFPOI, string OBCNALAKINJ, JOIBFHNBMAM.NPDHONCMECO MFKPIJLKLHA, JOIBFHNBMAM.NPDHONCMECO NIAIMECGJLJ, int KGBEDEDLIBF);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "44")]
	bool POMEGPBIALG();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool JAEGELAHHEB();

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "46")]
	bool CIGCIBPDDFE(IEnumerable<NAGGCEGLFLP> BCLINPMPNAI);

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void NLMJNEAIIOF(List<GameObject> KLNBGBBNCMD);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float ICKNDKAEJMC();

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<Scene> ICOAKFLMNDH(string EPCCHKDEDAA, LoadSceneMode OGFODAAECAP, bool KLHIAFKDFBA, EIIPDELDDBE<string>.OABKDIIPOLN JICPEFHJENB);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void CCLFANBHIMA();

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void ICBCKMIIPHK(bool HNEIOJHCMIL);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "57")]
	void GAFDBKPKEAK(JCOMCEDKFBJ GPEFBGHDHFN);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "58")]
	Task KIMOADPHPBO(EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "59")]
	Task HKLIKEBKFMP(EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "60")]
	Task PNDFMGFACFI(EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "61")]
	IDisposable MAGAEIFEOKO();

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "62")]
	BCBGBPJIIPL MNNKCEMMPJC();

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "63")]
	Task AALGPBADKEC(CancellationToken BIBHFGFDEGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface BCBGBPJIIPL
{
	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DEAGDAMKGNG(CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JPMONAFDFJL(CancellationToken BIBHFGFDEGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct HMAKMLLEGCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public HashSet<int> ECGNGPDOOGG;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public enum LBPCLKMJNHK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	No,
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public struct LGCKKPDPBBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public string BFAADCKIDKD;
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface GHGDBFAHECB
{
	[Cpp2IlInjected.Token(Token = "0x17000055")]
	JCOMCEDKFBJ FFIAPDMBNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	OABHNCNHAAJ KECNBLJDMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	BAKIIDGEBHM AFAJNLFJPJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	bool NGMEHEALDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	bool OMFHHHEOCGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	int ILFBBOICHCO
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action AIHDMJICCEG;

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event Action<int> HMGDAFKDNON;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LPJALLLCDBE();

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.JHGEIOECGPG> ACFGFHNIEHP(long KIPHFANLMBH, [Optional] CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<FGGGIKNANNA> OGLMGMGJGPI();

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task KBEBEJHFCCD();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "14")]
	(JCOMCEDKFBJ, JJCNDJJFHEJ) PKOCCCMMHBJ();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "15")]
	EAKMPIGGJPJ HCFJKACEKMG();

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EAMIJAMHGGK(long KIPHFANLMBH);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface NBJGOIMDMKC
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JDOBLCJLAPJ([Out] IEnumerable<int> PFHONAOHJPH);

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IBIDCAPGNLO(DMEPLNBDMIK PFKLELGAJPH);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MPDNELCIHOC(DMEPLNBDMIK PFKLELGAJPH);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface CKBFIIOLGPM
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JAHNFBNDFDC(HNLJAOBELNP OMJALDHHOEE);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface LIAHOJBLCMF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MCDGPCAMKEJ(DJCJFNHKCEN.EKIBJJLLCCC LPOAHOKLILE);

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LBCIKEKAAKO(DJCJFNHKCEN.EKIBJJLLCCC LPOAHOKLILE);
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface BFNLIFGMJBO : LIAHOJBLCMF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HNLJAOBELNP IBOCNOFJMJP(GHMIEPPMENM ODDGNEHIEGA);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface EEEIAIDPIAO : LIAHOJBLCMF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HNLJAOBELNP CEENHKAIGHK(GHMIEPPMENM GMGHMLHOMNF);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface FGLPGPFPCNM
{
	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IHFDHMKEEAA<HDCEIMDCGJK, EAGLHGKDHHG>> KIHAIGNODAF(string OBCNALAKINJ, long KIPHFANLMBH, HMNCILDCCDI.NMJKLNKMKAG NOIMABODHIE, CancellationToken BIBHFGFDEGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface IOCJEHKDFCC<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IHFDHMKEEAA<byte[], EAGLHGKDHHG>> LFDGBLCJLIO(TGetDataArg OFPCPIFKKJA, CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IHFDHMKEEAA<MPIDCENOJCB<TData>, EAGLHGKDHHG> KBPPPGMNJJP(byte[] PFDMLBFKIAP);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class NLDEOOHAJLI : DNDAMAFFFKG, EDPCKDKBIGC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct GBFGCMBAAFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public AsyncTaskMethodBuilder<HNLJAOBELNP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public NLDEOOHAJLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public JBIBDPPGHNE autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private TaskAwaiter<HNLJAOBELNP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x625A6A0", Offset = "0x62594A0", VA = "0x18625A6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x625A920", Offset = "0x6259720", VA = "0x18625A920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct MAONBPHEDBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public NLDEOOHAJLI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x625DCC0", Offset = "0x625CAC0", VA = "0x18625DCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x625DEF0", Offset = "0x625CCF0", VA = "0x18625DEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class PKENEAJNGGP : IEnumerable<GGAELEIAKGO>, IEnumerable, IEnumerator<GGAELEIAKGO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private GGAELEIAKGO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public NLDEOOHAJLI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		private GGAELEIAKGO System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x863A90", Offset = "0x862890", VA = "0x180863A90")]
		[DebuggerHidden]
		public PKENEAJNGGP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6262690", Offset = "0x6261490", VA = "0x186262690", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6262AF0", Offset = "0x62618F0", VA = "0x186262AF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6262A40", Offset = "0x6261840", VA = "0x186262A40", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<GGAELEIAKGO> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6262A40", Offset = "0x6261840", VA = "0x186262A40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly CancellationTokenSource DMGGJGPODJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly OILPPPCALMB NFDHIFFHPGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private bool GIDFIEECIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private ECBHDGLMBMM LIPCJFJHFHJ;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public HEJEKJPNGFL DHHNJONBIAP
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x76B160", Offset = "0x769F60", VA = "0x18076B160", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x76B170", Offset = "0x769F70", VA = "0x18076B170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public DOPLIFPLHHG FNLIBEJLBDN
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x764C40", Offset = "0x763A40", VA = "0x180764C40", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x764C30", Offset = "0x763A30", VA = "0x180764C30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public CJIBMGCPPCM FHMIKKFADBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x764C20", Offset = "0x763A20", VA = "0x180764C20", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x764BE0", Offset = "0x7639E0", VA = "0x180764BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public LKGIKKGGCBC PAFFJGKLBKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x764C00", Offset = "0x763A00", VA = "0x180764C00", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x764BF0", Offset = "0x7639F0", VA = "0x180764BF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public BFNLIFGMJBO DPDDMPAJNNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x764C10", Offset = "0x763A10", VA = "0x180764C10", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x764BD0", Offset = "0x7639D0", VA = "0x180764BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public EEEIAIDPIAO FOKKNDHNPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x766D10", Offset = "0x765B10", VA = "0x180766D10", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x766D00", Offset = "0x765B00", VA = "0x180766D00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public FNIHCJMFGHB DBAGHIJEKAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x76FD20", Offset = "0x76EB20", VA = "0x18076FD20", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x76FC40", Offset = "0x76EA40", VA = "0x18076FC40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public PANHNKJODMC JDDNLIJKCJD
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x76FD10", Offset = "0x76EB10", VA = "0x18076FD10", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x76FC10", Offset = "0x76EA10", VA = "0x18076FC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public GHCLEKEDAHM BIJHGIJNPGA
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x76FCA0", Offset = "0x76EAA0", VA = "0x18076FCA0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x76FCB0", Offset = "0x76EAB0", VA = "0x18076FCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public DMJIIPIJGLE EMCDBJJLCNG
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x8125E0", Offset = "0x8113E0", VA = "0x1808125E0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8126C0", Offset = "0x8114C0", VA = "0x1808126C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public OPOBPIDEDPH ACEBIALEFNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x76FC50", Offset = "0x76EA50", VA = "0x18076FC50", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x76FC70", Offset = "0x76EA70", VA = "0x18076FC70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public OABGDCJKBCI PJDNBGMCKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x89C9D0", Offset = "0x89B7D0", VA = "0x18089C9D0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x89B2F0", Offset = "0x89A0F0", VA = "0x18089B2F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public BCMCIFBKNFK DDBCNJALMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x76C140", Offset = "0x76AF40", VA = "0x18076C140", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x76C120", Offset = "0x76AF20", VA = "0x18076C120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public IHJDAIENJFM PBPEMIONJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8B4A00", Offset = "0x8B3800", VA = "0x1808B4A00", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8B4C50", Offset = "0x8B3A50", VA = "0x1808B4C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public LJJBHHOGIGD MPGFLIOAGEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x83E3C0", Offset = "0x83D1C0", VA = "0x18083E3C0", Slot = "55")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D10", Offset = "0x8B3B10", VA = "0x1808B4D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public NNJEDNLBDMH COFCHCDMJNA
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8B4A50", Offset = "0x8B3850", VA = "0x1808B4A50", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8B4CB0", Offset = "0x8B3AB0", VA = "0x1808B4CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public JFCENMOBGOK IGLJBFAPLAL
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x818420", Offset = "0x817220", VA = "0x180818420", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D30", Offset = "0x8B3B30", VA = "0x1808B4D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public BKHOIOIJIII FPJNHMFEAGO
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8B4A60", Offset = "0x8B3860", VA = "0x1808B4A60", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x8B4CD0", Offset = "0x8B3AD0", VA = "0x1808B4CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public DFALPJPJPOL OJBBEEBIHAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x76C190", Offset = "0x76AF90", VA = "0x18076C190", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x76C0E0", Offset = "0x76AEE0", VA = "0x18076C0E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public DAOOKEHLCHM JPCKHLNCOOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE00", Offset = "0x7DAC00", VA = "0x1807DBE00", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE10", Offset = "0x7DAC10", VA = "0x1807DBE10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public JAEPFJOJMJK ELKJDPIKNGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8B4A80", Offset = "0x8B3880", VA = "0x1808B4A80", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D50", Offset = "0x8B3B50", VA = "0x1808B4D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public NKELGJIFBCJ IKAGAFEDJCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8B4A70", Offset = "0x8B3870", VA = "0x1808B4A70", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8B4CF0", Offset = "0x8B3AF0", VA = "0x1808B4CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public AEAMMPAOHPO DJEKDJAOKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8B4A40", Offset = "0x8B3840", VA = "0x1808B4A40", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8B4C90", Offset = "0x8B3A90", VA = "0x1808B4C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public NBJGOIMDMKC NLKMMDJINDO
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B90", Offset = "0x8B3990", VA = "0x1808B4B90", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8B4F70", Offset = "0x8B3D70", VA = "0x1808B4F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public DOHKLGBDCAM PBCIMJGPPKN
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B70", Offset = "0x8B3970", VA = "0x1808B4B70", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x8B4F30", Offset = "0x8B3D30", VA = "0x1808B4F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public NHJOPKHKEBD CLHIEKAAFIH
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B20", Offset = "0x8B3920", VA = "0x1808B4B20", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x8B4E90", Offset = "0x8B3C90", VA = "0x1808B4E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public FBGJGNJLLDO BEEFIKEGEBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x8B4AE0", Offset = "0x8B38E0", VA = "0x1808B4AE0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8B4E10", Offset = "0x8B3C10", VA = "0x1808B4E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public JFLIKILMHEH PDOJPJGBCDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B80", Offset = "0x8B3980", VA = "0x1808B4B80", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public PMDLPPPGAMK JGEBJNKHGHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8B4A10", Offset = "0x8B3810", VA = "0x1808B4A10", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public KKPLOELDIBK AOPAIPNJBHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B50", Offset = "0x8B3950", VA = "0x1808B4B50", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public JJCNDJJFHEJ JBKBEFLBJEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8B4AF0", Offset = "0x8B38F0", VA = "0x1808B4AF0", Slot = "53")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x8B4E30", Offset = "0x8B3C30", VA = "0x1808B4E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	private bool BGBGLBFFBDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x62604B0", Offset = "0x625F2B0", VA = "0x1862604B0", Slot = "46")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	private bool AIPIBBNIBBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x625FE00", Offset = "0x625EC00", VA = "0x18625FE00", Slot = "47")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	private CancellationToken CBJOGICLGMA
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x625F9B0", Offset = "0x625E7B0", VA = "0x18625F9B0", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	private OILPPPCALMB ELBHOEAJHMF
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event Action FOCJCAKHFGM
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x62600B0", Offset = "0x625EEB0", VA = "0x1862600B0", Slot = "36")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x62603A0", Offset = "0x625F1A0", VA = "0x1862603A0", Slot = "37")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event CDDMAIAAIPE AFNKOMGEKHG
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6260110", Offset = "0x625EF10", VA = "0x186260110", Slot = "38")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x62602E0", Offset = "0x625F0E0", VA = "0x1862602E0", Slot = "39")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	private event CDDMAIAAIPE NECPNOAPKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x625FAC0", Offset = "0x625E8C0", VA = "0x18625FAC0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x625FF70", Offset = "0x625ED70", VA = "0x18625FF70", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	private event CDDMAIAAIPE NDCIPMEOGCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x625FC00", Offset = "0x625EA00", VA = "0x18625FC00", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6260340", Offset = "0x625F140", VA = "0x186260340", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	private event Action<EDHHCKCKEHJ, bool> LCKOMBDNCPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6260170", Offset = "0x625EF70", VA = "0x186260170", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x625FF10", Offset = "0x625ED10", VA = "0x18625FF10", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x8B4E30", Offset = "0x8B3C30", VA = "0x1808B4E30", Slot = "35")]
	public void AILCGIGKBJE(JJCNDJJFHEJ OECCIMHNFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6260510", Offset = "0x625F310", VA = "0x186260510")]
	[UnityEngine.Scripting.Preserve]
	internal NLDEOOHAJLI([NMBHAKGIBHG(null)] OILPPPCALMB NFDHIFFHPGD, [NMBHAKGIBHG(null)] HEJEKJPNGFL COFDFOKIOPK, [NMBHAKGIBHG(null)] DOPLIFPLHHG CCNCOKNOFID, [NMBHAKGIBHG(null)] CJIBMGCPPCM EILPDJCOMNG, [NMBHAKGIBHG(null)] LKGIKKGGCBC DOHICNGHCKH, [NMBHAKGIBHG(null)] BFNLIFGMJBO LEDBJGFMKFL, [NMBHAKGIBHG(null)] EEEIAIDPIAO GMONNOHBADL, [NMBHAKGIBHG(null)] FNIHCJMFGHB PEJNLHEMDEP, [NMBHAKGIBHG(null)] PANHNKJODMC FKHGDOCKADN, [NMBHAKGIBHG(null)] GHCLEKEDAHM MBHNBGAIGPA, [NMBHAKGIBHG(null)] DMJIIPIJGLE HOIBAOKBKJG, [NMBHAKGIBHG(null)] OPOBPIDEDPH LGBPEMBKMIO, [NMBHAKGIBHG(null)] OABGDCJKBCI LEBLGKEKICC, [NMBHAKGIBHG(null)] BCMCIFBKNFK DFFDOCAOKKI, [NMBHAKGIBHG(null)] IHJDAIENJFM GEGLDHGEJGN, [NMBHAKGIBHG(null)] LJJBHHOGIGD JFBGHFPIGDJ, [NMBHAKGIBHG(null)] NNJEDNLBDMH LCJMDLKIPEN, [NMBHAKGIBHG(null)] JFCENMOBGOK JINCOHMDBKG, [NMBHAKGIBHG(null)] BKHOIOIJIII BCGGEJKPHLL, [NMBHAKGIBHG(null)] DFALPJPJPOL GGINEBEOIHB, [NMBHAKGIBHG(null)] JAEPFJOJMJK JEEFGKDDDAE, [NMBHAKGIBHG(null)] DAOOKEHLCHM NBIOAIHOKDB, [NMBHAKGIBHG(null)] NKELGJIFBCJ PPIIKGKEPEP, [NMBHAKGIBHG(null)] AEAMMPAOHPO HIHJJECJEPL, [NMBHAKGIBHG(null)] NBJGOIMDMKC MBONEHPOBCJ, [NMBHAKGIBHG(null)] NHJOPKHKEBD OMPKHLFKKJK, [NMBHAKGIBHG(null)] FBGJGNJLLDO EGPGDLDLBPG, [NMBHAKGIBHG(null)] JFLIKILMHEH KIPLDDOEKNE, [NMBHAKGIBHG(null)] PMDLPPPGAMK FHOCFKMOBEL, [NMBHAKGIBHG(null)] KKPLOELDIBK HJLGAHJBIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6260400", Offset = "0x625F200", VA = "0x186260400")]
	private void OOCIGOIJKNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x625FC60", Offset = "0x625EA60", VA = "0x18625FC60", Slot = "54")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x625FFD0", Offset = "0x625EDD0", VA = "0x18625FFD0", Slot = "48")]
	private void HEDAJFPGLDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6260020", Offset = "0x625EE20", VA = "0x186260020", Slot = "49")]
	private CKFEPBOEKJB JFGEAMAJLPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x625FE80", Offset = "0x625EC80", VA = "0x18625FE80", Slot = "50")]
	private FDIKFKHJJGH GANKGFDIOKE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x62601D0", Offset = "0x625EFD0", VA = "0x1862601D0", Slot = "51")]
	[AsyncStateMachine(typeof(GBFGCMBAAFA))]
	private Task<HNLJAOBELNP> OJPIGKMHCEC(JBIBDPPGHNE OEAGFPFKGKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x625F9D0", Offset = "0x625E7D0", VA = "0x18625F9D0", Slot = "52")]
	[AsyncStateMachine(typeof(MAONBPHEDBC))]
	private Task BHMPJIFLJAM(CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x625FB80", Offset = "0x625E980", VA = "0x18625FB80")]
	[IteratorStateMachine(typeof(PKENEAJNGGP))]
	private IEnumerable<GGAELEIAKGO> DEEGLBEGDOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x625FB20", Offset = "0x625E920", VA = "0x18625FB20")]
	[CompilerGenerated]
	private void CMGOAHICMJG(GGAELEIAKGO PMEJDDFHMDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class MNJIHOHLMJO : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0xC20850", Offset = "0xC1F650", VA = "0x180C20850")]
	public MNJIHOHLMJO(string JIGBFCEILIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal class MNEJFBGBDHF : IBNAOMAPDHE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct JKCGPBKFLEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public MNEJFBGBDHF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x625D2C0", Offset = "0x625C0C0", VA = "0x18625D2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x625D600", Offset = "0x625C400", VA = "0x18625D600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly DNDAMAFFFKG HJDDMPFEAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly CJIBMGCPPCM EILPDJCOMNG;

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x76A6C0", Offset = "0x7694C0", VA = "0x18076A6C0")]
	public MNEJFBGBDHF(DNDAMAFFFKG HJDDMPFEAJK, CJIBMGCPPCM EILPDJCOMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x625F8C0", Offset = "0x625E6C0", VA = "0x18625F8C0", Slot = "4")]
	[AsyncStateMachine(typeof(JKCGPBKFLEB))]
	public Task<bool> OMFDJOAOBKI(CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x625F7E0", Offset = "0x625E5E0", VA = "0x18625F7E0")]
	[CompilerGenerated]
	private object CNODLPJBJBK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal class MIJOGPJFMBI : IBNAOMAPDHE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct BONHMCLIKKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public MIJOGPJFMBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private long <currentInstanceId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private bool <currentIsOffline>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private float <timeoutTime>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x6250D50", Offset = "0x624FB50", VA = "0x186250D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x6251460", Offset = "0x6250260", VA = "0x186251460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly DNDAMAFFFKG HJDDMPFEAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly CJIBMGCPPCM EILPDJCOMNG;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	private GHGDBFAHECB KOBHDJCOPLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x625F580", Offset = "0x625E380", VA = "0x18625F580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x76A6C0", Offset = "0x7694C0", VA = "0x18076A6C0")]
	public MIJOGPJFMBI(DNDAMAFFFKG HJDDMPFEAJK, CJIBMGCPPCM EILPDJCOMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x625F6B0", Offset = "0x625E4B0", VA = "0x18625F6B0", Slot = "4")]
	[AsyncStateMachine(typeof(BONHMCLIKKC))]
	public Task<bool> OMFDJOAOBKI(CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x625F5D0", Offset = "0x625E3D0", VA = "0x18625F5D0")]
	[CompilerGenerated]
	private object LPFAPAJFHPP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
internal class BPEMNOGBEJP : IBNAOMAPDHE
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class JCJJDIMFFKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public BPEMNOGBEJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public FGGGIKNANNA result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public JCOMCEDKFBJ newPresenceRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public long currentInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public JCJJDIMFFKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x625D1D0", Offset = "0x625BFD0", VA = "0x18625D1D0")]
		internal object IJCLPPLOINA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x625D160", Offset = "0x625BF60", VA = "0x18625D160")]
		internal object FFMHOEFJJFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x625D0C0", Offset = "0x625BEC0", VA = "0x18625D0C0")]
		internal object BILCNFCACPL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct AFCGGHCDJKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public BPEMNOGBEJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private JCJJDIMFFKE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private TaskAwaiter<FGGGIKNANNA> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x6245700", Offset = "0x6244500", VA = "0x186245700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6246030", Offset = "0x6244E30", VA = "0x186246030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly DNDAMAFFFKG HJDDMPFEAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly CJIBMGCPPCM EILPDJCOMNG;

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	private GHGDBFAHECB KOBHDJCOPLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x62514D0", Offset = "0x62502D0", VA = "0x1862514D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x76A6C0", Offset = "0x7694C0", VA = "0x18076A6C0")]
	public BPEMNOGBEJP(DNDAMAFFFKG HJDDMPFEAJK, CJIBMGCPPCM EILPDJCOMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6251520", Offset = "0x6250320", VA = "0x186251520", Slot = "4")]
	[AsyncStateMachine(typeof(AFCGGHCDJKN))]
	public Task<bool> OMFDJOAOBKI(CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
internal interface IBNAOMAPDHE
{
	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<bool> OMFDJOAOBKI(CancellationToken BIBHFGFDEGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal struct CCMPMDNEJDF
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class GPIOAMIDDJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public DNDAMAFFFKG manager;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public GPIOAMIDDJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x625AE70", Offset = "0x6259C70", VA = "0x18625AE70")]
		internal Task JMHGKGLELMB(EAHIPFGMIPN data, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct HEKOEMDCHCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public CCMPMDNEJDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private JBIBDPPGHNE <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<LBPCLKMJNHK> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<HNLJAOBELNP> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x625AEC0", Offset = "0x6259CC0", VA = "0x18625AEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x625B450", Offset = "0x625A250", VA = "0x18625B450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct PCBEHHEJKDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public CCMPMDNEJDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6262310", Offset = "0x6261110", VA = "0x186262310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6262630", Offset = "0x6261430", VA = "0x186262630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly CancellationToken BIBHFGFDEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly DNDAMAFFFKG OHOLEEOLBDH;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private HEJEKJPNGFL DHHNJONBIAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x6251B60", Offset = "0x6250960", VA = "0x186251B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	private CJIBMGCPPCM FHMIKKFADBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x6251900", Offset = "0x6250700", VA = "0x186251900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	private GHGDBFAHECB KOBHDJCOPLN
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6251BB0", Offset = "0x62509B0", VA = "0x186251BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private GHCLEKEDAHM BIJHGIJNPGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x62518B0", Offset = "0x62506B0", VA = "0x1862518B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x1C2DDB0", Offset = "0x1C2CBB0", VA = "0x181C2DDB0")]
	public CCMPMDNEJDF(CancellationToken BIBHFGFDEGJ, DNDAMAFFFKG OHOLEEOLBDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6251D40", Offset = "0x6250B40", VA = "0x186251D40")]
	public static AECEECPPOFG PLPNJHIIIGE(DNDAMAFFFKG OHOLEEOLBDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6251C30", Offset = "0x6250A30", VA = "0x186251C30")]
	[AsyncStateMachine(typeof(HEKOEMDCHCN))]
	public Task<bool> ODBEBJNFCLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6251950", Offset = "0x6250750", VA = "0x186251950")]
	private bool KJLJPOABIBE([Out] JBIBDPPGHNE OEAGFPFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x62516B0", Offset = "0x62504B0", VA = "0x1862516B0")]
	[AsyncStateMachine(typeof(PCBEHHEJKDF))]
	private Task CFNADMFJBMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6251780", Offset = "0x6250580", VA = "0x186251780")]
	private Task<LBPCLKMJNHK> CHPJDECEMKA(JBIBDPPGHNE LGCHENFMKAI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal struct DCIDDJKPLKA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly IHJDAIENJFM GEGLDHGEJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly Guid HMFDPJCPEKL;

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private Task<(HNLJAOBELNP, Task)> BPNLKIEGGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x62533A0", Offset = "0x62521A0", VA = "0x1862533A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x391B990", Offset = "0x391A790", VA = "0x18391B990")]
	public DCIDDJKPLKA(IHJDAIENJFM GEGLDHGEJGN, Guid HMFDPJCPEKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6253540", Offset = "0x6252340", VA = "0x186253540")]
	public TaskAwaiter<(HNLJAOBELNP, Task)> EBBCBJPMOFL()
	{
		return default(TaskAwaiter<(HNLJAOBELNP, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6253470", Offset = "0x6252270", VA = "0x186253470", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal struct APPBHNFBOGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly TaskCompletionSource<(HNLJAOBELNP, Task)> GMGKDNJDNBP;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public Task<(HNLJAOBELNP, Task)> BPNLKIEGGPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x624A900", Offset = "0x6249700", VA = "0x18624A900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x624AB50", Offset = "0x6249950", VA = "0x18624AB50")]
	public APPBHNFBOGK(TimeSpan FFFIPJLIDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x624AAB0", Offset = "0x62498B0", VA = "0x18624AAB0")]
	public void NFJNMFPGBPB(Task OGIBLKPPKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x624AA20", Offset = "0x6249820", VA = "0x18624AA20")]
	public void IGDNOJIKCDP(HNLJAOBELNP OMJALDHHOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x624A9D0", Offset = "0x62497D0", VA = "0x18624A9D0")]
	public void GNGDJIGEPGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x624A940", Offset = "0x6249740", VA = "0x18624A940")]
	internal void FDJIPHAIBBM(string JIGBFCEILIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class EECBOJHBJPI
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class OGOBCJGDFOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public GBFOHGAHICD subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public OGOBCJGDFOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6261DB0", Offset = "0x6260BB0", VA = "0x186261DB0")]
		internal bool PIAGMLLFENO(BAKIIDGEBHM s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x62570F0", Offset = "0x6255EF0", VA = "0x1862570F0")]
	public static FGGFFJJDOJP HKJMJGOBNGA(long LOMBOBCNNPE, long PIJEGGFFPOI, string KHKBFBOFMIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x6257180", Offset = "0x6255F80", VA = "0x186257180")]
	public static FGGFFJJDOJP HKJMJGOBNGA(long LOMBOBCNNPE, long PIJEGGFFPOI, GENLCBECCME NEFJKEGBDFC, long KICFIJPIOII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x6256D30", Offset = "0x6255B30", VA = "0x186256D30")]
	public static FGGFFJJDOJP HKJMJGOBNGA(EDLOAKHJMNO PBIONKHELBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x6256EC0", Offset = "0x6255CC0", VA = "0x186256EC0")]
	public static FGGFFJJDOJP HKJMJGOBNGA(OABHNCNHAAJ FMNBENJFDCG, GBFOHGAHICD KIAHEDPDKHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x6257240", Offset = "0x6256040", VA = "0x186257240")]
	public static FGGFFJJDOJP ONAEOMOMHME(this FGGFFJJDOJP JPGMJABDIAJ, OABHNCNHAAJ EBPGLEDBPLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6257330", Offset = "0x6256130", VA = "0x186257330")]
	public static FGGFFJJDOJP POFBPPFLBJK(this FGGFFJJDOJP JPGMJABDIAJ, GBFOHGAHICD HFCCLOGFLNO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[UnityEngine.Scripting.Preserve]
internal class CDILHJHNJKD : PANHNKJODMC, GGAELEIAKGO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private struct DLNDIIAKPAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public CDILHJHNJKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6254000", Offset = "0x6252E00", VA = "0x186254000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x62546E0", Offset = "0x62534E0", VA = "0x1862546E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly DMEPLNBDMIK DEGNLNLJJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private string DMOGJAIMCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Task PAHAHCIPPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private DNDAMAFFFKG HJDDMPFEAJK;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool CEFOHAKBBIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6252100", Offset = "0x6250F00", VA = "0x186252100", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public Task MAKKHJFDBFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x6251F50", Offset = "0x6250D50", VA = "0x186251F50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x768590", Offset = "0x767390", VA = "0x180768590", Slot = "7")]
	public void OOCIGOIJKNJ(DNDAMAFFFKG HJDDMPFEAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6251DF0", Offset = "0x6250BF0", VA = "0x186251DF0", Slot = "6")]
	public void CEPGKPCGMJD(Task CKLPGPGBFPF, string MGICKGFIBHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6251FE0", Offset = "0x6250DE0", VA = "0x186251FE0")]
	[AsyncStateMachine(typeof(DLNDIIAKPAE))]
	private Task KJIFICNHMPN(Task HCEKEIKCIAE, string MGICKGFIBHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6252130", Offset = "0x6250F30", VA = "0x186252130")]
	public CDILHJHNJKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class KLEGDOIODJH : DOHKLGBDCAM, GGAELEIAKGO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool KEEDDKDOHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private AKMHPCJDBNK DIAOKBCJPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private HEJEKJPNGFL COFDFOKIOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private NHJOPKHKEBD OMPKHLFKKJK;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public AKMHPCJDBNK JDNPDEIGCOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x625D7E0", Offset = "0x625C5E0", VA = "0x18625D7E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x625D910", Offset = "0x625C710", VA = "0x18625D910", Slot = "7")]
	public void OOCIGOIJKNJ(DNDAMAFFFKG HJDDMPFEAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x625DA90", Offset = "0x625C890", VA = "0x18625DA90", Slot = "5")]
	public void PAHEFJPAHOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x625D7A0", Offset = "0x625C5A0", VA = "0x18625D7A0", Slot = "6")]
	public void BBAOEGKHIOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x625D850", Offset = "0x625C650", VA = "0x18625D850")]
	private Task NOOMCKCIIGI(PEBOAKEGABG NGDHFFBLCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x625D7A0", Offset = "0x625C5A0", VA = "0x18625D7A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public KLEGDOIODJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class EGNMCFJGGBL : NHJOPKHKEBD
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private class OICMNLACKKM<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly ADGHNFOGBFM HJJHJNBDHIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly string JLDFGFPAIIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly T HEDIGKLLBHN;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public T GMPOHOAMMIO
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x7B46A0", Offset = "0x7B34A0", VA = "0x1807B46A0")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x8A3500", Offset = "0x8A2300", VA = "0x1808A3500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x3D25680", Offset = "0x3D24480", VA = "0x183D25680")]
		public OICMNLACKKM(ADGHNFOGBFM HJJHJNBDHIG, string JLDFGFPAIIN, T HEDIGKLLBHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x3D250B0", Offset = "0x3D23EB0", VA = "0x183D250B0")]
		private void FMEBGLHHFLI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly ADGHNFOGBFM HJJHJNBDHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly OICMNLACKKM<TimeSpan> JGANNNCHEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly OICMNLACKKM<TimeSpan> CEPCICCCFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly OICMNLACKKM<TimeSpan> CEFADEFDILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly OICMNLACKKM<TimeSpan> FEPBPJFPAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly OICMNLACKKM<bool> ICMOLEOIDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly OICMNLACKKM<bool> MGJGKHNFOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly OICMNLACKKM<bool> HINNCMJPDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly OICMNLACKKM<int> OKLGFADFEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly OICMNLACKKM<bool> FBKJAEOKKIH;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public TimeSpan GJMHAGADLNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x6257600", Offset = "0x6256400", VA = "0x186257600", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public TimeSpan CJAOHJEMOHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x6257500", Offset = "0x6256300", VA = "0x186257500", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public TimeSpan MPIHBLGLHLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6257540", Offset = "0x6256340", VA = "0x186257540", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public TimeSpan ONDJKGIBOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6257680", Offset = "0x6256480", VA = "0x186257680", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public bool PMACCKEKNDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6257580", Offset = "0x6256380", VA = "0x186257580", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public bool PGHPPBHFPGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x62575C0", Offset = "0x62563C0", VA = "0x1862575C0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool PDDCIAPOHBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x62576C0", Offset = "0x62564C0", VA = "0x1862576C0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public int EICLHHCBNHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6257640", Offset = "0x6256440", VA = "0x186257640", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public bool MMKGGMMOIHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x62574C0", Offset = "0x62562C0", VA = "0x1862574C0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6257700", Offset = "0x6256500", VA = "0x186257700")]
	[UnityEngine.Scripting.Preserve]
	public EGNMCFJGGBL([NMBHAKGIBHG(null)] ADGHNFOGBFM HJJHJNBDHIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[UnityEngine.Scripting.Preserve]
internal class NPLCOACDHFG : DMJIIPIJGLE, GGAELEIAKGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class KJPPDMHDDFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public MDPBNPLCIHC roomEvent;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public KJPPDMHDDFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x625D6C0", Offset = "0x625C4C0", VA = "0x18625D6C0")]
		internal object CCDAGBIHLDL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action MNGDHEFNEAN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x6260F60", Offset = "0x625FD60", VA = "0x186260F60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x6260D90", Offset = "0x625FB90", VA = "0x186260D90", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event CDDMAIAAIPE HDKMCPCNDKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x6261000", Offset = "0x625FE00", VA = "0x186261000", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x6260CF0", Offset = "0x625FAF0", VA = "0x186260CF0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event CDDMAIAAIPE BCOODKMOMAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x6261400", Offset = "0x6260200", VA = "0x186261400", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6261290", Offset = "0x6260090", VA = "0x186261290", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event CDDMAIAAIPE KFJMDDEEABE
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x6260C50", Offset = "0x625FA50", VA = "0x186260C50", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x6261330", Offset = "0x6260130", VA = "0x186261330", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<EDHHCKCKEHJ, bool> AHEGLMGDJBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x6260950", Offset = "0x625F750", VA = "0x186260950", Slot = "12")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x6260E30", Offset = "0x625FC30", VA = "0x186260E30", Slot = "13")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "19")]
	public void OOCIGOIJKNJ(DNDAMAFFFKG HJDDMPFEAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6260A00", Offset = "0x625F800", VA = "0x186260A00", Slot = "14")]
	public void ECAPMENHGGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x62613D0", Offset = "0x62601D0", VA = "0x1862613D0", Slot = "15")]
	public void NLBKGHKINBJ(MDPBNPLCIHC HAPHPPAHEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6260C20", Offset = "0x625FA20", VA = "0x186260C20", Slot = "16")]
	public void FCLENOGOBGE(MDPBNPLCIHC HAPHPPAHEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6260EE0", Offset = "0x625FCE0", VA = "0x186260EE0", Slot = "17")]
	public void JIHKNIGENHE(MDPBNPLCIHC HAPHPPAHEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x6260F10", Offset = "0x625FD10", VA = "0x186260F10", Slot = "18")]
	public void JKGDMJKAFFE(EDHHCKCKEHJ LANJILPEPCC, bool BPGAINDNDCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x62610A0", Offset = "0x625FEA0", VA = "0x1862610A0")]
	private void LBCPFKCIFOM(CDDMAIAAIPE GGJAKCFGJEB, MDPBNPLCIHC HAPHPPAHEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public NPLCOACDHFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[UnityEngine.Scripting.Preserve]
internal class MFMHPILCFMI : OPOBPIDEDPH, GGAELEIAKGO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[CompilerGenerated]
	private struct AGBFABKFLFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public MFMHPILCFMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x62460A0", Offset = "0x6244EA0", VA = "0x1862460A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x62465F0", Offset = "0x62453F0", VA = "0x1862465F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct POJLEGAPGBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public MFMHPILCFMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x6262B40", Offset = "0x6261940", VA = "0x186262B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x62631E0", Offset = "0x6261FE0", VA = "0x1862631E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class CLOBDAIGENI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public CLOBDAIGENI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x62521C0", Offset = "0x6250FC0", VA = "0x1862521C0")]
		internal object EFPLPOHPGOO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private struct DDCIEAEGCOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public MFMHPILCFMI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private CLOBDAIGENI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6253590", Offset = "0x6252390", VA = "0x186253590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x6253D20", Offset = "0x6252B20", VA = "0x186253D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class DGDHKJMNOBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int index;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public DGDHKJMNOBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x6253F90", Offset = "0x6252D90", VA = "0x186253F90")]
		internal object NAIKMCCONFE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private DNDAMAFFFKG HJDDMPFEAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private CJIBMGCPPCM EILPDJCOMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private IBNAOMAPDHE[] MLKFMKOOKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private CancellationTokenSource PEGEFBHNLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private int DFBEKAODDLN;

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x625F470", Offset = "0x625E270", VA = "0x18625F470", Slot = "6")]
	public void OOCIGOIJKNJ(DNDAMAFFFKG HJDDMPFEAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x625EC50", Offset = "0x625DA50", VA = "0x18625EC50", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x625EF50", Offset = "0x625DD50", VA = "0x18625EF50", Slot = "8")]
	public void HONJIECJPOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x625EE70", Offset = "0x625DC70", VA = "0x18625EE70", Slot = "5")]
	public void HEDEDKGKALH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x625F060", Offset = "0x625DE60", VA = "0x18625F060", Slot = "4")]
	[AsyncStateMachine(typeof(AGBFABKFLFH))]
	public Task JEEAALPEJKM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x625E940", Offset = "0x625D740", VA = "0x18625E940")]
	private void CDEICHOPOBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x625E850", Offset = "0x625D650", VA = "0x18625E850")]
	[AsyncStateMachine(typeof(POJLEGAPGBJ))]
	private Task APEDBACFBKF(CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x625F260", Offset = "0x625E060", VA = "0x18625F260")]
	[AsyncStateMachine(typeof(DDCIEAEGCOK))]
	private Task<bool> MELFHCLCALN(int DOJILIOCHKM, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x625F390", Offset = "0x625E190", VA = "0x18625F390")]
	private void NMPMCLCHAFD(int DOJILIOCHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x625EC60", Offset = "0x625DA60", VA = "0x18625EC60")]
	private void GJIJKGNANCF(int DOJILIOCHKM, bool BPGAINDNDCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x625F130", Offset = "0x625DF30", VA = "0x18625F130")]
	private void KJNHHJPHILE(int DOJILIOCHKM, Exception AOBBDNCEPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x625ED40", Offset = "0x625DB40", VA = "0x18625ED40")]
	private void GKEHAGMGHPA(CancellationToken BIBHFGFDEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public MFMHPILCFMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class AGGBPLPBAIE : OABGDCJKBCI, GGAELEIAKGO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	private struct EKBPHEPFCNI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public JCOMCEDKFBJ targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public AGGBPLPBAIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public JJCNDJJFHEJ customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x62587A0", Offset = "0x62575A0", VA = "0x1862587A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x6259160", Offset = "0x6257F60", VA = "0x186259160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct CMNPFMFFDCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public AGGBPLPBAIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public JCOMCEDKFBJ targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public JJCNDJJFHEJ customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private EIIPDELDDBE<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private JNFCFFOONNK <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private AACHMDLCILJ <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x6252230", Offset = "0x6251030", VA = "0x186252230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x6252E30", Offset = "0x6251C30", VA = "0x186252E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class ENHNKOBIFNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public Matchmaking.MNMCHLLNNPG result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public FGBLHMLLBED errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public ENHNKOBIFNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x62591C0", Offset = "0x6257FC0", VA = "0x1862591C0")]
		internal object LAAFHHCDLJL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class HHJOMIFCCIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public Task<FGGFFJJDOJP> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public HHJOMIFCCIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950")]
		internal Task<FGGFFJJDOJP> PAOOGJNEEMD(EIIPDELDDBE<string>.OABKDIIPOLN _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	private struct BCEGMDLJLIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AGGBPLPBAIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public JCOMCEDKFBJ targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public EIIPDELDDBE<string>.OABKDIIPOLN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public JJCNDJJFHEJ customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public JNFCFFOONNK joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private HHJOMIFCCIF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private PLICAFGMAMP <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private EAEGPJJOHKN <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private Task<Matchmaking.JHGEIOECGPG> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private OEEGPGKOJOA <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private TaskAwaiter<Matchmaking.JHGEIOECGPG> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private CancellationToken <photonJoinedToken>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private Task <roomLoadTask>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private TaskAwaiter<FGGFFJJDOJP> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x624B220", Offset = "0x624A020", VA = "0x18624B220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6250010", Offset = "0x624EE10", VA = "0x186250010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private struct ABAFKNPJJIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public AGGBPLPBAIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public EIIPDELDDBE<string>.OABKDIIPOLN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6244C10", Offset = "0x6243A10", VA = "0x186244C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x62456A0", Offset = "0x62444A0", VA = "0x1862456A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	private struct AJJKHJOGCNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public AGGBPLPBAIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private OILPPPCALMB <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x624A180", Offset = "0x6248F80", VA = "0x18624A180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x624A600", Offset = "0x6249400", VA = "0x18624A600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct HFHEGAEOGKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public AsyncTaskMethodBuilder<Matchmaking.JHGEIOECGPG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public JCOMCEDKFBJ targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public EIIPDELDDBE<string>.OABKDIIPOLN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public AGGBPLPBAIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private TaskAwaiter<Matchmaking.JHGEIOECGPG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x625B4C0", Offset = "0x625A2C0", VA = "0x18625B4C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x625B9A0", Offset = "0x625A7A0", VA = "0x18625B9A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	private struct ODFKCKLJPFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public EIIPDELDDBE<string>.OABKDIIPOLN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public Matchmaking.JHGEIOECGPG serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public AGGBPLPBAIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public JNFCFFOONNK joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private TaskAwaiter<OEJGKHLLHLM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x6261620", Offset = "0x6260420", VA = "0x186261620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x6261D50", Offset = "0x6260B50", VA = "0x186261D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class DDDGDIEPMJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public JCOMCEDKFBJ targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public DDDGDIEPMJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6253E90", Offset = "0x6252C90", VA = "0x186253E90")]
		internal object LIJCGIFLBCI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6253D90", Offset = "0x6252B90", VA = "0x186253D90")]
		internal string JMCKGMAJOOB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct EIJMIDBCHCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public JCOMCEDKFBJ targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public AGGBPLPBAIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private DDDGDIEPMJA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6257B10", Offset = "0x6256910", VA = "0x186257B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6258740", Offset = "0x6257540", VA = "0x186258740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct FMDHPFLCGML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public EIIPDELDDBE<string>.OABKDIIPOLN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public AGGBPLPBAIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public JNFCFFOONNK joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public FGGFFJJDOJP initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public JCOMCEDKFBJ targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public PLICAFGMAMP progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6259D30", Offset = "0x6258B30", VA = "0x186259D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x625A640", Offset = "0x6259440", VA = "0x18625A640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct DOGPALPOBKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public EIIPDELDDBE<string>.OABKDIIPOLN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public AGGBPLPBAIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private CancellationTokenSource <timeoutTcs>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private CancellationToken <timeoutToken>5__7;

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x6254740", Offset = "0x6253540", VA = "0x186254740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6255DE0", Offset = "0x6254BE0", VA = "0x186255DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	private struct MBNBLAJDDLP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public EAHIPFGMIPN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public AGGBPLPBAIE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private TaskAwaiter<HNLJAOBELNP> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x625DF50", Offset = "0x625CD50", VA = "0x18625DF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x625E780", Offset = "0x625D580", VA = "0x18625E780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class IOMILMEAILD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public JCOMCEDKFBJ targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public IOMILMEAILD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x625CC70", Offset = "0x625BA70", VA = "0x18625CC70")]
		internal object DEPMLBBJOBI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class ECFCEIAMDOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public ECFCEIAMDOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6256C90", Offset = "0x6255A90", VA = "0x186256C90")]
		internal void IOIFKEHKDML()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class LLBIILMEAPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public JCOMCEDKFBJ targetInstance;

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public LLBIILMEAPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x625DC40", Offset = "0x625CA40", VA = "0x18625DC40")]
		internal object KAPLONNICGE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class OBDKMCLCMNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public JCOMCEDKFBJ targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public OBDKMCLCMNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6261520", Offset = "0x6260320", VA = "0x186261520")]
		internal string OMNGEOENDHO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly GKFGDEJLFAD PAJEMFCKNDE;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly GKFGDEJLFAD OEFMOGEIFDP;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly GKFGDEJLFAD ACFLACAFDGB;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static readonly string LOBJGOEMALA;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly string CABBDGLFMID;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static readonly string DIBNJEKOOFM;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public static readonly Guid OIOLBJFKDNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private FNIHCJMFGHB PEJNLHEMDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private DOPLIFPLHHG CCNCOKNOFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private HEJEKJPNGFL COFDFOKIOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private DNDAMAFFFKG HJDDMPFEAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private CJIBMGCPPCM EILPDJCOMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private OPOBPIDEDPH LGBPEMBKMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private PANHNKJODMC FKHGDOCKADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private DMJIIPIJGLE HOIBAOKBKJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private KKPLOELDIBK HJLGAHJBIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private PMDLPPPGAMK FHOCFKMOBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private IDisposable NHFEPCMJPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly DMEPLNBDMIK DGENECLLEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly DMEPLNBDMIK IHMKMKFBJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private OEEGPGKOJOA CDCLFLDPEBD;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public TaskStatus LIMLOGJKAKB
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x955D70", Offset = "0x954B70", VA = "0x180955D70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x99EDC0", Offset = "0x99DBC0", VA = "0x18099EDC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private GHGDBFAHECB KOBHDJCOPLN
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x6248980", Offset = "0x6247780", VA = "0x186248980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x62498C0", Offset = "0x62486C0", VA = "0x1862498C0", Slot = "6")]
	public void OOCIGOIJKNJ(DNDAMAFFFKG HJDDMPFEAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6247560", Offset = "0x6246360", VA = "0x186247560", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6246C60", Offset = "0x6245A60", VA = "0x186246C60", Slot = "5")]
	[AsyncStateMachine(typeof(EKBPHEPFCNI))]
	public Task BHKFPJFNECD(JCOMCEDKFBJ NMOCHEEIGMK, JJCNDJJFHEJ OLCEOMOCFJP, CancellationToken MGHJMBBEFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x62484E0", Offset = "0x62472E0", VA = "0x1862484E0")]
	[AsyncStateMachine(typeof(CMNPFMFFDCL))]
	private Task KNNMNNOOBPL(JCOMCEDKFBJ NMOCHEEIGMK, JJCNDJJFHEJ OLCEOMOCFJP, CancellationToken MGHJMBBEFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x62471A0", Offset = "0x6245FA0", VA = "0x1862471A0")]
	private static void DLGKLEJDPMC(KKPLOELDIBK HJLGAHJBIEN, JCOMCEDKFBJ NMOCHEEIGMK, Exception AOBBDNCEPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6248D70", Offset = "0x6247B70", VA = "0x186248D70")]
	private static void MPFMEFMHBCM(AACHMDLCILJ KACCIGAJCKM, Exception AOBBDNCEPBJ, [Optional] List<int> GMDPJIBLNEJ, int DFBEKAODDLN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6246F10", Offset = "0x6245D10", VA = "0x186246F10")]
	[AsyncStateMachine(typeof(BCEGMDLJLIG))]
	private Task CJAHOGDFNHI(EIIPDELDDBE<string>.OABKDIIPOLN JICPEFHJENB, JCOMCEDKFBJ NMOCHEEIGMK, JJCNDJJFHEJ OLCEOMOCFJP, JNFCFFOONNK GJGOCKIJDIH, CancellationToken MGHJMBBEFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x6246B10", Offset = "0x6245910", VA = "0x186246B10")]
	private void BDBCIODBFOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x6249660", Offset = "0x6248460", VA = "0x186249660")]
	[AsyncStateMachine(typeof(ABAFKNPJJIL))]
	private Task NJNJFJDAOGG(EIIPDELDDBE<string>.OABKDIIPOLN JICPEFHJENB, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6248A30", Offset = "0x6247830", VA = "0x186248A30")]
	private void MGEDHOGHBEG(JCOMCEDKFBJ NMOCHEEIGMK, CancellationToken MGHJMBBEFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x6247DE0", Offset = "0x6246BE0", VA = "0x186247DE0")]
	private void JEPLBEOBKPK(JCOMCEDKFBJ NMOCHEEIGMK, JNFCFFOONNK GJGOCKIJDIH, OperationCanceledException PHGEJJNIMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x6248750", Offset = "0x6247550", VA = "0x186248750")]
	private void LDGGHKGLGJD(JCOMCEDKFBJ NMOCHEEIGMK, JNFCFFOONNK GJGOCKIJDIH, Exception AOBBDNCEPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x6247850", Offset = "0x6246650", VA = "0x186247850")]
	private void HGDEPLABBEJ(JCOMCEDKFBJ NMOCHEEIGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x62489D0", Offset = "0x62477D0", VA = "0x1862489D0")]
	private static MDPBNPLCIHC LKGCGHJEFNA(JCOMCEDKFBJ NMOCHEEIGMK)
	{
		return default(MDPBNPLCIHC);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x62470D0", Offset = "0x6245ED0", VA = "0x1862470D0")]
	[AsyncStateMachine(typeof(AJJKHJOGCNE))]
	private Task DALOJLIEBGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6246650", Offset = "0x6245450", VA = "0x186246650")]
	[AsyncStateMachine(typeof(HFHEGAEOGKG))]
	private Task<Matchmaking.JHGEIOECGPG> ACFGFHNIEHP(JCOMCEDKFBJ NMOCHEEIGMK, EIIPDELDDBE<string>.OABKDIIPOLN JICPEFHJENB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x6249D80", Offset = "0x6248B80", VA = "0x186249D80")]
	private static OEJGKHLLHLM PNPFDMNHNDH(Matchmaking.JHGEIOECGPG NDJIADJMINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x6247BA0", Offset = "0x62469A0", VA = "0x186247BA0")]
	[AsyncStateMachine(typeof(ODFKCKLJPFF))]
	private Task IAPEPCBJAAD(Matchmaking.JHGEIOECGPG NDJIADJMINB, JNFCFFOONNK GJGOCKIJDIH, EIIPDELDDBE<string>.OABKDIIPOLN JICPEFHJENB, CancellationToken JAGJENAECGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x6248390", Offset = "0x6247190", VA = "0x186248390")]
	[AsyncStateMachine(typeof(EIJMIDBCHCB))]
	private Task KLHJOAIEIIP(JCOMCEDKFBJ NMOCHEEIGMK, CancellationTokenSource FBEDFAPACFN, Task DNKNEPBNNBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x6246DA0", Offset = "0x6245BA0", VA = "0x186246DA0")]
	[AsyncStateMachine(typeof(FMDHPFLCGML))]
	private Task BOAKDKKCHOF(FGGFFJJDOJP AEIDKAPOCOA, PLICAFGMAMP FIFIFPAOFFD, JCOMCEDKFBJ NNDAKAJHHAL, JNFCFFOONNK DPPGHGICCAO, EIIPDELDDBE<string>.OABKDIIPOLN JICPEFHJENB, CancellationToken CNPANGOIAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x6246790", Offset = "0x6245590", VA = "0x186246790")]
	private JNFCFFOONNK AODLAOCGCOJ(JNFCFFOONNK DPPGHGICCAO, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x6249790", Offset = "0x6248590", VA = "0x186249790")]
	[AsyncStateMachine(typeof(DOGPALPOBKN))]
	private Task NMNMEFFOIBH(EIIPDELDDBE<string>.OABKDIIPOLN JICPEFHJENB, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x6248630", Offset = "0x6247430", VA = "0x186248630")]
	[AsyncStateMachine(typeof(MBNBLAJDDLP))]
	private Task LDFJGLCOHCN(EAHIPFGMIPN PFDMLBFKIAP, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x6246990", Offset = "0x6245790", VA = "0x186246990")]
	private static void BCDMMECLIEF(JCOMCEDKFBJ NMOCHEEIGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x62481C0", Offset = "0x6246FC0", VA = "0x1862481C0")]
	private void JLLFLJHNHLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x62476B0", Offset = "0x62464B0", VA = "0x1862476B0")]
	private void FMBPLHPEGPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x6247B10", Offset = "0x6246910", VA = "0x186247B10")]
	private void HPCGOONEJOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6247A80", Offset = "0x6246880", VA = "0x186247A80")]
	private void HMGEOBDCLCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6247CF0", Offset = "0x6246AF0", VA = "0x186247CF0")]
	private static void IHJLPHKBOBJ(JCOMCEDKFBJ NMOCHEEIGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x6247740", Offset = "0x6246540", VA = "0x186247740")]
	private static CancellationTokenRegistration GLKMJOBALNI(JCOMCEDKFBJ NMOCHEEIGMK, CancellationToken JAGJENAECGN)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x62475B0", Offset = "0x62463B0", VA = "0x1862475B0")]
	private static void EKIOHMIBJBE(JCOMCEDKFBJ NMOCHEEIGMK, Exception AOBBDNCEPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x6248010", Offset = "0x6246E10", VA = "0x186248010")]
	private void JGJAAEGGACJ(JCOMCEDKFBJ NMOCHEEIGMK, Task DNKNEPBNNBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x6249600", Offset = "0x6248400", VA = "0x186249600")]
	private static void NGLKBDEIIAD(Func<string> EMHIALHDHFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x624A0B0", Offset = "0x6248EB0", VA = "0x18624A0B0")]
	public AGGBPLPBAIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6247070", Offset = "0x6245E70", VA = "0x186247070")]
	[CompilerGenerated]
	internal static (int, int?) CPBHNDHPBMF(FGBLHMLLBED FGFBLJKGHIK)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[UnityEngine.Scripting.Preserve]
internal class IHHCIBIOEBP : BCMCIFBKNFK, GGAELEIAKGO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct BAIBBHGDAKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public IHHCIBIOEBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public EAHIPFGMIPN roomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x624ACE0", Offset = "0x6249AE0", VA = "0x18624ACE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x624B1C0", Offset = "0x6249FC0", VA = "0x18624B1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class IKLDPGDPDJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public IHHCIBIOEBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public EAHIPFGMIPN roomData;

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public IKLDPGDPDJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6276370", Offset = "0x6275170", VA = "0x186276370")]
		internal List<Task> IIPDEAEGAEO(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct HGFPDMHGNJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public AECEECPPOFG taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public EAHIPFGMIPN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6271CC0", Offset = "0x6270AC0", VA = "0x186271CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x6272090", Offset = "0x6270E90", VA = "0x186272090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct DGCKBKONCGB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public IHHCIBIOEBP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x626A570", Offset = "0x6269370", VA = "0x18626A570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x626A830", Offset = "0x6269630", VA = "0x18626A830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly HashSet<AECEECPPOFG> KKFIKOMDPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private DOPLIFPLHHG CCNCOKNOFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private DNDAMAFFFKG HJDDMPFEAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private DODNIFLIGFN CAPGDONGBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private JGMBHCBEGGL IAPKDJAINBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private IDisposable NHFEPCMJPMK;

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x625C960", Offset = "0x625B760", VA = "0x18625C960", Slot = "5")]
	public void OOCIGOIJKNJ(DNDAMAFFFKG HJDDMPFEAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x625BF90", Offset = "0x625AD90", VA = "0x18625BF90", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x625C0C0", Offset = "0x625AEC0", VA = "0x18625C0C0", Slot = "4")]
	public bool FHCGKCMMJJM(AECEECPPOFG LNAMNGLJHCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x625C3B0", Offset = "0x625B1B0", VA = "0x18625C3B0")]
	private void KIJAAIDFIKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x625BD90", Offset = "0x625AB90", VA = "0x18625BD90")]
	private void BICIJAPPGMH(EAHIPFGMIPN MFKPIJLKLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x625C120", Offset = "0x625AF20", VA = "0x18625C120")]
	[AsyncStateMachine(typeof(BAIBBHGDAKJ))]
	private Task FJOLDLNPPMC(EAHIPFGMIPN MFKPIJLKLHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x625BCC0", Offset = "0x625AAC0", VA = "0x18625BCC0")]
	private Func<CancellationToken, List<Task>> ALKACKDIMJN(EAHIPFGMIPN MFKPIJLKLHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x625C4F0", Offset = "0x625B2F0", VA = "0x18625C4F0")]
	private List<Task> NGLDPLKNHMN(EAHIPFGMIPN MFKPIJLKLHA, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x625C210", Offset = "0x625B010", VA = "0x18625C210")]
	[AsyncStateMachine(typeof(HGFPDMHGNJK))]
	private Task HKENNJHPOGA(AECEECPPOFG GGJHJJNMJNN, EAHIPFGMIPN PFDMLBFKIAP, CancellationToken PFKLELGAJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x625BFF0", Offset = "0x625ADF0", VA = "0x18625BFF0")]
	[AsyncStateMachine(typeof(DGCKBKONCGB))]
	private Task ELLNPJFNDHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x625C330", Offset = "0x625B130", VA = "0x18625C330")]
	private void HONJIECJPOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x625CBE0", Offset = "0x625B9E0", VA = "0x18625CBE0")]
	public IHHCIBIOEBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[UnityEngine.Scripting.Preserve]
internal sealed class DEJPDFOJJJJ : IHJDAIENJFM, GGAELEIAKGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class DKBBNGJBNFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public DKBBNGJBNFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x626AE40", Offset = "0x6269C40", VA = "0x18626AE40")]
		internal object IHAIELKEECP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class FAFLILJMJLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public FAFLILJMJLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x626CD90", Offset = "0x626BB90", VA = "0x18626CD90")]
		internal object JAAKPJLHKHD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class IIBAPFCACHL
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public IIBAPFCACHL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class AAMEJBFCBMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public AAMEJBFCBMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x6263CC0", Offset = "0x6262AC0", VA = "0x186263CC0")]
		internal object MAIGJJGHBPJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class EKABLEBMFEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public EKABLEBMFEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x626C680", Offset = "0x626B480", VA = "0x18626C680")]
		internal object FPFIKAHPFIH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private readonly Dictionary<Guid, APPBHNFBOGK> GEGLDHGEJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private readonly TimeSpan CEBNEHLDFDG;

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "9")]
	public void OOCIGOIJKNJ(DNDAMAFFFKG HJDDMPFEAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x6269A60", Offset = "0x6268860", VA = "0x186269A60", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x62697C0", Offset = "0x62685C0", VA = "0x1862697C0", Slot = "4")]
	public DCIDDJKPLKA AAFNAGDLNDC(Guid HMFDPJCPEKL)
	{
		return default(DCIDDJKPLKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x6269DC0", Offset = "0x6268BC0", VA = "0x186269DC0", Slot = "5")]
	public bool ILBKIBAINPM(Guid HMFDPJCPEKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6269A70", Offset = "0x6268870", VA = "0x186269A70", Slot = "6")]
	public bool EIEHADFPIEC(Guid HMFDPJCPEKL, Task OGIBLKPPKOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x6269FF0", Offset = "0x6268DF0", VA = "0x186269FF0", Slot = "7")]
	public bool LDIGJGMOGFL(Guid HMFDPJCPEKL, HNLJAOBELNP OMJALDHHOEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x62699F0", Offset = "0x62687F0", VA = "0x1862699F0", Slot = "8")]
	public Task<(HNLJAOBELNP, Task)> AONPHNDNCAN(Guid HMFDPJCPEKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x626A1F0", Offset = "0x6268FF0", VA = "0x18626A1F0")]
	private void LKJHMHOPKAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x626A430", Offset = "0x6269230", VA = "0x18626A430")]
	public DEJPDFOJJJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[UnityEngine.Scripting.Preserve]
internal class EFNBHBHFONG : LJJBHHOGIGD, GGAELEIAKGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	private class MMLMAFFJPLP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private readonly JCOMCEDKFBJ GPEFBGHDHFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private readonly CancellationTokenSource PEGEFBHNLPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public readonly CancellationToken BAEJCEDKNMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private bool KGOLDOGDLLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private bool FABLEFHCLJG;

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x627CBA0", Offset = "0x627B9A0", VA = "0x18627CBA0")]
		public MMLMAFFJPLP(JCOMCEDKFBJ GPEFBGHDHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x627CA50", Offset = "0x627B850", VA = "0x18627CA50")]
		public void HONJIECJPOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x627CA20", Offset = "0x627B820", VA = "0x18627CA20", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class BIBCHJAOHEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public PEBOAKEGABG disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public BIBCHJAOHEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x6266490", Offset = "0x6265290", VA = "0x186266490")]
		internal object JANMLFLFECM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct OJGNBMKENBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public PEBOAKEGABG disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public EFNBHBHFONG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x6280050", Offset = "0x627EE50", VA = "0x186280050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x6280480", Offset = "0x627F280", VA = "0x186280480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class NDAHMHPJCIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public NDAHMHPJCIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x627D6E0", Offset = "0x627C4E0", VA = "0x18627D6E0")]
		internal object DGFMMNBHBDC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct AOMEELCLMKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public EFNBHBHFONG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x62642D0", Offset = "0x62630D0", VA = "0x1862642D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x841FE0", Offset = "0x840DE0", VA = "0x180841FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class IGIOCAEFGAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public JCOMCEDKFBJ newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public IGIOCAEFGAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x6276250", Offset = "0x6275050", VA = "0x186276250")]
		internal object BFOOFKBBBKB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x6276330", Offset = "0x6275130", VA = "0x186276330")]
		internal object MPOCAFLBPCC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x62762F0", Offset = "0x62750F0", VA = "0x1862762F0")]
		internal object MENMDLPFGGJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class JMMEILJDLLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public long id;

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public JMMEILJDLLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x62779B0", Offset = "0x62767B0", VA = "0x1862779B0")]
		internal void OLEPFCEJLPA()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private struct HLIJIOFKIHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public JCOMCEDKFBJ newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public EFNBHBHFONG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public JJCNDJJFHEJ customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private IGIOCAEFGAJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x62720F0", Offset = "0x6270EF0", VA = "0x1862720F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x6273100", Offset = "0x6271F00", VA = "0x186273100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static readonly NGDJFHBIKLO.LBICECLIMDI CKGLHKDBFLH;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static readonly CJDGKNCMIEL OLJGPHABLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private DOPLIFPLHHG CCNCOKNOFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private DNDAMAFFFKG HJDDMPFEAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private OPOBPIDEDPH LGBPEMBKMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private CJIBMGCPPCM EILPDJCOMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private NHJOPKHKEBD OMPKHLFKKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private OABGDCJKBCI LEBLGKEKICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private long LGJEGMGCGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private MMLMAFFJPLP ABFJGIBPDFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private bool KPIKKBDDAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private Task OAEJFECPJEA;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private GHGDBFAHECB KOBHDJCOPLN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x626BF50", Offset = "0x626AD50", VA = "0x18626BF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public bool LKEPGKGNFIF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xA3B7C0", Offset = "0xA3A5C0", VA = "0x180A3B7C0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x626BD40", Offset = "0x626AB40", VA = "0x18626BD40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x626BFA0", Offset = "0x626ADA0", VA = "0x18626BFA0", Slot = "4")]
	public void OOCIGOIJKNJ(DNDAMAFFFKG HJDDMPFEAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x626B7E0", Offset = "0x626A5E0", VA = "0x18626B7E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x626B680", Offset = "0x626A480", VA = "0x18626B680")]
	[AsyncStateMachine(typeof(OJGNBMKENBJ))]
	private Task DBBKMBEBEDM(PEBOAKEGABG NKGLHJAOAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x626B190", Offset = "0x6269F90", VA = "0x18626B190")]
	private void AIHDMJICCEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x626B4E0", Offset = "0x626A2E0", VA = "0x18626B4E0")]
	private void ANNCOGEFBED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x626B350", Offset = "0x626A150", VA = "0x18626B350")]
	private void AMGDICAKHBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0x626B770", Offset = "0x626A570", VA = "0x18626B770")]
	private bool DMGFECPEHDB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x626BD50", Offset = "0x626AB50", VA = "0x18626BD50")]
	[AsyncStateMachine(typeof(AOMEELCLMKP))]
	private void HMGDAFKDNON(int LKPDEMOKJBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x626BAB0", Offset = "0x626A8B0", VA = "0x18626BAB0")]
	private void GENOPILDAME([Out] IDisposable CIHBAEKFLNB, [Out] IDisposable CBMCDGMAIBE, [Out] IDisposable LBEAECEPMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x626B950", Offset = "0x626A750", VA = "0x18626B950")]
	private bool FDHNLEPEIJJ(JCOMCEDKFBJ GPEFBGHDHFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x626BA60", Offset = "0x626A860", VA = "0x18626BA60")]
	private void FHMNPAIICPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x626BE20", Offset = "0x626AC20", VA = "0x18626BE20")]
	[AsyncStateMachine(typeof(HLIJIOFKIHK))]
	private Task KNNMNNOOBPL(JCOMCEDKFBJ GPEFBGHDHFN, JJCNDJJFHEJ OLCEOMOCFJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x626C610", Offset = "0x626B410", VA = "0x18626C610")]
	public EFNBHBHFONG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[UnityEngine.Scripting.Preserve]
internal sealed class IEBPPGEGEAP : NNJEDNLBDMH, GGAELEIAKGO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private struct BGCOFDIOFHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public AsyncTaskMethodBuilder<CCGFFOEKILI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public IEBPPGEGEAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private TaskAwaiter<CCGFFOEKILI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x6265C30", Offset = "0x6264A30", VA = "0x186265C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x6265E80", Offset = "0x6264C80", VA = "0x186265E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class LGGHKKKECEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		public KPCIENPMIHC message;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public LGGHKKKECEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x627B250", Offset = "0x627A050", VA = "0x18627B250")]
		internal object FJHGEOJNEEA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class NAELMLDCOAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public KPCIENPMIHC messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public NAELMLDCOAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x627CC50", Offset = "0x627BA50", VA = "0x18627CC50")]
		internal object KEFHDFHCKKM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class ELKKFDANFKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public KPCIENPMIHC request;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public ELKKFDANFKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x626C7A0", Offset = "0x626B5A0", VA = "0x18626C7A0")]
		internal object KPBFJJKIPBF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct HOHJLAFHNLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public KPCIENPMIHC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public IEBPPGEGEAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private TaskAwaiter<GCAFIKPGAJD> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x6273D70", Offset = "0x6272B70", VA = "0x186273D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x6274680", Offset = "0x6273480", VA = "0x186274680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class LLNIPONENPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public KPCIENPMIHC operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public LLNIPONENPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x627C220", Offset = "0x627B020", VA = "0x18627C220")]
		internal object IAOEJDGFMDA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct HOBKLFAHIHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		public KPCIENPMIHC operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public IEBPPGEGEAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private JNFCFFOONNK <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private TaskAwaiter<KPCIENPMIHC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x6273160", Offset = "0x6271F60", VA = "0x186273160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x6273D10", Offset = "0x6272B10", VA = "0x186273D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct EOJEPFCPCJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		public AsyncTaskMethodBuilder<GCAFIKPGAJD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		public IEBPPGEGEAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		public KPCIENPMIHC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private BOOJGEDPCLG.HAIFBMAHEPE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private JNFCFFOONNK <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private TaskAwaiter<KPCIENPMIHC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x626C800", Offset = "0x626B600", VA = "0x18626C800", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x626CD20", Offset = "0x626BB20", VA = "0x18626CD20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class MKGIGIPLCPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		public GCAFIKPGAJD operation;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public MKGIGIPLCPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x627C9A0", Offset = "0x627B7A0", VA = "0x18627C9A0")]
		internal object CMLODJOPPCK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private struct FGGLMOEAGDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public GCAFIKPGAJD operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public IEBPPGEGEAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private EIIPDELDDBE<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x626CF40", Offset = "0x626BD40", VA = "0x18626CF40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x626D5C0", Offset = "0x626C3C0", VA = "0x18626D5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class BCFGOADKKDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public KPCIENPMIHC request;

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public BCFGOADKKDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x62654C0", Offset = "0x62642C0", VA = "0x1862654C0")]
		internal object HMNCJNHBAGB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class KNGPFHDFGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public KPCIENPMIHC request;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public KNGPFHDFGIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x627A450", Offset = "0x6279250", VA = "0x18627A450")]
		internal object OMMIKMFMGFD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private DNDAMAFFFKG HJDDMPFEAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	private PANHNKJODMC FKHGDOCKADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	private JFCENMOBGOK JINCOHMDBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	private DAOOKEHLCHM NBIOAIHOKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	private HEJEKJPNGFL COFDFOKIOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private TaskCompletionSource<CCGFFOEKILI> BBFMJEFBGND;

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x6275C40", Offset = "0x6274A40", VA = "0x186275C40", Slot = "7")]
	public void OOCIGOIJKNJ(DNDAMAFFFKG HJDDMPFEAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6274940", Offset = "0x6273740", VA = "0x186274940", Slot = "6")]
	[AsyncStateMachine(typeof(BGCOFDIOFHJ))]
	public Task<CCGFFOEKILI> AHBJDLMFAFG(CancellationToken POEMIEOJADA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x6274B50", Offset = "0x6273950", VA = "0x186274B50", Slot = "4")]
	public void HJEIDKNDJMG(KPCIENPMIHC JIGBFCEILIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x6274EF0", Offset = "0x6273CF0", VA = "0x186274EF0", Slot = "5")]
	public void IGIIBDGIBCK(KPCIENPMIHC HPPHDKAHGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x6274A50", Offset = "0x6273850", VA = "0x186274A50")]
	[AsyncStateMachine(typeof(HOHJLAFHNLN))]
	private Task BBGGAPBBELL(KPCIENPMIHC GDHOLDPNHCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x6275A10", Offset = "0x6274810", VA = "0x186275A10")]
	[AsyncStateMachine(typeof(HOBKLFAHIHC))]
	private Task OGDJNFMCIOH(KPCIENPMIHC KMHLNKFBFAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x6275690", Offset = "0x6274490", VA = "0x186275690")]
	[AsyncStateMachine(typeof(EOJEPFCPCJJ))]
	private Task<GCAFIKPGAJD> MAMNLANLPEP(KPCIENPMIHC GDHOLDPNHCL, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x6275600", Offset = "0x6274400", VA = "0x186275600")]
	private JNFCFFOONNK KKKKPNCHDLB(KPCIENPMIHC NOIOAJMKMIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x6275B20", Offset = "0x6274920", VA = "0x186275B20")]
	[AsyncStateMachine(typeof(FGGLMOEAGDD))]
	private Task ONEPGFLFFLC(GCAFIKPGAJD ALJMPBCMDJC, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x62757E0", Offset = "0x62745E0", VA = "0x1862757E0")]
	private GCAFIKPGAJD MHFFFEILJBE(KPCIENPMIHC GDHOLDPNHCL, JNFCFFOONNK PCENDCBKBHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x23887E0", Offset = "0x23875E0", VA = "0x1823887E0")]
	private T OLEEJBGIBGJ<T>(T GNLEHBFFNFG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6275260", Offset = "0x6274060", VA = "0x186275260")]
	private GCAFIKPGAJD JFPABFBEPEB(KPCIENPMIHC GDHOLDPNHCL, JNFCFFOONNK PCENDCBKBHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public IEBPPGEGEAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[UnityEngine.Scripting.Preserve]
internal sealed class BPHHHFEOFKH : JFCENMOBGOK, GGAELEIAKGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class LGMPPNFOJEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public LGMPPNFOJEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x627B2B0", Offset = "0x627A0B0", VA = "0x18627B2B0")]
		internal object BLPEEIBFBBG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[CompilerGenerated]
	private sealed class FAJLLCLNDBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public FAJLLCLNDBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x626CDF0", Offset = "0x626BBF0", VA = "0x18626CDF0")]
		internal object DLEMLGCGKCO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private HEJEKJPNGFL COFDFOKIOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private NKELGJIFBCJ PPIIKGKEPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private NNJEDNLBDMH LCJMDLKIPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private IHJDAIENJFM GEGLDHGEJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private NBJGOIMDMKC MBONEHPOBCJ;

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x62685E0", Offset = "0x62673E0", VA = "0x1862685E0", Slot = "6")]
	public void OOCIGOIJKNJ(DNDAMAFFFKG HJDDMPFEAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x6266930", Offset = "0x6265730", VA = "0x186266930", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x62669E0", Offset = "0x62657E0", VA = "0x1862669E0", Slot = "4")]
	public DCIDDJKPLKA FHFPOKMOGCI(KPCIENPMIHC BENEGGEOCDK)
	{
		return default(DCIDDJKPLKA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x6266640", Offset = "0x6265440", VA = "0x186266640", Slot = "5")]
	public void ALOICFJKJFE(Guid HMFDPJCPEKL, Task OGIBLKPPKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x6266860", Offset = "0x6265660", VA = "0x186266860")]
	private void DHPHAEFDFHO(byte OPIMKOAPDOI, int NPLAPBCLCFM, object HHFAFDLGFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0x6267640", Offset = "0x6266440", VA = "0x186267640")]
	private void IJLLJOIJKMC(KGIPDMDFFNI EMJLGCDONIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x6267080", Offset = "0x6265E80", VA = "0x186267080")]
	private void GJHJBDODNID(KGIPDMDFFNI EMJLGCDONIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x6266E30", Offset = "0x6265C30", VA = "0x186266E30")]
	private void GHDPMPKAGGE(KGIPDMDFFNI EMJLGCDONIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x6267E40", Offset = "0x6266C40", VA = "0x186267E40")]
	private HNLJAOBELNP JPOLAEGKNAF(KPCIENPMIHC NOIOAJMKMIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x6267C10", Offset = "0x6266A10", VA = "0x186267C10")]
	private void IKLFPCHOBPI(KPCIENPMIHC KMHLNKFBFAF, HNLJAOBELNP OMJALDHHOEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x62680A0", Offset = "0x6266EA0", VA = "0x1862680A0")]
	private bool NKFBHKNLFIB(KPCIENPMIHC KMHLNKFBFAF, HNLJAOBELNP OMJALDHHOEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x6268360", Offset = "0x6267160", VA = "0x186268360")]
	private bool OGDBPKKFNHF(KPCIENPMIHC MAPCOIFNBLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x62673A0", Offset = "0x62661A0", VA = "0x1862673A0")]
	private bool GLLPAEIFBDI(byte OPIMKOAPDOI, ExitGames.Client.Photon.Hashtable EMJLGCDONIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public BPHHHFEOFKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[UnityEngine.Scripting.Preserve]
internal sealed class NDOLGJHGJDP : BKHOIOIJIII, GGAELEIAKGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class BEDACFPBBPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public CCGFFOEKILI operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public NDOLGJHGJDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public KPCIENPMIHC roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public BEDACFPBBPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x6265A90", Offset = "0x6264890", VA = "0x186265A90")]
		internal object CHMEDHIBOCE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x6265B00", Offset = "0x6264900", VA = "0x186265B00")]
		internal object CPJDPNBNELL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private struct GABDFBPNFBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public AsyncTaskMethodBuilder<HNLJAOBELNP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public NDOLGJHGJDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public KPCIENPMIHC roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private TaskAwaiter<HNLJAOBELNP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x626FC40", Offset = "0x626EA40", VA = "0x18626FC40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x6270320", Offset = "0x626F120", VA = "0x186270320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class NCHEDJBEJFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public CCGFFOEKILI operationType;

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public NCHEDJBEJFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x627D670", Offset = "0x627C470", VA = "0x18627D670")]
		internal object PJCKFHOIBGG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class ODPGJKJEGKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public KPCIENPMIHC request;

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public ODPGJKJEGKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x627F600", Offset = "0x627E400", VA = "0x18627F600")]
		internal object JELPMGHFPON()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x627F590", Offset = "0x627E390", VA = "0x18627F590")]
		internal object BPNLLGGEIOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x627F670", Offset = "0x627E470", VA = "0x18627F670")]
		internal object KPFEHGGMHFL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct OGBNAFNDLBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public AsyncTaskMethodBuilder<HNLJAOBELNP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public KPCIENPMIHC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public NDOLGJHGJDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private ODPGJKJEGKA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private DCIDDJKPLKA <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private HNLJAOBELNP <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private TaskAwaiter<(HNLJAOBELNP validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x627F6E0", Offset = "0x627E4E0", VA = "0x18627F6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x627FFE0", Offset = "0x627EDE0", VA = "0x18627FFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private HEJEKJPNGFL COFDFOKIOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private NKELGJIFBCJ PPIIKGKEPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private JFCENMOBGOK JINCOHMDBKG;

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x627DAA0", Offset = "0x627C8A0", VA = "0x18627DAA0", Slot = "5")]
	public void OOCIGOIJKNJ(DNDAMAFFFKG HJDDMPFEAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x627DB50", Offset = "0x627C950", VA = "0x18627DB50", Slot = "4")]
	[AsyncStateMachine(typeof(GABDFBPNFBP))]
	private Task<HNLJAOBELNP> PJIHHDPGMHP(KPCIENPMIHC NOIOAJMKMIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x627D890", Offset = "0x627C690", VA = "0x18627D890")]
	private bool NIAABJPMCBN(CCGFFOEKILI LANJILPEPCC, [Out] HNLJAOBELNP EKOLPKLNMBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x627D750", Offset = "0x627C550", VA = "0x18627D750")]
	[AsyncStateMachine(typeof(OGBNAFNDLBA))]
	private Task<HNLJAOBELNP> JJPNJFCOMLB(KPCIENPMIHC GDHOLDPNHCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public NDOLGJHGJDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class OPGPJGKCLPH : DFALPJPJPOL, GGAELEIAKGO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct IFPLDOADAJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		public AsyncTaskMethodBuilder<FGGFFJJDOJP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public JCOMCEDKFBJ targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public OPGPJGKCLPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private TaskAwaiter<OABHNCNHAAJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x6275D30", Offset = "0x6274B30", VA = "0x186275D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x62761E0", Offset = "0x6274FE0", VA = "0x1862761E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class ECHJHIFAIAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public ECHJHIFAIAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x626AEA0", Offset = "0x6269CA0", VA = "0x18626AEA0")]
		internal object GIFGACPFELI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct KBPBIGIAIID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public AsyncTaskMethodBuilder<OABHNCNHAAJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public OPGPJGKCLPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public JCOMCEDKFBJ targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private ECHJHIFAIAG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private TaskAwaiter<OABHNCNHAAJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x6277B20", Offset = "0x6276920", VA = "0x186277B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x6278110", Offset = "0x6276F10", VA = "0x186278110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class JBCHPBBLJBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public JBCHPBBLJBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x1305BA0", Offset = "0x13049A0", VA = "0x181305BA0")]
		internal bool FMIMEDDBKHO(BAKIIDGEBHM sr)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private CJIBMGCPPCM EILPDJCOMNG;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static readonly (GENLCBECCME superRoomData, long subRoomDataSaveId) FFKABHCLFLL;

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x6282130", Offset = "0x6280F30", VA = "0x186282130", Slot = "5")]
	public void OOCIGOIJKNJ(DNDAMAFFFKG HJDDMPFEAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x6281FD0", Offset = "0x6280DD0", VA = "0x186281FD0", Slot = "4")]
	[AsyncStateMachine(typeof(IFPLDOADAJB))]
	public Task<FGGFFJJDOJP> GMFJJAEFJIM(EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, JCOMCEDKFBJ NMOCHEEIGMK, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x6281E70", Offset = "0x6280C70", VA = "0x186281E70")]
	[AsyncStateMachine(typeof(KBPBIGIAIID))]
	private Task<OABHNCNHAAJ> BPCDHHPHHIC(JCOMCEDKFBJ NMOCHEEIGMK, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x62819F0", Offset = "0x62807F0", VA = "0x1862819F0")]
	private FGGFFJJDOJP AFGJMFDJNBK(JCOMCEDKFBJ NMOCHEEIGMK, OABHNCNHAAJ GJLKFCILFEP, long OBPCIAFLNJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x6281B30", Offset = "0x6280930", VA = "0x186281B30")]
	private (GENLCBECCME, long) BDBANLFDMLH(JCOMCEDKFBJ NMOCHEEIGMK, OABHNCNHAAJ GJLKFCILFEP, long OBPCIAFLNJK)
	{
		return default((GENLCBECCME, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public OPGPJGKCLPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[UnityEngine.Scripting.Preserve]
internal sealed class DDNKGCHKPNO : DAOOKEHLCHM, GGAELEIAKGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class DGPHLKKKFFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public KPCIENPMIHC request;

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public DGPHLKKKFFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x626A890", Offset = "0x6269690", VA = "0x18626A890")]
		internal object MFPMLEEGPPI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct LHGHIICMEFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public AsyncTaskMethodBuilder<KPCIENPMIHC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public KPCIENPMIHC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public DDNKGCHKPNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public JNFCFFOONNK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private TaskAwaiter<KPCIENPMIHC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x627BB70", Offset = "0x627A970", VA = "0x18627BB70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x627C1B0", Offset = "0x627AFB0", VA = "0x18627C1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct LOMKOJMAAGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AsyncTaskMethodBuilder<KPCIENPMIHC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public DDNKGCHKPNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public JNFCFFOONNK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private TaskAwaiter<AFBHEOGPOAF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x627C280", Offset = "0x627B080", VA = "0x18627C280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x627C8B0", Offset = "0x627B6B0", VA = "0x18627C8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class CGFOCLFLGKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public KPCIENPMIHC request;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public CGFOCLFLGKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6268C90", Offset = "0x6267A90", VA = "0x186268C90")]
		internal object CIBIJMNHOCK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private struct OMEFPAKCABG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public AsyncTaskMethodBuilder<KPCIENPMIHC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public KPCIENPMIHC request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public DDNKGCHKPNO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public JNFCFFOONNK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private GPLKLOFLLGK <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private DCPLKGBFCOK <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private TaskAwaiter<AFBHEOGPOAF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6280D60", Offset = "0x627FB60", VA = "0x186280D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x6281980", Offset = "0x6280780", VA = "0x186281980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private HEJEKJPNGFL COFDFOKIOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private DOHKLGBDCAM HNHKPKMJJCK;

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	private AKMHPCJDBNK JDNPDEIGCOI
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x6269060", Offset = "0x6267E60", VA = "0x186269060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x62695F0", Offset = "0x62683F0", VA = "0x1862695F0", Slot = "8")]
	public void OOCIGOIJKNJ(DNDAMAFFFKG HJDDMPFEAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x6269330", Offset = "0x6268130", VA = "0x186269330", Slot = "4")]
	[AsyncStateMachine(typeof(LHGHIICMEFE))]
	public Task<KPCIENPMIHC> GMBDOOMBGNF(KPCIENPMIHC GDHOLDPNHCL, JNFCFFOONNK PCENDCBKBHC, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x6269680", Offset = "0x6268480", VA = "0x186269680", Slot = "5")]
	[AsyncStateMachine(typeof(LOMKOJMAAGE))]
	public Task<KPCIENPMIHC> PGBKBEHJBHP(CancellationToken BIBHFGFDEGJ, JNFCFFOONNK PCENDCBKBHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x6269120", Offset = "0x6267F20", VA = "0x186269120", Slot = "6")]
	public ODJJEDEFBFH EPFGMICGEJG(GCAFIKPGAJD LIMOELMDOEI, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x6268E30", Offset = "0x6267C30", VA = "0x186268E30", Slot = "7")]
	public ODJJEDEFBFH BHHNILAPAAF(GCAFIKPGAJD LIMOELMDOEI, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x6269490", Offset = "0x6268290", VA = "0x186269490")]
	[AsyncStateMachine(typeof(OMEFPAKCABG))]
	private Task<KPCIENPMIHC> NHGFAJILPHL(KPCIENPMIHC GDHOLDPNHCL, JNFCFFOONNK PCENDCBKBHC, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x24EE1A0", Offset = "0x24ECFA0", VA = "0x1824EE1A0")]
	private static byte[] HPGIOMECMKD(KPCIENPMIHC JIGBFCEILIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public DDNKGCHKPNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[UnityEngine.Scripting.Preserve]
internal sealed class FIILNFGMLDA : NKELGJIFBCJ, GGAELEIAKGO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private BFNLIFGMJBO LEDBJGFMKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private HEJEKJPNGFL COFDFOKIOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private PANHNKJODMC FKHGDOCKADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private JAEPFJOJMJK JEEFGKDDDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private CJIBMGCPPCM EILPDJCOMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private OABGDCJKBCI LEBLGKEKICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private BCMCIFBKNFK DFFDOCAOKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private NHJOPKHKEBD OMPKHLFKKJK;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private GHGDBFAHECB KOBHDJCOPLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x626E690", Offset = "0x626D490", VA = "0x18626E690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private static HNLJAOBELNP NCAMNFFNLIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x6268750", Offset = "0x6267550", VA = "0x186268750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0x626E6E0", Offset = "0x626D4E0", VA = "0x18626E6E0", Slot = "6")]
	public void OOCIGOIJKNJ(DNDAMAFFFKG HJDDMPFEAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x626E520", Offset = "0x626D320", VA = "0x18626E520", Slot = "4")]
	public HNLJAOBELNP IADAJEPLAFG(GHMIEPPMENM DKANGFLOOAP, CCGFFOEKILI AJEBLIPDGBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x626E250", Offset = "0x626D050", VA = "0x18626E250", Slot = "5")]
	public HNLJAOBELNP EEBKAJMHFEG(GHMIEPPMENM ODDGNEHIEGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x62687D0", Offset = "0x62675D0", VA = "0x1862687D0")]
	private static HNLJAOBELNP KIPOMIJPMHA(FIIKENPCBCI GHFGMAKMGKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public FIILNFGMLDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public class NKNCNBKFDEG : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0x627DCE0", Offset = "0x627CAE0", VA = "0x18627DCE0")]
	public NKNCNBKFDEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x58D0990", Offset = "0x58CF790", VA = "0x1858D0990")]
	public NKNCNBKFDEG(string JIGBFCEILIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[UnityEngine.Scripting.Preserve]
internal sealed class JACNKJENFEP : GHCLEKEDAHM, GGAELEIAKGO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private struct FICCOMIMPHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public AsyncTaskMethodBuilder<HNLJAOBELNP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public JACNKJENFEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public JBIBDPPGHNE autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private EIIPDELDDBE<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private KIGKLGHKCHM <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private TaskAwaiter<HNLJAOBELNP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x626D620", Offset = "0x626C420", VA = "0x18626D620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x626E1E0", Offset = "0x626CFE0", VA = "0x18626E1E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private struct GLEJEBICOIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public JACNKJENFEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x6270C10", Offset = "0x626FA10", VA = "0x186270C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x6271360", Offset = "0x6270160", VA = "0x186271360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private struct OBPHBPEHMLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public JACNKJENFEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x627DD20", Offset = "0x627CB20", VA = "0x18627DD20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x627E230", Offset = "0x627D030", VA = "0x18627E230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private struct POLFAGGNMKL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public JACNKJENFEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x62822D0", Offset = "0x62810D0", VA = "0x1862822D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x6282A20", Offset = "0x6281820", VA = "0x186282A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private struct OKMOHAADFLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public JACNKJENFEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x6280B60", Offset = "0x627F960", VA = "0x186280B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x6280D00", Offset = "0x627FB00", VA = "0x186280D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct GPMCIJPGNLA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public JACNKJENFEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x6271420", Offset = "0x6270220", VA = "0x186271420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x6271B40", Offset = "0x6270940", VA = "0x186271B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private struct ANHEHACPOCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public JACNKJENFEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x6263E00", Offset = "0x6262C00", VA = "0x186263E00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x6264270", Offset = "0x6263070", VA = "0x186264270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private struct BHJCDFCPOOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public JACNKJENFEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public KCBBPOFPKPE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private EIIPDELDDBE<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6265EF0", Offset = "0x6264CF0", VA = "0x186265EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x6266430", Offset = "0x6265230", VA = "0x186266430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private HEJEKJPNGFL COFDFOKIOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private DNDAMAFFFKG HJDDMPFEAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private CJIBMGCPPCM EILPDJCOMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private DAOOKEHLCHM NBIOAIHOKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private PANHNKJODMC FKHGDOCKADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private BCMCIFBKNFK DFFDOCAOKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private CancellationTokenSource KELLIOIJNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private Task OFHDMDAGGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private TaskCompletionSource<int> EELDKLPIGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private int CHNPEFLMPDC;

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x62771C0", Offset = "0x6275FC0", VA = "0x1862771C0", Slot = "6")]
	public void OOCIGOIJKNJ(DNDAMAFFFKG HJDDMPFEAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x1B08AC0", Offset = "0x1B078C0", VA = "0x181B08AC0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x6276EB0", Offset = "0x6275CB0", VA = "0x186276EB0")]
	private void KAMLODGDKON(float MJMHHAHELIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x6277090", Offset = "0x6275E90", VA = "0x186277090", Slot = "4")]
	[AsyncStateMachine(typeof(FICCOMIMPHJ))]
	public Task<HNLJAOBELNP> OIJGANPFEML(JBIBDPPGHNE OEAGFPFKGKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x6276B00", Offset = "0x6275900", VA = "0x186276B00", Slot = "5")]
	[AsyncStateMachine(typeof(GLEJEBICOIL))]
	public Task HICKKPIJKJB([Optional] CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x1B08AC0", Offset = "0x1B078C0", VA = "0x181B08AC0")]
	public void LCBNMNLOLLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x6276BF0", Offset = "0x62759F0", VA = "0x186276BF0")]
	private KIGKLGHKCHM HJNAGGFDGIK(JBIBDPPGHNE OEAGFPFKGKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x6276A10", Offset = "0x6275810", VA = "0x186276A10")]
	[AsyncStateMachine(typeof(OBPHBPEHMLM))]
	private Task FADNIOFDIIC(EAHIPFGMIPN NGDHFFBLCOO, CancellationToken MGHJMBBEFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x6276F90", Offset = "0x6275D90", VA = "0x186276F90")]
	[AsyncStateMachine(typeof(POLFAGGNMKL))]
	private Task LFKNGBMCKGL(CancellationToken MGHJMBBEFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x6277600", Offset = "0x6276400", VA = "0x186277600")]
	[AsyncStateMachine(typeof(OKMOHAADFLK))]
	private Task PDPABLBEECE([Optional] CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x6276DC0", Offset = "0x6275BC0", VA = "0x186276DC0")]
	[AsyncStateMachine(typeof(GPMCIJPGNLA))]
	private Task HLOGAMAINBG(CancellationToken MGHJMBBEFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x62766F0", Offset = "0x62754F0", VA = "0x1862766F0")]
	[AsyncStateMachine(typeof(ANHEHACPOCA))]
	private Task CBDMBGMGFFA(CancellationToken HHMNNOCLOEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x6277370", Offset = "0x6276170", VA = "0x186277370")]
	private Task OPDNDMABGJK(KCBBPOFPKPE CCEKALLPEJN, CancellationToken MGHJMBBEFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x6276900", Offset = "0x6275700", VA = "0x186276900")]
	[AsyncStateMachine(typeof(BHJCDFCPOOJ))]
	private Task EJDKPIIBIHL(KCBBPOFPKPE CCEKALLPEJN, CancellationToken MGHJMBBEFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x62767F0", Offset = "0x62755F0", VA = "0x1862767F0")]
	private bool CEENHKAIGHK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public JACNKJENFEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
[UnityEngine.Scripting.Preserve]
internal class FLPGELCIHPK : JAEPFJOJMJK, GGAELEIAKGO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	private struct KDBKNPKMMAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public FLPGELCIHPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private EIIPDELDDBE<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x6278180", Offset = "0x6276F80", VA = "0x186278180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x62786E0", Offset = "0x62774E0", VA = "0x1862786E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	private EEEIAIDPIAO GMONNOHBADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	private DNDAMAFFFKG HJDDMPFEAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	private NKELGJIFBCJ PPIIKGKEPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private DAOOKEHLCHM NBIOAIHOKDB;

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x626EAF0", Offset = "0x626D8F0", VA = "0x18626EAF0", Slot = "6")]
	public void OOCIGOIJKNJ(DNDAMAFFFKG HJDDMPFEAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x626E9B0", Offset = "0x626D7B0", VA = "0x18626E9B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x626E850", Offset = "0x626D650", VA = "0x18626E850", Slot = "5")]
	[AsyncStateMachine(typeof(KDBKNPKMMAP))]
	public Task BMILLFPEILE(string GKNFKOKBKMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x626E950", Offset = "0x626D750", VA = "0x18626E950", Slot = "4")]
	public HNLJAOBELNP CEENHKAIGHK(GHMIEPPMENM DKANGFLOOAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x626EA00", Offset = "0x626D800", VA = "0x18626EA00")]
	private OBLFLMKPNAP HEJKJCILILH(string GKNFKOKBKMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
	public FLPGELCIHPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public static class LGNEOLKICPD
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x627B400", Offset = "0x627A200", VA = "0x18627B400")]
	public static void GADLBBAMLDF(OILPPPCALMB NFDHIFFHPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x627BA50", Offset = "0x627A850", VA = "0x18627BA50")]
	internal static void KBFOLALOBGE(OILPPPCALMB NFDHIFFHPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x627B320", Offset = "0x627A120", VA = "0x18627B320")]
	internal static void AOHEOMONDPF(OILPPPCALMB NFDHIFFHPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x627B600", Offset = "0x627A400", VA = "0x18627B600")]
	internal static void HFEBEIMENBH(OILPPPCALMB NFDHIFFHPGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
internal class GKIBKALOAJK : LBNEIFJJHHH<KPCIENPMIHC>
{
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class IMOIBJOJMIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public KPCIENPMIHC message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public IMOIBJOJMIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x62763A0", Offset = "0x62751A0", VA = "0x1862763A0")]
		internal object INMFOLJBFEL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public static readonly GKIBKALOAJK GOPCOAILBIE;

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x6270860", Offset = "0x626F660", VA = "0x186270860")]
	public ExitGames.Client.Photon.Hashtable GKMCGBDALGF(KPCIENPMIHC JIGBFCEILIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x62708F0", Offset = "0x626F6F0", VA = "0x1862708F0", Slot = "5")]
	protected override void HHBLCHKCDKB(KPCIENPMIHC JIGBFCEILIK, IDictionary<object, object> PFDMLBFKIAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x6270630", Offset = "0x626F430", VA = "0x186270630", Slot = "6")]
	public override KPCIENPMIHC EFHLMHLMFOG(IDictionary<object, object> PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x6270A20", Offset = "0x626F820", VA = "0x186270A20")]
	private static void NGLKBDEIIAD(string MFHIHFBGILP, KPCIENPMIHC JIGBFCEILIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x6270BD0", Offset = "0x626F9D0", VA = "0x186270BD0")]
	public GKIBKALOAJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x6270390", Offset = "0x626F190", VA = "0x186270390")]
	[CompilerGenerated]
	internal static string CEFDLIDNHHK(FGGFFJJDOJP JPGMJABDIAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C4")]
public static class CAIMBFLJBBE
{
	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public static HNLJAOBELNP NCAMNFFNLIA
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x6268750", Offset = "0x6267550", VA = "0x186268750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x62687B0", Offset = "0x62675B0", VA = "0x1862687B0")]
	public static bool EFHHJPLGMFI(this HNLJAOBELNP OMJALDHHOEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x62687D0", Offset = "0x62675D0", VA = "0x1862687D0")]
	public static HNLJAOBELNP KIPOMIJPMHA(FIIKENPCBCI PPPGELCICGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x6268A90", Offset = "0x6267890", VA = "0x186268A90")]
	public static HNLJAOBELNP PALAAIHEGFI(IEnumerable<HNLJAOBELNP> GCMHMFILDKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x6268830", Offset = "0x6267630", VA = "0x186268830")]
	public static string LKGMBOOAKNN(this HNLJAOBELNP EKOLPKLNMBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
public abstract class DJCJFNHKCEN : LIAHOJBLCMF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public delegate HNLJAOBELNP EKIBJJLLCCC([NotNull] GHMIEPPMENM BNIKFEPNCHD);

	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class HJINKPEHGLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public GHMIEPPMENM photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public HJINKPEHGLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x5AD9000", Offset = "0x5AD7E00", VA = "0x185AD9000")]
		internal HNLJAOBELNP HOHCPMGKEDA(EKIBJJLLCCC v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private bool GIDFIEECIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	protected readonly HashSet<EKIBJJLLCCC> LPKCFJJGJAH;

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x626AC40", Offset = "0x6269A40", VA = "0x18626AC40", Slot = "4")]
	public void MCDGPCAMKEJ(EKIBJJLLCCC LPOAHOKLILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x626ABE0", Offset = "0x62699E0", VA = "0x18626ABE0", Slot = "5")]
	public void LBCIKEKAAKO(EKIBJJLLCCC LPOAHOKLILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x626A8F0", Offset = "0x62696F0", VA = "0x18626A8F0", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x626A940", Offset = "0x6269740", VA = "0x18626A940")]
	protected HNLJAOBELNP EICIIBJAKMC(GHMIEPPMENM ODDGNEHIEGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x626ACA0", Offset = "0x6269AA0", VA = "0x18626ACA0")]
	protected DJCJFNHKCEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CA")]
public class DJPDNNOKAPI : DJCJFNHKCEN, BFNLIFGMJBO, LIAHOJBLCMF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class JOGFLABMAFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public HNLJAOBELNP result;

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public JOGFLABMAFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x6277A50", Offset = "0x6276850", VA = "0x186277A50")]
		internal object IIHODCGCFPG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x6266630", Offset = "0x6265430", VA = "0x186266630")]
	[UnityEngine.Scripting.Preserve]
	public DJPDNNOKAPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x626AD30", Offset = "0x6269B30", VA = "0x18626AD30", Slot = "8")]
	public HNLJAOBELNP IBOCNOFJMJP(GHMIEPPMENM ODDGNEHIEGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CC")]
public class BLMFNNEEMDC : DJCJFNHKCEN, EEEIAIDPIAO, LIAHOJBLCMF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private sealed class GMPHJBKIKEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public HNLJAOBELNP result;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public GMPHJBKIKEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x62713C0", Offset = "0x62701C0", VA = "0x1862713C0")]
		internal object EKKDEHLNBED()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x6266630", Offset = "0x6265430", VA = "0x186266630")]
	[UnityEngine.Scripting.Preserve]
	public BLMFNNEEMDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x6266520", Offset = "0x6265320", VA = "0x186266520", Slot = "8")]
	public HNLJAOBELNP CEENHKAIGHK(GHMIEPPMENM GMGHMLHOMNF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CE")]
internal static class IEAPAHKIGGK
{
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private sealed class DENJNHGGJBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public EIIPDELDDBE<string> timer;

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public DENJNHGGJBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x626A4F0", Offset = "0x62692F0", VA = "0x18626A4F0")]
		internal object FDPMEKCOIKD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x62747A0", Offset = "0x62735A0", VA = "0x1862747A0")]
	public static EIIPDELDDBE<string> IMAEMFBEOOH(GKFGDEJLFAD CGHEBMJOFGL, [Optional] string IFIHPGOBLHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x62746E0", Offset = "0x62734E0", VA = "0x1862746E0")]
	public static void GNMJONHIJNK(EIIPDELDDBE<string> JICPEFHJENB, GKFGDEJLFAD CGHEBMJOFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x6274880", Offset = "0x6273680", VA = "0x186274880")]
	public static string PMCNKOIJNAN(KPCIENPMIHC NOIOAJMKMIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D0")]
internal static class CHMKMFDOGHD
{
	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x6268E20", Offset = "0x6267C20", VA = "0x186268E20")]
	public static void PAHMFFCAJGL(this HEJEKJPNGFL COFDFOKIOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x6268E10", Offset = "0x6267C10", VA = "0x186268E10")]
	public static void INFOLDJNJFA(this HEJEKJPNGFL COFDFOKIOPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x6268CF0", Offset = "0x6267AF0", VA = "0x186268CF0")]
	private static void ILEDFGDGPCG(this HEJEKJPNGFL COFDFOKIOPK, bool CBDHMNPLJHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
public class BEBCJODFOHO : GHCFFFCCPAE, BLELPEGOKKC, JMDAMOBEHID, BMHKDAKICGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002ED")]
	private readonly BLELPEGOKKC GBMADNLJDJE;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public GHMIEPPMENM ICKPDINPLLD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x6265950", Offset = "0x6264750", VA = "0x186265950", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int BDCAOOMOBBH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x6265900", Offset = "0x6264700", VA = "0x186265900", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public int DCHGMEPNAOM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x62655C0", Offset = "0x62643C0", VA = "0x1862655C0", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public bool NKIKMACLCBG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x77D2F0", Offset = "0x77C0F0", VA = "0x18077D2F0", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public int FONCDJKLNHB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7DEC30", Offset = "0x7DDA30", VA = "0x1807DEC30", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event EOPPKIODIMF.FCAKINKLHOM JJBENDJDPML
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event GCAPAOHNDMB KFIPJGHALGD
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x62656F0", Offset = "0x62644F0", VA = "0x1862656F0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x62659A0", Offset = "0x62647A0", VA = "0x1862659A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event Action<bool> KMDAFAKJCDI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "17")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "18")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<GHMIEPPMENM> KBINCECGFOB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001D")]
	public event Action ECLPOEBMDLL
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x6265520", Offset = "0x6264320", VA = "0x186265520", Slot = "26")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x6265860", Offset = "0x6264660", VA = "0x186265860", Slot = "27")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0xBF4810", Offset = "0xBF3610", VA = "0x180BF4810")]
	public BEBCJODFOHO(BLELPEGOKKC GBMADNLJDJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x62657B0", Offset = "0x62645B0", VA = "0x1862657B0", Slot = "8")]
	public bool GDFFCGCNEDP(byte OPIMKOAPDOI, ExitGames.Client.Photon.Hashtable FFOIGEOGBJH, BDONCGAFLKA EBIOMDMHKBK, SendOptions HMBMMIMDAKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x6265610", Offset = "0x6264410", VA = "0x186265610", Slot = "16")]
	public GHMIEPPMENM CPCECHHEDNN(int COFHGJDOHCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "19")]
	public void BHIEEAFDEJE(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "20")]
	public void LPIKLCEODHH(object PFKLELGAJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "21")]
	public void GKLLCCIDMFN(object PFKLELGAJPH, bool DDKNJMGKMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6265A40", Offset = "0x6264840", VA = "0x186265A40", Slot = "22")]
	public IDisposable NFMKBKOKHKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370", Slot = "23")]
	private bool NAIMKPAEOMO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "24")]
	public void DNMKAONGKLJ(StringBuilder LPFHFPGIEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6265790", Offset = "0x6264590", VA = "0x186265790", Slot = "25")]
	public bool FIPALBKICAG(bool MKKCDFIJKDO, [Out] string OGJCCLJIEPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0xADBCA0", Offset = "0xADAAA0", VA = "0x180ADBCA0", Slot = "28")]
	public void OOIHKDCHMKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
internal struct KGIPDMDFFNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002EF")]
	private readonly IDictionary<object, object> EMJLGCDONIE;

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x7F19C0", Offset = "0x7F07C0", VA = "0x1807F19C0")]
	public KGIPDMDFFNI(IDictionary<object, object> EMJLGCDONIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x6278BB0", Offset = "0x62779B0", VA = "0x186278BB0")]
	public bool LMHKKJLOGMD([Out] KPCIENPMIHC JIGBFCEILIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6278C60", Offset = "0x6277A60", VA = "0x186278C60")]
	public Guid NJMJCPCDHKO()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x6278980", Offset = "0x6277780", VA = "0x186278980")]
	public HNLJAOBELNP DJOIBPMNHEO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x6278AC0", Offset = "0x62778C0", VA = "0x186278AC0")]
	public static ExitGames.Client.Photon.Hashtable HKJMJGOBNGA(KPCIENPMIHC JIGBFCEILIK, HNLJAOBELNP OMJALDHHOEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
internal static class MFHNJBGDDDP
{
	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x627C920", Offset = "0x627B720", VA = "0x18627C920")]
	public static bool JNHDCCCNBAH(this JCOMCEDKFBJ AFGDLPFNIII)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
internal struct JGMBHCBEGGL : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct KDHCFOKNEGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public JGMBHCBEGGL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x6278740", Offset = "0x6277540", VA = "0x186278740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x6278920", Offset = "0x6277720", VA = "0x186278920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F0")]
	private readonly CancellationTokenSource PEGEFBHNLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002F1")]
	private bool GIDFIEECIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002F2")]
	private Task CKLPGPGBFPF;

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool EHIDAKAHKBK
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x6277740", Offset = "0x6276540", VA = "0x186277740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x6277880", Offset = "0x6276680", VA = "0x186277880")]
	public JGMBHCBEGGL(CancellationToken BIBHFGFDEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x6277770", Offset = "0x6276570", VA = "0x186277770")]
	[AsyncStateMachine(typeof(KDHCFOKNEGL))]
	public Task MBAJHPMGBFA(Func<CancellationToken, List<Task>> IGLOPDDMDEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x62776F0", Offset = "0x62764F0", VA = "0x1862776F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D6")]
public readonly struct JPPPPEHKKAD<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct PMLCFODLOGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public AsyncTaskMethodBuilder<IHFDHMKEEAA<MPIDCENOJCB<TData>, EAGLHGKDHHG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public EIIPDELDDBE<string>.OABKDIIPOLN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public JPPPPEHKKAD<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private TaskAwaiter<IHFDHMKEEAA<byte[], EAGLHGKDHHG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x3E0C4E0", Offset = "0x3E0B2E0", VA = "0x183E0C4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x3E0D630", Offset = "0x3E0C430", VA = "0x183E0D630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F8")]
	private readonly IOCJEHKDFCC<TGetDataArg, TData> FCPNPAIPIMN;

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x7F19C0", Offset = "0x7F07C0", VA = "0x1807F19C0")]
	internal JPPPPEHKKAD(IOCJEHKDFCC<TGetDataArg, TData> NIPJNEHNMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x3846CA0", Offset = "0x3845AA0", VA = "0x183846CA0")]
	[AsyncStateMachine(typeof(JPPPPEHKKAD<, >.PMLCFODLOGL))]
	public Task<IHFDHMKEEAA<MPIDCENOJCB<TData>, EAGLHGKDHHG>> FCDPMLIICAN(TGetDataArg OFPCPIFKKJA, string AIAKOBNLNLA, EIIPDELDDBE<string>.OABKDIIPOLN JICPEFHJENB, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D8")]
public static class OCNPGFMCKBA
{
	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x21CDDA0", Offset = "0x21CCBA0", VA = "0x1821CDDA0")]
	public static JPPPPEHKKAD<TGetDataArg, TData> NPAOPBPEFCO<TGetDataArg, TData>(IOCJEHKDFCC<TGetDataArg, TData> NIPJNEHNMFI)
	{
		return default(JPPPPEHKKAD<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct FGBLHMLLBED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	public readonly int BILDFDPJPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	public readonly int? FJBBPHNDENJ;

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x391BE50", Offset = "0x391AC50", VA = "0x18391BE50")]
	public FGBLHMLLBED(int BNPNMCOOHLL, [Optional] int? APLNCJPPGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x626CE60", Offset = "0x626BC60", VA = "0x18626CE60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DA")]
public interface HOJCLKCINDB<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FOFEMJKADID();

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HOJCLKCINDB<T> NCMLMPFFAOK(string ABCGLPGDFPB);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HOJCLKCINDB<T> BMHNGIJJNLO(HOLAMKDOFFD<T> PNPBILCKBDN);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HOJCLKCINDB<T> PLEDFLGJIEC(int FGFBLJKGHIK);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HOJCLKCINDB<T> IAJPBJAIEBP(int FGFBLJKGHIK, HMMACFIKFDN<T> MNBJCDPPMLI);
}
[Cpp2IlInjected.Token(Token = "0x20000DB")]
public interface KKPLOELDIBK
{
	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HOJCLKCINDB<T> EBPHBDADOBC<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ELHKLLPCLJD EMMBEFFBCAC(Exception AOBBDNCEPBJ);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FGBLHMLLBED JJKNGMOILAH(Exception AOBBDNCEPBJ);
}
[Cpp2IlInjected.Token(Token = "0x20000DC")]
public delegate string HOLAMKDOFFD<in T>(T AOBBDNCEPBJ) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public delegate int HMMACFIKFDN<in T>(T AOBBDNCEPBJ) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal class KKHGBNFBBGD : KKPLOELDIBK
{
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	private delegate string NIHGMBEAEAK(Exception AOBBDNCEPBJ);

	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	private delegate int NJHLNEGMFCG(Exception AOBBDNCEPBJ);

	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	private class EOEHMEDLLLK<T> : HOJCLKCINDB<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private sealed class NOMLOMJHKCH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
			public NOMLOMJHKCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0x763950", Offset = "0x762750", VA = "0x180763950")]
			internal string HOHJFLPFNEK(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class OHPCMICIENJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			public HOLAMKDOFFD<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
			public OHPCMICIENJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0x3B28C60", Offset = "0x3B27A60", VA = "0x183B28C60")]
			internal string HPPIOJKGABL(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000E4")]
		[CompilerGenerated]
		private sealed class MHFLLKPMEPP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			public HMMACFIKFDN<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
			public MHFLLKPMEPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0x3B28C60", Offset = "0x3B27A60", VA = "0x183B28C60")]
			internal int KJNECCODGAA(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		private readonly KKHGBNFBBGD HJLGAHJBIEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private readonly Type PEGFOEDLDPC;

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x30835B0", Offset = "0x30823B0", VA = "0x1830835B0")]
		internal EOEHMEDLLLK(KKHGBNFBBGD HJLGAHJBIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x3083310", Offset = "0x3082110", VA = "0x183083310", Slot = "4")]
		public void FOFEMJKADID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x3083460", Offset = "0x3082260", VA = "0x183083460", Slot = "5")]
		public HOJCLKCINDB<T> NCMLMPFFAOK(string ABCGLPGDFPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x3083200", Offset = "0x3082000", VA = "0x183083200", Slot = "6")]
		public HOJCLKCINDB<T> BMHNGIJJNLO(HOLAMKDOFFD<T> PNPBILCKBDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x3083570", Offset = "0x3082370", VA = "0x183083570", Slot = "7")]
		public HOJCLKCINDB<T> PLEDFLGJIEC(int FGFBLJKGHIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x3083340", Offset = "0x3082140", VA = "0x183083340", Slot = "8")]
		public HOJCLKCINDB<T> IAJPBJAIEBP(int FGFBLJKGHIK, HMMACFIKFDN<T> MNBJCDPPMLI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	private class DGAGIIGFCFL<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private bool EDMGCIJDCHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private readonly List<Type> KAOFEOOFGBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private readonly Dictionary<Type, TVal> CFOFAPIPCPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private readonly Dictionary<Type, int> LMKFKDKMCMM;

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public IReadOnlyList<Type> BPOPDHMFJPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x4CD5160", Offset = "0x4CD3F60", VA = "0x184CD5160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x4CD5570", Offset = "0x4CD4370", VA = "0x184CD5570")]
		public DGAGIIGFCFL(Dictionary<Type, int> LMKFKDKMCMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x4CD5040", Offset = "0x4CD3E40", VA = "0x184CD5040")]
		public void AAFNAGDLNDC(Type JLDFGFPAIIN, TVal AACJDNHHIME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x4CD50E0", Offset = "0x4CD3EE0", VA = "0x184CD50E0")]
		public bool BBBNIOINKLD(Type PEGFOEDLDPC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x4CD5120", Offset = "0x4CD3F20", VA = "0x184CD5120")]
		public bool BKIDPMGAKIE(TVal GNLEHBFFNFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x4CD5420", Offset = "0x4CD4220", VA = "0x184CD5420")]
		public TVal OMJIHOMPBMI(Type PEMNIEMPPLO)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x4CD52E0", Offset = "0x4CD40E0", VA = "0x184CD52E0")]
		[CompilerGenerated]
		private int DJBPLBMCBML(Type LNGJDBFGPHC, Type IOMJJFGHGFB)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class KOMHCDDPMCC : IEnumerable<FGBLHMLLBED>, IEnumerable, IEnumerator<FGBLHMLLBED>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private FGBLHMLLBED <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public KKHGBNFBBGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private IEnumerator<FGBLHMLLBED> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		private FGBLHMLLBED System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x30DFE80", Offset = "0x30DEC80", VA = "0x1830DFE80", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(FGBLHMLLBED);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0x627AB10", Offset = "0x6279910", VA = "0x18627AB10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x863A90", Offset = "0x862890", VA = "0x180863A90")]
		[DebuggerHidden]
		public KOMHCDDPMCC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x627AB60", Offset = "0x6279960", VA = "0x18627AB60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x627A500", Offset = "0x6279300", VA = "0x18627A500", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x627A4B0", Offset = "0x62792B0", VA = "0x18627A4B0")]
		private void MPOCHKHBDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x627A9B0", Offset = "0x62797B0", VA = "0x18627A9B0")]
		private void NPKEOFGCBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x627AAC0", Offset = "0x62798C0", VA = "0x18627AAC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x627AA00", Offset = "0x6279800", VA = "0x18627AA00", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<FGBLHMLLBED> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x627AA00", Offset = "0x6279800", VA = "0x18627AA00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000305")]
	private static readonly FGBLHMLLBED JEABLNKJDGD;

	[Cpp2IlInjected.Token(Token = "0x4000306")]
	private static readonly Dictionary<Type, int> GCIAHFEDOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000307")]
	private readonly HashSet<Type> KHHPKFGIHFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000308")]
	private readonly DGAGIIGFCFL<int> PFENHDGCLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000309")]
	private readonly DGAGIIGFCFL<NJHLNEGMFCG> EOLBCKNFHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400030A")]
	private readonly DGAGIIGFCFL<NIHGMBEAEAK> PKIJJOLPNNI;

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x6279FD0", Offset = "0x6278DD0", VA = "0x186279FD0")]
	[GAPOPKHLLNB(OGJCEJIMIKL.GameOnly)]
	private static void NHJLANHPGEE(OILPPPCALMB IDMCGGBGLJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x627A110", Offset = "0x6278F10", VA = "0x18627A110")]
	[RecRoom.NoEngine.Common.Preserve]
	public KKHGBNFBBGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x216A7F0", Offset = "0x21695F0", VA = "0x18216A7F0", Slot = "4")]
	public HOJCLKCINDB<T> EBPHBDADOBC<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x62796A0", Offset = "0x62784A0", VA = "0x1862796A0", Slot = "5")]
	public ELHKLLPCLJD EMMBEFFBCAC(Exception AOBBDNCEPBJ)
	{
		return default(ELHKLLPCLJD);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x6279BA0", Offset = "0x62789A0", VA = "0x186279BA0", Slot = "6")]
	public FGBLHMLLBED JJKNGMOILAH(Exception? AOBBDNCEPBJ)
	{
		return default(FGBLHMLLBED);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x62798B0", Offset = "0x62786B0", VA = "0x1862798B0", Slot = "7")]
	[IteratorStateMachine(typeof(KOMHCDDPMCC))]
	public IEnumerable<FGBLHMLLBED> HHKEEHKBNCI(Exception AOBBDNCEPBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x6279E80", Offset = "0x6278C80", VA = "0x186279E80", Slot = "8")]
	public string LHFDNMOFCCF(Exception? AOBBDNCEPBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x6279390", Offset = "0x6278190", VA = "0x186279390")]
	private string DOBKKCACGIN(AggregateException FMCGEGIIKMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x6278D10", Offset = "0x6277B10", VA = "0x186278D10")]
	private void ALJMEFKCCLF(Type PEGFOEDLDPC, int FGFBLJKGHIK, NJHLNEGMFCG? LEJEJDFIHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x6279950", Offset = "0x6278750", VA = "0x186279950")]
	private void JBLCJHLANLF(Type PEGFOEDLDPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x62790C0", Offset = "0x6277EC0", VA = "0x1862790C0")]
	private void CCNMBLNENCD(Type PEGFOEDLDPC, NIHGMBEAEAK FICEEAFFNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x6279730", Offset = "0x6278530", VA = "0x186279730")]
	private static int GPHIMHKJNIF(Type PEGFOEDLDPC, Dictionary<Type, int> LMKFKDKMCMM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x24007F0", Offset = "0x23FF5F0", VA = "0x1824007F0")]
	private static bool INMOFDNAFNO<TVal>(DGAGIIGFCFL<TVal> HJOJMOBKMOL, Type PEGFOEDLDPC, [Out] TVal GNLEHBFFNFG) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x6279DA0", Offset = "0x6278BA0", VA = "0x186279DA0")]
	[CompilerGenerated]
	internal static int KAEHCBEFOJP(Type MDDPANIKIEJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
public struct ELHKLLPCLJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400031F")]
	public readonly FGBLHMLLBED NDDLFGNFFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000320")]
	public readonly string CAMBEFPFDNM;

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x626C780", Offset = "0x626B580", VA = "0x18626C780")]
	public ELHKLLPCLJD(string AJGIMJIEPPI, FGBLHMLLBED FGFBLJKGHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x626C6E0", Offset = "0x626B4E0", VA = "0x18626C6E0")]
	public string GKINKFPPDHF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public class FNIHCJMFGHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000321")]
	private readonly AABBEAPGIEF PECGDNIAKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000322")]
	private string MBLICFAOJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000323")]
	private long? AHGMNNJAKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	private long? NFCNNKGCEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private long? NDIALEFJNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000326")]
	private string DEPBJDBMFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000327")]
	private FEDLCPADLNP IMGJLMCCFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000328")]
	private long? AJPEJLNNOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000329")]
	private bool CCHMAMNGBHG;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public string COJPMNKPOEO
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public long LCIJFIFHHJD
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x626F420", Offset = "0x626E220", VA = "0x18626F420")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public long DHIEMMMCPEC
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x626F800", Offset = "0x626E600", VA = "0x18626F800")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public long HMDMICLJDKP
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x626EE50", Offset = "0x626DC50", VA = "0x18626EE50")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public string BNMIFOLHKHI
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x626F340", Offset = "0x626E140", VA = "0x18626F340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public FEDLCPADLNP APPGFEAEBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xEB7870", Offset = "0xEB6670", VA = "0x180EB7870")]
		get
		{
			return default(FEDLCPADLNP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x626F860", Offset = "0x626E660", VA = "0x18626F860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public long ALHGHBPLBDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x626FBA0", Offset = "0x626E9A0", VA = "0x18626FBA0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x626FC00", Offset = "0x626EA00", VA = "0x18626FC00")]
	[UnityEngine.Scripting.Preserve]
	public FNIHCJMFGHB([NMBHAKGIBHG(null)] AABBEAPGIEF PECGDNIAKCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x626F950", Offset = "0x626E750", VA = "0x18626F950")]
	private void PDPHAAJGHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x626EEB0", Offset = "0x626DCB0", VA = "0x18626EEB0")]
	public void BEHNLOJHHHE(long NGLNDFKLBFL, long OBPCIAFLNJK, [Optional] long? KIPHFANLMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x626F380", Offset = "0x626E180", VA = "0x18626F380")]
	public void CGBFNEEDIPP(long KIPHFANLMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x626EDD0", Offset = "0x626DBD0", VA = "0x18626EDD0")]
	public void AHHEIBIHBHF(string MKGIAHCNGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x626F480", Offset = "0x626E280", VA = "0x18626F480")]
	public void HGMKAKPHANC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal class ODJJEDEFBFH : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private struct LFPFDGOOOCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public AsyncTaskMethodBuilder<KPCIENPMIHC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public KPCIENPMIHC roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public ODJJEDEFBFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private TaskAwaiter<AKMHPCJDBNK.JFNIPFDFNBO<KPCIENPMIHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x627ACB0", Offset = "0x6279AB0", VA = "0x18627ACB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x627B1E0", Offset = "0x6279FE0", VA = "0x18627B1E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private struct GPFDKELNCEH<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private sealed class AEKCBPHBJLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public KPCIENPMIHC roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public AEKCBPHBJLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x6263D20", Offset = "0x6262B20", VA = "0x186263D20")]
		internal KPCIENPMIHC GOFFEIIIJNP(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private struct OKKIDMCDBDH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public AsyncTaskMethodBuilder<AKMHPCJDBNK.JFNIPFDFNBO<KPCIENPMIHC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public KPCIENPMIHC roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public ODJJEDEFBFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private GPLKLOFLLGK <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private TaskAwaiter<AKMHPCJDBNK.JFNIPFDFNBO<KPCIENPMIHC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x62804E0", Offset = "0x627F2E0", VA = "0x1862804E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x6280AF0", Offset = "0x627F8F0", VA = "0x186280AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private struct GDMOPLIAEOL<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public ODJJEDEFBFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x34A0030", Offset = "0x349EE30", VA = "0x1834A0030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x3040730", Offset = "0x303F530", VA = "0x183040730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private struct NBJPJEELOJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public ODJJEDEFBFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x627D450", Offset = "0x627C250", VA = "0x18627D450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0x627D610", Offset = "0x627C410", VA = "0x18627D610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class HAPLDINAAOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public HAPLDINAAOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x6271BA0", Offset = "0x62709A0", VA = "0x186271BA0")]
		internal object BOMJJGNDDNK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x6271C00", Offset = "0x6270A00", VA = "0x186271C00")]
		internal bool CFGGNBMPNIB(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class PCMBFIGELAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public PCMBFIGELAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x6282270", Offset = "0x6281070", VA = "0x186282270")]
		internal object HMNEJHIMOPC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class KBKBLIMJFGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public KBKBLIMJFGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x6277AB0", Offset = "0x62768B0", VA = "0x186277AB0")]
		internal object JFBJGEEMFDE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private sealed class NEEOJMAIPNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public NEEOJMAIPNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x627DC70", Offset = "0x627CA70", VA = "0x18627DC70")]
		internal object FPCCHJPILKP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class EFADMPFCKIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public ODJJEDEFBFH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public EFADMPFCKIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x626AF50", Offset = "0x6269D50", VA = "0x18626AF50")]
		internal object INMFOLJBFEL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400032A")]
	private static readonly Guid LKIHDGCCCAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400032B")]
	public readonly GCAFIKPGAJD CNNLFMBEMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400032C")]
	private readonly AKMHPCJDBNK BPPKFBOOLGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400032D")]
	private readonly JMDAMOBEHID COFDFOKIOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400032E")]
	private readonly BMHKDAKICGN PFJPKMHFMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400032F")]
	private bool FIFPICCNJDB;

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x627F360", Offset = "0x627E160", VA = "0x18627F360")]
	public ODJJEDEFBFH(GCAFIKPGAJD ALJMPBCMDJC, AKMHPCJDBNK BPPKFBOOLGO, JMDAMOBEHID COFDFOKIOPK, BMHKDAKICGN PFJPKMHFMGA, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x627E350", Offset = "0x627D150", VA = "0x18627E350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x627E350", Offset = "0x627D150", VA = "0x18627E350")]
	public void BDNIPIPAHCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x627E290", Offset = "0x627D090", VA = "0x18627E290")]
	public void BBKNMHCHKPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x627E760", Offset = "0x627D560", VA = "0x18627E760")]
	public void FHKNAJILBGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x627EEC0", Offset = "0x627DCC0", VA = "0x18627EEC0")]
	[AsyncStateMachine(typeof(LFPFDGOOOCN))]
	internal Task<KPCIENPMIHC> MBDIGJLDJIG(EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, KPCIENPMIHC NOIOAJMKMIN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x24EE1A0", Offset = "0x24ECFA0", VA = "0x1824EE1A0")]
	private static byte[] FGLBOFBDJOE<T>(T JIGBFCEILIK) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x24EDDA0", Offset = "0x24ECBA0", VA = "0x1824EDDA0")]
	private static T BMKKNIOELCP<T>(MessageParser<T> KOGBNEPJFKP, byte[] JIGBFCEILIK, T AMKLAEEOILO) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x627F020", Offset = "0x627DE20", VA = "0x18627F020")]
	[AsyncStateMachine(typeof(OKKIDMCDBDH))]
	private Task<AKMHPCJDBNK.JFNIPFDFNBO<KPCIENPMIHC>> MBOCGCAFEBH(KPCIENPMIHC NOIOAJMKMIN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x24EE1B0", Offset = "0x24ECFB0", VA = "0x1824EE1B0")]
	[AsyncStateMachine(typeof(GDMOPLIAEOL<>))]
	internal Task<T> GOIBBALHHKB<T>(CancellationToken MGHJMBBEFKK, Func<CancellationToken, Task<T>> KCKELDDMPBI, int JFKNEPNMAAH = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x627E820", Offset = "0x627D620", VA = "0x18627E820")]
	[AsyncStateMachine(typeof(NBJPJEELOJJ))]
	internal Task GOIBBALHHKB(CancellationToken MGHJMBBEFKK, Func<CancellationToken, Task> KCKELDDMPBI, int JFKNEPNMAAH = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x627E950", Offset = "0x627D750", VA = "0x18627E950")]
	public PGOPLLHDMBJ IOCLIDNKNAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0x627F270", Offset = "0x627E070", VA = "0x18627F270")]
	public ONNAFPNGIEA PECKMIMMCOB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x627EAE0", Offset = "0x627D8E0", VA = "0x18627EAE0")]
	public DIDCBHHLALC JGAFDHLJCME([Optional] GKFGDEJLFAD? CGHEBMJOFGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x627E5B0", Offset = "0x627D3B0", VA = "0x18627E5B0")]
	public void BIBFDNAKKHF(Func<Guid, bool> EOHAADJKLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x627EDB0", Offset = "0x627DBB0", VA = "0x18627EDB0")]
	public void LHPGJIJKOAD(Func<Guid, bool> ONJEMKGDFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x627EC30", Offset = "0x627DA30", VA = "0x18627EC30")]
	public Guid KAPGDGIKDGM()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0x627E9D0", Offset = "0x627D7D0", VA = "0x18627E9D0")]
	public void IPEHJCIAGLA(Guid KJFPPNCBOFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x627E470", Offset = "0x627D270", VA = "0x18627E470")]
	public void BGPNPODIOEB(KPCIENPMIHC MGDEAMKKEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x627F160", Offset = "0x627DF60", VA = "0x18627F160")]
	public void NGLKBDEIIAD(string LDAFBGAJAGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x24EE430", Offset = "0x24ED230", VA = "0x1824EE430")]
	private T OLEEJBGIBGJ<T>(T GNLEHBFFNFG) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x627E710", Offset = "0x627D510", VA = "0x18627E710")]
	public void BMIDIONPHMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x24EDEF0", Offset = "0x24ECCF0", VA = "0x1824EDEF0")]
	[CompilerGenerated]
	internal static string ENFCMMGGECF<T>(byte[] AFIEJCAINEM, int GFGPAGHIAOJ, GPFDKELNCEH<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
internal sealed class NAKEMNDPKOA : GCAFIKPGAJD
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class BOJFMHFMEIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public BOJFMHFMEIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x6284EC0", Offset = "0x6283CC0", VA = "0x186284EC0")]
		internal object ALHPMIMOIKG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private struct GMNDOCFJKEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public NAKEMNDPKOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public ODJJEDEFBFH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private EAKMPIGGJPJ <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private ONNAFPNGIEA <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x628F100", Offset = "0x628DF00", VA = "0x18628F100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x628F880", Offset = "0x628E680", VA = "0x18628F880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct JLNJIGCEPPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public NAKEMNDPKOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private bool <omIsEnabled>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private TaskAwaiter<OABHNCNHAAJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private TaskAwaiter<byte> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x62927E0", Offset = "0x62915E0", VA = "0x1862927E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x6292D60", Offset = "0x6291B60", VA = "0x186292D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[CompilerGenerated]
	private struct OABGGPNIPOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		public AsyncTaskMethodBuilder<byte> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		public NAKEMNDPKOA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private TaskAwaiter<GBFOHGAHICD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x6296760", Offset = "0x6295560", VA = "0x186296760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x6296A80", Offset = "0x6295880", VA = "0x186296A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[CompilerGenerated]
	private sealed class FHKHLKPPFOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public EAKMPIGGJPJ presence;

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public FHKHLKPPFOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x628A670", Offset = "0x6289470", VA = "0x18628A670")]
		internal object MFPJKICNIFC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400035A")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x400035B")]
	private static readonly GKFGDEJLFAD ADMHBJMMGLG;

	[Cpp2IlInjected.Token(Token = "0x400035C")]
	private static readonly GKFGDEJLFAD FCGNKOAMJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400035D")]
	private readonly FGGFFJJDOJP AEIDKAPOCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private readonly JCOMCEDKFBJ IKHBPKDFHBA;

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x627D2C0", Offset = "0x627C0C0", VA = "0x18627D2C0")]
	public NAKEMNDPKOA(FGGFFJJDOJP AEIDKAPOCOA, JCOMCEDKFBJ IKHBPKDFHBA, Guid HMFDPJCPEKL, DNDAMAFFFKG HJDDMPFEAJK, JNFCFFOONNK EODJCONFFOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x627D0A0", Offset = "0x627BEA0", VA = "0x18627D0A0", Slot = "7")]
	[AsyncStateMachine(typeof(GMNDOCFJKEB))]
	protected override Task NEHHFAKGFHI(ODJJEDEFBFH HFIAFEMCIEL, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x627CFA0", Offset = "0x627BDA0", VA = "0x18627CFA0")]
	[AsyncStateMachine(typeof(JLNJIGCEPPB))]
	private Task ICBCKMIIPHK(CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x627CE90", Offset = "0x627BC90", VA = "0x18627CE90")]
	[AsyncStateMachine(typeof(OABGGPNIPOF))]
	private Task<byte> HNMFCEHJIPH(CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0x627CCB0", Offset = "0x627BAB0", VA = "0x18627CCB0")]
	private EAKMPIGGJPJ HCFJKACEKMG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class KIGKLGHKCHM : GCAFIKPGAJD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private struct CDBOIKGBJLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public KIGKLGHKCHM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public ODJJEDEFBFH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private TaskAwaiter<EDLOAKHJMNO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x62870D0", Offset = "0x6285ED0", VA = "0x1862870D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x6287AA0", Offset = "0x62868A0", VA = "0x186287AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000378")]
	private readonly int CMKJINIPOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000379")]
	private readonly JBIBDPPGHNE KEFDGELDJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400037A")]
	public readonly long DLEPBJODBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400037B")]
	public readonly long CDNBNKDCICL;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public EDLOAKHJMNO DOOLPEKODLN
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x76FCA0", Offset = "0x76EAA0", VA = "0x18076FCA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x76FCB0", Offset = "0x76EAB0", VA = "0x18076FCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x6294A10", Offset = "0x6293810", VA = "0x186294A10")]
	public KIGKLGHKCHM(Guid HMFDPJCPEKL, DNDAMAFFFKG HJDDMPFEAJK, JNFCFFOONNK EODJCONFFOK, int CMKJINIPOOJ, JBIBDPPGHNE KEFDGELDJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0x62948F0", Offset = "0x62936F0", VA = "0x1862948F0", Slot = "7")]
	[AsyncStateMachine(typeof(CDBOIKGBJLK))]
	protected override Task NEHHFAKGFHI(ODJJEDEFBFH HFIAFEMCIEL, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000100")]
internal abstract class KBIMPFGLKAK : GCAFIKPGAJD
{
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private sealed class DMKMAJLGFLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public KBIMPFGLKAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public BCBGBPJIIPL playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public DMKMAJLGFLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x62886E0", Offset = "0x62874E0", VA = "0x1862886E0")]
		internal Task OCGGGMNMCLL(EIIPDELDDBE<string>.OABKDIIPOLN postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x6288720", Offset = "0x6287520", VA = "0x186288720")]
		internal object PKFLIPCKKBC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[CompilerGenerated]
	private struct JPCCJAAGMHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public KBIMPFGLKAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public ODJJEDEFBFH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private DMKMAJLGFLK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x6292F10", Offset = "0x6291D10", VA = "0x186292F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x62936D0", Offset = "0x62924D0", VA = "0x1862936D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	[CompilerGenerated]
	private struct BPIEGIGNOCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public EIIPDELDDBE<string>.OABKDIIPOLN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public BCBGBPJIIPL playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public KBIMPFGLKAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x6284F30", Offset = "0x6283D30", VA = "0x186284F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x62854C0", Offset = "0x62842C0", VA = "0x1862854C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x6293C50", Offset = "0x6292A50", VA = "0x186293C50")]
	public KBIMPFGLKAK(Guid HMFDPJCPEKL, DNDAMAFFFKG HJDDMPFEAJK, JNFCFFOONNK EODJCONFFOK, string CNPHOFOCEMG, EDHHCKCKEHJ LANJILPEPCC, bool CMIJGLPJLNK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x62939D0", Offset = "0x62927D0", VA = "0x1862939D0", Slot = "7")]
	[AsyncStateMachine(typeof(JPCCJAAGMHO))]
	protected override Task NEHHFAKGFHI(ODJJEDEFBFH HFIAFEMCIEL, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task ANFAACIFGFJ(ODJJEDEFBFH HFIAFEMCIEL, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x6293B10", Offset = "0x6292910", VA = "0x186293B10")]
	[AsyncStateMachine(typeof(BPIEGIGNOCF))]
	private Task OPAKPOPCLLM(IDisposable FLJPBDENHOO, BCBGBPJIIPL HLMIEOALIKJ, EIIPDELDDBE<string>.OABKDIIPOLN JICPEFHJENB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000104")]
internal class KBCJEAJCHPM : GCAFIKPGAJD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	[CompilerGenerated]
	private struct FCLCJGHNCLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public KBCJEAJCHPM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public ODJJEDEFBFH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private TaskAwaiter<CCPPDIFNJBM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x6289F10", Offset = "0x6288D10", VA = "0x186289F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x628A480", Offset = "0x6289280", VA = "0x18628A480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000399")]
	private readonly KCBBPOFPKPE CCEKALLPEJN;

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6293930", Offset = "0x6292730", VA = "0x186293930")]
	public KBCJEAJCHPM(Guid HMFDPJCPEKL, DNDAMAFFFKG HJDDMPFEAJK, JNFCFFOONNK EODJCONFFOK, KCBBPOFPKPE CCEKALLPEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0x6293730", Offset = "0x6292530", VA = "0x186293730", Slot = "6")]
	protected override string AOHMFKDEBPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x6293810", Offset = "0x6292610", VA = "0x186293810", Slot = "7")]
	[AsyncStateMachine(typeof(FCLCJGHNCLL))]
	protected override Task NEHHFAKGFHI(ODJJEDEFBFH HFIAFEMCIEL, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
internal abstract class GCAFIKPGAJD : HMFMDANJGDM
{
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public delegate Task JLPLJJKHAHJ(EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[CompilerGenerated]
	private sealed class LFAANPFLMEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public EIIPDELDDBE<string>.OABKDIIPOLN operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public GCAFIKPGAJD <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000495")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public LFAANPFLMEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x6294E40", Offset = "0x6293C40", VA = "0x186294E40")]
		internal Task JBPJCLDKCMP(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[CompilerGenerated]
	private sealed class DEPJPJNGNKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public LFAANPFLMEG CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public DEPJPJNGNKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x6288620", Offset = "0x6287420", VA = "0x186288620")]
		internal object OBAANIGNJLA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000499")]
		[Cpp2IlInjected.Address(RVA = "0x6288560", Offset = "0x6287360", VA = "0x186288560")]
		internal object BELEHCDICKK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010A")]
	[CompilerGenerated]
	private struct FPGHAHMGHPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public GCAFIKPGAJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public Func<GCAFIKPGAJD, EIIPDELDDBE<string>.OABKDIIPOLN, ODJJEDEFBFH> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private LFAANPFLMEG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private ODJJEDEFBFH <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private TaskAwaiter<KPCIENPMIHC> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600049A")]
		[Cpp2IlInjected.Address(RVA = "0x628BBF0", Offset = "0x628A9F0", VA = "0x18628BBF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x628CCF0", Offset = "0x628BAF0", VA = "0x18628CCF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct NEKOFPDGHNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public GCAFIKPGAJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x6295CD0", Offset = "0x6294AD0", VA = "0x186295CD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x6296030", Offset = "0x6294E30", VA = "0x186296030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A2")]
	public readonly Guid PADBNNKLAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003A3")]
	public readonly ByteString MMHKMDKCPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003A4")]
	public readonly JNFCFFOONNK ILLACBIGOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003A5")]
	protected readonly string HOIEMLFOBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40003A6")]
	private readonly DNDAMAFFFKG HJDDMPFEAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003A7")]
	private readonly bool CMIJGLPJLNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40003A8")]
	private readonly Queue<JLPLJJKHAHJ> IIIBLJIKGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	private readonly EAEGPJJOHKN GBINLHFOGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003AA")]
	private readonly EDHHCKCKEHJ LANJILPEPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40003AB")]
	private bool NOBHHHOEAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003AC")]
	public FEDLCPADLNP AKHLIDCKMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40003AD")]
	public FEDLCPADLNP LFPDFCMAFKM;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public DNDAMAFFFKG DGENPFONCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x768560", Offset = "0x767360", VA = "0x180768560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public CJIBMGCPPCM FHMIKKFADBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x628D240", Offset = "0x628C040", VA = "0x18628D240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public LKGIKKGGCBC PAFFJGKLBKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x628D290", Offset = "0x628C090", VA = "0x18628D290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public GHGDBFAHECB KOBHDJCOPLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x628D2E0", Offset = "0x628C0E0", VA = "0x18628D2E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001E")]
	public event ALOCECILKMC HOIIKOIHLKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x628CF90", Offset = "0x628BD90", VA = "0x18628CF90", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x628CD90", Offset = "0x628BB90", VA = "0x18628CD90", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x628D590", Offset = "0x628C390", VA = "0x18628D590")]
	protected GCAFIKPGAJD(Guid HMFDPJCPEKL, DNDAMAFFFKG HJDDMPFEAJK, JNFCFFOONNK EODJCONFFOK, string CNPHOFOCEMG, EDHHCKCKEHJ LANJILPEPCC, bool CMIJGLPJLNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0x628CD50", Offset = "0x628BB50", VA = "0x18628CD50", Slot = "6")]
	protected virtual string AOHMFKDEBPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0x628D530", Offset = "0x628C330", VA = "0x18628D530")]
	public void PMMDKNMHOLO(JLPLJJKHAHJ GGJHJJNMJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x628D100", Offset = "0x628BF00", VA = "0x18628D100")]
	protected void IKKDFJPDMNM(float DPGDANDOGFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x628D3E0", Offset = "0x628C1E0", VA = "0x18628D3E0")]
	[AsyncStateMachine(typeof(FPGHAHMGHPL))]
	public Task ODBEBJNFCLL(CancellationToken BIBHFGFDEGJ, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, [Optional] Func<GCAFIKPGAJD, EIIPDELDDBE<string>.OABKDIIPOLN, ODJJEDEFBFH> MKJAJIHOLAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x628CFB0", Offset = "0x628BDB0", VA = "0x18628CFB0")]
	private void IJPIIOEDAAC(bool BPGAINDNDCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x628CEA0", Offset = "0x628BCA0", VA = "0x18628CEA0")]
	private void FGFJBIACKDO(ODJJEDEFBFH HFIAFEMCIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task NEHHFAKGFHI(ODJJEDEFBFH HFIAFEMCIEL, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ);

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x628D120", Offset = "0x628BF20", VA = "0x18628D120")]
	[AsyncStateMachine(typeof(NEKOFPDGHNH))]
	private Task JCOLCFDLALM(EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x628D360", Offset = "0x628C160", VA = "0x18628D360")]
	public KPCIENPMIHC OBLOJDDIIAE(GPLKLOFLLGK DKMOIKLHBBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x628CDB0", Offset = "0x628BBB0", VA = "0x18628CDB0")]
	[CompilerGenerated]
	private Task EKPHICDHGJB(CancellationToken MOEPCGBEMKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010C")]
internal sealed class CFJLHLAIOGI : KBIMPFGLKAK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	[CompilerGenerated]
	private struct KHJAJALCNGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public CFJLHLAIOGI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public ODJJEDEFBFH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private MDPBNPLCIHC <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private ONNAFPNGIEA <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x6294120", Offset = "0x6292F20", VA = "0x186294120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x6294890", Offset = "0x6293690", VA = "0x186294890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	private readonly FGGFFJJDOJP MFHLDMNNMII;

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0x6287C50", Offset = "0x6286A50", VA = "0x186287C50")]
	public CFJLHLAIOGI(Guid HMFDPJCPEKL, DNDAMAFFFKG HJDDMPFEAJK, FGGFFJJDOJP MFHLDMNNMII, JNFCFFOONNK EODJCONFFOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0x6287B00", Offset = "0x6286900", VA = "0x186287B00", Slot = "8")]
	[AsyncStateMachine(typeof(KHJAJALCNGO))]
	protected override Task ANFAACIFGFJ(ODJJEDEFBFH HFIAFEMCIEL, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200010E")]
internal class OBLFLMKPNAP : GCAFIKPGAJD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct CKPBKFFIEGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public OBLFLMKPNAP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public ODJJEDEFBFH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private TaskAwaiter<CCPPDIFNJBM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x6287D00", Offset = "0x6286B00", VA = "0x186287D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x62880B0", Offset = "0x6286EB0", VA = "0x1862880B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003CE")]
	private readonly string CPBCFDOLGJK;

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x6297260", Offset = "0x6296060", VA = "0x186297260")]
	public OBLFLMKPNAP(Guid HMFDPJCPEKL, DNDAMAFFFKG HJDDMPFEAJK, JNFCFFOONNK EODJCONFFOK, string CPBCFDOLGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x6297150", Offset = "0x6295F50", VA = "0x186297150", Slot = "7")]
	[AsyncStateMachine(typeof(CKPBKFFIEGO))]
	protected override Task NEHHFAKGFHI(ODJJEDEFBFH HFIAFEMCIEL, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
internal class BIAMNHFLAAG : KBIMPFGLKAK
{
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private sealed class NGILDLHKJME
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000112")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public AsyncTaskMethodBuilder<KPCIENPMIHC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public NGILDLHKJME <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			private TaskAwaiter<CCPPDIFNJBM> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			private TaskAwaiter<KPCIENPMIHC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x629CA60", Offset = "0x629B860", VA = "0x18629CA60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x629CF20", Offset = "0x629BD20", VA = "0x18629CF20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public BIAMNHFLAAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public DIDCBHHLALC serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public LGCKKPDPBBM roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public PGOPLLHDMBJ uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public PPGCPHJKJOD roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public NGILDLHKJME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x6296090", Offset = "0x6294E90", VA = "0x186296090")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<KPCIENPMIHC> ONKIMGCCPJM(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct GCIBLECPILC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public BIAMNHFLAAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public ODJJEDEFBFH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private NGILDLHKJME <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private MDPBNPLCIHC <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private ONNAFPNGIEA <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private TaskAwaiter<KPCIENPMIHC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x628D6F0", Offset = "0x628C4F0", VA = "0x18628D6F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x628E590", Offset = "0x628D390", VA = "0x18628E590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003D5")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private static readonly GKFGDEJLFAD ADMHBJMMGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private readonly int KGBEDEDLIBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003D8")]
	[CanBeNull]
	private readonly LEMPGINLPKF GNMNCHGMMOK;

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x6284E10", Offset = "0x6283C10", VA = "0x186284E10")]
	public BIAMNHFLAAG(Guid HMFDPJCPEKL, DNDAMAFFFKG HJDDMPFEAJK, int KGBEDEDLIBF, LEMPGINLPKF GNMNCHGMMOK, JNFCFFOONNK EODJCONFFOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x6284950", Offset = "0x6283750", VA = "0x186284950", Slot = "8")]
	[AsyncStateMachine(typeof(GCIBLECPILC))]
	protected override Task ANFAACIFGFJ(ODJJEDEFBFH HFIAFEMCIEL, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x6284A90", Offset = "0x6283890", VA = "0x186284A90")]
	private void LAPBEDEIBOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x6284B90", Offset = "0x6283990", VA = "0x186284B90")]
	private void NPFCDJFHLPL(EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, MDPBNPLCIHC HAPHPPAHEDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000114")]
internal abstract class FBAAFAMKBFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003F2")]
	public readonly GCAFIKPGAJD CNNLFMBEMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003F3")]
	public readonly ODJJEDEFBFH BKDJDPDNHOI;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public CJIBMGCPPCM FHMIKKFADBO
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x6289240", Offset = "0x6288040", VA = "0x186289240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public GHGDBFAHECB KOBHDJCOPLN
	{
		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x6289290", Offset = "0x6288090", VA = "0x186289290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x6289340", Offset = "0x6288140", VA = "0x186289340")]
	protected FBAAFAMKBFA(ODJJEDEFBFH HFIAFEMCIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x6289320", Offset = "0x6288120", VA = "0x186289320")]
	protected void NGLKBDEIIAD(string LDAFBGAJAGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
internal struct JBAAJPLDHKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003F4")]
	public Dictionary<Guid, List<GOOGEMJEJCB>> JGAIANFFMCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003F5")]
	public Dictionary<Guid, List<GOOGEMJEJCB>> BKMCEBIKFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003F6")]
	public Dictionary<Guid, List<GOOGEMJEJCB>> MIKIBFJEJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003F7")]
	public List<Guid> LCOEGHJMCPB;

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x6291E30", Offset = "0x6290C30", VA = "0x186291E30")]
	public static JBAAJPLDHKC OMJIHOMPBMI(CJIBMGCPPCM EILPDJCOMNG, FEDLCPADLNP JLKANFAFLJF, EAHIPFGMIPN MIDOLEMHGEM)
	{
		return default(JBAAJPLDHKC);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000117")]
internal struct JJMHJLBGKBE
{
	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370")]
	public static JJMHJLBGKBE HKJMJGOBNGA()
	{
		return default(JJMHJLBGKBE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
internal struct FBGHMLHIAKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003FB")]
	public readonly OABHNCNHAAJ LPPHACPIBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003FC")]
	public readonly BAKIIDGEBHM DBGIAKBKLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003FD")]
	public readonly string OBCNALAKINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003FE")]
	public readonly GENLCBECCME NEFJKEGBDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003FF")]
	public readonly GENLCBECCME NIAIMECGJLJ;

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0x62893A0", Offset = "0x62881A0", VA = "0x1862893A0")]
	public FBGHMLHIAKM(OABHNCNHAAJ LPPHACPIBIA, BAKIIDGEBHM DBGIAKBKLFC, string OBCNALAKINJ, GENLCBECCME NEFJKEGBDFC, GENLCBECCME NIAIMECGJLJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal struct OPIMALNNNGM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000400")]
	private readonly ODJJEDEFBFH HFIAFEMCIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000401")]
	private readonly Guid KJFPPNCBOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000402")]
	private bool BPGAINDNDCK;

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0x6299BE0", Offset = "0x62989E0", VA = "0x186299BE0")]
	public static OPIMALNNNGM KAPGDGIKDGM(ODJJEDEFBFH HFIAFEMCIEL)
	{
		return default(OPIMALNNNGM);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0x7D3730", Offset = "0x7D2530", VA = "0x1807D3730")]
	public void CKNKONIFFKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0x6299B80", Offset = "0x6298980", VA = "0x186299B80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0x6299CE0", Offset = "0x6298AE0", VA = "0x186299CE0")]
	private OPIMALNNNGM(ODJJEDEFBFH HFIAFEMCIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0x6299B80", Offset = "0x6298980", VA = "0x186299B80")]
	private void IPEHJCIAGLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0x6299C40", Offset = "0x6298A40", VA = "0x186299C40")]
	private Func<Guid, bool> ONJEHBLFKJK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
internal class ONNAFPNGIEA : FBAAFAMKBFA, HMFMDANJGDM
{
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	public delegate Task<FEDLCPADLNP> DDEJFDFIMJJ(EAHIPFGMIPN PFDMLBFKIAP, GEHLODFNIJP IJINAOIKJEG, EAEGPJJOHKN FIFIFPAOFFD, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct MLCOAMGJECJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public ONNAFPNGIEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public FGGFFJJDOJP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private OPIMALNNNGM <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private TaskAwaiter<KPCIENPMIHC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004E4")]
		[Cpp2IlInjected.Address(RVA = "0x6295080", Offset = "0x6293E80", VA = "0x186295080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E5")]
		[Cpp2IlInjected.Address(RVA = "0x6295780", Offset = "0x6294580", VA = "0x186295780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct KEDLKFMEHID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public AsyncTaskMethodBuilder<KPCIENPMIHC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public ONNAFPNGIEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public FGGFFJJDOJP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private TaskAwaiter<KPCIENPMIHC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E6")]
		[Cpp2IlInjected.Address(RVA = "0x6293CA0", Offset = "0x6292AA0", VA = "0x186293CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x62940B0", Offset = "0x6292EB0", VA = "0x1862940B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private struct MMADAMNHPOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public ONNAFPNGIEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public FGGFFJJDOJP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x62957E0", Offset = "0x62945E0", VA = "0x1862957E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004E9")]
		[Cpp2IlInjected.Address(RVA = "0x6295C70", Offset = "0x6294A70", VA = "0x186295C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011F")]
	[CompilerGenerated]
	private sealed class JHEIKFLOMNO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000120")]
		private struct <<LoadRoomLocal>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400042B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400042C")]
			public AsyncTaskMethodBuilder<FBGHMLHIAKM> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400042D")]
			public JHEIKFLOMNO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400042E")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400042F")]
			private FBGHMLHIAKM <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000430")]
			private TaskAwaiter<FEDLCPADLNP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000431")]
			private TaskAwaiter<FBGHMLHIAKM> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004EF")]
			[Cpp2IlInjected.Address(RVA = "0x629B0D0", Offset = "0x6299ED0", VA = "0x18629B0D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0x629B860", Offset = "0x629A660", VA = "0x18629B860", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000121")]
		private struct <<LoadRoomLocal>b__4>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000432")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public AsyncTaskMethodBuilder<EAHIPFGMIPN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			public JHEIKFLOMNO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			private EAHIPFGMIPN <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			private TaskAwaiter<FEDLCPADLNP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			private TaskAwaiter<EAHIPFGMIPN> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0x629B8D0", Offset = "0x629A6D0", VA = "0x18629B8D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0x629BF20", Offset = "0x629AD20", VA = "0x18629BF20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000122")]
		private struct <<LoadRoomLocal>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public JHEIKFLOMNO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			private TaskAwaiter<FEDLCPADLNP> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			private GEHLODFNIJP <timedYielder>5__2;

			[Cpp2IlInjected.Token(Token = "0x60004F3")]
			[Cpp2IlInjected.Address(RVA = "0x6299D30", Offset = "0x6298B30", VA = "0x186299D30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004F4")]
			[Cpp2IlInjected.Address(RVA = "0x629B070", Offset = "0x6299E70", VA = "0x18629B070", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public ONNAFPNGIEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public FGGFFJJDOJP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public EAEGPJJOHKN preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public EAEGPJJOHKN downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public FBGHMLHIAKM data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public EAEGPJJOHKN postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public EAHIPFGMIPN phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public HMNCILDCCDI.NMJKLNKMKAG <>9__6;

		[Cpp2IlInjected.Token(Token = "0x60004EA")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public JHEIKFLOMNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x6292660", Offset = "0x6291460", VA = "0x186292660")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__2>d))]
		internal Task<FBGHMLHIAKM> HHOPGCGNMLC(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x6292540", Offset = "0x6291340", VA = "0x186292540")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__4>d))]
		internal Task<EAHIPFGMIPN> CIHADDNLLHO(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004ED")]
		[Cpp2IlInjected.Address(RVA = "0x62927A0", Offset = "0x62915A0", VA = "0x1862927A0")]
		internal void KPOMMLOBFGA(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EE")]
		[Cpp2IlInjected.Address(RVA = "0x6292440", Offset = "0x6291240", VA = "0x186292440")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__0>d))]
		internal Task BKAEGNBKELF(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct HKAOLIDFKCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public ONNAFPNGIEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public FGGFFJJDOJP request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		private JHEIKFLOMNO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private TaskAwaiter<FBGHMLHIAKM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private TaskAwaiter<EAHIPFGMIPN> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x628F9C0", Offset = "0x628E7C0", VA = "0x18628F9C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x62906C0", Offset = "0x628F4C0", VA = "0x1862906C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000125")]
	[CompilerGenerated]
	private struct GJMFHHFAFAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public ONNAFPNGIEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public EIIPDELDDBE<string>.OABKDIIPOLN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x628E960", Offset = "0x628D760", VA = "0x18628E960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x628F0A0", Offset = "0x628DEA0", VA = "0x18628F0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct CBBNDBCGKIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public ONNAFPNGIEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public EAHIPFGMIPN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		public EAEGPJJOHKN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private TaskAwaiter<FEDLCPADLNP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x6285520", Offset = "0x6284320", VA = "0x186285520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x6285E80", Offset = "0x6284C80", VA = "0x186285E80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000127")]
	[CompilerGenerated]
	private struct CBPNGKBIPOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public AsyncTaskMethodBuilder<FEDLCPADLNP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public ONNAFPNGIEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public EAHIPFGMIPN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public EAEGPJJOHKN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private TaskAwaiter<FEDLCPADLNP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x6285EE0", Offset = "0x6284CE0", VA = "0x186285EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x6287060", Offset = "0x6285E60", VA = "0x186287060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	[CompilerGenerated]
	private struct FJEBILMNHCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public AsyncTaskMethodBuilder<FEDLCPADLNP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public ONNAFPNGIEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public EAHIPFGMIPN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public EAEGPJJOHKN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public GEHLODFNIJP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private TaskAwaiter<FEDLCPADLNP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x628A7B0", Offset = "0x62895B0", VA = "0x18628A7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x628BB80", Offset = "0x628A980", VA = "0x18628BB80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private struct KLCCGAAFKHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public AsyncTaskMethodBuilder<FEDLCPADLNP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public ONNAFPNGIEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public FEDLCPADLNP operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public EAEGPJJOHKN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public EAHIPFGMIPN deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private TaskAwaiter<FEDLCPADLNP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x6294B40", Offset = "0x6293940", VA = "0x186294B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0x6294DD0", Offset = "0x6293BD0", VA = "0x186294DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private sealed class ECFOBEIHAHI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200012B")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000485")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			public AsyncTaskMethodBuilder<FEDLCPADLNP> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			public ECFOBEIHAHI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			private IDisposable <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			private TaskAwaiter<FEDLCPADLNP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000509")]
			[Cpp2IlInjected.Address(RVA = "0x629BF90", Offset = "0x629AD90", VA = "0x18629BF90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050A")]
			[Cpp2IlInjected.Address(RVA = "0x629C600", Offset = "0x629B400", VA = "0x18629C600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public ONNAFPNGIEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public EAHIPFGMIPN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public EAEGPJJOHKN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public DDEJFDFIMJJ masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public GEHLODFNIJP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public FEDLCPADLNP originalRoomLoadPhase;

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public ECFOBEIHAHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0x6288D70", Offset = "0x6287B70", VA = "0x186288D70")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<FEDLCPADLNP> DNIJDEHHDAC(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct NHHGJCHOHOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public AsyncTaskMethodBuilder<FEDLCPADLNP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public ONNAFPNGIEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public EAHIPFGMIPN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public EAEGPJJOHKN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public DDEJFDFIMJJ masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public GEHLODFNIJP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private TaskAwaiter<FEDLCPADLNP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050B")]
		[Cpp2IlInjected.Address(RVA = "0x62961B0", Offset = "0x6294FB0", VA = "0x1862961B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050C")]
		[Cpp2IlInjected.Address(RVA = "0x62966F0", Offset = "0x62954F0", VA = "0x1862966F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct AJIIOPIPFLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public ONNAFPNGIEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public EAHIPFGMIPN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public EAEGPJJOHKN progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private FEDLCPADLNP <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private IEnumerator<FEDLCPADLNP> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private TaskAwaiter<FEDLCPADLNP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050D")]
		[Cpp2IlInjected.Address(RVA = "0x6283960", Offset = "0x6282760", VA = "0x186283960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x6283E90", Offset = "0x6282C90", VA = "0x186283E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012E")]
	[CompilerGenerated]
	private struct GECGDCPMOII : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public ONNAFPNGIEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public EAHIPFGMIPN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600050F")]
		[Cpp2IlInjected.Address(RVA = "0x628E5F0", Offset = "0x628D3F0", VA = "0x18628E5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0x628E900", Offset = "0x628D700", VA = "0x18628E900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct OMGOKEBPDIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public ONNAFPNGIEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public EAHIPFGMIPN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x6297AD0", Offset = "0x62968D0", VA = "0x186297AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x6297D20", Offset = "0x6296B20", VA = "0x186297D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000403")]
	private readonly DMEPLNBDMIK CBHODLCMKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000404")]
	private readonly DMEPLNBDMIK JHBGBPLEOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000405")]
	private readonly FNIHCJMFGHB PEJNLHEMDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000406")]
	private readonly AFJEGAJNODK EMDEBILKIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000407")]
	private readonly FMFHAMKOLKP FECIPHKCGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000408")]
	private readonly PLICAFGMAMP BEBNDKOKBEM;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	private DNDAMAFFFKG DGENPFONCPC
	{
		[Cpp2IlInjected.Token(Token = "0x60004C4")]
		[Cpp2IlInjected.Address(RVA = "0x62995D0", Offset = "0x62983D0", VA = "0x1862995D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001F")]
	public event ALOCECILKMC HOIIKOIHLKA
	{
		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x62987A0", Offset = "0x62975A0", VA = "0x1862987A0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x62983A0", Offset = "0x62971A0", VA = "0x1862983A0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0x62998D0", Offset = "0x62986D0", VA = "0x1862998D0")]
	public ONNAFPNGIEA(ODJJEDEFBFH HFIAFEMCIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0x6298950", Offset = "0x6297750", VA = "0x186298950")]
	[AsyncStateMachine(typeof(MLCOAMGJECJ))]
	public Task IALNCPCMCOL(FGGFFJJDOJP GDHOLDPNHCL, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0x6299620", Offset = "0x6298420", VA = "0x186299620")]
	[AsyncStateMachine(typeof(KEDLKFMEHID))]
	private Task<KPCIENPMIHC> OBFLIHKCCEK(FGGFFJJDOJP GDHOLDPNHCL, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0x6298660", Offset = "0x6297460", VA = "0x186298660")]
	[AsyncStateMachine(typeof(MMADAMNHPOE))]
	private Task FLJFKPIEEJJ(FGGFFJJDOJP GDHOLDPNHCL, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0x6299490", Offset = "0x6298290", VA = "0x186299490")]
	[AsyncStateMachine(typeof(HKAOLIDFKCM))]
	private Task NEHANNCJLBK(FGGFFJJDOJP GDHOLDPNHCL, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken NFKCBELPEFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0x6298BF0", Offset = "0x62979F0", VA = "0x186298BF0")]
	[AsyncStateMachine(typeof(GJMFHHFAFAD))]
	private Task KIMOADPHPBO(EIIPDELDDBE<string>.OABKDIIPOLN JICPEFHJENB, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0x6299130", Offset = "0x6297F30", VA = "0x186299130")]
	[AsyncStateMachine(typeof(CBBNDBCGKIE))]
	private Task MHAGPPAKFAA(EAHIPFGMIPN PFDMLBFKIAP, EAEGPJJOHKN FIFIFPAOFFD, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0x6298240", Offset = "0x6297040", VA = "0x186298240")]
	[AsyncStateMachine(typeof(CBPNGKBIPOB))]
	private Task<FEDLCPADLNP> BOEEKCEGLJF(EAHIPFGMIPN PFDMLBFKIAP, GEHLODFNIJP BEPJALFLOAH, EAEGPJJOHKN FIFIFPAOFFD, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x6299280", Offset = "0x6298080", VA = "0x186299280")]
	[AsyncStateMachine(typeof(FJEBILMNHCG))]
	private Task<FEDLCPADLNP> MMNDDNELOKC(EAHIPFGMIPN PFDMLBFKIAP, GEHLODFNIJP BEPJALFLOAH, EAEGPJJOHKN FIFIFPAOFFD, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x6298F30", Offset = "0x6297D30", VA = "0x186298F30")]
	[AsyncStateMachine(typeof(KLCCGAAFKHM))]
	private Task<FEDLCPADLNP> LJDMBHLELEJ(FEDLCPADLNP JLKANFAFLJF, EAHIPFGMIPN MIDOLEMHGEM, EAEGPJJOHKN FIFIFPAOFFD, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ, bool KBHGDEHPFEK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x6298D00", Offset = "0x6297B00", VA = "0x186298D00")]
	private bool KJKCGKAOIOC(EAHIPFGMIPN FCBPHDACHCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x62984D0", Offset = "0x62972D0", VA = "0x1862984D0")]
	[AsyncStateMachine(typeof(NHHGJCHOHOA))]
	protected Task<FEDLCPADLNP> FBFPINOLEMC(EAHIPFGMIPN PFDMLBFKIAP, GEHLODFNIJP BEPJALFLOAH, EAEGPJJOHKN FIFIFPAOFFD, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ, DDEJFDFIMJJ DIFKPOGJNIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x6298AA0", Offset = "0x62978A0", VA = "0x186298AA0")]
	[AsyncStateMachine(typeof(AJIIOPIPFLE))]
	private Task IPBCCMKCKNP(EAHIPFGMIPN PFDMLBFKIAP, EAEGPJJOHKN FIFIFPAOFFD, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x6298900", Offset = "0x6297700", VA = "0x186298900")]
	private void HLAIPKOMCJE(FEDLCPADLNP MJGELGOLHAI, EAEGPJJOHKN FIFIFPAOFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x62990F0", Offset = "0x6297EF0", VA = "0x1862990F0")]
	private void MGNBEDHPFFO(FEDLCPADLNP NOGMKONMDDK, [Out] FEDLCPADLNP PMFEHIKJPBI, [Out] FEDLCPADLNP KBLLLPAOKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x6298200", Offset = "0x6297000", VA = "0x186298200")]
	private Task<FBGHMLHIAKM> BLGNFJFECHA(FGGFFJJDOJP GDHOLDPNHCL, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x6299450", Offset = "0x6298250", VA = "0x186299450")]
	private Task<EAHIPFGMIPN> NAGGLIDLJLP(FBGHMLHIAKM PFDMLBFKIAP, HMNCILDCCDI.NMJKLNKMKAG NOIMABODHIE, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x62980B0", Offset = "0x6296EB0", VA = "0x1862980B0")]
	[AsyncStateMachine(typeof(GECGDCPMOII))]
	private Task AMPDMPAOJCI(EAHIPFGMIPN PFDMLBFKIAP, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ, bool LNMMADBGKLD = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x62983C0", Offset = "0x62971C0", VA = "0x1862983C0")]
	[AsyncStateMachine(typeof(OMGOKEBPDIN))]
	private Task DIAIDKLFNBO(EAHIPFGMIPN PFDMLBFKIAP, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x62987C0", Offset = "0x62975C0", VA = "0x1862987C0")]
	private Task GCGLHAALJJI(EAHIPFGMIPN PFDMLBFKIAP, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x62990D0", Offset = "0x6297ED0", VA = "0x1862990D0")]
	private Task MBPHPKJMIFI(EAHIPFGMIPN PFDMLBFKIAP, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x62990B0", Offset = "0x6297EB0", VA = "0x1862990B0")]
	private Task LOPNIPNAMHH(EAHIPFGMIPN PFDMLBFKIAP, GEHLODFNIJP BEPJALFLOAH, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x6299780", Offset = "0x6298580", VA = "0x186299780")]
	private Task OCNJHKAEFPK(EAHIPFGMIPN PFDMLBFKIAP, GEHLODFNIJP BEPJALFLOAH, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x628F8E0", Offset = "0x628E6E0", VA = "0x18628F8E0")]
	private static Task KKEJOOOPJEL(CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x6299600", Offset = "0x6298400", VA = "0x186299600")]
	private Task NNAPDMNOKEG(EAHIPFGMIPN PFDMLBFKIAP, GEHLODFNIJP BEPJALFLOAH, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x6298DF0", Offset = "0x6297BF0", VA = "0x186298DF0")]
	private Task LEKGLLPKBHE(EAHIPFGMIPN PFDMLBFKIAP, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x6299400", Offset = "0x6298200", VA = "0x186299400")]
	private void MOKDMFBDBCO(FGGFFJJDOJP GDHOLDPNHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x62984B0", Offset = "0x62972B0", VA = "0x1862984B0")]
	public void EGJCCKFCOMM(long KIPHFANLMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	private static void LBBFCIAJOOA(OABHNCNHAAJ LPPHACPIBIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal struct ONMEMDLGGHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	private DNDAMAFFFKG HJDDMPFEAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	private EAHIPFGMIPN PFDMLBFKIAP;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private CJIBMGCPPCM FHMIKKFADBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x6297D80", Offset = "0x6296B80", VA = "0x186297D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x6297FD0", Offset = "0x6296DD0", VA = "0x186297FD0")]
	public static Task ODBEBJNFCLL(DNDAMAFFFKG HJDDMPFEAJK, EAHIPFGMIPN PFDMLBFKIAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0x6297DD0", Offset = "0x6296BD0", VA = "0x186297DD0")]
	private void ODBEBJNFCLL()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000131")]
internal struct HIKALKLMEDC
{
	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0x628F8E0", Offset = "0x628E6E0", VA = "0x18628F8E0")]
	public static Task ODBEBJNFCLL(CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal struct ELPGIPDGCHD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private struct EACKGIIGLEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public ODJJEDEFBFH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public EAHIPFGMIPN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x62887B0", Offset = "0x62875B0", VA = "0x1862887B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x6288D10", Offset = "0x6287B10", VA = "0x186288D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0x6289100", Offset = "0x6287F00", VA = "0x186289100")]
	[AsyncStateMachine(typeof(EACKGIIGLEE))]
	public static Task ODBEBJNFCLL(ODJJEDEFBFH HFIAFEMCIEL, EAHIPFGMIPN PFDMLBFKIAP, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000134")]
internal struct CLODOGFMOAJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct ILDPNIBADAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public ODJJEDEFBFH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public EAHIPFGMIPN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public GEHLODFNIJP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private FEDLCPADLNP <operationState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private DNDAMAFFFKG <roomManager>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private bool <isMaster>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private CJIBMGCPPCM <callbacks>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private IDisposable <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private List<(PersistenceView, MEEBAJFNOLB)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private MEEBAJFNOLB <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x6291130", Offset = "0x628FF30", VA = "0x186291130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x6291DD0", Offset = "0x6290BD0", VA = "0x186291DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0x6288310", Offset = "0x6287110", VA = "0x186288310")]
	[AsyncStateMachine(typeof(ILDPNIBADAE))]
	public static Task ODBEBJNFCLL(ODJJEDEFBFH HFIAFEMCIEL, EAHIPFGMIPN PFDMLBFKIAP, GEHLODFNIJP BEPJALFLOAH, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0x6288110", Offset = "0x6286F10", VA = "0x186288110")]
	private static void HKEAOFHNEFP(PersistenceView IHHDBAHIMPL, MEEBAJFNOLB CHKCMEOEOJO, EAHIPFGMIPN PFDMLBFKIAP, FEDLCPADLNP JLKANFAFLJF, bool MAGFNANODPJ)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000137")]
internal struct MDOOCNAAAGC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[CompilerGenerated]
	private struct AFMNEDCKPCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public DNDAMAFFFKG roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public EAHIPFGMIPN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x62834C0", Offset = "0x62822C0", VA = "0x1862834C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x6283900", Offset = "0x6282700", VA = "0x186283900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x6294F70", Offset = "0x6293D70", VA = "0x186294F70")]
	[AsyncStateMachine(typeof(AFMNEDCKPCC))]
	public static Task ODBEBJNFCLL(DNDAMAFFFKG HJDDMPFEAJK, EAHIPFGMIPN PFDMLBFKIAP, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct FBJDHMHPLLG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	[CompilerGenerated]
	private struct EFDALPGACDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public DNDAMAFFFKG roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public EAHIPFGMIPN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public ODJJEDEFBFH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x6288E90", Offset = "0x6287C90", VA = "0x186288E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x62890A0", Offset = "0x6287EA0", VA = "0x1862890A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013B")]
	[CompilerGenerated]
	private sealed class OGCLHGKPBNB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200013C")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004E1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004E2")]
			public EIIPDELDDBE<string>.OABKDIIPOLN timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004E3")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			public OGCLHGKPBNB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004E5")]
			private EIIPDELDDBE<string>.OABKDIIPOLN <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004E6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0x629C670", Offset = "0x629B470", VA = "0x18629C670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000530")]
			[Cpp2IlInjected.Address(RVA = "0x629CA00", Offset = "0x629B800", VA = "0x18629CA00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public OGCLHGKPBNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x6297310", Offset = "0x6296110", VA = "0x186297310")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task IBILJDBCIMP(EIIPDELDDBE<string>.OABKDIIPOLN timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200013D")]
	[CompilerGenerated]
	private struct HMLJLIAPIMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public FBJDHMHPLLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private TaskAwaiter<KPCIENPMIHC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x6290720", Offset = "0x628F520", VA = "0x186290720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x62910D0", Offset = "0x628FED0", VA = "0x1862910D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200013E")]
	[CompilerGenerated]
	private sealed class FFPGELBJGAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public GBHCGBLPNAE version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public FFPGELBJGAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x628A590", Offset = "0x6289390", VA = "0x18628A590")]
		internal object MDAALOLNHAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x628A4E0", Offset = "0x62892E0", VA = "0x18628A4E0")]
		internal object CMABICMGOIE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D1")]
	private DNDAMAFFFKG HJDDMPFEAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	private EAHIPFGMIPN PFDMLBFKIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	private ODJJEDEFBFH HFIAFEMCIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	private bool LNMMADBGKLD;

	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	private static readonly ByteString GNNKPOECPAL;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	private CJIBMGCPPCM FHMIKKFADBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x6289460", Offset = "0x6288260", VA = "0x186289460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private GHGDBFAHECB KOBHDJCOPLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x6289B50", Offset = "0x6288950", VA = "0x186289B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0x6289D30", Offset = "0x6288B30", VA = "0x186289D30")]
	[AsyncStateMachine(typeof(EFDALPGACDI))]
	public static Task ODBEBJNFCLL(DNDAMAFFFKG HJDDMPFEAJK, EAHIPFGMIPN PFDMLBFKIAP, ODJJEDEFBFH HFIAFEMCIEL, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ, bool LNMMADBGKLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0x6289BF0", Offset = "0x62889F0", VA = "0x186289BF0")]
	[AsyncStateMachine(typeof(HMLJLIAPIMO))]
	private Task ODBEBJNFCLL(EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0x62894B0", Offset = "0x62882B0", VA = "0x1862894B0")]
	private void KJIHLIIMOJO([NotNull] BNNAHCBMALA PDOAMGFMMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0x6289420", Offset = "0x6288220", VA = "0x186289420")]
	private bool FHPENBGODOF(GBHCGBLPNAE KCPGKFKLEJL, BNNAHCBMALA PDOAMGFMMJI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
internal struct OJKGAPBFPNL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct BDBHCOPPGPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public AsyncTaskMethodBuilder<EAHIPFGMIPN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public OJKGAPBFPNL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public HMNCILDCCDI.NMJKLNKMKAG downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private TaskAwaiter<(IHFDHMKEEAA<HDCEIMDCGJK, EAGLHGKDHHG>, IHFDHMKEEAA<MPIDCENOJCB<BNNAHCBMALA>, EAGLHGKDHHG>, IHFDHMKEEAA<MPIDCENOJCB<KOEJGCBBPJC>, EAGLHGKDHHG>, IHFDHMKEEAA<MPIDCENOJCB<DPNLDOHHJNG>, EAGLHGKDHHG>)> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x6283EF0", Offset = "0x6282CF0", VA = "0x186283EF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x62848E0", Offset = "0x62836E0", VA = "0x1862848E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct OAKACGAIOEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public AsyncTaskMethodBuilder<IHFDHMKEEAA<HDCEIMDCGJK, EAGLHGKDHHG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public EIIPDELDDBE<string>.OABKDIIPOLN downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public OJKGAPBFPNL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public string unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public long roomInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public HMNCILDCCDI.NMJKLNKMKAG downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private TaskAwaiter<IHFDHMKEEAA<HDCEIMDCGJK, EAGLHGKDHHG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x6296AF0", Offset = "0x62958F0", VA = "0x186296AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x62970E0", Offset = "0x6295EE0", VA = "0x1862970E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F5")]
	private JPPPPEHKKAD<GENLCBECCME, KOEJGCBBPJC> DCJJKANLLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F6")]
	private JPPPPEHKKAD<GENLCBECCME, BNNAHCBMALA> KNIIDEFIBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004F7")]
	private JPPPPEHKKAD<long, DPNLDOHHJNG> CMIJNKGAKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004F8")]
	private FGLPGPFPCNM GLKOHPIKKMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004F9")]
	private OABHNCNHAAJ LPPHACPIBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004FA")]
	private BAKIIDGEBHM DBGIAKBKLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004FB")]
	private string OBCNALAKINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private GENLCBECCME NEFJKEGBDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private GENLCBECCME NIAIMECGJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004FE")]
	private long KIPHFANLMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004FF")]
	private EIIPDELDDBE<string>.OABKDIIPOLN JICPEFHJENB;

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0x6297430", Offset = "0x6296230", VA = "0x186297430")]
	public static Task<EAHIPFGMIPN> HLHFCEKKJJG(DNDAMAFFFKG HJDDMPFEAJK, [In] FBGHMLHIAKM PFDMLBFKIAP, HMNCILDCCDI.NMJKLNKMKAG NOIMABODHIE, EIIPDELDDBE<string>.OABKDIIPOLN JICPEFHJENB, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x6297950", Offset = "0x6296750", VA = "0x186297950")]
	[AsyncStateMachine(typeof(BDBHCOPPGPB))]
	private Task<EAHIPFGMIPN> ODBEBJNFCLL(HMNCILDCCDI.NMJKLNKMKAG NOIMABODHIE, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x62977A0", Offset = "0x62965A0", VA = "0x1862977A0")]
	[AsyncStateMachine(typeof(OAKACGAIOEP))]
	private Task<IHFDHMKEEAA<HDCEIMDCGJK, EAGLHGKDHHG>> NAPLOJBFHHB(string OBCNALAKINJ, long KIPHFANLMBH, HMNCILDCCDI.NMJKLNKMKAG NOIMABODHIE, EIIPDELDDBE<string>.OABKDIIPOLN GGFNPLFKOBH, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
internal struct IHNOLNMNDJH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private struct FFJOIFILEAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		public AsyncTaskMethodBuilder<FBGHMLHIAKM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		public IHNOLNMNDJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private TaskAwaiter<FBGHMLHIAKM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x62A5280", Offset = "0x62A4080", VA = "0x1862A5280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x62A5680", Offset = "0x62A4480", VA = "0x1862A5680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000144")]
	[CompilerGenerated]
	private struct AHBBOIOPEBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		public AsyncTaskMethodBuilder<FBGHMLHIAKM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public IHNOLNMNDJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private TaskAwaiter<FBGHMLHIAKM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x629EF90", Offset = "0x629DD90", VA = "0x18629EF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x629F390", Offset = "0x629E190", VA = "0x18629F390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CompilerGenerated]
	private sealed class MIODHNLOJLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public long subroomId;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public MIODHNLOJLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x1305BA0", Offset = "0x13049A0", VA = "0x181305BA0")]
		internal bool CHMPGAOALNM(BAKIIDGEBHM sr)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[CompilerGenerated]
	private struct FFOJDMCALPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		public AsyncTaskMethodBuilder<FBGHMLHIAKM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		public GENLCBECCME superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public CJIBMGCPPCM callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private MIODHNLOJLM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private OABHNCNHAAJ <roomDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private BAKIIDGEBHM <subroom>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private string <unityAssetId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private GENLCBECCME <superRoomData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private GENLCBECCME <subRoomData>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private TaskAwaiter<OABHNCNHAAJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private TaskAwaiter<JDABFNMFCMB> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private TaskAwaiter<GBFOHGAHICD> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x62A56F0", Offset = "0x62A44F0", VA = "0x1862A56F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x62A6790", Offset = "0x62A5590", VA = "0x1862A6790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000513")]
	private CJIBMGCPPCM EILPDJCOMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000514")]
	private FNIHCJMFGHB PEJNLHEMDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000515")]
	private EIIPDELDDBE<string>.OABKDIIPOLN JICPEFHJENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000516")]
	private long NGLNDFKLBFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000517")]
	private long OBPCIAFLNJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000518")]
	private long KICFIJPIOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000519")]
	private string KHKBFBOFMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400051A")]
	private GENLCBECCME IOAOBGDFGHF;

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x62AB4E0", Offset = "0x62AA2E0", VA = "0x1862AB4E0")]
	public static Task<FBGHMLHIAKM> HLHFCEKKJJG(DNDAMAFFFKG HJDDMPFEAJK, FGGFFJJDOJP GDHOLDPNHCL, EIIPDELDDBE<string>.OABKDIIPOLN JICPEFHJENB, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x62AB760", Offset = "0x62AA560", VA = "0x1862AB760")]
	[AsyncStateMachine(typeof(FFJOIFILEAC))]
	private Task<FBGHMLHIAKM> ODBEBJNFCLL(CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x62AB1F0", Offset = "0x62A9FF0", VA = "0x1862AB1F0")]
	[AsyncStateMachine(typeof(AHBBOIOPEBC))]
	private Task<FBGHMLHIAKM> BLGNFJFECHA(EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x62AB350", Offset = "0x62AA150", VA = "0x1862AB350")]
	[AsyncStateMachine(typeof(FFOJDMCALPB))]
	private static Task<FBGHMLHIAKM> BLGNFJFECHA(CJIBMGCPPCM EILPDJCOMNG, long NGLNDFKLBFL, long OBPCIAFLNJK, long KICFIJPIOII, string KHKBFBOFMIB, GENLCBECCME IOAOBGDFGHF, CancellationToken BIBHFGFDEGJ, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x62AB8B0", Offset = "0x62AA6B0", VA = "0x1862AB8B0")]
	private void ONJBKOMFAJG(OABHNCNHAAJ LPPHACPIBIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000147")]
internal struct KIKMFBNCMEG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct GCNPMIKNLNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public KIKMFBNCMEG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x62A7620", Offset = "0x62A6420", VA = "0x1862A7620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x62A7BB0", Offset = "0x62A69B0", VA = "0x1862A7BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400053C")]
	private CJIBMGCPPCM EILPDJCOMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400053D")]
	private EAHIPFGMIPN PFDMLBFKIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400053E")]
	private EIIPDELDDBE<string>.OABKDIIPOLN JICPEFHJENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400053F")]
	private float FFMHKCPEFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000540")]
	private float DCFLKBNPNCI;

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0x62AEB00", Offset = "0x62AD900", VA = "0x1862AEB00")]
	public static Task KCIILFIGDCJ(DNDAMAFFFKG HJDDMPFEAJK, EAHIPFGMIPN PFDMLBFKIAP, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0x62AEE00", Offset = "0x62ADC00", VA = "0x1862AEE00")]
	[AsyncStateMachine(typeof(GCNPMIKNLNO))]
	public Task ODBEBJNFCLL(CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0x62AECC0", Offset = "0x62ADAC0", VA = "0x1862AECC0")]
	private static void MEBFKHMJEGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0x62AE9A0", Offset = "0x62AD7A0", VA = "0x1862AE9A0")]
	private void IGGMDLGOBFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0x62AEF20", Offset = "0x62ADD20", VA = "0x1862AEF20")]
	private static float OOKNDMPNNFL(CJIBMGCPPCM EILPDJCOMNG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0x62AECA0", Offset = "0x62ADAA0", VA = "0x1862AECA0")]
	private static float LIKAFPCMFCP()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200014A")]
internal struct APFLMGGNHPE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct DMEOJHIDPPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public ODJJEDEFBFH operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		public EAHIPFGMIPN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private GCAFIKPGAJD <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private DNDAMAFFFKG <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private FLPEPDELPGI.GDHFLEPOOLF <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private TaskAwaiter<KPCIENPMIHC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x62A36B0", Offset = "0x62A24B0", VA = "0x1862A36B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0x62A40A0", Offset = "0x62A2EA0", VA = "0x1862A40A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct LDOIMFGIKDN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0x62B0210", Offset = "0x62AF010", VA = "0x1862B0210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0x62B0540", Offset = "0x62AF340", VA = "0x1862B0540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0x629F4B0", Offset = "0x629E2B0", VA = "0x18629F4B0")]
	[AsyncStateMachine(typeof(DMEOJHIDPPG))]
	public static Task ODBEBJNFCLL(ODJJEDEFBFH HFIAFEMCIEL, EAHIPFGMIPN PFDMLBFKIAP, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0x629F5F0", Offset = "0x629E3F0", VA = "0x18629F5F0")]
	private static Task<KPCIENPMIHC> PIGDPLBMIBJ(ODJJEDEFBFH HFIAFEMCIEL, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x629F400", Offset = "0x629E200", VA = "0x18629F400")]
	[AsyncStateMachine(typeof(LDOIMFGIKDN))]
	private static Task LOBPGEILPMI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
internal struct IEAFLAINFJG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private struct CKPMMCCHKCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public IEAFLAINFJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x62A0D40", Offset = "0x629FB40", VA = "0x1862A0D40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x62A13F0", Offset = "0x62A01F0", VA = "0x1862A13F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class GHJGNOJOLOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public GHJGNOJOLOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x62A87D0", Offset = "0x62A75D0", VA = "0x1862A87D0")]
		internal object PDDPICLPDFK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct KIPIDHGOPKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public IEAFLAINFJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private JIBHJPAIMBN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x62AEFE0", Offset = "0x62ADDE0", VA = "0x1862AEFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x62AF5F0", Offset = "0x62AE3F0", VA = "0x1862AF5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400055B")]
	private bool GFBNCMLEANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400055C")]
	private EIIPDELDDBE<string>.OABKDIIPOLN JICPEFHJENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400055D")]
	private DNDAMAFFFKG HJDDMPFEAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400055E")]
	private CancellationToken BIBHFGFDEGJ;

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0x62AAF60", Offset = "0x62A9D60", VA = "0x1862AAF60")]
	public static Task HBEKLBPMJKN(DNDAMAFFFKG HJDDMPFEAJK, bool GFBNCMLEANB, EIIPDELDDBE<string>.OABKDIIPOLN JICPEFHJENB, CancellationToken JAGJENAECGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0x62AAFD0", Offset = "0x62A9DD0", VA = "0x1862AAFD0")]
	[AsyncStateMachine(typeof(CKPMMCCHKCN))]
	private Task ODBEBJNFCLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0x62AB0C0", Offset = "0x62A9EC0", VA = "0x1862AB0C0")]
	[AsyncStateMachine(typeof(KIPIDHGOPKC))]
	private Task PLKFFNGIGFJ(bool KLHIAFKDFBA, string EPCCHKDEDAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0x7AC370", Offset = "0x7AB170", VA = "0x1807AC370")]
	private bool GNKNLEHFOLF(bool GFBNCMLEANB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
internal struct DCLGEHGIOOM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct ILCMMIAMNOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public DCLGEHGIOOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x62ABDE0", Offset = "0x62AABE0", VA = "0x1862ABDE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x62AC350", Offset = "0x62AB150", VA = "0x1862AC350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private sealed class LNHBOOAOGAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public LNHBOOAOGAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x62B0F40", Offset = "0x62AFD40", VA = "0x1862B0F40")]
		internal object PDDPICLPDFK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private struct KNADEMEIPNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		public DCLGEHGIOOM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private JIBHJPAIMBN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x62AF650", Offset = "0x62AE450", VA = "0x1862AF650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000571")]
		[Cpp2IlInjected.Address(RVA = "0x62AFC30", Offset = "0x62AEA30", VA = "0x1862AFC30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400056F")]
	private MEAJEDGHGNK JFPGFOIICJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000570")]
	private EIIPDELDDBE<string>.OABKDIIPOLN JICPEFHJENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000571")]
	private DNDAMAFFFKG HJDDMPFEAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000572")]
	private bool IPGNEOGFFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000573")]
	private EAHIPFGMIPN PFDMLBFKIAP;

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0x62A22A0", Offset = "0x62A10A0", VA = "0x1862A22A0")]
	public static Task<Scene> FJNIJGBJMFC(DNDAMAFFFKG HJDDMPFEAJK, MEAJEDGHGNK LHEIPAKIGDJ, EIIPDELDDBE<string>.OABKDIIPOLN JICPEFHJENB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0x62A2350", Offset = "0x62A1150", VA = "0x1862A2350")]
	[AsyncStateMachine(typeof(ILCMMIAMNOC))]
	private Task<Scene> ODBEBJNFCLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x62A2320", Offset = "0x62A1120", VA = "0x1862A2320")]
	private bool LMMGDNNBGLN(EAHIPFGMIPN PFDMLBFKIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x62A2230", Offset = "0x62A1030", VA = "0x1862A2230")]
	private void CCLFANBHIMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x62A2470", Offset = "0x62A1270", VA = "0x1862A2470")]
	[AsyncStateMachine(typeof(KNADEMEIPNA))]
	private Task<Scene> PLKFFNGIGFJ(string EPCCHKDEDAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000155")]
internal struct FMFHAMKOLKP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct OLNNAGJDJLF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		public AsyncTaskMethodBuilder<FEDLCPADLNP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		public FMFHAMKOLKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		public FEDLCPADLNP nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public EAHIPFGMIPN deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private TaskAwaiter<FEDLCPADLNP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x62B2940", Offset = "0x62B1740", VA = "0x1862B2940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x62B3420", Offset = "0x62B2220", VA = "0x1862B3420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct HJMDCPFJIMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public AsyncTaskMethodBuilder<FEDLCPADLNP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public FMFHAMKOLKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public FEDLCPADLNP state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private TaskAwaiter<KPCIENPMIHC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x62A9E40", Offset = "0x62A8C40", VA = "0x1862A9E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x62AA120", Offset = "0x62A8F20", VA = "0x1862AA120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000581")]
	private readonly ODJJEDEFBFH HFIAFEMCIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000582")]
	private readonly FNIHCJMFGHB PEJNLHEMDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000583")]
	private readonly AFJEGAJNODK EMDEBILKIJI;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private GCAFIKPGAJD CNNLFMBEMLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x4BBD8B0", Offset = "0x4BBC6B0", VA = "0x184BBD8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x62A75C0", Offset = "0x62A63C0", VA = "0x1862A75C0")]
	public FMFHAMKOLKP(ODJJEDEFBFH HFIAFEMCIEL, FNIHCJMFGHB PEJNLHEMDEP, AFJEGAJNODK EMDEBILKIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x62A73F0", Offset = "0x62A61F0", VA = "0x1862A73F0")]
	[AsyncStateMachine(typeof(OLNNAGJDJLF))]
	public Task<FEDLCPADLNP> CMKJILDGGAO(FEDLCPADLNP GOLHJCOPPNK, EAHIPFGMIPN MIDOLEMHGEM, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ, bool KBHGDEHPFEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x62A7290", Offset = "0x62A6090", VA = "0x1862A7290")]
	[AsyncStateMachine(typeof(HJMDCPFJIMN))]
	private Task<FEDLCPADLNP> CMDFLECJMOL(EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, FEDLCPADLNP EPLFCMFNFIK, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x62A7570", Offset = "0x62A6370", VA = "0x1862A7570")]
	private bool JEPPGHFCKBC(FEDLCPADLNP PBNHOEFEKBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x62A75A0", Offset = "0x62A63A0", VA = "0x1862A75A0")]
	private void NGLKBDEIIAD(string EMHIALHDHFI)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000158")]
internal struct KCCIBGIJPOM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000159")]
	[CompilerGenerated]
	private struct LLININFHOCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		public GCAFIKPGAJD operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		public EAHIPFGMIPN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		public GEHLODFNIJP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private List<(PersistenceView, MEEBAJFNOLB)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private (PersistenceView, MEEBAJFNOLB) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x62B08A0", Offset = "0x62AF6A0", VA = "0x1862B08A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x62B0EE0", Offset = "0x62AFCE0", VA = "0x1862B0EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x62AE860", Offset = "0x62AD660", VA = "0x1862AE860")]
	[AsyncStateMachine(typeof(LLININFHOCB))]
	public static Task ODBEBJNFCLL(GCAFIKPGAJD ALJMPBCMDJC, EAHIPFGMIPN PFDMLBFKIAP, GEHLODFNIJP BEPJALFLOAH, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct MELMKHDIFDJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[CompilerGenerated]
	private struct CGBIEHAHKNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public GCAFIKPGAJD operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public EAHIPFGMIPN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public GEHLODFNIJP timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private GBHCGBLPNAE <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private List<(PersistenceView, MEEBAJFNOLB)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private MEEBAJFNOLB <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x62A01C0", Offset = "0x629EFC0", VA = "0x1862A01C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x62A0A20", Offset = "0x629F820", VA = "0x1862A0A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x62B1310", Offset = "0x62B0110", VA = "0x1862B1310")]
	[AsyncStateMachine(typeof(CGBIEHAHKNL))]
	public static Task ODBEBJNFCLL(GCAFIKPGAJD ALJMPBCMDJC, EAHIPFGMIPN PFDMLBFKIAP, GEHLODFNIJP BEPJALFLOAH, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200015C")]
internal struct FLPEPDELPGI
{
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	public struct GDHFLEPOOLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public List<NAGGCEGLFLP> KDGBCNIEJGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public List<MEEBAJFNOLB> CEDNFHOCOAF;

		[Cpp2IlInjected.Token(Token = "0x6000587")]
		[Cpp2IlInjected.Address(RVA = "0x7F1EC0", Offset = "0x7F0CC0", VA = "0x1807F1EC0")]
		public GDHFLEPOOLF(List<NAGGCEGLFLP> KDGBCNIEJGI, List<MEEBAJFNOLB> CEDNFHOCOAF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private sealed class ECGOEGMKAIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public IEnumerable<NAGGCEGLFLP> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000588")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public ECGOEGMKAIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000589")]
		[Cpp2IlInjected.Address(RVA = "0x62A4100", Offset = "0x62A2F00", VA = "0x1862A4100")]
		internal object GKOONEAHEMN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005B0")]
	private DNDAMAFFFKG HJDDMPFEAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005B1")]
	private EAHIPFGMIPN PFDMLBFKIAP;

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	private CJIBMGCPPCM FHMIKKFADBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x62A6DB0", Offset = "0x62A5BB0", VA = "0x1862A6DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x62A7230", Offset = "0x62A6030", VA = "0x1862A7230")]
	public static GDHFLEPOOLF ODBEBJNFCLL(DNDAMAFFFKG HJDDMPFEAJK, EAHIPFGMIPN PFDMLBFKIAP)
	{
		return default(GDHFLEPOOLF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x62A6FD0", Offset = "0x62A5DD0", VA = "0x1862A6FD0")]
	private GDHFLEPOOLF ODBEBJNFCLL()
	{
		return default(GDHFLEPOOLF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x62A6800", Offset = "0x62A5600", VA = "0x1862A6800")]
	private GDHFLEPOOLF BMJMIMGCNLG(BNNAHCBMALA PDOAMGFMMJI, GBHCGBLPNAE OEHHLNMNHMO)
	{
		return default(GDHFLEPOOLF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x62A6E00", Offset = "0x62A5C00", VA = "0x1862A6E00")]
	private bool NBHHKBLPDDN(IEnumerable<NAGGCEGLFLP> KDGBCNIEJGI)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015F")]
internal struct MJHBHEPEPHJ
{
	[Cpp2IlInjected.Token(Token = "0x2000160")]
	[CompilerGenerated]
	private sealed class PIIDGLBLLEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public FLPEPDELPGI.GDHFLEPOOLF instantiations;

		[Cpp2IlInjected.Token(Token = "0x600058B")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public PIIDGLBLLEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x62B40E0", Offset = "0x62B2EE0", VA = "0x1862B40E0")]
		internal object IBILJDBCIMP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private sealed class CMAIPGFNDKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public CMAIPGFNDKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x62A1450", Offset = "0x62A0250", VA = "0x1862A1450")]
		internal object JBPJCLDKCMP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x62B1450", Offset = "0x62B0250", VA = "0x1862B1450")]
	public static void ODBEBJNFCLL(GCAFIKPGAJD ALJMPBCMDJC, EAHIPFGMIPN PFDMLBFKIAP, FLPEPDELPGI.GDHFLEPOOLF EJDFNLGEMBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
internal class AFJEGAJNODK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private struct IPDFLONBMIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		public AFJEGAJNODK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		public FEDLCPADLNP operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		public EAHIPFGMIPN deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public EIIPDELDDBE<string>.OABKDIIPOLN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600059D")]
		[Cpp2IlInjected.Address(RVA = "0x62AC3C0", Offset = "0x62AB1C0", VA = "0x1862AC3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600059E")]
		[Cpp2IlInjected.Address(RVA = "0x62ACB30", Offset = "0x62AB930", VA = "0x1862ACB30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class NPJCCBIPBHK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000165")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005C7")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005C8")]
			public NPJCCBIPBHK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005C9")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005CA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0x62B55E0", Offset = "0x62B43E0", VA = "0x1862B55E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0x62B58A0", Offset = "0x62B46A0", VA = "0x1862B58A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public AFJEGAJNODK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public EAHIPFGMIPN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public EIIPDELDDBE<string>.OABKDIIPOLN handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600059F")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public NPJCCBIPBHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x62B2850", Offset = "0x62B1650", VA = "0x1862B2850")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task CDDHKIGAHBD(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct ENMFFBOOBKK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public AFJEGAJNODK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public EAHIPFGMIPN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		public EIIPDELDDBE<string>.OABKDIIPOLN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private NPJCCBIPBHK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x62A4180", Offset = "0x62A2F80", VA = "0x1862A4180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x62A46B0", Offset = "0x62A34B0", VA = "0x1862A46B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private struct PIKJMCLDNBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		public AFJEGAJNODK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		public EIIPDELDDBE<string>.OABKDIIPOLN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		public EAHIPFGMIPN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private Dictionary<Guid, List<GOOGEMJEJCB>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x62B4190", Offset = "0x62B2F90", VA = "0x1862B4190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x62B4740", Offset = "0x62B3540", VA = "0x1862B4740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000168")]
	[CompilerGenerated]
	private struct FDLMKKHEJHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public AFJEGAJNODK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public EIIPDELDDBE<string>.OABKDIIPOLN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		public EAHIPFGMIPN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private EIIPDELDDBE<string>.OABKDIIPOLN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private Dictionary<Guid, List<GOOGEMJEJCB>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x62A4BA0", Offset = "0x62A39A0", VA = "0x1862A4BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x62A5220", Offset = "0x62A4020", VA = "0x1862A5220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private sealed class CDBGBMIANDJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016A")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005EA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005EB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005EC")]
			public GOOGEMJEJCB handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005ED")]
			public CDBGBMIANDJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005EE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x62B53E0", Offset = "0x62B41E0", VA = "0x1862B53E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x62B5580", Offset = "0x62B4380", VA = "0x1862B5580", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public IPKOFMONAPE runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public List<GOOGEMJEJCB> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public EAHIPFGMIPN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public CDBGBMIANDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x629FFE0", Offset = "0x629EDE0", VA = "0x18629FFE0")]
		internal object JNKNFOLFJDA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x62A00D0", Offset = "0x629EED0", VA = "0x1862A00D0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task MDDICPEPKDN(GOOGEMJEJCB handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x629FEF0", Offset = "0x629ECF0", VA = "0x18629FEF0")]
		internal object JAFOKLGLOLC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016B")]
	[CompilerGenerated]
	private struct PNAMICLFHNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		public IPKOFMONAPE runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		public List<GOOGEMJEJCB> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		public EAHIPFGMIPN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		private CDBGBMIANDJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x62B4EB0", Offset = "0x62B3CB0", VA = "0x1862B4EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x62B5380", Offset = "0x62B4180", VA = "0x1862B5380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct AEBJINKKLFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public AFJEGAJNODK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public EAHIPFGMIPN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public EIIPDELDDBE<string>.OABKDIIPOLN timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x629DA20", Offset = "0x629C820", VA = "0x18629DA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x629DFD0", Offset = "0x629CDD0", VA = "0x18629DFD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private sealed class JJHGNIHDNAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public JJHGNIHDNAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x62AE7F0", Offset = "0x62AD5F0", VA = "0x1862AE7F0")]
		internal object POEJPMNICDN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private struct LANODPNBKCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public AFJEGAJNODK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public EAHIPFGMIPN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B5")]
		[Cpp2IlInjected.Address(RVA = "0x62AFCA0", Offset = "0x62AEAA0", VA = "0x1862AFCA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x62B01B0", Offset = "0x62AEFB0", VA = "0x1862B01B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016F")]
	[CompilerGenerated]
	private sealed class PBKBCJHGKNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public PBKBCJHGKNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x62B37B0", Offset = "0x62B25B0", VA = "0x1862B37B0")]
		internal object KHJCOOCEMLB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct BGAOPDMJDAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		public AFJEGAJNODK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		private TaskAwaiter<KPCIENPMIHC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x629F6D0", Offset = "0x629E4D0", VA = "0x18629F6D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x629FD50", Offset = "0x629EB50", VA = "0x18629FD50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000171")]
	[CompilerGenerated]
	private sealed class NECDAPLFNBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public NECDAPLFNBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x62B2320", Offset = "0x62B1120", VA = "0x1862B2320")]
		internal object LEBPBOIDHPG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005B8")]
	private readonly ODJJEDEFBFH HFIAFEMCIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005B9")]
	private JBAAJPLDHKC EMDEBILKIJI;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private GCAFIKPGAJD CNNLFMBEMLK
	{
		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x19F89A0", Offset = "0x19F77A0", VA = "0x1819F89A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x763A40", Offset = "0x762840", VA = "0x180763A40")]
	public AFJEGAJNODK(ODJJEDEFBFH HFIAFEMCIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x629EBB0", Offset = "0x629D9B0", VA = "0x18629EBB0")]
	[AsyncStateMachine(typeof(IPDFLONBMIE))]
	public Task ODBEBJNFCLL(FEDLCPADLNP JLKANFAFLJF, EAHIPFGMIPN MIDOLEMHGEM, EIIPDELDDBE<string>.OABKDIIPOLN JICPEFHJENB, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x629E560", Offset = "0x629D360", VA = "0x18629E560")]
	[AsyncStateMachine(typeof(ENMFFBOOBKK))]
	private Task ICCEFCIGIFB(EAHIPFGMIPN PFDMLBFKIAP, EIIPDELDDBE<string>.OABKDIIPOLN JICPEFHJENB, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x629E7E0", Offset = "0x629D5E0", VA = "0x18629E7E0")]
	[AsyncStateMachine(typeof(PIKJMCLDNBE))]
	private Task KHHDKIDMJGM(EAHIPFGMIPN PFDMLBFKIAP, EIIPDELDDBE<string>.OABKDIIPOLN JICPEFHJENB, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x629E150", Offset = "0x629CF50", VA = "0x18629E150")]
	[AsyncStateMachine(typeof(FDLMKKHEJHI))]
	private Task EGIPGBIAGLL(EAHIPFGMIPN PFDMLBFKIAP, EIIPDELDDBE<string>.OABKDIIPOLN JICPEFHJENB, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x629EE40", Offset = "0x629DC40", VA = "0x18629EE40")]
	[AsyncStateMachine(typeof(PNAMICLFHNB))]
	private Task PMEIFOACBBD(Guid BDIANCEPLPO, List<GOOGEMJEJCB> FLOAHBEMDPF, IPKOFMONAPE JDOAPNOLIEJ, EAHIPFGMIPN PFDMLBFKIAP, CancellationToken PFKLELGAJPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x629E6A0", Offset = "0x629D4A0", VA = "0x18629E6A0")]
	[AsyncStateMachine(typeof(AEBJINKKLFC))]
	private Task IOGNIMMJNFH(EAHIPFGMIPN PFDMLBFKIAP, EIIPDELDDBE<string>.OABKDIIPOLN JICPEFHJENB, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x629E420", Offset = "0x629D220", VA = "0x18629E420")]
	[AsyncStateMachine(typeof(LANODPNBKCD))]
	private Task HAFFHDJAFAF(Guid PLAAKODLILG, EAHIPFGMIPN PFDMLBFKIAP, EIIPDELDDBE<string>.OABKDIIPOLN JICPEFHJENB, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x629ED00", Offset = "0x629DB00", VA = "0x18629ED00")]
	[AsyncStateMachine(typeof(BGAOPDMJDAL))]
	private Task OODIMEGKBFP(Guid PLAAKODLILG, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0x629E030", Offset = "0x629CE30", VA = "0x18629E030")]
	private void ABJJJMOIBDK(Guid PLAAKODLILG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x629EB00", Offset = "0x629D900", VA = "0x18629EB00")]
	private void NKAGJJEGJCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x629E290", Offset = "0x629D090", VA = "0x18629E290")]
	public Guid EJIEJMKBAHG(FEDLCPADLNP MJGELGOLHAI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x629E920", Offset = "0x629D720", VA = "0x18629E920")]
	[CompilerGenerated]
	private object LDLDFCJPOOE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
public readonly struct PPGCPHJKJOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000616")]
	public readonly bool KMMGJCIAOPN;

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0xB2E170", Offset = "0xB2CF70", VA = "0x180B2E170")]
	public PPGCPHJKJOD(bool NBIJFCKNMAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
public readonly struct CCPPDIFNJBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000617")]
	public readonly BNNAHCBMALA? PBIJANGFMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000618")]
	public readonly NKPEKCOEIKE PNPLBCDPIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000619")]
	public readonly string? BFAADCKIDKD;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public IReadOnlyCollection<string> JCHFAGIIFPN
	{
		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x629FDD0", Offset = "0x629EBD0", VA = "0x18629FDD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public IReadOnlyDictionary<long, int> PEMNIHJIPBK
	{
		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x629FDB0", Offset = "0x629EBB0", VA = "0x18629FDB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0x629FDF0", Offset = "0x629EBF0", VA = "0x18629FDF0")]
	public CCPPDIFNJBM(BNNAHCBMALA? MFKPIJLKLHA, NKPEKCOEIKE BLICPCDBAFN, string? OBCNALAKINJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
internal class DIDCBHHLALC : FBAAFAMKBFA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct PKLLPPPFKBG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		public AsyncTaskMethodBuilder<CCPPDIFNJBM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public DIDCBHHLALC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public HBIMDAADLCM serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public LGCKKPDPBBM roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		private IEnumerable<PersistenceView> <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x62B47A0", Offset = "0x62B35A0", VA = "0x1862B47A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x62B4E40", Offset = "0x62B3C40", VA = "0x1862B4E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000177")]
	[CompilerGenerated]
	private sealed class LINEFHKBECO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public HBIMDAADLCM serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		public DIDCBHHLALC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public LINEFHKBECO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x62B05A0", Offset = "0x62AF3A0", VA = "0x1862B05A0")]
		internal Task DDPGFPHELIB(PersistenceView v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x62B07C0", Offset = "0x62AF5C0", VA = "0x1862B07C0")]
		internal Task OBNKNLOBLNE(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private sealed class MMDBKOMHABN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		public float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400062D")]
		public LINEFHKBECO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public MMDBKOMHABN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x62B1A00", Offset = "0x62B0800", VA = "0x1862B1A00")]
		internal object EIIHEJNIGPB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class IJLKADLLDNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400062E")]
		public PersistenceView v;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400062F")]
		public LINEFHKBECO CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public IJLKADLLDNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x62ABDA0", Offset = "0x62AABA0", VA = "0x1862ABDA0")]
		internal Task CLDGBGDJLMP(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017B")]
	[CompilerGenerated]
	private struct HINAFFAGMCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public HBIMDAADLCM serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public DIDCBHHLALC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		public IEnumerable<PersistenceView> activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private MMDBKOMHABN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x62A9520", Offset = "0x62A8320", VA = "0x1862A9520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x62A9DE0", Offset = "0x62A8BE0", VA = "0x1862A9DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400061A")]
	private readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x400061B")]
	private static readonly TimeSpan GPCMMJNKBNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400061C")]
	private readonly DKNLHJKNBOO JCABBLDANIP;

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0x62A3660", Offset = "0x62A2460", VA = "0x1862A3660")]
	public DIDCBHHLALC(ODJJEDEFBFH HFIAFEMCIEL, DKNLHJKNBOO JCABBLDANIP, GKFGDEJLFAD CGHEBMJOFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0x62A28D0", Offset = "0x62A16D0", VA = "0x1862A28D0")]
	[AsyncStateMachine(typeof(PKLLPPPFKBG))]
	public Task<CCPPDIFNJBM> GKMCGBDALGF(long OBPCIAFLNJK, LGCKKPDPBBM BBOBBFHBGOJ, HBIMDAADLCM LJGFDMBCNCG, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0x62A2780", Offset = "0x62A1580", VA = "0x1862A2780")]
	[AsyncStateMachine(typeof(HINAFFAGMCJ))]
	private Task GBJLCABOLCH(HBIMDAADLCM LJGFDMBCNCG, IEnumerable<PersistenceView> JBNPHDAKIKC, StringBuilder NHENEAENGHO, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0x62A3150", Offset = "0x62A1F50", VA = "0x1862A3150")]
	private CCPPDIFNJBM KNGJJHDIJAJ(long OBPCIAFLNJK, LGCKKPDPBBM BBOBBFHBGOJ, HBIMDAADLCM LJGFDMBCNCG, IEnumerable<PersistenceView> JBNPHDAKIKC, StringBuilder NHENEAENGHO)
	{
		return default(CCPPDIFNJBM);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0x62A25C0", Offset = "0x62A13C0", VA = "0x1862A25C0")]
	private BNNAHCBMALA DJKKJKPIOPH(long OBPCIAFLNJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0x62A2A30", Offset = "0x62A1830", VA = "0x1862A2A30")]
	private void JJFKFEJNIHF(BNNAHCBMALA FONIHPPLBKB, StringBuilder NHENEAENGHO, IEnumerable<PersistenceView> JBNPHDAKIKC, [In] HMAKMLLEGCB HHNIDIHBAFA, OKKKKFEMHMB JEKDEGEELKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0x62A2C80", Offset = "0x62A1A80", VA = "0x1862A2C80")]
	private void KJEHCGFLNMD(BNNAHCBMALA FONIHPPLBKB, StringBuilder NHENEAENGHO, PersistenceView IHHDBAHIMPL, OKKKKFEMHMB JEKDEGEELKH, [In] HMAKMLLEGCB HHNIDIHBAFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
internal class PGOPLLHDMBJ : FBAAFAMKBFA
{
	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private sealed class GPBFLENEJLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		public JOIBFHNBMAM.NPDHONCMECO roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public GPBFLENEJLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x62A8850", Offset = "0x62A7650", VA = "0x1862A8850")]
		internal object KBEFADDMCPG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private struct NBLAFFCFNEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public AsyncTaskMethodBuilder<(JOIBFHNBMAM.NPDHONCMECO roomDataUpload, JOIBFHNBMAM.NPDHONCMECO subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public CCPPDIFNJBM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public PGOPLLHDMBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private GPBFLENEJLN <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private TaskAwaiter<JOIBFHNBMAM.NPDHONCMECO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x62B1A70", Offset = "0x62B0870", VA = "0x1862B1A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x62B22B0", Offset = "0x62B10B0", VA = "0x1862B22B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017F")]
	[CompilerGenerated]
	private struct AAMIFDDGLAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public AsyncTaskMethodBuilder<EDLOAKHJMNO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public PGOPLLHDMBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public CCPPDIFNJBM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		public LEMPGINLPKF roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000653")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		private TaskAwaiter<(JOIBFHNBMAM.NPDHONCMECO roomDataUpload, JOIBFHNBMAM.NPDHONCMECO subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		private TaskAwaiter<EDLOAKHJMNO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005E8")]
		[Cpp2IlInjected.Address(RVA = "0x629D390", Offset = "0x629C190", VA = "0x18629D390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E9")]
		[Cpp2IlInjected.Address(RVA = "0x629D9B0", Offset = "0x629C7B0", VA = "0x18629D9B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct HHKCOKADICO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public AsyncTaskMethodBuilder<JDABFNMFCMB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public PGOPLLHDMBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public CCPPDIFNJBM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private TaskAwaiter<(JOIBFHNBMAM.NPDHONCMECO roomDataUpload, JOIBFHNBMAM.NPDHONCMECO subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private TaskAwaiter<JDABFNMFCMB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x62A9090", Offset = "0x62A7E90", VA = "0x1862A9090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x62A94B0", Offset = "0x62A82B0", VA = "0x1862A94B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private sealed class DAEHGMAJEMI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000182")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000668")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000669")]
			public AsyncTaskMethodBuilder<KPCIENPMIHC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400066A")]
			public DAEHGMAJEMI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400066B")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400066C")]
			private KPCIENPMIHC <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400066D")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400066E")]
			private TaskAwaiter<JDABFNMFCMB> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400066F")]
			private TaskAwaiter<EDLOAKHJMNO> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000670")]
			private TaskAwaiter<KPCIENPMIHC> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0x62B5900", Offset = "0x62B4700", VA = "0x1862B5900", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x62B6900", Offset = "0x62B5700", VA = "0x1862B6900", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public PGOPLLHDMBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public CCPPDIFNJBM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		public LEMPGINLPKF roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		public PPGCPHJKJOD roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60005EC")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public DAEHGMAJEMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x62A14E0", Offset = "0x62A02E0", VA = "0x1862A14E0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<KPCIENPMIHC> PADNOKJDIKJ(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private struct MAHJAIADFBP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public AsyncTaskMethodBuilder<KPCIENPMIHC> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public PGOPLLHDMBJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		public CCPPDIFNJBM roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		public LEMPGINLPKF roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		public PPGCPHJKJOD roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public EIIPDELDDBE<string>.OABKDIIPOLN stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private TaskAwaiter<KPCIENPMIHC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x62B0F90", Offset = "0x62AFD90", VA = "0x1862B0F90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x62B12A0", Offset = "0x62B00A0", VA = "0x1862B12A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400063F")]
	private static readonly GKFGDEJLFAD CGHEBMJOFGL;

	[Cpp2IlInjected.Token(Token = "0x4000640")]
	private static readonly GKFGDEJLFAD ADMHBJMMGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000641")]
	private readonly DFALPJPJPOL GGINEBEOIHB;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private DNDAMAFFFKG DGENPFONCPC
	{
		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x62995D0", Offset = "0x62983D0", VA = "0x1862995D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x62B4050", Offset = "0x62B2E50", VA = "0x1862B4050")]
	public PGOPLLHDMBJ(ODJJEDEFBFH HFIAFEMCIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x62B3D00", Offset = "0x62B2B00", VA = "0x1862B3D00")]
	[AsyncStateMachine(typeof(NBLAFFCFNEJ))]
	private Task<(JOIBFHNBMAM.NPDHONCMECO, JOIBFHNBMAM.NPDHONCMECO)> BKLNBNDJAPN(CCPPDIFNJBM OBDJDLGBOHF, long NGLNDFKLBFL, long PIJEGGFFPOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0x62B3B90", Offset = "0x62B2990", VA = "0x1862B3B90")]
	[AsyncStateMachine(typeof(AAMIFDDGLAM))]
	public Task<EDLOAKHJMNO> BFFJCOPBNHL(int KGBEDEDLIBF, [CanBeNull] LEMPGINLPKF GNMNCHGMMOK, CCPPDIFNJBM OBDJDLGBOHF, long NGLNDFKLBFL, long PIJEGGFFPOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0x62B3E40", Offset = "0x62B2C40", VA = "0x1862B3E40")]
	[AsyncStateMachine(typeof(HHKCOKADICO))]
	private Task<JDABFNMFCMB> PFGLJOIEKGP(string KHKBFBOFMIB, int KGBEDEDLIBF, CCPPDIFNJBM OBDJDLGBOHF, long NGLNDFKLBFL, long PIJEGGFFPOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x62B39F0", Offset = "0x62B27F0", VA = "0x1862B39F0")]
	[AsyncStateMachine(typeof(MAHJAIADFBP))]
	public Task<KPCIENPMIHC> AHEGOOMMFOL(int KGBEDEDLIBF, LEMPGINLPKF? GNMNCHGMMOK, CCPPDIFNJBM OBDJDLGBOHF, long NGLNDFKLBFL, long PIJEGGFFPOI, PPGCPHJKJOD HFCHACAOOHA, EIIPDELDDBE<string>.OABKDIIPOLN GGMBBLAPJAN, CancellationToken BIBHFGFDEGJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
public abstract class HOENKHGEDGI<T> where T : HOENKHGEDGI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400067D")]
	internal readonly DNDAMAFFFKG MOHPDGNPDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400067E")]
	private int? EIAPBBMGFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400067F")]
	protected readonly Guid PADBNNKLAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000680")]
	protected readonly CCGFFOEKILI LMOMKFBEEIC;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	protected T GGGNNDOFPMN
	{
		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x35AC130", Offset = "0x35AAF30", VA = "0x1835AC130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0x35AC420", Offset = "0x35AB220", VA = "0x1835AC420")]
	internal HOENKHGEDGI(DNDAMAFFFKG AFFHNKNLNLI, CCGFFOEKILI AJEBLIPDGBH, [Optional] Guid? HMFDPJCPEKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0x35AC340", Offset = "0x35AB140", VA = "0x1835AC340")]
	private KPCIENPMIHC LHCMJLNGIDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "4")]
	protected virtual void JADENBHGBBJ(KPCIENPMIHC JIGBFCEILIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0x35AC2B0", Offset = "0x35AB0B0", VA = "0x1835AC2B0")]
	public T KDOEEEEHNBH(GHMIEPPMENM GMGHMLHOMNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0x35AC0A0", Offset = "0x35AAEA0", VA = "0x1835AC0A0")]
	public T AKPNLMABNEA(int FFHDJHOCHMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0x35AC190", Offset = "0x35AAF90", VA = "0x1835AC190", Slot = "5")]
	public virtual Task<HNLJAOBELNP> IJEFMJCFIMO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
public class CKFEPBOEKJB : HOENKHGEDGI<CKFEPBOEKJB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000681")]
	private FGGFFJJDOJP JPGMJABDIAJ;

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0x62A0C70", Offset = "0x629FA70", VA = "0x1862A0C70")]
	internal CKFEPBOEKJB(DNDAMAFFFKG AFFHNKNLNLI, CCGFFOEKILI AJEBLIPDGBH, [Optional] Guid? HMFDPJCPEKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0x598D6A0", Offset = "0x598C4A0", VA = "0x18598D6A0")]
	public CKFEPBOEKJB MNAMCCMNELM(FGGFFJJDOJP JPGMJABDIAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0x62A0BA0", Offset = "0x629F9A0", VA = "0x1862A0BA0", Slot = "4")]
	protected override void JADENBHGBBJ(KPCIENPMIHC JIGBFCEILIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
public class FDIKFKHJJGH : HOENKHGEDGI<FDIKFKHJJGH>
{
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	internal enum IDMLCKCLMFA
	{
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000188")]
	[CompilerGenerated]
	private struct IPDFOKNPABB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		public AsyncTaskMethodBuilder<HNLJAOBELNP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		public FDIKFKHJJGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private TaskAwaiter<HNLJAOBELNP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x62ACB90", Offset = "0x62AB990", VA = "0x1862ACB90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x62ACF40", Offset = "0x62ABD40", VA = "0x1862ACF40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000682")]
	private IDMLCKCLMFA CGCIHPBOJCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000683")]
	private string IBDHMCCJLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000684")]
	private LEMPGINLPKF JPGMJABDIAJ;

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0x62A4A30", Offset = "0x62A3830", VA = "0x1862A4A30")]
	internal FDIKFKHJJGH(DNDAMAFFFKG AFFHNKNLNLI, CCGFFOEKILI AJEBLIPDGBH, [Optional] Guid? HMFDPJCPEKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0x62A4740", Offset = "0x62A3540", VA = "0x1862A4740")]
	public FDIKFKHJJGH EFHMDFBEAND(string IDLENODONKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x62A49D0", Offset = "0x62A37D0", VA = "0x1862A49D0")]
	public FDIKFKHJJGH KKCBHMGMCNK(bool LDCMMCMOALH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x62A4710", Offset = "0x62A3510", VA = "0x1862A4710")]
	public FDIKFKHJJGH BBPHOHFCJGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x62A4860", Offset = "0x62A3660", VA = "0x1862A4860", Slot = "4")]
	protected override void JADENBHGBBJ(KPCIENPMIHC JIGBFCEILIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0x62A4770", Offset = "0x62A3570", VA = "0x1862A4770", Slot = "5")]
	[AsyncStateMachine(typeof(IPDFOKNPABB))]
	public override Task<HNLJAOBELNP> IJEFMJCFIMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0x62A49F0", Offset = "0x62A37F0", VA = "0x1862A49F0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<HNLJAOBELNP> OHLGPJBMLFO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000189")]
internal static class PEAIIMKADAN
{
	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x62B3820", Offset = "0x62B2620", VA = "0x1862B3820")]
	public static void BCBDJHBDAFB(this EAKMPIGGJPJ EODPPBHALGM, JCOMCEDKFBJ IKHBPKDFHBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x62B3970", Offset = "0x62B2770", VA = "0x1862B3970")]
	public static void BCDMMECLIEF(this JCOMCEDKFBJ AFGDLPFNIII, [Optional] string JIGBFCEILIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
public static class HANDNECMFGC
{
	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x62A8950", Offset = "0x62A7750", VA = "0x1862A8950")]
	public static GENLCBECCME MBEOLGPCLPI(this ALANGLHBPEL CGEOMLBOPJN)
	{
		return default(GENLCBECCME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x62A88A0", Offset = "0x62A76A0", VA = "0x1862A88A0")]
	public static ALANGLHBPEL JEFIEGLHEHJ(this GENLCBECCME OLLBNLPMOAA)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x200018B")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200018C")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000691")]
			public FIIKENPCBCI ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000692")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000693")]
			public FIIKENPCBCI HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000694")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000695")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000696")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400068E")]
		private static FIIKENPCBCI[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private Dictionary<FIIKENPCBCI, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x62B7140", Offset = "0x62B5F40", VA = "0x1862B7140")]
		public bool OOFKPMNHAMK(FIIKENPCBCI PPPGELCICGP, [Out] ResultConfig OMPKHLFKKJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x62B7000", Offset = "0x62B5E00", VA = "0x1862B7000")]
		public ResultConfig EDFKJJALPMH(FIIKENPCBCI GHFGMAKMGKH, [Optional] HashSet<FIIKENPCBCI> BOPJFFFCMMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x62B7710", Offset = "0x62B6510", VA = "0x1862B7710", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x62B71B0", Offset = "0x62B5FB0", VA = "0x1862B71B0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x84D6F0", Offset = "0x84C4F0", VA = "0x18084D6F0")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
public static class NKHDDHGGCHF
{
	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x62B2390", Offset = "0x62B1190", VA = "0x1862B2390")]
	[GAPOPKHLLNB(OGJCEJIMIKL.GameOnly)]
	private static void CMFPJFHGGNL(OILPPPCALMB IDMCGGBGLJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
public interface JBIBDPPGHNE : IEquatable<JBIBDPPGHNE>
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	DateTime HAALKGGJFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKBEKGLKPGD();

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PJINGNEBKIN(long NGLNDFKLBFL, long OBPCIAFLNJK, [Out] CCPPDIFNJBM OBDJDLGBOHF);
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
internal class GENMPKPIAKN : JFLIKILMHEH
{
	[Cpp2IlInjected.Token(Token = "0x2000191")]
	[CompilerGenerated]
	private sealed class BDIDJMMJJBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		public KCBBPOFPKPE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public BDIDJMMJJBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x629F660", Offset = "0x629E460", VA = "0x18629F660")]
		internal object LPIPDPIJCML()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400069C")]
	private readonly PLKIHPFHEAC DIDELPNILNM;

	[Cpp2IlInjected.Token(Token = "0x14000020")]
	public event Action<JBIBDPPGHNE> BDNIAGMKNGP
	{
		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x62A8720", Offset = "0x62A7520", VA = "0x1862A8720", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600061B")]
		[Cpp2IlInjected.Address(RVA = "0x62A8190", Offset = "0x62A6F90", VA = "0x1862A8190", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x763A40", Offset = "0x762840", VA = "0x180763A40")]
	[UnityEngine.Scripting.Preserve]
	public GENMPKPIAKN([NMBHAKGIBHG(null)] PLKIHPFHEAC DIDELPNILNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x62A7EB0", Offset = "0x62A6CB0", VA = "0x1862A7EB0", Slot = "6")]
	public bool HMIDDKFCKJF(long NGLNDFKLBFL, long OBPCIAFLNJK, CCPPDIFNJBM OBDJDLGBOHF, KCBBPOFPKPE CCEKALLPEJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0x17EE1C0", Offset = "0x17ECFC0", VA = "0x1817EE1C0")]
	private void LLLIJIJBKIM(JBIBDPPGHNE KEFDGELDJDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x62A7C10", Offset = "0x62A6A10", VA = "0x1862A7C10", Slot = "7")]
	public bool DHMAACHMBAJ(long NGLNDFKLBFL, long OBPCIAFLNJK, [Out] JBIBDPPGHNE OEAGFPFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x62A8670", Offset = "0x62A7470", VA = "0x1862A8670", Slot = "8")]
	public bool ONFMAACNEMG(long NGLNDFKLBFL, long OBPCIAFLNJK, KCBBPOFPKPE CCEKALLPEJN, [Out] JBIBDPPGHNE OEAGFPFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x62A8240", Offset = "0x62A7040", VA = "0x1862A8240")]
	private void NENAHHKHLID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x62A7D80", Offset = "0x62A6B80", VA = "0x1862A7D80", Slot = "9")]
	public void FIBPMHLMFAC(long NGLNDFKLBFL, long OBPCIAFLNJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
internal abstract class IAKBCIACEEH : PLKIHPFHEAC
{
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	protected enum BFHILIGKHBA : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	private sealed class HPCGFNKGIEG : IEnumerable<JBIBDPPGHNE>, IEnumerable, IEnumerator<JBIBDPPGHNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		private JBIBDPPGHNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		public IAKBCIACEEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private KCBBPOFPKPE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		public KCBBPOFPKPE <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		private JBIBDPPGHNE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000639")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000634")]
		[Cpp2IlInjected.Address(RVA = "0x863A90", Offset = "0x862890", VA = "0x180863A90")]
		[DebuggerHidden]
		public HPCGFNKGIEG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000635")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x62AA190", Offset = "0x62A8F90", VA = "0x1862AA190", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0x62AA470", Offset = "0x62A9270", VA = "0x1862AA470", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x62AA3C0", Offset = "0x62A91C0", VA = "0x1862AA3C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JBIBDPPGHNE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x62AA3C0", Offset = "0x62A91C0", VA = "0x1862AA3C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000196")]
	[CompilerGenerated]
	private sealed class CGNMOMOICEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public KCBBPOFPKPE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public CGNMOMOICEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0x62A0A80", Offset = "0x629F880", VA = "0x1862A0A80")]
		internal object AIKFBBJGPPK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000197")]
	[CompilerGenerated]
	private sealed class CHLKENJBJAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public IAKBCIACEEH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		public CHLKENJBJAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x62A0B20", Offset = "0x629F920", VA = "0x1862A0B20")]
		internal void BCAEPLIHMKP(KGEBNOLCFDE.COHMGPGFFDM ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006A2")]
	protected readonly string CMFLMCFGJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006A3")]
	private readonly object PKJBLJGBDLJ;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public abstract AOFKPJHCJNE OGADLHFBNJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x62AAEC0", Offset = "0x62A9CC0", VA = "0x1862AAEC0")]
	protected IAKBCIACEEH([CanBeNull] string BCCENKMDFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x62AA850", Offset = "0x62A9650", VA = "0x1862AA850", Slot = "5")]
	public bool JBDPBCACMGE(long NGLNDFKLBFL, long OBPCIAFLNJK, KCBBPOFPKPE CCEKALLPEJN, [Out] JBIBDPPGHNE KEFDGELDJDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x62AAA40", Offset = "0x62A9840", VA = "0x1862AAA40", Slot = "6")]
	[IteratorStateMachine(typeof(HPCGFNKGIEG))]
	public IEnumerable<JBIBDPPGHNE> JGODDAELDFJ(KCBBPOFPKPE CCEKALLPEJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void FFJBDMDBNBI(Stream OBKJIEFBEIK, long NGLNDFKLBFL, long OBPCIAFLNJK, CCPPDIFNJBM OBDJDLGBOHF);

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool HALMEGKENJL(Stream PIBEEMAAJMI, long NGLNDFKLBFL, long OBPCIAFLNJK, OJGMEJHOEPO LMHCCBIIAGA, [Out] CCPPDIFNJBM OBDJDLGBOHF);

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x62AAAD0", Offset = "0x62A98D0", VA = "0x1862AAAD0", Slot = "7")]
	public JBIBDPPGHNE LPDHCEOBDGE(long NGLNDFKLBFL, long OBPCIAFLNJK, CCPPDIFNJBM OBDJDLGBOHF, KCBBPOFPKPE CCEKALLPEJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo NCBLLLODGHD(long NGLNDFKLBFL, long OBPCIAFLNJK, KCBBPOFPKPE CCEKALLPEJN, BFHILIGKHBA EFJKBPPBLDD);

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo LLFOAODPDNK(KCBBPOFPKPE CCEKALLPEJN, BFHILIGKHBA EFJKBPPBLDD);

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x62AAE50", Offset = "0x62A9C50", VA = "0x1862AAE50")]
	protected void OMJCDMIAKOP(KGEBNOLCFDE.COHMGPGFFDM BJMGNMNEEOL, string EMHIALHDHFI, FileInfo OFCPANNHEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x62AA4C0", Offset = "0x62A92C0", VA = "0x1862AA4C0")]
	internal bool FGBNIFELFJK(FileInfo NBMPIJFLGFM, long NGLNDFKLBFL, long OBPCIAFLNJK, [Out] CCPPDIFNJBM OBDJDLGBOHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0")]
	private void OFCPPPNMOBJ(Exception BJAHINDBFGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
internal class DBBLEIMPDHN : IAKBCIACEEH
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public override AOFKPJHCJNE OGADLHFBNJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0xA4A4E0", Offset = "0xA492E0", VA = "0x180A4A4E0", Slot = "8")]
		get
		{
			return default(AOFKPJHCJNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x62A2170", Offset = "0x62A0F70", VA = "0x1862A2170")]
	public DBBLEIMPDHN([Optional] string BCCENKMDFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0x62A20F0", Offset = "0x62A0EF0", VA = "0x1862A20F0")]
	private void PLJPHFCAHLC(KCBBPOFPKPE CCEKALLPEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0x62A1610", Offset = "0x62A0410", VA = "0x1862A1610", Slot = "9")]
	internal override void FFJBDMDBNBI(Stream OBKJIEFBEIK, long NGLNDFKLBFL, long OBPCIAFLNJK, CCPPDIFNJBM OBDJDLGBOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0x62A18A0", Offset = "0x62A06A0", VA = "0x1862A18A0", Slot = "10")]
	internal override bool HALMEGKENJL(Stream PIBEEMAAJMI, long NGLNDFKLBFL, long OBPCIAFLNJK, OJGMEJHOEPO LMHCCBIIAGA, [Out] CCPPDIFNJBM OBDJDLGBOHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0x62A2000", Offset = "0x62A0E00", VA = "0x1862A2000", Slot = "11")]
	protected override FileInfo NCBLLLODGHD(long NGLNDFKLBFL, long OBPCIAFLNJK, KCBBPOFPKPE CCEKALLPEJN, BFHILIGKHBA EFJKBPPBLDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x62A1EF0", Offset = "0x62A0CF0", VA = "0x1862A1EF0", Slot = "12")]
	protected override DirectoryInfo LLFOAODPDNK(KCBBPOFPKPE CCEKALLPEJN, BFHILIGKHBA EFJKBPPBLDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
internal sealed class JIKFDMOILOD : IAKBCIACEEH
{
	[Cpp2IlInjected.Token(Token = "0x40006B3")]
	private static readonly byte[] JLDFGFPAIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40006B4")]
	private readonly byte[] NOJJHFCBGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006B5")]
	private readonly byte[] HFGGOCCOABJ;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public override AOFKPJHCJNE OGADLHFBNJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x52AFA80", Offset = "0x52AE880", VA = "0x1852AFA80", Slot = "8")]
		get
		{
			return default(AOFKPJHCJNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0x62AE690", Offset = "0x62AD490", VA = "0x1862AE690")]
	public JIKFDMOILOD([Optional] string BCCENKMDFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x62AD810", Offset = "0x62AC610", VA = "0x1862AD810", Slot = "9")]
	internal override void FFJBDMDBNBI(Stream OBKJIEFBEIK, long NGLNDFKLBFL, long OBPCIAFLNJK, CCPPDIFNJBM OBDJDLGBOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0x62ADAD0", Offset = "0x62AC8D0", VA = "0x1862ADAD0", Slot = "10")]
	internal override bool HALMEGKENJL(Stream PIBEEMAAJMI, long NGLNDFKLBFL, long OBPCIAFLNJK, OJGMEJHOEPO LMHCCBIIAGA, [Out] CCPPDIFNJBM OBDJDLGBOHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0x62AE540", Offset = "0x62AD340", VA = "0x1862AE540")]
	private void OBEKMCGHELD(byte[] AFIEJCAINEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x62AE410", Offset = "0x62AD210", VA = "0x1862AE410", Slot = "11")]
	protected override FileInfo NCBLLLODGHD(long NGLNDFKLBFL, long OBPCIAFLNJK, KCBBPOFPKPE CCEKALLPEJN, BFHILIGKHBA EFJKBPPBLDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x62AE300", Offset = "0x62AD100", VA = "0x1862AE300", Slot = "12")]
	protected override DirectoryInfo LLFOAODPDNK(KCBBPOFPKPE CCEKALLPEJN, BFHILIGKHBA EFJKBPPBLDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
public enum AOFKPJHCJNE : byte
{
	[Cpp2IlInjected.Token(Token = "0x40006B7")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x40006B8")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x40006B9")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
internal class JCENCGKIBAK : PLKIHPFHEAC
{
	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[CompilerGenerated]
	private sealed class IIPMDHAGACA : IEnumerable<JBIBDPPGHNE>, IEnumerable, IEnumerator<JBIBDPPGHNE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private JBIBDPPGHNE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public JCENCGKIBAK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		private KCBBPOFPKPE autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public KCBBPOFPKPE <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		private AOFKPJHCJNE[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		private IEnumerator<JBIBDPPGHNE> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		private JBIBDPPGHNE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000660")]
			[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x863A90", Offset = "0x862890", VA = "0x180863A90")]
		[DebuggerHidden]
		public IIPMDHAGACA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x62ABD10", Offset = "0x62AAB10", VA = "0x1862ABD10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x62AB930", Offset = "0x62AA730", VA = "0x1862AB930", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x62AB8E0", Offset = "0x62AA6E0", VA = "0x1862AB8E0")]
		private void MPOCHKHBDOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x62ABCC0", Offset = "0x62AAAC0", VA = "0x1862ABCC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x62ABC10", Offset = "0x62AAA10", VA = "0x1862ABC10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<JBIBDPPGHNE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0x62ABC10", Offset = "0x62AAA10", VA = "0x1862ABC10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006BA")]
	private readonly AOFKPJHCJNE[] FFECNFACMLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006BB")]
	private readonly Dictionary<AOFKPJHCJNE, PLKIHPFHEAC> JFFPOLNPHMB;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public AOFKPJHCJNE OGADLHFBNJL
	{
		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x62AD490", Offset = "0x62AC290", VA = "0x1862AD490", Slot = "4")]
		get
		{
			return default(AOFKPJHCJNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0x62AD4C0", Offset = "0x62AC2C0", VA = "0x1862AD4C0")]
	[UnityEngine.Scripting.Preserve]
	public JCENCGKIBAK(params PLKIHPFHEAC[] CMOPNKNBNNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x62ACFB0", Offset = "0x62ABDB0", VA = "0x1862ACFB0", Slot = "5")]
	public bool JBDPBCACMGE(long NGLNDFKLBFL, long OBPCIAFLNJK, KCBBPOFPKPE CCEKALLPEJN, [Out] JBIBDPPGHNE KEFDGELDJDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0x62AD190", Offset = "0x62ABF90", VA = "0x1862AD190")]
	private void JHHGHGAOLHF(int FGOOMAAACDP, long NGLNDFKLBFL, long OBPCIAFLNJK, KCBBPOFPKPE CCEKALLPEJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x62AD100", Offset = "0x62ABF00", VA = "0x1862AD100", Slot = "6")]
	[IteratorStateMachine(typeof(IIPMDHAGACA))]
	public IEnumerable<JBIBDPPGHNE> JGODDAELDFJ(KCBBPOFPKPE CCEKALLPEJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x62AD3B0", Offset = "0x62AC1B0", VA = "0x1862AD3B0", Slot = "7")]
	public JBIBDPPGHNE LPDHCEOBDGE(long NGLNDFKLBFL, long OBPCIAFLNJK, CCPPDIFNJBM OBDJDLGBOHF, KCBBPOFPKPE CCEKALLPEJN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
internal static class OMPAHAICIAM
{
	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x62B36F0", Offset = "0x62B24F0", VA = "0x1862B36F0")]
	internal static byte[] KBCDDEPEMMA(byte[] AFIEJCAINEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x62B3670", Offset = "0x62B2470", VA = "0x1862B3670")]
	public static void IJAEDDIOPHN(Stream MMGOENDACIH, byte[] KNLCBDHFNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x62B3490", Offset = "0x62B2290", VA = "0x1862B3490")]
	public static bool GABJENALIIE(Stream MMGOENDACIH, long PHLHCELCCOP, OJGMEJHOEPO ABNLFNDICLN, [Out] byte[] PJKCNHHLKKD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
internal sealed class HFEDEGPNHMP : JBIBDPPGHNE, IEquatable<JBIBDPPGHNE>, IEquatable<HFEDEGPNHMP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006C9")]
	private readonly IAKBCIACEEH JLFBEAPGAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006CA")]
	public readonly FileInfo BPADLEPEJJA;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public AOFKPJHCJNE OGADLHFBNJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x62A8E60", Offset = "0x62A7C60", VA = "0x1862A8E60", Slot = "9")]
		get
		{
			return default(AOFKPJHCJNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public DateTime HAALKGGJFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x62A8DD0", Offset = "0x62A7BD0", VA = "0x1862A8DD0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x62A8F80", Offset = "0x62A7D80", VA = "0x1862A8F80")]
	public HFEDEGPNHMP(IAKBCIACEEH ODCNAIKFNMP, FileInfo NBMPIJFLGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x62A8ED0", Offset = "0x62A7CD0", VA = "0x1862A8ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x62A89F0", Offset = "0x62A77F0", VA = "0x1862A89F0", Slot = "5")]
	public void DKBEKGLKPGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x62A8E90", Offset = "0x62A7C90", VA = "0x1862A8E90", Slot = "6")]
	public bool PJINGNEBKIN(long NGLNDFKLBFL, long OBPCIAFLNJK, [Out] CCPPDIFNJBM OBDJDLGBOHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0x62A8B70", Offset = "0x62A7970", VA = "0x1862A8B70", Slot = "7")]
	public bool Equals(JBIBDPPGHNE MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0x62A8AB0", Offset = "0x62A78B0", VA = "0x1862A8AB0", Slot = "8")]
	public bool Equals(HFEDEGPNHMP MFMJJEFODHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x62A8C50", Offset = "0x62A7A50", VA = "0x1862A8C50", Slot = "0")]
	public override bool Equals(object HBDENJGMDDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x62A8D40", Offset = "0x62A7B40", VA = "0x1862A8D40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
public delegate void OJGMEJHOEPO(KGEBNOLCFDE.COHMGPGFFDM DOLJEGHBGMN, string JIGBFCEILIK);
[Cpp2IlInjected.Token(Token = "0x20001A1")]
internal interface PLKIHPFHEAC
{
	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	AOFKPJHCJNE OGADLHFBNJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JBDPBCACMGE(long NGLNDFKLBFL, long OBPCIAFLNJK, KCBBPOFPKPE CCEKALLPEJN, [Out] JBIBDPPGHNE KEFDGELDJDB);

	[Cpp2IlInjected.Token(Token = "0x6000674")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<JBIBDPPGHNE> JGODDAELDFJ(KCBBPOFPKPE CCEKALLPEJN);

	[Cpp2IlInjected.Token(Token = "0x6000675")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JBIBDPPGHNE LPDHCEOBDGE(long NGLNDFKLBFL, long OBPCIAFLNJK, CCPPDIFNJBM OBDJDLGBOHF, KCBBPOFPKPE CCEKALLPEJN);
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
