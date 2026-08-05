using System;
using System.Buffers;
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
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
using RecRoom.Persistence;
using Unity.Profiling;
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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8DA0770", Offset = "0x8D9F170", VA = "0x188DA0770")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class GBKGIJBJPLI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal Task<LHOHOJEJAHO> MLEMBEMGKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal Task AHGILBELFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal EAOBOKAGIGN NCBHLHEGHGB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public GBKGIJBJPLI()
	{
	}
}
namespace _LogRegistration.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8D9D360", Offset = "0x8D9BD60", VA = "0x188D9D360", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8DA3930", Offset = "0x8DA2330", VA = "0x188DA3930", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x29CDED0", Offset = "0x29CC8D0", VA = "0x1829CDED0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class JMPHGEJPNBF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8D954B0", Offset = "0x8D93EB0", VA = "0x188D954B0")]
	public JMPHGEJPNBF(string JEBOHIALEMJ, Exception BFLPFMDLFDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal class IKFICHGCJDC : CGAHEIPDMKF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct MKLFHOGDKGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<IReadOnlyList<INDFDDFMNAH>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private TaskAwaiter<CKLHAHKIHCL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8D9D720", Offset = "0x8D9C120", VA = "0x188D9D720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8D9D960", Offset = "0x8D9C360", VA = "0x188D9D960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct HIOCMKKPHMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<BMCJEMDNANL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<List<BMCJEMDNANL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8D8B2A0", Offset = "0x8D89CA0", VA = "0x188D8B2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8D8B4B0", Offset = "0x8D89EB0", VA = "0x188D8B4B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	[UnityEngine.Scripting.Preserve]
	public IKFICHGCJDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8D8D1B0", Offset = "0x8D8BBB0", VA = "0x188D8D1B0", Slot = "4")]
	[AsyncStateMachine(typeof(MKLFHOGDKGA))]
	public Task<IReadOnlyList<INDFDDFMNAH>> IPIIGDIAIAI(long GDCAPMONNDM, long FMNCJOBEOEF, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8D8D2D0", Offset = "0x8D8BCD0", VA = "0x188D8D2D0", Slot = "5")]
	[AsyncStateMachine(typeof(HIOCMKKPHMM))]
	public Task<IReadOnlyList<BMCJEMDNANL>> MHCIIHHNHCO(IReadOnlyList<int> JBOPBMEBBNP, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface IJODBKNDIJI : IEquatable<IJODBKNDIJI>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int BIMKLLHBLBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	BMCJEMDNANL AMIEFAMPNIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime AKGBIMDIEAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	FDEIDHKCJEA? DFJBEPJPPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	AIIENGDOPBC? FHBPHLHAAKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	KOPEBNNGBCG OIIMCGNDIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<PLLAKKIDGFG> FKFBNFADKOB();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum KOPEBNNGBCG
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CGAHEIPDMKF
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<INDFDDFMNAH>> IPIIGDIAIAI(long GDCAPMONNDM, long FMNCJOBEOEF, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<BMCJEMDNANL>> MHCIIHHNHCO(IReadOnlyList<int> JBOPBMEBBNP, [Optional] CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PLOCMMHIDLO
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class HPJGIIMJPAJ : IJODBKNDIJI, IEquatable<IJODBKNDIJI>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct ANKEAPOFNKG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AsyncTaskMethodBuilder<PLLAKKIDGFG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public HPJGIIMJPAJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private IHINAEDCPHM <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private TaskAwaiter<PKCMPJMLDGM> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private TaskAwaiter<PLLAKKIDGFG> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8D83630", Offset = "0x8D82030", VA = "0x188D83630", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8D83BB0", Offset = "0x8D825B0", VA = "0x188D83BB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly INDFDDFMNAH GMKENGBCIDG;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int BIMKLLHBLBF
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public BMCJEMDNANL AMIEFAMPNIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime EKNBKEPHKPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8D8BCE0", Offset = "0x8D8A6E0", VA = "0x188D8BCE0", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public FDEIDHKCJEA? DFJBEPJPPKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2DE7A50", Offset = "0x2DE6450", VA = "0x182DE7A50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public AIIENGDOPBC? FHBPHLHAAKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8D8B9D0", Offset = "0x8D8A3D0", VA = "0x188D8B9D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public KOPEBNNGBCG OIIMCGNDIGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xC43520", Offset = "0xC41F20", VA = "0x180C43520", Slot = "10")]
			get
			{
				return default(KOPEBNNGBCG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8D8BB20", Offset = "0x8D8A520", VA = "0x188D8BB20", Slot = "9")]
		[AsyncStateMachine(typeof(ANKEAPOFNKG))]
		public Task<PLLAKKIDGFG> FKFBNFADKOB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8D8BD00", Offset = "0x8D8A700", VA = "0x188D8BD00")]
		public HPJGIIMJPAJ(int ALNOKIMLIHP, BMCJEMDNANL IHPFBMAOOEB, INDFDDFMNAH GMKENGBCIDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8D8BA90", Offset = "0x8D8A490", VA = "0x188D8BA90", Slot = "11")]
		public bool Equals(IJODBKNDIJI GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8D8B9F0", Offset = "0x8D8A3F0", VA = "0x188D8B9F0", Slot = "0")]
		public override bool Equals(object PMNHIPACJLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8D8BCA0", Offset = "0x8D8A6A0", VA = "0x188D8BCA0")]
		private bool JMOPGKBMEDK(HPJGIIMJPAJ GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8D8BC20", Offset = "0x8D8A620", VA = "0x188D8BC20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class NAENNBJLJCE : IJODBKNDIJI, IEquatable<IJODBKNDIJI>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct KAEMFLLDEIO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public AsyncTaskMethodBuilder<PLLAKKIDGFG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public NAENNBJLJCE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<PLLAKKIDGFG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8D95F80", Offset = "0x8D94980", VA = "0x188D95F80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8D961D0", Offset = "0x8D94BD0", VA = "0x188D961D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly BNELGABNKPE DMHEFIGJAHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly FDEIDHKCJEA BFMFMOEAAHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly AIIENGDOPBC MGOHHIGOKKB;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int BIMKLLHBLBF
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8D9EAC0", Offset = "0x8D9D4C0", VA = "0x188D9EAC0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BMCJEMDNANL AMIEFAMPNIM
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8D9EB00", Offset = "0x8D9D500", VA = "0x188D9EB00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime EKNBKEPHKPD
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8D9EA70", Offset = "0x8D9D470", VA = "0x188D9EA70", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public FDEIDHKCJEA? DFJBEPJPPKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8D9EB90", Offset = "0x8D9D590", VA = "0x188D9EB90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public AIIENGDOPBC? FHBPHLHAAKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8D9E700", Offset = "0x8D9D100", VA = "0x188D9E700", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public KOPEBNNGBCG OIIMCGNDIGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xC56A80", Offset = "0xC55480", VA = "0x180C56A80", Slot = "10")]
			get
			{
				return default(KOPEBNNGBCG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x21DAF60", Offset = "0x21D9960", VA = "0x1821DAF60")]
		public NAENNBJLJCE(BNELGABNKPE PCGILFJIDOP, FDEIDHKCJEA EACGAJLGFDL, AIIENGDOPBC IHKKGLPPDDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8D9E8A0", Offset = "0x8D9D2A0", VA = "0x188D9E8A0", Slot = "9")]
		[AsyncStateMachine(typeof(KAEMFLLDEIO))]
		public Task<PLLAKKIDGFG> FKFBNFADKOB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8D9E800", Offset = "0x8D9D200", VA = "0x188D9E800", Slot = "11")]
		public bool Equals(IJODBKNDIJI GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8D9E750", Offset = "0x8D9D150", VA = "0x188D9E750", Slot = "0")]
		public override bool Equals(object PMNHIPACJLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8D9EA10", Offset = "0x8D9D410", VA = "0x188D9EA10")]
		private bool JMOPGKBMEDK(NAENNBJLJCE GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8D9E990", Offset = "0x8D9D390", VA = "0x188D9E990", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private sealed class LHLHBGAFLIC : IJODBKNDIJI, IEquatable<IJODBKNDIJI>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private struct AKLNDOLFLIF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public AsyncTaskMethodBuilder<PLLAKKIDGFG> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter<PLLAKKIDGFG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8D83090", Offset = "0x8D81A90", VA = "0x188D83090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8D832F0", Offset = "0x8D81CF0", VA = "0x188D832F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly BMCJEMDNANL MGOFIEAEBOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly FDEIDHKCJEA BFMFMOEAAHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly AIIENGDOPBC MGOHHIGOKKB;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int BIMKLLHBLBF
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8D98540", Offset = "0x8D96F40", VA = "0x188D98540", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public BMCJEMDNANL AMIEFAMPNIM
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime EKNBKEPHKPD
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public FDEIDHKCJEA? DFJBEPJPPKD
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8D98560", Offset = "0x8D96F60", VA = "0x188D98560", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public AIIENGDOPBC? FHBPHLHAAKC
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8D981C0", Offset = "0x8D96BC0", VA = "0x188D981C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public KOPEBNNGBCG OIIMCGNDIGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "10")]
			get
			{
				return default(KOPEBNNGBCG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x21DAF60", Offset = "0x21D9960", VA = "0x1821DAF60")]
		public LHLHBGAFLIC(BMCJEMDNANL IHPFBMAOOEB, FDEIDHKCJEA EACGAJLGFDL, AIIENGDOPBC IHKKGLPPDDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8D98300", Offset = "0x8D96D00", VA = "0x188D98300", Slot = "9")]
		[AsyncStateMachine(typeof(AKLNDOLFLIF))]
		public Task<PLLAKKIDGFG> FKFBNFADKOB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8D98290", Offset = "0x8D96C90", VA = "0x188D98290", Slot = "11")]
		public bool Equals(IJODBKNDIJI GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8D98210", Offset = "0x8D96C10", VA = "0x188D98210", Slot = "0")]
		public override bool Equals(object PMNHIPACJLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8D983D0", Offset = "0x8D96DD0", VA = "0x188D983D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8D98460", Offset = "0x8D96E60", VA = "0x188D98460")]
		private bool JMOPGKBMEDK(LHLHBGAFLIC GOCNHGEHNFD)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct FNCBCFOHAAM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<IList<IJODBKNDIJI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public bool forceRefreshSaveHistoryCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public PLOCMMHIDLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private IReadOnlyList<INDFDDFMNAH> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<IReadOnlyList<INDFDDFMNAH>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<IReadOnlyList<(int accountId, BMCJEMDNANL account, INDFDDFMNAH roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8D89620", Offset = "0x8D88020", VA = "0x188D89620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8D8A460", Offset = "0x8D88E60", VA = "0x188D8A460", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct IIIBIAHLELO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, BMCJEMDNANL account, INDFDDFMNAH roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public IReadOnlyList<INDFDDFMNAH> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public PLOCMMHIDLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<IReadOnlyList<BMCJEMDNANL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8D8C730", Offset = "0x8D8B130", VA = "0x188D8C730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8D8D140", Offset = "0x8D8BB40", VA = "0x188D8D140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly GEHECBHLLJC BAJLDHPLDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly CGAHEIPDMKF LLJMKHEBJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly GAKDHGEKIJL DIFIMGGLEHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly CMLAJHKJHAI<(long, long), IReadOnlyList<INDFDDFMNAH>> OAHFNEAFLFN;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8DA2050", Offset = "0x8DA0A50", VA = "0x188DA2050")]
	[UnityEngine.Scripting.Preserve]
	public PLOCMMHIDLO([BMCONCJPCIA(null)] CGAHEIPDMKF MOAGDAGLEHG, [BMCONCJPCIA(null)] GAKDHGEKIJL JNNFALHMLID, [BMCONCJPCIA(null)] GEHECBHLLJC EPHPEDDCCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8DA1C50", Offset = "0x8DA0650", VA = "0x188DA1C50")]
	[AsyncStateMachine(typeof(FNCBCFOHAAM))]
	public Task<IList<IJODBKNDIJI>> BMBLGALMFCI(long GDCAPMONNDM, long GKOJBHIBFEI, bool CMMLBENLPND = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8DA1DA0", Offset = "0x8DA07A0", VA = "0x188DA1DA0")]
	private bool EGJGEDIKHEM(DateTime? BBONDGHBFEG, long GDCAPMONNDM, long GKOJBHIBFEI, [Out] BNELGABNKPE MGJEEBCIHJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8DA1F40", Offset = "0x8DA0940", VA = "0x188DA1F40")]
	[AsyncStateMachine(typeof(IIIBIAHLELO))]
	private Task<IReadOnlyList<(int, BMCJEMDNANL, INDFDDFMNAH)>> FDMDECFAOFG(IReadOnlyList<INDFDDFMNAH> MNGJDPADIDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface GAKDHGEKIJL
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<BNELGABNKPE> IBCADCGLAFE;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KJMLJIEAALE(long GDCAPMONNDM, long GKOJBHIBFEI, DFPILBGDMFF BPIOIEAKAAD, EPNIDEGAFGC LDBMMHGJBOG);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PCDGPENHBPN(long GDCAPMONNDM, long GKOJBHIBFEI, [Out] BNELGABNKPE MGJEEBCIHJD);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LHPLILBDHCE(long GDCAPMONNDM, long GKOJBHIBFEI, EPNIDEGAFGC LDBMMHGJBOG, [Out] BNELGABNKPE MGJEEBCIHJD);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GJBCEFMPOLC(long GDCAPMONNDM, long GKOJBHIBFEI);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface NJNCDDGFIJG : ANMLBOEMDKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool JGDALFCNDEP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task HJECPFFIIAB
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GGMCKCMOJEB(Task FLAIIHBKGBI, string GDOPEDBKFAA);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface FENHLJCHJGE : ANMLBOEMDKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PLLAKKIDGFG> NHMPPKPACEE(BNELGABNKPE MGJEEBCIHJD);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FBKADDOKDIN(CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface FEHEMDONNPM : ANMLBOEMDKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	BGJPDHDKIOB AIPDFGPJCFO
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CPONDGEBCDL();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MALHPAKHIBE();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface ANMLBOEMDKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFALNPPLGKO(CHMOOPPGDGB NGALMEDAPGH);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal interface OCFAJKILBCD
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan FELHIMCBBAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan MELFLBBFLHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan IMMEBPBPABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan ANFOPNMALJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool FADKJFINKGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool CCDIDAOJJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool KBLFBFOFCPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int NFNMHAPJBNC
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool BIODEJDDJND
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool NMFBDNIGMAM
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool OHFECILDBKF
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum EIKLOIGIKCB
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum LMKGBJJKKKO
{
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	InitialRoomLoad,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	AutoSave,
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	SaveToDisk,
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	SaveToRecNet,
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	RestoreAutoSave,
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct GJIGLAJEIOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly long JEIGPDFAGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly long FMNCJOBEOEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly EIKLOIGIKCB DGNODDPLLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[CanBeNull]
	public readonly Exception ICMEGPJEDJH;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8D8A520", Offset = "0x8D88F20", VA = "0x188D8A520")]
	public GJIGLAJEIOM(long JEIGPDFAGLO, long FMNCJOBEOEF, EIKLOIGIKCB DGNODDPLLPC, [CanBeNull] Exception ICMEGPJEDJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8D8A4D0", Offset = "0x8D88ED0", VA = "0x188D8A4D0")]
	public static GJIGLAJEIOM DIHLONADDEL(IAOKBCEAMNP EGHGMPNMBEL, EIKLOIGIKCB DGNODDPLLPC, [Optional] Exception ICMEGPJEDJH)
	{
		return default(GJIGLAJEIOM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void NCAAEJLIILE(GJIGLAJEIOM MLNHANKLKJM);
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface FPANNDIBPBC : ANMLBOEMDKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event NCAAEJLIILE GFMOHFFMBFM;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event NCAAEJLIILE NACNBONMFCM;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event NCAAEJLIILE FFNLJCKFOPL;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<LMKGBJJKKKO, bool> PFKGNJIMPLH;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DGJBFOFLHNC(GJIGLAJEIOM MLNHANKLKJM);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DGPDKCBPIKB(GJIGLAJEIOM MLNHANKLKJM);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ADKIJHLKELN(GJIGLAJEIOM MLNHANKLKJM);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void HBHPEMCLEMI(LMKGBJJKKKO JCECGKAIEFB, bool GAJICMBGPLH);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface JCKIJAFMFEI : ANMLBOEMDKO, IDisposable, LLFOFNPHDOK
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool DJPNIOPDIFH
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMKNNECMACO();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface NHFIPDDNFBP : ANMLBOEMDKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TaskStatus KAMKMMHBNJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task EFHHJHBOPLK(IAOKBCEAMNP LNJDNBJGCOP, HMHMGFNHAOI BHNBGIMGNCE, CancellationToken ICODIHINNBH);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class CLKFPJMMKOF
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8D85F70", Offset = "0x8D84970", VA = "0x188D85F70")]
	public static bool MGEFHFLPCGH(this NHFIPDDNFBP FKCCFDGGNEJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate Task JKLLJDPDOFE(CancellationToken MFKHKDDANII, int DIOLIHHBDCB, LHDJNPMOIOH FIGFFLDCNGJ);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface NPIAOHCMBCD : ANMLBOEMDKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HPALILEMODP(JKLLJDPDOFE NBLILNHGKBL);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface CHMOOPPGDGB : IHINAEDCPHM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CancellationToken GPAJEFJPBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	JBJKIIKOACK PDOJMJHDBJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	HJKBCKDIADL PMPIJLLBMKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	CAKILKPJFMJ IOMKAHAAKEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	FFHNIMCCMFI BCDAFCHHCGD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	CJKIJIMANDA GCKCNGJGFAA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	MFMJLFCOBPH AKPCKHIPICO
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	ICCMCAOCNJP NCOMFOCHCJC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	MICBNHDLKLK GLHFANFGEON
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	NJNCDDGFIJG PGKAEIKBKGH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	FENHLJCHJGE OCJMBFLAMIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	FPANNDIBPBC NNGKKHHDLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	JCKIJAFMFEI GGFOLPOAIFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	NHFIPDDNFBP FGPMOGCJILE
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	NPIAOHCMBCD IIHCIONEKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	BOHEKDBLILG OGELAKGBDFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	PCCEEOKIMCJ GEGJABCACEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	DBBKACJHNHN OKHPMEJBDJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	GCNPEJHCBNO NFCEDNJLBML
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	PAAMJEMAEPM CBBONJPLBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	MGDNOIFCHIM OEPPKANKJNN
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	PLEFOEBMOOP MNMGILKBLNG
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	ABAEFDCOKIJ EMLIPMHAIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	CECNDLGIKNJ OLNAKNHCNBA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	GMELFNJAPGB LBMIHPOCLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	FEHEMDONNPM HKKCKNFDBHC
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	OCFAJKILBCD CBOIHOPEAMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	ABNJIEGFEOC JJELPJONJID
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	GAKDHGEKIJL PJMADDAAKFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	JHNBKOHMNNF GGEKGEFELFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	AOJPAFPLIGN PGJOCOBBNDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	PICKPONNANE BCMKKOMLBEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	CLPEKHGCOFA GCBKEDDIFIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	new bool MLLAHFJJCJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(Slot = "34")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void DCCMEBOPJIH(HMHMGFNHAOI APDKBEPCLBG);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface BOHEKDBLILG : ANMLBOEMDKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EBNAOPOIBGD HMDNMGBNKIA(Guid CHBBGPKOFFN);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MCKODPOBNPM(Guid CHBBGPKOFFN);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AGMJAPNBBHL(Guid CHBBGPKOFFN, Task GHMNDMGCGPF);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JHDFDCJKJCL(Guid CHBBGPKOFFN, PLLAKKIDGFG CICKACODEEJ);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(PLLAKKIDGFG, Task)> KKBOAKPDGLN(Guid CHBBGPKOFFN);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface IGCCPCGGBCA : ANMLBOEMDKO, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface PCCEEOKIMCJ : ANMLBOEMDKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CCNLPAFEPHA(BDHPLICAJHI JEBOHIALEMJ);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CFHLADDNNNC(BDHPLICAJHI JEBOHIALEMJ);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<BIHFGJAHICO> MHILJBGIABJ(CancellationToken CLOHGGHEHCL);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface DBBKACJHNHN : ANMLBOEMDKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EBNAOPOIBGD BAIHPMDJBIL(BDHPLICAJHI FAPGJPNHNMB);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNOCFHADPAF(Guid CHBBGPKOFFN, Task GHMNDMGCGPF);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface GCNPEJHCBNO : ANMLBOEMDKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<PLLAKKIDGFG> NFCEDNJLBML(BDHPLICAJHI JLJGLLPFINF);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface PAAMJEMAEPM : ANMLBOEMDKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<CCNAABFFCED> CCNOFCMKLMG(OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, IAOKBCEAMNP LNJDNBJGCOP, CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface PLEFOEBMOOP : ANMLBOEMDKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PLLAKKIDGFG ODFMDKNPNML(FNAEIBBBBBE OHCMPLALIOB);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task GKAIHLJAJKG(string HEEMGKHJLID);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface MGDNOIFCHIM : ANMLBOEMDKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BDHPLICAJHI> NLECGBAPBPP(BDHPLICAJHI KGHMNJMLIBE, BEOKCNIMCAK BJGHICAFBLM, CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<BDHPLICAJHI> EFKFCGKEFPB(CancellationToken AHOMALKMHKK, BEOKCNIMCAK BJGHICAFBLM);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GPFLGLGCINI KPLBNKPMPNF(ECHHAJDKEIH CDMEODDBMHD, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GPFLGLGCINI DLGEGAJCALB(ECHHAJDKEIH CDMEODDBMHD, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface ABAEFDCOKIJ : ANMLBOEMDKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PLLAKKIDGFG LJIJNGNKKKA(FNAEIBBBBBE OHCMPLALIOB, BIHFGJAHICO EJLDBIEEPEK);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PLLAKKIDGFG JFLOOFBIOND(FNAEIBBBBBE AFLHBKMHOEB);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface IIGPCDCLLKM
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	const int BMLBLFGFDOP = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	IReadOnlyDictionary<Guid, FOMKHDIKKCF> JGLIEODEBGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Action BDICDGGIHOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IReadOnlyList<Guid> MFNPLFKOPEP();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task MAJHBMKGCLB([Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task MJOJAFCEPIN([Optional] CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface CECNDLGIKNJ
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OHBILKPJCNE(LEIBKJGOLDM FILDBKGFNEA);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OIDFGNPOPDH(LEIBKJGOLDM FILDBKGFNEA);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HPAGFEHHMLI(LEIBKJGOLDM FILDBKGFNEA);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CEHJAGOBIJJ(LEIBKJGOLDM FILDBKGFNEA);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class LEIBKJGOLDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly IAOKBCEAMNP JFGPICDJLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Dictionary<string, string> CBACHLNFKLD;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public OEEGBKAOPAE<string> DGGOPNPHICB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0xABA5E0", Offset = "0xAB8FE0", VA = "0x180ABA5E0")]
	public LEIBKJGOLDM(IAOKBCEAMNP EOJGKDJALHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8D97D70", Offset = "0x8D96770", VA = "0x188D97D70")]
	public LEIBKJGOLDM ILFONIBCJOB(string HPFHOBCPNEF, string KMAFNKGMDCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8D97CE0", Offset = "0x8D966E0", VA = "0x188D97CE0")]
	public bool BMFAKKPDCPH([Out] IEnumerable<KeyValuePair<string, string>> NHBGLMDMFFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7C40B20", Offset = "0x7C3F520", VA = "0x187C40B20")]
	public LEIBKJGOLDM KBNEBKJPNGH(OEEGBKAOPAE<string> KIGHMIAOFFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface ABNJIEGFEOC
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool HJALNNHNLKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string AJPMMLOFFNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool EGMMLMEODHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EJMJNJCGAOG();

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MHPEOFPNGND BKIKCMFMBLJ(long AFCPIMKFDHC);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LLIIMJFACFH<APAFHBPABPH, EHFFBGCAIIE> CGEHHDHGCCF(long AFCPIMKFDHC);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LLIIMJFACFH<APAFHBPABPH, EHIMHNJBHOL> AHCMKDPNCHI(long AFCPIMKFDHC);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	LLIIMJFACFH<long, DEHOJEDEEJF> HEEPDGFIJCG();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<IReadOnlyCollection<LMBBLNHDLDK>> AGGEMLCIECF(long AFCPIMKFDHC, IReadOnlyCollection<LMBBLNHDLDK> PMOKPKGKINA, CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool EKFJKPLHEHK(long AFCPIMKFDHC, [Out] bool LCMHOPBJAGN);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<bool> MHNJINDLNEA(byte[] NDJGEMIFCHE, byte[] NHHOJBCKKLB, IReadOnlyCollection<Guid> JKMNMPPBLLJ, CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface CIACMOGMJDE
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CCNAABFFCED MLAHKGEEKLJ(long JEIGPDFAGLO, long FMNCJOBEOEF, string OBPOKNPEGFF);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	CCNAABFFCED MLAHKGEEKLJ(long JEIGPDFAGLO, long FMNCJOBEOEF, APAFHBPABPH NDJGEMIFCHE, Guid? NCAJCGEDOLH, long KOKCHFCMPJA, bool ELGADAJABLI);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CCNAABFFCED MLAHKGEEKLJ(PPJEADMNHEK PGJBPJGPNGM);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CCNAABFFCED MLAHKGEEKLJ(PKCMPJMLDGM JMGMGLDGDBB, INDFDDFMNAH ECFKOLHGIBE);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface IHINAEDCPHM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool MGEFHFLPCGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool OLEBNACIAOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool MLLAHFJJCJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	CIACMOGMJDE GKPLFOBGHIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	HMHMGFNHAOI MDAHPENMHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event NCAAEJLIILE GFMOHFFMBFM;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event NCAAEJLIILE NACNBONMFCM;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event NCAAEJLIILE FFNLJCKFOPL;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<LMKGBJJKKKO, bool> PFKGNJIMPLH;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DMKNNECMACO();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DABENGHLNMG BNEPLOLJBJM();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	KOGLONMCCJJ EGOEMAMIFJN();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task GPCHILPNLNL(int BHLHMOKBKOA, GKJAGFBLLKC FGDEENNPCPP, Func<DFPILBGDMFF, DFPILBGDMFF> EICHFPJDCLH);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<PLLAKKIDGFG> NHMPPKPACEE(BNELGABNKPE PCGILFJIDOP);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task FBKADDOKDIN(CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface CJKIJIMANDA
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool CFOMKDKPCEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool BGLLBEOKKPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Guid? OKIJIFKOOFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FOHNGJBMPKH(Scene CGBLNOKBEJA);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task JDJMPNDCANK(NDIBKEHOAOL NNINGJHEEAC, IReadOnlyList<NDIBKEHOAOL> HEDFKKMIBFG, IReadOnlyList<NDIBKEHOAOL> ECDDEKHGPMC, CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KEHGOLKAIKF(Guid NDKPBPBIOMO, IReadOnlyList<Guid> JKMNMPPBLLJ, HMIBPDDAODI KILNPFOBJDC, [Optional] object FEFLBHKIIEF);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task CLPMAIEPPIE(IReadOnlyList<Guid> OHDDNGIGAMP, CancellationToken LHCLBCMNJKF);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PIKPDCGCPGG PPEIIPAOPPI();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task OMKHFLKCLIL();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KEFIOOLKDMD(GameObject CFNIACIFDFN);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task CCCOEMDGLKG();
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface FFHNIMCCMFI
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	FDNIDPPAKMF EGHDDGIBOKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool NLGGCNEBEIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool JGKFKMCAPAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool EEMOLAHLCOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool EBKKHANPFIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	int GOEIIBNBCKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool DPMNCDPBCDP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool MFDJCKKHIBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int GJPDKODLDHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	int LAFADBBBPHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool IHHCMOHMPKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool AFALMFKEEDB
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool BEIPMIGJPBO
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	float FMPDGEKPHEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<float> IMKMAOMIOAP;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JBJKIIKOACK CABPJMMCNLI(JBJKIIKOACK FIALHPNIOPO);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LAMIGDOOKLA(JBJKIIKOACK KLIEGJHNGPK);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HHOFBJHDMFJ();

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task KGNJDADHDKH(OEEGBKAOPAE<string>.BANCHJBJHFK CIFBPKMLMJG, CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DDBKGKGEPJH(float KOOCBNLIKCI);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NEMGPKCINMI(string JLLMPMKJKMF);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<BGBIJHCFHPL> IPDLMFGLILF();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable FDHGDDALIIO(object IJNPIDPIBFP, BGBIJHCFHPL OIAJENBJKKC);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<BAHMGECMGEB> ELGLONGEGKG();

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "11")]
	EHFFBGCAIIE PBFEDDLBHAF(IEnumerable<LNEHPBAPDKG> MHCLJLIBLPF);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void KJFEBBDHCHC(int DDFEAKLIDDG);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task DMHGLGIFJIN();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JLNNNNBBGLF();

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool MLNDKOGMFCN();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task OFPJDNELJAP(CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task PGPDOGGPJLO(CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<JAJILGCHJJN> LOJFIJFDMHA(DateTime KIMALCFHLNF, CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> BHAEOKFGCNH(CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void GGFANBPEINA(string JEBOHIALEMJ = "", float NDKGEJPCLBH = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "25")]
	LIBIHKAHBAL KAPEKLBOOAI(FJCNFCABHMI MNOCNJDBJHH, ALABEABJCDD LJLNONPCKJA, EHIMHNJBHOL BBMPKPDDAMB, IEnumerable<PersistenceView> LAJAKKFKIBO, IAJJGFEHOPJ MCPEJKLCMHG);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void FDBBOKMELLH(EHIMHNJBHOL BBMPKPDDAMB);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void KIMBHIPNAMO(LNEHPBAPDKG CKBAKJANFMC, [In] LIBIHKAHBAL JPPEOEEHJOI);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task JHGFNLLEOND(EHIMHNJBHOL DOALKJIILIM, bool GIAGIPGDLKF, CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task LOKHDHEOPAF(CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void MNMOFCMECAC(long GDCAPMONNDM, long FMNCJOBEOEF, PKCMPJMLDGM EDBEPKHMJCK, INDFDDFMNAH OLBALMNAEMJ, DFPILBGDMFF BPIOIEAKAAD, GKJAGFBLLKC? FGDEENNPCPP, CEGHBONCLIO? ENJEABHDIIM);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void FKKJHLPFBIA(long GDCAPMONNDM, long FMNCJOBEOEF, CEGHBONCLIO? ENJEABHDIIM);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void JMJLBJDLHJO(PersistenceView IMLEILDCPIH);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void NLLFACKPPDH(string DHCKGMIONJC, IAOKBCEAMNP EOJGKDJALHE, PPFENAOBDPL OBNLBFKOMDL, [Optional] string? LBNFBJAKDFI, [Optional] string? PDOLMABINFP, [Optional] string? NLMKDLMNEED);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool AHCMLFMKPAH(PersistenceView DMJMJBPOHHC);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool GNCHENOAEFP(LNEHPBAPDKG CKBAKJANFMC, FPGEPAJMDDO ALMALDHDLIN, [Out] MGNEPFHCMDN LGKILMBLIBG);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task CMJEPGHJJJN(CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void ALBANBFODMC();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "38")]
	IDisposable HCMHPHBLHJJ();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void CLPIBKGLPDP(EHIMHNJBHOL DOALKJIILIM, FPGEPAJMDDO ALMALDHDLIN);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<bool> KPOKNABIFMD(HJKBCKDIADL EHCDEMFECBB, CancellationToken AHOMALKMHKK, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void ELIHGNHFLOM(CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<PPJEADMNHEK> ANGFMEFACFI(IABFFLOLCOE KGHMNJMLIBE);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<PKCMPJMLDGM> IPLGCLMMJID(long GDCAPMONNDM, bool ALCPBJLLBBB, CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<HCJPDEFNHKL> AEPNNFNDKME(long GDCAPMONNDM, long FMNCJOBEOEF, long KOKCHFCMPJA, CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<INDFDDFMNAH> IAAHDEBMCPP(long GDCAPMONNDM, long FMNCJOBEOEF, CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<LFPGAJNOPDL> GFINOCBIJJK(long GDCAPMONNDM, Guid OCBKANPDDNC, long? GKOJBHIBFEI, CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "47")]
	LLIIMJFACFH<LFPGAJNOPDL, IEnumerable<CGFPIIJECHE>> GJPLDCNLBNF();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "48")]
	Task<ICFDNHEACPK> GOJGBGMLODG(string OBPOKNPEGFF, CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<ICFDNHEACPK> DFDBHDJCPJB(string OBPOKNPEGFF, long GDCAPMONNDM, long FMNCJOBEOEF, Guid? NDKPBPBIOMO, MEBOLGOEOBG.PMPBIGFEPGB KALMEDGIGPJ, MEBOLGOEOBG.PMPBIGFEPGB NHHOJBCKKLB, int BHLHMOKBKOA);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool JLDADNKELIL();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool BDPAGFCLIAL();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool NKGFJPENGHP(IEnumerable<MGNEPFHCMDN> CGPDCOKHEDN);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void AOLIALKGEBP(List<GameObject> KPOMKJJIFCP);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "55")]
	float MECPCLMBJEF();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task<bool> FJHAAPIJOAP(CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "57")]
	Task<Scene> JBEINPFPKOE(string GGEKNOFDIKM, LoadSceneMode KJOOEINPCIC, bool PGKONOJOANP, OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void ODHCBEIBCMB(bool LEFHPHFNFDO);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "63")]
	void HCOCFEFIKNP();

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void FIKLAFLOEDE();

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void GMKBNIDIAKO(bool CAAEJOKINKB);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task<MEBOLGOEOBG.PMPBIGFEPGB> ALGCOCPOLOL(byte[] BLPDDGCLNPE, MEBOLGOEOBG.NICNIHOAHBD BBFJNFFGBJP, KFDMCGCIAFG DJPFGOODJDG, [Optional] IReadOnlyCollection<string>? MPBPDJPGACO, [Optional] string? OCGJLGHJFEB);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void FEEFCEHKINH(IAOKBCEAMNP CINMFCJDKFE);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "73")]
	Task PMOCHPMADOD(OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task INCLBKBCKBH(OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "75")]
	Task PDMEHLNDNPP(OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "76")]
	Task MEPNFHJFIJA(OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "77")]
	IDisposable HCGKCGHKHNO();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "78")]
	IIKFOIDDMBB PPEMPBLLFJL();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "79")]
	Task JGCPAMJBPGE(CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface IIKFOIDDMBB
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DPCIOMHMOIG(CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task FNAEJAPOFFM(CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct LIBIHKAHBAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public HashSet<int> MNHMGNBKPCA;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum JAJILGCHJJN : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	No,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct FJCNFCABHMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Guid? CFMLHNHKJFF;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface FDNIDPPAKMF
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	IAOKBCEAMNP POGBJPJLBAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	PKCMPJMLDGM LGNOMIDOKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	PMHLBPGOPPD MOFFIGHFFCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool BDALHJPMCNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool DAFFGALMOKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	int KAHCJCKDDDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action JHLOKJPKLAE;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<int> PAMIABLNBDC;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EOMBBGCECMF();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.FANEBMINOHO> IENLDKCNMAN(long AFCPIMKFDHC, [Optional] CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<CIGFOLOFBAB> BFPLLLDMELG(IAOKBCEAMNP EOJGKDJALHE, [Optional] HMHMGFNHAOI BHNBGIMGNCE);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<CIGFOLOFBAB> FKHLPDFMABE();

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task EADDIGBKMGM();

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	(IAOKBCEAMNP, HMHMGFNHAOI) HBJBPGHIHIP();

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	KNIBMCLIMEI JLLIBKLKAJG();

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void DPOOGIGOGEM(long AFCPIMKFDHC);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void MLCJMMPGPNC(IAOKBCEAMNP EOJGKDJALHE, Matchmaking.PNOFAGMLCCE GGIKEMCHAAA, (int Major, int? Minor)? NGDAMNDJLIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface GMELFNJAPGB
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PIDMOAEFLHK([Out] IEnumerable<int> GEKNPPFDFBE);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MIPLILKGIDK(OMCJCLBFMAA MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PABNNBIFGDH(OMCJCLBFMAA MFKHKDDANII);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface PHFCFPIMKBH
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string HOJBDICEELG(PLLAKKIDGFG JHOGHDKBLCK);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface NPHEDJBDAGD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PFMILKDGBFI(CENIPDCJBKB.BIMLPAKOPON FLEMCBFBGBF);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GGECNKEPBKB(CENIPDCJBKB.BIMLPAKOPON FLEMCBFBGBF);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface MFMJLFCOBPH : NPHEDJBDAGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PLLAKKIDGFG IJOIIONJNEJ(FNAEIBBBBBE AFLHBKMHOEB);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface ICCMCAOCNJP : NPHEDJBDAGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PLLAKKIDGFG ODFMDKNPNML(FNAEIBBBBBE NBPOBGMPFAH);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface MHPEOFPNGND
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FEENKEDBOAD<HIOHINJLKHL, EFLAGBIEFMN>> LHFDKJIPJKP(Guid? NDKPBPBIOMO, IReadOnlyCollection<LMBBLNHDLDK> MNPBGPGNHCC, IReadOnlyCollection<LMBBLNHDLDK> KIFCMKOKEEL, JDGFAPGHPHD BPKNJHKFCNP, long? GDCAPMONNDM, long? FMNCJOBEOEF, CLFDOCGHGJD.OLKGGNOFGNE MDONJJJHHCD, CancellationToken AHOMALKMHKK, bool KPIACIPEPJK = false);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class HIOHINJLKHL
{
	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public NDIBKEHOAOL ELGNDJKBDJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IReadOnlyList<NDIBKEHOAOL> KDLPLHJPOMF
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IReadOnlyList<NDIBKEHOAOL> PCABHFJEIGL
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0xE09BE0", Offset = "0xE085E0", VA = "0x180E09BE0")]
	public HIOHINJLKHL(NDIBKEHOAOL KJBHJJBCIAH, IReadOnlyList<NDIBKEHOAOL> LHDCKEHGPBL, IReadOnlyList<NDIBKEHOAOL> AKLDMCBPFEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface LLIIMJFACFH<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<FEENKEDBOAD<FKPMICMHLMH<TData>, EFLAGBIEFMN>> LDPIPKKMABF(TGetDataArg MFHBGCBJCJO, CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class DPMFJHPMIPI : CHMOOPPGDGB, IHINAEDCPHM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct KBBCHNMIEFM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<PLLAKKIDGFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public DPMFJHPMIPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public BNELGABNKPE autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<PLLAKKIDGFG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8D96240", Offset = "0x8D94C40", VA = "0x188D96240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8D964C0", Offset = "0x8D94EC0", VA = "0x188D964C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct AAHGLFLBNPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public DPMFJHPMIPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8D82950", Offset = "0x8D81350", VA = "0x188D82950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8D82B80", Offset = "0x8D81580", VA = "0x188D82B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class HMJHCMOKNHG : IEnumerable<ANMLBOEMDKO>, IEnumerable, IEnumerator<ANMLBOEMDKO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private ANMLBOEMDKO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public DPMFJHPMIPI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private ANMLBOEMDKO System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xBE39C0", Offset = "0xBE23C0", VA = "0x180BE39C0")]
		[DebuggerHidden]
		public HMJHCMOKNHG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8D8B520", Offset = "0x8D89F20", VA = "0x188D8B520", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8D8B980", Offset = "0x8D8A380", VA = "0x188D8B980", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8D8B8D0", Offset = "0x8D8A2D0", VA = "0x188D8B8D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<ANMLBOEMDKO> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8D8B8D0", Offset = "0x8D8A2D0", VA = "0x188D8B8D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly CancellationTokenSource CPBBABHCIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly JBJKIIKOACK KLIEGJHNGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool JPNPFIIDGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private EAJALDENEIB FFABPBLCAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private bool PJHPFGPMNFE;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public HJKBCKDIADL PMPIJLLBMKD
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xAB4860", Offset = "0xAB3260", VA = "0x180AB4860", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xAB4880", Offset = "0xAB3280", VA = "0x180AB4880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public CAKILKPJFMJ IOMKAHAAKEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xAB4840", Offset = "0xAB3240", VA = "0x180AB4840", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xAB4800", Offset = "0xAB3200", VA = "0x180AB4800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public FFHNIMCCMFI BCDAFCHHCGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xAB4850", Offset = "0xAB3250", VA = "0x180AB4850", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xAB47F0", Offset = "0xAB31F0", VA = "0x180AB47F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public CJKIJIMANDA GCKCNGJGFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xAB4820", Offset = "0xAB3220", VA = "0x180AB4820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public MFMJLFCOBPH AKPCKHIPICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xAB4830", Offset = "0xAB3230", VA = "0x180AB4830", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xAB4810", Offset = "0xAB3210", VA = "0x180AB4810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public ICCMCAOCNJP NCOMFOCHCJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xAB7B30", Offset = "0xAB6530", VA = "0x180AB7B30", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xAB7BB0", Offset = "0xAB65B0", VA = "0x180AB7BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public CIACMOGMJDE GKPLFOBGHIE
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xAB7B40", Offset = "0xAB6540", VA = "0x180AB7B40", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xAB7B60", Offset = "0xAB6560", VA = "0x180AB7B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public MICBNHDLKLK GLHFANFGEON
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xAB7B50", Offset = "0xAB6550", VA = "0x180AB7B50", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xAB7AD0", Offset = "0xAB64D0", VA = "0x180AB7AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public NJNCDDGFIJG PGKAEIKBKGH
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xB2F7C0", Offset = "0xB2E1C0", VA = "0x180B2F7C0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xB79800", Offset = "0xB78200", VA = "0x180B79800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public FENHLJCHJGE OCJMBFLAMIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xAB7A80", Offset = "0xAB6480", VA = "0x180AB7A80", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xAB7AB0", Offset = "0xAB64B0", VA = "0x180AB7AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public FPANNDIBPBC NNGKKHHDLED
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xB79620", Offset = "0xB78020", VA = "0x180B79620", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xB795D0", Offset = "0xB77FD0", VA = "0x180B795D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public JCKIJAFMFEI GGFOLPOAIFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xAB9520", Offset = "0xAB7F20", VA = "0x180AB9520", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xAB9490", Offset = "0xAB7E90", VA = "0x180AB9490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public NHFIPDDNFBP FGPMOGCJILE
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xB793D0", Offset = "0xB77DD0", VA = "0x180B793D0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xB795F0", Offset = "0xB77FF0", VA = "0x180B795F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public NPIAOHCMBCD IIHCIONEKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xEE2960", Offset = "0xEE1360", VA = "0x180EE2960", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xEE2970", Offset = "0xEE1370", VA = "0x180EE2970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public BOHEKDBLILG OGELAKGBDFK
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xB79570", Offset = "0xB77F70", VA = "0x180B79570", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xBAD7B0", Offset = "0xBAC1B0", VA = "0x180BAD7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public IGCCPCGGBCA EHGKIFLCEDP
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xB795C0", Offset = "0xB77FC0", VA = "0x180B795C0", Slot = "60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xB79820", Offset = "0xB78220", VA = "0x180B79820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public PCCEEOKIMCJ GEGJABCACEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xB3D1C0", Offset = "0xB3BBC0", VA = "0x180B3D1C0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xB40170", Offset = "0xB3EB70", VA = "0x180B40170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public DBBKACJHNHN OKHPMEJBDJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xAB94F0", Offset = "0xAB7EF0", VA = "0x180AB94F0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xAB94B0", Offset = "0xAB7EB0", VA = "0x180AB94B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public GCNPEJHCBNO NFCEDNJLBML
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xB40E90", Offset = "0xB3F890", VA = "0x180B40E90", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xB40820", Offset = "0xB3F220", VA = "0x180B40820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public PAAMJEMAEPM CBBONJPLBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xB40E80", Offset = "0xB3F880", VA = "0x180B40E80", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xB407E0", Offset = "0xB3F1E0", VA = "0x180B407E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public MGDNOIFCHIM OEPPKANKJNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xB3BA70", Offset = "0xB3A470", VA = "0x180B3BA70", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xB3BA80", Offset = "0xB3A480", VA = "0x180B3BA80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public PLEFOEBMOOP MNMGILKBLNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xB49720", Offset = "0xB48120", VA = "0x180B49720", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xB42C70", Offset = "0xB41670", VA = "0x180B42C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public ABAEFDCOKIJ EMLIPMHAIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xB3D0B0", Offset = "0xB3BAB0", VA = "0x180B3D0B0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xB435A0", Offset = "0xB41FA0", VA = "0x180B435A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public CECNDLGIKNJ OLNAKNHCNBA
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xB3EDF0", Offset = "0xB3D7F0", VA = "0x180B3EDF0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xB3DC80", Offset = "0xB3C680", VA = "0x180B3DC80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public GMELFNJAPGB LBMIHPOCLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xB3ECA0", Offset = "0xB3D6A0", VA = "0x180B3ECA0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xB3DA30", Offset = "0xB3C430", VA = "0x180B3DA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public FEHEMDONNPM HKKCKNFDBHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xB11EE0", Offset = "0xB108E0", VA = "0x180B11EE0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xB3F100", Offset = "0xB3DB00", VA = "0x180B3F100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public OCFAJKILBCD CBOIHOPEAMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xC269B0", Offset = "0xC253B0", VA = "0x180C269B0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xC2F580", Offset = "0xC2DF80", VA = "0x180C2F580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public ABNJIEGFEOC JJELPJONJID
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xBA4B00", Offset = "0xBA3500", VA = "0x180BA4B00", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xB9CAD0", Offset = "0xB9B4D0", VA = "0x180B9CAD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public GAKDHGEKIJL PJMADDAAKFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xBA47A0", Offset = "0xBA31A0", VA = "0x180BA47A0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public JHNBKOHMNNF GGEKGEFELFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xC28520", Offset = "0xC26F20", VA = "0x180C28520", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public AOJPAFPLIGN PGJOCOBBNDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xC261F0", Offset = "0xC24BF0", VA = "0x180C261F0", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public PICKPONNANE BCMKKOMLBEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xC265D0", Offset = "0xC24FD0", VA = "0x180C265D0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public CLPEKHGCOFA GCBKEDDIFIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xC40F40", Offset = "0xC3F940", VA = "0x180C40F40", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public HMHMGFNHAOI MDAHPENMHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xC29330", Offset = "0xC27D30", VA = "0x180C29330", Slot = "58")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xDB7170", Offset = "0xDB5B70", VA = "0x180DB7170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool LEFIBMACODF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8D86710", Offset = "0x8D85110", VA = "0x188D86710", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool GNPOMGAGBHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8D86DD0", Offset = "0x8D857D0", VA = "0x188D86DD0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool MFBDONMJMJA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8480", Offset = "0x1FA6E80", VA = "0x181FA8480", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private CancellationToken FMPFIPHOHCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8D86770", Offset = "0x8D85170", VA = "0x188D86770", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private JBJKIIKOACK KMKKLHOHMOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private bool OMOFCBJNIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1FA8480", Offset = "0x1FA6E80", VA = "0x181FA8480", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1FA27F0", Offset = "0x1FA11F0", VA = "0x181FA27F0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	private event NCAAEJLIILE DIGKJINIMJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8D867F0", Offset = "0x8D851F0", VA = "0x188D867F0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8D86D70", Offset = "0x8D85770", VA = "0x188D86D70", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event NCAAEJLIILE NMFLNHMLCAP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8D86650", Offset = "0x8D85050", VA = "0x188D86650", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8D861C0", Offset = "0x8D84BC0", VA = "0x188D861C0", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event NCAAEJLIILE GDCPPKHHKNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8D86E50", Offset = "0x8D85850", VA = "0x188D86E50", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8D86100", Offset = "0x8D84B00", VA = "0x188D86100", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event Action<LMKGBJJKKKO, bool> MOKMGFFHJHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8D866B0", Offset = "0x8D850B0", VA = "0x188D866B0", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8D86790", Offset = "0x8D85190", VA = "0x188D86790", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0xDB7170", Offset = "0xDB5B70", VA = "0x180DB7170", Slot = "39")]
	public void DCCMEBOPJIH(HMHMGFNHAOI APDKBEPCLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x8D86EB0", Offset = "0x8D858B0", VA = "0x188D86EB0")]
	[UnityEngine.Scripting.Preserve]
	internal DPMFJHPMIPI([BMCONCJPCIA(null)] JBJKIIKOACK KLIEGJHNGPK, [BMCONCJPCIA(null)] HJKBCKDIADL EHCDEMFECBB, [BMCONCJPCIA(null)] CAKILKPJFMJ PBNJPFBDEJD, [BMCONCJPCIA(null)] FFHNIMCCMFI ADCMGLPBECA, [BMCONCJPCIA(null)] CJKIJIMANDA KPKFIJGNPLI, [BMCONCJPCIA(null)] MFMJLFCOBPH DEHLJHOMOGK, [BMCONCJPCIA(null)] ICCMCAOCNJP CKKGCEBLKJB, [BMCONCJPCIA(null)] MICBNHDLKLK BPOOOHOMDNA, [BMCONCJPCIA(null)] NJNCDDGFIJG PMIBAMBFHDE, [BMCONCJPCIA(null)] FENHLJCHJGE CONENCKKGCI, [BMCONCJPCIA(null)] FPANNDIBPBC LEDABCFBDNN, [BMCONCJPCIA(null)] JCKIJAFMFEI GHBAGKGJMDO, [BMCONCJPCIA(null)] NHFIPDDNFBP FKCCFDGGNEJ, [BMCONCJPCIA(null)] NPIAOHCMBCD DCODBNKMEHJ, [BMCONCJPCIA(null)] BOHEKDBLILG BIEBDFEBCKC, [BMCONCJPCIA(null)] IGCCPCGGBCA EKBJHKGNFBA, [BMCONCJPCIA(null)] PCCEEOKIMCJ EPPBFHPGIKH, [BMCONCJPCIA(null)] DBBKACJHNHN OGNBPNDMMOO, [BMCONCJPCIA(null)] GCNPEJHCBNO FDCNKKFEICI, [BMCONCJPCIA(null)] PAAMJEMAEPM OEJCPOGJBCD, [BMCONCJPCIA(null)] PLEFOEBMOOP GPIGCHBFGBI, [BMCONCJPCIA(null)] MGDNOIFCHIM JHJAMFNHLPL, [BMCONCJPCIA(null)] ABAEFDCOKIJ NHINLCDNNJM, [BMCONCJPCIA(null)] CECNDLGIKNJ AMNELOOKGFP, [BMCONCJPCIA(null)] GMELFNJAPGB DGBOCEDDJHF, [BMCONCJPCIA(null)] OCFAJKILBCD OINEAODAACF, [BMCONCJPCIA(null)] ABNJIEGFEOC MEOCGECJPJH, [BMCONCJPCIA(null)] GAKDHGEKIJL JPMFIBIAGJA, [BMCONCJPCIA(null)] JHNBKOHMNNF CCJBPALLILA, [BMCONCJPCIA(null)] AOJPAFPLIGN POABMPEJDBF, [BMCONCJPCIA(null)] PICKPONNANE APHOBCNFJKK, [BMCONCJPCIA(null)] CLPEKHGCOFA MDJBCPALBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x8D86850", Offset = "0x8D85250", VA = "0x188D86850")]
	private void GFALNPPLGKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x8D864B0", Offset = "0x8D84EB0", VA = "0x188D864B0", Slot = "59")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x8D86D20", Offset = "0x8D85720", VA = "0x188D86D20", Slot = "51")]
	private void LAMCGEKPPAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x8D86420", Offset = "0x8D84E20", VA = "0x188D86420", Slot = "52")]
	private DABENGHLNMG DIBGDBNOGLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x8D86C90", Offset = "0x8D85690", VA = "0x188D86C90", Slot = "53")]
	private KOGLONMCCJJ KHBBNBILOBP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x8D86900", Offset = "0x8D85300", VA = "0x188D86900", Slot = "55")]
	public Task GPCHILPNLNL(int BHLHMOKBKOA, GKJAGFBLLKC FGDEENNPCPP, Func<DFPILBGDMFF, DFPILBGDMFF> EICHFPJDCLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x8D86310", Offset = "0x8D84D10", VA = "0x188D86310")]
	private OLINAOFCBCD DFFAIPLJAGH(int BHLHMOKBKOA, GKJAGFBLLKC FGDEENNPCPP, Func<DFPILBGDMFF, DFPILBGDMFF> EICHFPJDCLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8D85FF0", Offset = "0x8D849F0", VA = "0x188D85FF0", Slot = "56")]
	[AsyncStateMachine(typeof(KBBCHNMIEFM))]
	private Task<PLLAKKIDGFG> AJECHKFFKBB(BNELGABNKPE MGJEEBCIHJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8D86220", Offset = "0x8D84C20", VA = "0x188D86220", Slot = "57")]
	[AsyncStateMachine(typeof(AAHGLFLBNPM))]
	private Task CNPGMOPCBPI(CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x8D86C10", Offset = "0x8D85610", VA = "0x188D86C10")]
	[IteratorStateMachine(typeof(HMJHCMOKNHG))]
	private IEnumerable<ANMLBOEMDKO> HMDJPMFMNHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x8D86160", Offset = "0x8D84B60", VA = "0x188D86160")]
	[CompilerGenerated]
	private void CEGJNDJKICE(ANMLBOEMDKO ADKKEOFFDMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class KIBBDHOIBJM : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x1B36FA0", Offset = "0x1B359A0", VA = "0x181B36FA0")]
	public KIBBDHOIBJM(string JEBOHIALEMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class KGGBOOGNOCJ : HFAACBPEOAJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct NLBHEJCEIDL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AsyncTaskMethodBuilder<HFAACBPEOAJ.FFCIFOPIDII> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public HashSet<LLFOFNPHDOK.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public KGGBOOGNOCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8D9F380", Offset = "0x8D9DD80", VA = "0x188D9F380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8D9F690", Offset = "0x8D9E090", VA = "0x188D9F690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly CHMOOPPGDGB NGALMEDAPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly FFHNIMCCMFI ADCMGLPBECA;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private string BKLCHAMDDLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8D96C40", Offset = "0x8D95640", VA = "0x188D96C40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0xAB5980", Offset = "0xAB4380", VA = "0x180AB5980")]
	public KGGBOOGNOCJ(CHMOOPPGDGB NGALMEDAPGH, FFHNIMCCMFI ADCMGLPBECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x8D96B30", Offset = "0x8D95530", VA = "0x188D96B30", Slot = "5")]
	[AsyncStateMachine(typeof(NLBHEJCEIDL))]
	public Task<HFAACBPEOAJ.FFCIFOPIDII> JOLKOGBHMDE(HashSet<LLFOFNPHDOK.Reason> INFHNJLCBJL, CancellationToken AHOMALKMHKK, LLFOFNPHDOK.Reason LJPPNNLHGCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal class IIHJOKOIKCP : AKEDPDJDGCJ, HFAACBPEOAJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct OMHLMDMPBFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<HFAACBPEOAJ.FFCIFOPIDII> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public IIHJOKOIKCP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public HashSet<LLFOFNPHDOK.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public LLFOFNPHDOK.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private IAOKBCEAMNP <localRoomInstance>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private long <preFallbackInstance>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private bool <currentIsOffline>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private TaskAwaiter<HFAACBPEOAJ.FFCIFOPIDII> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8DA0D70", Offset = "0x8D9F770", VA = "0x188DA0D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8DA1740", Offset = "0x8DA0140", VA = "0x188DA1740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly MEDFICBLIIJ CKAEEDAGMDD;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private string BKLCHAMDDLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8D8C5B0", Offset = "0x8D8AFB0", VA = "0x188D8C5B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x8D8C660", Offset = "0x8D8B060", VA = "0x188D8C660")]
	public IIHJOKOIKCP([BMCONCJPCIA(null)] CHMOOPPGDGB NGALMEDAPGH, [BMCONCJPCIA(null)] FFHNIMCCMFI ADCMGLPBECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x8D8C460", Offset = "0x8D8AE60", VA = "0x188D8C460", Slot = "5")]
	[AsyncStateMachine(typeof(OMHLMDMPBFK))]
	public Task<HFAACBPEOAJ.FFCIFOPIDII> JOLKOGBHMDE(HashSet<LLFOFNPHDOK.Reason> INFHNJLCBJL, CancellationToken AHOMALKMHKK, LLFOFNPHDOK.Reason LJPPNNLHGCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class FJPIJDBEFCC : AKEDPDJDGCJ, HFAACBPEOAJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct JPLHHDIDLOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<HFAACBPEOAJ.FFCIFOPIDII> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public FJPIJDBEFCC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public HashSet<LLFOFNPHDOK.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private TaskAwaiter<CIGFOLOFBAB> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<HFAACBPEOAJ.FFCIFOPIDII> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8D95520", Offset = "0x8D93F20", VA = "0x188D95520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8D95F10", Offset = "0x8D94910", VA = "0x188D95F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private string BKLCHAMDDLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8D89570", Offset = "0x8D87F70", VA = "0x188D89570", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0xAB5980", Offset = "0xAB4380", VA = "0x180AB5980")]
	public FJPIJDBEFCC(CHMOOPPGDGB NGALMEDAPGH, FFHNIMCCMFI ADCMGLPBECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8D89420", Offset = "0x8D87E20", VA = "0x188D89420", Slot = "5")]
	[AsyncStateMachine(typeof(JPLHHDIDLOB))]
	public Task<HFAACBPEOAJ.FFCIFOPIDII> JOLKOGBHMDE(HashSet<LLFOFNPHDOK.Reason> INFHNJLCBJL, CancellationToken AHOMALKMHKK, LLFOFNPHDOK.Reason LJPPNNLHGCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal class ALJKHPJEHDP : AKEDPDJDGCJ, HFAACBPEOAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class CEPHMFCBHKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public CIGFOLOFBAB matchmakingErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public IAOKBCEAMNP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public long preFallbackInstance;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public CEPHMFCBHKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8D856C0", Offset = "0x8D840C0", VA = "0x188D856C0")]
		internal object EMAFFHLNPPE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8D85600", Offset = "0x8D84000", VA = "0x188D85600")]
		internal object BBIFGIBFDLD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct HALIOIOIIOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder<HFAACBPEOAJ.FFCIFOPIDII> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public ALJKHPJEHDP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public HashSet<LLFOFNPHDOK.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private CEPHMFCBHKM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public LLFOFNPHDOK.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private TaskAwaiter<CIGFOLOFBAB> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private TaskAwaiter<HFAACBPEOAJ.FFCIFOPIDII> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8D8A590", Offset = "0x8D88F90", VA = "0x188D8A590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8D8B230", Offset = "0x8D89C30", VA = "0x188D8B230", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly MEDFICBLIIJ CKAEEDAGMDD;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private string BKLCHAMDDLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8D834B0", Offset = "0x8D81EB0", VA = "0x188D834B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x8D83560", Offset = "0x8D81F60", VA = "0x188D83560")]
	public ALJKHPJEHDP([BMCONCJPCIA(null)] CHMOOPPGDGB NGALMEDAPGH, [BMCONCJPCIA(null)] FFHNIMCCMFI ADCMGLPBECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x8D83360", Offset = "0x8D81D60", VA = "0x188D83360", Slot = "5")]
	[AsyncStateMachine(typeof(HALIOIOIIOP))]
	public Task<HFAACBPEOAJ.FFCIFOPIDII> JOLKOGBHMDE(HashSet<LLFOFNPHDOK.Reason> INFHNJLCBJL, CancellationToken AHOMALKMHKK, LLFOFNPHDOK.Reason LJPPNNLHGCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal abstract class AKEDPDJDGCJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct OABBKIPDGKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public OLFEOKKCIEG log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public HashSet<LLFOFNPHDOK.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public AKEDPDJDGCJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private List<LLFOFNPHDOK.Reason> <newDisconnectTriggers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8DA07F0", Offset = "0x8D9F1F0", VA = "0x188DA07F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8DA0D10", Offset = "0x8D9F710", VA = "0x188DA0D10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	protected readonly CHMOOPPGDGB NGALMEDAPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	protected readonly FFHNIMCCMFI ADCMGLPBECA;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	protected FDNIDPPAKMF EGHDDGIBOKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8D83040", Offset = "0x8D81A40", VA = "0x188D83040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0xAB5980", Offset = "0xAB4380", VA = "0x180AB5980")]
	public AKEDPDJDGCJ(CHMOOPPGDGB NGALMEDAPGH, FFHNIMCCMFI ADCMGLPBECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x8D82F10", Offset = "0x8D81910", VA = "0x188D82F10")]
	[AsyncStateMachine(typeof(OABBKIPDGKE))]
	protected Task DPJMAJAHLOJ(OLFEOKKCIEG JHGFKLHHPJD, HashSet<LLFOFNPHDOK.Reason> INFHNJLCBJL, CancellationToken AHOMALKMHKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class CELKBIIFIAI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct ELJMMJHIFJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public AsyncTaskMethodBuilder<HFAACBPEOAJ.FFCIFOPIDII> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public FFHNIMCCMFI callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8D87670", Offset = "0x8D86070", VA = "0x188D87670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8D879F0", Offset = "0x8D863F0", VA = "0x188D879F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class EEOGCIOFJHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public string fallbackName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public CHMOOPPGDGB roomManager;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public EEOGCIOFJHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8D87570", Offset = "0x8D85F70", VA = "0x188D87570")]
		internal object HDAAPMEDGEH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static readonly float JOEOFLDCLGA;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	internal static readonly HashSet<LLFOFNPHDOK.Reason> IMFNKDEOCOK;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8D85250", Offset = "0x8D83C50", VA = "0x188D85250")]
	[AsyncStateMachine(typeof(ELJMMJHIFJL))]
	internal static Task<HFAACBPEOAJ.FFCIFOPIDII> GLJAENLKHKL(FFHNIMCCMFI ADCMGLPBECA, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8D85360", Offset = "0x8D83D60", VA = "0x188D85360")]
	internal static void LKAFNAGCKDA(CHMOOPPGDGB NGALMEDAPGH, OLFEOKKCIEG JHGFKLHHPJD, string DHCKGMIONJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal interface HFAACBPEOAJ
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct FFCIFOPIDII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public bool GAJICMBGPLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public LLFOFNPHDOK.Reason LJPPNNLHGCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Enum? NLMKDLMNEED;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8D893E0", Offset = "0x8D87DE0", VA = "0x188D893E0")]
		public static FFCIFOPIDII ANDPHKADADF()
		{
			return default(FFCIFOPIDII);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8D893F0", Offset = "0x8D87DF0", VA = "0x188D893F0")]
		public static FFCIFOPIDII DFPABNDCPOM(LLFOFNPHDOK.Reason LJPPNNLHGCJ, [Optional] Enum? NLMKDLMNEED)
		{
			return default(FFCIFOPIDII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string CIHNGIGOPGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<FFCIFOPIDII> JOLKOGBHMDE(HashSet<LLFOFNPHDOK.Reason> INFHNJLCBJL, CancellationToken AHOMALKMHKK, LLFOFNPHDOK.Reason LJPPNNLHGCJ);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal struct BMOLEKDKLKP
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class GOAPFGMKIDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public CHMOOPPGDGB manager;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public GOAPFGMKIDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x8D8A540", Offset = "0x8D88F40", VA = "0x188D8A540")]
		internal Task ILIFNIABBMA(CancellationToken cancellationToken, int roomTotalVersion, LHDJNPMOIOH localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct LOECPMJJNIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public BMOLEKDKLKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private BNELGABNKPE <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private TaskAwaiter<JAJILGCHJJN> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private TaskAwaiter<PLLAKKIDGFG> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8D9CD60", Offset = "0x8D9B760", VA = "0x188D9CD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8D9D2F0", Offset = "0x8D9BCF0", VA = "0x188D9D2F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct LFIIKDCDKPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public BMOLEKDKLKP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8D97E40", Offset = "0x8D96840", VA = "0x188D97E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x8D98160", Offset = "0x8D96B60", VA = "0x188D98160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly CancellationToken AHOMALKMHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly CHMOOPPGDGB KFMMGFEJHFC;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private HJKBCKDIADL PMPIJLLBMKD
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8D84460", Offset = "0x8D82E60", VA = "0x188D84460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private FFHNIMCCMFI BCDAFCHHCGD
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8D84150", Offset = "0x8D82B50", VA = "0x188D84150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private FDNIDPPAKMF EGHDDGIBOKD
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8D83F50", Offset = "0x8D82950", VA = "0x188D83F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private FENHLJCHJGE OCJMBFLAMIM
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8D84100", Offset = "0x8D82B00", VA = "0x188D84100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x2B5B6F0", Offset = "0x2B5A0F0", VA = "0x182B5B6F0")]
	public BMOLEKDKLKP(CancellationToken AHOMALKMHKK, CHMOOPPGDGB KFMMGFEJHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8D841A0", Offset = "0x8D82BA0", VA = "0x188D841A0")]
	public static JKLLJDPDOFE IJFGBIFEIPH(CHMOOPPGDGB KFMMGFEJHFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8D83D70", Offset = "0x8D82770", VA = "0x188D83D70")]
	[AsyncStateMachine(typeof(LOECPMJJNIF))]
	public Task<bool> AEOBHGFBIDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x8D84250", Offset = "0x8D82C50", VA = "0x188D84250")]
	private bool KKFLAAPOLHF([Out] BNELGABNKPE MGJEEBCIHJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x8D83E80", Offset = "0x8D82880", VA = "0x188D83E80")]
	[AsyncStateMachine(typeof(LFIIKDCDKPE))]
	private Task AFNNANEKMND()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8D83FD0", Offset = "0x8D829D0", VA = "0x188D83FD0")]
	private Task<JAJILGCHJJN> GCDNLCFLNLJ(BNELGABNKPE LELHJPOJMBE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct EBNAOPOIBGD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly BOHEKDBLILG BIEBDFEBCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly Guid CHBBGPKOFFN;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private Task<(PLLAKKIDGFG, Task)> IGDACLDPPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x8D874A0", Offset = "0x8D85EA0", VA = "0x188D874A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x56F4250", Offset = "0x56F2C50", VA = "0x1856F4250")]
	public EBNAOPOIBGD(BOHEKDBLILG BIEBDFEBCKC, Guid CHBBGPKOFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x8D87380", Offset = "0x8D85D80", VA = "0x188D87380")]
	public TaskAwaiter<(PLLAKKIDGFG, Task)> CHDCJGNKGCK()
	{
		return default(TaskAwaiter<(PLLAKKIDGFG, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x8D873D0", Offset = "0x8D85DD0", VA = "0x188D873D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal struct NMCOENJPGAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly TaskCompletionSource<(PLLAKKIDGFG, Task)> FBIPCCBJKBI;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Task<(PLLAKKIDGFG, Task)> IGDACLDPPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8DA0500", Offset = "0x8D9EF00", VA = "0x188DA0500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x8DA05E0", Offset = "0x8D9EFE0", VA = "0x188DA05E0")]
	public NMCOENJPGAP(TimeSpan LPPGPMAJHFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x8DA0540", Offset = "0x8D9EF40", VA = "0x188DA0540")]
	public void PHLBOKHAEEP(Task GHMNDMGCGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x8DA0420", Offset = "0x8D9EE20", VA = "0x188DA0420")]
	public void EEKFLFBINIA(PLLAKKIDGFG JHOGHDKBLCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8DA04B0", Offset = "0x8D9EEB0", VA = "0x188DA04B0")]
	public void NBNEBICCILP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x8DA0390", Offset = "0x8D9ED90", VA = "0x188DA0390")]
	internal void DDMCCALDLBN(string JEBOHIALEMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class AIAJPJHFKCK
{
	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8D82D70", Offset = "0x8D81770", VA = "0x188D82D70")]
	public static CCNAABFFCED IBHCHJNHHHP(this CCNAABFFCED IHHGLEDNONA, PKCMPJMLDGM NGFFAAEEPCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x8D82BE0", Offset = "0x8D815E0", VA = "0x188D82BE0")]
	public static CCNAABFFCED HCMGAGEKKAC(this CCNAABFFCED IHHGLEDNONA, INDFDDFMNAH LNHGFICNMLP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class CKGCLACMOCM : CIACMOGMJDE
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class DBNBPAJLFCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public INDFDDFMNAH subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public DBNBPAJLFCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8D85FC0", Offset = "0x8D849C0", VA = "0x188D85FC0")]
		internal bool BMJKCOFIKCE(PMHLBPGOPPD s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly OCFAJKILBCD AFPNKINCBJM;

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0xABA5E0", Offset = "0xAB8FE0", VA = "0x180ABA5E0")]
	public CKGCLACMOCM(OCFAJKILBCD OINEAODAACF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8D858A0", Offset = "0x8D842A0", VA = "0x188D858A0", Slot = "4")]
	public CCNAABFFCED MLAHKGEEKLJ(long JEIGPDFAGLO, long FMNCJOBEOEF, string OBPOKNPEGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8D85930", Offset = "0x8D84330", VA = "0x188D85930", Slot = "5")]
	public CCNAABFFCED MLAHKGEEKLJ(long JEIGPDFAGLO, long FMNCJOBEOEF, APAFHBPABPH NDJGEMIFCHE, Guid? NCAJCGEDOLH, long KOKCHFCMPJA, bool ELGADAJABLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8D85D70", Offset = "0x8D84770", VA = "0x188D85D70", Slot = "6")]
	public CCNAABFFCED MLAHKGEEKLJ(PPJEADMNHEK PGJBPJGPNGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8D85A90", Offset = "0x8D84490", VA = "0x188D85A90", Slot = "7")]
	public CCNAABFFCED MLAHKGEEKLJ(PKCMPJMLDGM JMGMGLDGDBB, INDFDDFMNAH ECFKOLHGIBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8D857F0", Offset = "0x8D841F0", VA = "0x188D857F0")]
	private Guid? FLDKCHHPFAF(PKCMPJMLDGM MCBFGNKNLPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class BOHBDLGMEEJ : NJNCDDGFIJG, ANMLBOEMDKO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct IFNDDMFOKIP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public BOHBDLGMEEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8D8BD60", Offset = "0x8D8A760", VA = "0x188D8BD60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8D8C400", Offset = "0x8D8AE00", VA = "0x188D8C400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly OMCJCLBFMAA LMKGNENNCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private string BLMIMNNGMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Task JLFFHMFHOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private CHMOOPPGDGB NGALMEDAPGH;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool JGDALFCNDEP
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8D844B0", Offset = "0x8D82EB0", VA = "0x188D844B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Task HJECPFFIIAB
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8D84760", Offset = "0x8D83160", VA = "0x188D84760", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150", Slot = "7")]
	public void GFALNPPLGKO(CHMOOPPGDGB NGALMEDAPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x8D844E0", Offset = "0x8D82EE0", VA = "0x188D844E0", Slot = "6")]
	public void GGMCKCMOJEB(Task FLAIIHBKGBI, string GDOPEDBKFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x8D84640", Offset = "0x8D83040", VA = "0x188D84640")]
	[AsyncStateMachine(typeof(IFNDDMFOKIP))]
	private Task IJBFDELJLKK(Task CPIDIMIFIPK, string GDOPEDBKFAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x8D847F0", Offset = "0x8D831F0", VA = "0x188D847F0")]
	public BOHBDLGMEEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class PCJDFMAIGHF : FEHEMDONNPM, ANMLBOEMDKO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private bool IPCKGPJECPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private BGJPDHDKIOB GFDHODHGAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private HJKBCKDIADL EHCDEMFECBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private OCFAJKILBCD OINEAODAACF;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public BGJPDHDKIOB AIPDFGPJCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x8DA1B20", Offset = "0x8DA0520", VA = "0x188DA1B20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x8DA19A0", Offset = "0x8DA03A0", VA = "0x188DA19A0", Slot = "7")]
	public void GFALNPPLGKO(CHMOOPPGDGB NGALMEDAPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x8DA17B0", Offset = "0x8DA01B0", VA = "0x188DA17B0", Slot = "5")]
	public void CPONDGEBCDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x8DA1960", Offset = "0x8DA0360", VA = "0x188DA1960", Slot = "6")]
	public void MALHPAKHIBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x8DA1B90", Offset = "0x8DA0590", VA = "0x188DA1B90")]
	private Task MFAEMONGEFJ(NHLJKPJALOB HBELCFIJGKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x8DA1960", Offset = "0x8DA0360", VA = "0x188DA1960", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public PCJDFMAIGHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal class NBBDMJNPEPP : OCFAJKILBCD
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class BHGBMBAJEHP<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly JLFIJNDEFBP OPGACPAKDDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly string HPFHOBCPNEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly T KJMOBDOKFBF;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public T AFPBILBCKEL
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xAFB540", Offset = "0xAF9F40", VA = "0x180AFB540")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xB8BA80", Offset = "0xB8A480", VA = "0x180B8BA80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x676EDA0", Offset = "0x676D7A0", VA = "0x18676EDA0")]
		public BHGBMBAJEHP(JLFIJNDEFBP OPGACPAKDDP, string HPFHOBCPNEF, T KJMOBDOKFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x676ECE0", Offset = "0x676D6E0", VA = "0x18676ECE0")]
		private void MGKNIGJPIOP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly JLFIJNDEFBP OPGACPAKDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly BHGBMBAJEHP<TimeSpan> PDPHJKPMEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly BHGBMBAJEHP<TimeSpan> MALDKMHLCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly BHGBMBAJEHP<TimeSpan> LPENPEFDLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly BHGBMBAJEHP<TimeSpan> OGHDIGLCCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly BHGBMBAJEHP<bool> ANGHGFPCHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly BHGBMBAJEHP<bool> PGKMDMAGEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly BHGBMBAJEHP<bool> GLNPJIOAKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly BHGBMBAJEHP<int> ALLNONPHAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly BHGBMBAJEHP<bool> DFJOOEKCCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly BHGBMBAJEHP<bool> LONEEJJAJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly BHGBMBAJEHP<AMLOJEALFHA> JFBBBGDBOGO;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public TimeSpan FELHIMCBBAK
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8D9EC20", Offset = "0x8D9D620", VA = "0x188D9EC20", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public TimeSpan MELFLBBFLHF
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8D9EE70", Offset = "0x8D9D870", VA = "0x188D9EE70", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public TimeSpan IMMEBPBPABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8D9ED60", Offset = "0x8D9D760", VA = "0x188D9ED60", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public TimeSpan ANFOPNMALJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8D9ECA0", Offset = "0x8D9D6A0", VA = "0x188D9ECA0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool FADKJFINKGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8D9EDE0", Offset = "0x8D9D7E0", VA = "0x188D9EDE0", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool CCDIDAOJJBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x8D9EDA0", Offset = "0x8D9D7A0", VA = "0x188D9EDA0", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool KBLFBFOFCPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8D9EC60", Offset = "0x8D9D660", VA = "0x188D9EC60", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int NFNMHAPJBNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8D9EBE0", Offset = "0x8D9D5E0", VA = "0x188D9EBE0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool BIODEJDDJND
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8D9ECE0", Offset = "0x8D9D6E0", VA = "0x188D9ECE0", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool NMFBDNIGMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8D9ED20", Offset = "0x8D9D720", VA = "0x188D9ED20", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool OHFECILDBKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8D9EE20", Offset = "0x8D9D820", VA = "0x188D9EE20", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x8D9EEB0", Offset = "0x8D9D8B0", VA = "0x188D9EEB0")]
	[UnityEngine.Scripting.Preserve]
	public NBBDMJNPEPP([BMCONCJPCIA(null)] JLFIJNDEFBP OPGACPAKDDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[UnityEngine.Scripting.Preserve]
internal class FFBBGDMPPAC : FPANNDIBPBC, ANMLBOEMDKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class INHPMKFFBGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public GJIGLAJEIOM roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public INHPMKFFBGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8D8D3E0", Offset = "0x8D8BDE0", VA = "0x188D8D3E0")]
		internal object OIJKPMJKLDN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event NCAAEJLIILE GFMOHFFMBFM
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8D891F0", Offset = "0x8D87BF0", VA = "0x188D891F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8D88DE0", Offset = "0x8D877E0", VA = "0x188D88DE0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event NCAAEJLIILE NACNBONMFCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8D89340", Offset = "0x8D87D40", VA = "0x188D89340", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x8D88C40", Offset = "0x8D87640", VA = "0x188D88C40", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event NCAAEJLIILE FFNLJCKFOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8D88F80", Offset = "0x8D87980", VA = "0x188D88F80", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8D88CE0", Offset = "0x8D876E0", VA = "0x188D88CE0", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<LMKGBJJKKKO, bool> PFKGNJIMPLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8D89290", Offset = "0x8D87C90", VA = "0x188D89290", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8D88E80", Offset = "0x8D87880", VA = "0x188D88E80", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "16")]
	public void GFALNPPLGKO(CHMOOPPGDGB NGALMEDAPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x8D88D80", Offset = "0x8D87780", VA = "0x188D88D80", Slot = "12")]
	public void DGJBFOFLHNC(GJIGLAJEIOM MLNHANKLKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8D88DB0", Offset = "0x8D877B0", VA = "0x188D88DB0", Slot = "13")]
	public void DGPDKCBPIKB(GJIGLAJEIOM MLNHANKLKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8D88C10", Offset = "0x8D87610", VA = "0x188D88C10", Slot = "14")]
	public void ADKIJHLKELN(GJIGLAJEIOM MLNHANKLKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8D88F30", Offset = "0x8D87930", VA = "0x188D88F30", Slot = "15")]
	public void HBHPEMCLEMI(LMKGBJJKKKO JCECGKAIEFB, bool GAJICMBGPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8D89020", Offset = "0x8D87A20", VA = "0x188D89020")]
	private void KDMGDDCNHFD(NCAAEJLIILE OIAJENBJKKC, GJIGLAJEIOM MLNHANKLKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public FFBBGDMPPAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[UnityEngine.Scripting.Preserve]
internal class KNCDIEFABAO : JCKIJAFMFEI, ANMLBOEMDKO, IDisposable, LLFOFNPHDOK
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private class JKBHPGLKHAF : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct PPLGGGGLHPA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public JKBHPGLKHAF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public LLFOFNPHDOK.DMECMAGDCNC reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			private PDJKNFENBKE <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			private HFAACBPEOAJ[] <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			private TaskAwaiter<HFAACBPEOAJ.FFCIFOPIDII> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x8DA2180", Offset = "0x8DA0B80", VA = "0x188DA2180", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x8DA2900", Offset = "0x8DA1300", VA = "0x188DA2900", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct MLBOEHNGFHB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public AsyncTaskMethodBuilder<HFAACBPEOAJ.FFCIFOPIDII> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public HFAACBPEOAJ fallbackProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public JKBHPGLKHAF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public LLFOFNPHDOK.DMECMAGDCNC reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			private PDJKNFENBKE <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			private KFDOJGPADPI <individualFallbackTaskState>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private TaskAwaiter<HFAACBPEOAJ.FFCIFOPIDII> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x8D9D9D0", Offset = "0x8D9C3D0", VA = "0x188D9D9D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x8D9E690", Offset = "0x8D9D090", VA = "0x188D9E690", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class JBDIDIAKLJO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public LLFOFNPHDOK.DMECMAGDCNC reason;

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public JBDIDIAKLJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x8D8D4C0", Offset = "0x8D8BEC0", VA = "0x188D8D4C0")]
			internal object PJDMEKEADJN((LLFOFNPHDOK.Reason fallbackReason, PPFENAOBDPL roomDto, KFDOJGPADPI state, string subReason) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class KELGGGBDFGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public HFAACBPEOAJ fallbackProvider;

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public KELGGGBDFGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x8D96530", Offset = "0x8D94F30", VA = "0x188D96530")]
			internal object PKEAHMIHOPL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public Task FLAIIHBKGBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public CancellationTokenSource OHFCLCGHNMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public KFDOJGPADPI AFBKHJKKDJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public FFHNIMCCMFI ADCMGLPBECA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public PPFENAOBDPL OBNLBFKOMDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public IAOKBCEAMNP EOJGKDJALHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public HFAACBPEOAJ[] ENOAALHFIGJ;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool FICMBNIAFOO
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x8D8F550", Offset = "0x8D8DF50", VA = "0x188D8F550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool BACLNECEHKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x8D8E120", Offset = "0x8D8CB20", VA = "0x188D8E120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8D8F8E0", Offset = "0x8D8E2E0", VA = "0x188D8F8E0")]
		public JKBHPGLKHAF(FFHNIMCCMFI ADCMGLPBECA, PPFENAOBDPL OBNLBFKOMDL, IAOKBCEAMNP EOJGKDJALHE, HFAACBPEOAJ[] ENOAALHFIGJ, CancellationToken AHOMALKMHKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8D8E660", Offset = "0x8D8D060", VA = "0x188D8E660", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8D8E970", Offset = "0x8D8D370", VA = "0x188D8E970")]
		public void HAPJBLKBPOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8D8EAF0", Offset = "0x8D8D4F0", VA = "0x188D8EAF0")]
		public void IHELJKDOKNM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8D8DD30", Offset = "0x8D8C730", VA = "0x188D8DD30")]
		public void ACJBBOFAAPL(LLFOFNPHDOK.Reason APMKFONGGKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8D8F030", Offset = "0x8D8DA30", VA = "0x188D8F030")]
		[AsyncStateMachine(typeof(PPLGGGGLHPA))]
		public Task JDMCFHPODII(LLFOFNPHDOK.DMECMAGDCNC LJPPNNLHGCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8D8F400", Offset = "0x8D8DE00", VA = "0x188D8F400")]
		[AsyncStateMachine(typeof(MLBOEHNGFHB))]
		private Task<HFAACBPEOAJ.FFCIFOPIDII> MDDOPLEKCIL(LLFOFNPHDOK.DMECMAGDCNC LJPPNNLHGCJ, HFAACBPEOAJ OBNCJDJBAMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8D8E000", Offset = "0x8D8CA00", VA = "0x188D8E000")]
		private void ALCNFNIHCFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8D8E5B0", Offset = "0x8D8CFB0", VA = "0x188D8E5B0")]
		public bool DMMGLLLBNPC(LLFOFNPHDOK.Reason PGNMNHCJNGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8D8E310", Offset = "0x8D8CD10", VA = "0x188D8E310")]
		private void CFAALIFMOKL(KFDOJGPADPI IMNBLKDCAKA, LLFOFNPHDOK.DMECMAGDCNC LJPPNNLHGCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8D8E140", Offset = "0x8D8CB40", VA = "0x188D8E140")]
		private void CCOFKPCOBJD(KFDOJGPADPI IMNBLKDCAKA, HFAACBPEOAJ.FFCIFOPIDII GGIKEMCHAAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8D8F250", Offset = "0x8D8DC50", VA = "0x188D8F250")]
		private void MDBHPIDEFLC(KFDOJGPADPI IMNBLKDCAKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8D8EC60", Offset = "0x8D8D660", VA = "0x188D8EC60")]
		private void IKPMMKDNFAL(KFDOJGPADPI IMNBLKDCAKA, HFAACBPEOAJ.FFCIFOPIDII GGIKEMCHAAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8D8E800", Offset = "0x8D8D200", VA = "0x188D8E800")]
		private void GEJBOIFKEIK(KFDOJGPADPI IMNBLKDCAKA, Exception JOEMCJLBOIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8D8E9E0", Offset = "0x8D8D3E0", VA = "0x188D8E9E0")]
		private void HHJHHAHBLLC(HFAACBPEOAJ OBNCJDJBAMI, LLFOFNPHDOK.DMECMAGDCNC LJPPNNLHGCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8D8F140", Offset = "0x8D8DB40", VA = "0x188D8F140")]
		private void KJKLDOKKJNC(HFAACBPEOAJ OBNCJDJBAMI, LLFOFNPHDOK.Reason LJPPNNLHGCJ, string NLMKDLMNEED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8D8F570", Offset = "0x8D8DF70", VA = "0x188D8F570", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class KFDOJGPADPI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public Task<HFAACBPEOAJ.FFCIFOPIDII> FLAIIHBKGBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public CancellationTokenSource OHFCLCGHNMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public HFAACBPEOAJ OBNCJDJBAMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public LLFOFNPHDOK.Reason APMKFONGGKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public HashSet<LLFOFNPHDOK.Reason> INFHNJLCBJL;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public bool FICMBNIAFOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x8D8F550", Offset = "0x8D8DF50", VA = "0x188D8F550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public bool BACLNECEHKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x8D8E120", Offset = "0x8D8CB20", VA = "0x188D8E120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8D965D0", Offset = "0x8D94FD0", VA = "0x188D965D0")]
		public void LFPMCBHAIJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8D965B0", Offset = "0x8D94FB0", VA = "0x188D965B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8D96740", Offset = "0x8D95140", VA = "0x188D96740", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x8D96AA0", Offset = "0x8D954A0", VA = "0x188D96AA0")]
		public KFDOJGPADPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class BMCFNPIDKOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public LLFOFNPHDOK.Reason reason;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public BMCFNPIDKOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8D83C20", Offset = "0x8D82620", VA = "0x188D83C20")]
		internal object CPOPEHBCLHA(KFDOJGPADPI x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8D83C90", Offset = "0x8D82690", VA = "0x188D83C90")]
		internal object LDMOPHPMILM(JKBHPGLKHAF x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x8D83D00", Offset = "0x8D82700", VA = "0x188D83D00")]
		internal object OKHJBNKGFAA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct NLGCLHDCAFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public LLFOFNPHDOK.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public KNCDIEFABAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private BMCFNPIDKOC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public Exception exception;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8D9F700", Offset = "0x8D9E100", VA = "0x188D9F700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x8DA0330", Offset = "0x8D9ED30", VA = "0x188DA0330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct LMCPILPECFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public KNCDIEFABAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public LLFOFNPHDOK.DMECMAGDCNC reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private JKBHPGLKHAF <localTaskState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8D9C040", Offset = "0x8D9AA40", VA = "0x188D9C040", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8D9CD00", Offset = "0x8D9B700", VA = "0x188D9CD00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct JFAFDEPLNFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public KNCDIEFABAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x8D8D730", Offset = "0x8D8C130", VA = "0x188D8D730", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8D8DCD0", Offset = "0x8D8C6D0", VA = "0x188D8DCD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	internal static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	internal static readonly OLFEOKKCIEG PEIOGGBPENK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private CHMOOPPGDGB NGALMEDAPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private FFHNIMCCMFI ADCMGLPBECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private JKBHPGLKHAF PJGHMANJBHG;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private FDNIDPPAKMF EGHDDGIBOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8D97380", Offset = "0x8D95D80", VA = "0x188D97380")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool DJPNIOPDIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x2781C50", Offset = "0x2780650", VA = "0x182781C50", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private bool IMFPDFDMDFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8D97BB0", Offset = "0x8D965B0", VA = "0x188D97BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x8D973D0", Offset = "0x8D95DD0", VA = "0x188D973D0", Slot = "6")]
	public void GFALNPPLGKO(CHMOOPPGDGB NGALMEDAPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x8D97250", Offset = "0x8D95C50", VA = "0x188D97250", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x8D97940", Offset = "0x8D96340", VA = "0x188D97940", Slot = "9")]
	public void LFPMCBHAIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8D97AD0", Offset = "0x8D964D0", VA = "0x188D97AD0")]
	private bool LOAOILDBBEH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x8D97180", Offset = "0x8D95B80", VA = "0x188D97180", Slot = "5")]
	private void DPJDJKAAPJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x8D97750", Offset = "0x8D96150", VA = "0x188D97750", Slot = "8")]
	[AsyncStateMachine(typeof(NLGCLHDCAFN))]
	public Task KEHIPLJIDJK(LLFOFNPHDOK.Reason LJPPNNLHGCJ, [Optional] Exception FGDPOGPHENJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x8D97450", Offset = "0x8D95E50", VA = "0x188D97450")]
	private bool IMOKHAPHMMG(LLFOFNPHDOK.DMECMAGDCNC LJPPNNLHGCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x8D96CF0", Offset = "0x8D956F0", VA = "0x188D96CF0")]
	private HFAACBPEOAJ[] DHCKMFOANCC(IAOKBCEAMNP MBALGGFDCIO, PPFENAOBDPL IHLNEMDOFAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x8D97260", Offset = "0x8D95C60", VA = "0x188D97260")]
	[AsyncStateMachine(typeof(LMCPILPECFN))]
	private Task EBHJILIEBPC(LLFOFNPHDOK.DMECMAGDCNC LJPPNNLHGCJ, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x8D97870", Offset = "0x8D96270", VA = "0x188D97870")]
	[AsyncStateMachine(typeof(JFAFDEPLNFA))]
	private Task KMHIGEGDGEI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public KNCDIEFABAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.NoEngine.Common.Preserve]
internal class LKFCKGCOBGD : NHFIPDDNFBP, ANMLBOEMDKO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct CBNPMPJLFHN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public IAOKBCEAMNP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public LKFCKGCOBGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public HMHMGFNHAOI customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8D84880", Offset = "0x8D83280", VA = "0x188D84880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x8D851F0", Offset = "0x8D83BF0", VA = "0x188D851F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct FBFOGIBBEEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public LKFCKGCOBGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public IAOKBCEAMNP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public HMHMGFNHAOI customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private OEEGBKAOPAE<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private PDJKNFENBKE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private BEOKCNIMCAK <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private LEIBKJGOLDM <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8D87A60", Offset = "0x8D86460", VA = "0x188D87A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8D88BB0", Offset = "0x8D875B0", VA = "0x188D88BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class CIHBGNELGOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public Matchmaking.PNOFAGMLCCE result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public IPMMGHJONLE errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public CIHBGNELGOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x8D85740", Offset = "0x8D84140", VA = "0x188D85740")]
		internal object POFHPCEGDOH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class NLDOOFOPMLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public Task<CCNAABFFCED> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public NLDOOFOPMLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		internal Task<CCNAABFFCED> HGHAMHGOLAB(OEEGBKAOPAE<string>.BANCHJBJHFK _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private struct JKEHBCAOJEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public LKFCKGCOBGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public IAOKBCEAMNP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public HMHMGFNHAOI customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public BEOKCNIMCAK joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private NLDOOFOPMLL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private GGAMAAEOFMM <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private PDJKNFENBKE <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private MEILIGBJNHJ <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private Task<Matchmaking.FANEBMINOHO> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private IBFOPPEEJNA <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private int <i>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private TaskAwaiter<Matchmaking.FANEBMINOHO> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private TaskAwaiter<CCNAABFFCED> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8D8FA00", Offset = "0x8D8E400", VA = "0x188D8FA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8D95360", Offset = "0x8D93D60", VA = "0x188D95360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class OCGKLNEMLHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public Task<CCNAABFFCED> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public OCGKLNEMLHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		internal Task<CCNAABFFCED> KOIKEOGFJLK(OEEGBKAOPAE<string>.BANCHJBJHFK _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct FENDCLNBLOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public LKFCKGCOBGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public IAOKBCEAMNP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public HMHMGFNHAOI customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public BEOKCNIMCAK joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private GGAMAAEOFMM <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private PDJKNFENBKE <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <connectToRoomAndRunLoadLogicTimer>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private CancellationTokenSource <roomTokenSource>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private CancellationTokenRegistration <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private CancellationToken <roomCancellationToken>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private MEILIGBJNHJ <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private Task<Matchmaking.FANEBMINOHO> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private CCNAABFFCED <initialRoomLoadPayload>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private GBKGIJBJPLI <preloadContext>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private TaskAwaiter<CCNAABFFCED> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private IBFOPPEEJNA <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private Task <loadEmptySceneTask>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private PJFNAIEGFFD <sceneManagementService>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private EAOBOKAGIGN <scenePreloadRequest>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private CancellationTokenSource <cameraFadeCts>5__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <>7__wrap17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private TaskAwaiter<LHOHOJEJAHO> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private int <i>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private YieldAwaitable.YieldAwaiter <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private TaskAwaiter<Matchmaking.FANEBMINOHO> <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private CancellationToken <photonJoinedToken>5__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private Task <roomLoadTask>5__21;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8DAC430", Offset = "0x8DAAE30", VA = "0x188DAC430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1AB0", Offset = "0x8DB04B0", VA = "0x188DB1AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct MIOBBMAEINI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public LKFCKGCOBGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <disconnectTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8DBEE10", Offset = "0x8DBD810", VA = "0x188DBEE10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x8DBF880", Offset = "0x8DBE280", VA = "0x188DBF880", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private struct PILIFJAKJAI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public LKFCKGCOBGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private JBJKIIKOACK <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2C10", Offset = "0x8DC1610", VA = "0x188DC2C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x8DC30A0", Offset = "0x8DC1AA0", VA = "0x188DC30A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct FLHMIAOGNJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public AsyncTaskMethodBuilder<Matchmaking.FANEBMINOHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public IAOKBCEAMNP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public LKFCKGCOBGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private TaskAwaiter<Matchmaking.FANEBMINOHO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x8DB21B0", Offset = "0x8DB0BB0", VA = "0x188DB21B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2690", Offset = "0x8DB1090", VA = "0x188DB2690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct FJHMGCMAHLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public Matchmaking.FANEBMINOHO serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public LKFCKGCOBGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public BEOKCNIMCAK joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private TaskAwaiter<HICOKHMGCLG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x8DB1B10", Offset = "0x8DB0510", VA = "0x188DB1B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2150", Offset = "0x8DB0B50", VA = "0x188DB2150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class FAKHKMBGPIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public IAOKBCEAMNP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public bool firstIsWhileInRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public Task firstCompletedTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public FAKHKMBGPIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8DABAC0", Offset = "0x8DAA4C0", VA = "0x188DABAC0")]
		internal object ECFKGDILBHB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8DABBC0", Offset = "0x8DAA5C0", VA = "0x188DABBC0")]
		internal string LIPFHOCJAGO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct LFMPGDCEFAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public IAOKBCEAMNP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public LKFCKGCOBGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private FAKHKMBGPIM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x8DBC400", Offset = "0x8DBAE00", VA = "0x188DBC400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8DBCF90", Offset = "0x8DBB990", VA = "0x188DBCF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct JIIINAEBDCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public LKFCKGCOBGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public BEOKCNIMCAK joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public CCNAABFFCED initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public IAOKBCEAMNP targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public GBKGIJBJPLI preloadContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public GGAMAAEOFMM progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x8DB88B0", Offset = "0x8DB72B0", VA = "0x188DB88B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x8DB90A0", Offset = "0x8DB7AA0", VA = "0x188DB90A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct IMPMFAMPDGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public LKFCKGCOBGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private PDJKNFENBKE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private int <i>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private PDJKNFENBKE <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private CancellationTokenSource <timeoutTcs>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private CancellationToken <timeoutToken>5__8;

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3A20", Offset = "0x8DB2420", VA = "0x188DB3A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8DB5200", Offset = "0x8DB3C00", VA = "0x188DB5200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private struct BACFKODNCCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		public LHDJNPMOIOH localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public LKFCKGCOBGD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private TaskAwaiter<PLLAKKIDGFG> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4300", Offset = "0x8DA2D00", VA = "0x188DA4300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4B00", Offset = "0x8DA3500", VA = "0x188DA4B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class KPAJOLILPAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public IAOKBCEAMNP targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public KPAJOLILPAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8DBC1D0", Offset = "0x8DBABD0", VA = "0x188DBC1D0")]
		internal object PDABMBILPAN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class BEFOHNGCAEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public BEFOHNGCAEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x8DA51C0", Offset = "0x8DA3BC0", VA = "0x188DA51C0")]
		internal void HJGFHMFDPAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class JPIHIEEBGAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public IAOKBCEAMNP targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public JPIHIEEBGAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x8DBA600", Offset = "0x8DB9000", VA = "0x188DBA600")]
		internal object CNCKMBAAGJP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class MNMEHOCDALK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public IAOKBCEAMNP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public MNMEHOCDALK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8DBFAB0", Offset = "0x8DBE4B0", VA = "0x188DBFAB0")]
		internal string OKMIMHLCNAB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static readonly OLFEOKKCIEG MHOBCEACLFK;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static readonly OLFEOKKCIEG JBDNEJHKIHB;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static readonly OLFEOKKCIEG KCJMEAJIOND;

	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private static readonly string EBPGKHOIKNG;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private static readonly string LMADNBLMHGO;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private static readonly string FDCOMKGDNIM;

	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly Guid DKMJGLFKOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private MICBNHDLKLK BPOOOHOMDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private CAKILKPJFMJ PBNJPFBDEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private HJKBCKDIADL EHCDEMFECBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private CHMOOPPGDGB NGALMEDAPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private FFHNIMCCMFI ADCMGLPBECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private JCKIJAFMFEI GHBAGKGJMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private NJNCDDGFIJG PMIBAMBFHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private FPANNDIBPBC LEDABCFBDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private AOJPAFPLIGN POABMPEJDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private JHNBKOHMNNF CCJBPALLILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private IDisposable HOOHHABLJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private CLPEKHGCOFA MDJBCPALBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly OMCJCLBFMAA ABGHJHLGPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private IBFOPPEEJNA NGDABJFODDG;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public TaskStatus KAMKMMHBNJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xAD4A70", Offset = "0xAD3470", VA = "0x180AD4A70", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1618FE0", Offset = "0x16179E0", VA = "0x181618FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private FDNIDPPAKMF EGHDDGIBOKD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x8D99610", Offset = "0x8D98010", VA = "0x188D99610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x8D997B0", Offset = "0x8D981B0", VA = "0x188D997B0", Slot = "6")]
	public void GFALNPPLGKO(CHMOOPPGDGB NGALMEDAPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x8D98CA0", Offset = "0x8D976A0", VA = "0x188D98CA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x8D98EE0", Offset = "0x8D978E0", VA = "0x188D98EE0", Slot = "5")]
	[AsyncStateMachine(typeof(CBNPMPJLFHN))]
	public Task EFHHJHBOPLK(IAOKBCEAMNP LNJDNBJGCOP, HMHMGFNHAOI BHNBGIMGNCE, CancellationToken ICODIHINNBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x8D99660", Offset = "0x8D98060", VA = "0x188D99660")]
	[AsyncStateMachine(typeof(FBFOGIBBEEL))]
	private Task FHJCHALPEHD(IAOKBCEAMNP LNJDNBJGCOP, HMHMGFNHAOI BHNBGIMGNCE, CancellationToken ICODIHINNBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x8D99C80", Offset = "0x8D98680", VA = "0x188D99C80")]
	private void HAHDCOHDFKA(AOJPAFPLIGN POABMPEJDBF, IAOKBCEAMNP LNJDNBJGCOP, Exception JOEMCJLBOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x8D9AD10", Offset = "0x8D99710", VA = "0x188D9AD10")]
	private static void LKPFHFGIMDD(LEIBKJGOLDM FLILODIIECB, Exception JOEMCJLBOIG, [Optional] List<int> KIGJBMMIGAP, int KGGCPCHHLLG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x8D9B540", Offset = "0x8D99F40", VA = "0x188D9B540")]
	[AsyncStateMachine(typeof(JKEHBCAOJEO))]
	private Task LMNLFPMBMFI(OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO, IAOKBCEAMNP LNJDNBJGCOP, HMHMGFNHAOI BHNBGIMGNCE, BEOKCNIMCAK ODOMIKJIGGA, CancellationToken ICODIHINNBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x8D989E0", Offset = "0x8D973E0", VA = "0x188D989E0")]
	[AsyncStateMachine(typeof(FENDCLNBLOE))]
	private Task DEOFILBLFKI(OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO, IAOKBCEAMNP LNJDNBJGCOP, HMHMGFNHAOI BHNBGIMGNCE, BEOKCNIMCAK ODOMIKJIGGA, CancellationToken ICODIHINNBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x8D99020", Offset = "0x8D97A20", VA = "0x188D99020")]
	private void EJPHJPDBDIL([CallerMemberName] string GCEOAEGPIEK = "<unknown>")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8D9A410", Offset = "0x8D98E10", VA = "0x188D9A410")]
	[AsyncStateMachine(typeof(MIOBBMAEINI))]
	private Task JGEGHLFICGE(OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x8D992E0", Offset = "0x8D97CE0", VA = "0x188D992E0")]
	private void ELOEOMKCODD(IAOKBCEAMNP LNJDNBJGCOP, CancellationToken ICODIHINNBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x8D9B9B0", Offset = "0x8D9A3B0", VA = "0x188D9B9B0")]
	private void NJOODBCOPJN(IAOKBCEAMNP LNJDNBJGCOP, TaskStatus HPOEHMOLEIK, string JEBOHIALEMJ, BEOKCNIMCAK ODOMIKJIGGA, Exception FGDPOGPHENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8D9AA90", Offset = "0x8D99490", VA = "0x188D9AA90")]
	private void KNOENLIBMNK(IAOKBCEAMNP LNJDNBJGCOP, BEOKCNIMCAK ODOMIKJIGGA, OperationCanceledException OLNFPLPEGJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8D987C0", Offset = "0x8D971C0", VA = "0x188D987C0")]
	private void CFKIIIKGIAJ(IAOKBCEAMNP LNJDNBJGCOP, BEOKCNIMCAK ODOMIKJIGGA, Exception JOEMCJLBOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x8D985B0", Offset = "0x8D96FB0", VA = "0x188D985B0")]
	private void AMODKAMNHIB(IAOKBCEAMNP LNJDNBJGCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x8D9A0F0", Offset = "0x8D98AF0", VA = "0x188D9A0F0")]
	private static GJIGLAJEIOM HLDFOHKCOGI(IAOKBCEAMNP LNJDNBJGCOP)
	{
		return default(GJIGLAJEIOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x8D98BD0", Offset = "0x8D975D0", VA = "0x188D98BD0")]
	[AsyncStateMachine(typeof(PILIFJAKJAI))]
	private Task DIGCHGOPOFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x8D9A150", Offset = "0x8D98B50", VA = "0x188D9A150")]
	[AsyncStateMachine(typeof(FLHMIAOGNJB))]
	private Task<Matchmaking.FANEBMINOHO> IENLDKCNMAN(IAOKBCEAMNP LNJDNBJGCOP, OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x8D988D0", Offset = "0x8D972D0", VA = "0x188D988D0")]
	private static HICOKHMGCLG CONFKNMAGJB(Matchmaking.FANEBMINOHO DMKFFHGMPDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x8D9B860", Offset = "0x8D9A260", VA = "0x188D9B860")]
	[AsyncStateMachine(typeof(FJHMGCMAHLE))]
	private Task NHNGFOPCGFM(Matchmaking.FANEBMINOHO DMKFFHGMPDC, BEOKCNIMCAK ODOMIKJIGGA, OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO, CancellationToken GPFLDACOAGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x8D9A540", Offset = "0x8D98F40", VA = "0x188D9A540")]
	[AsyncStateMachine(typeof(LFMPGDCEFAB))]
	private Task KCCMKNEGPMD(IAOKBCEAMNP LNJDNBJGCOP, CancellationTokenSource KNNAPFGIIGN, Task NODIPADLCKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x8D9A8B0", Offset = "0x8D992B0", VA = "0x188D9A8B0")]
	[AsyncStateMachine(typeof(JIIINAEBDCP))]
	private Task KJIIKIILOMP(CCNAABFFCED PDDHENJBLND, GGAMAAEOFMM CMPBGOLILAA, IAOKBCEAMNP FPJLANHBKGA, BEOKCNIMCAK KAKJPJOJEKD, OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO, CancellationToken HCOMFHDKMPG, [Optional] GBKGIJBJPLI AKNDJHEIPCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8D98CF0", Offset = "0x8D976F0", VA = "0x188D98CF0")]
	private BEOKCNIMCAK EAJMDFBMJHH(BEOKCNIMCAK KAKJPJOJEKD, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8D991A0", Offset = "0x8D97BA0", VA = "0x188D991A0")]
	[AsyncStateMachine(typeof(IMPMFAMPDGP))]
	private Task EKFMELFIJML(OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8D9B730", Offset = "0x8D9A130", VA = "0x188D9B730")]
	[AsyncStateMachine(typeof(BACFKODNCCN))]
	private Task NFHGNBFFMCC(CancellationToken AHOMALKMHKK, int DIOLIHHBDCB, LHDJNPMOIOH FIGFFLDCNGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x8D9BC10", Offset = "0x8D9A610", VA = "0x188D9BC10")]
	private static void PHILJAOAOBN(IAOKBCEAMNP LNJDNBJGCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x8D9A680", Offset = "0x8D99080", VA = "0x188D9A680")]
	private void KHJBJKGEOMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x8D98B40", Offset = "0x8D97540", VA = "0x188D98B40")]
	private void DFCCLEIHGEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x8D9B6A0", Offset = "0x8D9A0A0", VA = "0x188D9B6A0")]
	private void MFECLDHDCAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x8D98840", Offset = "0x8D97240", VA = "0x188D98840")]
	private void CMBNNJJDAHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x8D9AC20", Offset = "0x8D99620", VA = "0x188D9AC20")]
	private static void LFJMJABLDOC(IAOKBCEAMNP LNJDNBJGCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x8D9AB10", Offset = "0x8D99510", VA = "0x188D9AB10")]
	private static CancellationTokenRegistration LBOLMHONPHN(IAOKBCEAMNP LNJDNBJGCOP, CancellationToken GPFLDACOAGH)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x8D9A2B0", Offset = "0x8D98CB0", VA = "0x188D9A2B0")]
	private static void IKKNLJMANBE(IAOKBCEAMNP LNJDNBJGCOP, Exception JOEMCJLBOIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x8D99AD0", Offset = "0x8D984D0", VA = "0x188D99AD0")]
	private void GKEIPOPFNIB(IAOKBCEAMNP LNJDNBJGCOP, Task NODIPADLCKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x8D9A3B0", Offset = "0x8D98DB0", VA = "0x188D9A3B0")]
	private static void JAPFEIFECJM(Func<string> EDCCMILPHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x8D9BFB0", Offset = "0x8D9A9B0", VA = "0x188D9BFB0")]
	public LKFCKGCOBGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x8D9AA30", Offset = "0x8D99430", VA = "0x188D9AA30")]
	[CompilerGenerated]
	internal static (int, int?) KLPLLOAFNEG(IPMMGHJONLE NGDAMNDJLIJ)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[RecRoom.NoEngine.Common.Preserve]
internal class CIHNOADLJMB : NPIAOHCMBCD, ANMLBOEMDKO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct GCDAALMBJIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public CIHNOADLJMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public LHDJNPMOIOH localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2B00", Offset = "0x8DB1500", VA = "0x188DB2B00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2FE0", Offset = "0x8DB19E0", VA = "0x188DB2FE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class DHGPOGJGBHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public CIHNOADLJMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public LHDJNPMOIOH localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public DHGPOGJGBHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8DA9020", Offset = "0x8DA7A20", VA = "0x188DA9020")]
		internal List<Task> NLMADCAKKFJ(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct FNDOOCPHOPC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public JKLLJDPDOFE taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public LHDJNPMOIOH localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2700", Offset = "0x8DB1100", VA = "0x188DB2700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8DB2AA0", Offset = "0x8DB14A0", VA = "0x188DB2AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct MFCJJLJLNOD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public CIHNOADLJMB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x8DBEAD0", Offset = "0x8DBD4D0", VA = "0x188DBEAD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x8DBEDB0", Offset = "0x8DBD7B0", VA = "0x188DBEDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private readonly HashSet<JKLLJDPDOFE> GIPLBKKPLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private CAKILKPJFMJ PBNJPFBDEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private CHMOOPPGDGB NGALMEDAPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private BGBIJHCFHPL NEKIJAPJCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private EHOMLENHKML MCAAOJAIDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private IDisposable HOOHHABLJPA;

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x8DA7180", Offset = "0x8DA5B80", VA = "0x188DA7180", Slot = "5")]
	public void GFALNPPLGKO(CHMOOPPGDGB NGALMEDAPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8DA7120", Offset = "0x8DA5B20", VA = "0x188DA7120", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x8DA7550", Offset = "0x8DA5F50", VA = "0x188DA7550", Slot = "4")]
	public bool HPALILEMODP(JKLLJDPDOFE NBLILNHGKBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x8DA7050", Offset = "0x8DA5A50", VA = "0x188DA7050")]
	private void CLLHPEEGGJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8DA7CF0", Offset = "0x8DA66F0", VA = "0x188DA7CF0")]
	private void MHEHGFDACAA(CMFAJILFAHI KALMEDGIGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x8DA7460", Offset = "0x8DA5E60", VA = "0x188DA7460")]
	[AsyncStateMachine(typeof(GCDAALMBJIK))]
	private Task GIEDNNJFKCI(int DIOLIHHBDCB, LHDJNPMOIOH FIGFFLDCNGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x8DA7A80", Offset = "0x8DA6480", VA = "0x188DA7A80")]
	private Func<CancellationToken, List<Task>> KDIJCCKFKKN(int DIOLIHHBDCB, LHDJNPMOIOH FIGFFLDCNGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x8DA75B0", Offset = "0x8DA5FB0", VA = "0x188DA75B0")]
	private List<Task> JCDNLADBCFK(int DIOLIHHBDCB, LHDJNPMOIOH FIGFFLDCNGJ, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x8DA7B50", Offset = "0x8DA6550", VA = "0x188DA7B50")]
	[AsyncStateMachine(typeof(FNDOOCPHOPC))]
	private Task KGBOMEIENEI(JKLLJDPDOFE OLGHGKJILEE, CancellationToken MFKHKDDANII, int DIOLIHHBDCB, LHDJNPMOIOH FIGFFLDCNGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x8DA6F80", Offset = "0x8DA5980", VA = "0x188DA6F80")]
	[AsyncStateMachine(typeof(MFCJJLJLNOD))]
	private Task BDHHOAKBLCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x8DA7C70", Offset = "0x8DA6670", VA = "0x188DA7C70")]
	private void LFPMCBHAIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x8DA7F10", Offset = "0x8DA6910", VA = "0x188DA7F10")]
	public CIHNOADLJMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[UnityEngine.Scripting.Preserve]
internal sealed class JDCPKOLNIKK : BOHEKDBLILG, ANMLBOEMDKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class EPGKGBOJBOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public EPGKGBOJBOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8DABA60", Offset = "0x8DAA460", VA = "0x188DABA60")]
		internal object HCDBNANJMBE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class JJJBMFDLKHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public JJJBMFDLKHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x8DB9100", Offset = "0x8DB7B00", VA = "0x188DB9100")]
		internal object LLNJAMFAIEN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class NPOOECLJBPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public NPOOECLJBPC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class LOMOIPDDEEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public LOMOIPDDEEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x8DBE3D0", Offset = "0x8DBCDD0", VA = "0x188DBE3D0")]
		internal object LGLBOHOOAPF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class KGBFJOMBNHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public KGBFJOMBNHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8DBA680", Offset = "0x8DB9080", VA = "0x188DBA680")]
		internal object NNKCBMGJEPG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private readonly Dictionary<Guid, NMCOENJPGAP> BIEBDFEBCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private readonly TimeSpan FFCNPJHJLIM;

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "9")]
	public void GFALNPPLGKO(CHMOOPPGDGB NGALMEDAPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x8DB5600", Offset = "0x8DB4000", VA = "0x188DB5600", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x8DB5840", Offset = "0x8DB4240", VA = "0x188DB5840", Slot = "4")]
	public EBNAOPOIBGD HMDNMGBNKIA(Guid CHBBGPKOFFN)
	{
		return default(EBNAOPOIBGD);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x8DB5CB0", Offset = "0x8DB46B0", VA = "0x188DB5CB0", Slot = "5")]
	public bool MCKODPOBNPM(Guid CHBBGPKOFFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x8DB52D0", Offset = "0x8DB3CD0", VA = "0x188DB52D0", Slot = "6")]
	public bool AGMJAPNBBHL(Guid CHBBGPKOFFN, Task GHMNDMGCGPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x8DB5A60", Offset = "0x8DB4460", VA = "0x188DB5A60", Slot = "7")]
	public bool JHDFDCJKJCL(Guid CHBBGPKOFFN, PLLAKKIDGFG JHOGHDKBLCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x8DB5C40", Offset = "0x8DB4640", VA = "0x188DB5C40", Slot = "8")]
	public Task<(PLLAKKIDGFG, Task)> KKBOAKPDGLN(Guid CHBBGPKOFFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x8DB5610", Offset = "0x8DB4010", VA = "0x188DB5610")]
	private void FAAFKHCLBMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x8DB5EC0", Offset = "0x8DB48C0", VA = "0x188DB5EC0")]
	public JDCPKOLNIKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[RecRoom.NoEngine.Common.Preserve]
internal class JNBOGACFHFJ : IGCCPCGGBCA, ANMLBOEMDKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class NFIJGLGBNJO : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private readonly IAOKBCEAMNP CINMFCJDKFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private readonly CancellationTokenSource CFDOKKENJBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public readonly CancellationToken EBOBALABOOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private bool GPKBDPPOADH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private bool ICPNMNBNLKA;

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1650", Offset = "0x8DC0050", VA = "0x188DC1650")]
		public NFIJGLGBNJO(IAOKBCEAMNP CINMFCJDKFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1500", Offset = "0x8DBFF00", VA = "0x188DC1500")]
		public void LFPMCBHAIJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x8DC14D0", Offset = "0x8DBFED0", VA = "0x188DC14D0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class FDLLMIIKEBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public NHLJKPJALOB disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public FDLLMIIKEBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8DAC3A0", Offset = "0x8DAADA0", VA = "0x188DAC3A0")]
		internal object KGLDKEMFEFI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private struct MOMEDHEFBEE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public NHLJKPJALOB disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public JNBOGACFHFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8DBFBB0", Offset = "0x8DBE5B0", VA = "0x188DBFBB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0010", Offset = "0x8DBEA10", VA = "0x188DC0010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class ELIGHIEJEEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public JNBOGACFHFJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public ELIGHIEJEEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x8DAB6F0", Offset = "0x8DAA0F0", VA = "0x188DAB6F0")]
		internal object NCCJELGMIIC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class GIOGIMMPIJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public IAOKBCEAMNP newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public ELIGHIEJEEB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public GIOGIMMPIJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3040", Offset = "0x8DB1A40", VA = "0x188DB3040")]
		internal object OMEMKHDBHOB((IAOKBCEAMNP lastLocalPlayerRoomInstance, IAOKBCEAMNP newRoomInstance, JCKIJAFMFEI fallbacks) x)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct BMLEEIEOONL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public JNBOGACFHFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private IDisposable <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private PDJKNFENBKE <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x8DA52C0", Offset = "0x8DA3CC0", VA = "0x188DA52C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class NPBNNDKKKJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public IAOKBCEAMNP newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public NPBNNDKKKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x8DC17A0", Offset = "0x8DC01A0", VA = "0x188DC17A0")]
		internal object COFIFDNKNIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1880", Offset = "0x8DC0280", VA = "0x188DC1880")]
		internal void KDIKILCMMKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1760", Offset = "0x8DC0160", VA = "0x188DC1760")]
		internal object ADGHKPHKJKG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1840", Offset = "0x8DC0240", VA = "0x188DC1840")]
		internal object KALFPLINMHE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct KJKHAHDPIDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public IAOKBCEAMNP newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public JNBOGACFHFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public HMHMGFNHAOI customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private NPBNNDKKKJE <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private CancellationTokenRegistration <_>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x8DBA6E0", Offset = "0x8DB90E0", VA = "0x188DBA6E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x8DBB6B0", Offset = "0x8DBA0B0", VA = "0x188DBB6B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static readonly ANFNDBGKCDF.KGHHEBKBKNG FPNCMPLMKEN;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static readonly CFCAHAGIHFI LJOECAFPBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private CAKILKPJFMJ PBNJPFBDEJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private CHMOOPPGDGB NGALMEDAPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private JCKIJAFMFEI GHBAGKGJMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private FFHNIMCCMFI ADCMGLPBECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private OCFAJKILBCD OINEAODAACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private NHFIPDDNFBP FKCCFDGGNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private IAOKBCEAMNP AKLFFFBFBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private NFIJGLGBNJO NHCKGOKCBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private bool DADEKFDLALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private Task CHJICALCNCL;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private FDNIDPPAKMF EGHDDGIBOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x8DB9A00", Offset = "0x8DB8400", VA = "0x188DB9A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool LIAGFIIIBIN
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xB2F7F0", Offset = "0xB2E1F0", VA = "0x180B2F7F0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x8DB92E0", Offset = "0x8DB7CE0", VA = "0x188DB92E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x8DB9B80", Offset = "0x8DB8580", VA = "0x188DB9B80", Slot = "4")]
	public void GFALNPPLGKO(CHMOOPPGDGB NGALMEDAPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x8DB9720", Offset = "0x8DB8120", VA = "0x188DB9720", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x8DB9910", Offset = "0x8DB8310", VA = "0x188DB9910")]
	[AsyncStateMachine(typeof(MOMEDHEFBEE))]
	private Task EKIECEHINNC(NHLJKPJALOB JADHDJOECGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x8DB9E20", Offset = "0x8DB8820", VA = "0x188DB9E20")]
	private void JHLOKJPKLAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x8DB9590", Offset = "0x8DB7F90", VA = "0x188DB9590")]
	private void COBHAADGAJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x8DB9160", Offset = "0x8DB7B60", VA = "0x188DB9160")]
	private void BAMCHFJFLLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x8DB9890", Offset = "0x8DB8290", VA = "0x188DB9890")]
	private bool EKEOJGBOCCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x8DBA100", Offset = "0x8DB8B00", VA = "0x188DBA100")]
	[AsyncStateMachine(typeof(BMLEEIEOONL))]
	private void PAMIABLNBDC(int MCNJLDELGIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x8DB92F0", Offset = "0x8DB7CF0", VA = "0x188DB92F0")]
	private void BJLCJAMHJNN([Out] IDisposable NJIBMMJLPGG, [Out] IDisposable MAELGBOOEMG, [Out] IDisposable LDODHOGJGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x8DBA000", Offset = "0x8DB8A00", VA = "0x188DBA000")]
	private bool OKBOAKAHDMC(IAOKBCEAMNP CINMFCJDKFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8DB9FB0", Offset = "0x8DB89B0", VA = "0x188DB9FB0")]
	private void NJLMCECEDPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x8DB9A50", Offset = "0x8DB8450", VA = "0x188DB9A50")]
	[AsyncStateMachine(typeof(KJKHAHDPIDB))]
	private Task FHJCHALPEHD(IAOKBCEAMNP CINMFCJDKFE, HMHMGFNHAOI BHNBGIMGNCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x8DBA590", Offset = "0x8DB8F90", VA = "0x188DBA590")]
	public JNBOGACFHFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[UnityEngine.Scripting.Preserve]
internal sealed class JHHKAAJDHJB : PCCEEOKIMCJ, ANMLBOEMDKO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct EPCIBNKCBEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public AsyncTaskMethodBuilder<BIHFGJAHICO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public JHHKAAJDHJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private TaskAwaiter<BIHFGJAHICO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x8DAB760", Offset = "0x8DAA160", VA = "0x188DAB760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x8DAB9F0", Offset = "0x8DAA3F0", VA = "0x188DAB9F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class NKIEPCECKJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public BDHPLICAJHI message;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public NKIEPCECKJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1700", Offset = "0x8DC0100", VA = "0x188DC1700")]
		internal object EMFMLIAMKBH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class EGPELJCIAOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public BDHPLICAJHI messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public EGPELJCIAOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x8DAAF80", Offset = "0x8DA9980", VA = "0x188DAAF80")]
		internal object NCFOENNBNMH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class ONOONKGOGMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public BDHPLICAJHI request;

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public ONOONKGOGMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2580", Offset = "0x8DC0F80", VA = "0x188DC2580")]
		internal object EFGAHDODHDP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct DGPEALBOOBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public BDHPLICAJHI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public JHHKAAJDHJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private TaskAwaiter<ECHHAJDKEIH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x8DA86F0", Offset = "0x8DA70F0", VA = "0x188DA86F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8FC0", Offset = "0x8DA79C0", VA = "0x188DA8FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class LADJDBLGEBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public BDHPLICAJHI operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public LADJDBLGEBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x8DBC3A0", Offset = "0x8DBADA0", VA = "0x188DBC3A0")]
		internal object COMMLLCJHPM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct OINJFLFNGCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public BDHPLICAJHI operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public JHHKAAJDHJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private BEOKCNIMCAK <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private TaskAwaiter<BDHPLICAJHI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x8DC19B0", Offset = "0x8DC03B0", VA = "0x188DC19B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2520", Offset = "0x8DC0F20", VA = "0x188DC2520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct JEPFPIDAKMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public AsyncTaskMethodBuilder<ECHHAJDKEIH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public JHHKAAJDHJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public BDHPLICAJHI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private NFEONMCCHNO.PHEAPBNNDLE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private BEOKCNIMCAK <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private TaskAwaiter<BDHPLICAJHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x8DB6FA0", Offset = "0x8DB59A0", VA = "0x188DB6FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x8DB74D0", Offset = "0x8DB5ED0", VA = "0x188DB74D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class MMJBEPHEFJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public ECHHAJDKEIH operation;

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public MMJBEPHEFJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x8DBFA30", Offset = "0x8DBE430", VA = "0x188DBFA30")]
		internal object PPAOLMDEDPO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct MAJAJNLPLCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public ECHHAJDKEIH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public JHHKAAJDHJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private OEEGBKAOPAE<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x8DBE430", Offset = "0x8DBCE30", VA = "0x188DBE430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x8DBEA70", Offset = "0x8DBD470", VA = "0x188DBEA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private sealed class PDLBPHHBBJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public BDHPLICAJHI request;

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public PDLBPHHBBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x8DC25E0", Offset = "0x8DC0FE0", VA = "0x188DC25E0")]
		internal object GIGDCMILGBK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class KOMMEDAAJHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public BDHPLICAJHI request;

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public KOMMEDAAJHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x8DBC170", Offset = "0x8DBAB70", VA = "0x188DBC170")]
		internal object MBPGIBNJLOB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private CHMOOPPGDGB NGALMEDAPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private NJNCDDGFIJG PMIBAMBFHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private DBBKACJHNHN OGNBPNDMMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private MGDNOIFCHIM JHJAMFNHLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private HJKBCKDIADL EHCDEMFECBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private TaskCompletionSource<BIHFGJAHICO> DKGAHFFGAKP;

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x8DB7E50", Offset = "0x8DB6850", VA = "0x188DB7E50", Slot = "7")]
	public void GFALNPPLGKO(CHMOOPPGDGB NGALMEDAPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x8DB8500", Offset = "0x8DB6F00", VA = "0x188DB8500", Slot = "6")]
	[AsyncStateMachine(typeof(EPCIBNKCBEG))]
	public Task<BIHFGJAHICO> MHILJBGIABJ(CancellationToken CLOHGGHEHCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x8DB7690", Offset = "0x8DB6090", VA = "0x188DB7690", Slot = "4")]
	public void CCNLPAFEPHA(BDHPLICAJHI JEBOHIALEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x8DB7B10", Offset = "0x8DB6510", VA = "0x188DB7B10", Slot = "5")]
	public void CFHLADDNNNC(BDHPLICAJHI OEMPCGOOIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x8DB7F40", Offset = "0x8DB6940", VA = "0x188DB7F40")]
	[AsyncStateMachine(typeof(DGPEALBOOBE))]
	private Task GGCMLDDEDGA(BDHPLICAJHI KGHMNJMLIBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x8DB7A00", Offset = "0x8DB6400", VA = "0x188DB7A00")]
	[AsyncStateMachine(typeof(OINJFLFNGCH))]
	private Task CDJBOOCDHED(BDHPLICAJHI DLMKDJMDNEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x8DB7540", Offset = "0x8DB5F40", VA = "0x188DB7540")]
	[AsyncStateMachine(typeof(JEPFPIDAKMJ))]
	private Task<ECHHAJDKEIH> BKHONLDJGNJ(BDHPLICAJHI KGHMNJMLIBE, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x8DB8820", Offset = "0x8DB7220", VA = "0x188DB8820")]
	private BEOKCNIMCAK PMCACDKPFNN(BDHPLICAJHI JLJGLLPFINF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x8DB83E0", Offset = "0x8DB6DE0", VA = "0x188DB83E0")]
	[AsyncStateMachine(typeof(MAJAJNLPLCD))]
	private Task KIILGOPKLOG(ECHHAJDKEIH BEINHMMJKLL, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x8DB8610", Offset = "0x8DB7010", VA = "0x188DB8610")]
	private ECHHAJDKEIH MOKNMJADHBL(BDHPLICAJHI KGHMNJMLIBE, BEOKCNIMCAK BJGHICAFBLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x3E23E70", Offset = "0x3E22870", VA = "0x183E23E70")]
	private T IBOIIKBNMLA<T>(T KMAFNKGMDCF) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x8DB8050", Offset = "0x8DB6A50", VA = "0x188DB8050")]
	private ECHHAJDKEIH HNHGOCOFIMI(BDHPLICAJHI KGHMNJMLIBE, BEOKCNIMCAK BJGHICAFBLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public JHHKAAJDHJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[UnityEngine.Scripting.Preserve]
internal sealed class DOKNJGMBALH : DBBKACJHNHN, ANMLBOEMDKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class DFMDKIAGCOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public DFMDKIAGCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8680", Offset = "0x8DA7080", VA = "0x188DA8680")]
		internal object BIIGLHIEPII()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class EBAIBLMIABD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public EBAIBLMIABD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x8DAAF10", Offset = "0x8DA9910", VA = "0x188DAAF10")]
		internal object OPPCPJFJHHB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private HJKBCKDIADL EHCDEMFECBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private ABAEFDCOKIJ NHINLCDNNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private PCCEEOKIMCJ EPPBFHPGIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private BOHEKDBLILG BIEBDFEBCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private GMELFNJAPGB DGBOCEDDJHF;

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x8DAA3D0", Offset = "0x8DA8DD0", VA = "0x188DAA3D0", Slot = "6")]
	public void GFALNPPLGKO(CHMOOPPGDGB NGALMEDAPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x8DA9DB0", Offset = "0x8DA87B0", VA = "0x188DA9DB0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x8DA9060", Offset = "0x8DA7A60", VA = "0x188DA9060", Slot = "4")]
	public EBNAOPOIBGD BAIHPMDJBIL(BDHPLICAJHI FAPGJPNHNMB)
	{
		return default(EBNAOPOIBGD);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x8DAA0B0", Offset = "0x8DA8AB0", VA = "0x188DAA0B0", Slot = "5")]
	public void FNOCFHADPAF(Guid CHBBGPKOFFN, Task GHMNDMGCGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x8DAA2C0", Offset = "0x8DA8CC0", VA = "0x188DAA2C0")]
	private void FPBJHHIGEPM(PJCAKALKNLJ DHNILGMCEHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x8DAA540", Offset = "0x8DA8F40", VA = "0x188DAA540")]
	private void HNDBGMNAEMA(MBBOMGNGMKO PPGGMEFFGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x8DA9B20", Offset = "0x8DA8520", VA = "0x188DA9B20")]
	private void DKMJKDFCAJE(MBBOMGNGMKO PPGGMEFFGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x8DA94A0", Offset = "0x8DA7EA0", VA = "0x188DA94A0")]
	private void BBEDEGGJBFJ(MBBOMGNGMKO PPGGMEFFGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x8DA98D0", Offset = "0x8DA82D0", VA = "0x188DA98D0")]
	private PLLAKKIDGFG CCGAIBADILH(BDHPLICAJHI JLJGLLPFINF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x8DAAAE0", Offset = "0x8DA94E0", VA = "0x188DAAAE0")]
	private void IOLMPCNMDBK(BDHPLICAJHI DLMKDJMDNEH, PLLAKKIDGFG JHOGHDKBLCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x8DA96E0", Offset = "0x8DA80E0", VA = "0x188DA96E0")]
	private bool BIPILLCHFKC(BDHPLICAJHI DLMKDJMDNEH, PLLAKKIDGFG JHOGHDKBLCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x8DAACF0", Offset = "0x8DA96F0", VA = "0x188DAACF0")]
	private bool KPALMJOOOLO(BDHPLICAJHI GIPJNBHGCCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x8DA9E60", Offset = "0x8DA8860", VA = "0x188DA9E60")]
	private bool FIBJODJKNIO(byte DMJFIGMGCMF, ExitGames.Client.Photon.Hashtable PPGGMEFFGDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public DOKNJGMBALH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[UnityEngine.Scripting.Preserve]
internal sealed class CDCGEAAEAEB : GCNPEJHCBNO, ANMLBOEMDKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class APFHCNNBPBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public BIHFGJAHICO operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public CDCGEAAEAEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public BDHPLICAJHI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public APFHCNNBPBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4290", Offset = "0x8DA2C90", VA = "0x188DA4290")]
		internal object GCAGMPPAGCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4160", Offset = "0x8DA2B60", VA = "0x188DA4160")]
		internal object FMJBFKBDEJK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct EHKOKIKKPCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public AsyncTaskMethodBuilder<PLLAKKIDGFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public CDCGEAAEAEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public BDHPLICAJHI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private TaskAwaiter<PLLAKKIDGFG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x8DAAFE0", Offset = "0x8DA99E0", VA = "0x188DAAFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x8DAB680", Offset = "0x8DAA080", VA = "0x188DAB680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class JCNOBLLFEBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public BIHFGJAHICO operationType;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public JCNOBLLFEBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x8DB5260", Offset = "0x8DB3C60", VA = "0x188DB5260")]
		internal object PNCPKLHDGGJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class MKHIPENIHNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public BDHPLICAJHI request;

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public MKHIPENIHNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x8DBF8E0", Offset = "0x8DBE2E0", VA = "0x188DBF8E0")]
		internal object GBBGLMMPHJL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x8DBF950", Offset = "0x8DBE350", VA = "0x188DBF950")]
		internal object HGEDFJFLMIB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x8DBF9C0", Offset = "0x8DBE3C0", VA = "0x188DBF9C0")]
		internal object HKGLLHKNKNM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct KLLBOKHKHCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public AsyncTaskMethodBuilder<PLLAKKIDGFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public BDHPLICAJHI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public CDCGEAAEAEB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private MKHIPENIHNA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private EBNAOPOIBGD <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private PLLAKKIDGFG <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private TaskAwaiter<(PLLAKKIDGFG validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x8DBB710", Offset = "0x8DBA110", VA = "0x188DBB710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x8DBC100", Offset = "0x8DBAB00", VA = "0x188DBC100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private HJKBCKDIADL EHCDEMFECBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	private ABAEFDCOKIJ NHINLCDNNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	private DBBKACJHNHN OGNBPNDMMOO;

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x8DA6D90", Offset = "0x8DA5790", VA = "0x188DA6D90", Slot = "5")]
	public void GFALNPPLGKO(CHMOOPPGDGB NGALMEDAPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x8DA6A80", Offset = "0x8DA5480", VA = "0x188DA6A80", Slot = "4")]
	[AsyncStateMachine(typeof(EHKOKIKKPCH))]
	private Task<PLLAKKIDGFG> BPMGBFKIFFA(BDHPLICAJHI JLJGLLPFINF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x8DA6BA0", Offset = "0x8DA55A0", VA = "0x188DA6BA0")]
	private bool ELMCLGLKFJH(BIHFGJAHICO JCECGKAIEFB, [Out] PLLAKKIDGFG GGIKEMCHAAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x8DA6E40", Offset = "0x8DA5840", VA = "0x188DA6E40")]
	[AsyncStateMachine(typeof(KLLBOKHKHCD))]
	private Task<PLLAKKIDGFG> ILINHMHALIB(BDHPLICAJHI KGHMNJMLIBE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public CDCGEAAEAEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class NEMGOOJIKHN : PAAMJEMAEPM, ANMLBOEMDKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private struct PANFBPGOBLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public APAFHBPABPH BLIAFKGLLAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public long LBHCKDPDBMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public Guid? NBAIIFKAHKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public bool IADDODKCNAI;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct LNCLOCCPDPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public AsyncTaskMethodBuilder<CCNAABFFCED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public IAOKBCEAMNP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public NEMGOOJIKHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private TaskAwaiter<PKCMPJMLDGM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private TaskAwaiter<CCNAABFFCED> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x8DBDD90", Offset = "0x8DBC790", VA = "0x188DBDD90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x8DBE360", Offset = "0x8DBCD60", VA = "0x188DBE360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class AFHEBPJJLJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public AFHEBPJJLJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x8DA40B0", Offset = "0x8DA2AB0", VA = "0x188DA40B0")]
		internal object CAFINGFANAE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct BBALEKHBGEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public AsyncTaskMethodBuilder<PKCMPJMLDGM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public NEMGOOJIKHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public IAOKBCEAMNP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private AFHEBPJJLJP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private TaskAwaiter<PKCMPJMLDGM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x8DA4B60", Offset = "0x8DA3560", VA = "0x188DA4B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x8DA5150", Offset = "0x8DA3B50", VA = "0x188DA5150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private struct FCMNJHJIKDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public AsyncTaskMethodBuilder<CCNAABFFCED> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public NEMGOOJIKHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public IAOKBCEAMNP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public PKCMPJMLDGM roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private TaskAwaiter<PANFBPGOBLB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x8DABDC0", Offset = "0x8DAA7C0", VA = "0x188DABDC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x8DAC330", Offset = "0x8DAAD30", VA = "0x188DAC330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class IEKBBIDJMMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public PKCMPJMLDGM roomDetailsDto;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public IEKBBIDJMMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x1369040", Offset = "0x1367A40", VA = "0x181369040")]
		internal bool LEDMABFGMBA(PMHLBPGOPPD sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3840", Offset = "0x8DB2240", VA = "0x188DB3840")]
		internal object BCIKKBOBNEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3990", Offset = "0x8DB2390", VA = "0x188DB3990")]
		internal object IPNHMJIFDAC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3900", Offset = "0x8DB2300", VA = "0x188DB3900")]
		internal object IMNAKDAGLFF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class FBNLAOLDNPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public bool loadUsedCompatibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public IEKBBIDJMMI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public FBNLAOLDNPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x8DABCC0", Offset = "0x8DAA6C0", VA = "0x188DABCC0")]
		internal object DNMGDCKPLOH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private struct JEJNFKLDOEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public AsyncTaskMethodBuilder<PANFBPGOBLB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public PKCMPJMLDGM roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public NEMGOOJIKHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public IAOKBCEAMNP targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private FBNLAOLDNPH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private TaskAwaiter<PANFBPGOBLB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private TaskAwaiter<LFPGAJNOPDL> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x8DB5F80", Offset = "0x8DB4980", VA = "0x188DB5F80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x8DB6F30", Offset = "0x8DB5930", VA = "0x188DB6F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class OGEBLGILEBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public OGEBLGILEBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x8DC1900", Offset = "0x8DC0300", VA = "0x188DC1900")]
		internal object LKOFDAGCANG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private struct LHEOLNMFGCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public AsyncTaskMethodBuilder<PANFBPGOBLB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public PMHLBPGOPPD subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public NEMGOOJIKHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public IAOKBCEAMNP dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private OGEBLGILEBK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private TaskAwaiter<INDFDDFMNAH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x8DBCFF0", Offset = "0x8DBB9F0", VA = "0x188DBCFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x8DBD6B0", Offset = "0x8DBC0B0", VA = "0x188DBD6B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private FFHNIMCCMFI ADCMGLPBECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private OCFAJKILBCD OINEAODAACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private PICKPONNANE APHOBCNFJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private CIACMOGMJDE HNJGFMCIFLL;

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x8DC1270", Offset = "0x8DBFC70", VA = "0x188DC1270", Slot = "5")]
	public void GFALNPPLGKO(CHMOOPPGDGB NGALMEDAPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x8DC0E40", Offset = "0x8DBF840", VA = "0x188DC0E40", Slot = "4")]
	[AsyncStateMachine(typeof(LNCLOCCPDPD))]
	public Task<CCNAABFFCED> CCNOFCMKLMG(OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, IAOKBCEAMNP LNJDNBJGCOP, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x8DC0FA0", Offset = "0x8DBF9A0", VA = "0x188DC0FA0")]
	[AsyncStateMachine(typeof(BBALEKHBGEO))]
	private Task<PKCMPJMLDGM> DBDIAFFKKAJ(IAOKBCEAMNP LNJDNBJGCOP, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x8DC1360", Offset = "0x8DBFD60", VA = "0x188DC1360")]
	[AsyncStateMachine(typeof(FCMNJHJIKDG))]
	private Task<CCNAABFFCED> HOANNJHCADI(IAOKBCEAMNP LNJDNBJGCOP, PKCMPJMLDGM NDIBIPMCCAA, long GKOJBHIBFEI, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x8DC1100", Offset = "0x8DBFB00", VA = "0x188DC1100")]
	[AsyncStateMachine(typeof(JEJNFKLDOEI))]
	private Task<PANFBPGOBLB> DCGGPLNFDHJ(IAOKBCEAMNP LNJDNBJGCOP, PKCMPJMLDGM NDIBIPMCCAA, long GKOJBHIBFEI, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x8DC0CD0", Offset = "0x8DBF6D0", VA = "0x188DC0CD0")]
	[AsyncStateMachine(typeof(LHEOLNMFGCE))]
	private Task<PANFBPGOBLB> AJPGHNCIEAJ(IAOKBCEAMNP CFCHEEPCIOE, PMHLBPGOPPD JFDMBMLPAKA, long GKOJBHIBFEI, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public NEMGOOJIKHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[UnityEngine.Scripting.Preserve]
internal sealed class HHJFOBLEHMN : MGDNOIFCHIM, ANMLBOEMDKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private sealed class CLHNJJBKAOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public BDHPLICAJHI request;

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public CLHNJJBKAOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x8DA7FA0", Offset = "0x8DA69A0", VA = "0x188DA7FA0")]
		internal object FEGNBPBBCME()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private struct DCPJCCIECJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public AsyncTaskMethodBuilder<BDHPLICAJHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public BDHPLICAJHI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public HHJFOBLEHMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public BEOKCNIMCAK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private TaskAwaiter<BDHPLICAJHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8000", Offset = "0x8DA6A00", VA = "0x188DA8000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x8DA8610", Offset = "0x8DA7010", VA = "0x188DA8610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct LKCDKOKOGDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public AsyncTaskMethodBuilder<BDHPLICAJHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public HHJFOBLEHMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public BEOKCNIMCAK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private TaskAwaiter<PBHNDNMOAMM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x8DBD720", Offset = "0x8DBC120", VA = "0x188DBD720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x8DBDD20", Offset = "0x8DBC720", VA = "0x188DBDD20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class BIILAEEMHGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public BDHPLICAJHI request;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public BIILAEEMHGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x8DA5260", Offset = "0x8DA3C60", VA = "0x188DA5260")]
		internal object JFBAEKINJJM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct NEHKLFGBADC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public AsyncTaskMethodBuilder<BDHPLICAJHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public BDHPLICAJHI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public HHJFOBLEHMN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public BEOKCNIMCAK pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private ACGHAABHPJL <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private DGCJEIIOAGH <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private TaskAwaiter<PBHNDNMOAMM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0070", Offset = "0x8DBEA70", VA = "0x188DC0070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x8DC0C60", Offset = "0x8DBF660", VA = "0x188DC0C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	private HJKBCKDIADL EHCDEMFECBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private FEHEMDONNPM HIGAMBEJOLA;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private BGJPDHDKIOB AIPDFGPJCFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x8DB3410", Offset = "0x8DB1E10", VA = "0x188DB3410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x8DB3380", Offset = "0x8DB1D80", VA = "0x188DB3380", Slot = "8")]
	public void GFALNPPLGKO(CHMOOPPGDGB NGALMEDAPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x8DB36E0", Offset = "0x8DB20E0", VA = "0x188DB36E0", Slot = "4")]
	[AsyncStateMachine(typeof(DCPJCCIECJA))]
	public Task<BDHPLICAJHI> NLECGBAPBPP(BDHPLICAJHI KGHMNJMLIBE, BEOKCNIMCAK BJGHICAFBLM, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x8DB3230", Offset = "0x8DB1C30", VA = "0x188DB3230", Slot = "5")]
	[AsyncStateMachine(typeof(LKCDKOKOGDG))]
	public Task<BDHPLICAJHI> EFKFCGKEFPB(CancellationToken AHOMALKMHKK, BEOKCNIMCAK BJGHICAFBLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x8DB3630", Offset = "0x8DB2030", VA = "0x188DB3630", Slot = "6")]
	public GPFLGLGCINI KPLBNKPMPNF(ECHHAJDKEIH CDMEODDBMHD, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x8DB3100", Offset = "0x8DB1B00", VA = "0x188DB3100", Slot = "7")]
	public GPFLGLGCINI DLGEGAJCALB(ECHHAJDKEIH CDMEODDBMHD, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x8DB34D0", Offset = "0x8DB1ED0", VA = "0x188DB34D0")]
	[AsyncStateMachine(typeof(NEHKLFGBADC))]
	private Task<BDHPLICAJHI> JBIOFLNLMGC(BDHPLICAJHI KGHMNJMLIBE, BEOKCNIMCAK BJGHICAFBLM, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x3DBAB70", Offset = "0x3DB9570", VA = "0x183DBAB70")]
	private static byte[] MOPEFKNBKDB(BDHPLICAJHI JEBOHIALEMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public HHJFOBLEHMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[UnityEngine.Scripting.Preserve]
internal sealed class PFLHEKMOBGL : ABAEFDCOKIJ, ANMLBOEMDKO, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	private MFMJLFCOBPH DEHLJHOMOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private HJKBCKDIADL EHCDEMFECBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private NJNCDDGFIJG PMIBAMBFHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private PLEFOEBMOOP GPIGCHBFGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	private FFHNIMCCMFI ADCMGLPBECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private NHFIPDDNFBP FKCCFDGGNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private NPIAOHCMBCD DCODBNKMEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private OCFAJKILBCD OINEAODAACF;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private FDNIDPPAKMF EGHDDGIBOKD
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2650", Offset = "0x8DC1050", VA = "0x188DC2650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private static PLLAKKIDGFG ANDPHKADADF
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x8DC2640", Offset = "0x8DC1040", VA = "0x188DC2640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x8DC26A0", Offset = "0x8DC10A0", VA = "0x188DC26A0", Slot = "6")]
	public void GFALNPPLGKO(CHMOOPPGDGB NGALMEDAPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x8DC2AA0", Offset = "0x8DC14A0", VA = "0x188DC2AA0", Slot = "4")]
	public PLLAKKIDGFG LJIJNGNKKKA(FNAEIBBBBBE OHCMPLALIOB, BIHFGJAHICO EJLDBIEEPEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x8DC2810", Offset = "0x8DC1210", VA = "0x188DC2810", Slot = "5")]
	public PLLAKKIDGFG JFLOOFBIOND(FNAEIBBBBBE AFLHBKMHOEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x8DC2A90", Offset = "0x8DC1490", VA = "0x188DC2A90")]
	private static PLLAKKIDGFG KPKAPBJBJBL(CAIEKIDAKIA LJPPNNLHGCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public PFLHEKMOBGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public class FNAMGLCJPBD : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x8DCA9B0", Offset = "0x8DC93B0", VA = "0x188DCA9B0")]
	public FNAMGLCJPBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x7E888E0", Offset = "0x7E872E0", VA = "0x187E888E0")]
	public FNAMGLCJPBD(string JEBOHIALEMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[UnityEngine.Scripting.Preserve]
internal sealed class ALJODBLMALM : FENHLJCHJGE, ANMLBOEMDKO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct MNLAEEPEOCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public AsyncTaskMethodBuilder<PLLAKKIDGFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public ALJODBLMALM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public BNELGABNKPE autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private OEEGBKAOPAE<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private LPAEAAAEHDG <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private TaskAwaiter<PLLAKKIDGFG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x8DDB2C0", Offset = "0x8DD9CC0", VA = "0x188DDB2C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x8DDBC90", Offset = "0x8DDA690", VA = "0x188DDBC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct JMFMAAOBKJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public ALJODBLMALM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private CancellationTokenSource <combinedTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x8DD3E90", Offset = "0x8DD2890", VA = "0x188DD3E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x8DD45F0", Offset = "0x8DD2FF0", VA = "0x188DD45F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct MCAAKICGOMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public ALJODBLMALM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x8DD7610", Offset = "0x8DD6010", VA = "0x188DD7610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x8DD7B20", Offset = "0x8DD6520", VA = "0x188DD7B20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct PFPHOCEPDDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public ALJODBLMALM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x8DDE070", Offset = "0x8DDCA70", VA = "0x188DDE070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x8DDE830", Offset = "0x8DDD230", VA = "0x188DDE830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct NIPDGHLLKDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public ALJODBLMALM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x8DDC410", Offset = "0x8DDAE10", VA = "0x188DDC410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x8DDC5B0", Offset = "0x8DDAFB0", VA = "0x188DDC5B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct MHNDGBKBEPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public ALJODBLMALM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private CancellationToken <nextAutosaveToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x8DD9680", Offset = "0x8DD8080", VA = "0x188DD9680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x8DD9DB0", Offset = "0x8DD87B0", VA = "0x188DD9DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct PNNFOAPMCHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public ALJODBLMALM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public CancellationToken nextAutosaveToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private Task <delayTask>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x8DE00A0", Offset = "0x8DDEAA0", VA = "0x188DE00A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0510", Offset = "0x8DDEF10", VA = "0x188DE0510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct HCEJCLNHHIG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public ALJODBLMALM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public EPNIDEGAFGC autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private OEEGBKAOPAE<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x8DCE680", Offset = "0x8DCD080", VA = "0x188DCE680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x8DCEC20", Offset = "0x8DCD620", VA = "0x188DCEC20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private HJKBCKDIADL EHCDEMFECBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private CHMOOPPGDGB NGALMEDAPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private FFHNIMCCMFI ADCMGLPBECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private MGDNOIFCHIM JHJAMFNHLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private NJNCDDGFIJG PMIBAMBFHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private NPIAOHCMBCD DCODBNKMEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private CancellationTokenSource NPDNOAAILBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private Task JABCEADBOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private TaskCompletionSource<int> FIAFDMMGKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private int HFDBBKKEKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private int PKOCCOMCIIE;

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x8DC5630", Offset = "0x8DC4030", VA = "0x188DC5630", Slot = "6")]
	public void GFALNPPLGKO(CHMOOPPGDGB NGALMEDAPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x15CBEA0", Offset = "0x15CA8A0", VA = "0x1815CBEA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x8DC50C0", Offset = "0x8DC3AC0", VA = "0x188DC50C0")]
	private void CJGAJFJEGMC(float ACHJBDDGEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x8DC5DE0", Offset = "0x8DC47E0", VA = "0x188DC5DE0", Slot = "4")]
	[AsyncStateMachine(typeof(MNLAEEPEOCH))]
	public Task<PLLAKKIDGFG> NHMPPKPACEE(BNELGABNKPE MGJEEBCIHJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x8DC5440", Offset = "0x8DC3E40", VA = "0x188DC5440", Slot = "5")]
	[AsyncStateMachine(typeof(JMFMAAOBKJL))]
	public Task FBKADDOKDIN([Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x15CBEA0", Offset = "0x15CA8A0", VA = "0x1815CBEA0")]
	public void BDLBDOEGAOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x8DC58E0", Offset = "0x8DC42E0", VA = "0x188DC58E0")]
	private LPAEAAAEHDG KEEKDELHIJA(BNELGABNKPE MGJEEBCIHJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x8DC5C00", Offset = "0x8DC4600", VA = "0x188DC5C00")]
	[AsyncStateMachine(typeof(MCAAKICGOMB))]
	private Task LEKFDBHNFFL(CancellationToken ICODIHINNBH, int DIOLIHHBDCB, LHDJNPMOIOH FIGFFLDCNGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x8DC5530", Offset = "0x8DC3F30", VA = "0x188DC5530")]
	[AsyncStateMachine(typeof(PFPHOCEPDDJ))]
	private Task FPJFJPJEABB(CancellationToken ICODIHINNBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x8DC5CF0", Offset = "0x8DC46F0", VA = "0x188DC5CF0")]
	[AsyncStateMachine(typeof(NIPDGHLLKDA))]
	private Task NFIBKJHCHAG([Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x8DC5B10", Offset = "0x8DC4510", VA = "0x188DC5B10")]
	[AsyncStateMachine(typeof(MHNDGBKBEPD))]
	private Task KLLDBADAEPI(CancellationToken ICODIHINNBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x8DC57E0", Offset = "0x8DC41E0", VA = "0x188DC57E0")]
	[AsyncStateMachine(typeof(PNNFOAPMCHP))]
	private Task GGFACEONMCO(CancellationToken LOKLDCEDGBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x8DC51A0", Offset = "0x8DC3BA0", VA = "0x188DC51A0")]
	private Task DJAICBMHCHJ(EPNIDEGAFGC LDBMMHGJBOG, CancellationToken ICODIHINNBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x8DC5330", Offset = "0x8DC3D30", VA = "0x188DC5330")]
	[AsyncStateMachine(typeof(HCEJCLNHHIG))]
	private Task FBEGGLCNPCG(EPNIDEGAFGC LDBMMHGJBOG, CancellationToken ICODIHINNBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x8DC5F10", Offset = "0x8DC4910", VA = "0x188DC5F10")]
	private bool ODFMDKNPNML()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public ALJODBLMALM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[UnityEngine.Scripting.Preserve]
internal class BIHGLJIEHJP : PLEFOEBMOOP, ANMLBOEMDKO, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct BOCNMINCIFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public BIHGLJIEHJP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private OEEGBKAOPAE<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x8DC85C0", Offset = "0x8DC6FC0", VA = "0x188DC85C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x8DC8B80", Offset = "0x8DC7580", VA = "0x188DC8B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000390")]
	private ICCMCAOCNJP CKKGCEBLKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000391")]
	private CHMOOPPGDGB NGALMEDAPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000392")]
	private ABAEFDCOKIJ NHINLCDNNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	private MGDNOIFCHIM JHJAMFNHLPL;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x8DC75E0", Offset = "0x8DC5FE0", VA = "0x188DC75E0", Slot = "6")]
	public void GFALNPPLGKO(CHMOOPPGDGB NGALMEDAPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x8DC7590", Offset = "0x8DC5F90", VA = "0x188DC7590", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x8DC78C0", Offset = "0x8DC62C0", VA = "0x188DC78C0", Slot = "5")]
	[AsyncStateMachine(typeof(BOCNMINCIFF))]
	public Task GKAIHLJAJKG(string HEEMGKHJLID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x8DC79C0", Offset = "0x8DC63C0", VA = "0x188DC79C0", Slot = "4")]
	public PLLAKKIDGFG ODFMDKNPNML(FNAEIBBBBBE OHCMPLALIOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x8DC7450", Offset = "0x8DC5E50", VA = "0x188DC7450")]
	private AGCLJCJMCPJ AAGBDDKIDNG(string HEEMGKHJLID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public BIHGLJIEHJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public static class AIINGLHIMBC
{
	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x8DC47D0", Offset = "0x8DC31D0", VA = "0x188DC47D0")]
	public static void BKLHMMHNIAC(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x8DC4A10", Offset = "0x8DC3410", VA = "0x188DC4A10")]
	internal static void DPLILCLFMKI(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x8DC46F0", Offset = "0x8DC30F0", VA = "0x188DC46F0")]
	internal static void BJEAEAIFAKN(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x8DC4B70", Offset = "0x8DC3570", VA = "0x188DC4B70")]
	internal static void NPDCFBCCOIJ(JBJKIIKOACK KLIEGJHNGPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x32D7860", Offset = "0x32D6260", VA = "0x1832D7860")]
	private static void FJCANCGGLDC<Interface, Impl, Interface>(JBJKIIKOACK KLIEGJHNGPK) where Impl : Interface
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
internal class OBPGIDMCMPL : JMCCJOGOEKB<BDHPLICAJHI>
{
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private sealed class NCFAPLCFKEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public BDHPLICAJHI message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public NCFAPLCFKEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x8DDBD00", Offset = "0x8DDA700", VA = "0x188DDBD00")]
		internal object PHEAKLOPILA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly OBPGIDMCMPL FLGHCDNLMND;

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x8DDC910", Offset = "0x8DDB310", VA = "0x188DDC910")]
	public ExitGames.Client.Photon.Hashtable GCGCKFHBJPB(BDHPLICAJHI JEBOHIALEMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x8DDCF80", Offset = "0x8DDB980", VA = "0x188DDCF80", Slot = "5")]
	protected override void PDPCLFOAAJF(BDHPLICAJHI JEBOHIALEMJ, IDictionary<object, object> BLPDDGCLNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x8DDCD50", Offset = "0x8DDB750", VA = "0x188DDCD50", Slot = "6")]
	public override BDHPLICAJHI LEOAOCFGODA(IDictionary<object, object> BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x8DDC9A0", Offset = "0x8DDB3A0", VA = "0x188DDC9A0")]
	private static void JAPFEIFECJM(string EHMBLGMCOEL, BDHPLICAJHI JEBOHIALEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x8DDD150", Offset = "0x8DDBB50", VA = "0x188DDD150")]
	public OBPGIDMCMPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x8DDCAB0", Offset = "0x8DDB4B0", VA = "0x188DDCAB0")]
	[CompilerGenerated]
	internal static string KABGCHDJIAM(CCNAABFFCED IHHGLEDNONA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public static class IKMPFFOFFOK
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public static PLLAKKIDGFG ANDPHKADADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x8DD1420", Offset = "0x8DCFE20", VA = "0x188DD1420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x8DD1940", Offset = "0x8DD0340", VA = "0x188DD1940")]
	public static bool PMFAKGPFNMG(this PLLAKKIDGFG JHOGHDKBLCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x8DD1680", Offset = "0x8DD0080", VA = "0x188DD1680")]
	public static PLLAKKIDGFG KPKAPBJBJBL(CAIEKIDAKIA APBMLPKMHGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x8DD1480", Offset = "0x8DCFE80", VA = "0x188DD1480")]
	public static PLLAKKIDGFG GNKFBDJGDND(IEnumerable<PLLAKKIDGFG> FNIMFMKKHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x8DD16E0", Offset = "0x8DD00E0", VA = "0x188DD16E0")]
	public static string LJMGHDHIIHF(this PLLAKKIDGFG GGIKEMCHAAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public abstract class CENIPDCJBKB : NPHEDJBDAGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public delegate PLLAKKIDGFG BIMLPAKOPON([NotNull] FNAEIBBBBBE LFGCONENJAL);

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class KGPJNOPAIND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public FNAEIBBBBBE photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public KGPJNOPAIND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x188D0C0", Offset = "0x188BAC0", VA = "0x18188D0C0")]
		internal PLLAKKIDGFG JHLPMLJNAMK(BIMLPAKOPON v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	private bool JPNPFIIDGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	protected readonly HashSet<BIMLPAKOPON> PKHPDDFIHHK;

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x8DC8F30", Offset = "0x8DC7930", VA = "0x188DC8F30", Slot = "4")]
	public void PFMILKDGBFI(BIMLPAKOPON FLEMCBFBGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x8DC8ED0", Offset = "0x8DC78D0", VA = "0x188DC8ED0", Slot = "5")]
	public void GGECNKEPBKB(BIMLPAKOPON FLEMCBFBGBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x8DC8E80", Offset = "0x8DC7880", VA = "0x188DC8E80", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x8DC8BE0", Offset = "0x8DC75E0", VA = "0x188DC8BE0")]
	protected PLLAKKIDGFG BPLNPLHPMKA(FNAEIBBBBBE AFLHBKMHOEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x8DC8F90", Offset = "0x8DC7990", VA = "0x188DC8F90")]
	protected CENIPDCJBKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public class HKNLBJKIGEE : CENIPDCJBKB, MFMJLFCOBPH, NPHEDJBDAGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private sealed class IKBLIPOCNOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public PLLAKKIDGFG result;

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public IKBLIPOCNOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x8DD1000", Offset = "0x8DCFA00", VA = "0x188DD1000")]
		internal object PBHNONOBCEG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x8DC50B0", Offset = "0x8DC3AB0", VA = "0x188DC50B0")]
	[UnityEngine.Scripting.Preserve]
	public HKNLBJKIGEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x8DD0560", Offset = "0x8DCEF60", VA = "0x188DD0560", Slot = "8")]
	public PLLAKKIDGFG IJOIIONJNEJ(FNAEIBBBBBE AFLHBKMHOEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public class ALEDEAAODCM : CENIPDCJBKB, ICCMCAOCNJP, NPHEDJBDAGD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class BIFCHBPMIHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public PLLAKKIDGFG result;

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public BIFCHBPMIHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x8DC73F0", Offset = "0x8DC5DF0", VA = "0x188DC73F0")]
		internal object FAHKDGOLJPE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x8DC50B0", Offset = "0x8DC3AB0", VA = "0x188DC50B0")]
	[UnityEngine.Scripting.Preserve]
	public ALEDEAAODCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x8DC4FA0", Offset = "0x8DC39A0", VA = "0x188DC4FA0", Slot = "8")]
	public PLLAKKIDGFG ODFMDKNPNML(FNAEIBBBBBE NBPOBGMPFAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal static class HILEJAMFHOM
{
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private sealed class NFNAMEENABE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public OEEGBKAOPAE<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public NFNAMEENABE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x8DDC390", Offset = "0x8DDAD90", VA = "0x188DDC390")]
		internal object IEDBFNGNHGL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x8DCFF90", Offset = "0x8DCE990", VA = "0x188DCFF90")]
	public static OEEGBKAOPAE<string> GDAMPMJIKJM(OLFEOKKCIEG JHGFKLHHPJD, [Optional] string KMAGHMJNLBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x8DCFED0", Offset = "0x8DCE8D0", VA = "0x188DCFED0")]
	public static void EOFCNNMECGA(OEEGBKAOPAE<string> KIGHMIAOFFO, OLFEOKKCIEG JHGFKLHHPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x8DCFE10", Offset = "0x8DCE810", VA = "0x188DCFE10")]
	public static string AIFDAOIFKGG(BDHPLICAJHI JLJGLLPFINF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal static class BMCJGENNANE
{
	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x8DC8490", Offset = "0x8DC6E90", VA = "0x188DC8490")]
	public static void CLBJNHIAPHE(this HJKBCKDIADL EHCDEMFECBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x8DC8480", Offset = "0x8DC6E80", VA = "0x188DC8480")]
	public static void CBCLGCDOKDH(this HJKBCKDIADL EHCDEMFECBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x8DC84A0", Offset = "0x8DC6EA0", VA = "0x188DC84A0")]
	private static void ENDLJDKKIFH(this HJKBCKDIADL EHCDEMFECBB, bool BLCDBKPBOCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public class BAGFCDAKOOE : DJNKJPOENBH, GKOBHHCNMBJ, CKHBACPBGOP, MJINEADEAIK
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[DefaultMember("Item")]
	private class DELNCFGKCJN : PJCAKALKNLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private readonly byte DDFEAKLIDDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly int FPJMIEGHFGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private readonly object BFMNMHCENOF;

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public byte CGKLPFAGDGF
		{
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xAFB540", Offset = "0xAF9F40", VA = "0x180AFB540", Slot = "4")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public int HFGLGEFIHFD
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xBAD7D0", Offset = "0xBAC1D0", VA = "0x180BAD7D0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public object LIKGFPBPMOP
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public object PCCJLFHFGOC
		{
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0x8DC9290", Offset = "0x8DC7C90", VA = "0x188DC9290", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x7E903A0", Offset = "0x7E8EDA0", VA = "0x187E903A0")]
		public DELNCFGKCJN(byte DDFEAKLIDDG, int FPJMIEGHFGE, object BFMNMHCENOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x8DC9240", Offset = "0x8DC7C40", VA = "0x188DC9240", Slot = "8")]
		public bool BMFHANOLGIO(byte HPFHOBCPNEF, [Out] object KMAFNKGMDCF)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	private readonly GKOBHHCNMBJ IDAMJHNJLAN;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public FNAEIBBBBBE OPIAAKOABFN
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x8DC6A80", Offset = "0x8DC5480", VA = "0x188DC6A80", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int LJPALJGINMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x8DC6BB0", Offset = "0x8DC55B0", VA = "0x188DC6BB0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public int PFDCHAAKNAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x8DC7060", Offset = "0x8DC5A60", VA = "0x188DC7060", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public FNAEIBBBBBE NLCLELPBFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x8DC6A30", Offset = "0x8DC5430", VA = "0x188DC6A30", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool DGEAHJMLCIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public int GMODFLLNLNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xC43520", Offset = "0xC41F20", VA = "0x180C43520", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public string MACMGPHDDIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x8DC7150", Offset = "0x8DC5B50", VA = "0x188DC7150", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Func<string, string> CEGLKGFBICN
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x8DC6CE0", Offset = "0x8DC56E0", VA = "0x188DC6CE0", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<string, long> IJOLGFOAPKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<PJCAKALKNLJ> AFHNFOLIALG
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x8DC7260", Offset = "0x8DC5C60", VA = "0x188DC7260", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x8DC71B0", Offset = "0x8DC5BB0", VA = "0x188DC71B0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<bool> LADHAIPPEKO
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "26")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "27")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<FNAEIBBBBBE> LBGOLLLEDMC
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event Action IDIOFBICEOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x8DC6EE0", Offset = "0x8DC58E0", VA = "0x188DC6EE0", Slot = "35")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x8DC70B0", Offset = "0x8DC5AB0", VA = "0x188DC70B0", Slot = "36")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x8DC6E80", Offset = "0x8DC5880", VA = "0x188DC6E80", Slot = "19")]
	public void LDGHDHGLOIL(string IELIBBNCJAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0xEAC300", Offset = "0xEAAD00", VA = "0x180EAC300")]
	public BAGFCDAKOOE(GKOBHHCNMBJ IDAMJHNJLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x8DC68D0", Offset = "0x8DC52D0", VA = "0x188DC68D0", Slot = "8")]
	public bool AJMCEANPHKH(byte DMJFIGMGCMF, object KNFKFJIPOBJ, LAAOOMKIIJB IAJLLBCOKMJ, DFHGKHIBBFL EDMBENGILFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x8DC6DE0", Offset = "0x8DC57E0", VA = "0x188DC6DE0", Slot = "20")]
	public FNAEIBBBBBE LBPOMOEKJJO(int AKCNDIOJIBG, bool JPNDNIPFNOO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x8DC6C00", Offset = "0x8DC5600", VA = "0x188DC6C00", Slot = "21")]
	public FNAEIBBBBBE GNGFGILOIAK(int KPCCLFNHPJC, bool JPNDNIPFNOO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x8DC6F80", Offset = "0x8DC5980", VA = "0x188DC6F80", Slot = "22")]
	public FNAEIBBBBBE NJLEKKMOKPG(int AKCNDIOJIBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x8DC6AD0", Offset = "0x8DC54D0", VA = "0x188DC6AD0", Slot = "23")]
	public IReadOnlyList<FNAEIBBBBBE> EAHLEHBCINN(bool JPNDNIPFNOO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x8DC6DA0", Offset = "0x8DC57A0", VA = "0x188DC6DA0", Slot = "24")]
	public IReadOnlyList<FNAEIBBBBBE> IKKOGALDJEA(bool JPNDNIPFNOO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "25")]
	public bool ALKOBMOMHBA(FNAEIBBBBBE NMJFGDKALHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "28")]
	public void EHJDPONIJMD(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "29")]
	public void CMGMOMFNFDA(object MFKHKDDANII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "30")]
	public void DNODEPPCNPF(object MFKHKDDANII, bool PNBIMDNKJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x8DC69E0", Offset = "0x8DC53E0", VA = "0x188DC69E0", Slot = "31")]
	public IDisposable BINDPHGNOFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "32")]
	private bool KEOIAIGPJBP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "33")]
	public void CNDFIBMNOLB(StringBuilder LCJDGNFDCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x112B450", Offset = "0x1129E50", VA = "0x18112B450", Slot = "34")]
	public bool BGLIOCCCDEJ(bool LJFCAAPEJIA, [Out] string IHPAEKNOMOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x10BC090", Offset = "0x10BAA90", VA = "0x1810BC090", Slot = "37")]
	public void EAPNOMMEECB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal struct MBBOMGNGMKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private readonly IDictionary<object, object> PPGGMEFFGDH;

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0xECC590", Offset = "0xECAF90", VA = "0x180ECC590")]
	public MBBOMGNGMKO(IDictionary<object, object> PPGGMEFFGDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x8DD7470", Offset = "0x8DD5E70", VA = "0x188DD7470")]
	public bool GIAFMLMIFPH([Out] BDHPLICAJHI JEBOHIALEMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x8DD73C0", Offset = "0x8DD5DC0", VA = "0x188DD73C0")]
	public Guid GGDNAGOHEGN()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x8DD7280", Offset = "0x8DD5C80", VA = "0x188DD7280")]
	public PLLAKKIDGFG DHLDPIKHPPM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x8DD7520", Offset = "0x8DD5F20", VA = "0x188DD7520")]
	public static ExitGames.Client.Photon.Hashtable MLAHKGEEKLJ(BDHPLICAJHI JEBOHIALEMJ, PLLAKKIDGFG JHOGHDKBLCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal static class LJKLOFGBJCP
{
	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x8DD5FE0", Offset = "0x8DD49E0", VA = "0x188DD5FE0")]
	public static bool AENOLENBODL(this IAOKBCEAMNP EOJGKDJALHE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
internal struct EHOMLENHKML : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct NJOMNFMHPAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public Func<CancellationToken, List<Task>> taskGenerator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public EHOMLENHKML <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x8DDC610", Offset = "0x8DDB010", VA = "0x188DDC610", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x8DDC7F0", Offset = "0x8DDB1F0", VA = "0x188DDC7F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private readonly CancellationTokenSource CFDOKKENJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private bool JPNPFIIDGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private Task FLAIIHBKGBI;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool OEBGFPNJFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x8DCA0F0", Offset = "0x8DC8AF0", VA = "0x188DCA0F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x8DCA120", Offset = "0x8DC8B20", VA = "0x188DCA120")]
	public EHOMLENHKML(CancellationToken AHOMALKMHKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x8DC9FE0", Offset = "0x8DC89E0", VA = "0x188DC9FE0")]
	[AsyncStateMachine(typeof(NJOMNFMHPAD))]
	public Task EJIJLBAJPGI(Func<CancellationToken, List<Task>> CLAMIFAODHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x8DC9F90", Offset = "0x8DC8990", VA = "0x188DC9F90", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public readonly struct CGNFBJLEKOC<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private struct GKPCAAIGEBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public AsyncTaskMethodBuilder<FEENKEDBOAD<FKPMICMHLMH<TData>, EFLAGBIEFMN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public CGNFBJLEKOC<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private TaskAwaiter<FEENKEDBOAD<FKPMICMHLMH<TData>, EFLAGBIEFMN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x51329D0", Offset = "0x51313D0", VA = "0x1851329D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x4B35850", Offset = "0x4B34250", VA = "0x184B35850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	private readonly LLIIMJFACFH<TGetDataArg, TData> KLALHCJBOKG;

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0xECC590", Offset = "0xECAF90", VA = "0x180ECC590")]
	internal CGNFBJLEKOC(LLIIMJFACFH<TGetDataArg, TData> KPEJCAGFLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x6CDDB40", Offset = "0x6CDC540", VA = "0x186CDDB40")]
	[AsyncStateMachine(typeof(CGNFBJLEKOC<, >.GKPCAAIGEBH))]
	public Task<FEENKEDBOAD<FKPMICMHLMH<TData>, EFLAGBIEFMN>> AOCBOMLFGNK(TGetDataArg MFHBGCBJCJO, string HLOICBDDFIL, OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO, CancellationToken AHOMALKMHKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public static class OPOBOACPINH
{
	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x3BD8C70", Offset = "0x3BD7670", VA = "0x183BD8C70")]
	public static CGNFBJLEKOC<TGetDataArg, TData> KDBDJPAJKDJ<TGetDataArg, TData>(LLIIMJFACFH<TGetDataArg, TData> KPEJCAGFLDG)
	{
		return default(CGNFBJLEKOC<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public struct IPMMGHJONLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public readonly int CGKLPFAGDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public readonly int? MFMGJMDAFCF;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x56EED80", Offset = "0x56ED780", VA = "0x1856EED80")]
	public IPMMGHJONLE(int DDFEAKLIDDG, [Optional] int? LOOEBOOINAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x8DD1960", Offset = "0x8DD0360", VA = "0x188DD1960", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface DPJPILNNPMM<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BHGOCFAFPGK();

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "1")]
	DPJPILNNPMM<T> KDBODHALBKG(string FGBHJMCGLMA);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DPJPILNNPMM<T> NJMIIMGOODD(BBCIKPPCPIL<T> OBOMJEFHNOP);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DPJPILNNPMM<T> ADPNCLFDION(int NGDAMNDJLIJ);

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "4")]
	DPJPILNNPMM<T> KLDKIFLFNLD(int NGDAMNDJLIJ, ECOMBOAPGCL<T> GFNLJAJCAJB);
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public interface AOJPAFPLIGN
{
	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DPJPILNNPMM<T> KNOJCLIGJMB<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IJBKDNAIHDN AJAHOKMLKIE(Exception JOEMCJLBOIG);

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IPMMGHJONLE FIKNNPPCHCJ(Exception JOEMCJLBOIG);
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public delegate string BBCIKPPCPIL<in T>(T JOEMCJLBOIG) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public delegate int ECOMBOAPGCL<in T>(T JOEMCJLBOIG) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class PKCCKPELGKL : AOJPAFPLIGN
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private delegate string HGJIMDAPAOG(Exception JOEMCJLBOIG);

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private delegate int KIAOLKFPOEL(Exception JOEMCJLBOIG);

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	private class KAADHMJEPBC<T> : DPJPILNNPMM<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		[CompilerGenerated]
		private sealed class JBIBFHMODEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public JBIBFHMODEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			internal string KJOPNEJBEKI(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000103")]
		[CompilerGenerated]
		private sealed class KDDPNMGAHKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public BBCIKPPCPIL<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public KDDPNMGAHKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x5537720", Offset = "0x5536120", VA = "0x185537720")]
			internal string DMKNFIIGIDL(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000104")]
		[CompilerGenerated]
		private sealed class JFOGPIDEHBD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public ECOMBOAPGCL<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public JFOGPIDEHBD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x5537720", Offset = "0x5536120", VA = "0x185537720")]
			internal int MCFOCDMIEHI(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private readonly PKCCKPELGKL POABMPEJDBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private readonly Type DAMCCAPFIBA;

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x5634120", Offset = "0x5632B20", VA = "0x185634120")]
		internal KAADHMJEPBC(PKCCKPELGKL POABMPEJDBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x5633DB0", Offset = "0x56327B0", VA = "0x185633DB0", Slot = "4")]
		public void BHGOCFAFPGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x5633DE0", Offset = "0x56327E0", VA = "0x185633DE0", Slot = "5")]
		public DPJPILNNPMM<T> KDBODHALBKG(string FGBHJMCGLMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x5634010", Offset = "0x5632A10", VA = "0x185634010", Slot = "6")]
		public DPJPILNNPMM<T> NJMIIMGOODD(BBCIKPPCPIL<T> OBOMJEFHNOP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x5633D70", Offset = "0x5632770", VA = "0x185633D70", Slot = "7")]
		public DPJPILNNPMM<T> ADPNCLFDION(int NGDAMNDJLIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x5633EF0", Offset = "0x56328F0", VA = "0x185633EF0", Slot = "8")]
		public DPJPILNNPMM<T> KLDKIFLFNLD(int NGDAMNDJLIJ, ECOMBOAPGCL<T> GFNLJAJCAJB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	private class LNGPKMFMGGM<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private bool LCKHLHFDODA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private readonly List<Type> BMDABOAKMAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private readonly Dictionary<Type, TVal> CGPKLINALIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private readonly Dictionary<Type, int> NFOOJJMNJID;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public IReadOnlyList<Type> MMLJPALOMNC
		{
			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x5746D20", Offset = "0x5745720", VA = "0x185746D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x5746F20", Offset = "0x5745920", VA = "0x185746F20")]
		public LNGPKMFMGGM(Dictionary<Type, int> NFOOJJMNJID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x5746E80", Offset = "0x5745880", VA = "0x185746E80")]
		public void HMDNMGBNKIA(Type HPFHOBCPNEF, TVal MKDEBCJNKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x5746C20", Offset = "0x5745620", VA = "0x185746C20")]
		public bool EIDGKKFGELF(Type DAMCCAPFIBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x5746BE0", Offset = "0x57455E0", VA = "0x185746BE0")]
		public bool CMCJLINPDGM(TVal KMAFNKGMDCF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x46909E0", Offset = "0x468F3E0", VA = "0x1846909E0")]
		public TVal GFFPJLNAMHB(Type DGNODDPLLPC)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x5746AA0", Offset = "0x57454A0", VA = "0x185746AA0")]
		[CompilerGenerated]
		private int BCLOLCBHLPC(Type FDNPIBLKDFO, Type DLNIPKBJDLA)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class LMCPPCDICNL : IEnumerable<IPMMGHJONLE>, IEnumerable, IEnumerator<IPMMGHJONLE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private IPMMGHJONLE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public PKCCKPELGKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public Exception <>3__ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private IEnumerator<Exception> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private IEnumerator<IPMMGHJONLE> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		private IPMMGHJONLE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x19F0920", Offset = "0x19EF320", VA = "0x1819F0920", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(IPMMGHJONLE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x8DD66C0", Offset = "0x8DD50C0", VA = "0x188DD66C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0xBE39C0", Offset = "0xBE23C0", VA = "0x180BE39C0")]
		[DebuggerHidden]
		public LMCPPCDICNL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x8DD6710", Offset = "0x8DD5110", VA = "0x188DD6710", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x8DD60B0", Offset = "0x8DD4AB0", VA = "0x188DD60B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x8DD6060", Offset = "0x8DD4A60", VA = "0x188DD6060")]
		private void LLDKJPCFHKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x8DD6560", Offset = "0x8DD4F60", VA = "0x188DD6560")]
		private void OCOHJFDHCPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x8DD6670", Offset = "0x8DD5070", VA = "0x188DD6670", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x8DD65B0", Offset = "0x8DD4FB0", VA = "0x188DD65B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<IPMMGHJONLE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x8DD65B0", Offset = "0x8DD4FB0", VA = "0x188DD65B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private static readonly IPMMGHJONLE DPKKCLFCBBM;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	private static readonly Dictionary<Type, int> KEBDEFBIAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private readonly HashSet<Type> EJKOILJLFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	private readonly LNGPKMFMGGM<int> ANJFMEFAGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	private readonly LNGPKMFMGGM<KIAOLKFPOEL> FJIHLEMGBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	private readonly LNGPKMFMGGM<HGJIMDAPAOG> PIKCMMGNBPO;

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x8DDF1E0", Offset = "0x8DDDBE0", VA = "0x188DDF1E0")]
	[DMKNBLIJJON.EGFDFBOLNDK.IOMGPCDPIJG]
	internal static void HFPMPAAENFC(JBJKIIKOACK ALFOGEOKGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x8DDFC90", Offset = "0x8DDE690", VA = "0x188DDFC90")]
	[RecRoom.NoEngine.Common.Preserve]
	public PKCCKPELGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x32D1CC0", Offset = "0x32D06C0", VA = "0x1832D1CC0", Slot = "4")]
	public DPJPILNNPMM<T> KNOJCLIGJMB<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x8DDEC40", Offset = "0x8DDD640", VA = "0x188DDEC40", Slot = "5")]
	public IJBKDNAIHDN AJAHOKMLKIE(Exception JOEMCJLBOIG)
	{
		return default(IJBKDNAIHDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x8DDECD0", Offset = "0x8DDD6D0", VA = "0x188DDECD0", Slot = "6")]
	public IPMMGHJONLE FIKNNPPCHCJ(Exception? JOEMCJLBOIG)
	{
		return default(IPMMGHJONLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x8DDF8D0", Offset = "0x8DDE2D0", VA = "0x188DDF8D0", Slot = "7")]
	[IteratorStateMachine(typeof(LMCPPCDICNL))]
	public IEnumerable<IPMMGHJONLE> ODPOOFOAKEN(Exception JOEMCJLBOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x8DDF780", Offset = "0x8DDE180", VA = "0x188DDF780", Slot = "8")]
	public string NMAKFHACIMA(Exception? JOEMCJLBOIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x8DDEED0", Offset = "0x8DDD8D0", VA = "0x188DDEED0")]
	private string GPLFFHBPDDB(AggregateException HACKFKNJPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x8DDE890", Offset = "0x8DDD290", VA = "0x188DDE890")]
	private void ABGFOFAKFCE(Type DAMCCAPFIBA, int NGDAMNDJLIJ, KIAOLKFPOEL? GLPCOLCGFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x8DDF970", Offset = "0x8DDE370", VA = "0x188DDF970")]
	private void OHGIFNMAKMK(Type DAMCCAPFIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x8DDF4B0", Offset = "0x8DDDEB0", VA = "0x188DDF4B0")]
	private void MLBLLNPJGBP(Type DAMCCAPFIBA, HGJIMDAPAOG BIKIGCBJJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x8DDF250", Offset = "0x8DDDC50", VA = "0x188DDF250")]
	private static int JLKBENNLFLC(Type DAMCCAPFIBA, Dictionary<Type, int> NFOOJJMNJID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x3F6EEF0", Offset = "0x3F6D8F0", VA = "0x183F6EEF0")]
	private static bool DPOKDDLBCIP<TVal>(LNGPKMFMGGM<TVal> FDOLNIMJMJM, Type DAMCCAPFIBA, [Out] TVal KMAFNKGMDCF) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x8DDF3D0", Offset = "0x8DDDDD0", VA = "0x188DDF3D0")]
	[CompilerGenerated]
	internal static int LCPKLGBAHFD(Type DBMNAJLECLK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public struct IJBKDNAIHDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public readonly IPMMGHJONLE IHAEEELDGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public readonly string ALGAHCMMONL;

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x8DD0FE0", Offset = "0x8DCF9E0", VA = "0x188DD0FE0")]
	public IJBKDNAIHDN(string AOEKIPCGEJI, IPMMGHJONLE NGDAMNDJLIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x8DD0F40", Offset = "0x8DCF940", VA = "0x188DD0F40")]
	public string BIJONKPDHFO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public class MICBNHDLKLK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	private readonly CNGDCLJNIFB BFIOAIOKKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	private string GBOOIHLGCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	private long? LJOMNPMELIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	private long? EEAEKCJOBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	private long? NMAECPLCPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	private string KDGEJBLAPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private IBJAHKDFDAH FCHMAJPDOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private long? DCMKGFDBGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	private bool NILHDOMPPKF;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public string GLEFLAHJPKK
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public long HIPMFHIGMBF
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x8DD9E10", Offset = "0x8DD8810", VA = "0x188DD9E10")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public long EJMIMDHJPCH
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x8DDA3F0", Offset = "0x8DD8DF0", VA = "0x188DDA3F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public long FJLCLPNLJDO
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x8DDA980", Offset = "0x8DD9380", VA = "0x188DDA980")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public string DMIOJGFOJAI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x8DDA8C0", Offset = "0x8DD92C0", VA = "0x188DDA8C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public IBJAHKDFDAH AAFNDKLNGCA
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xC57850", Offset = "0xC56250", VA = "0x180C57850")]
		get
		{
			return default(IBJAHKDFDAH);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x8DDA300", Offset = "0x8DD8D00", VA = "0x188DDA300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public long GDPCCPGEBAB
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x8DDA4F0", Offset = "0x8DD8EF0", VA = "0x188DDA4F0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x8DDAC30", Offset = "0x8DD9630", VA = "0x188DDAC30")]
	[UnityEngine.Scripting.Preserve]
	public MICBNHDLKLK([BMCONCJPCIA(null)] CNGDCLJNIFB BFIOAIOKKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x8DDA9E0", Offset = "0x8DD93E0", VA = "0x188DDA9E0")]
	private void PPMBPHPHGKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x8DD9E70", Offset = "0x8DD8870", VA = "0x188DD9E70")]
	public void ANDJKPJAOMC(long GDCAPMONNDM, long GKOJBHIBFEI, [Optional] long? AFCPIMKFDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x8DDA450", Offset = "0x8DD8E50", VA = "0x188DDA450")]
	public void ILPKBNJHIIH(long AFCPIMKFDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x8DDA900", Offset = "0x8DD9300", VA = "0x188DDA900")]
	public void NFECENAJHHN(string KMOEKFEJPHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x8DDA550", Offset = "0x8DD8F50", VA = "0x188DDA550")]
	public void LICHNEPJBIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
internal class GPFLGLGCINI : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct JMDMIFLGLBJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public AsyncTaskMethodBuilder<BDHPLICAJHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public BDHPLICAJHI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public GPFLGLGCINI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private TaskAwaiter<BGJPDHDKIOB.EAMLGPEMDBE<BDHPLICAJHI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x8DD38E0", Offset = "0x8DD22E0", VA = "0x188DD38E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x8DD3E20", Offset = "0x8DD2820", VA = "0x188DD3E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct ACOICHJGOCP<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class BBICPJJPPOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public BDHPLICAJHI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public BBICPJJPPOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x8DC7310", Offset = "0x8DC5D10", VA = "0x188DC7310")]
		internal BDHPLICAJHI JNIDJEBBHKL(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct IGGPIJDGGFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public AsyncTaskMethodBuilder<BGJPDHDKIOB.EAMLGPEMDBE<BDHPLICAJHI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public BDHPLICAJHI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public GPFLGLGCINI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private ACGHAABHPJL <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private TaskAwaiter<BGJPDHDKIOB.EAMLGPEMDBE<BDHPLICAJHI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x8DD08C0", Offset = "0x8DCF2C0", VA = "0x188DD08C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x8DD0ED0", Offset = "0x8DCF8D0", VA = "0x188DD0ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct NDHKMLHEPBJ<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public GPFLGLGCINI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public Func<CancellationToken, Task<T>> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x5A48020", Offset = "0x5A46A20", VA = "0x185A48020", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x4B35850", Offset = "0x4B34250", VA = "0x184B35850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct NEABOHCFKCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public GPFLGLGCINI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public Func<CancellationToken, Task> masterLockedCodeBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public int maxAttempts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x8DDC050", Offset = "0x8DDAA50", VA = "0x188DDC050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x8DDC330", Offset = "0x8DDAD30", VA = "0x188DDC330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class IFNGNJEKPFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public IFNGNJEKPFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x8DD07A0", Offset = "0x8DCF1A0", VA = "0x188DD07A0")]
		internal object CKIFGAPCJPO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x8DD0800", Offset = "0x8DCF200", VA = "0x188DD0800")]
		internal bool HIEINBBLPBN(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class FEGOGENOJOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public FEGOGENOJOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x8DCA8E0", Offset = "0x8DC92E0", VA = "0x188DCA8E0")]
		internal object DNCCJALKDKB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class EOJFAHGBABI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public EOJFAHGBABI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x8DCA250", Offset = "0x8DC8C50", VA = "0x188DCA250")]
		internal object GPJCHAJLLEP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private sealed class PLCGNOCBPED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public PLCGNOCBPED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0030", Offset = "0x8DDEA30", VA = "0x188DE0030")]
		internal object EEFDDHFHCLO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class HDMJJFLPCGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public GPFLGLGCINI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public HDMJJFLPCGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x8DCEC80", Offset = "0x8DCD680", VA = "0x188DCEC80")]
		internal object PHEAKLOPILA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	private static readonly Guid ICKMOJHICLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public readonly ECHHAJDKEIH LBLJJNDELGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	private readonly BGJPDHDKIOB MBIJANEPMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	private readonly CKHBACPBGOP EHCDEMFECBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	private readonly MJINEADEAIK OOKCDMBCOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	private bool AILPHGONBJA;

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x8DCCFB0", Offset = "0x8DCB9B0", VA = "0x188DCCFB0")]
	public GPFLGLGCINI(ECHHAJDKEIH BEINHMMJKLL, BGJPDHDKIOB MBIJANEPMGM, CKHBACPBGOP EHCDEMFECBB, MJINEADEAIK OOKCDMBCOHH, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x8DCBF90", Offset = "0x8DCA990", VA = "0x188DCBF90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x8DCC450", Offset = "0x8DCAE50", VA = "0x188DCC450")]
	public void JHHBECOKFHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x8DCCBA0", Offset = "0x8DCB5A0", VA = "0x188DCCBA0")]
	public void OBLEKEBADAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x8DCC230", Offset = "0x8DCAC30", VA = "0x188DCC230")]
	public void GCNIKBJBDCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x8DCCA40", Offset = "0x8DCB440", VA = "0x188DCCA40")]
	[AsyncStateMachine(typeof(JMDMIFLGLBJ))]
	internal Task<BDHPLICAJHI> NMBJAPHPIBL(OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, BDHPLICAJHI JLJGLLPFINF, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x3DBAB70", Offset = "0x3DB9570", VA = "0x183DBAB70")]
	private static byte[] BKHOEALIGNE<T>(T JEBOHIALEMJ) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x3DBAE00", Offset = "0x3DB9800", VA = "0x183DBAE00")]
	private static T GJONPHAFKKE<T>(MessageParser<T> NMNKOOLBDMM, byte[] JEBOHIALEMJ, T PIDIALJEEHM) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x8DCC880", Offset = "0x8DCB280", VA = "0x188DCC880")]
	[AsyncStateMachine(typeof(IGGPIJDGGFA))]
	private Task<BGJPDHDKIOB.EAMLGPEMDBE<BDHPLICAJHI>> MLIFDOKKBKP(BDHPLICAJHI JLJGLLPFINF, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x3DBAB80", Offset = "0x3DB9580", VA = "0x183DBAB80")]
	[AsyncStateMachine(typeof(NDHKMLHEPBJ<>))]
	internal Task<T> FKDEIFFOCPK<T>(CancellationToken ICODIHINNBH, Func<CancellationToken, Task<T>> HFFAAGJOCBM, int EOHFPHGJCKK = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x8DCBFA0", Offset = "0x8DCA9A0", VA = "0x188DCBFA0")]
	[AsyncStateMachine(typeof(NEABOHCFKCH))]
	internal Task FKDEIFFOCPK(CancellationToken ICODIHINNBH, Func<CancellationToken, Task> HFFAAGJOCBM, int EOHFPHGJCKK = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x8DCC9C0", Offset = "0x8DCB3C0", VA = "0x188DCC9C0")]
	public IJGANLFOGKM NGLJBAINGEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x8DCCEB0", Offset = "0x8DCB8B0", VA = "0x188DCCEB0")]
	public JEOPOFELMFB PKPKPGHECJN([Optional] GBKGIJBJPLI AKNDJHEIPCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x8DCC570", Offset = "0x8DCAF70", VA = "0x188DCC570")]
	public HEMJNFGDOOG JJFLCCCFLBC([Optional] OLFEOKKCIEG? JHGFKLHHPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x8DCC0D0", Offset = "0x8DCAAD0", VA = "0x188DCC0D0")]
	public void FLNKCIOMFMO(Func<Guid, bool> IIKAENHOLGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x8DCCDA0", Offset = "0x8DCB7A0", VA = "0x188DCCDA0")]
	public void PENELGKCHCL(Func<Guid, bool> DIBNIOPHKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x8DCBE10", Offset = "0x8DCA810", VA = "0x188DCBE10")]
	public Guid AONLINMMHDE()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x8DCC770", Offset = "0x8DCB170", VA = "0x188DCC770")]
	public void KDMIBPDMGNJ(Guid IOFOBBIMJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x8DCCC60", Offset = "0x8DCB660", VA = "0x188DCCC60")]
	public void PBINGKPMEIO(BDHPLICAJHI EOLCHPADLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x8DCC340", Offset = "0x8DCAD40", VA = "0x188DCC340")]
	public void JAPFEIFECJM(string IEKECJIEHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x3DBAF50", Offset = "0x3DB9950", VA = "0x183DBAF50")]
	private T IBOIIKBNMLA<T>(T KMAFNKGMDCF) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x8DCC2F0", Offset = "0x8DCACF0", VA = "0x188DCC2F0")]
	public void HGIPPJODAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x3DBB030", Offset = "0x3DB9A30", VA = "0x183DBB030")]
	[CompilerGenerated]
	internal static string LCEGKOGGFBJ<T>(byte[] BNICMFHPCJC, int HCJFIGIPJBN, ACOICHJGOCP<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal sealed class BKOGAAGPEEO : ECHHAJDKEIH
{
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private sealed class FELOBJIHCAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public FELOBJIHCAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x8DCA940", Offset = "0x8DC9340", VA = "0x188DCA940")]
		internal object DFKCOOJLNMK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct GGPJMDKFHNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public BKOGAAGPEEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public GPFLGLGCINI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private KNIBMCLIMEI <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private JEOPOFELMFB <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private TaskAwaiter<NAOLNCNMNOH> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x8DCAEB0", Offset = "0x8DC98B0", VA = "0x188DCAEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x8DCBDB0", Offset = "0x8DCA7B0", VA = "0x188DCBDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct MEKAKGOIDBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public BKOGAAGPEEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private TaskAwaiter<PKCMPJMLDGM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x8DD8E80", Offset = "0x8DD7880", VA = "0x188DD8E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x8DD9620", Offset = "0x8DD8020", VA = "0x188DD9620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct AGFFMEFHANM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public BKOGAAGPEEO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private TaskAwaiter<HCJPDEFNHKL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x8DC4370", Offset = "0x8DC2D70", VA = "0x188DC4370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x8DC4680", Offset = "0x8DC3080", VA = "0x188DC4680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private sealed class ADJGNDNDIOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public KNIBMCLIMEI presence;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public ADJGNDNDIOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x8DC3990", Offset = "0x8DC2390", VA = "0x188DC3990")]
		internal object NNIMKAJBGCG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	private static readonly OLFEOKKCIEG HPIJLNODOFH;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	private static readonly OLFEOKKCIEG JJPMGHICEKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400041E")]
	private readonly CCNAABFFCED PDDHENJBLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private readonly IAOKBCEAMNP MEKACEMHKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private readonly GBKGIJBJPLI AKNDJHEIPCC;

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x8DC82D0", Offset = "0x8DC6CD0", VA = "0x188DC82D0")]
	public BKOGAAGPEEO(CCNAABFFCED PDDHENJBLND, IAOKBCEAMNP MEKACEMHKMJ, Guid CHBBGPKOFFN, CHMOOPPGDGB NGALMEDAPGH, BEOKCNIMCAK NMPPILJOIAL, GBKGIJBJPLI AKNDJHEIPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x8DC7DD0", Offset = "0x8DC67D0", VA = "0x188DC7DD0", Slot = "7")]
	[AsyncStateMachine(typeof(GGPJMDKFHNJ))]
	protected override Task DKDECAHIBCN(GPFLGLGCINI FGJGFPOECJN, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x8DC80F0", Offset = "0x8DC6AF0", VA = "0x188DC80F0")]
	[AsyncStateMachine(typeof(MEKAKGOIDBK))]
	private Task ODHCBEIBCMB(CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x8DC7CC0", Offset = "0x8DC66C0", VA = "0x188DC7CC0")]
	[AsyncStateMachine(typeof(AGFFMEFHANM))]
	private Task<int> BEAPGEJLGON(CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x8DC7F20", Offset = "0x8DC6920", VA = "0x188DC7F20")]
	private KNIBMCLIMEI JLLIBKLKAJG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal class LPAEAAAEHDG : ECHHAJDKEIH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct LCJIPNPGHJF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public LPAEAAAEHDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public GPFLGLGCINI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private TaskAwaiter<PPJEADMNHEK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x8DD5150", Offset = "0x8DD3B50", VA = "0x188DD5150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x8DD5B00", Offset = "0x8DD4500", VA = "0x188DD5B00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private readonly int IFGPKKOGJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private readonly BNELGABNKPE PCGILFJIDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public readonly long JELONAFLPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public readonly long EFIPIABEEKP;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public PPJEADMNHEK BDHPBHIMBCB
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xAB7B50", Offset = "0xAB6550", VA = "0x180AB7B50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xAB7AD0", Offset = "0xAB64D0", VA = "0x180AB7AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x8DD7150", Offset = "0x8DD5B50", VA = "0x188DD7150")]
	public LPAEAAAEHDG(Guid CHBBGPKOFFN, CHMOOPPGDGB NGALMEDAPGH, BEOKCNIMCAK NMPPILJOIAL, int IFGPKKOGJAJ, BNELGABNKPE PCGILFJIDOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x8DD7030", Offset = "0x8DD5A30", VA = "0x188DD7030", Slot = "7")]
	[AsyncStateMachine(typeof(LCJIPNPGHJF))]
	protected override Task DKDECAHIBCN(GPFLGLGCINI FGJGFPOECJN, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal abstract class LINJCMIINCB : ECHHAJDKEIH
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private sealed class PAIMDCBCNEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public LINJCMIINCB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public IIKFOIDDMBB playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public PAIMDCBCNEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x8DDD380", Offset = "0x8DDBD80", VA = "0x188DDD380")]
		internal Task FDGIFHCOLPJ(OEEGBKAOPAE<string>.BANCHJBJHFK postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x8DDD3C0", Offset = "0x8DDBDC0", VA = "0x188DDD3C0")]
		internal object NGOBOJMKHEJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct PDBMGLAGKAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public LINJCMIINCB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public GPFLGLGCINI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private PAIMDCBCNEM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private object <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x8DDD450", Offset = "0x8DDBE50", VA = "0x188DDD450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x8DDDDB0", Offset = "0x8DDC7B0", VA = "0x188DDDDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct AOLLCIPEDMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public IIKFOIDDMBB playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public LINJCMIINCB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x8DC6190", Offset = "0x8DC4B90", VA = "0x188DC6190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x8DC6750", Offset = "0x8DC5150", VA = "0x188DC6750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x8DD5F90", Offset = "0x8DD4990", VA = "0x188DD5F90")]
	public LINJCMIINCB(Guid CHBBGPKOFFN, CHMOOPPGDGB NGALMEDAPGH, BEOKCNIMCAK NMPPILJOIAL, string DCKLCAPPGOC, LMKGBJJKKKO JCECGKAIEFB, bool BJOPDNNOJPG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x8DD5CA0", Offset = "0x8DD46A0", VA = "0x188DD5CA0", Slot = "7")]
	[AsyncStateMachine(typeof(PDBMGLAGKAK))]
	protected override Task DKDECAHIBCN(GPFLGLGCINI FGJGFPOECJN, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task NNIECHDIIOH(GPFLGLGCINI FGJGFPOECJN, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x8DD5DE0", Offset = "0x8DD47E0", VA = "0x188DD5DE0")]
	[AsyncStateMachine(typeof(AOLLCIPEDMP))]
	private Task HFOAKLDACMJ(IDisposable OPGHNNOJEBB, IIKFOIDDMBB KHGIOFJPBHJ, OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal class BIKOGDHCDHN : ECHHAJDKEIH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct MJEFPMDLJJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public BIKOGDHCDHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public GPFLGLGCINI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private TaskAwaiter<DFPILBGDMFF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x8DDAC70", Offset = "0x8DD9670", VA = "0x188DDAC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x8DDB260", Offset = "0x8DD9C60", VA = "0x188DDB260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400045C")]
	private readonly EPNIDEGAFGC LDBMMHGJBOG;

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x8DC7C20", Offset = "0x8DC6620", VA = "0x188DC7C20")]
	public BIKOGDHCDHN(Guid CHBBGPKOFFN, CHMOOPPGDGB NGALMEDAPGH, BEOKCNIMCAK NMPPILJOIAL, EPNIDEGAFGC LDBMMHGJBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x8DC7B40", Offset = "0x8DC6540", VA = "0x188DC7B40", Slot = "6")]
	protected override string JLAADLNKANE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x8DC7A20", Offset = "0x8DC6420", VA = "0x188DC7A20", Slot = "7")]
	[AsyncStateMachine(typeof(MJEFPMDLJJH))]
	protected override Task DKDECAHIBCN(GPFLGLGCINI FGJGFPOECJN, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
internal abstract class ECHHAJDKEIH : ODDEMOLBLEK
{
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	public delegate Task AFPPGGLMDCF(OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private sealed class IFFEEIJOPPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public ECHHAJDKEIH <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public IFFEEIJOPPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x8DD0670", Offset = "0x8DCF070", VA = "0x188DD0670")]
		internal Task OCBLADONBLK(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private sealed class OBFFICAGJIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public IFFEEIJOPPL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public OBFFICAGJIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x8DDC850", Offset = "0x8DDB250", VA = "0x188DDC850")]
		internal object BHBKBCOCJCK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct MCFMPAGFKIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public ECHHAJDKEIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public Func<ECHHAJDKEIH, OEEGBKAOPAE<string>.BANCHJBJHFK, GPFLGLGCINI> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private IFFEEIJOPPL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private GPFLGLGCINI <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private TaskAwaiter<BDHPLICAJHI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x8DD7B80", Offset = "0x8DD6580", VA = "0x188DD7B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x8DD8E20", Offset = "0x8DD7820", VA = "0x188DD8E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct KIIDFODAHDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public Func<CancellationToken, Task> createDriverTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public Func<CancellationToken, Task> originalTaskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private CancellationTokenSource <driverCancellationTokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private CancellationTokenSource <originalTaskCancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private Task <driverTask>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private Task <originalTask>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private TaskAwaiter<Task> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0x8DD4650", Offset = "0x8DD3050", VA = "0x188DD4650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x8DD50F0", Offset = "0x8DD3AF0", VA = "0x188DD50F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct IKFNPMGGENB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public ECHHAJDKEIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x8DD1060", Offset = "0x8DCFA60", VA = "0x188DD1060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x8DD13C0", Offset = "0x8DCFDC0", VA = "0x188DD13C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public readonly Guid KEPMKLLAMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public readonly ByteString FHKHOMINANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public readonly BEOKCNIMCAK PBKPEMFFPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	protected readonly string DHMMGHFMKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	private readonly CHMOOPPGDGB NGALMEDAPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private readonly bool BJOPDNNOJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private readonly Queue<AFPPGGLMDCF> BFGONLIEKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private readonly MEILIGBJNHJ CEHLMJEBGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	private readonly LMKGBJJKKKO JCECGKAIEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	private bool IBGNKCIGCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public IBJAHKDFDAH KOAGOHJBOFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public IBJAHKDFDAH PKKBFCPLKOP;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public CHMOOPPGDGB CFOCDEKJEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public FFHNIMCCMFI BCDAFCHHCGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x8DC9B30", Offset = "0x8DC8530", VA = "0x188DC9B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public CJKIJIMANDA GCKCNGJGFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x8DC9450", Offset = "0x8DC7E50", VA = "0x188DC9450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public FDNIDPPAKMF EGHDDGIBOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x8DC95A0", Offset = "0x8DC7FA0", VA = "0x188DC95A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event OADHLNFGHIK NDOACDJDNMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x8DC9E10", Offset = "0x8DC8810", VA = "0x188DC9E10", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x8DC9850", Offset = "0x8DC8250", VA = "0x188DC9850", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x8DC9E30", Offset = "0x8DC8830", VA = "0x188DC9E30")]
	protected ECHHAJDKEIH(Guid CHBBGPKOFFN, CHMOOPPGDGB NGALMEDAPGH, BEOKCNIMCAK NMPPILJOIAL, string DCKLCAPPGOC, LMKGBJJKKKO JCECGKAIEFB, bool BJOPDNNOJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x8DC9B80", Offset = "0x8DC8580", VA = "0x188DC9B80", Slot = "6")]
	protected virtual string JLAADLNKANE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x8DC9960", Offset = "0x8DC8360", VA = "0x188DC9960")]
	public void HOCAPNJHPAC(AFPPGGLMDCF OLGHGKJILEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x8DC9430", Offset = "0x8DC7E30", VA = "0x188DC9430")]
	protected void APJAKFBEJFB(float BNAMGIMJGIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x8DC92E0", Offset = "0x8DC7CE0", VA = "0x188DC92E0")]
	[AsyncStateMachine(typeof(MCFMPAGFKIC))]
	public Task AEOBHGFBIDI(CancellationToken AHOMALKMHKK, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, [Optional] Func<ECHHAJDKEIH, OEEGBKAOPAE<string>.BANCHJBJHFK, GPFLGLGCINI> PNCMNENHBHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x8DC9BC0", Offset = "0x8DC85C0", VA = "0x188DC9BC0")]
	[AsyncStateMachine(typeof(KIIDFODAHDD))]
	private static Task LBHCINBNIKL(Func<CancellationToken, Task> KOKBLNKIHFH, Func<CancellationToken, Task> KHAJNIKAEHJ, CancellationToken ICODIHINNBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x8DC99C0", Offset = "0x8DC83C0", VA = "0x188DC99C0")]
	private void HOENMCDHCEN(bool GAJICMBGPLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x8DC9620", Offset = "0x8DC8020", VA = "0x188DC9620")]
	private void GAONEHJABCF(GPFLGLGCINI FGJGFPOECJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task DKDECAHIBCN(GPFLGLGCINI FGJGFPOECJN, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x8DC9CF0", Offset = "0x8DC86F0", VA = "0x188DC9CF0")]
	[AsyncStateMachine(typeof(IKFNPMGGENB))]
	private Task LKGKOCDKHPP(OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x8DC94A0", Offset = "0x8DC7EA0", VA = "0x188DC94A0")]
	public BDHPLICAJHI EDKANEKOKPJ(ACGHAABHPJL CGMPAMOIMMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x8DC9870", Offset = "0x8DC8270", VA = "0x188DC9870")]
	[CompilerGenerated]
	private Task HBHAJAIKPCG(CancellationToken GGMLEPFJHKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x8DC9520", Offset = "0x8DC7F20", VA = "0x188DC9520")]
	[CompilerGenerated]
	private object EFPGJHAAGKN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
internal sealed class COLLCDLNNKA : LINJCMIINCB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct LOLOOICNHJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public COLLCDLNNKA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public GPFLGLGCINI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private GJIGLAJEIOM <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private JEOPOFELMFB <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x8DD6860", Offset = "0x8DD5260", VA = "0x188DD6860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x8DD6FD0", Offset = "0x8DD59D0", VA = "0x188DD6FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	private readonly CCNAABFFCED AAPIILJAHAC;

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x8DC9170", Offset = "0x8DC7B70", VA = "0x188DC9170")]
	public COLLCDLNNKA(Guid CHBBGPKOFFN, CHMOOPPGDGB NGALMEDAPGH, CCNAABFFCED AAPIILJAHAC, BEOKCNIMCAK NMPPILJOIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x8DC9020", Offset = "0x8DC7A20", VA = "0x188DC9020", Slot = "8")]
	[AsyncStateMachine(typeof(LOLOOICNHJJ))]
	protected override Task NNIECHDIIOH(GPFLGLGCINI FGJGFPOECJN, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal class AGCLJCJMCPJ : ECHHAJDKEIH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct HJFENHIJAEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public AGCLJCJMCPJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public GPFLGLGCINI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private TaskAwaiter<DFPILBGDMFF> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x8DD0070", Offset = "0x8DCEA70", VA = "0x188DD0070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x8DD0500", Offset = "0x8DCEF00", VA = "0x188DD0500", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private readonly string JAKIJIEGAGG;

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x8DC42C0", Offset = "0x8DC2CC0", VA = "0x188DC42C0")]
	public AGCLJCJMCPJ(Guid CHBBGPKOFFN, CHMOOPPGDGB NGALMEDAPGH, BEOKCNIMCAK NMPPILJOIAL, string JAKIJIEGAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x8DC41B0", Offset = "0x8DC2BB0", VA = "0x188DC41B0", Slot = "7")]
	[AsyncStateMachine(typeof(HJFENHIJAEF))]
	protected override Task DKDECAHIBCN(GPFLGLGCINI FGJGFPOECJN, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal class AFMKBGNDGPK : LINJCMIINCB
{
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private sealed class APOAMEOALFC
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000134")]
		private struct <<RunWhilePlayerDespawnedAsync>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004AF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004B0")]
			public AsyncTaskMethodBuilder<BDHPLICAJHI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004B1")]
			public APOAMEOALFC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			private TaskAwaiter<DFPILBGDMFF> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004B4")]
			private TaskAwaiter<BDHPLICAJHI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600055F")]
			[Cpp2IlInjected.Address(RVA = "0x8DE0570", Offset = "0x8DDEF70", VA = "0x188DE0570", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(RVA = "0x8DE0A60", Offset = "0x8DDF460", VA = "0x188DE0A60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public AFMKBGNDGPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public HEMJNFGDOOG serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public FJCNFCABHMI roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public IJGANLFOGKM uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public CEGHBONCLIO roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public APOAMEOALFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x8DC67B0", Offset = "0x8DC51B0", VA = "0x188DC67B0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<BDHPLICAJHI> OEDNDOJPEHK(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct HEJGLMKLHBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public AFMKBGNDGPK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public GPFLGLGCINI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private APOAMEOALFC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private GJIGLAJEIOM <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private JEOPOFELMFB <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private BDHPLICAJHI <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private TaskAwaiter<BDHPLICAJHI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x8DCEEC0", Offset = "0x8DCD8C0", VA = "0x188DCEEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x8DCFDB0", Offset = "0x8DCE7B0", VA = "0x188DCFDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	private static readonly OLFEOKKCIEG HPIJLNODOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	private readonly int BHLHMOKBKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	[CanBeNull]
	private readonly GKJAGFBLLKC FGDEENNPCPP;

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x8DC3F90", Offset = "0x8DC2990", VA = "0x188DC3F90")]
	public AFMKBGNDGPK(Guid CHBBGPKOFFN, CHMOOPPGDGB NGALMEDAPGH, int BHLHMOKBKOA, GKJAGFBLLKC FGDEENNPCPP, BEOKCNIMCAK NMPPILJOIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x8DC3DA0", Offset = "0x8DC27A0", VA = "0x188DC3DA0", Slot = "8")]
	[AsyncStateMachine(typeof(HEJGLMKLHBA))]
	protected override Task NNIECHDIIOH(GPFLGLGCINI FGJGFPOECJN, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x8DC3CA0", Offset = "0x8DC26A0", VA = "0x188DC3CA0")]
	private void NNCMHIPDLDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x8DC3AD0", Offset = "0x8DC24D0", VA = "0x188DC3AD0")]
	private void JLMBIJFGIKO(OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, GJIGLAJEIOM MLNHANKLKJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal class OLINAOFCBCD : ECHHAJDKEIH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct HAACHPLANIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public OLINAOFCBCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private GJIGLAJEIOM <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private long <superRoomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private long <subRoomId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private HCJPDEFNHKL <currentRoomSave>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private AACADPLMCLK<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private TaskAwaiter<HCJPDEFNHKL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private TaskAwaiter<ReadOnlySequence<byte>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private TaskAwaiter<PPJEADMNHEK> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private TaskAwaiter <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x8DCD1E0", Offset = "0x8DCBBE0", VA = "0x188DCD1E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x8DCE620", Offset = "0x8DCD020", VA = "0x188DCE620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	private readonly int BHLHMOKBKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	private readonly GKJAGFBLLKC FGDEENNPCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	private Func<DFPILBGDMFF, DFPILBGDMFF> EICHFPJDCLH;

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x8DDD2C0", Offset = "0x8DDBCC0", VA = "0x188DDD2C0")]
	public OLINAOFCBCD(Guid CHBBGPKOFFN, CHMOOPPGDGB NGALMEDAPGH, int BHLHMOKBKOA, GKJAGFBLLKC FGDEENNPCPP, Func<DFPILBGDMFF, DFPILBGDMFF> EICHFPJDCLH, BEOKCNIMCAK NMPPILJOIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x8DDD190", Offset = "0x8DDBB90", VA = "0x188DDD190", Slot = "7")]
	[AsyncStateMachine(typeof(HAACHPLANIL))]
	protected override Task DKDECAHIBCN(GPFLGLGCINI FGJGFPOECJN, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal abstract class PDLFDHCLAOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public readonly ECHHAJDKEIH LBLJJNDELGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public readonly GPFLGLGCINI EFIECAFGMGP;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public FFHNIMCCMFI BCDAFCHHCGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x8DDDEA0", Offset = "0x8DDC8A0", VA = "0x188DDDEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public FDNIDPPAKMF EGHDDGIBOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x8DDDE10", Offset = "0x8DDC810", VA = "0x188DDDE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x8DDE010", Offset = "0x8DDCA10", VA = "0x188DDE010")]
	protected PDLFDHCLAOK(GPFLGLGCINI FGJGFPOECJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x8DDDEF0", Offset = "0x8DDC8F0", VA = "0x188DDDEF0")]
	protected void JAPFEIFECJM(string IEKECJIEHGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct FCDOBIBAEHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public Dictionary<Guid, List<JAEDGEODMNM>> FEFPDBAMNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public Dictionary<Guid, List<JAEDGEODMNM>> LAHIKKMONCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public Dictionary<Guid, List<JAEDGEODMNM>> AIDFMNOJMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public List<Guid> FCDHGJKOELL;

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x8DCA2C0", Offset = "0x8DC8CC0", VA = "0x188DCA2C0")]
	public static FCDOBIBAEHG GFFPJLNAMHB(FFHNIMCCMFI ADCMGLPBECA, IBJAHKDFDAH OCEEJPIEMGJ, CMFAJILFAHI GBIGFHHDIBP)
	{
		return default(FCDOBIBAEHG);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct BDACDAIKDOI
{
	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250")]
	public static BDACDAIKDOI MLAHKGEEKLJ()
	{
		return default(BDACDAIKDOI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal struct LHOHOJEJAHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public readonly PKCMPJMLDGM EDBEPKHMJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public readonly PMHLBPGOPPD PGAFPPOOEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public readonly Guid? NDKPBPBIOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public readonly IReadOnlyCollection<LMBBLNHDLDK> MNPBGPGNHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public readonly IReadOnlyCollection<LMBBLNHDLDK> KIFCMKOKEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public readonly APAFHBPABPH NDJGEMIFCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public readonly APAFHBPABPH NHHOJBCKKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public readonly LFPGAJNOPDL LPGNBMAEHCL;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool BKJNMFEHBND
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x8DD5B60", Offset = "0x8DD4560", VA = "0x188DD5B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x8DD5BF0", Offset = "0x8DD45F0", VA = "0x188DD5BF0")]
	public LHOHOJEJAHO(PKCMPJMLDGM EDBEPKHMJCK, PMHLBPGOPPD PGAFPPOOEND, Guid? NDKPBPBIOMO, IReadOnlyList<LMBBLNHDLDK> MNPBGPGNHCC, IReadOnlyCollection<LMBBLNHDLDK> KIFCMKOKEEL, APAFHBPABPH NDJGEMIFCHE, APAFHBPABPH NHHOJBCKKLB, LFPGAJNOPDL LPGNBMAEHCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal struct FNCMNKLHEEN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private readonly GPFLGLGCINI FGJGFPOECJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private readonly Guid IOFOBBIMJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	private bool GAJICMBGPLH;

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x8DCA9F0", Offset = "0x8DC93F0", VA = "0x188DCA9F0")]
	public static FNCMNKLHEEN AONLINMMHDE(GPFLGLGCINI FGJGFPOECJN)
	{
		return default(FNCMNKLHEEN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x13C2800", Offset = "0x13C1200", VA = "0x1813C2800")]
	public void DGIKINIGGJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x8DCAA20", Offset = "0x8DC9420", VA = "0x188DCAA20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x8DCAD10", Offset = "0x8DC9710", VA = "0x188DCAD10")]
	private FNCMNKLHEEN(GPFLGLGCINI FGJGFPOECJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x8DCAA30", Offset = "0x8DC9430", VA = "0x188DCAA30")]
	private void KDMIBPDMGNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x8DCAC70", Offset = "0x8DC9670", VA = "0x188DCAC70")]
	private Func<Guid, bool> MOMBBMAFEOE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
internal class JEOPOFELMFB : PDLFDHCLAOK, ODDEMOLBLEK
{
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	public delegate Task<IBJAHKDFDAH> FMOAAKIMMGD(CMFAJILFAHI BLPDDGCLNPE, LNBIFKHOIBN KMICNMIEBDM, MEILIGBJNHJ CMPBGOLILAA, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct DDOLIPFGGOJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public JEOPOFELMFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public CCNAABFFCED request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private FNCMNKLHEEN <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private TaskAwaiter<BDHPLICAJHI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x8DE6110", Offset = "0x8DE4B10", VA = "0x188DE6110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x8DE6850", Offset = "0x8DE5250", VA = "0x188DE6850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct PHPCGHNJCCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public AsyncTaskMethodBuilder<BDHPLICAJHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public JEOPOFELMFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public CCNAABFFCED request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private TaskAwaiter<BDHPLICAJHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4D00", Offset = "0x8DF3700", VA = "0x188DF4D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5130", Offset = "0x8DF3B30", VA = "0x188DF5130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct PIKJNEJMLHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public JEOPOFELMFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public CCNAABFFCED request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x8DF51A0", Offset = "0x8DF3BA0", VA = "0x188DF51A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5660", Offset = "0x8DF4060", VA = "0x188DF5660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class MKJCJLLHNGG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000144")]
		private struct <<LoadRoomLocal>b__1>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000510")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000511")]
			public AsyncTaskMethodBuilder<LHOHOJEJAHO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000512")]
			public MKJCJLLHNGG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000513")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000514")]
			private LHOHOJEJAHO <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000515")]
			private TaskAwaiter<IBJAHKDFDAH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000516")]
			private TaskAwaiter<LHOHOJEJAHO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x8DF6CE0", Offset = "0x8DF56E0", VA = "0x188DF6CE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x8DF75A0", Offset = "0x8DF5FA0", VA = "0x188DF75A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000145")]
		private struct <<LoadRoomLocal>b__3>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000517")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000518")]
			public AsyncTaskMethodBuilder<CMFAJILFAHI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000519")]
			public MKJCJLLHNGG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400051A")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400051B")]
			private CMFAJILFAHI <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400051C")]
			private TaskAwaiter<IBJAHKDFDAH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400051D")]
			private TaskAwaiter<CMFAJILFAHI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0x8DF7610", Offset = "0x8DF6010", VA = "0x188DF7610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0x8DF7C60", Offset = "0x8DF6660", VA = "0x188DF7C60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public JEOPOFELMFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public CCNAABFFCED request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public MEILIGBJNHJ preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public MEILIGBJNHJ downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public LHOHOJEJAHO data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public MEILIGBJNHJ postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public CMFAJILFAHI phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public CLFDOCGHGJD.OLKGGNOFGNE <>9__5;

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public MKJCJLLHNGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x8DF05D0", Offset = "0x8DEEFD0", VA = "0x188DF05D0")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<LHOHOJEJAHO> LHPAFCAAFLN(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x8DF0720", Offset = "0x8DEF120", VA = "0x188DF0720")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<CMFAJILFAHI> PFOEOGPNLMP(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x8DF0510", Offset = "0x8DEEF10", VA = "0x188DF0510")]
		internal void BJELIBHDPEG(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x8DF0550", Offset = "0x8DEEF50", VA = "0x188DF0550")]
		internal Task EMDEBIPMOPO(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x8DF0590", Offset = "0x8DEEF90", VA = "0x188DF0590")]
		internal Task GMHNOGFKJNI(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct HLBEKIOOCHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public JEOPOFELMFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public CCNAABFFCED request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private MKJCJLLHNGG <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private TaskAwaiter<LHOHOJEJAHO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private TaskAwaiter<CMFAJILFAHI> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x8DE9D20", Offset = "0x8DE8720", VA = "0x188DE9D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x8DEA9F0", Offset = "0x8DE93F0", VA = "0x188DEA9F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct KOIGMJOMNGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public JEOPOFELMFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public CMFAJILFAHI phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public MEILIGBJNHJ postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private TaskAwaiter<IBJAHKDFDAH> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private LNBIFKHOIBN <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x8DEE630", Offset = "0x8DED030", VA = "0x188DEE630", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x8DEF490", Offset = "0x8DEDE90", VA = "0x188DEF490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct EEEMHNDENNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public JEOPOFELMFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x8DE7640", Offset = "0x8DE6040", VA = "0x188DE7640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x8DE7E20", Offset = "0x8DE6820", VA = "0x188DE7E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct KHLCDJCLPOL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public JEOPOFELMFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public CMFAJILFAHI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public MEILIGBJNHJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private TaskAwaiter<IBJAHKDFDAH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x8DED180", Offset = "0x8DEBB80", VA = "0x188DED180", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x8DED9C0", Offset = "0x8DEC3C0", VA = "0x188DED9C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct IDPPLAHEOJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public AsyncTaskMethodBuilder<IBJAHKDFDAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public JEOPOFELMFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public CMFAJILFAHI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public MEILIGBJNHJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private TaskAwaiter<IBJAHKDFDAH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x8DEB1D0", Offset = "0x8DE9BD0", VA = "0x188DEB1D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x8DEC190", Offset = "0x8DEAB90", VA = "0x188DEC190", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct OEILIKHAGOH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public AsyncTaskMethodBuilder<IBJAHKDFDAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public JEOPOFELMFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public CMFAJILFAHI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public MEILIGBJNHJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public LNBIFKHOIBN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private TaskAwaiter<IBJAHKDFDAH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3AA0", Offset = "0x8DF24A0", VA = "0x188DF3AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x8DF4BB0", Offset = "0x8DF35B0", VA = "0x188DF4BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct AGKCFPBMMDE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public AsyncTaskMethodBuilder<IBJAHKDFDAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public JEOPOFELMFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public IBJAHKDFDAH operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public MEILIGBJNHJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public CMFAJILFAHI deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private TaskAwaiter<IBJAHKDFDAH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x8DE13C0", Offset = "0x8DDFDC0", VA = "0x188DE13C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1610", Offset = "0x8DE0010", VA = "0x188DE1610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class NKHLPCPJAIF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200014F")]
		private struct <<MasterLockedPhaseChangeBlock>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400056D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400056E")]
			public AsyncTaskMethodBuilder<IBJAHKDFDAH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400056F")]
			public NKHLPCPJAIF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000570")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000571")]
			private PDJKNFENBKE <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000572")]
			private TaskAwaiter<IBJAHKDFDAH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0x8DF7CD0", Offset = "0x8DF66D0", VA = "0x188DF7CD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0x8DF81A0", Offset = "0x8DF6BA0", VA = "0x188DF81A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public JEOPOFELMFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public FMOAAKIMMGD masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public CMFAJILFAHI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public LNBIFKHOIBN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public MEILIGBJNHJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public IBJAHKDFDAH initialState;

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public NKHLPCPJAIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3980", Offset = "0x8DF2380", VA = "0x188DF3980")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<IBJAHKDFDAH> ILAIKNFELLN(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct BFJDCEFNMKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public AsyncTaskMethodBuilder<IBJAHKDFDAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public JEOPOFELMFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public FMOAAKIMMGD masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public CMFAJILFAHI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public LNBIFKHOIBN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public MEILIGBJNHJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private TaskAwaiter<IBJAHKDFDAH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1680", Offset = "0x8DE0080", VA = "0x188DE1680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1BA0", Offset = "0x8DE05A0", VA = "0x188DE1BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct EHODKKDDPMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public JEOPOFELMFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public CMFAJILFAHI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public MEILIGBJNHJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private IBJAHKDFDAH <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private IEnumerator<IBJAHKDFDAH> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private TaskAwaiter<IBJAHKDFDAH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x8DE7FC0", Offset = "0x8DE69C0", VA = "0x188DE7FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x8DE8520", Offset = "0x8DE6F20", VA = "0x188DE8520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct NBCBDBGPMGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public JEOPOFELMFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public CMFAJILFAHI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1460", Offset = "0x8DEFE60", VA = "0x188DF1460", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1750", Offset = "0x8DF0150", VA = "0x188DF1750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct HLJNICOGJIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public JEOPOFELMFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public CMFAJILFAHI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x8DEAA50", Offset = "0x8DE9450", VA = "0x188DEAA50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x8DEAC80", Offset = "0x8DE9680", VA = "0x188DEAC80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private sealed class LIKMNGBBJIO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000155")]
		private struct <<RoomV2LoadLogic>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000597")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000598")]
			public AsyncTaskMethodBuilder<IBJAHKDFDAH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000599")]
			public LIKMNGBBJIO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400059A")]
			public CMFAJILFAHI data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400059B")]
			public MEILIGBJNHJ progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400059C")]
			public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400059D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400059E")]
			private TaskAwaiter<IBJAHKDFDAH> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400059F")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005A0")]
			private TaskAwaiter<NOIILBLDIEO> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x8DF8210", Offset = "0x8DF6C10", VA = "0x188DF8210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0x8DF8CE0", Offset = "0x8DF76E0", VA = "0x188DF8CE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public JEOPOFELMFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public GAOFOKCGIKJ mainLoadService;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public LIKMNGBBJIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x8DEFC20", Offset = "0x8DEE620", VA = "0x188DEFC20")]
		[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
		internal Task<IBJAHKDFDAH> DHGFEGCCFNI(CMFAJILFAHI data, LNBIFKHOIBN _, MEILIGBJNHJ progressTracker, OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct CBMOJBJENDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public JEOPOFELMFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public CMFAJILFAHI phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public MEILIGBJNHJ postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private LIKMNGBBJIO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private LNBIFKHOIBN <timedYielder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private TaskAwaiter<IBJAHKDFDAH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3120", Offset = "0x8DE1B20", VA = "0x188DE3120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3F70", Offset = "0x8DE2970", VA = "0x188DE3F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct BPJHNPCEGKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public JEOPOFELMFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public CMFAJILFAHI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x8DE27E0", Offset = "0x8DE11E0", VA = "0x188DE27E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2BE0", Offset = "0x8DE15E0", VA = "0x188DE2BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct CELHDJINLCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public AsyncTaskMethodBuilder<IBJAHKDFDAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public JEOPOFELMFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public CMFAJILFAHI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public MEILIGBJNHJ progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private TaskAwaiter<IBJAHKDFDAH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x8DE57E0", Offset = "0x8DE41E0", VA = "0x188DE57E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5E00", Offset = "0x8DE4800", VA = "0x188DE5E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	private readonly OMCJCLBFMAA MDIMCBFOGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	private readonly OMCJCLBFMAA ANCCDEIFMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	private readonly MICBNHDLKLK BPOOOHOMDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private readonly NLHMFGCDECP AGHECKBAHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	private readonly FBDFAKIBLGM HKLCPOBMIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	private ProfilerCounterValue<int> IPODNNMCBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	private readonly GGAMAAEOFMM JKDCACEDKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	private readonly GBKGIJBJPLI AKNDJHEIPCC;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private CHMOOPPGDGB CFOCDEKJEAC
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x8DD1F50", Offset = "0x8DD0950", VA = "0x188DD1F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event OADHLNFGHIK NDOACDJDNMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x8DD31F0", Offset = "0x8DD1BF0", VA = "0x188DD31F0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x8DD2170", Offset = "0x8DD0B70", VA = "0x188DD2170", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x8DD3600", Offset = "0x8DD2000", VA = "0x188DD3600")]
	public JEOPOFELMFB(GPFLGLGCINI FGJGFPOECJN, GBKGIJBJPLI AKNDJHEIPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x8DD2F50", Offset = "0x8DD1950", VA = "0x188DD2F50")]
	[AsyncStateMachine(typeof(DDOLIPFGGOJ))]
	public Task MJEOLKAMMOO(CCNAABFFCED KGHMNJMLIBE, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x8DD24C0", Offset = "0x8DD0EC0", VA = "0x188DD24C0")]
	[AsyncStateMachine(typeof(PHPCGHNJCCB))]
	private Task<BDHPLICAJHI> HOKHHCENEOM(CCNAABFFCED KGHMNJMLIBE, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x8DD30B0", Offset = "0x8DD1AB0", VA = "0x188DD30B0")]
	[AsyncStateMachine(typeof(PIKJNEJMLHD))]
	private Task NBAGOAFCHFK(CCNAABFFCED KGHMNJMLIBE, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x8DD1F80", Offset = "0x8DD0980", VA = "0x188DD1F80")]
	[AsyncStateMachine(typeof(HLBEKIOOCHC))]
	private Task EMAGPPHEOFI(CCNAABFFCED KGHMNJMLIBE, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken HBLBLIFGLBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x8DD2370", Offset = "0x8DD0D70", VA = "0x188DD2370")]
	[AsyncStateMachine(typeof(KOIGMJOMNGK))]
	private Task HKPMJHLOHLI(CMFAJILFAHI NHCDLCCMOHI, MEILIGBJNHJ ILEFBEBICGK, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken LMDNBAJNFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x8DD34F0", Offset = "0x8DD1EF0", VA = "0x188DD34F0")]
	[AsyncStateMachine(typeof(EEEMHNDENNC))]
	private Task PMOCHPMADOD(OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x8DD1CB0", Offset = "0x8DD06B0", VA = "0x188DD1CB0")]
	[AsyncStateMachine(typeof(KHLCDJCLPOL))]
	private Task DLJOBMKMGIB(CMFAJILFAHI BLPDDGCLNPE, MEILIGBJNHJ CMPBGOLILAA, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x8DD2210", Offset = "0x8DD0C10", VA = "0x188DD2210")]
	[AsyncStateMachine(typeof(IDPPLAHEOJJ))]
	private Task<IBJAHKDFDAH> HKJADMOLCJB(CMFAJILFAHI BLPDDGCLNPE, LNBIFKHOIBN GHJGKOMBDCK, MEILIGBJNHJ CMPBGOLILAA, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x8DD1B30", Offset = "0x8DD0530", VA = "0x188DD1B30")]
	[AsyncStateMachine(typeof(OEILIKHAGOH))]
	private Task<IBJAHKDFDAH> DGIMADEONEK(CMFAJILFAHI BLPDDGCLNPE, LNBIFKHOIBN GHJGKOMBDCK, MEILIGBJNHJ CMPBGOLILAA, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x8DD2DD0", Offset = "0x8DD17D0", VA = "0x188DD2DD0")]
	[AsyncStateMachine(typeof(AGKCFPBMMDE))]
	private Task<IBJAHKDFDAH> MCGIKOPHCCJ(IBJAHKDFDAH OCEEJPIEMGJ, CMFAJILFAHI GBIGFHHDIBP, MEILIGBJNHJ CMPBGOLILAA, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK, bool CHMKKLLCAKP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x8DD2A50", Offset = "0x8DD1450", VA = "0x188DD2A50")]
	private bool KKJPNLGNHIO(CMFAJILFAHI NHCDLCCMOHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x8DD3210", Offset = "0x8DD1C10", VA = "0x188DD3210")]
	[AsyncStateMachine(typeof(BFJDCEFNMKJ))]
	protected Task<IBJAHKDFDAH> NOBNLDCBDFC(CMFAJILFAHI BLPDDGCLNPE, LNBIFKHOIBN GHJGKOMBDCK, MEILIGBJNHJ CMPBGOLILAA, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK, FMOAAKIMMGD LKENJALJELE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x8DD2C80", Offset = "0x8DD1680", VA = "0x188DD2C80")]
	[AsyncStateMachine(typeof(EHODKKDDPMI))]
	private Task LIAAJDNJMIB(CMFAJILFAHI BLPDDGCLNPE, MEILIGBJNHJ CMPBGOLILAA, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x8DD29E0", Offset = "0x8DD13E0", VA = "0x188DD29E0")]
	private void JFLHIEDMFFE(IBJAHKDFDAH MHKOKMLIBEL, MEILIGBJNHJ CMPBGOLILAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x8DD1AB0", Offset = "0x8DD04B0", VA = "0x188DD1AB0")]
	private void DEJBJPEHCNJ(IBJAHKDFDAH DCFNNAIHAMP, [Out] IBJAHKDFDAH HJBCDOHCGGE, [Out] IBJAHKDFDAH GGOFCOOPHNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x8DD21B0", Offset = "0x8DD0BB0", VA = "0x188DD21B0")]
	private Task<LHOHOJEJAHO> GNJBPDOACHE(CCNAABFFCED KGHMNJMLIBE, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x8DD1AF0", Offset = "0x8DD04F0", VA = "0x188DD1AF0")]
	private Task<CMFAJILFAHI> DEMEFHCAHLB(LHOHOJEJAHO BLPDDGCLNPE, CLFDOCGHGJD.OLKGGNOFGNE MDONJJJHHCD, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x8DD33A0", Offset = "0x8DD1DA0", VA = "0x188DD33A0")]
	[AsyncStateMachine(typeof(NBCBDBGPMGM))]
	private Task NPBOLBIOMCI(CMFAJILFAHI BLPDDGCLNPE, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK, bool DAIGLOBOJJH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x8DD2780", Offset = "0x8DD1180", VA = "0x188DD2780")]
	[AsyncStateMachine(typeof(HLJNICOGJIE))]
	private Task ILIJNIIOPNC(CMFAJILFAHI BLPDDGCLNPE, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x8DD2990", Offset = "0x8DD1390", VA = "0x188DD2990")]
	private Task IOCCCDAOAPB(CMFAJILFAHI BLPDDGCLNPE, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x8DD2A30", Offset = "0x8DD1430", VA = "0x188DD2A30")]
	private Task KHCJFIGKLHP(CMFAJILFAHI BLPDDGCLNPE, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x8DD29C0", Offset = "0x8DD13C0", VA = "0x188DD29C0")]
	private Task IOJANNJIKNA(CMFAJILFAHI BLPDDGCLNPE, LNBIFKHOIBN GHJGKOMBDCK, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x8DD21F0", Offset = "0x8DD0BF0", VA = "0x188DD21F0")]
	private Task HANGGLNGGOJ(CMFAJILFAHI BLPDDGCLNPE, LNBIFKHOIBN GHJGKOMBDCK, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x8DD30A0", Offset = "0x8DD1AA0", VA = "0x188DD30A0")]
	private static Task MJPAKAGALIF(CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x8DD1A90", Offset = "0x8DD0490", VA = "0x188DD1A90")]
	private Task CNANHHGHKMF(CMFAJILFAHI BLPDDGCLNPE, LNBIFKHOIBN GHJGKOMBDCK, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x8DD2190", Offset = "0x8DD0B90", VA = "0x188DD2190")]
	private Task GKNDNPEHPKH(CMFAJILFAHI BLPDDGCLNPE, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x8DD1A40", Offset = "0x8DD0440", VA = "0x188DD1A40")]
	private void ALKGMIKFCFG(CCNAABFFCED KGHMNJMLIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x8DD20C0", Offset = "0x8DD0AC0", VA = "0x188DD20C0")]
	public void FMDBHNAEKHI(long AFCPIMKFDHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	private static void NKHPNGAOPLK(PKCMPJMLDGM EDBEPKHMJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x8DD1E00", Offset = "0x8DD0800", VA = "0x188DD1E00")]
	[AsyncStateMachine(typeof(CBMOJBJENDM))]
	private Task DNFFDMCGOCJ(CMFAJILFAHI NHCDLCCMOHI, MEILIGBJNHJ ILEFBEBICGK, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken LMDNBAJNFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x8DD2B40", Offset = "0x8DD1540", VA = "0x188DD2B40")]
	[AsyncStateMachine(typeof(BPJHNPCEGKB))]
	private Task KPCJGNAAJGK(CMFAJILFAHI BLPDDGCLNPE, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x8DD2870", Offset = "0x8DD1270", VA = "0x188DD2870")]
	private static IFCMBFOMDFH INPLACPBOIH(CMFAJILFAHI GBIGFHHDIBP)
	{
		return default(IFCMBFOMDFH);
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x8DD2620", Offset = "0x8DD1020", VA = "0x188DD2620")]
	[AsyncStateMachine(typeof(CELHDJINLCC))]
	private Task<IBJAHKDFDAH> HPIEGKHBBHH(CMFAJILFAHI BLPDDGCLNPE, LNBIFKHOIBN GHJGKOMBDCK, MEILIGBJNHJ CMPBGOLILAA, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	private void LBHDLLPFAID(IBJAHKDFDAH NMJJIIJGDEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct DHOOMMHOEJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005BD")]
	private CHMOOPPGDGB NGALMEDAPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005BE")]
	private CMFAJILFAHI BLPDDGCLNPE;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private FFHNIMCCMFI BCDAFCHHCGD
	{
		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x8DE6C00", Offset = "0x8DE5600", VA = "0x188DE6C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x8DE6900", Offset = "0x8DE5300", VA = "0x188DE6900")]
	public static Task AEOBHGFBIDI(CHMOOPPGDGB NGALMEDAPGH, CMFAJILFAHI BLPDDGCLNPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x8DE69E0", Offset = "0x8DE53E0", VA = "0x188DE69E0")]
	private void AEOBHGFBIDI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct PGPGDNPLFGD
{
	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x8DF4C20", Offset = "0x8DF3620", VA = "0x188DF4C20")]
	public static Task AEOBHGFBIDI(CancellationToken AHOMALKMHKK)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015B")]
internal struct EGGKENPMFCF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private struct KJAPIKPBLCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public GPFLGLGCINI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public CMFAJILFAHI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x8DEDA20", Offset = "0x8DEC420", VA = "0x188DEDA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x8DEDF50", Offset = "0x8DEC950", VA = "0x188DEDF50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x8DE7E80", Offset = "0x8DE6880", VA = "0x188DE7E80")]
	[AsyncStateMachine(typeof(KJAPIKPBLCP))]
	public static Task AEOBHGFBIDI(GPFLGLGCINI FGJGFPOECJN, CMFAJILFAHI BLPDDGCLNPE, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015D")]
internal struct BLNNPDELJOA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct JALLDENMBEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public GPFLGLGCINI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public CMFAJILFAHI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public LNBIFKHOIBN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private CHMOOPPGDGB <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private FFHNIMCCMFI <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private IBJAHKDFDAH <operationState>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private bool <isMaster>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private PDJKNFENBKE <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		private List<(PersistenceView, LNEHPBAPDKG)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private LNEHPBAPDKG <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x8DEC320", Offset = "0x8DEAD20", VA = "0x188DEC320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x8DED000", Offset = "0x8DEBA00", VA = "0x188DED000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x8DE2490", Offset = "0x8DE0E90", VA = "0x188DE2490")]
	[AsyncStateMachine(typeof(JALLDENMBEA))]
	public static Task AEOBHGFBIDI(GPFLGLGCINI FGJGFPOECJN, CMFAJILFAHI BLPDDGCLNPE, LNBIFKHOIBN GHJGKOMBDCK, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x8DE25E0", Offset = "0x8DE0FE0", VA = "0x188DE25E0")]
	private static void GLBIAEGBLKO(PersistenceView DMJMJBPOHHC, LNEHPBAPDKG CKBAKJANFMC, CMFAJILFAHI BLPDDGCLNPE, IBJAHKDFDAH OCEEJPIEMGJ, bool GIAGIPGDLKF)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal struct JAJEGLODEEJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private struct KODKJGJAALI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public CHMOOPPGDGB roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public CMFAJILFAHI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private PDJKNFENBKE <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x8DEDFB0", Offset = "0x8DEC9B0", VA = "0x188DEDFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x8DEE5D0", Offset = "0x8DECFD0", VA = "0x188DEE5D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x8DEC200", Offset = "0x8DEAC00", VA = "0x188DEC200")]
	[AsyncStateMachine(typeof(KODKJGJAALI))]
	public static Task AEOBHGFBIDI(CHMOOPPGDGB NGALMEDAPGH, CMFAJILFAHI BLPDDGCLNPE, CancellationToken AHOMALKMHKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
internal struct MNMMEBEFENP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private struct AGCIAPPBIAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public CHMOOPPGDGB roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public CMFAJILFAHI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public GPFLGLGCINI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1150", Offset = "0x8DDFB50", VA = "0x188DE1150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x8DE1360", Offset = "0x8DDFD60", VA = "0x188DE1360", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class KAIEINMMLMA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000165")]
		private struct <<Run>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005F1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005F2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005F3")]
			public OEEGBKAOPAE<string>.BANCHJBJHFK timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005F4")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005F5")]
			public KAIEINMMLMA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005F6")]
			private OEEGBKAOPAE<string>.BANCHJBJHFK <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005F7")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0x8DF8D50", Offset = "0x8DF7750", VA = "0x188DF8D50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x8DF90E0", Offset = "0x8DF7AE0", VA = "0x188DF90E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public KAIEINMMLMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x8DED060", Offset = "0x8DEBA60", VA = "0x188DED060")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task LJBDCCDHADC(OEEGBKAOPAE<string>.BANCHJBJHFK timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct NJMFHEILIGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public MNMMEBEFENP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private PDJKNFENBKE <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		private TaskAwaiter<BDHPLICAJHI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x8DF1EC0", Offset = "0x8DF08C0", VA = "0x188DF1EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2AD0", Offset = "0x8DF14D0", VA = "0x188DF2AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private sealed class DLBEPLLJBHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public FPGEPAJMDDO version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		public bool preserveScoreboards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		public List<PersistenceView> existingViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		public List<GameObject> objectsToDestroy;

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public DLBEPLLJBHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x8DE6D00", Offset = "0x8DE5700", VA = "0x188DE6D00")]
		internal object ODENBIJIIDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x8DE6C50", Offset = "0x8DE5650", VA = "0x188DE6C50")]
		internal object NOMLBLGNABL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private CHMOOPPGDGB NGALMEDAPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private CMFAJILFAHI BLPDDGCLNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private GPFLGLGCINI FGJGFPOECJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private bool DAIGLOBOJJH;

	[Cpp2IlInjected.Token(Token = "0x40005E6")]
	private static readonly ByteString HIBFKFKCAND;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private FFHNIMCCMFI BCDAFCHHCGD
	{
		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x8DF0BA0", Offset = "0x8DEF5A0", VA = "0x188DF0BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private FDNIDPPAKMF EGHDDGIBOKD
	{
		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x8DF0AC0", Offset = "0x8DEF4C0", VA = "0x188DF0AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x8DF0970", Offset = "0x8DEF370", VA = "0x188DF0970")]
	[AsyncStateMachine(typeof(AGCIAPPBIAO))]
	public static Task AEOBHGFBIDI(CHMOOPPGDGB NGALMEDAPGH, CMFAJILFAHI BLPDDGCLNPE, GPFLGLGCINI FGJGFPOECJN, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK, bool DAIGLOBOJJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x8DF0840", Offset = "0x8DEF240", VA = "0x188DF0840")]
	[AsyncStateMachine(typeof(NJMFHEILIGK))]
	private Task AEOBHGFBIDI(OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x8DF0BF0", Offset = "0x8DEF5F0", VA = "0x188DF0BF0")]
	private void MAHPLFBNKCN([NotNull] EHIMHNJBHOL DOALKJIILIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x8DF0B60", Offset = "0x8DEF560", VA = "0x188DF0B60")]
	private bool FNDIAAJGCLE(FPGEPAJMDDO PKNNCMNKNHL, EHIMHNJBHOL DOALKJIILIM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct BICHMPNENPO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct NKHDIEEBIEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public AsyncTaskMethodBuilder<CMFAJILFAHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public BICHMPNENPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public CLFDOCGHGJD.OLKGGNOFGNE downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		private TaskAwaiter<IReadOnlyCollection<LMBBLNHDLDK>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		private TaskAwaiter<(FEENKEDBOAD<HIOHINJLKHL, EFLAGBIEFMN>, FEENKEDBOAD<FKPMICMHLMH<EHIMHNJBHOL>, EFLAGBIEFMN>, FEENKEDBOAD<FKPMICMHLMH<EHFFBGCAIIE>, EFLAGBIEFMN>, FEENKEDBOAD<FKPMICMHLMH<IEnumerable<CGFPIIJECHE>>, EFLAGBIEFMN>, FEENKEDBOAD<FKPMICMHLMH<DEHOJEDEEJF>, EFLAGBIEFMN>)> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x8DF2B30", Offset = "0x8DF1530", VA = "0x188DF2B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x8DF3910", Offset = "0x8DF2310", VA = "0x188DF3910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct PPEODCMJMCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public AsyncTaskMethodBuilder<FEENKEDBOAD<HIOHINJLKHL, EFLAGBIEFMN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public BICHMPNENPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public IReadOnlyCollection<LMBBLNHDLDK> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public IReadOnlyCollection<LMBBLNHDLDK> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public CLFDOCGHGJD.OLKGGNOFGNE downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		private TaskAwaiter<FEENKEDBOAD<HIOHINJLKHL, EFLAGBIEFMN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5C00", Offset = "0x8DF4600", VA = "0x188DF5C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x8DF6260", Offset = "0x8DF4C60", VA = "0x188DF6260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	private CGNFBJLEKOC<APAFHBPABPH, EHFFBGCAIIE> CHIEMFPCJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000608")]
	private CGNFBJLEKOC<APAFHBPABPH, EHIMHNJBHOL> GKLMHGGNHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000609")]
	private CGNFBJLEKOC<LFPGAJNOPDL, IEnumerable<CGFPIIJECHE>> AAAPCBOLOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400060A")]
	private CGNFBJLEKOC<long, DEHOJEDEEJF> BBECEPFLPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400060B")]
	private MHPEOFPNGND EOKKCHNIBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	private PKCMPJMLDGM EDBEPKHMJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400060D")]
	private PMHLBPGOPPD PGAFPPOOEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400060E")]
	private Guid? NDKPBPBIOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400060F")]
	private IReadOnlyCollection<LMBBLNHDLDK> MNPBGPGNHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000610")]
	private Task<IReadOnlyCollection<LMBBLNHDLDK>> OLEELNEDAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000611")]
	private APAFHBPABPH NDJGEMIFCHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000612")]
	private APAFHBPABPH NHHOJBCKKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000613")]
	private APAFHBPABPH? JFBLMHAKDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000614")]
	private LFPGAJNOPDL LPGNBMAEHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	private OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO;

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x8DE1FF0", Offset = "0x8DE09F0", VA = "0x188DE1FF0")]
	public static Task<CMFAJILFAHI> OAMEFFNIOOB(CHMOOPPGDGB NGALMEDAPGH, [In] LHOHOJEJAHO BLPDDGCLNPE, CLFDOCGHGJD.OLKGGNOFGNE MDONJJJHHCD, OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x8DE1C10", Offset = "0x8DE0610", VA = "0x188DE1C10")]
	[AsyncStateMachine(typeof(NKHDIEEBIEJ))]
	private Task<CMFAJILFAHI> AEOBHGFBIDI(CLFDOCGHGJD.OLKGGNOFGNE MDONJJJHHCD, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x8DE1DC0", Offset = "0x8DE07C0", VA = "0x188DE1DC0")]
	[AsyncStateMachine(typeof(PPEODCMJMCG))]
	private Task<FEENKEDBOAD<HIOHINJLKHL, EFLAGBIEFMN>> FLNJMNPNMFD(Guid? NDKPBPBIOMO, IReadOnlyCollection<LMBBLNHDLDK> MNPBGPGNHCC, IReadOnlyCollection<LMBBLNHDLDK> KIFCMKOKEEL, long? GDCAPMONNDM, long? FMNCJOBEOEF, CLFDOCGHGJD.OLKGGNOFGNE MDONJJJHHCD, OEEGBKAOPAE<string>.BANCHJBJHFK MAINFMMLPKH, CancellationToken AHOMALKMHKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
internal struct NECMFOAAICO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct LBGGLHJDMHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public AsyncTaskMethodBuilder<LHOHOJEJAHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public NECMFOAAICO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private TaskAwaiter<LHOHOJEJAHO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x8DEF760", Offset = "0x8DEE160", VA = "0x188DEF760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x8DEFBB0", Offset = "0x8DEE5B0", VA = "0x188DEFBB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct HNHMLHNCLKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public AsyncTaskMethodBuilder<LHOHOJEJAHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public NECMFOAAICO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		private TaskAwaiter<LHOHOJEJAHO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x8DEACE0", Offset = "0x8DE96E0", VA = "0x188DEACE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x8DEB160", Offset = "0x8DE9B60", VA = "0x188DEB160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private sealed class FCPNIFDCHBH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200016F")]
		private struct <<FetchRoomLoadDetails>g__getRoomSaveData|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000652")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000653")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000654")]
			public FCPNIFDCHBH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000655")]
			private OEEGBKAOPAE<string>.BANCHJBJHFK <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000656")]
			private TaskAwaiter<ICFDNHEACPK> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000657")]
			private TaskAwaiter<HCJPDEFNHKL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x8DF62D0", Offset = "0x8DF4CD0", VA = "0x188DF62D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0x8DF6C80", Offset = "0x8DF5680", VA = "0x188DF6C80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		public ABNJIEGFEOC roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public FFHNIMCCMFI callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public APAFHBPABPH superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public APAFHBPABPH subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public IReadOnlyList<LMBBLNHDLDK> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public IReadOnlyList<LMBBLNHDLDK> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public PKCMPJMLDGM roomDetails;

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public FCPNIFDCHBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0x1369040", Offset = "0x1367A40", VA = "0x181369040")]
		internal bool PCEKKJKLNLM(PMHLBPGOPPD sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x8DE9100", Offset = "0x8DE7B00", VA = "0x188DE9100")]
		[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
		internal Task NAGMMONPLDE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x8DE8F00", Offset = "0x8DE7900", VA = "0x188DE8F00")]
		internal Task<LFPGAJNOPDL> HCOPKJEJDND()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct CCBOHCPLBLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public AsyncTaskMethodBuilder<LHOHOJEJAHO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public ABNJIEGFEOC roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public FFHNIMCCMFI callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		public APAFHBPABPH superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private FCPNIFDCHBH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private PMHLBPGOPPD <subroom>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private Task<LFPGAJNOPDL> <getRoomLoadDTOTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private TaskAwaiter<PKCMPJMLDGM> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private TaskAwaiter<LFPGAJNOPDL> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x8DE3FD0", Offset = "0x8DE29D0", VA = "0x188DE3FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4F80", Offset = "0x8DE3980", VA = "0x188DE4F80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400062D")]
	private FFHNIMCCMFI ADCMGLPBECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400062E")]
	private MICBNHDLKLK BPOOOHOMDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400062F")]
	private ABNJIEGFEOC MEOCGECJPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	private OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000631")]
	private long GDCAPMONNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000632")]
	private long GKOJBHIBFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000633")]
	private long KOKCHFCMPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000634")]
	private string OBPOKNPEGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000635")]
	private APAFHBPABPH KLFEEJKAJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000636")]
	private Guid NKBOOMANJIH;

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x8DF1C70", Offset = "0x8DF0670", VA = "0x188DF1C70")]
	public static Task<LHOHOJEJAHO> OAMEFFNIOOB(CHMOOPPGDGB NGALMEDAPGH, CCNAABFFCED KGHMNJMLIBE, OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x8DF17B0", Offset = "0x8DF01B0", VA = "0x188DF17B0")]
	[AsyncStateMachine(typeof(LBGGLHJDMHC))]
	private Task<LHOHOJEJAHO> AEOBHGFBIDI(CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x8DF1930", Offset = "0x8DF0330", VA = "0x188DF1930")]
	[AsyncStateMachine(typeof(HNHMLHNCLKD))]
	private Task<LHOHOJEJAHO> GNJBPDOACHE(OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x8DF1AA0", Offset = "0x8DF04A0", VA = "0x188DF1AA0")]
	[AsyncStateMachine(typeof(CCBOHCPLBLD))]
	private static Task<LHOHOJEJAHO> GNJBPDOACHE(FFHNIMCCMFI ADCMGLPBECA, ABNJIEGFEOC MEOCGECJPJH, long GDCAPMONNDM, long GKOJBHIBFEI, long KOKCHFCMPJA, string OBPOKNPEGFF, APAFHBPABPH KLFEEJKAJAB, Guid NKBOOMANJIH, CancellationToken AHOMALKMHKK, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x8DF1900", Offset = "0x8DF0300", VA = "0x188DF1900")]
	private void CJGODKDPHOC(PKCMPJMLDGM EDBEPKHMJCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
internal struct GINHKGDCOGE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct FACMFHCCNMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public GINHKGDCOGE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x8DE8580", Offset = "0x8DE6F80", VA = "0x188DE8580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x8DE8B10", Offset = "0x8DE7510", VA = "0x188DE8B10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066B")]
	private FFHNIMCCMFI ADCMGLPBECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400066C")]
	private CMFAJILFAHI BLPDDGCLNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400066D")]
	private OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	private float LIOFNPDFPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	private float FLIAEPJIDBM;

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x8DE9AE0", Offset = "0x8DE84E0", VA = "0x188DE9AE0")]
	public static Task NKELCENPCLK(CHMOOPPGDGB NGALMEDAPGH, CMFAJILFAHI BLPDDGCLNPE, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x8DE9660", Offset = "0x8DE8060", VA = "0x188DE9660")]
	[AsyncStateMachine(typeof(FACMFHCCNMI))]
	public Task AEOBHGFBIDI(CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x8DE98E0", Offset = "0x8DE82E0", VA = "0x188DE98E0")]
	private static void JHEIKECAOCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x8DE9780", Offset = "0x8DE8180", VA = "0x188DE9780")]
	private void EHIGOFMBPPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x8DE9A20", Offset = "0x8DE8420", VA = "0x188DE9A20")]
	private static float LHBIAKOBHIO(FFHNIMCCMFI ADCMGLPBECA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x8DE9C80", Offset = "0x8DE8680", VA = "0x188DE9C80")]
	private static float OFDLDFELBFP()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000174")]
internal struct KPFKPMJPBAO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct EBGKLGCGKEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public GPFLGLGCINI operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public CMFAJILFAHI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private ECHHAJDKEIH <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private CHMOOPPGDGB <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private BHOACLMPOID.NHGBDEJAJBN <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		private TaskAwaiter<BDHPLICAJHI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x8DE6DE0", Offset = "0x8DE57E0", VA = "0x188DE6DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x8DE75E0", Offset = "0x8DE5FE0", VA = "0x188DE75E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct GCICCBFCKHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x8DE92D0", Offset = "0x8DE7CD0", VA = "0x188DE92D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x8DE9600", Offset = "0x8DE8000", VA = "0x188DE9600", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x8DEF4F0", Offset = "0x8DEDEF0", VA = "0x188DEF4F0")]
	[AsyncStateMachine(typeof(EBGKLGCGKEI))]
	public static Task AEOBHGFBIDI(GPFLGLGCINI FGJGFPOECJN, CMFAJILFAHI BLPDDGCLNPE, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x8DEF6F0", Offset = "0x8DEE0F0", VA = "0x188DEF6F0")]
	private static Task<BDHPLICAJHI> OLEMEEIPGME(GPFLGLGCINI FGJGFPOECJN, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x8DEF630", Offset = "0x8DEE030", VA = "0x188DEF630")]
	[AsyncStateMachine(typeof(GCICCBFCKHO))]
	private static Task LDJKOBCAEPD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
internal struct LNMBLJFBOAB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct CELBPHPGOBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public LNMBLJFBOAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x8DE4FF0", Offset = "0x8DE39F0", VA = "0x188DE4FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x8DE5780", Offset = "0x8DE4180", VA = "0x188DE5780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class HGEACLFGMII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public HGEACLFGMII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x8DE9CA0", Offset = "0x8DE86A0", VA = "0x188DE9CA0")]
		internal object MMLFFECNEFN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private struct CBANFPLGHKG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		public LNMBLJFBOAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x8DE2C40", Offset = "0x8DE1640", VA = "0x188DE2C40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x8DE30C0", Offset = "0x8DE1AC0", VA = "0x188DE30C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068A")]
	private bool EPGKBFKIKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400068B")]
	private OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400068C")]
	private CHMOOPPGDGB NGALMEDAPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400068D")]
	private CancellationToken AHOMALKMHKK;

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x8DEFFA0", Offset = "0x8DEE9A0", VA = "0x188DEFFA0")]
	public static Task LGPAGIMAEBB(CHMOOPPGDGB NGALMEDAPGH, bool EPGKBFKIKGL, OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO, CancellationToken GPFLDACOAGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x8DEFD80", Offset = "0x8DEE780", VA = "0x188DEFD80")]
	[AsyncStateMachine(typeof(CELBPHPGOBD))]
	private Task AEOBHGFBIDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x8DEFE70", Offset = "0x8DEE870", VA = "0x188DEFE70")]
	[AsyncStateMachine(typeof(CBANFPLGHKG))]
	private Task BHPLFBECAEK(bool PGKONOJOANP, string GGEKNOFDIKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250")]
	private bool JHDCOMLHABH(bool EPGKBFKIKGL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
internal struct CFEOKEPHGJE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private struct PJJCHCLNBHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public CFEOKEPHGJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x8DF56C0", Offset = "0x8DF40C0", VA = "0x188DF56C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x8DF5B90", Offset = "0x8DF4590", VA = "0x188DF5B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private sealed class DHCPPJIHCKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public DHCPPJIHCKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x8DE68B0", Offset = "0x8DE52B0", VA = "0x188DE68B0")]
		internal object MMLFFECNEFN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private struct MJMJBBPNDAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		public CFEOKEPHGJE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x8DF0010", Offset = "0x8DEEA10", VA = "0x188DF0010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x8DF04A0", Offset = "0x8DEEEA0", VA = "0x188DF04A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400069D")]
	private OPIMFDCINMJ NNNHMDDIFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400069E")]
	private OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400069F")]
	private CHMOOPPGDGB NGALMEDAPGH;

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x8DE60C0", Offset = "0x8DE4AC0", VA = "0x188DE60C0")]
	public static Task<Scene> FAKHDHNCFDO(CHMOOPPGDGB NGALMEDAPGH, OPIMFDCINMJ FGOOBCGHEMF, OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x8DE5E70", Offset = "0x8DE4870", VA = "0x188DE5E70")]
	[AsyncStateMachine(typeof(PJJCHCLNBHI))]
	private Task<Scene> AEOBHGFBIDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x8DE5F80", Offset = "0x8DE4980", VA = "0x188DE5F80")]
	[AsyncStateMachine(typeof(MJMJBBPNDAA))]
	private Task<Scene> BHPLFBECAEK(string GGEKNOFDIKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
internal struct FBDFAKIBLGM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct HIOKCAGEKHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public AsyncTaskMethodBuilder<IBJAHKDFDAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public FBDFAKIBLGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public IBJAHKDFDAH nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public CMFAJILFAHI deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private TaskAwaiter<IBJAHKDFDAH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x8E03C20", Offset = "0x8E02620", VA = "0x188E03C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x8E046C0", Offset = "0x8E030C0", VA = "0x188E046C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct LPGFPBOABFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public AsyncTaskMethodBuilder<IBJAHKDFDAH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public FBDFAKIBLGM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public IBJAHKDFDAH state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private TaskAwaiter<BDHPLICAJHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x8E08DC0", Offset = "0x8E077C0", VA = "0x188E08DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x8E090A0", Offset = "0x8E07AA0", VA = "0x188E090A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006AC")]
	private readonly GPFLGLGCINI FGJGFPOECJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006AD")]
	private readonly MICBNHDLKLK BPOOOHOMDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006AE")]
	private readonly NLHMFGCDECP AGHECKBAHKE;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private ECHHAJDKEIH LBLJJNDELGO
	{
		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x718A2C0", Offset = "0x7188CC0", VA = "0x18718A2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x8DE8EA0", Offset = "0x8DE78A0", VA = "0x188DE8EA0")]
	public FBDFAKIBLGM(GPFLGLGCINI FGJGFPOECJN, MICBNHDLKLK BPOOOHOMDNA, NLHMFGCDECP AGHECKBAHKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x8DE8B70", Offset = "0x8DE7570", VA = "0x188DE8B70")]
	[AsyncStateMachine(typeof(HIOKCAGEKHI))]
	public Task<IBJAHKDFDAH> AEFAECDDKAP(IBJAHKDFDAH EINPBCKGCOF, CMFAJILFAHI GBIGFHHDIBP, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK, bool CHMKKLLCAKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x8DE8D40", Offset = "0x8DE7740", VA = "0x188DE8D40")]
	[AsyncStateMachine(typeof(LPGFPBOABFH))]
	private Task<IBJAHKDFDAH> KPOMGJAOCCM(OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, IBJAHKDFDAH IMNBLKDCAKA, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x8DE8D10", Offset = "0x8DE7710", VA = "0x188DE8D10")]
	private bool JHEIGJPFJKB(IBJAHKDFDAH PDONOIENMJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x8DE8CF0", Offset = "0x8DE76F0", VA = "0x188DE8CF0")]
	private void JAPFEIFECJM(string EDCCMILPHPE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000182")]
internal struct GOFDFKCDANN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private struct MAECIFBMNGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public ECHHAJDKEIH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public CMFAJILFAHI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public LNBIFKHOIBN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		private PDJKNFENBKE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		private List<(PersistenceView, LNEHPBAPDKG)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		private (PersistenceView, LNEHPBAPDKG) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x8E09110", Offset = "0x8E07B10", VA = "0x188E09110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x8E097E0", Offset = "0x8E081E0", VA = "0x188E097E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x8E021E0", Offset = "0x8E00BE0", VA = "0x188E021E0")]
	[AsyncStateMachine(typeof(MAECIFBMNGI))]
	public static Task AEOBHGFBIDI(ECHHAJDKEIH BEINHMMJKLL, CMFAJILFAHI BLPDDGCLNPE, LNBIFKHOIBN GHJGKOMBDCK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000184")]
internal struct MJEAFKBBALC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct NHNIGODBOCG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public ECHHAJDKEIH operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public CMFAJILFAHI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public LNBIFKHOIBN timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		private FPGEPAJMDDO <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		private PDJKNFENBKE <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		private List<(PersistenceView, LNEHPBAPDKG)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		private LNEHPBAPDKG <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x8E0A970", Offset = "0x8E09370", VA = "0x188E0A970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x8E0B250", Offset = "0x8E09C50", VA = "0x188E0B250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x8E0A410", Offset = "0x8E08E10", VA = "0x188E0A410")]
	[AsyncStateMachine(typeof(NHNIGODBOCG))]
	public static Task AEOBHGFBIDI(ECHHAJDKEIH BEINHMMJKLL, CMFAJILFAHI BLPDDGCLNPE, LNBIFKHOIBN GHJGKOMBDCK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
public struct HOAGJEEAEJJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private struct FNAKOIKDNGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public AsyncTaskMethodBuilder<FEENKEDBOAD<HIOHINJLKHL, EFLAGBIEFMN>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public HOAGJEEAEJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public CLFDOCGHGJD.OLKGGNOFGNE preloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private TaskAwaiter<FEENKEDBOAD<HIOHINJLKHL, EFLAGBIEFMN>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x8E006F0", Offset = "0x8DFF0F0", VA = "0x188E006F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x8E00D70", Offset = "0x8DFF770", VA = "0x188E00D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private long LFBPAOIPACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	private long BHDKJNLAOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	private Guid? KLNNJCOEOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private IReadOnlyCollection<LMBBLNHDLDK> EKKHEHFHGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006E0")]
	private IReadOnlyCollection<LMBBLNHDLDK> BBLNCAPIPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006E1")]
	private MHPEOFPNGND KEKCPLHIBBE;

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x8E04890", Offset = "0x8E03290", VA = "0x188E04890")]
	public static Task<FEENKEDBOAD<HIOHINJLKHL, EFLAGBIEFMN>> OAMEFFNIOOB(long GDCAPMONNDM, long GKOJBHIBFEI, HCJPDEFNHKL JJMEDKDNOPP, CLFDOCGHGJD.OLKGGNOFGNE CBMFCGOAADP, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x8E04730", Offset = "0x8E03130", VA = "0x188E04730")]
	[AsyncStateMachine(typeof(FNAKOIKDNGP))]
	private Task<FEENKEDBOAD<HIOHINJLKHL, EFLAGBIEFMN>> AEOBHGFBIDI(CLFDOCGHGJD.OLKGGNOFGNE CBMFCGOAADP, CancellationToken AHOMALKMHKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
internal struct BHOACLMPOID
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	public struct NHGBDEJAJBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		public List<MGNEPFHCMDN> NAANOHECHNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		public List<LNEHPBAPDKG> OBCEMPPPHCE;

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0xC64140", Offset = "0xC62B40", VA = "0x180C64140")]
		public NHGBDEJAJBN(List<MGNEPFHCMDN> NAANOHECHNL, List<LNEHPBAPDKG> OBCEMPPPHCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private sealed class JDNMPPAEKNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public IEnumerable<MGNEPFHCMDN> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public JDNMPPAEKNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x8E05F70", Offset = "0x8E04970", VA = "0x188E05F70")]
		internal object LLHFGPBOMON()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006E9")]
	private CHMOOPPGDGB NGALMEDAPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006EA")]
	private CMFAJILFAHI BLPDDGCLNPE;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private FFHNIMCCMFI BCDAFCHHCGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x8DFB940", Offset = "0x8DFA340", VA = "0x188DFB940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x8DFB0D0", Offset = "0x8DF9AD0", VA = "0x188DFB0D0")]
	public static NHGBDEJAJBN AEOBHGFBIDI(CHMOOPPGDGB NGALMEDAPGH, CMFAJILFAHI BLPDDGCLNPE)
	{
		return default(NHGBDEJAJBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x8DFB130", Offset = "0x8DF9B30", VA = "0x188DFB130")]
	private NHGBDEJAJBN AEOBHGFBIDI()
	{
		return default(NHGBDEJAJBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x8DFB390", Offset = "0x8DF9D90", VA = "0x188DFB390")]
	private NHGBDEJAJBN CGPDODGDDHE(EHIMHNJBHOL DOALKJIILIM, FPGEPAJMDDO ALMALDHDLIN)
	{
		return default(NHGBDEJAJBN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x8DFB990", Offset = "0x8DFA390", VA = "0x188DFB990")]
	private bool PJNDKECODHN(IEnumerable<MGNEPFHCMDN> NAANOHECHNL)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal struct ABHDAABEBHN
{
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class HAKNNNPDHKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public BHOACLMPOID.NHGBDEJAJBN instantiations;

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public HAKNNNPDHKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x8E02320", Offset = "0x8E00D20", VA = "0x188E02320")]
		internal object LJBDCCDHADC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private sealed class COMFOFMBAKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public COMFOFMBAKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x8DFDED0", Offset = "0x8DFC8D0", VA = "0x188DFDED0")]
		internal object OCBLADONBLK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x8DF9670", Offset = "0x8DF8070", VA = "0x188DF9670")]
	public static void AEOBHGFBIDI(ECHHAJDKEIH BEINHMMJKLL, CMFAJILFAHI BLPDDGCLNPE, BHOACLMPOID.NHGBDEJAJBN FOCCMIJOEOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
internal class NLHMFGCDECP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[CompilerGenerated]
	private struct LEIKNOAPOMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public NLHMFGCDECP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public IBJAHKDFDAH operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public CMFAJILFAHI deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x8E07A50", Offset = "0x8E06450", VA = "0x188E07A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x8E081C0", Offset = "0x8E06BC0", VA = "0x188E081C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private sealed class FNFKIHFJCJF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000191")]
		private struct <<RunAuthorityHandler>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006FF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000700")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000701")]
			public FNFKIHFJCJF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000702")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000703")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E4A0", Offset = "0x8E0CEA0", VA = "0x188E0E4A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E760", Offset = "0x8E0D160", VA = "0x188E0E760", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		public NLHMFGCDECP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		public CMFAJILFAHI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public FNFKIHFJCJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x8E00DE0", Offset = "0x8DFF7E0", VA = "0x188E00DE0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task DGGPANEMJBO(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private struct DCBAEIAJEHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public NLHMFGCDECP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public CMFAJILFAHI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		private FNFKIHFJCJF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x8DFE7A0", Offset = "0x8DFD1A0", VA = "0x188DFE7A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x8DFECD0", Offset = "0x8DFD6D0", VA = "0x188DFECD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private struct LOIKGKLFMJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		public NLHMFGCDECP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		public CMFAJILFAHI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		private Dictionary<Guid, List<JAEDGEODMNM>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x8E08750", Offset = "0x8E07150", VA = "0x188E08750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x8E08D60", Offset = "0x8E07760", VA = "0x188E08D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private struct JOGKOJAEELM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public NLHMFGCDECP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		public CMFAJILFAHI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		private Dictionary<Guid, List<JAEDGEODMNM>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x8E06300", Offset = "0x8E04D00", VA = "0x188E06300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x8E069A0", Offset = "0x8E053A0", VA = "0x188E069A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	private sealed class CHDCMPLGPJP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000196")]
		private struct <<InvokeMethodsInParallel>b__2>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000723")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000724")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000725")]
			public JAEDGEODMNM handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000726")]
			public CHDCMPLGPJP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000727")]
			private PDJKNFENBKE <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000728")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x8E0DFD0", Offset = "0x8E0C9D0", VA = "0x188E0DFD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067D")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E440", Offset = "0x8E0CE40", VA = "0x188E0E440", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public FPKAAOMAOJJ runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public List<JAEDGEODMNM> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		public CMFAJILFAHI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public CHDCMPLGPJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x8DFD8D0", Offset = "0x8DFC2D0", VA = "0x188DFD8D0")]
		internal object AHEEHHIJMMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x8DFD9C0", Offset = "0x8DFC3C0", VA = "0x188DFD9C0")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task CHDIBKIEFJD(JAEDGEODMNM handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x8DFDAC0", Offset = "0x8DFC4C0", VA = "0x188DFDAC0")]
		internal object IFDOOAHLMHF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private struct CECHGPMHLIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		public FPKAAOMAOJJ runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		public List<JAEDGEODMNM> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		public CMFAJILFAHI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		private CHDCMPLGPJP <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x8DFD3A0", Offset = "0x8DFBDA0", VA = "0x188DFD3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x8DFD870", Offset = "0x8DFC270", VA = "0x188DFD870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private struct OJKDOACIKFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		public NLHMFGCDECP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		public CMFAJILFAHI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400073A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		private Guid <handlerIdToRun>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x8E0D260", Offset = "0x8E0BC60", VA = "0x188E0D260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x8E0D820", Offset = "0x8E0C220", VA = "0x188E0D820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private sealed class DNGBPLCMJJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public DNGBPLCMJJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x8DFEFC0", Offset = "0x8DFD9C0", VA = "0x188DFEFC0")]
		internal object LLHGLKCBKCI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private struct ADCEMGPIPPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		public NLHMFGCDECP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		public CMFAJILFAHI data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x8DFA4A0", Offset = "0x8DF8EA0", VA = "0x188DFA4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x8DFA960", Offset = "0x8DF9360", VA = "0x188DFA960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[CompilerGenerated]
	private sealed class BOFBCIIAGIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public BOFBCIIAGIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x8DFC060", Offset = "0x8DFAA60", VA = "0x188DFC060")]
		internal object MLOBBAMJAMO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[CompilerGenerated]
	private struct DANLBJBPGPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		public NLHMFGCDECP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		private PDJKNFENBKE <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		private TaskAwaiter<BDHPLICAJHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x8DFE100", Offset = "0x8DFCB00", VA = "0x188DFE100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x8DFE740", Offset = "0x8DFD140", VA = "0x188DFE740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[CompilerGenerated]
	private sealed class EGPLILCBAFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public EGPLILCBAFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x8DFF030", Offset = "0x8DFDA30", VA = "0x188DFF030")]
		internal object ACKEKHMHPLA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F1")]
	private readonly GPFLGLGCINI FGJGFPOECJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006F2")]
	private FCDOBIBAEHG AGHECKBAHKE;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private ECHHAJDKEIH LBLJJNDELGO
	{
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x133C8B0", Offset = "0x133B2B0", VA = "0x18133C8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0xABA5E0", Offset = "0xAB8FE0", VA = "0x180ABA5E0")]
	public NLHMFGCDECP(GPFLGLGCINI FGJGFPOECJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x8E0B2B0", Offset = "0x8E09CB0", VA = "0x188E0B2B0")]
	[AsyncStateMachine(typeof(LEIKNOAPOMN))]
	public Task AEOBHGFBIDI(IBJAHKDFDAH OCEEJPIEMGJ, CMFAJILFAHI GBIGFHHDIBP, OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x8E0B520", Offset = "0x8E09F20", VA = "0x188E0B520")]
	[AsyncStateMachine(typeof(DCBAEIAJEHI))]
	private Task EKEFKLOHPFB(CMFAJILFAHI BLPDDGCLNPE, OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x8E0BCB0", Offset = "0x8E0A6B0", VA = "0x188E0BCB0")]
	[AsyncStateMachine(typeof(LOIKGKLFMJO))]
	private Task JDDCIGFBKAC(CMFAJILFAHI BLPDDGCLNPE, OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x8E0B660", Offset = "0x8E0A060", VA = "0x188E0B660")]
	[AsyncStateMachine(typeof(JOGKOJAEELM))]
	private Task GMKLPEKMOEK(CMFAJILFAHI BLPDDGCLNPE, OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x8E0BF60", Offset = "0x8E0A960", VA = "0x188E0BF60")]
	[AsyncStateMachine(typeof(CECHGPMHLIL))]
	private Task MACCODHDGPO(Guid LBEIKAOJNHB, List<JAEDGEODMNM> FKHMNKHICPL, FPKAAOMAOJJ LCEAAKMJPMM, CMFAJILFAHI BLPDDGCLNPE, CancellationToken MFKHKDDANII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x8E0C0B0", Offset = "0x8E0AAB0", VA = "0x188E0C0B0")]
	[AsyncStateMachine(typeof(OJKDOACIKFA))]
	private Task OEMKNMGGPLC(CMFAJILFAHI BLPDDGCLNPE, OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x8E0B7A0", Offset = "0x8E0A1A0", VA = "0x188E0B7A0")]
	[AsyncStateMachine(typeof(ADCEMGPIPPM))]
	private Task GNMANDGECAG(Guid OAJAOOIJEOM, CMFAJILFAHI BLPDDGCLNPE, OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x8E0B8E0", Offset = "0x8E0A2E0", VA = "0x188E0B8E0")]
	[AsyncStateMachine(typeof(DANLBJBPGPP))]
	private Task HGGJCHFKFPL(Guid OAJAOOIJEOM, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x8E0B400", Offset = "0x8E09E00", VA = "0x188E0B400")]
	private void EHDGCIAGKND(Guid OAJAOOIJEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x8E0BA20", Offset = "0x8E0A420", VA = "0x188E0BA20")]
	private void HHBADOGMPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x8E0BDF0", Offset = "0x8E0A7F0", VA = "0x188E0BDF0")]
	public Guid KOEPIKGKMGI(IBJAHKDFDAH MHKOKMLIBEL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x8E0BAD0", Offset = "0x8E0A4D0", VA = "0x188E0BAD0")]
	[CompilerGenerated]
	private object IGONFMPHIKD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
internal struct EHJHBDEOGBO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	[CompilerGenerated]
	private struct FFFDADODBLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		public EHJHBDEOGBO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		private IEnumerator<BAHMGECMGEB> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x8DFFCC0", Offset = "0x8DFE6C0", VA = "0x188DFFCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x8E00350", Offset = "0x8DFED50", VA = "0x188E00350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000751")]
	private FFHNIMCCMFI ADCMGLPBECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000752")]
	private OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000753")]
	private CancellationToken AHOMALKMHKK;

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x8DFF190", Offset = "0x8DFDB90", VA = "0x188DFF190")]
	public static Task EJIJLBAJPGI(FFHNIMCCMFI ADCMGLPBECA, OEEGBKAOPAE<string>.BANCHJBJHFK KIGHMIAOFFO, CancellationToken GPFLDACOAGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x8DFF0A0", Offset = "0x8DFDAA0", VA = "0x188DFF0A0")]
	[AsyncStateMachine(typeof(FFFDADODBLG))]
	private Task AEOBHGFBIDI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
public readonly struct CEGHBONCLIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400075A")]
	public readonly bool BCPABGJLJOH;

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x2DD8640", Offset = "0x2DD7040", VA = "0x182DD8640")]
	public CEGHBONCLIO(bool LDBNDOGGMOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public readonly struct DFPILBGDMFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400075B")]
	public readonly EHIMHNJBHOL? GMMPEKPPAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400075C")]
	public readonly PFPIICJOBLP GKFFHCHNGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400075D")]
	public readonly Guid? CFMLHNHKJFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400075E")]
	public readonly IReadOnlyList<Guid> JGLIEODEBGK;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public IReadOnlyCollection<string> NPHCIECCAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x8DFED50", Offset = "0x8DFD750", VA = "0x188DFED50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public IReadOnlyDictionary<long, int> JIFIMEOJKPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x8DFED30", Offset = "0x8DFD730", VA = "0x188DFED30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x8DFED70", Offset = "0x8DFD770", VA = "0x188DFED70")]
	public DFPILBGDMFF(EHIMHNJBHOL? KALMEDGIGPJ, PFPIICJOBLP MCOCEIFADHF, Guid? NDKPBPBIOMO, [Optional] IReadOnlyList<Guid>? AAFOEOLBMCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal class HEMJNFGDOOG : PDLFDHCLAOK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[CompilerGenerated]
	private struct LDHFBMHJCFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000763")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		public AsyncTaskMethodBuilder<DFPILBGDMFF> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		public HEMJNFGDOOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		public ALABEABJCDD serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public FJCNFCABHMI roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		private PersistenceView[] <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		private PDJKNFENBKE <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x8E07340", Offset = "0x8E05D40", VA = "0x188E07340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x8E079E0", Offset = "0x8E063E0", VA = "0x188E079E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private sealed class JOMLNCPFNFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		public float time;

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public JOMLNCPFNFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x8E06A00", Offset = "0x8E05400", VA = "0x188E06A00")]
		internal object LBNDPECCBEI()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private struct BOJBCGDOCNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		public HEMJNFGDOOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		public PersistenceView[] activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		public ALABEABJCDD serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		private JOMLNCPFNFI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		private PDJKNFENBKE <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		private CancellationTokenSource <cts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		private FMJHIDPKFMF<Task> <tasks>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x8DFC0D0", Offset = "0x8DFAAD0", VA = "0x188DFC0D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x8DFCB50", Offset = "0x8DFB550", VA = "0x188DFCB50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400075F")]
	private readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x4000760")]
	private static readonly TimeSpan DIHOILJKFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000761")]
	private readonly CMBMENCIDPI LCMHEMMCNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000762")]
	private readonly IIGPCDCLLKM LKNHCNJNLDD;

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x8E039F0", Offset = "0x8E023F0", VA = "0x188E039F0")]
	public HEMJNFGDOOG(GPFLGLGCINI FGJGFPOECJN, CMBMENCIDPI AGLPBMHGNLD, IIGPCDCLLKM LKNHCNJNLDD, OLFEOKKCIEG JHGFKLHHPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x8E02D50", Offset = "0x8E01750", VA = "0x188E02D50")]
	[AsyncStateMachine(typeof(LDHFBMHJCFD))]
	public Task<DFPILBGDMFF> GCGCKFHBJPB(long GKOJBHIBFEI, FJCNFCABHMI MNOCNJDBJHH, ALABEABJCDD LJLNONPCKJA, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x8E03890", Offset = "0x8E02290", VA = "0x188E03890")]
	private static bool NILMLJCIKCF(PersistenceView DMJMJBPOHHC, [Out] JHJIDMMLHBA IBIDAFEADHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x8E03590", Offset = "0x8E01F90", VA = "0x188E03590")]
	[AsyncStateMachine(typeof(BOJBCGDOCNL))]
	private Task JIBKJMCHBGO(ALABEABJCDD LJLNONPCKJA, PersistenceView[] LAJAKKFKIBO, StringBuilder GLHHBBCJBEL, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x8E02770", Offset = "0x8E01170", VA = "0x188E02770")]
	private DFPILBGDMFF FNMNFCINEIM(long GKOJBHIBFEI, FJCNFCABHMI MNOCNJDBJHH, ALABEABJCDD LJLNONPCKJA, IEnumerable<PersistenceView> LAJAKKFKIBO, StringBuilder GLHHBBCJBEL)
	{
		return default(DFPILBGDMFF);
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x8E036D0", Offset = "0x8E020D0", VA = "0x188E036D0")]
	private EHIMHNJBHOL LCKLMNKNKFL(long GKOJBHIBFEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x8E03340", Offset = "0x8E01D40", VA = "0x188E03340")]
	private void JDOBAACFDPK(EHIMHNJBHOL BBMPKPDDAMB, StringBuilder GLHHBBCJBEL, IEnumerable<PersistenceView> LAJAKKFKIBO, [In] LIBIHKAHBAL JPPEOEEHJOI, IAJJGFEHOPJ MCPEJKLCMHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x8E02EA0", Offset = "0x8E018A0", VA = "0x188E02EA0")]
	private void JBIJCDIPKJM(EHIMHNJBHOL BBMPKPDDAMB, StringBuilder GLHHBBCJBEL, PersistenceView DMJMJBPOHHC, IAJJGFEHOPJ MCPEJKLCMHG, [In] LIBIHKAHBAL JPPEOEEHJOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
internal class IJGANLFOGKM : PDLFDHCLAOK
{
	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[CompilerGenerated]
	private sealed class AAGPCACCIJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400077F")]
		public MEBOLGOEOBG.PMPBIGFEPGB roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public AAGPCACCIJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x8DF9620", Offset = "0x8DF8020", VA = "0x188DF9620")]
		internal object JBNFDGKCDHJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	private struct IHFPNJPIBBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public AsyncTaskMethodBuilder<(MEBOLGOEOBG.PMPBIGFEPGB roomDataUpload, MEBOLGOEOBG.PMPBIGFEPGB subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public DFPILBGDMFF roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		public FFHNIMCCMFI callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		private AAGPCACCIJD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		private TaskAwaiter<MEBOLGOEOBG.PMPBIGFEPGB> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x8E04A80", Offset = "0x8E03480", VA = "0x188E04A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x8E05300", Offset = "0x8E03D00", VA = "0x188E05300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private struct JHBEPGEIDGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		public AsyncTaskMethodBuilder<PPJEADMNHEK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		public IJGANLFOGKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		public GKJAGFBLLKC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public DFPILBGDMFF roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		private TaskAwaiter<PPJEADMNHEK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x8E05FF0", Offset = "0x8E049F0", VA = "0x188E05FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x8E06290", Offset = "0x8E04C90", VA = "0x188E06290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[CompilerGenerated]
	private struct PBCGMEEAPMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		public AsyncTaskMethodBuilder<PPJEADMNHEK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		public FFHNIMCCMFI callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		public DFPILBGDMFF roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public MECHFNNEEII ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		public GKJAGFBLLKC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		private TaskAwaiter<(MEBOLGOEOBG.PMPBIGFEPGB roomDataUpload, MEBOLGOEOBG.PMPBIGFEPGB subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		private TaskAwaiter<PPJEADMNHEK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x8E0D900", Offset = "0x8E0C300", VA = "0x188E0D900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x8E0DF60", Offset = "0x8E0C960", VA = "0x188E0DF60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private struct LFHDNLANPKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400079D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400079E")]
		public AsyncTaskMethodBuilder<ICFDNHEACPK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400079F")]
		public IJGANLFOGKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007A0")]
		public DFPILBGDMFF roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007A1")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007A2")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		private TaskAwaiter<(MEBOLGOEOBG.PMPBIGFEPGB roomDataUpload, MEBOLGOEOBG.PMPBIGFEPGB subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		private TaskAwaiter<ICFDNHEACPK> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x8E08220", Offset = "0x8E06C20", VA = "0x188E08220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x8E086E0", Offset = "0x8E070E0", VA = "0x188E086E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AE")]
	[CompilerGenerated]
	private sealed class MKADJEBGDGI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001AF")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007AF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007B0")]
			public AsyncTaskMethodBuilder<BDHPLICAJHI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007B1")]
			public MKADJEBGDGI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007B2")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007B3")]
			private BDHPLICAJHI <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007B4")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007B5")]
			private TaskAwaiter<ICFDNHEACPK> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007B6")]
			private TaskAwaiter<PPJEADMNHEK> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007B7")]
			private TaskAwaiter<BDHPLICAJHI> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006BF")]
			[Cpp2IlInjected.Address(RVA = "0x8E0E7C0", Offset = "0x8E0D1C0", VA = "0x188E0E7C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C0")]
			[Cpp2IlInjected.Address(RVA = "0x8E0F9D0", Offset = "0x8E0E3D0", VA = "0x188E0F9D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		public IJGANLFOGKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		public DFPILBGDMFF roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007AC")]
		public GKJAGFBLLKC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		public CEGHBONCLIO roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007AE")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public MKADJEBGDGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x8E0A550", Offset = "0x8E08F50", VA = "0x188E0A550")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<BDHPLICAJHI> AEJGPJPOEGE(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B0")]
	[CompilerGenerated]
	private struct HEADPDGBEEB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007B9")]
		public AsyncTaskMethodBuilder<BDHPLICAJHI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007BA")]
		public IJGANLFOGKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		public DFPILBGDMFF roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		public GKJAGFBLLKC roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		public CEGHBONCLIO roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007C3")]
		private TaskAwaiter<BDHPLICAJHI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x8E023D0", Offset = "0x8E00DD0", VA = "0x188E023D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x8E02700", Offset = "0x8E01100", VA = "0x188E02700", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400077C")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x400077D")]
	private static readonly OLFEOKKCIEG HPIJLNODOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400077E")]
	private readonly PAAMJEMAEPM OEJCPOGJBCD;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private CHMOOPPGDGB CFOCDEKJEAC
	{
		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x8DD1F50", Offset = "0x8DD0950", VA = "0x188DD1F50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x8E05EE0", Offset = "0x8E048E0", VA = "0x188E05EE0")]
	public IJGANLFOGKM(GPFLGLGCINI FGJGFPOECJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x8E05370", Offset = "0x8E03D70", VA = "0x188E05370")]
	[AsyncStateMachine(typeof(IHFPNJPIBBF))]
	private static Task<(MEBOLGOEOBG.PMPBIGFEPGB, MEBOLGOEOBG.PMPBIGFEPGB)> DABODAILGFC(FFHNIMCCMFI ADCMGLPBECA, DFPILBGDMFF BPIOIEAKAAD, long GDCAPMONNDM, long FMNCJOBEOEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x8E05980", Offset = "0x8E04380", VA = "0x188E05980")]
	[AsyncStateMachine(typeof(JHBEPGEIDGM))]
	public Task<PPJEADMNHEK> PABLEPKOKJJ(int BHLHMOKBKOA, [CanBeNull] GKJAGFBLLKC FGDEENNPCPP, DFPILBGDMFF BPIOIEAKAAD, long GDCAPMONNDM, long FMNCJOBEOEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x8E05AF0", Offset = "0x8E044F0", VA = "0x188E05AF0")]
	public static Task<PPJEADMNHEK> PABLEPKOKJJ(FFHNIMCCMFI ADCMGLPBECA, int BHLHMOKBKOA, [CanBeNull] GKJAGFBLLKC FGDEENNPCPP, DFPILBGDMFF BPIOIEAKAAD, long GDCAPMONNDM, long FMNCJOBEOEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x8E057F0", Offset = "0x8E041F0", VA = "0x188E057F0")]
	[AsyncStateMachine(typeof(PBCGMEEAPMM))]
	public static Task<PPJEADMNHEK> PABLEPKOKJJ(FFHNIMCCMFI ADCMGLPBECA, int BHLHMOKBKOA, [CanBeNull] GKJAGFBLLKC FGDEENNPCPP, DFPILBGDMFF BPIOIEAKAAD, long GDCAPMONNDM, long FMNCJOBEOEF, MECHFNNEEII HGCPMGBOOMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x8E054C0", Offset = "0x8E03EC0", VA = "0x188E054C0")]
	[AsyncStateMachine(typeof(LFHDNLANPKA))]
	private Task<ICFDNHEACPK> IPBLFAONCPI(string OBPOKNPEGFF, int BHLHMOKBKOA, DFPILBGDMFF BPIOIEAKAAD, long GDCAPMONNDM, long FMNCJOBEOEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x8E05640", Offset = "0x8E04040", VA = "0x188E05640")]
	[AsyncStateMachine(typeof(HEADPDGBEEB))]
	public Task<BDHPLICAJHI> OEOMGEHKKJM(int BHLHMOKBKOA, GKJAGFBLLKC? FGDEENNPCPP, DFPILBGDMFF BPIOIEAKAAD, long GDCAPMONNDM, long FMNCJOBEOEF, CEGHBONCLIO ENJEABHDIIM, OEEGBKAOPAE<string>.BANCHJBJHFK FCJPPPKIGAK, CancellationToken AHOMALKMHKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public abstract class MMOIMMPEJHC<T> where T : MMOIMMPEJHC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C4")]
	internal readonly CHMOOPPGDGB IOJMFMFOABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C5")]
	private int? AAPIKGHGGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C6")]
	protected readonly Guid KEPMKLLAMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C7")]
	protected readonly BIHFGJAHICO PLONEKIHHFM;

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	protected T OLMINBDOCBB
	{
		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x59F1D00", Offset = "0x59F0700", VA = "0x1859F1D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x59F2080", Offset = "0x59F0A80", VA = "0x1859F2080")]
	internal MMOIMMPEJHC(CHMOOPPGDGB MOCHAOFKNGO, BIHFGJAHICO EJLDBIEEPEK, [Optional] Guid? CHBBGPKOFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x59F1F10", Offset = "0x59F0910", VA = "0x1859F1F10")]
	private BDHPLICAJHI IGINOEKHAHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	protected virtual void OJMMLOFLMJF(BDHPLICAJHI JEBOHIALEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x59F1E80", Offset = "0x59F0880", VA = "0x1859F1E80")]
	public T HOCNOLENLNA(FNAEIBBBBBE NBPOBGMPFAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x59F1FF0", Offset = "0x59F09F0", VA = "0x1859F1FF0")]
	public T PPIJMACOEHB(int DGKJHKNBBLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x59F1D60", Offset = "0x59F0760", VA = "0x1859F1D60", Slot = "5")]
	public virtual Task<PLLAKKIDGFG> BNJKNMENJGB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
public class DABENGHLNMG : MMOIMMPEJHC<DABENGHLNMG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007C8")]
	private CCNAABFFCED IHHGLEDNONA;

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x8DFE030", Offset = "0x8DFCA30", VA = "0x188DFE030")]
	internal DABENGHLNMG(CHMOOPPGDGB MOCHAOFKNGO, BIHFGJAHICO EJLDBIEEPEK, [Optional] Guid? CHBBGPKOFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x7F5DF70", Offset = "0x7F5C970", VA = "0x187F5DF70")]
	public DABENGHLNMG GEGLJFAAKBB(CCNAABFFCED IHHGLEDNONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x8DFDF60", Offset = "0x8DFC960", VA = "0x188DFDF60", Slot = "4")]
	protected override void OJMMLOFLMJF(BDHPLICAJHI JEBOHIALEMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
public class KOGLONMCCJJ : MMOIMMPEJHC<KOGLONMCCJJ>
{
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	internal enum HMDBOIKICAC
	{
		[Cpp2IlInjected.Token(Token = "0x40007CD")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40007CE")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40007CF")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B5")]
	[CompilerGenerated]
	private struct KIOIPMBCDLG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		public AsyncTaskMethodBuilder<PLLAKKIDGFG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		public KOGLONMCCJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		private TaskAwaiter<PLLAKKIDGFG> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x8E06A70", Offset = "0x8E05470", VA = "0x188E06A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x8E06E20", Offset = "0x8E05820", VA = "0x188E06E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007C9")]
	private HMDBOIKICAC EHGAKCMLHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40007CA")]
	private string DFKKDPAEJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40007CB")]
	private GKJAGFBLLKC IHHGLEDNONA;

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x8E071D0", Offset = "0x8E05BD0", VA = "0x188E071D0")]
	internal KOGLONMCCJJ(CHMOOPPGDGB MOCHAOFKNGO, BIHFGJAHICO EJLDBIEEPEK, [Optional] Guid? CHBBGPKOFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x8E06FE0", Offset = "0x8E059E0", VA = "0x188E06FE0")]
	public KOGLONMCCJJ OFKJOCGLKII(string GDFPOPIGPDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x8E07180", Offset = "0x8E05B80", VA = "0x188E07180")]
	public KOGLONMCCJJ PACOKNLLMEA(bool KMEGAIOAPCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x8E06FC0", Offset = "0x8E059C0", VA = "0x188E06FC0")]
	public KOGLONMCCJJ NKKGOMEAMFE(bool LENMIEOMALI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x8E071A0", Offset = "0x8E05BA0", VA = "0x188E071A0")]
	public KOGLONMCCJJ PMNIICNMJKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x8E07010", Offset = "0x8E05A10", VA = "0x188E07010", Slot = "4")]
	protected override void OJMMLOFLMJF(BDHPLICAJHI JEBOHIALEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x8E06E90", Offset = "0x8E05890", VA = "0x188E06E90", Slot = "5")]
	[AsyncStateMachine(typeof(KIOIPMBCDLG))]
	public override Task<PLLAKKIDGFG> BNJKNMENJGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x8E06F80", Offset = "0x8E05980", VA = "0x188E06F80")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<PLLAKKIDGFG> GMHPEMPPAMH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
internal static class HGKEBAHJNEF
{
	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x8E03A50", Offset = "0x8E02450", VA = "0x188E03A50")]
	public static void CHNBAIEJKJC(this KNIBMCLIMEI JIKNENFBGGO, IAOKBCEAMNP MEKACEMHKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0x8E03BA0", Offset = "0x8E025A0", VA = "0x188E03BA0")]
	public static void PHILJAOAOBN(this IAOKBCEAMNP EOJGKDJALHE, [Optional] string JEBOHIALEMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B7")]
public static class DNFLAIIIFNH
{
	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x8DFEE70", Offset = "0x8DFD870", VA = "0x188DFEE70")]
	public static APAFHBPABPH ECLNMFOEJBE(this GLCKKGCDAIJ AIGLMGBKCKH)
	{
		return default(APAFHBPABPH);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x8DFEF10", Offset = "0x8DFD910", VA = "0x188DFEF10")]
	public static GLCKKGCDAIJ EODHPMPEJPL(this APAFHBPABPH LGCPKGOEGOJ)
	{
		return null;
	}
}
namespace RecRoom.RoomLoading.RoomOperation.Validation
{
	[Cpp2IlInjected.Token(Token = "0x20001B8")]
	public class ValidationResultConfig : ScriptableObject, ISerializationCallbackReceiver
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20001B9")]
		public class ResultConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007D8")]
			public CAIEKIDAKIA ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007D9")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007DA")]
			public CAIEKIDAKIA HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007DB")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007DC")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007DD")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60006E1")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		private static CAIEKIDAKIA[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		private Dictionary<CAIEKIDAKIA, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x8E0FFF0", Offset = "0x8E0E9F0", VA = "0x188E0FFF0")]
		public bool DKKNPBBMEPP(CAIEKIDAKIA APBMLPKMHGD, [Out] ResultConfig OINEAODAACF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x8E10060", Offset = "0x8E0EA60", VA = "0x188E10060")]
		public ResultConfig LNBFCDDJHMC(CAIEKIDAKIA LJPPNNLHGCJ, [Optional] HashSet<CAIEKIDAKIA> MCOLPCBFIIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x8E10700", Offset = "0x8E0F100", VA = "0x188E10700", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x8E101A0", Offset = "0x8E0EBA0", VA = "0x188E101A0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xD5D430", Offset = "0xD5BE30", VA = "0x180D5D430")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
public class FJOIDBANJHP : CLPEKHGCOFA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	[CompilerGenerated]
	private struct NFEFPDMCNML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		public FJOIDBANJHP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x8E0A680", Offset = "0x8E09080", VA = "0x188E0A680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x8E0A910", Offset = "0x8E09310", VA = "0x188E0A910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BD")]
	[CompilerGenerated]
	private struct BHPIFEJIKIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007ED")]
		public OEEGBKAOPAE<string>.BANCHJBJHFK timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007EE")]
		public CLPEKHGCOFA preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		private OEEGBKAOPAE<string>.BANCHJBJHFK <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007F1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x8DFBB60", Offset = "0x8DFA560", VA = "0x188DFBB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x8DFC000", Offset = "0x8DFAA00", VA = "0x188DFC000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007E3")]
	private readonly CEJABLEPNMI KBMPONLELBJ;

	[Cpp2IlInjected.Token(Token = "0x40007E4")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public string EBNDKCGFHDK
	{
		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x8E004C0", Offset = "0x8DFEEC0", VA = "0x188E004C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x8E00610", Offset = "0x8DFF010", VA = "0x188E00610")]
	[DMKNBLIJJON.EGFDFBOLNDK.IOMGPCDPIJG]
	internal static void NJIHGMBMMOP(JBJKIIKOACK ALFOGEOKGPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0xABA5E0", Offset = "0xAB8FE0", VA = "0x180ABA5E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public FJOIDBANJHP([BMCONCJPCIA(null)] CEJABLEPNMI KBMPONLELBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x8E003B0", Offset = "0x8DFEDB0", VA = "0x188E003B0", Slot = "5")]
	[AsyncStateMachine(typeof(NFEFPDMCNML))]
	public Task AEOBHGFBIDI(OEEGBKAOPAE<string>.BANCHJBJHFK IPOALAHOCJI, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x8E004F0", Offset = "0x8DFEEF0", VA = "0x188E004F0")]
	[AsyncStateMachine(typeof(BHPIFEJIKIJ))]
	private Task FFBOIHBAFOI(CLPEKHGCOFA MDJBCPALBAB, OEEGBKAOPAE<string>.BANCHJBJHFK IPOALAHOCJI, CancellationToken AHOMALKMHKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
public interface CEJABLEPNMI : CLPEKHGCOFA
{
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
public interface CLPEKHGCOFA
{
	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	string EBNDKCGFHDK
	{
		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AEOBHGFBIDI(OEEGBKAOPAE<string>.BANCHJBJHFK IPOALAHOCJI, CancellationToken AHOMALKMHKK);
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
public static class OBBJOGINHPK
{
	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x8E0C1F0", Offset = "0x8E0ABF0", VA = "0x188E0C1F0")]
	[DMKNBLIJJON.EGFDFBOLNDK.IOMGPCDPIJG]
	internal static void CCKCOACOBKL(JBJKIIKOACK ALFOGEOKGPO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C1")]
public interface BNELGABNKPE : IEquatable<BNELGABNKPE>
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	DateTime BFFHHIOEDCP
	{
		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFIIMJBGPLC();

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GPJBDLGMKMI(long GDCAPMONNDM, long GKOJBHIBFEI, [Out] DFPILBGDMFF BPIOIEAKAAD);
}
[Cpp2IlInjected.Token(Token = "0x20001C2")]
internal class MHMMFKBFKDD : GAKDHGEKIJL
{
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[CompilerGenerated]
	private sealed class BFFGMEIGOFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F4")]
		public EPNIDEGAFGC autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F5")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public BFFGMEIGOFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x8DFB060", Offset = "0x8DF9A60", VA = "0x188DFB060")]
		internal object LNKMMILLJJN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F2")]
	private readonly MAGJJHMLGJP FCBKPKPJDGB;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<BNELGABNKPE> IBCADCGLAFE
	{
		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x8E09D90", Offset = "0x8E08790", VA = "0x188E09D90", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x8E0A1F0", Offset = "0x8E08BF0", VA = "0x188E0A1F0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0xABA5E0", Offset = "0xAB8FE0", VA = "0x180ABA5E0")]
	[UnityEngine.Scripting.Preserve]
	public MHMMFKBFKDD([BMCONCJPCIA(null)] MAGJJHMLGJP FCBKPKPJDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x8E09E40", Offset = "0x8E08840", VA = "0x188E09E40", Slot = "6")]
	public bool KJMLJIEAALE(long GDCAPMONNDM, long GKOJBHIBFEI, DFPILBGDMFF BPIOIEAKAAD, EPNIDEGAFGC LDBMMHGJBOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0xF812A0", Offset = "0xF7FCA0", VA = "0x180F812A0")]
	private void CNNMDFNPFCC(BNELGABNKPE PCGILFJIDOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x8E0A2A0", Offset = "0x8E08CA0", VA = "0x188E0A2A0", Slot = "7")]
	public bool PCDGPENHBPN(long GDCAPMONNDM, long GKOJBHIBFEI, [Out] BNELGABNKPE MGJEEBCIHJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x8E0A140", Offset = "0x8E08B40", VA = "0x188E0A140", Slot = "8")]
	public bool LHPLILBDHCE(long GDCAPMONNDM, long GKOJBHIBFEI, EPNIDEGAFGC LDBMMHGJBOG, [Out] BNELGABNKPE MGJEEBCIHJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x8E09840", Offset = "0x8E08240", VA = "0x188E09840")]
	private void CHJKAPFMLJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x8E09C70", Offset = "0x8E08670", VA = "0x188E09C70", Slot = "9")]
	public void GJBCEFMPOLC(long GDCAPMONNDM, long GKOJBHIBFEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C5")]
internal abstract class EOKJKINANFD : MAGJJHMLGJP
{
	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	protected enum IAFACPKMFAO : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40007FA")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40007FB")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	[CompilerGenerated]
	private sealed class BPNIDNDNBOL : IEnumerable<BNELGABNKPE>, IEnumerable, IEnumerator<BNELGABNKPE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007FC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007FD")]
		private BNELGABNKPE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007FE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007FF")]
		public EOKJKINANFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000800")]
		private EPNIDEGAFGC autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000801")]
		public EPNIDEGAFGC <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000802")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000803")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		private BNELGABNKPE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000718")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0xBE39C0", Offset = "0xBE23C0", VA = "0x180BE39C0")]
		[DebuggerHidden]
		public BPNIDNDNBOL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x8DFCBB0", Offset = "0x8DFB5B0", VA = "0x188DFCBB0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x8DFCE90", Offset = "0x8DFB890", VA = "0x188DFCE90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x8DFCDE0", Offset = "0x8DFB7E0", VA = "0x188DFCDE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BNELGABNKPE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x8DFCDE0", Offset = "0x8DFB7E0", VA = "0x188DFCDE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	[CompilerGenerated]
	private sealed class AHKJBBKPBEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000804")]
		public EPNIDEGAFGC autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000805")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public AHKJBBKPBEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x8DFAFC0", Offset = "0x8DF99C0", VA = "0x188DFAFC0")]
		internal object IEDFGDADGEK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C9")]
	[CompilerGenerated]
	private sealed class OLIFBPNOIFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000806")]
		public EOKJKINANFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000807")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public OLIFBPNOIFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x8E0D880", Offset = "0x8E0C280", VA = "0x188E0D880")]
		internal void NFNCJJLIDCD(ACCPGKCGCPP.GHIODAGHICF ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F8")]
	private readonly object NACHIHOLBGF;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	protected string HHKCIMHBCKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x8DFFB30", Offset = "0x8DFE530", VA = "0x188DFFB30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public abstract CFOJJDFDNMD NNJEJPBPLCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x8DFFC40", Offset = "0x8DFE640", VA = "0x188DFFC40")]
	protected EOKJKINANFD([CanBeNull] string INGPGEAFOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x8DFF580", Offset = "0x8DFDF80", VA = "0x188DFF580", Slot = "5")]
	public bool CPAFAJGJLNM(long GDCAPMONNDM, long GKOJBHIBFEI, EPNIDEGAFGC LDBMMHGJBOG, [Out] BNELGABNKPE PCGILFJIDOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x8DFFB40", Offset = "0x8DFE540", VA = "0x188DFFB40", Slot = "6")]
	[IteratorStateMachine(typeof(BPNIDNDNBOL))]
	public IEnumerable<BNELGABNKPE> KPCBHOAOMLE(EPNIDEGAFGC LDBMMHGJBOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void DOACJCJHJLE(Stream ACKPAJLLGJM, long GDCAPMONNDM, long GKOJBHIBFEI, DFPILBGDMFF BPIOIEAKAAD);

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool AKHNBFGKEGD(Stream FKCLMCADJBJ, long GDCAPMONNDM, long GKOJBHIBFEI, BKMNADDLFOM FAFODHAJOMM, [Out] DFPILBGDMFF BPIOIEAKAAD);

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x8DFF200", Offset = "0x8DFDC00", VA = "0x188DFF200", Slot = "7")]
	public BNELGABNKPE BKMFCLHCGLC(long GDCAPMONNDM, long GKOJBHIBFEI, DFPILBGDMFF BPIOIEAKAAD, EPNIDEGAFGC LDBMMHGJBOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo CNAMAJDICPE(long GDCAPMONNDM, long GKOJBHIBFEI, EPNIDEGAFGC LDBMMHGJBOG, IAFACPKMFAO MLHLEGDDHNI);

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo BACANDKBKAC(EPNIDEGAFGC LDBMMHGJBOG, IAFACPKMFAO MLHLEGDDHNI);

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x8DFFBD0", Offset = "0x8DFE5D0", VA = "0x188DFFBD0")]
	protected void MGAAIMKJGKJ(ACCPGKCGCPP.GHIODAGHICF DCFKDKGDEKO, string EDCCMILPHPE, FileInfo ANDDNFJKBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x8DFF770", Offset = "0x8DFE170", VA = "0x188DFF770")]
	internal bool HGLOHGCKPMH(FileInfo ONAAJAJLPPO, long GDCAPMONNDM, long GKOJBHIBFEI, [Out] DFPILBGDMFF BPIOIEAKAAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
	private void FBCPAJIHBCJ(Exception FGDPOGPHENJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CA")]
internal class OIFMINGMHPG : EOKJKINANFD
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public override CFOJJDFDNMD NNJEJPBPLCD
	{
		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x155F0B0", Offset = "0x155DAB0", VA = "0x18155F0B0", Slot = "8")]
		get
		{
			return default(CFOJJDFDNMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x8E0D220", Offset = "0x8E0BC20", VA = "0x188E0D220")]
	public OIFMINGMHPG([Optional] string INGPGEAFOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x8E0D1A0", Offset = "0x8E0BBA0", VA = "0x188E0D1A0")]
	private void IKBFIIPLIGF(EPNIDEGAFGC LDBMMHGJBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x8E0CEF0", Offset = "0x8E0B8F0", VA = "0x188E0CEF0", Slot = "9")]
	internal override void DOACJCJHJLE(Stream ACKPAJLLGJM, long GDCAPMONNDM, long GKOJBHIBFEI, DFPILBGDMFF BPIOIEAKAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x8E0C600", Offset = "0x8E0B000", VA = "0x188E0C600", Slot = "10")]
	internal override bool AKHNBFGKEGD(Stream FKCLMCADJBJ, long GDCAPMONNDM, long GKOJBHIBFEI, BKMNADDLFOM FAFODHAJOMM, [Out] DFPILBGDMFF BPIOIEAKAAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x8E0CE00", Offset = "0x8E0B800", VA = "0x188E0CE00", Slot = "11")]
	protected override FileInfo CNAMAJDICPE(long GDCAPMONNDM, long GKOJBHIBFEI, EPNIDEGAFGC LDBMMHGJBOG, IAFACPKMFAO MLHLEGDDHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x8E0CD00", Offset = "0x8E0B700", VA = "0x188E0CD00", Slot = "12")]
	protected override DirectoryInfo BACANDKBKAC(EPNIDEGAFGC LDBMMHGJBOG, IAFACPKMFAO MLHLEGDDHNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CB")]
internal sealed class GJGPCLKMAIL : EOKJKINANFD
{
	[Cpp2IlInjected.Token(Token = "0x4000808")]
	private static readonly byte[] HPFHOBCPNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000809")]
	private readonly byte[] BMPGJCDIIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400080A")]
	private readonly byte[] FMPDNONCHFC;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public override CFOJJDFDNMD NNJEJPBPLCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x1B0E130", Offset = "0x1B0CB30", VA = "0x181B0E130", Slot = "8")]
		get
		{
			return default(CFOJJDFDNMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x8E020F0", Offset = "0x8E00AF0", VA = "0x188E020F0")]
	public GJGPCLKMAIL([Optional] string INGPGEAFOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x8E01B80", Offset = "0x8E00580", VA = "0x188E01B80", Slot = "9")]
	internal override void DOACJCJHJLE(Stream ACKPAJLLGJM, long GDCAPMONNDM, long GKOJBHIBFEI, DFPILBGDMFF BPIOIEAKAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x8E00ED0", Offset = "0x8DFF8D0", VA = "0x188E00ED0", Slot = "10")]
	internal override bool AKHNBFGKEGD(Stream FKCLMCADJBJ, long GDCAPMONNDM, long GKOJBHIBFEI, BKMNADDLFOM FAFODHAJOMM, [Out] DFPILBGDMFF BPIOIEAKAAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x8E01FA0", Offset = "0x8E009A0", VA = "0x188E01FA0")]
	private void HHMJBHOCNNM(byte[] BNICMFHPCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x8E01A50", Offset = "0x8E00450", VA = "0x188E01A50", Slot = "11")]
	protected override FileInfo CNAMAJDICPE(long GDCAPMONNDM, long GKOJBHIBFEI, EPNIDEGAFGC LDBMMHGJBOG, IAFACPKMFAO MLHLEGDDHNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x8E01940", Offset = "0x8E00340", VA = "0x188E01940", Slot = "12")]
	protected override DirectoryInfo BACANDKBKAC(EPNIDEGAFGC LDBMMHGJBOG, IAFACPKMFAO MLHLEGDDHNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
public enum CFOJJDFDNMD : byte
{
	[Cpp2IlInjected.Token(Token = "0x400080E")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x400080F")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000810")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001CE")]
internal class ABMHLFKKNKB : MAGJJHMLGJP
{
	[Cpp2IlInjected.Token(Token = "0x20001D0")]
	[CompilerGenerated]
	private sealed class CAFOINNNFDI : IEnumerable<BNELGABNKPE>, IEnumerable, IEnumerator<BNELGABNKPE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000817")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000818")]
		private BNELGABNKPE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000819")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400081A")]
		public ABMHLFKKNKB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400081B")]
		private EPNIDEGAFGC autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400081C")]
		public EPNIDEGAFGC <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400081D")]
		private CFOJJDFDNMD[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400081E")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400081F")]
		private IEnumerator<BNELGABNKPE> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		private BNELGABNKPE System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0xBE39C0", Offset = "0xBE23C0", VA = "0x180BE39C0")]
		[DebuggerHidden]
		public CAFOINNNFDI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0x8DFD310", Offset = "0x8DFBD10", VA = "0x188DFD310", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x8DFCF30", Offset = "0x8DFB930", VA = "0x188DFCF30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x8DFCEE0", Offset = "0x8DFB8E0", VA = "0x188DFCEE0")]
		private void LLDKJPCFHKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x8DFD2C0", Offset = "0x8DFBCC0", VA = "0x188DFD2C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x8DFD210", Offset = "0x8DFBC10", VA = "0x188DFD210", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<BNELGABNKPE> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x8DFD210", Offset = "0x8DFBC10", VA = "0x188DFD210", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000811")]
	private readonly CFOJJDFDNMD[] DIFHAMPJHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000812")]
	private readonly Dictionary<CFOJJDFDNMD, MAGJJHMLGJP> MPMKMEOKBCF;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public CFOJJDFDNMD NNJEJPBPLCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x8DFA090", Offset = "0x8DF8A90", VA = "0x188DFA090", Slot = "4")]
		get
		{
			return default(CFOJJDFDNMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x8DFA150", Offset = "0x8DF8B50", VA = "0x188DFA150")]
	[UnityEngine.Scripting.Preserve]
	public ABMHLFKKNKB(params MAGJJHMLGJP[] ALJJBCADFGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x8DF9D10", Offset = "0x8DF8710", VA = "0x188DF9D10", Slot = "5")]
	public bool CPAFAJGJLNM(long GDCAPMONNDM, long GKOJBHIBFEI, EPNIDEGAFGC LDBMMHGJBOG, [Out] BNELGABNKPE PCGILFJIDOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x8DF9E60", Offset = "0x8DF8860", VA = "0x188DF9E60")]
	private void JCLKKIDGBEF(int KHECEIDFOHD, long GDCAPMONNDM, long GKOJBHIBFEI, EPNIDEGAFGC LDBMMHGJBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x8DFA0C0", Offset = "0x8DF8AC0", VA = "0x188DFA0C0", Slot = "6")]
	[IteratorStateMachine(typeof(CAFOINNNFDI))]
	public IEnumerable<BNELGABNKPE> KPCBHOAOMLE(EPNIDEGAFGC LDBMMHGJBOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x8DF9C20", Offset = "0x8DF8620", VA = "0x188DF9C20", Slot = "7")]
	public BNELGABNKPE BKMFCLHCGLC(long GDCAPMONNDM, long GKOJBHIBFEI, DFPILBGDMFF BPIOIEAKAAD, EPNIDEGAFGC LDBMMHGJBOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
internal static class CHHILMAHHDI
{
	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x8DFDE10", Offset = "0x8DFC810", VA = "0x188DFDE10")]
	internal static byte[] NOFMJPGAEDP(byte[] BNICMFHPCJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000746")]
	[Cpp2IlInjected.Address(RVA = "0x8DFDD90", Offset = "0x8DFC790", VA = "0x188DFDD90")]
	public static void KEPKFAMDNEM(Stream GDDPDAOPHDP, byte[] KPGGAPFAHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x8DFDBB0", Offset = "0x8DFC5B0", VA = "0x188DFDBB0")]
	public static bool DMFKHNNEBOF(Stream GDDPDAOPHDP, long KEMHNJLANAK, BKMNADDLFOM GCBPOELDLJL, [Out] byte[] EMHJONFAAIH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
internal sealed class AHHHKGPGKGO : BNELGABNKPE, IEquatable<BNELGABNKPE>, IEquatable<AHHHKGPGKGO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000820")]
	private readonly EOKJKINANFD OIOLCBLJLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000821")]
	public readonly FileInfo EOOELHGHFDG;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public CFOJJDFDNMD NNJEJPBPLCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x864ECB0", Offset = "0x864D6B0", VA = "0x18864ECB0", Slot = "9")]
		get
		{
			return default(CFOJJDFDNMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public DateTime BFFHHIOEDCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x8DFAA80", Offset = "0x8DF9480", VA = "0x188DFAA80", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x8DFAEB0", Offset = "0x8DF98B0", VA = "0x188DFAEB0")]
	public AHHHKGPGKGO(EOKJKINANFD FBHILFJJMCI, FileInfo ONAAJAJLPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x8DFAE00", Offset = "0x8DF9800", VA = "0x188DFAE00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0x8DFA9C0", Offset = "0x8DF93C0", VA = "0x188DFA9C0", Slot = "5")]
	public void AFIIMJBGPLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x8DFAD30", Offset = "0x8DF9730", VA = "0x188DFAD30", Slot = "6")]
	public bool GPJBDLGMKMI(long GDCAPMONNDM, long GKOJBHIBFEI, [Out] DFPILBGDMFF BPIOIEAKAAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x8DFAB10", Offset = "0x8DF9510", VA = "0x188DFAB10", Slot = "7")]
	public bool Equals(BNELGABNKPE GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074F")]
	[Cpp2IlInjected.Address(RVA = "0x8DFAB80", Offset = "0x8DF9580", VA = "0x188DFAB80", Slot = "8")]
	public bool Equals(AHHHKGPGKGO GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x8DFAC40", Offset = "0x8DF9640", VA = "0x188DFAC40", Slot = "0")]
	public override bool Equals(object PMNHIPACJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x8DFAD70", Offset = "0x8DF9770", VA = "0x188DFAD70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
public delegate void BKMNADDLFOM(ACCPGKCGCPP.GHIODAGHICF NOECBGAFMDN, string JEBOHIALEMJ);
[Cpp2IlInjected.Token(Token = "0x20001D4")]
internal interface MAGJJHMLGJP
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	CFOJJDFDNMD NNJEJPBPLCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CPAFAJGJLNM(long GDCAPMONNDM, long GKOJBHIBFEI, EPNIDEGAFGC LDBMMHGJBOG, [Out] BNELGABNKPE PCGILFJIDOP);

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<BNELGABNKPE> KPCBHOAOMLE(EPNIDEGAFGC LDBMMHGJBOG);

	[Cpp2IlInjected.Token(Token = "0x6000757")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BNELGABNKPE BKMFCLHCGLC(long GDCAPMONNDM, long GKOJBHIBFEI, DFPILBGDMFF BPIOIEAKAAD, EPNIDEGAFGC LDBMMHGJBOG);
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
