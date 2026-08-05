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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B47910", Offset = "0x8B46D10", VA = "0x188B47910")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
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
		[Cpp2IlInjected.Address(RVA = "0xA99B40", Offset = "0xA98F40", VA = "0x180A99B40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class NOFPNMHOLJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal Task<FNBLNBOMKEN> IFHNLDBLOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal Task IHIFBDFBKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal EPEDKBIKHMJ KEEFPHMCAHD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public NOFPNMHOLJE()
	{
	}
}
namespace _LogRegistration.RecRoom_RoomLoading_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : FIPEGIMCDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8B43830", Offset = "0x8B42C30", VA = "0x188B43830", Slot = "4")]
		public override void AAGBOPIEMBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B4C320", Offset = "0x8B4B720", VA = "0x188B4C320", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x291FE80", Offset = "0x291F280", VA = "0x18291FE80")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MGONJMKHHDC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8B44DB0", Offset = "0x8B441B0", VA = "0x188B44DB0")]
	public MGONJMKHHDC(string AFDNIPHJHMO, Exception DNFKLOFLLMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal class HCGDKEBEKJC : AHLLMKACEPJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct CJNCMPHCGHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<IReadOnlyList<CDHHINAEKFG>> <>t__builder;

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
		private TaskAwaiter<BECCMHPNPFI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8B2DDD0", Offset = "0x8B2D1D0", VA = "0x188B2DDD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8B2E010", Offset = "0x8B2D410", VA = "0x188B2E010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct OMHEHFKOMGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public AsyncTaskMethodBuilder<IReadOnlyList<MECDIPCLLLE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public IReadOnlyList<int> accountIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private TaskAwaiter<List<MECDIPCLLLE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8B48320", Offset = "0x8B47720", VA = "0x188B48320", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8B48530", Offset = "0x8B47930", VA = "0x188B48530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	[UnityEngine.Scripting.Preserve]
	public HCGDKEBEKJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8B33C50", Offset = "0x8B33050", VA = "0x188B33C50", Slot = "4")]
	[AsyncStateMachine(typeof(CJNCMPHCGHH))]
	public Task<IReadOnlyList<CDHHINAEKFG>> IDOHOMCODAK(long DCONEHIDLCB, long OBCIDCBDAAN, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8B33B40", Offset = "0x8B32F40", VA = "0x188B33B40", Slot = "5")]
	[AsyncStateMachine(typeof(OMHEHFKOMGJ))]
	public Task<IReadOnlyList<MECDIPCLLLE>> DHNEECMHFLF(IReadOnlyList<int> COIIJJPDABO, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OFBGKEMJEHN : IEquatable<OFBGKEMJEHN>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int DAODLLDHNOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	[CanBeNull]
	MECDIPCLLLE EHBMGIFJKFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	DateTime IFFFGLDAOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	BHKAGDNLKEG? CNJKCMLAICF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	EKHLHFMOIJD? LHJNKIJJKDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	[CanBeNull]
	IFAGABDBOOK AIHNMIDLDON
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<LALFMHKAHCO> BKPAKIHIHPK();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum IFAGABDBOOK
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Current,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	RecNetSave,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	DiskAutosave
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AHLLMKACEPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<IReadOnlyList<CDHHINAEKFG>> IDOHOMCODAK(long DCONEHIDLCB, long OBCIDCBDAAN, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<IReadOnlyList<MECDIPCLLLE>> DHNEECMHFLF(IReadOnlyList<int> COIIJJPDABO, [Optional] CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class MLGEGNEEDNP
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class OAEFGEEOKIB : OFBGKEMJEHN, IEquatable<OFBGKEMJEHN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct FMGOICJPADJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AsyncTaskMethodBuilder<LALFMHKAHCO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public OAEFGEEOKIB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private BOKALKOMIFP <roomManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private TaskAwaiter<MBLNIACGJFP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private TaskAwaiter<LALFMHKAHCO> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8B32850", Offset = "0x8B31C50", VA = "0x188B32850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8B32DD0", Offset = "0x8B321D0", VA = "0x188B32DD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly CDHHINAEKFG IDOHCGHDPEH;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int DAODLLDHNOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public MECDIPCLLLE EHBMGIFJKFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private DateTime IIKHEABELIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8B47C20", Offset = "0x8B47020", VA = "0x188B47C20", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public BHKAGDNLKEG? CNJKCMLAICF
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2D1FAF0", Offset = "0x2D1EEF0", VA = "0x182D1FAF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public EKHLHFMOIJD? LHJNKIJJKDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8B47C00", Offset = "0x8B47000", VA = "0x188B47C00", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public IFAGABDBOOK AIHNMIDLDON
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xC11DD0", Offset = "0xC111D0", VA = "0x180C11DD0", Slot = "10")]
			get
			{
				return default(IFAGABDBOOK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8B479D0", Offset = "0x8B46DD0", VA = "0x188B479D0", Slot = "9")]
		[AsyncStateMachine(typeof(FMGOICJPADJ))]
		public Task<LALFMHKAHCO> BKPAKIHIHPK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8B47CC0", Offset = "0x8B470C0", VA = "0x188B47CC0")]
		public OAEFGEEOKIB(int LGKOCKLMFCF, MECDIPCLLLE DOBHIKEOMOO, CDHHINAEKFG IDOHCGHDPEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8B47AD0", Offset = "0x8B46ED0", VA = "0x188B47AD0", Slot = "11")]
		public bool Equals(OFBGKEMJEHN LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8B47B60", Offset = "0x8B46F60", VA = "0x188B47B60", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8B47990", Offset = "0x8B46D90", VA = "0x188B47990")]
		private bool BJKGGHKCIMP(OAEFGEEOKIB LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8B47C40", Offset = "0x8B47040", VA = "0x188B47C40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private sealed class LINNOHCKBNN : OFBGKEMJEHN, IEquatable<OFBGKEMJEHN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct PPBJNDNAFOE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public AsyncTaskMethodBuilder<LALFMHKAHCO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public LINNOHCKBNN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private TaskAwaiter<LALFMHKAHCO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8B4B070", Offset = "0x8B4A470", VA = "0x188B4B070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8B4B2C0", Offset = "0x8B4A6C0", VA = "0x188B4B2C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly HOAPKCGDNIL DFHBNHIDCLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly BHKAGDNLKEG KLGOGGJAFBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly EKHLHFMOIJD MBEKBLAHLHD;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int DAODLLDHNOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8B435A0", Offset = "0x8B429A0", VA = "0x188B435A0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public MECDIPCLLLE EHBMGIFJKFM
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8B43700", Offset = "0x8B42B00", VA = "0x188B43700", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private DateTime IIKHEABELIO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8B43630", Offset = "0x8B42A30", VA = "0x188B43630", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public BHKAGDNLKEG? CNJKCMLAICF
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8B43790", Offset = "0x8B42B90", VA = "0x188B43790", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public EKHLHFMOIJD? LHJNKIJJKDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8B435E0", Offset = "0x8B429E0", VA = "0x188B435E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public IFAGABDBOOK AIHNMIDLDON
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAC93A0", Offset = "0xAC87A0", VA = "0x180AC93A0", Slot = "10")]
			get
			{
				return default(IFAGABDBOOK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x21277B0", Offset = "0x2126BB0", VA = "0x1821277B0")]
		public LINNOHCKBNN(HOAPKCGDNIL PGGNJLGKBOA, BHKAGDNLKEG KDPOCPGFCKC, EKHLHFMOIJD DMJKLAPEOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8B43360", Offset = "0x8B42760", VA = "0x188B43360", Slot = "9")]
		[AsyncStateMachine(typeof(PPBJNDNAFOE))]
		public Task<LALFMHKAHCO> BKPAKIHIHPK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8B43450", Offset = "0x8B42850", VA = "0x188B43450", Slot = "11")]
		public bool Equals(OFBGKEMJEHN LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8B434F0", Offset = "0x8B428F0", VA = "0x188B434F0", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8B43300", Offset = "0x8B42700", VA = "0x188B43300")]
		private bool BJKGGHKCIMP(LINNOHCKBNN LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8B43680", Offset = "0x8B42A80", VA = "0x188B43680", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	private sealed class FPGCBCEOILB : OFBGKEMJEHN, IEquatable<OFBGKEMJEHN>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private struct HEEGDDJHNAB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public AsyncTaskMethodBuilder<LALFMHKAHCO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter<LALFMHKAHCO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x8B33D70", Offset = "0x8B33170", VA = "0x188B33D70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8B33FD0", Offset = "0x8B333D0", VA = "0x188B33FD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly MECDIPCLLLE CNLJPBHBPOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly BHKAGDNLKEG KLGOGGJAFBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly EKHLHFMOIJD MBEKBLAHLHD;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int DAODLLDHNOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8B330E0", Offset = "0x8B324E0", VA = "0x188B330E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		[NotNull]
		public MECDIPCLLLE EHBMGIFJKFM
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private DateTime IIKHEABELIO
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "6")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public BHKAGDNLKEG? CNJKCMLAICF
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8B331E0", Offset = "0x8B325E0", VA = "0x188B331E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public EKHLHFMOIJD? LHJNKIJJKDF
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8B33100", Offset = "0x8B32500", VA = "0x188B33100", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public IFAGABDBOOK AIHNMIDLDON
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED80", Offset = "0xA6E180", VA = "0x180A6ED80", Slot = "10")]
			get
			{
				return default(IFAGABDBOOK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x21277B0", Offset = "0x2126BB0", VA = "0x1821277B0")]
		public FPGCBCEOILB(MECDIPCLLLE DOBHIKEOMOO, BHKAGDNLKEG KDPOCPGFCKC, EKHLHFMOIJD DMJKLAPEOOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8B32F20", Offset = "0x8B32320", VA = "0x188B32F20", Slot = "9")]
		[AsyncStateMachine(typeof(HEEGDDJHNAB))]
		public Task<LALFMHKAHCO> BKPAKIHIHPK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8B33070", Offset = "0x8B32470", VA = "0x188B33070", Slot = "11")]
		public bool Equals(OFBGKEMJEHN LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8B32FF0", Offset = "0x8B323F0", VA = "0x188B32FF0", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8B33150", Offset = "0x8B32550", VA = "0x188B33150", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8B32E40", Offset = "0x8B32240", VA = "0x188B32E40")]
		private bool BJKGGHKCIMP(FPGCBCEOILB LHDOHAKINKP)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct PGEEFFKJMIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<IList<OFBGKEMJEHN>> <>t__builder;

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
		public MLGEGNEEDNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private (long roomId, long subroomId) <cacheKey>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private IReadOnlyList<CDHHINAEKFG> <saveHistory>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<IReadOnlyList<CDHHINAEKFG>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<IReadOnlyList<(int accountId, MECDIPCLLLE account, CDHHINAEKFG roomDataSaveDto)>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8B4A170", Offset = "0x8B49570", VA = "0x188B4A170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B000", Offset = "0x8B4A400", VA = "0x188B4B000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	private struct BOMDBGGOADM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public AsyncTaskMethodBuilder<IReadOnlyList<(int accountId, MECDIPCLLLE account, CDHHINAEKFG roomDataSaveDto)>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public IReadOnlyList<CDHHINAEKFG> history;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public MLGEGNEEDNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<IReadOnlyList<MECDIPCLLLE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8B2D360", Offset = "0x8B2C760", VA = "0x188B2D360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8B2DD60", Offset = "0x8B2D160", VA = "0x188B2DD60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private readonly NADJFCAAKAN EPHAPKMICAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly AHLLMKACEPJ PHOKGHOJPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly BHFDIHOAMAC GGPJCPEJLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly OGIIDNDKACI<(long, long), IReadOnlyList<CDHHINAEKFG>> DCLCJGBKLDB;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8B46A30", Offset = "0x8B45E30", VA = "0x188B46A30")]
	[UnityEngine.Scripting.Preserve]
	public MLGEGNEEDNP([PKIHAALFADL(null)] AHLLMKACEPJ AMAAPCCDDBM, [PKIHAALFADL(null)] BHFDIHOAMAC GGGMLJCEMEC, [PKIHAALFADL(null)] NADJFCAAKAN ICHNMPMJPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x8B468E0", Offset = "0x8B45CE0", VA = "0x188B468E0")]
	[AsyncStateMachine(typeof(PGEEFFKJMIK))]
	public Task<IList<OFBGKEMJEHN>> NEDIJNDNHEN(long DCONEHIDLCB, long JLNBCNHEKAJ, bool CHKJFDOHCPE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x8B46740", Offset = "0x8B45B40", VA = "0x188B46740")]
	private bool FMEGEMOBGLD(DateTime? PKGGFOOKJMC, long DCONEHIDLCB, long JLNBCNHEKAJ, [Out] HOAPKCGDNIL NNKOPAHIOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8B46630", Offset = "0x8B45A30", VA = "0x188B46630")]
	[AsyncStateMachine(typeof(BOMDBGGOADM))]
	private Task<IReadOnlyList<(int, MECDIPCLLLE, CDHHINAEKFG)>> EBIFMJFPBPC(IReadOnlyList<CDHHINAEKFG> NKOIJALAGPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface BHFDIHOAMAC
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<HOAPKCGDNIL> BNBNFDLOANH;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PMLNFMBEAKA(long DCONEHIDLCB, long JLNBCNHEKAJ, NCAEELCEENN GLJDKFPIHIE, GFFNCJJHNKA PLJIHINALMN);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MBNBGHMAEBB(long DCONEHIDLCB, long JLNBCNHEKAJ, [Out] HOAPKCGDNIL NNKOPAHIOCN);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OGNNOGJEGKP(long DCONEHIDLCB, long JLNBCNHEKAJ, GFFNCJJHNKA PLJIHINALMN, [Out] HOAPKCGDNIL NNKOPAHIOCN);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EAKDOKLFGID(long DCONEHIDLCB, long JLNBCNHEKAJ);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
internal interface OHGELLMBBCH : EHHOJPPJJPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool GJCGGGJCNDM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	Task PEPMIHIAOHK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PBOFOCCKJMO(Task KDHFABGBLNO, string MCOGNDCLNGP);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal interface BIKNNKNKKNG : EHHOJPPJJPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LALFMHKAHCO> PEOMPONBMFF(HOAPKCGDNIL NNKOPAHIOCN);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AKJFFFINGPA(CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
internal interface GAHEGOGCHOL : EHHOJPPJJPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	KHKGOPFBEOO LHINHCOPEGL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DECEBGCIMKB();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DMEMJCICEFH();
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal interface EHHOJPPJJPL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJOFCLDPLJB(JNGEBJCPLIA IDEPICHODDC);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
internal interface OGFKANFAGPF
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	TimeSpan JIAPNGJLNKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	TimeSpan OKFMOAGHBGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	TimeSpan DHAHGGFIICG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	TimeSpan LJAFDGCGPHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool JKBOHCFNCOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool LJOIDJHFJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool DLBHFCCBKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	int EECBCEHAMFB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool GHPKFNGIMOK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool GOHCBPBLMCL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool GNKGPPIJJNM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum AHHNMFFPNAG
{
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Load,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	SaveAndReload,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	Reload
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum ECCPAABCJNI
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
public struct NBKAILCGOBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly long LFNOOICHMCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly long OBCIDCBDAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly AHHNMFFPNAG IIHAKBEOLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[CanBeNull]
	public readonly Exception DOGOPGFOKJD;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8B46BB0", Offset = "0x8B45FB0", VA = "0x188B46BB0")]
	public NBKAILCGOBA(long LFNOOICHMCA, long OBCIDCBDAAN, AHHNMFFPNAG IIHAKBEOLJD, [CanBeNull] Exception DOGOPGFOKJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8B46B60", Offset = "0x8B45F60", VA = "0x188B46B60")]
	public static NBKAILCGOBA HBEHBGIAPLO(AAKDENBOOJG FAFACGPEAHB, AHHNMFFPNAG IIHAKBEOLJD, [Optional] Exception DOGOPGFOKJD)
	{
		return default(NBKAILCGOBA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void EIPCGJEPLHG(NBKAILCGOBA KKPBBNLOJBJ);
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal interface IJPBCNJCDLL : EHHOJPPJJPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event EIPCGJEPLHG EPJOKBIDHIJ;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event EIPCGJEPLHG DHNGCEGJFGH;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event EIPCGJEPLHG KLABIGGBJDM;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<ECCPAABCJNI, bool> LKJKDDJPEFP;

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DEKOKKPJIHH(NBKAILCGOBA KKPBBNLOJBJ);

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HJIJBBKCLJM(NBKAILCGOBA KKPBBNLOJBJ);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JKBCFGMCOJM(NBKAILCGOBA KKPBBNLOJBJ);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OOOBEFMEMLJ(ECCPAABCJNI MPPPMJJKDDE, bool DLGALHBKJDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal interface CNFMKMLJBNK : EHHOJPPJJPL, IDisposable, PEKCJHOIPJA
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	bool EIKPNGDGNCB
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GAGLFJFGGLG();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal interface PJPBKECLNGI : EHHOJPPJJPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	TaskStatus EBPGGHOMDMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task ALDKHNJMJME(AAKDENBOOJG EDHCJOGBCNG, GOFJAADJDOP OEBIGJLGLNB, CancellationToken NILMHHOPMOB);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class KHCLLBNHNEE
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8B41B00", Offset = "0x8B40F00", VA = "0x188B41B00")]
	public static bool ICKNEOFNNEA(this PJPBKECLNGI GPEHJJBHHLE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public delegate Task KJCCMEEKOGD(CancellationToken MONGIMOHLAO, int FNJHLEOJHLA, JPNNICBILFM FLDGFFCOMHI);
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal interface LLMBDMOEJHN : EHHOJPPJJPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KLEKKPCEPLE(KJCCMEEKOGD DEEAABMNOFC);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal interface JNGEBJCPLIA : BOKALKOMIFP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	CancellationToken FIIOFEMHJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	JFAGCPCLAAF JMFDOLCFICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	CFAOIDGAGLN DCBDPIDPKED
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	GJDFEKLPFLO CGPMFDINPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	IJIEICICPPB JDGMIPEIBAC
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	BGMGFHJNNDK JKKJFMCJMOA
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	NEPJNHOBGFK OPGDJIFHHNB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	GCFCNBPHIEF DFJELNHPMPC
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	EOLAJDKNPJP IBAIKLAIIPL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	OHGELLMBBCH CAJPICHFLPB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	BIKNNKNKKNG FOKPJDBIANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	IJPBCNJCDLL IAEJJHJMCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	CNFMKMLJBNK INKLAOHDHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	PJPBKECLNGI AIDDBIGHDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	LLMBDMOEJHN POMPNDIDHKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	AOMCGKJFJCA NNIHMPFOGLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	DJEPMJOLNDO MNIDDBPEIBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	MPJEHHCGJLJ GCONCFCDHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	COPIACBMJOB HKLGNFMOELB
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	DDFIJAHBHAB CCDFMJDJBPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	EAEHMHEANPP JCMEJOPFCPF
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	MJCJEEMHPAL KBHPDGLGDKH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	NDHMFLFGHJI MNFFFOEKAPI
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	NGCHDLFDNLO ACOOHAJFDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	ONEHEKMMKIA PLMGMEPOKPP
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	GAHEGOGCHOL EJBENFIBAJB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	OGFKANFAGPF GLDKAJEHDBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	JPLOJOIMKCI JHGHHBIMJHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	BHFDIHOAMAC DBGCBKAKFEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	AMBHINONLEP FDJPBFOBPFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	LBKIPKPPCBG DMLAMLJHCIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "30")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	LCGKHGAPJOB EGLOIGDAHGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	OGJJOHIHALN LDCDPIICGFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "32")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	new bool ELCFGPIFFAF
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
	void ANBJBGJINCL(GOFJAADJDOP CGDGPFJJODE);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal interface AOMCGKJFJCA : EHHOJPPJJPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IENGDNGCKLK KOBMLIBBKBO(Guid PADGMLDAJOI);

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CBDHBFLGDII(Guid PADGMLDAJOI);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LIMIHNPAIHA(Guid PADGMLDAJOI, Task JFLMKLJIJJG);

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BGEHJHLHFGD(Guid PADGMLDAJOI, LALFMHKAHCO AOOGPOBPMKD);

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<(LALFMHKAHCO, Task)> PEGJMCLFKNL(Guid PADGMLDAJOI);
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal interface KFBFGIMCKBO : EHHOJPPJJPL, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal interface DJEPMJOLNDO : EHHOJPPJJPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIMPPFDBDFB(HNBAHPJPPAI AFDNIPHJHMO);

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JBHBFNCNNIF(HNBAHPJPPAI AFDNIPHJHMO);

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<HFLIPKNADKN> FHKFCENCKFH(CancellationToken IPACAKKFECM);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal interface MPJEHHCGJLJ : EHHOJPPJJPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IENGDNGCKLK DNMMBHAOIJA(HNBAHPJPPAI LIMIIADGKHF);

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GONAHKMGACL(Guid PADGMLDAJOI, Task JFLMKLJIJJG);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal interface COPIACBMJOB : EHHOJPPJJPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<LALFMHKAHCO> HKLGNFMOELB(HNBAHPJPPAI OJDCKMAPLCP);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal interface DDFIJAHBHAB : EHHOJPPJJPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<BGMNPHKELEH> KDDODOKPLJA(CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, AAKDENBOOJG EDHCJOGBCNG, CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
internal interface MJCJEEMHPAL : EHHOJPPJJPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LALFMHKAHCO ABLMCEMBKLA(NELIJLIGAOD DCBNPLECEOJ);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task AICOFOPPKDG(string GADMOJMIIGI);
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
internal interface EAEHMHEANPP : EHHOJPPJJPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<HNBAHPJPPAI> DALCFCIFGEJ(HNBAHPJPPAI IDLJGJGIGEG, BHMBHHAEFLE EOHIGEJFENG, CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<HNBAHPJPPAI> GKNBCCLLLHJ(CancellationToken GMKBGHHNCDJ, BHMBHHAEFLE EOHIGEJFENG);

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NFGCOFFCAHB CIDMOHECIBO(KKGNFEOCIOB KLEMEDAIFBB, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NFGCOFFCAHB BCJLJAGEGNL(KKGNFEOCIOB KLEMEDAIFBB, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
internal interface NDHMFLFGHJI : EHHOJPPJJPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LALFMHKAHCO PFKCKOBAJKI(NELIJLIGAOD DCBNPLECEOJ, HFLIPKNADKN DILMGLJEHEN);

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LALFMHKAHCO EBOHNEABPLN(NELIJLIGAOD KHKEJCOHPIB);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface MDHHAEAKDCE
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	const int AHBIGMOOGBK = 1000;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	IReadOnlyDictionary<Guid, DGMJNFMJCAE> GLEAMAONNKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	Action KEHKBGEPDMC
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
	IReadOnlyList<Guid> JHBNODKJPCF();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task APNJNEFIFMH([Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task GHDAMFLABAB([Optional] CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface NGCHDLFDNLO
{
	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KAOMFFECDCK(OCNGNNCGAPE LKDFKIEHNFA);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EHFMIOLDDJM(OCNGNNCGAPE LKDFKIEHNFA);

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EGHICDJKHOG(OCNGNNCGAPE LKDFKIEHNFA);

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BCHPFDLFPNB(OCNGNNCGAPE LKDFKIEHNFA);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class OCNGNNCGAPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly AAKDENBOOJG MMKJANAKKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private Dictionary<string, string> NLEGNFLOPMN;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public CIIMOEPMPCG<string> NHLBHBENHMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	public OCNGNNCGAPE(AAKDENBOOJG BAGPMCPHKKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x8B47DB0", Offset = "0x8B471B0", VA = "0x188B47DB0")]
	public OCNGNNCGAPE PKCHFMPNPPO(string PEENICAIFOP, string CBMEHPPMEEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x8B47D20", Offset = "0x8B47120", VA = "0x188B47D20")]
	public bool HNFHIFBCJCN([Out] IEnumerable<KeyValuePair<string, string>> FMLEAKPIIFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7A1BAA0", Offset = "0x7A1AEA0", VA = "0x187A1BAA0")]
	public OCNGNNCGAPE BNCMENGFPGC(CIIMOEPMPCG<string> LLOEFCNKADN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface JPLOJOIMKCI
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	bool ODENLKPNLED
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	string ELALPGCENBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	bool BDCFJEBDCPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CECOLIHHNMN();

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	AGJEILLLEMO DEPNGNNBNNA(long DAKBFKLMPGD);

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	JMEMOINNBPH<APAGCNALJKL, MNNMLCEECEP> PMIAPPEMMOH(long DAKBFKLMPGD);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	JMEMOINNBPH<APAGCNALJKL, LCCHGCBPFIP> GMLEOMMKIBG(long DAKBFKLMPGD);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JMEMOINNBPH<long, GFFFBNOEAPJ> IEOABPOMDCJ();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task<IReadOnlyCollection<NCDNOPDHNPA>> PKLMAAKENJM(long DAKBFKLMPGD, IReadOnlyCollection<NCDNOPDHNPA> GOJEJPFGBKG, CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool EGCCNGLKIDJ(long DAKBFKLMPGD, [Out] bool MIBKOFLBHCM);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task<bool> IBLOLKJEFJI(byte[] PNHJPDOBEAP, byte[] IAOLPELEMJE, IReadOnlyCollection<Guid> PGAMNOFCLGP, CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface CMJHPNLKEGN
{
	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BGMNPHKELEH CEOONNIFPHP(long LFNOOICHMCA, long OBCIDCBDAAN, string CKLCBBHHKPN);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	BGMNPHKELEH CEOONNIFPHP(long LFNOOICHMCA, long OBCIDCBDAAN, APAGCNALJKL PNHJPDOBEAP, Guid? BGDOGACKFOG, long DEMDBAHMNFM, bool HEOKPBILMDA);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BGMNPHKELEH CEOONNIFPHP(LFHDKPIJJCJ MOOIEGMHBKC);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BGMNPHKELEH CEOONNIFPHP(MBLNIACGJFP HJMEIFOPKEJ, CDHHINAEKFG LBONFDONBLB);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface BOKALKOMIFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	bool ICKNEOFNNEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	bool PHBIBBGLDEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	bool ELCFGPIFFAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	CMJHPNLKEGN GKOEDHCFNGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	GOFJAADJDOP BIAJCCNEFOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event EIPCGJEPLHG EPJOKBIDHIJ;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event EIPCGJEPLHG DHNGCEGJFGH;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event EIPCGJEPLHG KLABIGGBJDM;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action<ECCPAABCJNI, bool> LKJKDDJPEFP;

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GAGLFJFGGLG();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "12")]
	PJDLMHFKGND GOGIOOBKIPJ();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "13")]
	KEPELKDMLJM EGNMPCMPIOG();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "15")]
	Task OKIBFCLAMEJ(int IIIICGCPFGI, NAODMFNDKAH MMMALGMIIMN, Func<NCAEELCEENN, NCAEELCEENN> NBPDBOJPCGN);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task<LALFMHKAHCO> PEOMPONBMFF(HOAPKCGDNIL PGGNJLGKBOA);

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Task AKJFFFINGPA(CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface BGMGFHJNNDK
{
	[Cpp2IlInjected.Token(Token = "0x17000056")]
	bool DCKILFFIPPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	bool DJKFGDKIAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	Guid? KLNHEKGEIHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CGIJIAOLHED(Scene BDDNKHNKLOO);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task OGMJOGLCLFG(MOFDHGDONHK KOKNAKCPIEI, IReadOnlyList<MOFDHGDONHK> DGOOCACECNL, IReadOnlyList<MOFDHGDONHK> PDNKOAIDHMH, CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FGNBHCHLHON(Guid GCDGOJIGOMN, IReadOnlyList<Guid> PGAMNOFCLGP, JKBGGMHHGAL EMHOEJODAGO, [Optional] object JDHJAHGHOJG);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task DBACGFDMJMO(IReadOnlyList<Guid> PFHLGOECKHK, CancellationToken FMNFPPMCJII);

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HBEOILABBHN CJDALIBAOLM();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task CFOEHPPGLNH();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EBIAKCEPING(GameObject MLLLHKPDMHN);

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Task LALJIBEDFIF();
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface IJIEICICPPB
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	CJGDJMIKAIC MJABACAOHLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	bool NNDMGJPLDAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	bool KFBCIHHNLIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	bool CLKMCCLINMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	bool CIGKKFGHBEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	int EDKGFDDFMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	bool FICPEIIDOFM
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "50")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	bool FOBDAKGJANM
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "58")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	int LKGPAAGDCKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	int DHCKCACBEKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	bool HJOLGGCJDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "61")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool AFEJDBNNEMO
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "66")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool GJMGAOHPIPB
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "67")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	float KFALMPJOMLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "70")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<float> PAKLFOCMCKF;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JFAGCPCLAAF JBMKNHKOCCA(JFAGCPCLAAF PCAICDKGOID);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EALNGKEKAEB(JFAGCPCLAAF MNCIANLLPKI);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PKMBBAMAMCI();

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task PCIBLADGNBP(CIIMOEPMPCG<string>.MOMGGNPHIKH KDNDKEIKJMG, CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FGIBEPFGDOP(float JFGJNLEONKB);

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HINJFNDMKDA(string OGMPNBFOIII);

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IReadOnlyList<HGKAPEFBFIF> IDCEGKILIJG();

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(Slot = "9")]
	IDisposable FONAAHJJLFA(object HFJHENFIDEF, HGKAPEFBFIF IGJIAOCAHMB);

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(Slot = "10")]
	IReadOnlyList<KOIEILAHJPM> GGHABHDMLJI();

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(Slot = "11")]
	MNNMLCEECEP ACCKEEIMFLK(IEnumerable<MGLJJACBNLF> DIGJPFPJOCB);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void DBMGBAAEIHP(int AINAMMEFIOC);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Task OANACEAFOEP();

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void KADFMDNJJAD();

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool LOBCKFGOAHE();

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(Slot = "19")]
	Task BDDJDABFGCM(CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task NDJOOHEAFAL(CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task<LDEGPMKIHEM> IGJLMJELCKO(DateTime PAMNPMJNMLM, CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "22")]
	Task<bool> NAAALMCJCGO(CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void FOCCGIIKCPB(string AFDNIPHJHMO = "", float DLCLIHPGOLF = 3f);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "25")]
	JJDEBGOFHIM AFJDILENNKE(EPBLMMCONNB PJFNIKNLLIE, GHPJALIENGD JNHJNCKBLMG, LCCHGCBPFIP HFNMCHEPFHM, IEnumerable<PersistenceView> PIPIKOBIFPK, LCJMAJINLIB MEGOKKDPNEE);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void JPILFAAFLNE(LCCHGCBPFIP HFNMCHEPFHM);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void IEBPJKIPJFA(MGLJJACBNLF EGAMMPAFFJK, [In] JJDEBGOFHIM GHGLDMJMCGK);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "28")]
	Task CJJKBBJBGJD(LCCHGCBPFIP DLNHHMNONFG, bool DKMPDCECDLC, CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Task CAGGOIDLGLA(CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void BIMJAKHFPCH(long DCONEHIDLCB, long OBCIDCBDAAN, MBLNIACGJFP MOJKGMPPOOM, CDHHINAEKFG FDNJGFCOKBN, NCAEELCEENN GLJDKFPIHIE, NAODMFNDKAH? MMMALGMIIMN, AHKALLEBELB? BOOMHOGHMLL);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void NHFCEPLCJDB(long DCONEHIDLCB, long OBCIDCBDAAN, AHKALLEBELB? BOOMHOGHMLL);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void ODCPLIJLADD(PersistenceView AHLCMHCDPIF);

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void MJNICNCJBJK(string MNNBPHLPOLE, AAKDENBOOJG BAGPMCPHKKA, IENLNGMNILH FHANAFAIDPI, [Optional] string? JFJICPIGKPN, [Optional] string? GLIIMAGEMBE, [Optional] string? MDIIOAIEJHA);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool HPGNDMDBGID(PersistenceView BPHIDAEMDAO);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "35")]
	bool HIEOLPIOGAF(MGLJJACBNLF EGAMMPAFFJK, ICHMBANNAMC BCFOJALMLBH, [Out] LGBKJPKBIKB OMPICOFPGIG);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "36")]
	Task BJNGLLKHEDJ(CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void LIHLPMFBKBK();

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(Slot = "38")]
	IDisposable LKCOIECLBDB();

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void NKDELFNHFBG(LCCHGCBPFIP DLNHHMNONFG, ICHMBANNAMC BCFOJALMLBH);

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "40")]
	Task<bool> EOBGGLOHEDO(CFAOIDGAGLN KMFAHFKEGPF, CancellationToken GMKBGHHNCDJ, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void JCKNMMGHMHI(CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "42")]
	Task<LFHDKPIJJCJ> KNFBOIACNMF(FNAACIPNCNN IDLJGJGIGEG);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(Slot = "43")]
	Task<MBLNIACGJFP> BDDHBPPMIML(long DCONEHIDLCB, bool LEIPFJBGPPF, CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "44")]
	Task<EILAOANGAEC> FCCAONFOMMN(long DCONEHIDLCB, long OBCIDCBDAAN, long DEMDBAHMNFM, CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "45")]
	Task<CDHHINAEKFG> JBPOILJJEBD(long DCONEHIDLCB, long OBCIDCBDAAN, CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "46")]
	Task<GJNECDDAEBM> PPJCBMNCKCE(long DCONEHIDLCB, Guid MACKIGIFCGL, long? JLNBCNHEKAJ, CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "47")]
	JMEMOINNBPH<GJNECDDAEBM, IEnumerable<ACJJNNKGIPF>> EKFHCEOKAND();

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(Slot = "48")]
	Task<GELNHKAAEAP> NHNEAGAOKGM(string CKLCBBHHKPN, CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "49")]
	Task<GELNHKAAEAP> KEJJDEJPMJF(string CKLCBBHHKPN, long DCONEHIDLCB, long OBCIDCBDAAN, Guid? GCDGOJIGOMN, OJKNGDHNBLO.EJPNMHDEOFI PHIIDLOGBDN, OJKNGDHNBLO.EJPNMHDEOFI IAOLPELEMJE, int IIIICGCPFGI);

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(Slot = "51")]
	bool ELBODFMJCJI();

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool EKHLMGCCCMK();

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool PLACIBGPNAI(IEnumerable<LGBKJPKBIKB> DHNILMFGLIH);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void MOLGKINBBGE(List<GameObject> DFGLBNMJNJP);

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(Slot = "55")]
	float EKFHNOAEJPG();

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(Slot = "56")]
	Task<bool> POOGODDGDFE(CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "57")]
	Task<Scene> LDHJPDOLDDI(string CGAJOJLBJOM, LoadSceneMode NPCAALKDPBM, bool HLKMKJFACNJ, CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN);

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void BJJGBDAMAEJ(bool DGKJCLCLLMA);

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(Slot = "63")]
	void PHLEJAHPAKC();

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void BLALNHLAHNF();

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void MEOBBIOMPJP(bool OMGOKOBKENG);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "71")]
	Task<OJKNGDHNBLO.EJPNMHDEOFI> FFOEGOFBKCL(byte[] NGIAGNLBILI, OJKNGDHNBLO.PCKPKNLIKIE FLPBNCFLNDP, AFAHMMHICON ABIJIHOCFPI, [Optional] IReadOnlyCollection<string>? DNKLKCDDPGN, [Optional] string? OBMEBAPIKEE);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void LFMPGGNEKHK(AAKDENBOOJG HNHBEJCGLAG);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "73")]
	Task EGKCNLMGGKE(CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "74")]
	Task EDAIJKPCPHF(CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "75")]
	Task MPDFLDKNHII(CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "76")]
	Task CIFGGJGOBBA(CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "77")]
	IDisposable BLEPLOFLPDK();

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "78")]
	KFGBAMIOEAD EGLEKJKAJMD();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "79")]
	Task EJEGEONMMAM(CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface KFGBAMIOEAD
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ALOJNICCEGN(CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JOEKOKJNIAA(CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public struct JJDEBGOFHIM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public HashSet<int> MGKGGGNMLBD;
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public enum LDEGPMKIHEM : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	Yes,
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	No,
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	NoAndDelete
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public struct EPBLMMCONNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Guid? EGENNPOMEAK;
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface CJGDJMIKAIC
{
	[Cpp2IlInjected.Token(Token = "0x17000067")]
	AAKDENBOOJG KMEJPIGBHKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	MBLNIACGJFP IHNDJFPJKPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	EOHPFFLACLH AKFBMBGFEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	bool MMKJMEOGEBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	bool ANOGNGDNPGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	int EEIPMFMKNGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action DDOPFDKNJDN;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<int> OHCPEMLCHGK;

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ENFNHPOIMLD();

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "11")]
	Task<Matchmaking.CKKBBHCKHDD> EFKFKGBOCAN(long DAKBFKLMPGD, [Optional] CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "12")]
	Task<NHMPOKILKGM> IGGBKBILKDO(AAKDENBOOJG BAGPMCPHKKA, [Optional] GOFJAADJDOP OEBIGJLGLNB);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	Task<NHMPOKILKGM> ALNBGPMAHJM();

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	Task MLLFCLNOKMH();

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	(AAKDENBOOJG, GOFJAADJDOP) OEOOMIPPJHG();

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	CGAODEELHOF IJFPCNONHPJ();

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void HBIKNNOBOJJ(long DAKBFKLMPGD);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void NONGKKGHPHL(AAKDENBOOJG BAGPMCPHKKA, Matchmaking.MIBDOLNHAPA HJBCDFKDKBA, (int Major, int? Minor)? FCDCKNGNLFJ);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface ONEHEKMMKIA
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EEJJJNJEBIF([Out] IEnumerable<int> EPFPLHLOMIO);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OLINLKFHCCL(ACAHCPOBLDI MONGIMOHLAO);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PIKNMHJDHBD(ACAHCPOBLDI MONGIMOHLAO);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface BEPICPNLHEN
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string EJPNIDABPDN(LALFMHKAHCO ONBHNOJBNCG);
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface NBKFIDCCLCN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIOOFKFJJGD(IFJCGMNPLIB.NINJBMAAMGO FBCHPNEEHEK);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMFOCBLJNCI(IFJCGMNPLIB.NINJBMAAMGO FBCHPNEEHEK);
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public interface NEPJNHOBGFK : NBKFIDCCLCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LALFMHKAHCO PFMIOBOFJHH(NELIJLIGAOD KHKEJCOHPIB);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface GCFCNBPHIEF : NBKFIDCCLCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LALFMHKAHCO ABLMCEMBKLA(NELIJLIGAOD GHOBDALFLGI);
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface AGJEILLLEMO
{
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DGHPMJAIBNO<PKPKOGNMCPP, KIBOPIAKFMB>> CKKJLCBDIIN(Guid? GCDGOJIGOMN, IReadOnlyCollection<NCDNOPDHNPA> MBBBOJDGOAD, IReadOnlyCollection<NCDNOPDHNPA> LOMDMIGODGN, NPLOBMPCANM FFBEPOEECMP, long? DCONEHIDLCB, long? OBCIDCBDAAN, HIGDFOFBOPO.DABADIHPCNE HMNIKNLJBKD, CancellationToken GMKBGHHNCDJ, bool EPAEIBKMPNJ = false);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public sealed class PKPKOGNMCPP
{
	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public MOFDHGDONHK GJHHFIDHGGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public IReadOnlyList<MOFDHGDONHK> IFNODOPJNGL
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public IReadOnlyList<MOFDHGDONHK> AKNMJECEGIP
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0xDA1DB0", Offset = "0xDA11B0", VA = "0x180DA1DB0")]
	public PKPKOGNMCPP(MOFDHGDONHK GFCBOAJHION, IReadOnlyList<MOFDHGDONHK> JKPKLCHAEHB, IReadOnlyList<MOFDHGDONHK> JICOOANLIDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface JMEMOINNBPH<TGetDataArg, TData>
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task<DGHPMJAIBNO<DAENPLLCOHN<TData>, KIBOPIAKFMB>> CKLDEAKPFJP(TGetDataArg ALOONCIOJJM, CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class BLGJFNGAACI : JNGEBJCPLIA, BOKALKOMIFP, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct ODJGHJHIOHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public AsyncTaskMethodBuilder<LALFMHKAHCO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public BLGJFNGAACI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public HOAPKCGDNIL autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private TaskAwaiter<LALFMHKAHCO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x8B47E80", Offset = "0x8B47280", VA = "0x188B47E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x8B48100", Offset = "0x8B47500", VA = "0x188B48100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct MHFKLGMHEPL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public BLGJFNGAACI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8B453A0", Offset = "0x8B447A0", VA = "0x188B453A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x8B455D0", Offset = "0x8B449D0", VA = "0x188B455D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class MBJDCHLJIAL : IEnumerable<EHHOJPPJJPL>, IEnumerable, IEnumerator<EHHOJPPJJPL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private EHHOJPPJJPL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public BLGJFNGAACI <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		private EHHOJPPJJPL System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.IRoomManagerComponent>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xFC9810", Offset = "0xFC8C10", VA = "0x180FC9810")]
		[DebuggerHidden]
		public MBJDCHLJIAL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x8B43BF0", Offset = "0x8B42FF0", VA = "0x188B43BF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x8B44050", Offset = "0x8B43450", VA = "0x188B44050", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8B43FA0", Offset = "0x8B433A0", VA = "0x188B43FA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<EHHOJPPJJPL> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.IRoomManagerComponent>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8B43FA0", Offset = "0x8B433A0", VA = "0x188B43FA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly CancellationTokenSource FOHMPJGFGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly JFAGCPCLAAF MNCIANLLPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private bool GJNOCMLAONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private APILMOPPHCD GABILEOHNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private bool PMIBGLHLMEO;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public CFAOIDGAGLN DCBDPIDPKED
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA70280", Offset = "0xA6F680", VA = "0x180A70280", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA70270", Offset = "0xA6F670", VA = "0x180A70270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public GJDFEKLPFLO CGPMFDINPHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA703D0", Offset = "0xA6F7D0", VA = "0x180A703D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA70390", Offset = "0xA6F790", VA = "0x180A70390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public IJIEICICPPB JDGMIPEIBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA74030", Offset = "0xA73430", VA = "0x180A74030", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA74020", Offset = "0xA73420", VA = "0x180A74020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public BGMGFHJNNDK JKKJFMCJMOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA70440", Offset = "0xA6F840", VA = "0x180A70440", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA70240", Offset = "0xA6F640", VA = "0x180A70240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public NEPJNHOBGFK OPGDJIFHHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA703E0", Offset = "0xA6F7E0", VA = "0x180A703E0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA70170", Offset = "0xA6F570", VA = "0x180A70170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public GCFCNBPHIEF DFJELNHPMPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA7C8A0", Offset = "0xA7BCA0", VA = "0x180A7C8A0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA7C9A0", Offset = "0xA7BDA0", VA = "0x180A7C9A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public CMJHPNLKEGN GKOEDHCFNGA
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA7C870", Offset = "0xA7BC70", VA = "0x180A7C870", Slot = "54")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA7C9B0", Offset = "0xA7BDB0", VA = "0x180A7C9B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public EOLAJDKNPJP IBAIKLAIIPL
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA7C960", Offset = "0xA7BD60", VA = "0x180A7C960", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA7C810", Offset = "0xA7BC10", VA = "0x180A7C810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public OHGELLMBBCH CAJPICHFLPB
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xAD90C0", Offset = "0xAD84C0", VA = "0x180AD90C0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xB1ECE0", Offset = "0xB1E0E0", VA = "0x180B1ECE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public BIKNNKNKKNG FOKPJDBIANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA7C860", Offset = "0xA7BC60", VA = "0x180A7C860", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA7C970", Offset = "0xA7BD70", VA = "0x180A7C970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public IJPBCNJCDLL IAEJJHJMCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xB1F0B0", Offset = "0xB1E4B0", VA = "0x180B1F0B0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xB1F110", Offset = "0xB1E510", VA = "0x180B1F110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public CNFMKMLJBNK INKLAOHDHKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA76C50", Offset = "0xA76050", VA = "0x180A76C50", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA76BE0", Offset = "0xA75FE0", VA = "0x180A76BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public PJPBKECLNGI AIDDBIGHDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xB1ED30", Offset = "0xB1E130", VA = "0x180B1ED30", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xB1F130", Offset = "0xB1E530", VA = "0x180B1F130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public LLMBDMOEJHN POMPNDIDHKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xE7BEF0", Offset = "0xE7B2F0", VA = "0x180E7BEF0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xE7BF00", Offset = "0xE7B300", VA = "0x180E7BF00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public AOMCGKJFJCA NNIHMPFOGLC
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xB1F0F0", Offset = "0xB1E4F0", VA = "0x180B1F0F0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xB508C0", Offset = "0xB4FCC0", VA = "0x180B508C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public KFBFGIMCKBO ANCENADHNKA
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xB1ED20", Offset = "0xB1E120", VA = "0x180B1ED20", Slot = "60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xB1ECC0", Offset = "0xB1E0C0", VA = "0x180B1ECC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public DJEPMJOLNDO MNIDDBPEIBO
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xAE4BE0", Offset = "0xAE3FE0", VA = "0x180AE4BE0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xAE8210", Offset = "0xAE7610", VA = "0x180AE8210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public MPJEHHCGJLJ GCONCFCDHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA76C20", Offset = "0xA76020", VA = "0x180A76C20", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA76C00", Offset = "0xA76000", VA = "0x180A76C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public COPIACBMJOB HKLGNFMOELB
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xAE88B0", Offset = "0xAE7CB0", VA = "0x180AE88B0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xAE7EF0", Offset = "0xAE72F0", VA = "0x180AE7EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public DDFIJAHBHAB CCDFMJDJBPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xAE88A0", Offset = "0xAE7CA0", VA = "0x180AE88A0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xAE8230", Offset = "0xAE7630", VA = "0x180AE8230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public EAEHMHEANPP JCMEJOPFCPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xAE32D0", Offset = "0xAE26D0", VA = "0x180AE32D0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xAE3530", Offset = "0xAE2930", VA = "0x180AE3530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public MJCJEEMHPAL KBHPDGLGDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xAF1220", Offset = "0xAF0620", VA = "0x180AF1220", Slot = "25")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xAEC170", Offset = "0xAEB570", VA = "0x180AEC170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public NDHMFLFGHJI MNFFFOEKAPI
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xAE4AD0", Offset = "0xAE3ED0", VA = "0x180AE4AD0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xAEB450", Offset = "0xAEA850", VA = "0x180AEB450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public NGCHDLFDNLO ACOOHAJFDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xAE6810", Offset = "0xAE5C10", VA = "0x180AE6810", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xAE4C90", Offset = "0xAE4090", VA = "0x180AE4C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public ONEHEKMMKIA PLMGMEPOKPP
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xAE66C0", Offset = "0xAE5AC0", VA = "0x180AE66C0", Slot = "28")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xAE5040", Offset = "0xAE4440", VA = "0x180AE5040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public GAHEGOGCHOL EJBENFIBAJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xAD6960", Offset = "0xAD5D60", VA = "0x180AD6960", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xAE6B20", Offset = "0xAE5F20", VA = "0x180AE6B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public OGFKANFAGPF GLDKAJEHDBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xBCDBE0", Offset = "0xBCCFE0", VA = "0x180BCDBE0", Slot = "30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xBC77E0", Offset = "0xBC6BE0", VA = "0x180BC77E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public JPLOJOIMKCI JHGHHBIMJHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0xB4C1F0", Offset = "0xB4B5F0", VA = "0x180B4C1F0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xB44890", Offset = "0xB43C90", VA = "0x180B44890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public BHFDIHOAMAC DBGCBKAKFEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xB4BEA0", Offset = "0xB4B2A0", VA = "0x180B4BEA0", Slot = "32")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public AMBHINONLEP FDJPBFOBPFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xBCF310", Offset = "0xBCE710", VA = "0x180BCF310", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public LBKIPKPPCBG DMLAMLJHCIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xBCF390", Offset = "0xBCE790", VA = "0x180BCF390", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public LCGKHGAPJOB EGLOIGDAHGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xBD0B90", Offset = "0xBCFF90", VA = "0x180BD0B90", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public OGJJOHIHALN LDCDPIICGFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xBE0820", Offset = "0xBDFC20", VA = "0x180BE0820", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public GOFJAADJDOP BIAJCCNEFOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xBC8C10", Offset = "0xBC8010", VA = "0x180BC8C10", Slot = "58")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xD52360", Offset = "0xD51760", VA = "0x180D52360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private bool LMJKDLHHHND
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8B2CD80", Offset = "0x8B2C180", VA = "0x188B2CD80", Slot = "48")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	private bool JBKKJNOCGND
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C5F0", Offset = "0x8B2B9F0", VA = "0x188B2C5F0", Slot = "49")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	private bool LCDFJHPCIDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x1EF5530", Offset = "0x1EF4930", VA = "0x181EF5530", Slot = "50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	private CancellationToken JDPGFCFDDCO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8B2CA00", Offset = "0x8B2BE00", VA = "0x188B2CA00", Slot = "4")]
		get
		{
			return default(CancellationToken);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	private JFAGCPCLAAF KAOBBABGAKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private bool NJELENHOGBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x1EF5530", Offset = "0x1EF4930", VA = "0x181EF5530", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x1EEFBB0", Offset = "0x1EEEFB0", VA = "0x181EEFBB0", Slot = "38")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	private event EIPCGJEPLHG HPBKOFMBKAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C9A0", Offset = "0x8B2BDA0", VA = "0x188B2C9A0", Slot = "40")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C590", Offset = "0x8B2B990", VA = "0x188B2C590", Slot = "41")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	private event EIPCGJEPLHG JNAHLKLLCKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C130", Offset = "0x8B2B530", VA = "0x188B2C130", Slot = "42")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C0D0", Offset = "0x8B2B4D0", VA = "0x188B2C0D0", Slot = "43")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000F")]
	private event EIPCGJEPLHG GCJPNALHBIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8B2BFE0", Offset = "0x8B2B3E0", VA = "0x188B2BFE0", Slot = "44")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C7E0", Offset = "0x8B2BBE0", VA = "0x188B2C7E0", Slot = "45")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000010")]
	private event Action<ECCPAABCJNI, bool> BLFNGNKLJOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8B2CD20", Offset = "0x8B2C120", VA = "0x188B2CD20", Slot = "46")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C420", Offset = "0x8B2B820", VA = "0x188B2C420", Slot = "47")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0xD52360", Offset = "0xD51760", VA = "0x180D52360", Slot = "39")]
	public void ANBJBGJINCL(GOFJAADJDOP CGDGPFJJODE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x8B2CE90", Offset = "0x8B2C290", VA = "0x188B2CE90")]
	[UnityEngine.Scripting.Preserve]
	internal BLGJFNGAACI([PKIHAALFADL(null)] JFAGCPCLAAF MNCIANLLPKI, [PKIHAALFADL(null)] CFAOIDGAGLN KMFAHFKEGPF, [PKIHAALFADL(null)] GJDFEKLPFLO LPFMFOJPEPF, [PKIHAALFADL(null)] IJIEICICPPB LHIJBEJLBFF, [PKIHAALFADL(null)] BGMGFHJNNDK PMGDOOJBJKM, [PKIHAALFADL(null)] NEPJNHOBGFK HBGEIILAJIO, [PKIHAALFADL(null)] GCFCNBPHIEF EIIIIMAMBPH, [PKIHAALFADL(null)] EOLAJDKNPJP CDNGDNLHLDP, [PKIHAALFADL(null)] OHGELLMBBCH JGGICGFGJEF, [PKIHAALFADL(null)] BIKNNKNKKNG ELOPNFIJNDD, [PKIHAALFADL(null)] IJPBCNJCDLL LIBOFBBNJID, [PKIHAALFADL(null)] CNFMKMLJBNK EOFDBLMIHIL, [PKIHAALFADL(null)] PJPBKECLNGI GPEHJJBHHLE, [PKIHAALFADL(null)] LLMBDMOEJHN BCDGCKHBBNG, [PKIHAALFADL(null)] AOMCGKJFJCA OMLFHJOFHBG, [PKIHAALFADL(null)] KFBFGIMCKBO JBJLGDCKOGH, [PKIHAALFADL(null)] DJEPMJOLNDO CCDAJKHJDJB, [PKIHAALFADL(null)] MPJEHHCGJLJ GENHELHGMCE, [PKIHAALFADL(null)] COPIACBMJOB CHOKNFIMOLF, [PKIHAALFADL(null)] DDFIJAHBHAB EBHGIPFDGJH, [PKIHAALFADL(null)] MJCJEEMHPAL IKKACAKFMKF, [PKIHAALFADL(null)] EAEHMHEANPP NEEDNELMJIC, [PKIHAALFADL(null)] NDHMFLFGHJI JIGHDCPOALO, [PKIHAALFADL(null)] NGCHDLFDNLO JHMKJCBJHNA, [PKIHAALFADL(null)] ONEHEKMMKIA MCLEBCHDCDH, [PKIHAALFADL(null)] OGFKANFAGPF HFDKCBHNBMB, [PKIHAALFADL(null)] JPLOJOIMKCI BBCMJDBCPNP, [PKIHAALFADL(null)] BHFDIHOAMAC KNEBKMJDIFG, [PKIHAALFADL(null)] AMBHINONLEP DLDNLMOAPMB, [PKIHAALFADL(null)] LBKIPKPPCBG NLMHGAIPIGF, [PKIHAALFADL(null)] LCGKHGAPJOB BDMKIMIJNLJ, [PKIHAALFADL(null)] OGJJOHIHALN FECJHCJFEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x8B2CDE0", Offset = "0x8B2C1E0", VA = "0x188B2CDE0")]
	private void PJOFCLDPLJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x8B2C280", Offset = "0x8B2B680", VA = "0x188B2C280", Slot = "59")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x8B2C950", Offset = "0x8B2BD50", VA = "0x188B2C950", Slot = "51")]
	private void MPHFJKHFMKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x8B2C750", Offset = "0x8B2BB50", VA = "0x188B2C750", Slot = "52")]
	private PJDLMHFKGND KCHJKFBDADM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x8B2C040", Offset = "0x8B2B440", VA = "0x188B2C040", Slot = "53")]
	private KEPELKDMLJM CFJPGNPGCDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x8B2CA20", Offset = "0x8B2BE20", VA = "0x188B2CA20", Slot = "55")]
	public Task OKIBFCLAMEJ(int IIIICGCPFGI, NAODMFNDKAH MMMALGMIIMN, Func<NCAEELCEENN, NCAEELCEENN> NBPDBOJPCGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x8B2C480", Offset = "0x8B2B880", VA = "0x188B2C480")]
	private CHPGJFHLDMO GPBLJDHGFDP(int IIIICGCPFGI, NAODMFNDKAH MMMALGMIIMN, Func<NCAEELCEENN, NCAEELCEENN> NBPDBOJPCGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x8B2C840", Offset = "0x8B2BC40", VA = "0x188B2C840", Slot = "56")]
	[AsyncStateMachine(typeof(ODJGHJHIOHE))]
	private Task<LALFMHKAHCO> MLPBIPIDHPJ(HOAPKCGDNIL NNKOPAHIOCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x8B2C190", Offset = "0x8B2B590", VA = "0x188B2C190", Slot = "57")]
	[AsyncStateMachine(typeof(MHFKLGMHEPL))]
	private Task DPPMDGPFOBH(CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x8B2C6D0", Offset = "0x8B2BAD0", VA = "0x188B2C6D0")]
	[IteratorStateMachine(typeof(MBJDCHLJIAL))]
	private IEnumerable<EHHOJPPJJPL> JHJNJJCJCBO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x8B2C670", Offset = "0x8B2BA70", VA = "0x188B2C670")]
	[CompilerGenerated]
	private void IEAEFBAPECC(EHHOJPPJJPL FCIHIIPNCLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class DDMGLNEFAOK : TimeoutException
{
	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x1A82310", Offset = "0x1A81710", VA = "0x181A82310")]
	public DDMGLNEFAOK(string AFDNIPHJHMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal class HOFOOADLMGN : KDEBOOHPBMI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct AJCLPIIFGIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public AsyncTaskMethodBuilder<KDEBOOHPBMI.BADKJBOEJHH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public HashSet<PEKCJHOIPJA.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public HOFOOADLMGN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8B2B840", Offset = "0x8B2AC40", VA = "0x188B2B840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8B2BB50", Offset = "0x8B2AF50", VA = "0x188B2BB50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly JNGEBJCPLIA IDEPICHODDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly IJIEICICPPB LHIJBEJLBFF;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private string OAJDEKHKHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x8B37380", Offset = "0x8B36780", VA = "0x188B37380", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0xA7A690", Offset = "0xA79A90", VA = "0x180A7A690")]
	public HOFOOADLMGN(JNGEBJCPLIA IDEPICHODDC, IJIEICICPPB LHIJBEJLBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x8B373B0", Offset = "0x8B367B0", VA = "0x188B373B0", Slot = "5")]
	[AsyncStateMachine(typeof(AJCLPIIFGIL))]
	public Task<KDEBOOHPBMI.BADKJBOEJHH> OJJABFNKKAB(HashSet<PEKCJHOIPJA.Reason> POPIBCHFPOC, CancellationToken GMKBGHHNCDJ, PEKCJHOIPJA.Reason HBHJOPNAJMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal class HIABPBHGFIP : KNIGIGLNEJN, KDEBOOHPBMI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct FKIEHOGPAAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<KDEBOOHPBMI.BADKJBOEJHH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public HIABPBHGFIP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public HashSet<PEKCJHOIPJA.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public PEKCJHOIPJA.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private AAKDENBOOJG <localRoomInstance>5__2;

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
		private TaskAwaiter<KDEBOOHPBMI.BADKJBOEJHH> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8B31B40", Offset = "0x8B30F40", VA = "0x188B31B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x8B32510", Offset = "0x8B31910", VA = "0x188B32510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly BHDMKDMOGNP CDCFIOPBLOM;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	private string OAJDEKHKHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8B34370", Offset = "0x8B33770", VA = "0x188B34370", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x8B34570", Offset = "0x8B33970", VA = "0x188B34570")]
	public HIABPBHGFIP([PKIHAALFADL(null)] JNGEBJCPLIA IDEPICHODDC, [PKIHAALFADL(null)] IJIEICICPPB LHIJBEJLBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x8B343A0", Offset = "0x8B337A0", VA = "0x188B343A0", Slot = "5")]
	[AsyncStateMachine(typeof(FKIEHOGPAAC))]
	public Task<KDEBOOHPBMI.BADKJBOEJHH> OJJABFNKKAB(HashSet<PEKCJHOIPJA.Reason> POPIBCHFPOC, CancellationToken GMKBGHHNCDJ, PEKCJHOIPJA.Reason HBHJOPNAJMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal class INEBLNPBPBD : KNIGIGLNEJN, KDEBOOHPBMI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct EDMNCMHHNAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AsyncTaskMethodBuilder<KDEBOOHPBMI.BADKJBOEJHH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public INEBLNPBPBD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public HashSet<PEKCJHOIPJA.Reason> fallbackTriggersToIgnore;

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
		private TaskAwaiter<NHMPOKILKGM> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private TaskAwaiter<KDEBOOHPBMI.BADKJBOEJHH> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8B30650", Offset = "0x8B2FA50", VA = "0x188B30650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x8B31040", Offset = "0x8B30440", VA = "0x188B31040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	private string OAJDEKHKHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8B412B0", Offset = "0x8B406B0", VA = "0x188B412B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0xA7A690", Offset = "0xA79A90", VA = "0x180A7A690")]
	public INEBLNPBPBD(JNGEBJCPLIA IDEPICHODDC, IJIEICICPPB LHIJBEJLBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8B412E0", Offset = "0x8B406E0", VA = "0x188B412E0", Slot = "5")]
	[AsyncStateMachine(typeof(EDMNCMHHNAC))]
	public Task<KDEBOOHPBMI.BADKJBOEJHH> OJJABFNKKAB(HashSet<PEKCJHOIPJA.Reason> POPIBCHFPOC, CancellationToken GMKBGHHNCDJ, PEKCJHOIPJA.Reason HBHJOPNAJMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal class FKODMOIOPPC : KNIGIGLNEJN, KDEBOOHPBMI
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class GHAGGIAABCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public NHMPOKILKGM matchmakingErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public AAKDENBOOJG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public long preFallbackInstance;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public GHAGGIAABCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8B33A00", Offset = "0x8B32E00", VA = "0x188B33A00")]
		internal object BLKNEDHIFKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x8B33A80", Offset = "0x8B32E80", VA = "0x188B33A80")]
		internal object CILOCLOBJOM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct HNLANOLEIBK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public AsyncTaskMethodBuilder<KDEBOOHPBMI.BADKJBOEJHH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public FKODMOIOPPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public HashSet<PEKCJHOIPJA.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private GHAGGIAABCA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public PEKCJHOIPJA.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private TaskAwaiter<NHMPOKILKGM> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private TaskAwaiter<KDEBOOHPBMI.BADKJBOEJHH> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x8B36670", Offset = "0x8B35A70", VA = "0x188B36670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8B37310", Offset = "0x8B36710", VA = "0x188B37310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly BHDMKDMOGNP CDCFIOPBLOM;

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	private string OAJDEKHKHOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8B32580", Offset = "0x8B31980", VA = "0x188B32580", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x8B32780", Offset = "0x8B31B80", VA = "0x188B32780")]
	public FKODMOIOPPC([PKIHAALFADL(null)] JNGEBJCPLIA IDEPICHODDC, [PKIHAALFADL(null)] IJIEICICPPB LHIJBEJLBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x8B325B0", Offset = "0x8B319B0", VA = "0x188B325B0", Slot = "5")]
	[AsyncStateMachine(typeof(HNLANOLEIBK))]
	public Task<KDEBOOHPBMI.BADKJBOEJHH> OJJABFNKKAB(HashSet<PEKCJHOIPJA.Reason> POPIBCHFPOC, CancellationToken GMKBGHHNCDJ, PEKCJHOIPJA.Reason HBHJOPNAJMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal abstract class KNIGIGLNEJN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct MHFCPNAMKHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public AKNCNLDICPO log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public HashSet<PEKCJHOIPJA.Reason> fallbackTriggersToIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public KNIGIGLNEJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private List<PEKCJHOIPJA.Reason> <newDisconnectTriggers>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x8B44E20", Offset = "0x8B44220", VA = "0x188B44E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8B45340", Offset = "0x8B44740", VA = "0x188B45340", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	protected readonly JNGEBJCPLIA IDEPICHODDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	protected readonly IJIEICICPPB LHIJBEJLBFF;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	protected CJGDJMIKAIC MJABACAOHLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8B43180", Offset = "0x8B42580", VA = "0x188B43180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0xA7A690", Offset = "0xA79A90", VA = "0x180A7A690")]
	public KNIGIGLNEJN(JNGEBJCPLIA IDEPICHODDC, IJIEICICPPB LHIJBEJLBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x8B431D0", Offset = "0x8B425D0", VA = "0x188B431D0")]
	[AsyncStateMachine(typeof(MHFCPNAMKHC))]
	protected Task JADKICIFGIO(AKNCNLDICPO CCLJCJDJCOE, HashSet<PEKCJHOIPJA.Reason> POPIBCHFPOC, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class EHENJDDKBMB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct KKOGDIKBGCN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public AsyncTaskMethodBuilder<KDEBOOHPBMI.BADKJBOEJHH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public IJIEICICPPB callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private float <timeoutTime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8B423C0", Offset = "0x8B417C0", VA = "0x188B423C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x8B42740", Offset = "0x8B41B40", VA = "0x188B42740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class OGNIBEEDFAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public string fallbackName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public JNGEBJCPLIA roomManager;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public OGNIBEEDFAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x8B48170", Offset = "0x8B47570", VA = "0x188B48170")]
		internal object GJGGDDAKKMG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public static readonly float NFGMGFODPCD;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	internal static readonly HashSet<PEKCJHOIPJA.Reason> OOJKGNPIAGL;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8B316B0", Offset = "0x8B30AB0", VA = "0x188B316B0")]
	[AsyncStateMachine(typeof(KKOGDIKBGCN))]
	internal static Task<KDEBOOHPBMI.BADKJBOEJHH> JIKBNKBKMBN(IJIEICICPPB LHIJBEJLBFF, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x8B317C0", Offset = "0x8B30BC0", VA = "0x188B317C0")]
	internal static void LCNPDLCNCNN(JNGEBJCPLIA IDEPICHODDC, AKNCNLDICPO CCLJCJDJCOE, string MNNBPHLPOLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal interface KDEBOOHPBMI
{
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct BADKJBOEJHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public bool DLGALHBKJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public PEKCJHOIPJA.Reason HBHJOPNAJMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Enum? MDIIOAIEJHA;

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x8B2BFD0", Offset = "0x8B2B3D0", VA = "0x188B2BFD0")]
		public static BADKJBOEJHH KMAEPPNCJOM()
		{
			return default(BADKJBOEJHH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x8B2BFA0", Offset = "0x8B2B3A0", VA = "0x188B2BFA0")]
		public static BADKJBOEJHH DADNBKPCHGH(PEKCJHOIPJA.Reason HBHJOPNAJMN, [Optional] Enum? MDIIOAIEJHA)
		{
			return default(BADKJBOEJHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	string JNPHMMHHDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<BADKJBOEJHH> OJJABFNKKAB(HashSet<PEKCJHOIPJA.Reason> POPIBCHFPOC, CancellationToken GMKBGHHNCDJ, PEKCJHOIPJA.Reason HBHJOPNAJMN);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal struct NFIOJKKECLD
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class LMHCCJGJBKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public JNGEBJCPLIA manager;

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public LMHCCJGJBKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x8B437E0", Offset = "0x8B42BE0", VA = "0x188B437E0")]
		internal Task CCENKCCCIAK(CancellationToken cancellationToken, int roomTotalVersion, JPNNICBILFM localPlayerAccountRoleType)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private struct EHDAPNIGHPA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public NFIOJKKECLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private long <roomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private long <subroomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private HOAPKCGDNIL <autosaveInfo>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private TaskAwaiter<LDEGPMKIHEM> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private TaskAwaiter<LALFMHKAHCO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8B310B0", Offset = "0x8B304B0", VA = "0x188B310B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8B31640", Offset = "0x8B30A40", VA = "0x188B31640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private struct HIDCPGHFMNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public NFIOJKKECLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8B34640", Offset = "0x8B33A40", VA = "0x188B34640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x8B34960", Offset = "0x8B33D60", VA = "0x188B34960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly CancellationToken GMKBGHHNCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly JNGEBJCPLIA JPGAFCLKGNM;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	private CFAOIDGAGLN DCBDPIDPKED
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8B46BD0", Offset = "0x8B45FD0", VA = "0x188B46BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	private IJIEICICPPB JDGMIPEIBAC
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x8B470B0", Offset = "0x8B464B0", VA = "0x188B470B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	private CJGDJMIKAIC MJABACAOHLE
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x8B46E70", Offset = "0x8B46270", VA = "0x188B46E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	private BIKNNKNKKNG FOKPJDBIANE
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x8B46E20", Offset = "0x8B46220", VA = "0x188B46E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x2A86F20", Offset = "0x2A86320", VA = "0x182A86F20")]
	public NFIOJKKECLD(CancellationToken GMKBGHHNCDJ, JNGEBJCPLIA JPGAFCLKGNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x8B47000", Offset = "0x8B46400", VA = "0x188B47000")]
	public static KJCCMEEKOGD IPNHADCBDOI(JNGEBJCPLIA JPGAFCLKGNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x8B46EF0", Offset = "0x8B462F0", VA = "0x188B46EF0")]
	[AsyncStateMachine(typeof(EHDAPNIGHPA))]
	public Task<bool> COBMPGJIBLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x8B47100", Offset = "0x8B46500", VA = "0x188B47100")]
	private bool PLJPIAKFCID([Out] HOAPKCGDNIL NNKOPAHIOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x8B46C20", Offset = "0x8B46020", VA = "0x188B46C20")]
	[AsyncStateMachine(typeof(HIDCPGHFMNG))]
	private Task BEILOEGCPEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8B46CF0", Offset = "0x8B460F0", VA = "0x188B46CF0")]
	private Task<LDEGPMKIHEM> BHBOGOFCEIP(HOAPKCGDNIL PDDLKDCPFHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal struct IENGDNGCKLK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly AOMCGKJFJCA OMLFHJOFHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly Guid PADGMLDAJOI;

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	private Task<(LALFMHKAHCO, Task)> GFCAIMMJEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x8B37C40", Offset = "0x8B37040", VA = "0x188B37C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x54E1AC0", Offset = "0x54E0EC0", VA = "0x1854E1AC0")]
	public IENGDNGCKLK(AOMCGKJFJCA OMLFHJOFHBG, Guid PADGMLDAJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x8B37DE0", Offset = "0x8B371E0", VA = "0x188B37DE0")]
	public TaskAwaiter<(LALFMHKAHCO, Task)> JNHNNPMDNOI()
	{
		return default(TaskAwaiter<(LALFMHKAHCO, Task)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x8B37D10", Offset = "0x8B37110", VA = "0x188B37D10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
internal struct AJHNMFINGKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly TaskCompletionSource<(LALFMHKAHCO, Task)> EACDKJDMENA;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public Task<(LALFMHKAHCO, Task)> GFCAIMMJEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8B2BD40", Offset = "0x8B2B140", VA = "0x188B2BD40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x8B2BE10", Offset = "0x8B2B210", VA = "0x188B2BE10")]
	public AJHNMFINGKH(TimeSpan BLPEEGBOENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x8B2BCA0", Offset = "0x8B2B0A0", VA = "0x188B2BCA0")]
	public void CFBGKKLMGHC(Task JFLMKLJIJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x8B2BBC0", Offset = "0x8B2AFC0", VA = "0x188B2BBC0")]
	public void AIPAHKCCMGD(LALFMHKAHCO ONBHNOJBNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x8B2BC50", Offset = "0x8B2B050", VA = "0x188B2BC50")]
	public void BIDMKPEJOMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x8B2BD80", Offset = "0x8B2B180", VA = "0x188B2BD80")]
	internal void KEJDPPGGBAH(string AFDNIPHJHMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class HHMCPMJNMGM
{
	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x8B341D0", Offset = "0x8B335D0", VA = "0x188B341D0")]
	public static BGMNPHKELEH PNNPMIHIFIJ(this BGMNPHKELEH JPPAFNCCIMK, MBLNIACGJFP DOMHFCDDMDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x8B34040", Offset = "0x8B33440", VA = "0x188B34040")]
	public static BGMNPHKELEH KDCDCGHAOOC(this BGMNPHKELEH JPPAFNCCIMK, CDHHINAEKFG LNJGKLICKDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class KKAPAFABLGE : CMJHPNLKEGN
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class PCLFAGBMEPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public CDHHINAEKFG subRoomSave;

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public PCLFAGBMEPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8B4A140", Offset = "0x8B49540", VA = "0x188B4A140")]
		internal bool GKNIFMNOKHF(EOHPFFLACLH s)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly OGFKANFAGPF CJEJMGNFBBE;

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	public KKAPAFABLGE(OGFKANFAGPF HFDKCBHNBMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x8B42080", Offset = "0x8B41480", VA = "0x188B42080", Slot = "4")]
	public BGMNPHKELEH CEOONNIFPHP(long LFNOOICHMCA, long OBCIDCBDAAN, string CKLCBBHHKPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x8B41C40", Offset = "0x8B41040", VA = "0x188B41C40", Slot = "5")]
	public BGMNPHKELEH CEOONNIFPHP(long LFNOOICHMCA, long OBCIDCBDAAN, APAGCNALJKL PNHJPDOBEAP, Guid? BGDOGACKFOG, long DEMDBAHMNFM, bool HEOKPBILMDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x8B42110", Offset = "0x8B41510", VA = "0x188B42110", Slot = "6")]
	public BGMNPHKELEH CEOONNIFPHP(LFHDKPIJJCJ MOOIEGMHBKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x8B41DA0", Offset = "0x8B411A0", VA = "0x188B41DA0", Slot = "7")]
	public BGMNPHKELEH CEOONNIFPHP(MBLNIACGJFP HJMEIFOPKEJ, CDHHINAEKFG LBONFDONBLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x8B42310", Offset = "0x8B41710", VA = "0x188B42310")]
	private Guid? OHIDBKPNHNJ(MBLNIACGJFP JGDNDIIJCDP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[RecRoom.NoEngine.Common.Preserve]
internal class KFABLBOMMFI : OHGELLMBBCH, EHHOJPPJJPL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private struct IEINDBMHJBL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public KFABLBOMMFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public string debugInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public Task innerTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8B37540", Offset = "0x8B36940", VA = "0x188B37540", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8B37BE0", Offset = "0x8B36FE0", VA = "0x188B37BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly ACAHCPOBLDI JNCBBCGALNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private string LGMKNJLJMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Task DBBJDDKPBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private JNGEBJCPLIA IDEPICHODDC;

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool GJCGGGJCNDM
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8B41730", Offset = "0x8B40B30", VA = "0x188B41730", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public Task PEPMIHIAOHK
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x8B41760", Offset = "0x8B40B60", VA = "0x188B41760", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10", Slot = "7")]
	public void PJOFCLDPLJB(JNGEBJCPLIA IDEPICHODDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x8B41910", Offset = "0x8B40D10", VA = "0x188B41910", Slot = "6")]
	public void PBOFOCCKJMO(Task KDHFABGBLNO, string MCOGNDCLNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x8B417F0", Offset = "0x8B40BF0", VA = "0x188B417F0")]
	[AsyncStateMachine(typeof(IEINDBMHJBL))]
	private Task NEILNIJCBBH(Task HLJINIEACIA, string MCOGNDCLNGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x8B41A70", Offset = "0x8B40E70", VA = "0x188B41A70")]
	public KFABLBOMMFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal class DBFLBHCMHAK : GAHEGOGCHOL, EHHOJPPJJPL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private bool NFDPBPGMHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private KHKGOPFBEOO NIGKLCIFGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private CFAOIDGAGLN KMFAHFKEGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private OGFKANFAGPF HFDKCBHNBMB;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public KHKGOPFBEOO LHINHCOPEGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x8B2EAD0", Offset = "0x8B2DED0", VA = "0x188B2EAD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x8B2EB40", Offset = "0x8B2DF40", VA = "0x188B2EB40", Slot = "7")]
	public void PJOFCLDPLJB(JNGEBJCPLIA IDEPICHODDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x8B2E820", Offset = "0x8B2DC20", VA = "0x188B2E820", Slot = "5")]
	public void DECEBGCIMKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x8B2E9D0", Offset = "0x8B2DDD0", VA = "0x188B2E9D0", Slot = "6")]
	public void DMEMJCICEFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x8B2EA10", Offset = "0x8B2DE10", VA = "0x188B2EA10")]
	private Task JPAGPNFGACG(NLAHKKKCINO PCKIEOGDDCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x8B2E9D0", Offset = "0x8B2DDD0", VA = "0x188B2E9D0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public DBFLBHCMHAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal class CPPGCJMOKHE : OGFKANFAGPF
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	private class OKANHHICKAB<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly LFMDEIGOMOD HPKDJJIICKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly string PEENICAIFOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly T ABINAMGBLJP;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public T JCMAOCOGHGO
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xB32030", Offset = "0xB31430", VA = "0x180B32030")]
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xB32040", Offset = "0xB31440", VA = "0x180B32040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x59E08C0", Offset = "0x59DFCC0", VA = "0x1859E08C0")]
		public OKANHHICKAB(LFMDEIGOMOD HPKDJJIICKF, string PEENICAIFOP, T ABINAMGBLJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x59E0460", Offset = "0x59DF860", VA = "0x1859E0460")]
		private void EPPIFJBCAAJ()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly LFMDEIGOMOD HPKDJJIICKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly OKANHHICKAB<TimeSpan> LAABJPAOHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly OKANHHICKAB<TimeSpan> DPCJNDCLBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly OKANHHICKAB<TimeSpan> MHMIDCLEILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly OKANHHICKAB<TimeSpan> KJHOKJJAAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private readonly OKANHHICKAB<bool> ALPNPFHNANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private readonly OKANHHICKAB<bool> GNIGAMKDNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private readonly OKANHHICKAB<bool> AKMBBABBHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly OKANHHICKAB<int> KAHMJCFLPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly OKANHHICKAB<bool> LJAABAIDICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private readonly OKANHHICKAB<bool> BDMCIEHNKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly OKANHHICKAB<IMFBMEFPKNK> PGPJMOODLAI;

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public TimeSpan JIAPNGJLNKG
	{
		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8B2E100", Offset = "0x8B2D500", VA = "0x188B2E100", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public TimeSpan OKFMOAGHBGK
	{
		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x8B2E180", Offset = "0x8B2D580", VA = "0x188B2E180", Slot = "5")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public TimeSpan DHAHGGFIICG
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8B2E0C0", Offset = "0x8B2D4C0", VA = "0x188B2E0C0", Slot = "6")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public TimeSpan LJAFDGCGPHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8B2E1C0", Offset = "0x8B2D5C0", VA = "0x188B2E1C0", Slot = "7")]
		get
		{
			return default(TimeSpan);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool JKBOHCFNCOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8B2E200", Offset = "0x8B2D600", VA = "0x188B2E200", Slot = "8")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool LJOIDJHFJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x8B2E310", Offset = "0x8B2D710", VA = "0x188B2E310", Slot = "9")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool DLBHFCCBKCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8B2E2D0", Offset = "0x8B2D6D0", VA = "0x188B2E2D0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public int EECBCEHAMFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8B2E240", Offset = "0x8B2D640", VA = "0x188B2E240", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool GHPKFNGIMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x8B2E080", Offset = "0x8B2D480", VA = "0x188B2E080", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool GOHCBPBLMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x8B2E140", Offset = "0x8B2D540", VA = "0x188B2E140", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool GNKGPPIJJNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x8B2E280", Offset = "0x8B2D680", VA = "0x188B2E280", Slot = "14")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x8B2E350", Offset = "0x8B2D750", VA = "0x188B2E350")]
	[UnityEngine.Scripting.Preserve]
	public CPPGCJMOKHE([PKIHAALFADL(null)] LFMDEIGOMOD HPKDJJIICKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[UnityEngine.Scripting.Preserve]
internal class GFAPKFJFMJH : IJPBCNJCDLL, EHHOJPPJJPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class FJPCAJKNFGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public NBKAILCGOBA roomEvent;

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public FJPCAJKNFGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8B31A60", Offset = "0x8B30E60", VA = "0x188B31A60")]
		internal object AEOMLBDHJJF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event EIPCGJEPLHG EPJOKBIDHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x8B33960", Offset = "0x8B32D60", VA = "0x188B33960", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8B334A0", Offset = "0x8B328A0", VA = "0x188B334A0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event EIPCGJEPLHG DHNGCEGJFGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x8B33840", Offset = "0x8B32C40", VA = "0x188B33840", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x8B33230", Offset = "0x8B32630", VA = "0x188B33230", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000013")]
	public event EIPCGJEPLHG KLABIGGBJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8B33770", Offset = "0x8B32B70", VA = "0x188B33770", Slot = "8")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x8B33620", Offset = "0x8B32A20", VA = "0x188B33620", Slot = "9")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000014")]
	public event Action<ECCPAABCJNI, bool> LKJKDDJPEFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x8B336C0", Offset = "0x8B32AC0", VA = "0x188B336C0", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x8B33570", Offset = "0x8B32970", VA = "0x188B33570", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "16")]
	public void PJOFCLDPLJB(JNGEBJCPLIA IDEPICHODDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "17")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x8B33540", Offset = "0x8B32940", VA = "0x188B33540", Slot = "12")]
	public void DEKOKKPJIHH(NBKAILCGOBA KKPBBNLOJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x8B33810", Offset = "0x8B32C10", VA = "0x188B33810", Slot = "13")]
	public void HJIJBBKCLJM(NBKAILCGOBA KKPBBNLOJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x8B338E0", Offset = "0x8B32CE0", VA = "0x188B338E0", Slot = "14")]
	public void JKBCFGMCOJM(NBKAILCGOBA KKPBBNLOJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x8B33910", Offset = "0x8B32D10", VA = "0x188B33910", Slot = "15")]
	public void OOOBEFMEMLJ(ECCPAABCJNI MPPPMJJKDDE, bool DLGALHBKJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x8B332D0", Offset = "0x8B326D0", VA = "0x188B332D0")]
	private void COEOEEINBLF(EIPCGJEPLHG IGJIAOCAHMB, NBKAILCGOBA KKPBBNLOJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public GFAPKFJFMJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
[UnityEngine.Scripting.Preserve]
internal class MKMICHOALJH : CNFMKMLJBNK, EHHOJPPJJPL, IDisposable, PEKCJHOIPJA
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private class HNFAPGJNKBE : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct DNFLJPOFNBD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			public HNFAPGJNKBE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public PEKCJHOIPJA.PIIDCPGODEF reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			private NEJBKFDPNPN <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			private KDEBOOHPBMI[] <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			private TaskAwaiter<KDEBOOHPBMI.BADKJBOEJHH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x8B2FE70", Offset = "0x8B2F270", VA = "0x188B2FE70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x8B305F0", Offset = "0x8B2F9F0", VA = "0x188B305F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct PBCHDKJONJL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public AsyncTaskMethodBuilder<KDEBOOHPBMI.BADKJBOEJHH> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			public KDEBOOHPBMI fallbackProvider;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public HNFAPGJNKBE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400013B")]
			public PEKCJHOIPJA.PIIDCPGODEF reason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400013C")]
			private NEJBKFDPNPN <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400013D")]
			private AHODJOEENJM <individualFallbackTaskState>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private TaskAwaiter<KDEBOOHPBMI.BADKJBOEJHH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0x8B49410", Offset = "0x8B48810", VA = "0x188B49410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x8B4A0D0", Offset = "0x8B494D0", VA = "0x188B4A0D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private sealed class KEIKOFJDODC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			public PEKCJHOIPJA.PIIDCPGODEF reason;

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public KEIKOFJDODC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0x8B414B0", Offset = "0x8B408B0", VA = "0x188B414B0")]
			internal object CIKLIGGNJAE((PEKCJHOIPJA.Reason fallbackReason, IENLNGMNILH roomDto, AHODJOEENJM state, string subReason) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class MGDMAKLEDEC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			public KDEBOOHPBMI fallbackProvider;

			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public MGDMAKLEDEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x8B440A0", Offset = "0x8B434A0", VA = "0x188B440A0")]
			internal object KKLMOOOHKNK()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public Task KDHFABGBLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public CancellationTokenSource EBACOGHDBNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public AHODJOEENJM IEDEKBHNHFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public IJIEICICPPB LHIJBEJLBFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public IENLNGMNILH FHANAFAIDPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public AAKDENBOOJG BAGPMCPHKKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public KDEBOOHPBMI[] HEPNCOGCNEF;

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool HBLLBEFBBKP
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x8B2B420", Offset = "0x8B2A820", VA = "0x188B2B420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool IAPCCBNIAGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x8B2B400", Offset = "0x8B2A800", VA = "0x188B2B400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x8B36550", Offset = "0x8B35950", VA = "0x188B36550")]
		public HNFAPGJNKBE(IJIEICICPPB LHIJBEJLBFF, IENLNGMNILH FHANAFAIDPI, AAKDENBOOJG BAGPMCPHKKA, KDEBOOHPBMI[] HEPNCOGCNEF, CancellationToken GMKBGHHNCDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x8B35020", Offset = "0x8B34420", VA = "0x188B35020", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x8B34FB0", Offset = "0x8B343B0", VA = "0x188B34FB0")]
		public void CNNMENHGMEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x8B35EA0", Offset = "0x8B352A0", VA = "0x188B35EA0")]
		public void NGLBENBDEAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x8B349C0", Offset = "0x8B33DC0", VA = "0x188B349C0")]
		public void AJDIGONBIAO(PEKCJHOIPJA.Reason KBAHLCFEKHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8B352D0", Offset = "0x8B346D0", VA = "0x188B352D0")]
		[AsyncStateMachine(typeof(DNFLJPOFNBD))]
		public Task ECAPMJCMFKC(PEKCJHOIPJA.PIIDCPGODEF HBHJOPNAJMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x8B34C90", Offset = "0x8B34090", VA = "0x188B34C90")]
		[AsyncStateMachine(typeof(PBCHDKJONJL))]
		private Task<KDEBOOHPBMI.BADKJBOEJHH> BIFPMPKFPPH(PEKCJHOIPJA.PIIDCPGODEF HBHJOPNAJMN, KDEBOOHPBMI KJKABHMODOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x8B35AE0", Offset = "0x8B34EE0", VA = "0x188B35AE0")]
		private void LMJFKJIFEAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x8B353E0", Offset = "0x8B347E0", VA = "0x188B353E0")]
		public bool FPBPFGHBBMF(PEKCJHOIPJA.Reason CIGFFEDIEAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x8B35C00", Offset = "0x8B35000", VA = "0x188B35C00")]
		private void NEICMNCONGH(AHODJOEENJM JPDKKKJJNLC, PEKCJHOIPJA.PIIDCPGODEF HBHJOPNAJMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x8B34DE0", Offset = "0x8B341E0", VA = "0x188B34DE0")]
		private void CLEBMAAGKBP(AHODJOEENJM JPDKKKJJNLC, KDEBOOHPBMI.BADKJBOEJHH HJBCDFKDKBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8B36010", Offset = "0x8B35410", VA = "0x188B36010")]
		private void PEDMKFMDOHI(AHODJOEENJM JPDKKKJJNLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8B35490", Offset = "0x8B34890", VA = "0x188B35490")]
		private void GENBICJLFKF(AHODJOEENJM JPDKKKJJNLC, KDEBOOHPBMI.BADKJBOEJHH HJBCDFKDKBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x8B35970", Offset = "0x8B34D70", VA = "0x188B35970")]
		private void LAKPAMPDPNC(AHODJOEENJM JPDKKKJJNLC, Exception DGLGDFPJBDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x8B35860", Offset = "0x8B34C60", VA = "0x188B35860")]
		private void JJNAGMNKDGC(KDEBOOHPBMI KJKABHMODOL, PEKCJHOIPJA.PIIDCPGODEF HBHJOPNAJMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8B351C0", Offset = "0x8B345C0", VA = "0x188B351C0")]
		private void EBAKIKMPAHA(KDEBOOHPBMI KJKABHMODOL, PEKCJHOIPJA.Reason HBHJOPNAJMN, string MDIIOAIEJHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x8B361C0", Offset = "0x8B355C0", VA = "0x188B361C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class AHODJOEENJM : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public Task<KDEBOOHPBMI.BADKJBOEJHH> KDHFABGBLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public CancellationTokenSource EBACOGHDBNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public KDEBOOHPBMI KJKABHMODOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public PEKCJHOIPJA.Reason KBAHLCFEKHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public HashSet<PEKCJHOIPJA.Reason> POPIBCHFPOC;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public bool HBLLBEFBBKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x8B2B420", Offset = "0x8B2A820", VA = "0x188B2B420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public bool IAPCCBNIAGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x8B2B400", Offset = "0x8B2A800", VA = "0x188B2B400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x8B2B290", Offset = "0x8B2A690", VA = "0x188B2B290")]
		public void IMAIIMDHCFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8B2B270", Offset = "0x8B2A670", VA = "0x188B2B270", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8B2B440", Offset = "0x8B2A840", VA = "0x188B2B440", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x8B2B7B0", Offset = "0x8B2ABB0", VA = "0x188B2B7B0")]
		public AHODJOEENJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class PAFKKNEOACO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public PEKCJHOIPJA.Reason reason;

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public PAFKKNEOACO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8B492C0", Offset = "0x8B486C0", VA = "0x188B492C0")]
		internal object DLOANLHJIPN(AHODJOEENJM x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x8B493A0", Offset = "0x8B487A0", VA = "0x188B493A0")]
		internal object OJPMJOOIACP(HNFAPGJNKBE x)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x8B49330", Offset = "0x8B48730", VA = "0x188B49330")]
		internal object LCPCDBFPOKD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private struct MGHBJKECONI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public PEKCJHOIPJA.Reason reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public MKMICHOALJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private PAFKKNEOACO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public Exception exception;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8B44120", Offset = "0x8B43520", VA = "0x188B44120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x8B44D50", Offset = "0x8B44150", VA = "0x188B44D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[CompilerGenerated]
	private struct ONJPGOLLLJH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public MKMICHOALJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public PEKCJHOIPJA.PIIDCPGODEF reason;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private HNFAPGJNKBE <localTaskState>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x8B485A0", Offset = "0x8B479A0", VA = "0x188B485A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x8B49260", Offset = "0x8B48660", VA = "0x188B49260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private struct NNEIJLNMAPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public MKMICHOALJH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x8B47310", Offset = "0x8B46710", VA = "0x188B47310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x8B478B0", Offset = "0x8B46CB0", VA = "0x188B478B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	internal static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	internal static readonly AKNCNLDICPO NOJKJFHIEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private JNGEBJCPLIA IDEPICHODDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private IJIEICICPPB LHIJBEJLBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private HNFAPGJNKBE PCMABIEKFNF;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	private CJGDJMIKAIC MJABACAOHLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x8B45BA0", Offset = "0x8B44FA0", VA = "0x188B45BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool EIKPNGDGNCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x26C2E20", Offset = "0x26C2220", VA = "0x1826C2E20", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private bool PCKELKCFFCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8B46480", Offset = "0x8B45880", VA = "0x188B46480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x8B464F0", Offset = "0x8B458F0", VA = "0x188B464F0", Slot = "6")]
	public void PJOFCLDPLJB(JNGEBJCPLIA IDEPICHODDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x8B45BF0", Offset = "0x8B44FF0", VA = "0x188B45BF0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x8B46100", Offset = "0x8B45500", VA = "0x188B46100", Slot = "9")]
	public void IMAIIMDHCFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x8B46020", Offset = "0x8B45420", VA = "0x188B46020")]
	private bool FNKPDAEOCBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x8B45AD0", Offset = "0x8B44ED0", VA = "0x188B45AD0", Slot = "5")]
	private void BOPBIJMJICG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x8B46360", Offset = "0x8B45760", VA = "0x188B46360", Slot = "8")]
	[AsyncStateMachine(typeof(MGHBJKECONI))]
	public Task KONFDCDBCBH(PEKCJHOIPJA.Reason HBHJOPNAJMN, [Optional] Exception GGJDDHMDBJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x8B45C00", Offset = "0x8B45000", VA = "0x188B45C00")]
	private bool EJANEEEDOKJ(PEKCJHOIPJA.PIIDCPGODEF HBHJOPNAJMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x8B45630", Offset = "0x8B44A30", VA = "0x188B45630")]
	private KDEBOOHPBMI[] BINMJJNBEEK(AAKDENBOOJG GFIJOKENNGP, IENLNGMNILH GBFKGLLKGCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x8B45F00", Offset = "0x8B45300", VA = "0x188B45F00")]
	[AsyncStateMachine(typeof(ONJPGOLLLJH))]
	private Task FHLJENGFAAH(PEKCJHOIPJA.PIIDCPGODEF HBHJOPNAJMN, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x8B46290", Offset = "0x8B45690", VA = "0x188B46290")]
	[AsyncStateMachine(typeof(NNEIJLNMAPM))]
	private Task JHAKMLFFKDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public MKMICHOALJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[RecRoom.NoEngine.Common.Preserve]
internal class IGBDEAICEPH : PJPBKECLNGI, EHHOJPPJJPL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private struct KNIANIOOPAO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public AAKDENBOOJG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public IGBDEAICEPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public GOFJAADJDOP customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8B427B0", Offset = "0x8B41BB0", VA = "0x188B427B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x8B43120", Offset = "0x8B42520", VA = "0x188B43120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	private struct DJHCEBBDBNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public IGBDEAICEPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public AAKDENBOOJG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public GOFJAADJDOP customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private CIIMOEPMPCG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private NEJBKFDPNPN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private BHMBHHAEFLE <joinRoomInstancePauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private OCNGNNCGAPE <analyticsData>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x8B2ECC0", Offset = "0x8B2E0C0", VA = "0x188B2ECC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x8B2FE10", Offset = "0x8B2F210", VA = "0x188B2FE10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class OJKBJMMKFOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public Matchmaking.MIBDOLNHAPA result;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public CGLANNGJMPD errorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public OJKBJMMKFOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x8B48270", Offset = "0x8B47670", VA = "0x188B48270")]
		internal object OGGPHPBALKP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class KHCHKLOBOKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public Task<BGMNPHKELEH> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public KHCHKLOBOKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		internal Task<BGMNPHKELEH> CEIJMPAMJMB(CIIMOEPMPCG<string>.MOMGGNPHIKH _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	private struct IMMEGLKPODN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public IGBDEAICEPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public AAKDENBOOJG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public GOFJAADJDOP customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public BHMBHHAEFLE joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private KHCHKLOBOKJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private JIIIHNJCLKF <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private NEJBKFDPNPN <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private MOMLBLNPBLC <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private Task<Matchmaking.CKKBBHCKHDD> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private KCCPMKODHHM <>7__wrap10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private CancellationTokenSource <cameraFadeCts>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <>7__wrap12;

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
		private TaskAwaiter<Matchmaking.CKKBBHCKHDD> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private CancellationToken <photonJoinedToken>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private Task <roomLoadTask>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private TaskAwaiter<BGMNPHKELEH> <>u__4;

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8B3B8F0", Offset = "0x8B3ACF0", VA = "0x188B3B8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8B41250", Offset = "0x8B40650", VA = "0x188B41250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class DJHDFLOPMDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public Task<BGMNPHKELEH> roomLoadRequestPayloadTask;

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public DJHDFLOPMDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		internal Task<BGMNPHKELEH> DPJJCLGFDGF(CIIMOEPMPCG<string>.MOMGGNPHIKH _)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	private struct FDLDGLOOKBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public IGBDEAICEPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public AAKDENBOOJG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public GOFJAADJDOP customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public BHMBHHAEFLE joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private JIIIHNJCLKF <multiProgressTracker>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private IDisposable <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private NEJBKFDPNPN <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <connectToRoomAndRunLoadLogicTimer>5__5;

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
		private MOMLBLNPBLC <preOperationProgressTracker>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private Task<Matchmaking.CKKBBHCKHDD> <serverConnectionInfoTask>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private BGMNPHKELEH <initialRoomLoadPayload>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private NOFPNMHOLJE <preloadContext>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private TaskAwaiter<BGMNPHKELEH> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private KCCPMKODHHM <>7__wrap12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private Task <loadEmptySceneTask>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private BEOHMGGJGFD <sceneManagementService>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private EPEDKBIKHMJ <scenePreloadRequest>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private CancellationTokenSource <cameraFadeCts>5__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <>7__wrap17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private TaskAwaiter<FNBLNBOMKEN> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private int <i>5__19;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private YieldAwaitable.YieldAwaiter <>u__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private TaskAwaiter<Matchmaking.CKKBBHCKHDD> <>u__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private CancellationToken <photonJoinedToken>5__20;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private Task <roomLoadTask>5__21;

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8B52870", Offset = "0x8B51C70", VA = "0x188B52870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8B57ED0", Offset = "0x8B572D0", VA = "0x188B57ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	private struct KOINFNPADEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public IGBDEAICEPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <disconnectTimerScope>5__3;

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
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x8B62AF0", Offset = "0x8B61EF0", VA = "0x188B62AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x8B63560", Offset = "0x8B62960", VA = "0x188B63560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private struct DBFPHPCHHNL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public IGBDEAICEPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private JFAGCPCLAAF <roomContainer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x8B50F20", Offset = "0x8B50320", VA = "0x188B50F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x8B513A0", Offset = "0x8B507A0", VA = "0x188B513A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private struct HNMPAAJPHCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public AsyncTaskMethodBuilder<Matchmaking.CKKBBHCKHDD> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public AAKDENBOOJG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public IGBDEAICEPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private TaskAwaiter<Matchmaking.CKKBBHCKHDD> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x8B5D9A0", Offset = "0x8B5CDA0", VA = "0x188B5D9A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x8B5DE70", Offset = "0x8B5D270", VA = "0x188B5DE70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private struct AMGAPMALCMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public Matchmaking.CKKBBHCKHDD serverConnectionInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public IGBDEAICEPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public BHMBHHAEFLE joinRoomInstancePauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public CancellationToken roomCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private TaskAwaiter<ONMPGPIAOIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x8B4CD10", Offset = "0x8B4C110", VA = "0x188B4CD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D350", Offset = "0x8B4C750", VA = "0x188B4D350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class HAMANMLDAAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public Task roomLoadTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public AAKDENBOOJG targetInstance;

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
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public HAMANMLDAAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8B5A010", Offset = "0x8B59410", VA = "0x188B5A010")]
		internal object OJBPNFFMJJB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8B59F10", Offset = "0x8B59310", VA = "0x188B59F10")]
		internal string ILAAPPCACDD()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private struct CHDOCPGLHME : IAsyncStateMachine
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
		public AAKDENBOOJG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public IGBDEAICEPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private HAMANMLDAAH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public CancellationTokenSource roomLoadTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private NEJBKFDPNPN <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x8B500A0", Offset = "0x8B4F4A0", VA = "0x188B500A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x8B50C40", Offset = "0x8B50040", VA = "0x188B50C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private struct JLKEMKMNNAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public IGBDEAICEPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		public BHMBHHAEFLE joinRoomInstanceToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public CancellationToken roomJoinCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		public BGMNPHKELEH initialRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public AAKDENBOOJG targetRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		public NOFPNMHOLJE preloadContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		public JIIIHNJCLKF progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <roomLoadLogicTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x8B5EDA0", Offset = "0x8B5E1A0", VA = "0x188B5EDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x8B5F590", Offset = "0x8B5E990", VA = "0x188B5F590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	private struct KKDAHJIKICA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		public IGBDEAICEPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <spawnLocalPlayerTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private NEJBKFDPNPN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <>7__wrap3;

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
		private NEJBKFDPNPN <>7__wrap5;

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
		[Cpp2IlInjected.Address(RVA = "0x8B5F9F0", Offset = "0x8B5EDF0", VA = "0x188B5F9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8B611D0", Offset = "0x8B605D0", VA = "0x188B611D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	private struct NFPDHIGBDPE : IAsyncStateMachine
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
		public JPNNICBILFM localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		public IGBDEAICEPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private TaskAwaiter<LALFMHKAHCO> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8B67BE0", Offset = "0x8B66FE0", VA = "0x188B67BE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x8B683D0", Offset = "0x8B677D0", VA = "0x188B683D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class KNFALIHDNKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		public AAKDENBOOJG targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public KNFALIHDNKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8B61410", Offset = "0x8B60810", VA = "0x188B61410")]
		internal object BLHFMGPPFFH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class OBJEJCHDIBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public long targetInstanceId;

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public OBJEJCHDIBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x8B68BB0", Offset = "0x8B67FB0", VA = "0x188B68BB0")]
		internal void AOLCDJAJOLK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class DDCMCNOGLHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public AAKDENBOOJG targetInstance;

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public DDCMCNOGLHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x8B51400", Offset = "0x8B50800", VA = "0x188B51400")]
		internal object OONNJLHJGLH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class BJJAGFDDOMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		public AAKDENBOOJG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public Task whileInRoomTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public Task roomLoadTask;

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public BJJAGFDDOMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DF20", Offset = "0x8B4D320", VA = "0x188B4DF20")]
		internal string POMLLIJPNEC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static readonly AKNCNLDICPO HJOOONGOFPB;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static readonly AKNCNLDICPO LPJMGPOIAJN;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static readonly AKNCNLDICPO BJKMPFMEPBM;

	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private static readonly string EMIEOPPICCL;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private static readonly string LDIJCNNCNBD;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private static readonly string FJOPGCBODPF;

	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public static readonly Guid DPPHHJGKFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private EOLAJDKNPJP CDNGDNLHLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private GJDFEKLPFLO LPFMFOJPEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private CFAOIDGAGLN KMFAHFKEGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private JNGEBJCPLIA IDEPICHODDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private IJIEICICPPB LHIJBEJLBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private CNFMKMLJBNK EOFDBLMIHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private OHGELLMBBCH JGGICGFGJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private IJPBCNJCDLL LIBOFBBNJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private LBKIPKPPCBG NLMHGAIPIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private AMBHINONLEP DLDNLMOAPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private IDisposable IIDDLEPOFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private OGJJOHIHALN FECJHCJFEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly ACAHCPOBLDI FHDNLOAJGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private KCCPMKODHHM HCKIHGIENHO;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public TaskStatus EBPGGHOMDMC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xA96380", Offset = "0xA95780", VA = "0x180A96380", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(TaskStatus);
		}
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x1580E90", Offset = "0x1580290", VA = "0x181580E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private CJGDJMIKAIC MJABACAOHLE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x8B38B40", Offset = "0x8B37F40", VA = "0x188B38B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x8B3B1C0", Offset = "0x8B3A5C0", VA = "0x188B3B1C0", Slot = "6")]
	public void PJOFCLDPLJB(JNGEBJCPLIA IDEPICHODDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x8B394A0", Offset = "0x8B388A0", VA = "0x188B394A0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x8B387B0", Offset = "0x8B37BB0", VA = "0x188B387B0", Slot = "5")]
	[AsyncStateMachine(typeof(KNIANIOOPAO))]
	public Task ALDKHNJMJME(AAKDENBOOJG EDHCJOGBCNG, GOFJAADJDOP OEBIGJLGLNB, CancellationToken NILMHHOPMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x8B39650", Offset = "0x8B38A50", VA = "0x188B39650")]
	[AsyncStateMachine(typeof(DJHCEBBDBNA))]
	private Task FDEMPHJBJFG(AAKDENBOOJG EDHCJOGBCNG, GOFJAADJDOP OEBIGJLGLNB, CancellationToken NILMHHOPMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x8B3A310", Offset = "0x8B39710", VA = "0x188B3A310")]
	private void KOKJLOGBOGK(LBKIPKPPCBG NLMHGAIPIGF, AAKDENBOOJG EDHCJOGBCNG, Exception DGLGDFPJBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x8B37E30", Offset = "0x8B37230", VA = "0x188B37E30")]
	private static void ADNJFKIEMEG(OCNGNNCGAPE IEEBGEIIHHN, Exception DGLGDFPJBDB, [Optional] List<int> JFOOEGEHIMC, int OJDPLMDFPJJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x8B3AE00", Offset = "0x8B3A200", VA = "0x188B3AE00")]
	[AsyncStateMachine(typeof(IMMEGLKPODN))]
	private Task PELIFLICLKJ(CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN, AAKDENBOOJG EDHCJOGBCNG, GOFJAADJDOP OEBIGJLGLNB, BHMBHHAEFLE HGHBLFAMMLE, CancellationToken NILMHHOPMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x8B3B4E0", Offset = "0x8B3A8E0", VA = "0x188B3B4E0")]
	[AsyncStateMachine(typeof(FDLDGLOOKBM))]
	private Task PMOHOIPKJHL(CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN, AAKDENBOOJG EDHCJOGBCNG, GOFJAADJDOP OEBIGJLGLNB, BHMBHHAEFLE HGHBLFAMMLE, CancellationToken NILMHHOPMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x8B38B90", Offset = "0x8B37F90", VA = "0x188B38B90")]
	private void CHKJCBGFDPP([CallerMemberName] string DOJALFINAIF = "<unknown>")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x8B39D10", Offset = "0x8B39110", VA = "0x188B39D10")]
	[AsyncStateMachine(typeof(KOINFNPADEC))]
	private Task JAOHIKOOKKC(CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x8B38D10", Offset = "0x8B38110", VA = "0x188B38D10")]
	private void CLCKIOCHLCD(AAKDENBOOJG EDHCJOGBCNG, CancellationToken NILMHHOPMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x8B3AF60", Offset = "0x8B3A360", VA = "0x188B3AF60")]
	private void PIHHLLPAEGC(AAKDENBOOJG EDHCJOGBCNG, TaskStatus CHLOFLMLPBP, string AFDNIPHJHMO, BHMBHHAEFLE HGHBLFAMMLE, Exception GGJDDHMDBJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x8B39190", Offset = "0x8B38590", VA = "0x188B39190")]
	private void CPCBOPOGGIH(AAKDENBOOJG EDHCJOGBCNG, BHMBHHAEFLE HGHBLFAMMLE, OperationCanceledException FHEHAOHMBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x8B39210", Offset = "0x8B38610", VA = "0x188B39210")]
	private void DDACLJLBPDJ(AAKDENBOOJG EDHCJOGBCNG, BHMBHHAEFLE HGHBLFAMMLE, Exception DGLGDFPJBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x8B3AAC0", Offset = "0x8B39EC0", VA = "0x188B3AAC0")]
	private void OOHBFJAAOMN(AAKDENBOOJG EDHCJOGBCNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x8B3A780", Offset = "0x8B39B80", VA = "0x188B3A780")]
	private static NBKAILCGOBA LGKAEHNFEOH(AAKDENBOOJG EDHCJOGBCNG)
	{
		return default(NBKAILCGOBA);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x8B38A70", Offset = "0x8B37E70", VA = "0x188B38A70")]
	[AsyncStateMachine(typeof(DBFPHPCHHNL))]
	private Task CEOMDGKMIIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x8B394F0", Offset = "0x8B388F0", VA = "0x188B394F0")]
	[AsyncStateMachine(typeof(HNMPAAJPHCP))]
	private Task<Matchmaking.CKKBBHCKHDD> EFKFKGBOCAN(AAKDENBOOJG EDHCJOGBCNG, CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x8B398F0", Offset = "0x8B38CF0", VA = "0x188B398F0")]
	private static ONMPGPIAOIL GJPPOABIEJF(Matchmaking.CKKBBHCKHDD OGCHIAEJIEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x8B39040", Offset = "0x8B38440", VA = "0x188B39040")]
	[AsyncStateMachine(typeof(AMGAPMALCMC))]
	private Task CMJAIEGPHLP(Matchmaking.CKKBBHCKHDD OGCHIAEJIEG, BHMBHHAEFLE HGHBLFAMMLE, CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN, CancellationToken KCJNNEDMKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x8B38670", Offset = "0x8B37A70", VA = "0x188B38670")]
	[AsyncStateMachine(typeof(CHDOCPGLHME))]
	private Task AKLGCICGCMJ(AAKDENBOOJG EDHCJOGBCNG, CancellationTokenSource LHFMNOECPLN, Task MIOMCJBGHCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0x8B388F0", Offset = "0x8B37CF0", VA = "0x188B388F0")]
	[AsyncStateMachine(typeof(JLKEMKMNNAJ))]
	private Task AOGJFIPMIGG(BGMNPHKELEH PCAGCICDLCG, JIIIHNJCLKF AMFBNPOGHAA, AAKDENBOOJG CDCJNEPLOGK, BHMBHHAEFLE JLAJJIMNIOD, CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN, CancellationToken JJLDFFOKBAC, [Optional] NOFPNMHOLJE NFIHGODFMOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x8B39FE0", Offset = "0x8B393E0", VA = "0x188B39FE0")]
	private BHMBHHAEFLE KDABKJHHMBE(BHMBHHAEFLE JLAJJIMNIOD, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x8B3A1D0", Offset = "0x8B395D0", VA = "0x188B3A1D0")]
	[AsyncStateMachine(typeof(KKDAHJIKICA))]
	private Task KEIKDDMNDOM(CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x8B3ACD0", Offset = "0x8B3A0D0", VA = "0x188B3ACD0")]
	[AsyncStateMachine(typeof(NFPDHIGBDPE))]
	private Task OPNIGIINEAH(CancellationToken GMKBGHHNCDJ, int FNJHLEOJHLA, JPNNICBILFM FLDGFFCOMHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x8B39B90", Offset = "0x8B38F90", VA = "0x188B39B90")]
	private static void HPNLBGNMHLL(AAKDENBOOJG EDHCJOGBCNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x8B3A870", Offset = "0x8B39C70", VA = "0x188B3A870")]
	private void MMDECHOLKDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x8B39B00", Offset = "0x8B38F00", VA = "0x188B39B00")]
	private void GPKIAICAMBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x8B3A7E0", Offset = "0x8B39BE0", VA = "0x188B3A7E0")]
	private void LMPNLPKAEEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x8B39F50", Offset = "0x8B39350", VA = "0x188B39F50")]
	private void KBFOFABNHHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x8B397A0", Offset = "0x8B38BA0", VA = "0x188B397A0")]
	private static void GBHOENMOPGF(AAKDENBOOJG EDHCJOGBCNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x8B39E40", Offset = "0x8B39240", VA = "0x188B39E40")]
	private static CancellationTokenRegistration KAPAHCFOCIJ(AAKDENBOOJG EDHCJOGBCNG, CancellationToken KCJNNEDMKPG)
	{
		return default(CancellationTokenRegistration);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x8B39A00", Offset = "0x8B38E00", VA = "0x188B39A00")]
	private static void GMALOBABICG(AAKDENBOOJG EDHCJOGBCNG, Exception DGLGDFPJBDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x8B392F0", Offset = "0x8B386F0", VA = "0x188B392F0")]
	private void DPPNMOOBGIB(AAKDENBOOJG EDHCJOGBCNG, Task MIOMCJBGHCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x8B39890", Offset = "0x8B38C90", VA = "0x188B39890")]
	private static void GJFBEGANDPI(Func<string> KMNBOEKAFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x8B3B860", Offset = "0x8B3AC60", VA = "0x188B3B860")]
	public IGBDEAICEPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x8B39290", Offset = "0x8B38690", VA = "0x188B39290")]
	[CompilerGenerated]
	internal static (int, int?) DGOCJOFPHHN(CGLANNGJMPD FCDCKNGNLFJ)
	{
		return default((int, int?));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[RecRoom.NoEngine.Common.Preserve]
internal class LFEMLNNCOPO : LLMBDMOEJHN, EHHOJPPJJPL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	private struct LNDCMGCPAIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		public LFEMLNNCOPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		public JPNNICBILFM localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8B66170", Offset = "0x8B65570", VA = "0x188B66170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x8B66650", Offset = "0x8B65A50", VA = "0x188B66650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class BKDABJHMONB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		public LFEMLNNCOPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		public JPNNICBILFM localPlayerAccountRoleType;

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public BKDABJHMONB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8B4E020", Offset = "0x8B4D420", VA = "0x188B4E020")]
		internal List<Task> BDOLADBNIFK(CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private struct KILKKAIDHLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		public KJCCMEEKOGD taskBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public int roomTotalVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		public JPNNICBILFM localPlayerAccountRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8B5F5F0", Offset = "0x8B5E9F0", VA = "0x188B5F5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8B5F990", Offset = "0x8B5ED90", VA = "0x188B5F990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct HGBNFIDPEAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public LFEMLNNCOPO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x8B5A170", Offset = "0x8B59570", VA = "0x188B5A170", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x8B5A450", Offset = "0x8B59850", VA = "0x188B5A450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private readonly HashSet<KJCCMEEKOGD> IGJBKKAPNOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private GJDFEKLPFLO LPFMFOJPEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private JNGEBJCPLIA IDEPICHODDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private HGKAPEFBFIF GIOAPPDLHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private CMGILKHKFOG HDKKHPCHOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private IDisposable IIDDLEPOFBG;

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x8B64990", Offset = "0x8B63D90", VA = "0x188B64990", Slot = "5")]
	public void PJOFCLDPLJB(JNGEBJCPLIA IDEPICHODDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x8B641B0", Offset = "0x8B635B0", VA = "0x188B641B0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x8B64500", Offset = "0x8B63900", VA = "0x188B64500", Slot = "4")]
	public bool KLEKKPCEPLE(KJCCMEEKOGD DEEAABMNOFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x8B642E0", Offset = "0x8B636E0", VA = "0x188B642E0")]
	private void IKFHLNNOPKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x8B64770", Offset = "0x8B63B70", VA = "0x188B64770")]
	private void MLEDIIFCADP(PJKBEIHEIIE PHIIDLOGBDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x8B64680", Offset = "0x8B63A80", VA = "0x188B64680")]
	[AsyncStateMachine(typeof(LNDCMGCPAIL))]
	private Task LCLMAAAIKPN(int FNJHLEOJHLA, JPNNICBILFM FLDGFFCOMHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x8B64210", Offset = "0x8B63610", VA = "0x188B64210")]
	private Func<CancellationToken, List<Task>> GAIBDCDNOAA(int FNJHLEOJHLA, JPNNICBILFM FLDGFFCOMHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x8B63C80", Offset = "0x8B63080", VA = "0x188B63C80")]
	private List<Task> CIAEBHJFDDA(int FNJHLEOJHLA, JPNNICBILFM FLDGFFCOMHI, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x8B64560", Offset = "0x8B63960", VA = "0x188B64560")]
	[AsyncStateMachine(typeof(KILKKAIDHLI))]
	private Task LBBOOEGPKFC(KJCCMEEKOGD MEBGBNKILEM, CancellationToken MONGIMOHLAO, int FNJHLEOJHLA, JPNNICBILFM FLDGFFCOMHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x8B64430", Offset = "0x8B63830", VA = "0x188B64430")]
	[AsyncStateMachine(typeof(HGBNFIDPEAN))]
	private Task IPKLGCPDMPA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x8B643B0", Offset = "0x8B637B0", VA = "0x188B643B0")]
	private void IMAIIMDHCFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x8B64C70", Offset = "0x8B64070", VA = "0x188B64C70")]
	public LFEMLNNCOPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
[UnityEngine.Scripting.Preserve]
internal sealed class CALPCGEBHNO : AOMCGKJFJCA, EHHOJPPJJPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class AOOOMFMAGAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public AOOOMFMAGAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D410", Offset = "0x8B4C810", VA = "0x188B4D410")]
		internal object BMMBHKNJAID()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class JDKEEDOEEDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public JDKEEDOEEDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x8B5E540", Offset = "0x8B5D940", VA = "0x188B5E540")]
		internal object IGNLHHPACID()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class PAOACCBONIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public PAOACCBONIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class FMKPDFHGLOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public FMKPDFHGLOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x8B57FC0", Offset = "0x8B573C0", VA = "0x188B57FC0")]
		internal object NEJEJIOOGNK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class GBPCEDHCPAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public GBPCEDHCPAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x8B58760", Offset = "0x8B57B60", VA = "0x188B58760")]
		internal object HNCLEFKFHMB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private readonly Dictionary<Guid, AJHNMFINGKH> OMLFHJOFHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private readonly TimeSpan HIJOPIKDCAA;

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "9")]
	public void PJOFCLDPLJB(JNGEBJCPLIA IDEPICHODDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x8B4F020", Offset = "0x8B4E420", VA = "0x188B4F020", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x8B4F260", Offset = "0x8B4E660", VA = "0x188B4F260", Slot = "4")]
	public IENGDNGCKLK KOBMLIBBKBO(Guid PADGMLDAJOI)
	{
		return default(IENGDNGCKLK);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x8B4EE10", Offset = "0x8B4E210", VA = "0x188B4EE10", Slot = "5")]
	public bool CBDHBFLGDII(Guid PADGMLDAJOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x8B4F480", Offset = "0x8B4E880", VA = "0x188B4F480", Slot = "6")]
	public bool LIMIHNPAIHA(Guid PADGMLDAJOI, Task JFLMKLJIJJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x8B4EC30", Offset = "0x8B4E030", VA = "0x188B4EC30", Slot = "7")]
	public bool BGEHJHLHFGD(Guid PADGMLDAJOI, LALFMHKAHCO ONBHNOJBNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x8B4F7B0", Offset = "0x8B4EBB0", VA = "0x188B4F7B0", Slot = "8")]
	public Task<(LALFMHKAHCO, Task)> PEGJMCLFKNL(Guid PADGMLDAJOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x8B4F030", Offset = "0x8B4E430", VA = "0x188B4F030")]
	private void EMFCACKOFED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x8B4F820", Offset = "0x8B4EC20", VA = "0x188B4F820")]
	public CALPCGEBHNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
[RecRoom.NoEngine.Common.Preserve]
internal class KNHCHMPOCOF : KFBFGIMCKBO, EHHOJPPJJPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	private class OENODBIONCC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private readonly AAKDENBOOJG HNHBEJCGLAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private readonly CancellationTokenSource HAGAAAKNION;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public readonly CancellationToken CKBDJOFGFBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private bool ODIBHKHEIAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private bool EGNOAKFAPLF;

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x8B69A90", Offset = "0x8B68E90", VA = "0x188B69A90")]
		public OENODBIONCC(AAKDENBOOJG HNHBEJCGLAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x8B69940", Offset = "0x8B68D40", VA = "0x188B69940")]
		public void IMAIIMDHCFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x8B69910", Offset = "0x8B68D10", VA = "0x188B69910", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class FKLFAOAKNLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public NLAHKKKCINO disconnectCause;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public FKLFAOAKNLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x8B57F30", Offset = "0x8B57330", VA = "0x188B57F30")]
		internal object OBDNMMGOMGA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private struct CGJGCKNHGDM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public NLAHKKKCINO disconnectCause;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public KNHCHMPOCOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x8B4FBE0", Offset = "0x8B4EFE0", VA = "0x188B4FBE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x8B50040", Offset = "0x8B4F440", VA = "0x188B50040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class APCCDCHLCIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		public int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		public KNHCHMPOCOF <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public APCCDCHLCIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D470", Offset = "0x8B4C870", VA = "0x188B4D470")]
		internal object PEBBBDNEMHF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class IKMBHLKFGAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		public AAKDENBOOJG newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public APCCDCHLCIP CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public IKMBHLKFGAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x8B5DEE0", Offset = "0x8B5D2E0", VA = "0x188B5DEE0")]
		internal object ILNEPEDPBCB((AAKDENBOOJG lastLocalPlayerRoomInstance, AAKDENBOOJG newRoomInstance, CNFMKMLJBNK fallbacks) x)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private struct OIPOFCHIGIC : IAsyncStateMachine
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
		public KNHCHMPOCOF <>4__this;

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
		private NEJBKFDPNPN <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x8B6A1B0", Offset = "0x8B695B0", VA = "0x188B6A1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0xAC9F20", Offset = "0xAC9320", VA = "0x180AC9F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class CHPFIJFNOML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public AAKDENBOOJG newRoomInstance;

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public CHPFIJFNOML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x8B50D20", Offset = "0x8B50120", VA = "0x188B50D20")]
		internal object NJAILKBEHPJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x8B50DC0", Offset = "0x8B501C0", VA = "0x188B50DC0")]
		internal void OAEBLFKPEEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x8B50CA0", Offset = "0x8B500A0", VA = "0x188B50CA0")]
		internal object IOPAMCKGEHI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x8B50CE0", Offset = "0x8B500E0", VA = "0x188B50CE0")]
		internal object MLFGPCGEANM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct HHEMPPPLBHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public AAKDENBOOJG newRoomInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public KNHCHMPOCOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public GOFJAADJDOP customRoomLoadPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private CHPFIJFNOML <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private NEJBKFDPNPN <>7__wrap1;

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
		[Cpp2IlInjected.Address(RVA = "0x8B5A4B0", Offset = "0x8B598B0", VA = "0x188B5A4B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B480", Offset = "0x8B5A880", VA = "0x188B5B480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static readonly GBFMLFHGLKE.MCGHBMLKHOP FHAMEKCALPG;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static readonly HMDPMDHAOOB FBOJGKHAHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private GJDFEKLPFLO LPFMFOJPEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private JNGEBJCPLIA IDEPICHODDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private CNFMKMLJBNK EOFDBLMIHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private IJIEICICPPB LHIJBEJLBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private OGFKANFAGPF HFDKCBHNBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private PJPBKECLNGI GPEHJJBHHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private AAKDENBOOJG IPHEHJKBHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private OENODBIONCC BMJPCJAMJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private bool EHFJIHECJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private Task PKDOGGMKCBL;

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private CJGDJMIKAIC MJABACAOHLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x8B615E0", Offset = "0x8B609E0", VA = "0x188B615E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool NMMMPDECBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0xAD9120", Offset = "0xAD8520", VA = "0x180AD9120")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x8B61DD0", Offset = "0x8B611D0", VA = "0x188B61DD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x8B62330", Offset = "0x8B61730", VA = "0x188B62330", Slot = "4")]
	public void PJOFCLDPLJB(JNGEBJCPLIA IDEPICHODDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x8B61A30", Offset = "0x8B60E30", VA = "0x188B61A30", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x8B61940", Offset = "0x8B60D40", VA = "0x188B61940")]
	[AsyncStateMachine(typeof(CGJGCKNHGDM))]
	private Task DMJLFPNAMKP(NLAHKKKCINO JCDJHKGFDDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x8B617B0", Offset = "0x8B60BB0", VA = "0x188B617B0")]
	private void DDOPFDKNJDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x8B62080", Offset = "0x8B61480", VA = "0x188B62080")]
	private void MDKFEFJOAAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x8B61630", Offset = "0x8B60A30", VA = "0x188B61630")]
	private void CIJKFFAAPBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x8B625D0", Offset = "0x8B619D0", VA = "0x188B625D0")]
	private bool PMEFEDCBJBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x8B62210", Offset = "0x8B61610", VA = "0x188B62210")]
	[AsyncStateMachine(typeof(OIPOFCHIGIC))]
	private void OHCPEMLCHGK(int BDBJAOEOBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x8B61DE0", Offset = "0x8B611E0", VA = "0x188B61DE0")]
	private void LOELKHBBOMI([Out] IDisposable IGPACADMHMF, [Out] IDisposable NFFIENEEACF, [Out] IDisposable CIAPICOMFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x8B61BA0", Offset = "0x8B60FA0", VA = "0x188B61BA0")]
	private bool ENGHLOGCIFF(AAKDENBOOJG HNHBEJCGLAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x8B622E0", Offset = "0x8B616E0", VA = "0x188B622E0")]
	private void OPEDNANEPHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x8B61CA0", Offset = "0x8B610A0", VA = "0x188B61CA0")]
	[AsyncStateMachine(typeof(HHEMPPPLBHK))]
	private Task FDEMPHJBJFG(AAKDENBOOJG HNHBEJCGLAG, GOFJAADJDOP OEBIGJLGLNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x8B62A10", Offset = "0x8B61E10", VA = "0x188B62A10")]
	public KNHCHMPOCOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[UnityEngine.Scripting.Preserve]
internal sealed class LJHNPJHOLOP : DJEPMJOLNDO, EHHOJPPJJPL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct CEEFHMDPLCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public AsyncTaskMethodBuilder<HFLIPKNADKN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public LJHNPJHOLOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public CancellationToken throwOnRequestCancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private TaskAwaiter<HFLIPKNADKN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x8B4F8E0", Offset = "0x8B4ECE0", VA = "0x188B4F8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x8B4FB70", Offset = "0x8B4EF70", VA = "0x188B4FB70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class AIPJJBBCILG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public HNBAHPJPPAI message;

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public AIPJJBBCILG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x8B4CCB0", Offset = "0x8B4C0B0", VA = "0x188B4CCB0")]
		internal object AOMNEBIHGNG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class DOCGPPIIDKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public HNBAHPJPPAI messageFromMaster;

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public DOCGPPIIDKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x8B51480", Offset = "0x8B50880", VA = "0x188B51480")]
		internal object NBEKGFCPGHE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class OEJGMBHJOFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public HNBAHPJPPAI request;

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public OEJGMBHJOFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x8B698B0", Offset = "0x8B68CB0", VA = "0x188B698B0")]
		internal object EBLHNJAGNPB()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private struct BDLINFEELKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public HNBAHPJPPAI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public LJHNPJHOLOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private TaskAwaiter<KKGNFEOCIOB> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D590", Offset = "0x8B4C990", VA = "0x188B4D590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DE60", Offset = "0x8B4D260", VA = "0x188B4DE60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class HBJBLNJIECH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public HNBAHPJPPAI operationStartMessage;

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public HBJBLNJIECH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x8B5A110", Offset = "0x8B59510", VA = "0x188B5A110")]
		internal object DNDGBJHDHEC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private struct BOPAFBCCCNB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public HNBAHPJPPAI operationStartMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public LJHNPJHOLOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private CancellationTokenSource <cancellationTokenSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private BHMBHHAEFLE <pauseToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private TaskAwaiter<HNBAHPJPPAI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x8B4E060", Offset = "0x8B4D460", VA = "0x188B4E060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x8B4EBD0", Offset = "0x8B4DFD0", VA = "0x188B4EBD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private struct IOGKBBHJJBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public AsyncTaskMethodBuilder<KKGNFEOCIOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public LJHNPJHOLOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public HNBAHPJPPAI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private KIHLBJENPPP.HBJFAHPKGML <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private BHMBHHAEFLE <pauseToken>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private TaskAwaiter<HNBAHPJPPAI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x8B5DFA0", Offset = "0x8B5D3A0", VA = "0x188B5DFA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x8B5E4D0", Offset = "0x8B5D8D0", VA = "0x188B5E4D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class CKCPEDPKLKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public KKGNFEOCIOB operation;

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public CKCPEDPKLKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x8B50E40", Offset = "0x8B50240", VA = "0x188B50E40")]
		internal object MBFMFHPIFAO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private struct ODOCEOCDCKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public KKGNFEOCIOB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public LJHNPJHOLOP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private CIIMOEPMPCG<string> <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x8B69220", Offset = "0x8B68620", VA = "0x188B69220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x8B69850", Offset = "0x8B68C50", VA = "0x188B69850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private sealed class BGMNFGINMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		public HNBAHPJPPAI request;

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public BGMNFGINMAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x8B4DEC0", Offset = "0x8B4D2C0", VA = "0x188B4DEC0")]
		internal object IIHFANBLBKE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class LBHLAEFKOKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public HNBAHPJPPAI request;

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public LBHLAEFKOKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x8B635C0", Offset = "0x8B629C0", VA = "0x188B635C0")]
		internal object PCNFKJDFJFO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private JNGEBJCPLIA IDEPICHODDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private OHGELLMBBCH JGGICGFGJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private MPJEHHCGJLJ GENHELHGMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private EAEHMHEANPP NEEDNELMJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private CFAOIDGAGLN KMFAHFKEGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private TaskCompletionSource<HFLIPKNADKN> LACJKPAMGLD;

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x8B65C20", Offset = "0x8B65020", VA = "0x188B65C20", Slot = "7")]
	public void PJOFCLDPLJB(JNGEBJCPLIA IDEPICHODDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x8B652B0", Offset = "0x8B646B0", VA = "0x188B652B0", Slot = "6")]
	[AsyncStateMachine(typeof(CEEFHMDPLCM))]
	public Task<HFLIPKNADKN> FHKFCENCKFH(CancellationToken IPACAKKFECM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x8B653C0", Offset = "0x8B647C0", VA = "0x188B653C0", Slot = "4")]
	public void IIMPPFDBDFB(HNBAHPJPPAI AFDNIPHJHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x8B65730", Offset = "0x8B64B30", VA = "0x188B65730", Slot = "5")]
	public void JBHBFNCNNIF(HNBAHPJPPAI NILDHKJFGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x8B65090", Offset = "0x8B64490", VA = "0x188B65090")]
	[AsyncStateMachine(typeof(BDLINFEELKM))]
	private Task FCGALKJKFFM(HNBAHPJPPAI IDLJGJGIGEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x8B651A0", Offset = "0x8B645A0", VA = "0x188B651A0")]
	[AsyncStateMachine(typeof(BOPAFBCCCNB))]
	private Task FFOEGFLGINC(HNBAHPJPPAI FDOJJFNNFOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x8B65F20", Offset = "0x8B65320", VA = "0x188B65F20")]
	[AsyncStateMachine(typeof(IOGKBBHJJBB))]
	private Task<KKGNFEOCIOB> PNJMCFBLFAK(HNBAHPJPPAI IDLJGJGIGEG, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x8B65B90", Offset = "0x8B64F90", VA = "0x188B65B90")]
	private BHMBHHAEFLE PDFFNDBJBHJ(HNBAHPJPPAI OJDCKMAPLCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x8B65A70", Offset = "0x8B64E70", VA = "0x188B65A70")]
	[AsyncStateMachine(typeof(ODOCEOCDCKB))]
	private Task JOJEELNBMLO(KKGNFEOCIOB GKJPEAFFBEP, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x8B65D10", Offset = "0x8B65110", VA = "0x188B65D10")]
	private KKGNFEOCIOB PKJALGLGAFJ(HNBAHPJPPAI IDLJGJGIGEG, BHMBHHAEFLE EOHIGEJFENG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x3DC6ED0", Offset = "0x3DC62D0", VA = "0x183DC6ED0")]
	private T HHHJDDGIDNO<T>(T CBMEHPPMEEA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x8B64D00", Offset = "0x8B64100", VA = "0x188B64D00")]
	private KKGNFEOCIOB AEEFBHDKCDD(HNBAHPJPPAI IDLJGJGIGEG, BHMBHHAEFLE EOHIGEJFENG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public LJHNPJHOLOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
[UnityEngine.Scripting.Preserve]
internal sealed class HILNIODCCNI : MPJEHHCGJLJ, EHHOJPPJJPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class KNMOPFAIJDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public KNMOPFAIJDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x8B62A80", Offset = "0x8B61E80", VA = "0x188B62A80")]
		internal object APPMKJHCABB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class ADHICIEMGPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public byte eventCode;

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public ADHICIEMGPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x8B4CC40", Offset = "0x8B4C040", VA = "0x188B4CC40")]
		internal object HMADBAJKDDL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private CFAOIDGAGLN KMFAHFKEGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private NDHMFLFGHJI JIGHDCPOALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private DJEPMJOLNDO CCDAJKHJDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BE")]
	private AOMCGKJFJCA OMLFHJOFHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BF")]
	private ONEHEKMMKIA MCLEBCHDCDH;

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x8B5D1F0", Offset = "0x8B5C5F0", VA = "0x188B5D1F0", Slot = "6")]
	public void PJOFCLDPLJB(JNGEBJCPLIA IDEPICHODDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BB60", Offset = "0x8B5AF60", VA = "0x188B5BB60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x8B5B730", Offset = "0x8B5AB30", VA = "0x188B5B730", Slot = "4")]
	public IENGDNGCKLK DNMMBHAOIJA(HNBAHPJPPAI LIMIIADGKHF)
	{
		return default(IENGDNGCKLK);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x8B5C670", Offset = "0x8B5BA70", VA = "0x188B5C670", Slot = "5")]
	public void GONAHKMGACL(Guid PADGMLDAJOI, Task JFLMKLJIJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x8B5C880", Offset = "0x8B5BC80", VA = "0x188B5C880")]
	private void HDELGENHEIO(APFDEDCIGGF EGMDPKHDKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x8B5C0D0", Offset = "0x8B5B4D0", VA = "0x188B5C0D0")]
	private void GEEMILLBEMO(BBGBOIEEOJH FCGKHKJBFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BE50", Offset = "0x8B5B250", VA = "0x188B5BE50")]
	private void EOIAJPAIFGD(BBGBOIEEOJH FCGKHKJBFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BC10", Offset = "0x8B5B010", VA = "0x188B5BC10")]
	private void ELGOFEPMNAP(BBGBOIEEOJH FCGKHKJBFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x8B5C990", Offset = "0x8B5BD90", VA = "0x188B5C990")]
	private LALFMHKAHCO HJNEJDMEJNN(HNBAHPJPPAI OJDCKMAPLCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x8B5CBD0", Offset = "0x8B5BFD0", VA = "0x188B5CBD0")]
	private void JIBKILKMGNG(HNBAHPJPPAI FDOJJFNNFOM, LALFMHKAHCO ONBHNOJBNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x8B5CDE0", Offset = "0x8B5C1E0", VA = "0x188B5CDE0")]
	private bool NGKAFAPHFKF(HNBAHPJPPAI FDOJJFNNFOM, LALFMHKAHCO ONBHNOJBNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x8B5CFD0", Offset = "0x8B5C3D0", VA = "0x188B5CFD0")]
	private bool PHLINLCHLEB(HNBAHPJPPAI NKHOEKOHBDO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x8B5B4E0", Offset = "0x8B5A8E0", VA = "0x188B5B4E0")]
	private bool DIBPKBILHPI(byte IBOOIFDLFGD, ExitGames.Client.Photon.Hashtable FCGKHKJBFED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public HILNIODCCNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
[UnityEngine.Scripting.Preserve]
internal sealed class LNHPBOJOMPE : COPIACBMJOB, EHHOJPPJJPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class ABJJPCJOPBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public HFLIPKNADKN operationType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public LNHPBOJOMPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public HNBAHPJPPAI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public ABJJPCJOPBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x8B4CAA0", Offset = "0x8B4BEA0", VA = "0x188B4CAA0")]
		internal object DEBPKALFCPP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x8B4CB10", Offset = "0x8B4BF10", VA = "0x188B4CB10")]
		internal object IABDPPOBIEO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct NPILCBFOJGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public AsyncTaskMethodBuilder<LALFMHKAHCO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public LNHPBOJOMPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public HNBAHPJPPAI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private TaskAwaiter<LALFMHKAHCO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x8B68430", Offset = "0x8B67830", VA = "0x188B68430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x8B68AD0", Offset = "0x8B67ED0", VA = "0x188B68AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class OAOHENHBKEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public HFLIPKNADKN operationType;

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public OAOHENHBKEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x8B68B40", Offset = "0x8B67F40", VA = "0x188B68B40")]
		internal object OMBDDMKPBLC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class PPAFJAGFCPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public HNBAHPJPPAI request;

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public PPAFJAGFCPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x8B6BA40", Offset = "0x8B6AE40", VA = "0x188B6BA40")]
		internal object NKMMBNENJMF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x8B6B9D0", Offset = "0x8B6ADD0", VA = "0x188B6B9D0")]
		internal object BALODIBHLFK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x8B6B960", Offset = "0x8B6AD60", VA = "0x188B6B960")]
		internal object AOKDEFEJOJC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private struct MHAKHHEKNIN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public AsyncTaskMethodBuilder<LALFMHKAHCO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public HNBAHPJPPAI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public LNHPBOJOMPE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private PPAFJAGFCPL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private IENGDNGCKLK <pendingRequest>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private LALFMHKAHCO <result>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private TaskAwaiter<(LALFMHKAHCO validationResult, Task operation)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x8B66BB0", Offset = "0x8B65FB0", VA = "0x188B66BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x8B67590", Offset = "0x8B66990", VA = "0x188B67590", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002CD")]
	private CFAOIDGAGLN KMFAHFKEGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002CE")]
	private NDHMFLFGHJI JIGHDCPOALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002CF")]
	private MPJEHHCGJLJ GENHELHGMCE;

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x8B66B00", Offset = "0x8B65F00", VA = "0x188B66B00", Slot = "5")]
	public void PJOFCLDPLJB(JNGEBJCPLIA IDEPICHODDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x8B669E0", Offset = "0x8B65DE0", VA = "0x188B669E0", Slot = "4")]
	[AsyncStateMachine(typeof(NPILCBFOJGG))]
	private Task<LALFMHKAHCO> MNGIIFFLHEE(HNBAHPJPPAI OJDCKMAPLCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x8B666B0", Offset = "0x8B65AB0", VA = "0x188B666B0")]
	private bool ANKKHBFDGEA(HFLIPKNADKN MPPPMJJKDDE, [Out] LALFMHKAHCO HJBCDFKDKBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x8B668A0", Offset = "0x8B65CA0", VA = "0x188B668A0")]
	[AsyncStateMachine(typeof(MHAKHHEKNIN))]
	private Task<LALFMHKAHCO> DHBCDHMHDIF(HNBAHPJPPAI IDLJGJGIGEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public LNHPBOJOMPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
[RecRoom.NoEngine.Common.Preserve]
internal sealed class JLCMPNPNPHJ : DDFIJAHBHAB, EHHOJPPJJPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	private struct FEGFAJCGHKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public APAGCNALJKL DLFICNJKNAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public long MGGMBAINOIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public Guid? IBPAAKEHJFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public bool FKLHAIEKJEB;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private struct HMGHHJNFIIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public AsyncTaskMethodBuilder<BGMNPHKELEH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public AAKDENBOOJG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public JLCMPNPNPHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private long <subRoomId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private TaskAwaiter<MBLNIACGJFP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private TaskAwaiter<BGMNPHKELEH> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x8B5D360", Offset = "0x8B5C760", VA = "0x188B5D360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x8B5D930", Offset = "0x8B5CD30", VA = "0x188B5D930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class BBCBLFKNDFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public BBCBLFKNDFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D4E0", Offset = "0x8B4C8E0", VA = "0x188B4D4E0")]
		internal object FBCGFEHCNII()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private struct LEDJJLHAHAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public AsyncTaskMethodBuilder<MBLNIACGJFP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public JLCMPNPNPHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public AAKDENBOOJG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private BBCBLFKNDFD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private TaskAwaiter<MBLNIACGJFP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x8B63620", Offset = "0x8B62A20", VA = "0x188B63620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x8B63C10", Offset = "0x8B63010", VA = "0x188B63C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private struct NFNLLCNEEBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public AsyncTaskMethodBuilder<BGMNPHKELEH> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public JLCMPNPNPHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public AAKDENBOOJG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public MBLNIACGJFP roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private TaskAwaiter<FEGFAJCGHKL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B67600", Offset = "0x8B66A00", VA = "0x188B67600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x8B67B70", Offset = "0x8B66F70", VA = "0x188B67B70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class KKIPHMOLDAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public MBLNIACGJFP roomDetailsDto;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public KKIPHMOLDAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xFB8DA0", Offset = "0xFB81A0", VA = "0x180FB8DA0")]
		internal bool LCEBFBBMLJD(EOHPFFLACLH sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x8B612C0", Offset = "0x8B606C0", VA = "0x188B612C0")]
		internal object HMBKNIIHGOI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x8B61230", Offset = "0x8B60630", VA = "0x188B61230")]
		internal object FOHDIPEOEAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x8B61380", Offset = "0x8B60780", VA = "0x188B61380")]
		internal object PAKAEOHCKAE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class LMIOPGMNFBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public bool loadUsedCompatibility;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public KKIPHMOLDAC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public LMIOPGMNFBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x8B66070", Offset = "0x8B65470", VA = "0x188B66070")]
		internal object PFCEEDNDANA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private struct GDIOIIHBEGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public AsyncTaskMethodBuilder<FEGFAJCGHKL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public MBLNIACGJFP roomDetailsDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public JLCMPNPNPHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public AAKDENBOOJG targetInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private LMIOPGMNFBK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private TaskAwaiter<FEGFAJCGHKL> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private TaskAwaiter<GJNECDDAEBM> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x8B587C0", Offset = "0x8B57BC0", VA = "0x188B587C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x8B59770", Offset = "0x8B58B70", VA = "0x188B59770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class EAOFGAKJKNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public Stopwatch sw;

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public EAOFGAKJKNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x8B514E0", Offset = "0x8B508E0", VA = "0x188B514E0")]
		internal object HFBGCHGBBLG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private struct GIHACDFGMCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public AsyncTaskMethodBuilder<FEGFAJCGHKL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public EOHPFFLACLH subroom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public JLCMPNPNPHJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public AAKDENBOOJG dormInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private EAOFGAKJKNA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private TaskAwaiter<CDHHINAEKFG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x8B597E0", Offset = "0x8B58BE0", VA = "0x188B597E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x8B59EA0", Offset = "0x8B592A0", VA = "0x188B59EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	private IJIEICICPPB LHIJBEJLBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private OGFKANFAGPF HFDKCBHNBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private LCGKHGAPJOB BDMKIMIJNLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private CMJHPNLKEGN FONPIPHDKOF;

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x8B5ECB0", Offset = "0x8B5E0B0", VA = "0x188B5ECB0", Slot = "5")]
	public void PJOFCLDPLJB(JNGEBJCPLIA IDEPICHODDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x8B5E9E0", Offset = "0x8B5DDE0", VA = "0x188B5E9E0", Slot = "4")]
	[AsyncStateMachine(typeof(HMGHHJNFIIJ))]
	public Task<BGMNPHKELEH> KDDODOKPLJA(CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, AAKDENBOOJG EDHCJOGBCNG, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x8B5E880", Offset = "0x8B5DC80", VA = "0x188B5E880")]
	[AsyncStateMachine(typeof(LEDJJLHAHAP))]
	private Task<MBLNIACGJFP> IAHJHGLJFIM(AAKDENBOOJG EDHCJOGBCNG, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x8B5E710", Offset = "0x8B5DB10", VA = "0x188B5E710")]
	[AsyncStateMachine(typeof(NFNLLCNEEBD))]
	private Task<BGMNPHKELEH> ECAJIMFIPBG(AAKDENBOOJG EDHCJOGBCNG, MBLNIACGJFP BABBGDPKJHL, long JLNBCNHEKAJ, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x8B5E5A0", Offset = "0x8B5D9A0", VA = "0x188B5E5A0")]
	[AsyncStateMachine(typeof(GDIOIIHBEGA))]
	private Task<FEGFAJCGHKL> DEBGBPPANHK(AAKDENBOOJG EDHCJOGBCNG, MBLNIACGJFP BABBGDPKJHL, long JLNBCNHEKAJ, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x8B5EB40", Offset = "0x8B5DF40", VA = "0x188B5EB40")]
	[AsyncStateMachine(typeof(GIHACDFGMCD))]
	private Task<FEGFAJCGHKL> NDFEONHFBBI(AAKDENBOOJG IEDKMAMLHEP, EOHPFFLACLH CHAJFIFLKHB, long JLNBCNHEKAJ, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public JLCMPNPNPHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000CB")]
[UnityEngine.Scripting.Preserve]
internal sealed class GAENGOJNJHN : EAEHMHEANPP, EHHOJPPJJPL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private sealed class CNBLBBIIOFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public HNBAHPJPPAI request;

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public CNBLBBIIOFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x8B50EC0", Offset = "0x8B502C0", VA = "0x188B50EC0")]
		internal object JJPFLFKCPMG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private struct ENMHDNDEIBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public AsyncTaskMethodBuilder<HNBAHPJPPAI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public HNBAHPJPPAI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public GAENGOJNJHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public BHMBHHAEFLE pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private TaskAwaiter<HNBAHPJPPAI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x8B51590", Offset = "0x8B50990", VA = "0x188B51590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x8B51BA0", Offset = "0x8B50FA0", VA = "0x188B51BA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private struct OGHNFHDKKBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public AsyncTaskMethodBuilder<HNBAHPJPPAI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public GAENGOJNJHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public BHMBHHAEFLE pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private TaskAwaiter<IGCBLCKCMBB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x8B69B40", Offset = "0x8B68F40", VA = "0x188B69B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x8B6A140", Offset = "0x8B69540", VA = "0x188B6A140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class ANCIFMFBDEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public HNBAHPJPPAI request;

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public ANCIFMFBDEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x8B4D3B0", Offset = "0x8B4C7B0", VA = "0x188B4D3B0")]
		internal object LALDONFIEHL()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private struct FCLLAKNMBEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public AsyncTaskMethodBuilder<HNBAHPJPPAI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public HNBAHPJPPAI request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public GAENGOJNJHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public BHMBHHAEFLE pauseToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private Guid <requestGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private CIPBAEEMAEF <expectMessageKind>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private KGLFBLDOMAK <masterSwitchCancellationScope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private TaskAwaiter<IGCBLCKCMBB> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x8B51C10", Offset = "0x8B51010", VA = "0x188B51C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x8B52800", Offset = "0x8B51C00", VA = "0x188B52800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000324")]
	private CFAOIDGAGLN KMFAHFKEGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000325")]
	private GAHEGOGCHOL EJDIMGPDPEC;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private KHKGOPFBEOO LHINHCOPEGL
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x8B58610", Offset = "0x8B57A10", VA = "0x188B58610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x8B586D0", Offset = "0x8B57AD0", VA = "0x188B586D0", Slot = "8")]
	public void PJOFCLDPLJB(JNGEBJCPLIA IDEPICHODDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x8B58200", Offset = "0x8B57600", VA = "0x188B58200", Slot = "4")]
	[AsyncStateMachine(typeof(ENMHDNDEIBD))]
	public Task<HNBAHPJPPAI> DALCFCIFGEJ(HNBAHPJPPAI IDLJGJGIGEG, BHMBHHAEFLE EOHIGEJFENG, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x8B584C0", Offset = "0x8B578C0", VA = "0x188B584C0", Slot = "5")]
	[AsyncStateMachine(typeof(OGHNFHDKKBF))]
	public Task<HNBAHPJPPAI> GKNBCCLLLHJ(CancellationToken GMKBGHHNCDJ, BHMBHHAEFLE EOHIGEJFENG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x8B58150", Offset = "0x8B57550", VA = "0x188B58150", Slot = "6")]
	public NFGCOFFCAHB CIDMOHECIBO(KKGNFEOCIOB KLEMEDAIFBB, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x8B58020", Offset = "0x8B57420", VA = "0x188B58020", Slot = "7")]
	public NFGCOFFCAHB BCJLJAGEGNL(KKGNFEOCIOB KLEMEDAIFBB, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x8B58360", Offset = "0x8B57760", VA = "0x188B58360")]
	[AsyncStateMachine(typeof(FCLLAKNMBEL))]
	private Task<HNBAHPJPPAI> EBCIMDHBMNJ(HNBAHPJPPAI IDLJGJGIGEG, BHMBHHAEFLE EOHIGEJFENG, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x3E5B0D0", Offset = "0x3E5A4D0", VA = "0x183E5B0D0")]
	private static byte[] JCGIIAGFNDO(HNBAHPJPPAI AFDNIPHJHMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public GAENGOJNJHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D2")]
[UnityEngine.Scripting.Preserve]
internal sealed class OCAHMABOBIK : NDHMFLFGHJI, EHHOJPPJJPL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000344")]
	private NEPJNHOBGFK HBGEIILAJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private CFAOIDGAGLN KMFAHFKEGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private OHGELLMBBCH JGGICGFGJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000347")]
	private MJCJEEMHPAL IKKACAKFMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000348")]
	private IJIEICICPPB LHIJBEJLBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000349")]
	private PJPBKECLNGI GPEHJJBHHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400034A")]
	private LLMBDMOEJHN BCDGCKHBBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400034B")]
	private OGFKANFAGPF HFDKCBHNBMB;

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private CJGDJMIKAIC MJABACAOHLE
	{
		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x8B68C70", Offset = "0x8B68070", VA = "0x188B68C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private static LALFMHKAHCO KMAEPPNCJOM
	{
		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x8B68C50", Offset = "0x8B68050", VA = "0x188B68C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x8B690B0", Offset = "0x8B684B0", VA = "0x188B690B0", Slot = "6")]
	public void PJOFCLDPLJB(JNGEBJCPLIA IDEPICHODDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x8B68F40", Offset = "0x8B68340", VA = "0x188B68F40", Slot = "4")]
	public LALFMHKAHCO PFKCKOBAJKI(NELIJLIGAOD DCBNPLECEOJ, HFLIPKNADKN DILMGLJEHEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x8B68CC0", Offset = "0x8B680C0", VA = "0x188B68CC0", Slot = "5")]
	public LALFMHKAHCO EBOHNEABPLN(NELIJLIGAOD KHKEJCOHPIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x8B68C60", Offset = "0x8B68060", VA = "0x188B68C60")]
	private static LALFMHKAHCO ANAKLFDAOOI(MHKDGKFABOE HBHJOPNAJMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public OCAHMABOBIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public class DPIKIDINHDF : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x8B72470", Offset = "0x8B71870", VA = "0x188B72470")]
	public DPIKIDINHDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x7C54520", Offset = "0x7C53920", VA = "0x187C54520")]
	public DPIKIDINHDF(string AFDNIPHJHMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D4")]
[UnityEngine.Scripting.Preserve]
internal sealed class PHPGGBEKKLD : BIKNNKNKKNG, EHHOJPPJJPL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private struct NCOLGEKCGIH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public AsyncTaskMethodBuilder<LALFMHKAHCO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public PHPGGBEKKLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public HOAPKCGDNIL autosaveRecordInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private CIIMOEPMPCG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <timerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private BPDDKIDLADD <operation>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private TaskAwaiter<LALFMHKAHCO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x8B83710", Offset = "0x8B82B10", VA = "0x188B83710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x8B840E0", Offset = "0x8B834E0", VA = "0x188B840E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private struct MPAAPFCNOEO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		public PHPGGBEKKLD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8B82F50", Offset = "0x8B82350", VA = "0x188B82F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x8B836B0", Offset = "0x8B82AB0", VA = "0x188B836B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private struct FEACBFDCEFJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		public PHPGGBEKKLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x8B76090", Offset = "0x8B75490", VA = "0x188B76090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x8B765A0", Offset = "0x8B759A0", VA = "0x188B765A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private struct FFOBBFNBHHM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		public PHPGGBEKKLD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8B76A60", Offset = "0x8B75E60", VA = "0x188B76A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x8B77210", Offset = "0x8B76610", VA = "0x188B77210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private struct FECFPOHFLEF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		public PHPGGBEKKLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x8B76600", Offset = "0x8B75A00", VA = "0x188B76600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x8B767A0", Offset = "0x8B75BA0", VA = "0x188B767A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private struct OBPBLMMMFHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public PHPGGBEKKLD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8B85870", Offset = "0x8B84C70", VA = "0x188B85870", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x8B85FA0", Offset = "0x8B853A0", VA = "0x188B85FA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private struct AMICGECBBAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public PHPGGBEKKLD <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8B6D1C0", Offset = "0x8B6C5C0", VA = "0x188B6D1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x8B6D630", Offset = "0x8B6CA30", VA = "0x188B6D630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DD")]
	[CompilerGenerated]
	private struct EPLGDOPKHJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public PHPGGBEKKLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public GFFNCJJHNKA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private CIIMOEPMPCG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x8B74A60", Offset = "0x8B73E60", VA = "0x188B74A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x8B75000", Offset = "0x8B74400", VA = "0x188B75000", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400034C")]
	private CFAOIDGAGLN KMFAHFKEGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034D")]
	private JNGEBJCPLIA IDEPICHODDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400034E")]
	private IJIEICICPPB LHIJBEJLBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private EAEHMHEANPP NEEDNELMJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private OHGELLMBBCH JGGICGFGJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000351")]
	private LLMBDMOEJHN BCDGCKHBBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000352")]
	private CancellationTokenSource CEDACNPMPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000353")]
	private Task MCJNJHLHHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000354")]
	private TaskCompletionSource<int> HODIPGOLAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000355")]
	private int NPGLGGNCFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000356")]
	private int OLEJGGKKAMK;

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x8B87ED0", Offset = "0x8B872D0", VA = "0x188B87ED0", Slot = "6")]
	public void PJOFCLDPLJB(JNGEBJCPLIA IDEPICHODDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x152D600", Offset = "0x152CA00", VA = "0x18152D600", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x8B87BD0", Offset = "0x8B86FD0", VA = "0x188B87BD0")]
	private void PDAMLPPJLNH(float MCIAMPGAHCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x8B87CB0", Offset = "0x8B870B0", VA = "0x188B87CB0", Slot = "4")]
	[AsyncStateMachine(typeof(NCOLGEKCGIH))]
	public Task<LALFMHKAHCO> PEOMPONBMFF(HOAPKCGDNIL NNKOPAHIOCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x8B87230", Offset = "0x8B86630", VA = "0x188B87230", Slot = "5")]
	[AsyncStateMachine(typeof(MPAAPFCNOEO))]
	public Task AKJFFFINGPA([Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x152D600", Offset = "0x152CA00", VA = "0x18152D600")]
	public void JFDOHPMEMEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x8B878B0", Offset = "0x8B86CB0", VA = "0x188B878B0")]
	private BPDDKIDLADD OKJLHCNPMGM(HOAPKCGDNIL NNKOPAHIOCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x8B87DE0", Offset = "0x8B871E0", VA = "0x188B87DE0")]
	[AsyncStateMachine(typeof(FEACBFDCEFJ))]
	private Task PFJHLFOHLMP(CancellationToken NILMHHOPMOB, int FNJHLEOJHLA, JPNNICBILFM FLDGFFCOMHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x8B875C0", Offset = "0x8B869C0", VA = "0x188B875C0")]
	[AsyncStateMachine(typeof(FFOBBFNBHHM))]
	private Task JPIJDEGNMNL(CancellationToken NILMHHOPMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x8B87AE0", Offset = "0x8B86EE0", VA = "0x188B87AE0")]
	[AsyncStateMachine(typeof(FECFPOHFLEF))]
	private Task OPPLOECKKOI([Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x8B876C0", Offset = "0x8B86AC0", VA = "0x188B876C0")]
	[AsyncStateMachine(typeof(OBPBLMMMFHJ))]
	private Task MFHJOOKPMNI(CancellationToken NILMHHOPMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x8B877B0", Offset = "0x8B86BB0", VA = "0x188B877B0")]
	[AsyncStateMachine(typeof(AMICGECBBAA))]
	private Task NFBLEMJHJGN(CancellationToken HMIJOMPPOND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x8B87430", Offset = "0x8B86830", VA = "0x188B87430")]
	private Task GGEPIHDPMEJ(GFFNCJJHNKA PLJIHINALMN, CancellationToken NILMHHOPMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x8B87320", Offset = "0x8B86720", VA = "0x188B87320")]
	[AsyncStateMachine(typeof(EPLGDOPKHJJ))]
	private Task CFFGNGBLHMG(GFFNCJJHNKA PLJIHINALMN, CancellationToken NILMHHOPMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x8B86FB0", Offset = "0x8B863B0", VA = "0x188B86FB0")]
	private bool ABLMCEMBKLA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public PHPGGBEKKLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
[UnityEngine.Scripting.Preserve]
internal class AKLHKFJPHDH : MJCJEEMHPAL, EHHOJPPJJPL, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private struct FCINJPHOPAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public AKLHKFJPHDH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public string path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private CIIMOEPMPCG<string> <timer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x8B75820", Offset = "0x8B74C20", VA = "0x188B75820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x8B75DD0", Offset = "0x8B751D0", VA = "0x188B75DD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000390")]
	private GCFCNBPHIEF EIIIIMAMBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000391")]
	private JNGEBJCPLIA IDEPICHODDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000392")]
	private NDHMFLFGHJI JIGHDCPOALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	private EAEHMHEANPP NEEDNELMJIC;

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x8B6CEE0", Offset = "0x8B6C2E0", VA = "0x188B6CEE0", Slot = "6")]
	public void PJOFCLDPLJB(JNGEBJCPLIA IDEPICHODDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x8B6CE90", Offset = "0x8B6C290", VA = "0x188B6CE90", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x8B6CD90", Offset = "0x8B6C190", VA = "0x188B6CD90", Slot = "5")]
	[AsyncStateMachine(typeof(FCINJPHOPAN))]
	public Task AICOFOPPKDG(string GADMOJMIIGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x8B6CBF0", Offset = "0x8B6BFF0", VA = "0x188B6CBF0", Slot = "4")]
	public LALFMHKAHCO ABLMCEMBKLA(NELIJLIGAOD DCBNPLECEOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x8B6CC50", Offset = "0x8B6C050", VA = "0x188B6CC50")]
	private BFDDDCKAJNP AFCPFMHKGCJ(string GADMOJMIIGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public AKLHKFJPHDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public static class EJEBDKGJFCO
{
	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x8B72D40", Offset = "0x8B72140", VA = "0x188B72D40")]
	public static void JHPBANDPHED(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x8B733B0", Offset = "0x8B727B0", VA = "0x188B733B0")]
	internal static void KIENCNBHLJN(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x8B73510", Offset = "0x8B72910", VA = "0x188B73510")]
	internal static void NIPPCJLMDDA(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x8B72F80", Offset = "0x8B72380", VA = "0x188B72F80")]
	internal static void JNMNHIBIKHA(JFAGCPCLAAF MNCIANLLPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x3B39A30", Offset = "0x3B38E30", VA = "0x183B39A30")]
	private static void CIMHBLNMPMH<Interface, Impl, Interface>(JFAGCPCLAAF MNCIANLLPKI) where Impl : Interface
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
internal class EEHIBEEDJIH : OBKHJAOFJAG<HNBAHPJPPAI>
{
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private sealed class KEAJPCINGFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public HNBAHPJPPAI message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public string op;

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public KEAJPCINGFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x8B7EB60", Offset = "0x8B7DF60", VA = "0x188B7EB60")]
		internal object CBIDCGBHKEI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400039A")]
	public static readonly EEHIBEEDJIH NKAKNKMIPPI;

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x8B724B0", Offset = "0x8B718B0", VA = "0x188B724B0")]
	public ExitGames.Client.Photon.Hashtable COFPFOKABJF(HNBAHPJPPAI AFDNIPHJHMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x8B72770", Offset = "0x8B71B70", VA = "0x188B72770", Slot = "5")]
	protected override void FOEENLLBGGB(HNBAHPJPPAI AFDNIPHJHMO, IDictionary<object, object> NGIAGNLBILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x8B72540", Offset = "0x8B71940", VA = "0x188B72540", Slot = "6")]
	public override HNBAHPJPPAI DGFNGGGAAON(IDictionary<object, object> NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x8B728A0", Offset = "0x8B71CA0", VA = "0x188B728A0")]
	private static void GJFBEGANDPI(string PLBLCFDKDBF, HNBAHPJPPAI AFDNIPHJHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x8B72D00", Offset = "0x8B72100", VA = "0x188B72D00")]
	public EEHIBEEDJIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x8B729B0", Offset = "0x8B71DB0", VA = "0x188B729B0")]
	[CompilerGenerated]
	internal static string LOMPCFDJJLB(BGMNPHKELEH JPPAFNCCIMK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public static class AHOBOLKALEO
{
	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public static LALFMHKAHCO KMAEPPNCJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x8B6C460", Offset = "0x8B6B860", VA = "0x188B6C460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x8B6C520", Offset = "0x8B6B920", VA = "0x188B6C520")]
	public static bool BCNILPEIHBN(this LALFMHKAHCO ONBHNOJBNCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x8B6C4C0", Offset = "0x8B6B8C0", VA = "0x188B6C4C0")]
	public static LALFMHKAHCO ANAKLFDAOOI(MHKDGKFABOE LBMCPIPNPIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x8B6C540", Offset = "0x8B6B940", VA = "0x188B6C540")]
	public static LALFMHKAHCO MEFPIOJBPCB(IEnumerable<LALFMHKAHCO> FMIHHCNCHCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x8B6C740", Offset = "0x8B6BB40", VA = "0x188B6C740")]
	public static string OCJGDFHJDCK(this LALFMHKAHCO HJBCDFKDKBA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public abstract class IFJCGMNPLIB : NBKFIDCCLCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000E6")]
	public delegate LALFMHKAHCO NINJBMAAMGO([NotNull] NELIJLIGAOD MAJOHFIPFOF);

	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[CompilerGenerated]
	private sealed class HAIOFMLGAOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		public NELIJLIGAOD photonPlayer;

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public HAIOFMLGAOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x17E5F00", Offset = "0x17E5300", VA = "0x1817E5F00")]
		internal LALFMHKAHCO PLNCELGOGMI(NINJBMAAMGO v)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003A0")]
	private bool GJNOCMLAONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A1")]
	protected readonly HashSet<NINJBMAAMGO> PCDBANKPIGN;

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x8B7AED0", Offset = "0x8B7A2D0", VA = "0x188B7AED0", Slot = "4")]
	public void IIOOFKFJJGD(NINJBMAAMGO FBCHPNEEHEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x8B7AE20", Offset = "0x8B7A220", VA = "0x188B7AE20", Slot = "5")]
	public void DMFOCBLJNCI(NINJBMAAMGO FBCHPNEEHEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x8B7AE80", Offset = "0x8B7A280", VA = "0x188B7AE80", Slot = "7")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0x8B7AB80", Offset = "0x8B79F80", VA = "0x188B7AB80")]
	protected LALFMHKAHCO DGPJFEDELAI(NELIJLIGAOD KHKEJCOHPIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x8B7AF30", Offset = "0x8B7A330", VA = "0x188B7AF30")]
	protected IFJCGMNPLIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E9")]
public class AEFCFBEENAG : IFJCGMNPLIB, NEPJNHOBGFK, NBKFIDCCLCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private sealed class IOPCBDAHKDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		public LALFMHKAHCO result;

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public IOPCBDAHKDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C4C0", Offset = "0x8B7B8C0", VA = "0x188B7C4C0")]
		internal object LFJLGMMPECO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x8B6C450", Offset = "0x8B6B850", VA = "0x188B6C450")]
	[UnityEngine.Scripting.Preserve]
	public AEFCFBEENAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x8B6C340", Offset = "0x8B6B740", VA = "0x188B6C340", Slot = "8")]
	public LALFMHKAHCO PFMIOBOFJHH(NELIJLIGAOD KHKEJCOHPIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EB")]
public class PFKLNEOJAIN : IFJCGMNPLIB, GCFCNBPHIEF, NBKFIDCCLCN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class BOAJPAEMPKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		public LALFMHKAHCO result;

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public BOAJPAEMPKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x8B6E4B0", Offset = "0x8B6D8B0", VA = "0x188B6E4B0")]
		internal object OOOKAEOIONH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x8B6C450", Offset = "0x8B6B850", VA = "0x188B6C450")]
	[UnityEngine.Scripting.Preserve]
	public PFKLNEOJAIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x8B86EA0", Offset = "0x8B862A0", VA = "0x188B86EA0", Slot = "8")]
	public LALFMHKAHCO ABLMCEMBKLA(NELIJLIGAOD GHOBDALFLGI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal static class FDDEHNIEMJH
{
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private sealed class HAOLLKIPJMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		public CIIMOEPMPCG<string> timer;

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public HAOLLKIPJMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x8B7A4E0", Offset = "0x8B798E0", VA = "0x188B7A4E0")]
		internal object MIDGLIMHEKK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x8B75EF0", Offset = "0x8B752F0", VA = "0x188B75EF0")]
	public static CIIMOEPMPCG<string> DGHBONCKDCE(AKNCNLDICPO CCLJCJDJCOE, [Optional] string LJLHPFCBFFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x8B75E30", Offset = "0x8B75230", VA = "0x188B75E30")]
	public static void AMHFLJBCMAJ(CIIMOEPMPCG<string> LLOEFCNKADN, AKNCNLDICPO CCLJCJDJCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x8B75FD0", Offset = "0x8B753D0", VA = "0x188B75FD0")]
	public static string MLMJIFBDOAD(HNBAHPJPPAI OJDCKMAPLCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EF")]
internal static class NLOKCIALPJK
{
	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x8B85730", Offset = "0x8B84B30", VA = "0x188B85730")]
	public static void PGPMHDAHPIG(this CFAOIDGAGLN KMFAHFKEGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x8B85600", Offset = "0x8B84A00", VA = "0x188B85600")]
	public static void HOHHOOAIPDO(this CFAOIDGAGLN KMFAHFKEGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0x8B85610", Offset = "0x8B84A10", VA = "0x188B85610")]
	private static void JHGGPBACLFH(this CFAOIDGAGLN KMFAHFKEGPF, bool EOFHCILPCIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F0")]
public class KNMLLFKAJGL : GGFPKCMINLD, DFIABPCGCAI, FIHEDBOAMLM, FEJAGFIJCPP
{
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[DefaultMember("Item")]
	private class LICMLHDINGD : APFDEDCIGGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private readonly byte AINAMMEFIOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private readonly int KEJCMKLNFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private readonly object KFJPHKBCAPL;

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public byte PKFOILGCDGE
		{
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0xB32030", Offset = "0xB31430", VA = "0x180B32030", Slot = "4")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public int CBOFALAFBKG
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0xAC6FB0", Offset = "0xAC63B0", VA = "0x180AC6FB0", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public object FBPFPOGHLLE
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public object FMHPKKMCCLF
		{
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0x8B81E00", Offset = "0x8B81200", VA = "0x188B81E00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x7C5BC30", Offset = "0x7C5B030", VA = "0x187C5BC30")]
		public LICMLHDINGD(byte AINAMMEFIOC, int KEJCMKLNFBJ, object KFJPHKBCAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x8B81DB0", Offset = "0x8B811B0", VA = "0x188B81DB0", Slot = "8")]
		public bool EGMGAAFJGGH(byte PEENICAIFOP, [Out] object CBMEHPPMEEA)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003A9")]
	private readonly DFIABPCGCAI EJLPBGLDACO;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public NELIJLIGAOD EAEIDFPEPEI
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x8B815B0", Offset = "0x8B809B0", VA = "0x188B815B0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int DGFCPEKJAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x8B81600", Offset = "0x8B80A00", VA = "0x188B81600", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public int KDHNLAAECFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000451")]
		[Cpp2IlInjected.Address(RVA = "0x8B81A30", Offset = "0x8B80E30", VA = "0x188B81A30", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public NELIJLIGAOD AKENBFGGMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(RVA = "0x8B81370", Offset = "0x8B80770", VA = "0x188B81370", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool IEAAMLFFHLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "15")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public int MGJGFEBPHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0xC11DD0", Offset = "0xC111D0", VA = "0x180C11DD0", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public string CEMJIEMNKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x8B816F0", Offset = "0x8B80AF0", VA = "0x188B816F0", Slot = "17")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public Func<string, string> POODDEAJJNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x8B81C40", Offset = "0x8B81040", VA = "0x188B81C40", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000015")]
	public event Action<string, long> ILPGMMGBKPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000016")]
	public event Action<APFDEDCIGGF> HCBDPDOJJCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x8B817A0", Offset = "0x8B80BA0", VA = "0x188B817A0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x8B81D00", Offset = "0x8B81100", VA = "0x188B81D00", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action<bool> CGOJJEFKCNN
	{
		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "26")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "27")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action<NELIJLIGAOD> EMGLLADPJOK
	{
		[Cpp2IlInjected.Token(Token = "0x600044D")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "9")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "10")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000019")]
	public event Action LELIKNPBLMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x8B81650", Offset = "0x8B80A50", VA = "0x188B81650", Slot = "35")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x8B81BA0", Offset = "0x8B80FA0", VA = "0x188B81BA0", Slot = "36")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0x8B81850", Offset = "0x8B80C50", VA = "0x188B81850", Slot = "19")]
	public void JDDCGMDPKEF(string HDNPPEBJPAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0xE4C1E0", Offset = "0xE4B5E0", VA = "0x180E4C1E0")]
	public KNMLLFKAJGL(DFIABPCGCAI EJLPBGLDACO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x8B814A0", Offset = "0x8B808A0", VA = "0x188B814A0", Slot = "8")]
	public bool BGEGDEIIACC(byte IBOOIFDLFGD, object FFDEHCEOFPC, MIAGGALJIMC DPDKHCNMKJC, AJOPFBCEGBG GAILODJIDIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0x8B818B0", Offset = "0x8B80CB0", VA = "0x188B818B0", Slot = "20")]
	public NELIJLIGAOD KLIBMBLHAMB(int DMBIMOMMAHA, bool MMANBLIOCIJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0x8B81A80", Offset = "0x8B80E80", VA = "0x188B81A80", Slot = "21")]
	public NELIJLIGAOD NBPNEOIPFHD(int MNAACFOHONJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0x8B813C0", Offset = "0x8B807C0", VA = "0x188B813C0", Slot = "22")]
	public NELIJLIGAOD BFPEBMJEGHH(int DMBIMOMMAHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0x8B81950", Offset = "0x8B80D50", VA = "0x188B81950", Slot = "23")]
	public IReadOnlyList<NELIJLIGAOD> LFABLLEGMGF(bool MMANBLIOCIJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x8B81B60", Offset = "0x8B80F60", VA = "0x188B81B60", Slot = "24")]
	public IReadOnlyList<NELIJLIGAOD> NIMEKIFDNNG(bool MMANBLIOCIJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "25")]
	public bool IOADPADKGHM(NELIJLIGAOD LOEKALJCKFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "28")]
	public void MFHKNKDGGAO(object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "29")]
	public void MECBJEBNNMK(object MONGIMOHLAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "30")]
	public void FKMDHNNGPBP(object MONGIMOHLAO, bool OKGNONIDIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x8B81750", Offset = "0x8B80B50", VA = "0x188B81750", Slot = "31")]
	public IDisposable HJHHDGBDKEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "32")]
	private bool LLIGILOCKMI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "33")]
	public void DOMALNFFFAO(StringBuilder DCNLNFLEHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x10BAAB0", Offset = "0x10B9EB0", VA = "0x1810BAAB0", Slot = "34")]
	public bool BGFMAJCBFBG(bool DJPFIPOJJDG, [Out] string FKPCAPOIAIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0x10290B0", Offset = "0x10284B0", VA = "0x1810290B0", Slot = "37")]
	public void JNFLENLNEFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F2")]
internal struct BBGBOIEEOJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AE")]
	private readonly IDictionary<object, object> FCGKHKJBFED;

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0xE62750", Offset = "0xE61B50", VA = "0x180E62750")]
	public BBGBOIEEOJH(IDictionary<object, object> FCGKHKJBFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0x8B6D970", Offset = "0x8B6CD70", VA = "0x188B6D970")]
	public bool OLBANEFIKHM([Out] HNBAHPJPPAI AFDNIPHJHMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0x8B6D8C0", Offset = "0x8B6CCC0", VA = "0x188B6D8C0")]
	public Guid KALDOMDPNNL()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0x8B6D780", Offset = "0x8B6CB80", VA = "0x188B6D780")]
	public LALFMHKAHCO HMCANDJBDOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x8B6D690", Offset = "0x8B6CA90", VA = "0x188B6D690")]
	public static ExitGames.Client.Photon.Hashtable CEOONNIFPHP(HNBAHPJPPAI AFDNIPHJHMO, LALFMHKAHCO ONBHNOJBNCG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F3")]
internal static class MOPPONBIPIC
{
	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x8B82ED0", Offset = "0x8B822D0", VA = "0x188B82ED0")]
	public static bool LGCCLMIGNNE(this AAKDENBOOJG BAGPMCPHKKA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F4")]
internal struct CMGILKHKFOG : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	[CompilerGenerated]
	private struct CJJFFBHCANJ : IAsyncStateMachine
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
		public CMGILKHKFOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x8B6F650", Offset = "0x8B6EA50", VA = "0x188B6F650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x8B6F830", Offset = "0x8B6EC30", VA = "0x188B6F830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003AF")]
	private readonly CancellationTokenSource HAGAAAKNION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40003B0")]
	private bool GJNOCMLAONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003B1")]
	private Task KDHFABGBLNO;

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public bool JDPJAANKGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x8B6F8E0", Offset = "0x8B6ECE0", VA = "0x188B6F8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0x8B6FA20", Offset = "0x8B6EE20", VA = "0x188B6FA20")]
	public CMGILKHKFOG(CancellationToken GMKBGHHNCDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x8B6F910", Offset = "0x8B6ED10", VA = "0x188B6F910")]
	[AsyncStateMachine(typeof(CJJFFBHCANJ))]
	public Task KOGIJPLKIGI(Func<CancellationToken, List<Task>> EINMKGKBCPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x8B6F890", Offset = "0x8B6EC90", VA = "0x188B6F890", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
public readonly struct DPLHFNHOBFF<TGetDataArg, TData>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private struct GLFLIECAPJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public AsyncTaskMethodBuilder<DGHPMJAIBNO<DAENPLLCOHN<TData>, KIBOPIAKFMB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public string timerName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public DPLHFNHOBFF<TGetDataArg, TData> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public TGetDataArg arg;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private TaskAwaiter<DGHPMJAIBNO<DAENPLLCOHN<TData>, KIBOPIAKFMB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x4F629F0", Offset = "0x4F61DF0", VA = "0x184F629F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x49B8100", Offset = "0x49B7500", VA = "0x1849B8100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003B7")]
	private readonly JMEMOINNBPH<TGetDataArg, TData> MGFGGPPDFIP;

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0xE62750", Offset = "0xE61B50", VA = "0x180E62750")]
	internal DPLHFNHOBFF(JMEMOINNBPH<TGetDataArg, TData> MOHOCDOOLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0x456A1A0", Offset = "0x45695A0", VA = "0x18456A1A0")]
	[AsyncStateMachine(typeof(DPLHFNHOBFF<, >.GLFLIECAPJA))]
	public Task<DGHPMJAIBNO<DAENPLLCOHN<TData>, KIBOPIAKFMB>> KJHEGLJOGAG(TGetDataArg ALOONCIOJJM, string DHBNIKIFHOH, CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
public static class ADHKCLECLDN
{
	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x31E7370", Offset = "0x31E6770", VA = "0x1831E7370")]
	public static DPLHFNHOBFF<TGetDataArg, TData> EJOLKNBPCJB<TGetDataArg, TData>(JMEMOINNBPH<TGetDataArg, TData> MOHOCDOOLDA)
	{
		return default(DPLHFNHOBFF<TGetDataArg, TData>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F9")]
public struct CGLANNGJMPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003C1")]
	public readonly int PKFOILGCDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40003C2")]
	public readonly int? HLIHNOEDILC;

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x54DB950", Offset = "0x54DAD50", VA = "0x1854DB950")]
	public CGLANNGJMPD(int AINAMMEFIOC, [Optional] int? LHODDMICAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x8B6F380", Offset = "0x8B6E780", VA = "0x188B6F380", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public interface FAJGNLDEMOH<T> where T : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AJPNHKIOIDD();

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(Slot = "1")]
	FAJGNLDEMOH<T> OFEFIBPEDEL(string IPDEHBDCEKK);

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FAJGNLDEMOH<T> NHNFDCLGMEL(EGPPKMIOIKK<T> BCIJGDBDEGO);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FAJGNLDEMOH<T> LOPBBIDCNFE(int FCDCKNGNLFJ);

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "4")]
	FAJGNLDEMOH<T> LNBBGKPHKJJ(int FCDCKNGNLFJ, GCHCBKAOFDE<T> JFFHCKNDHCA);
}
[Cpp2IlInjected.Token(Token = "0x20000FB")]
public interface LBKIPKPPCBG
{
	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FAJGNLDEMOH<T> NFFDLOKJJPE<T>() where T : Exception;

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IPIFMJIHHHK FKOMGHNCHBB(Exception DGLGDFPJBDB);

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CGLANNGJMPD IMNLALOKPJA(Exception DGLGDFPJBDB);
}
[Cpp2IlInjected.Token(Token = "0x20000FC")]
public delegate string EGPPKMIOIKK<in T>(T DGLGDFPJBDB) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FD")]
public delegate int GCHCBKAOFDE<in T>(T DGLGDFPJBDB) where T : Exception;
[Cpp2IlInjected.Token(Token = "0x20000FE")]
internal class GEAOJOJHPMK : LBKIPKPPCBG
{
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	private delegate string HHALCCIFGIL(Exception DGLGDFPJBDB);

	[Cpp2IlInjected.Token(Token = "0x2000100")]
	private delegate int FFOFLPJDPKB(Exception DGLGDFPJBDB);

	[Cpp2IlInjected.Token(Token = "0x2000101")]
	private class AGNKGNGKFEL<T> : FAJGNLDEMOH<T> where T : notnull, Exception
	{
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		[CompilerGenerated]
		private sealed class IKBNEDHMECK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public string errorMessage;

			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public IKBNEDHMECK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			internal string EELHJFLLPNL(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000103")]
		[CompilerGenerated]
		private sealed class BNPEFLLHNAA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public EGPPKMIOIKK<T> errorMessageBuilder;

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public BNPEFLLHNAA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0x4F66680", Offset = "0x4F65A80", VA = "0x184F66680")]
			internal string ABGOJADDNCB(Exception ex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000104")]
		[CompilerGenerated]
		private sealed class GOAOFJDDKAH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public GCHCBKAOFDE<T> getSubCode;

			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public GOAOFJDDKAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x4F66680", Offset = "0x4F65A80", VA = "0x184F66680")]
			internal int DBGECPMPJNK(Exception ex)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private readonly GEAOJOJHPMK NLMHGAIPIGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private readonly Type KAKMIDBKFLL;

		[Cpp2IlInjected.Token(Token = "0x60004A2")]
		[Cpp2IlInjected.Address(RVA = "0x51E73A0", Offset = "0x51E67A0", VA = "0x1851E73A0")]
		internal AGNKGNGKFEL(GEAOJOJHPMK NLMHGAIPIGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x51E7010", Offset = "0x51E6410", VA = "0x1851E7010", Slot = "4")]
		public void AJPNHKIOIDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x51E72A0", Offset = "0x51E66A0", VA = "0x1851E72A0", Slot = "5")]
		public FAJGNLDEMOH<T> OFEFIBPEDEL(string IPDEHBDCEKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x51E71A0", Offset = "0x51E65A0", VA = "0x1851E71A0", Slot = "6")]
		public FAJGNLDEMOH<T> NHNFDCLGMEL(EGPPKMIOIKK<T> BCIJGDBDEGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x51E7160", Offset = "0x51E6560", VA = "0x1851E7160", Slot = "7")]
		public FAJGNLDEMOH<T> LOPBBIDCNFE(int FCDCKNGNLFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x51E7040", Offset = "0x51E6440", VA = "0x1851E7040", Slot = "8")]
		public FAJGNLDEMOH<T> LNBBGKPHKJJ(int FCDCKNGNLFJ, GCHCBKAOFDE<T> JFFHCKNDHCA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000105")]
	private class BFDACOCPFFB<TVal> where TVal : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private bool HLEOGEHKGLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private readonly List<Type> NJCBJEHNNPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private readonly Dictionary<Type, TVal> KPLDHKHOBCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private readonly Dictionary<Type, int> LHNBDNCNBOH;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public IReadOnlyList<Type> LFOOCPGIFCP
		{
			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x6545420", Offset = "0x6544820", VA = "0x186545420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x6545870", Offset = "0x6544C70", VA = "0x186545870")]
		public BFDACOCPFFB(Dictionary<Type, int> LHNBDNCNBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x6545740", Offset = "0x6544B40", VA = "0x186545740")]
		public void KOBMLIBBKBO(Type PEENICAIFOP, TVal DIMKOEFIKCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x6545610", Offset = "0x6544A10", VA = "0x186545610")]
		public bool JMMHHDIDKDC(Type KAKMIDBKFLL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x6545830", Offset = "0x6544C30", VA = "0x186545830")]
		public bool MLBGHPMLKCL(TVal CBMEHPPMEEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x4571080", Offset = "0x4570480", VA = "0x184571080")]
		public TVal DIJAEKOIPED(Type IIHAKBEOLJD)
		{
			return (TVal)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x6545570", Offset = "0x6544970", VA = "0x186545570")]
		[CompilerGenerated]
		private int HNKKHGKCLJC(Type BMCGECLFPOK, Type PDLCPJLHLIK)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class CPIKOGIMAEH : IEnumerable<CGLANNGJMPD>, IEnumerable, IEnumerator<CGLANNGJMPD>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private CGLANNGJMPD <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public GEAOJOJHPMK <>4__this;

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
		private IEnumerator<CGLANNGJMPD> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		private CGLANNGJMPD System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.Errors.ErrorCode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x4A5F690", Offset = "0x4A5EA90", VA = "0x184A5F690", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(CGLANNGJMPD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x8B70B00", Offset = "0x8B6FF00", VA = "0x188B70B00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0xFC9810", Offset = "0xFC8C10", VA = "0x180FC9810")]
		[DebuggerHidden]
		public CPIKOGIMAEH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x8B70B50", Offset = "0x8B6FF50", VA = "0x188B70B50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x8B70540", Offset = "0x8B6F940", VA = "0x188B70540", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B704F0", Offset = "0x8B6F8F0", VA = "0x188B704F0")]
		private void DKMCMBPCGHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x8B704A0", Offset = "0x8B6F8A0", VA = "0x188B704A0")]
		private void AIFLPGLABJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x8B70AB0", Offset = "0x8B6FEB0", VA = "0x188B70AB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x8B709F0", Offset = "0x8B6FDF0", VA = "0x188B709F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<CGLANNGJMPD> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.Errors.ErrorCode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x8B709F0", Offset = "0x8B6FDF0", VA = "0x188B709F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003C3")]
	private static readonly CGLANNGJMPD ODFGNEDKGFO;

	[Cpp2IlInjected.Token(Token = "0x40003C4")]
	private static readonly Dictionary<Type, int> PIKOLCMKBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003C5")]
	private readonly HashSet<Type> KJLICDFKJBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003C6")]
	private readonly BFDACOCPFFB<int> DEFIGPIKAIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003C7")]
	private readonly BFDACOCPFFB<FFOFLPJDPKB> LAAJNDDNOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003C8")]
	private readonly BFDACOCPFFB<HHALCCIFGIL> CLJFGPFAHJC;

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x8B77CF0", Offset = "0x8B770F0", VA = "0x188B77CF0")]
	[MKODAOGKIAA.PMDGGDAFIAI.CCGBOKDKPLD]
	internal static void EMILKHFAJPJ(JFAGCPCLAAF KOCCFDNNPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x8B78E20", Offset = "0x8B78220", VA = "0x188B78E20")]
	[RecRoom.NoEngine.Common.Preserve]
	public GEAOJOJHPMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x3AAC6E0", Offset = "0x3AABAE0", VA = "0x183AAC6E0", Slot = "4")]
	public FAJGNLDEMOH<T> NFFDLOKJJPE<T>() where T : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x8B78070", Offset = "0x8B77470", VA = "0x188B78070", Slot = "5")]
	public IPIFMJIHHHK FKOMGHNCHBB(Exception DGLGDFPJBDB)
	{
		return default(IPIFMJIHHHK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x8B784B0", Offset = "0x8B778B0", VA = "0x188B784B0", Slot = "6")]
	public CGLANNGJMPD IMNLALOKPJA(Exception? DGLGDFPJBDB)
	{
		return default(CGLANNGJMPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x8B786B0", Offset = "0x8B77AB0", VA = "0x188B786B0", Slot = "7")]
	[IteratorStateMachine(typeof(CPIKOGIMAEH))]
	public IEnumerable<CGLANNGJMPD> INLLBKJAFPM(Exception DGLGDFPJBDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x8B78750", Offset = "0x8B77B50", VA = "0x188B78750", Slot = "8")]
	public string IOONBBCIGEF(Exception? DGLGDFPJBDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x8B77D60", Offset = "0x8B77160", VA = "0x188B77D60")]
	private string EPBHHEFKGHF(AggregateException IDPHGGPGKGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x8B78100", Offset = "0x8B77500", VA = "0x188B78100")]
	private void GANFAGENKND(Type KAKMIDBKFLL, int FCDCKNGNLFJ, FFOFLPJDPKB? HHFMBNECBAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x8B78A20", Offset = "0x8B77E20", VA = "0x188B78A20")]
	private void NEDNFPEACPI(Type KAKMIDBKFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x8B77A20", Offset = "0x8B76E20", VA = "0x188B77A20")]
	private void BGJDMMLJPOP(Type KAKMIDBKFLL, HHALCCIFGIL KJINELPOKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x8B788A0", Offset = "0x8B77CA0", VA = "0x188B788A0")]
	private static int MMADLJAMCCG(Type KAKMIDBKFLL, Dictionary<Type, int> LHNBDNCNBOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0x3CB07E0", Offset = "0x3CAFBE0", VA = "0x183CB07E0")]
	private static bool OIJCJNCDDDK<TVal>(BFDACOCPFFB<TVal> EJCCOPPBIIG, Type KAKMIDBKFLL, [Out] TVal CBMEHPPMEEA) where TVal : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0x8B78C70", Offset = "0x8B78070", VA = "0x188B78C70")]
	[CompilerGenerated]
	internal static int OJJBNOINHEJ(Type MFHEIDHHCAP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000108")]
public struct IPIFMJIHHHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40003DD")]
	public readonly CGLANNGJMPD DPIHOPJEEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003DE")]
	public readonly string FHMNOLDELLK;

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0x8B7C5C0", Offset = "0x8B7B9C0", VA = "0x188B7C5C0")]
	public IPIFMJIHHHK(string AMAFEFOPMGN, CGLANNGJMPD FCDCKNGNLFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0x8B7C520", Offset = "0x8B7B920", VA = "0x188B7C520")]
	public string OBCCCBNBFFD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000109")]
public class EOLAJDKNPJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003DF")]
	private readonly IPONJNHEOIB HMAPBGFFGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003E0")]
	private string FPLKKCCOCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	private long? GGFOPNLOGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003E2")]
	private long? CEFFPMLILNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40003E3")]
	private long? DCFCMCJDEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40003E4")]
	private string FJKMKDOKOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private HHALHAFODBO BKFGBKNBEBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40003E6")]
	private long? NMCIMCKOGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40003E7")]
	private bool CFOCAJGAAEC;

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public string EINDAAKOPLE
	{
		[Cpp2IlInjected.Token(Token = "0x60004C5")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public long GNKGHPEONOB
	{
		[Cpp2IlInjected.Token(Token = "0x60004C6")]
		[Cpp2IlInjected.Address(RVA = "0x8B744E0", Offset = "0x8B738E0", VA = "0x188B744E0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public long BPLBEPEHIBD
	{
		[Cpp2IlInjected.Token(Token = "0x60004C7")]
		[Cpp2IlInjected.Address(RVA = "0x8B73FF0", Offset = "0x8B733F0", VA = "0x188B73FF0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public long BHPFDOEJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x8B74540", Offset = "0x8B73940", VA = "0x188B74540")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	public string LEDDKCIKBBN
	{
		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x8B74790", Offset = "0x8B73B90", VA = "0x188B74790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public HHALHAFODBO GFDHHGBJFFM
	{
		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0xAD29F0", Offset = "0xAD1DF0", VA = "0x180AD29F0")]
		get
		{
			return default(HHALHAFODBO);
		}
		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x8B745A0", Offset = "0x8B739A0", VA = "0x188B745A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public long CMBBPCLFGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x8B74730", Offset = "0x8B73B30", VA = "0x188B74730")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0x8B74A20", Offset = "0x8B73E20", VA = "0x188B74A20")]
	[UnityEngine.Scripting.Preserve]
	public EOLAJDKNPJP([PKIHAALFADL(null)] IPONJNHEOIB HMAPBGFFGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0x8B747D0", Offset = "0x8B73BD0", VA = "0x188B747D0")]
	private void MDJMCMKKIOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0x8B74050", Offset = "0x8B73450", VA = "0x188B74050")]
	public void FBKIIKPNLAD(long DCONEHIDLCB, long JLNBCNHEKAJ, [Optional] long? DAKBFKLMPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0x8B74690", Offset = "0x8B73A90", VA = "0x188B74690")]
	public void LDDGEEBHNFC(long DAKBFKLMPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0x8B73F70", Offset = "0x8B73370", VA = "0x188B73F70")]
	public void BODKDFFNEEK(string GNJOMAPLBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0x8B73C00", Offset = "0x8B73000", VA = "0x188B73C00")]
	public void BDLBGBNCGGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200010A")]
internal class NFGCOFFCAHB : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[CompilerGenerated]
	private struct FHEACNIINLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public AsyncTaskMethodBuilder<HNBAHPJPPAI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public HNBAHPJPPAI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public NFGCOFFCAHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private TaskAwaiter<KHKGOPFBEOO.IGGDOKLMJBC<HNBAHPJPPAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004EB")]
		[Cpp2IlInjected.Address(RVA = "0x8B77270", Offset = "0x8B76670", VA = "0x188B77270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004EC")]
		[Cpp2IlInjected.Address(RVA = "0x8B777B0", Offset = "0x8B76BB0", VA = "0x188B777B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	[CompilerGenerated]
	private struct CGKDGPIILAL<T> where T : IMessage<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public byte[] message;
	}

	[Cpp2IlInjected.Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class DGCKLBDLFPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public HNBAHPJPPAI roomOperationMessage;

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public DGCKLBDLFPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x8B70CA0", Offset = "0x8B700A0", VA = "0x188B70CA0")]
		internal HNBAHPJPPAI HEDDKPPJKNK(byte[] msg)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200010F")]
	[CompilerGenerated]
	private struct PFBEJEPFPJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public AsyncTaskMethodBuilder<KHKGOPFBEOO.IGGDOKLMJBC<HNBAHPJPPAI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public HNBAHPJPPAI roomOperationMessage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public NFGCOFFCAHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private CIPBAEEMAEF <expectedMessageKind>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private ByteString <expectedOperationId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private TaskAwaiter<KHKGOPFBEOO.IGGDOKLMJBC<HNBAHPJPPAI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x8B86820", Offset = "0x8B85C20", VA = "0x188B86820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x8B86E30", Offset = "0x8B86230", VA = "0x188B86E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct EDPBJMOECAJ<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public NFGCOFFCAHB <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x49B7BB0", Offset = "0x49B6FB0", VA = "0x1849B7BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x49B8100", Offset = "0x49B7500", VA = "0x1849B8100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CompilerGenerated]
	private struct BELAPGDKBBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public NFGCOFFCAHB <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8B6DA20", Offset = "0x8B6CE20", VA = "0x188B6DA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x8B6DD00", Offset = "0x8B6D100", VA = "0x188B6DD00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class MJDCNJJINDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public Func<Guid, bool> externalFilter;

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public MJDCNJJINDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000500")]
		[Cpp2IlInjected.Address(RVA = "0x8B82D50", Offset = "0x8B82150", VA = "0x188B82D50")]
		internal object OEDMGFNFKEP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000501")]
		[Cpp2IlInjected.Address(RVA = "0x8B82C90", Offset = "0x8B82090", VA = "0x188B82C90")]
		internal bool IJHOKONOFMC(Guid guid)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000115")]
	[CompilerGenerated]
	private sealed class PEAAJOFLEAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public Func<Guid, bool> filter;

		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public PEAAJOFLEAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x8B867C0", Offset = "0x8B85BC0", VA = "0x188B867C0")]
		internal object FNIDLCBKDDI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class IMEGDACLJMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public IMEGDACLJMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000505")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C450", Offset = "0x8B7B850", VA = "0x188B7C450")]
		internal object FMJIIGLPKMP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[CompilerGenerated]
	private sealed class KMCBIAINIJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public Guid sliceId;

		[Cpp2IlInjected.Token(Token = "0x6000506")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public KMCBIAINIJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000507")]
		[Cpp2IlInjected.Address(RVA = "0x8B81300", Offset = "0x8B80700", VA = "0x188B81300")]
		internal object IDMCEOBAGPH()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class AJGGNKKBIPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public NFGCOFFCAHB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public string stepMessage;

		[Cpp2IlInjected.Token(Token = "0x6000508")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public AJGGNKKBIPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000509")]
		[Cpp2IlInjected.Address(RVA = "0x8B6C9A0", Offset = "0x8B6BDA0", VA = "0x188B6C9A0")]
		internal object CBIDCGBHKEI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40003E8")]
	private static readonly Guid GKCDHKAIMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40003E9")]
	public readonly KKGNFEOCIOB LHGELCIPFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003EA")]
	private readonly KHKGOPFBEOO OKFCJKKGDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	private readonly FIHEDBOAMLM KMFAHFKEGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40003EC")]
	private readonly FEJAGFIJCPP NPOLJNCMJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003ED")]
	private bool FKBBGODDLIB;

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0x8B85360", Offset = "0x8B84760", VA = "0x188B85360")]
	public NFGCOFFCAHB(KKGNFEOCIOB GKJPEAFFBEP, KHKGOPFBEOO OKFCJKKGDBH, FIHEDBOAMLM KMFAHFKEGPF, FEJAGFIJCPP NPOLJNCMJDF, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0x8B84680", Offset = "0x8B83A80", VA = "0x188B84680", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0x8B84E20", Offset = "0x8B84220", VA = "0x188B84E20")]
	public void LFPMBEKNANI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0x8B845C0", Offset = "0x8B839C0", VA = "0x188B845C0")]
	public void DLNFGDMJBGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0x8B84F40", Offset = "0x8B84340", VA = "0x188B84F40")]
	public void MDCBNNHFNGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0x8B84320", Offset = "0x8B83720", VA = "0x188B84320")]
	[AsyncStateMachine(typeof(FHEACNIINLO))]
	internal Task<HNBAHPJPPAI> CDPKCEGHDLC(CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, HNBAHPJPPAI OJDCKMAPLCP, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0x3E5B0D0", Offset = "0x3E5A4D0", VA = "0x183E5B0D0")]
	private static byte[] LIGMOBJMFKG<T>(T AFDNIPHJHMO) where T : IMessage<T>
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0x3E5AD00", Offset = "0x3E5A100", VA = "0x183E5AD00")]
	private static T HIDIOFABNNN<T>(MessageParser<T> DEIBDNOPGPB, byte[] AFDNIPHJHMO, T KMBHGPAJLKO) where T : IMessage<T>
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0x8B84150", Offset = "0x8B83550", VA = "0x188B84150")]
	[AsyncStateMachine(typeof(PFBEJEPFPJL))]
	private Task<KHKGOPFBEOO.IGGDOKLMJBC<HNBAHPJPPAI>> ABBJFCOOPDN(HNBAHPJPPAI OJDCKMAPLCP, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0x3E5AE50", Offset = "0x3E5A250", VA = "0x183E5AE50")]
	[AsyncStateMachine(typeof(EDPBJMOECAJ<>))]
	internal Task<T> IHMKGOMGHJP<T>(CancellationToken NILMHHOPMOB, Func<CancellationToken, Task<T>> LMMEMECAGJB, int MCGNPPJKPID = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0x8B84900", Offset = "0x8B83D00", VA = "0x188B84900")]
	[AsyncStateMachine(typeof(BELAPGDKBBN))]
	internal Task IHMKGOMGHJP(CancellationToken NILMHHOPMOB, Func<CancellationToken, Task> LMMEMECAGJB, int MCGNPPJKPID = 3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0x8B85000", Offset = "0x8B84400", VA = "0x188B85000")]
	public HPPNIEBCIMH NMBCNEBDBMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0x8B84290", Offset = "0x8B83690", VA = "0x188B84290")]
	public JELNMBMFAJB BNCCKNAEMMM([Optional] NOFPNMHOLJE NFIHGODFMOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0x8B85080", Offset = "0x8B84480", VA = "0x188B85080")]
	public GKHJHHJLBGJ OOKNMFIOGPH([Optional] AKNCNLDICPO? CCLJCJDJCOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0x8B847A0", Offset = "0x8B83BA0", VA = "0x188B847A0")]
	public void IEOPKLPCGGL(Func<Guid, bool> CICIPGIFMAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0x8B84B90", Offset = "0x8B83F90", VA = "0x188B84B90")]
	public void KLBDPPEEFLH(Func<Guid, bool> NIKABFAIENA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0x8B84CA0", Offset = "0x8B840A0", VA = "0x188B84CA0")]
	public Guid LCLBJCKBBKC()
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0x8B84A80", Offset = "0x8B83E80", VA = "0x188B84A80")]
	public void IOPKBLIEELK(Guid LEPFIPKMFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0x8B84480", Offset = "0x8B83880", VA = "0x188B84480")]
	public void DKDGCAEGDKE(HNBAHPJPPAI GJEDEOFEBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x8B84690", Offset = "0x8B83A90", VA = "0x188B84690")]
	public void GJFBEGANDPI(string HGPMMHKALDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0x3E5AC20", Offset = "0x3E5A020", VA = "0x183E5AC20")]
	private T HHHJDDGIDNO<T>(T CBMEHPPMEEA) where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0x8B84A30", Offset = "0x8B83E30", VA = "0x188B84A30")]
	public void ILAOHJNOJOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x3E5B0E0", Offset = "0x3E5A4E0", VA = "0x183E5B0E0")]
	[CompilerGenerated]
	internal static string OHKEGLMHOLA<T>(byte[] FGHKEPJEKFP, int LADMEHMLHKB, CGKDGPIILAL<T> P_2) where T : IMessage<T>
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
internal sealed class FCHICLHNPMK : KKGNFEOCIOB
{
	[Cpp2IlInjected.Token(Token = "0x200011A")]
	[CompilerGenerated]
	private sealed class NGPCOMILCAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public Guid operationId;

		[Cpp2IlInjected.Token(Token = "0x6000510")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public NGPCOMILCAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x8B85590", Offset = "0x8B84990", VA = "0x188B85590")]
		internal object CHCOOHFKFHN()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011B")]
	[CompilerGenerated]
	private struct GNAKHIJPNHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public FCHICLHNPMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public NFGCOFFCAHB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private CGAODEELHOF <presence>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private JELNMBMFAJB <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private TaskAwaiter<EODNBIJLMMJ> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x8B79580", Offset = "0x8B78980", VA = "0x188B79580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x8B7A480", Offset = "0x8B79880", VA = "0x188B7A480", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011C")]
	[CompilerGenerated]
	private struct CMHMNEFLAJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public FCHICLHNPMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private bool <omShouldBeEnabled>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private TaskAwaiter<MBLNIACGJFP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private TaskAwaiter<int> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x8B6FB50", Offset = "0x8B6EF50", VA = "0x188B6FB50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x8B702F0", Offset = "0x8B6F6F0", VA = "0x188B702F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200011D")]
	[CompilerGenerated]
	private struct DMOOIKIBPIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		public AsyncTaskMethodBuilder<int> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public FCHICLHNPMK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private TaskAwaiter<EILAOANGAEC> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x8B720F0", Offset = "0x8B714F0", VA = "0x188B720F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x8B72400", Offset = "0x8B71800", VA = "0x188B72400", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200011E")]
	[CompilerGenerated]
	private sealed class BOBIPJJPGOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public CGAODEELHOF presence;

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public BOBIPJJPGOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x8B6E510", Offset = "0x8B6D910", VA = "0x188B6E510")]
		internal object COFPINLFIPP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400041B")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x400041C")]
	private static readonly AKNCNLDICPO BJLNEJCBJGP;

	[Cpp2IlInjected.Token(Token = "0x400041D")]
	private static readonly AKNCNLDICPO LLOHOOFJMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400041E")]
	private readonly BGMNPHKELEH PCAGCICDLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private readonly AAKDENBOOJG IAFGJMENDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private readonly NOFPNMHOLJE NFIHGODFMOO;

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x8B75670", Offset = "0x8B74A70", VA = "0x188B75670")]
	public FCHICLHNPMK(BGMNPHKELEH PCAGCICDLCG, AAKDENBOOJG IAFGJMENDAD, Guid PADGMLDAJOI, JNGEBJCPLIA IDEPICHODDC, BHMBHHAEFLE MJKLKOKDNHK, NOFPNMHOLJE NFIHGODFMOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x8B75440", Offset = "0x8B74840", VA = "0x188B75440", Slot = "7")]
	[AsyncStateMachine(typeof(GNAKHIJPNHE))]
	protected override Task KHINMJLLPMJ(NFGCOFFCAHB PJGCMFIFJNB, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x8B75060", Offset = "0x8B74460", VA = "0x188B75060")]
	[AsyncStateMachine(typeof(CMHMNEFLAJB))]
	private Task BJJGBDAMAEJ(CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x8B75330", Offset = "0x8B74730", VA = "0x188B75330")]
	[AsyncStateMachine(typeof(DMOOIKIBPIM))]
	private Task<int> JCLEJGGDBKN(CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0x8B75160", Offset = "0x8B74560", VA = "0x188B75160")]
	private CGAODEELHOF IJFPCNONHPJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
internal class BPDDKIDLADD : KKGNFEOCIOB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000120")]
	[CompilerGenerated]
	private struct BPOKDCCFHGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public BPDDKIDLADD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public NFGCOFFCAHB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private TaskAwaiter<LFHDKPIJJCJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x8B6E8A0", Offset = "0x8B6DCA0", VA = "0x188B6E8A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x8B6F250", Offset = "0x8B6E650", VA = "0x188B6F250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400043A")]
	private readonly int HABDIDHOIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400043B")]
	private readonly HOAPKCGDNIL PGGNJLGKBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400043C")]
	public readonly long NMJFOBHOBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400043D")]
	public readonly long PGBDEAPKGPH;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public LFHDKPIJJCJ NFCIACBEAAP
	{
		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0xA7C960", Offset = "0xA7BD60", VA = "0x180A7C960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xA7C810", Offset = "0xA7BC10", VA = "0x180A7C810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0x8B6E770", Offset = "0x8B6DB70", VA = "0x188B6E770")]
	public BPDDKIDLADD(Guid PADGMLDAJOI, JNGEBJCPLIA IDEPICHODDC, BHMBHHAEFLE MJKLKOKDNHK, int HABDIDHOIBN, HOAPKCGDNIL PGGNJLGKBOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0x8B6E650", Offset = "0x8B6DA50", VA = "0x188B6E650", Slot = "7")]
	[AsyncStateMachine(typeof(BPOKDCCFHGK))]
	protected override Task KHINMJLLPMJ(NFGCOFFCAHB PJGCMFIFJNB, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000121")]
internal abstract class LLHEHCOOILE : KKGNFEOCIOB
{
	[Cpp2IlInjected.Token(Token = "0x2000122")]
	[CompilerGenerated]
	private sealed class CCGAIKCHNJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		public LLHEHCOOILE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		public KFGBAMIOEAD playerDespawn;

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public CCGAIKCHNJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x8B6F340", Offset = "0x8B6E740", VA = "0x188B6F340")]
		internal Task KHMBIKMFOBK(CIIMOEPMPCG<string>.MOMGGNPHIKH postOpTimer, CancellationToken postOpToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x8B6F2B0", Offset = "0x8B6E6B0", VA = "0x188B6F2B0")]
		internal object DLDBBJPEMJF()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000123")]
	[CompilerGenerated]
	private struct KGCALNGLNDC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		public LLHEHCOOILE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		public NFGCOFFCAHB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private CCGAIKCHNJC <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x8B7EEC0", Offset = "0x8B7E2C0", VA = "0x188B7EEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x8B7F820", Offset = "0x8B7EC20", VA = "0x188B7F820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[CompilerGenerated]
	private struct HCIONJACLNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		public IDisposable freezePlayerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		public KFGBAMIOEAD playerDespawn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		public LLHEHCOOILE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x8B7A560", Offset = "0x8B79960", VA = "0x188B7A560", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x8B7AB20", Offset = "0x8B79F20", VA = "0x188B7AB20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000446")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0x8B82140", Offset = "0x8B81540", VA = "0x188B82140")]
	public LLHEHCOOILE(Guid PADGMLDAJOI, JNGEBJCPLIA IDEPICHODDC, BHMBHHAEFLE MJKLKOKDNHK, string OGPNKOEFHNO, ECCPAABCJNI MPPPMJJKDDE, bool ODAOHMLKIJF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0x8B81E50", Offset = "0x8B81250", VA = "0x188B81E50", Slot = "7")]
	[AsyncStateMachine(typeof(KGCALNGLNDC))]
	protected override Task KHINMJLLPMJ(NFGCOFFCAHB PJGCMFIFJNB, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract Task EEJIKKFOKMB(NFGCOFFCAHB PJGCMFIFJNB, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0x8B81F90", Offset = "0x8B81390", VA = "0x188B81F90")]
	[AsyncStateMachine(typeof(HCIONJACLNG))]
	private Task MPEMAKMMCMB(IDisposable GAHPOHDOPAG, KFGBAMIOEAD OACAIKAJBOM, CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000125")]
internal class KJLJJLGFJAM : KKGNFEOCIOB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000126")]
	[CompilerGenerated]
	private struct KHIKEFGOBCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public KJLJJLGFJAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public NFGCOFFCAHB operationContext;

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
		private TaskAwaiter<NCAEELCEENN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x8B7F880", Offset = "0x8B7EC80", VA = "0x188B7F880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x8B7FE70", Offset = "0x8B7F270", VA = "0x188B7FE70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400045C")]
	private readonly GFFNCJJHNKA PLJIHINALMN;

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0x8B800D0", Offset = "0x8B7F4D0", VA = "0x188B800D0")]
	public KJLJJLGFJAM(Guid PADGMLDAJOI, JNGEBJCPLIA IDEPICHODDC, BHMBHHAEFLE MJKLKOKDNHK, GFFNCJJHNKA PLJIHINALMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x8B7FFF0", Offset = "0x8B7F3F0", VA = "0x188B7FFF0", Slot = "6")]
	protected override string MFJEMOBLAKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0x8B7FED0", Offset = "0x8B7F2D0", VA = "0x188B7FED0", Slot = "7")]
	[AsyncStateMachine(typeof(KHIKEFGOBCF))]
	protected override Task KHINMJLLPMJ(NFGCOFFCAHB PJGCMFIFJNB, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000127")]
internal abstract class KKGNFEOCIOB : NHPEHMDHCFM
{
	[Cpp2IlInjected.Token(Token = "0x2000128")]
	public delegate Task COANIMMLPLE(CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x2000129")]
	[CompilerGenerated]
	private sealed class NNIOPOCEJEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH operationRunStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public KKGNFEOCIOB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public NNIOPOCEJEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0x8B85740", Offset = "0x8B84B40", VA = "0x188B85740")]
		internal Task ICGFNMIHOKM(CancellationToken t)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200012A")]
	[CompilerGenerated]
	private sealed class FHFDIHDODBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public Exception ex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public NNIOPOCEJEO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public FHFDIHDODBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x8B77820", Offset = "0x8B76C20", VA = "0x188B77820")]
		internal object COLIJIGIKCP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012B")]
	[CompilerGenerated]
	private struct DMDGBENNMGD : IAsyncStateMachine
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
		public KKGNFEOCIOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public Func<KKGNFEOCIOB, CIIMOEPMPCG<string>.MOMGGNPHIKH, NFGCOFFCAHB> operationContextBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private NNIOPOCEJEO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private bool <success>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private NFGCOFFCAHB <operationContext>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private TaskAwaiter<HNBAHPJPPAI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x8B70D80", Offset = "0x8B70180", VA = "0x188B70D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0x8B72090", Offset = "0x8B71490", VA = "0x188B72090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[CompilerGenerated]
	private struct MCLBDKIOABA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8B82190", Offset = "0x8B81590", VA = "0x188B82190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0x8B82C30", Offset = "0x8B82030", VA = "0x188B82C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012D")]
	[CompilerGenerated]
	private struct GGIKJBKFLCD : IAsyncStateMachine
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
		public KKGNFEOCIOB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x8B791C0", Offset = "0x8B785C0", VA = "0x188B791C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x8B79520", Offset = "0x8B78920", VA = "0x188B79520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000465")]
	public readonly Guid CKANHNHMJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000466")]
	public readonly ByteString GKIPLLCDMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000467")]
	public readonly BHMBHHAEFLE MBHKNBGIDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000468")]
	protected readonly string BKCJBAEHBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000469")]
	private readonly JNGEBJCPLIA IDEPICHODDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	private readonly bool ODAOHMLKIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	private readonly Queue<COANIMMLPLE> EEDOAIAIJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400046C")]
	private readonly MOMLBLNPBLC CNHJMOOGNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400046D")]
	private readonly ECCPAABCJNI MPPPMJJKDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	private bool ABMACBCLEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public HHALHAFODBO CJACHFFJCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public HHALHAFODBO BIOBEAHABKJ;

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public JNGEBJCPLIA BEBMHIJNKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public IJIEICICPPB JDGMIPEIBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x8B80C50", Offset = "0x8B80050", VA = "0x188B80C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public BGMGFHJNNDK JKKJFMCJMOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000533")]
		[Cpp2IlInjected.Address(RVA = "0x8B80C00", Offset = "0x8B80000", VA = "0x188B80C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public CJGDJMIKAIC MJABACAOHLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000534")]
		[Cpp2IlInjected.Address(RVA = "0x8B80170", Offset = "0x8B7F570", VA = "0x188B80170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001A")]
	public event NBADGDDEIDG IEONFJOOMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000535")]
		[Cpp2IlInjected.Address(RVA = "0x8B804B0", Offset = "0x8B7F8B0", VA = "0x188B804B0", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000536")]
		[Cpp2IlInjected.Address(RVA = "0x8B80CA0", Offset = "0x8B800A0", VA = "0x188B80CA0", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x8B80CC0", Offset = "0x8B800C0", VA = "0x188B80CC0")]
	protected KKGNFEOCIOB(Guid PADGMLDAJOI, JNGEBJCPLIA IDEPICHODDC, BHMBHHAEFLE MJKLKOKDNHK, string OGPNKOEFHNO, ECCPAABCJNI MPPPMJJKDDE, bool ODAOHMLKIJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x8B80690", Offset = "0x8B7FA90", VA = "0x188B80690", Slot = "6")]
	protected virtual string MFJEMOBLAKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0x8B80BA0", Offset = "0x8B7FFA0", VA = "0x188B80BA0")]
	public void NFCNGFBFNKL(COANIMMLPLE MEBGBNKILEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0x8B805F0", Offset = "0x8B7F9F0", VA = "0x188B805F0")]
	protected void HGABPAHMLBD(float AOECCAAAEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0x8B801F0", Offset = "0x8B7F5F0", VA = "0x188B801F0")]
	[AsyncStateMachine(typeof(DMDGBENNMGD))]
	public Task COBMPGJIBLC(CancellationToken GMKBGHHNCDJ, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, [Optional] Func<KKGNFEOCIOB, CIIMOEPMPCG<string>.MOMGGNPHIKH, NFGCOFFCAHB> GIENEEAJBNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0x8B80A70", Offset = "0x8B7FE70", VA = "0x188B80A70")]
	[AsyncStateMachine(typeof(MCLBDKIOABA))]
	private static Task NEFCNECGOCP(Func<CancellationToken, Task> FHKLDHJKLHH, Func<CancellationToken, Task> FJBPAJEFPNP, CancellationToken NILMHHOPMOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0x8B80340", Offset = "0x8B7F740", VA = "0x188B80340")]
	private void EFKJEFJDFKG(bool DLGALHBKJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x8B806D0", Offset = "0x8B7FAD0", VA = "0x188B806D0")]
	private void MIPDJFBOMAO(NFGCOFFCAHB PJGCMFIFJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract Task KHINMJLLPMJ(NFGCOFFCAHB PJGCMFIFJNB, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x8B804D0", Offset = "0x8B7F8D0", VA = "0x188B804D0")]
	[AsyncStateMachine(typeof(GGIKJBKFLCD))]
	private Task FNDEGGFLGDE(CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x8B80900", Offset = "0x8B7FD00", VA = "0x188B80900")]
	public HNBAHPJPPAI NAGLPBJMFAE(CIPBAEEMAEF KCHBKFHGBPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x8B80980", Offset = "0x8B7FD80", VA = "0x188B80980")]
	[CompilerGenerated]
	private Task NBFMCLKMHGI(CancellationToken DBAMLJDDEJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x8B80610", Offset = "0x8B7FA10", VA = "0x188B80610")]
	[CompilerGenerated]
	private object HJDPNINDJKF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200012E")]
internal sealed class JDFCPAGCEAC : LLHEHCOOILE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200012F")]
	[CompilerGenerated]
	private struct OOENPEAAGPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public JDFCPAGCEAC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public NFGCOFFCAHB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private NBKAILCGOBA <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private JELNMBMFAJB <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x8B86000", Offset = "0x8B85400", VA = "0x188B86000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x8B86760", Offset = "0x8B85B60", VA = "0x188B86760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000492")]
	private readonly BGMNPHKELEH IBGFEEMIGBL;

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0x8B7C730", Offset = "0x8B7BB30", VA = "0x188B7C730")]
	public JDFCPAGCEAC(Guid PADGMLDAJOI, JNGEBJCPLIA IDEPICHODDC, BGMNPHKELEH IBGFEEMIGBL, BHMBHHAEFLE MJKLKOKDNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0x8B7C5E0", Offset = "0x8B7B9E0", VA = "0x188B7C5E0", Slot = "8")]
	[AsyncStateMachine(typeof(OOENPEAAGPF))]
	protected override Task EEJIKKFOKMB(NFGCOFFCAHB PJGCMFIFJNB, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
internal class BFDDDCKAJNP : KKGNFEOCIOB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[CompilerGenerated]
	private struct KLBPINKCMOF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public BFDDDCKAJNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public NFGCOFFCAHB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private TaskAwaiter<NCAEELCEENN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0x8B80E20", Offset = "0x8B80220", VA = "0x188B80E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x8B812A0", Offset = "0x8B806A0", VA = "0x188B812A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private readonly string NFABEECHIKI;

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0x8B6DE70", Offset = "0x8B6D270", VA = "0x188B6DE70")]
	public BFDDDCKAJNP(Guid PADGMLDAJOI, JNGEBJCPLIA IDEPICHODDC, BHMBHHAEFLE MJKLKOKDNHK, string NFABEECHIKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0x8B6DD60", Offset = "0x8B6D160", VA = "0x188B6DD60", Slot = "7")]
	[AsyncStateMachine(typeof(KLBPINKCMOF))]
	protected override Task KHINMJLLPMJ(NFGCOFFCAHB PJGCMFIFJNB, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000132")]
internal class BLOMICIKJHN : LLHEHCOOILE
{
	[Cpp2IlInjected.Token(Token = "0x2000133")]
	[CompilerGenerated]
	private sealed class MLOHCGOKCMF
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
			public AsyncTaskMethodBuilder<HNBAHPJPPAI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004B1")]
			public MLOHCGOKCMF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			public CancellationToken masterLockedCodeBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			private TaskAwaiter<NCAEELCEENN> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004B4")]
			private TaskAwaiter<HNBAHPJPPAI> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600055F")]
			[Cpp2IlInjected.Address(RVA = "0x8B88FD0", Offset = "0x8B883D0", VA = "0x188B88FD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(RVA = "0x8B894C0", Offset = "0x8B888C0", VA = "0x188B894C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public BLOMICIKJHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public GKHJHHJLBGJ serializeLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public EPBLMMCONNB roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public HPPNIEBCIMH uploadLogic;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public long superRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public AHKALLEBELB roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public MLOHCGOKCMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x8B82DB0", Offset = "0x8B821B0", VA = "0x188B82DB0")]
		[AsyncStateMachine(typeof(<<RunWhilePlayerDespawnedAsync>b__0>d))]
		internal Task<HNBAHPJPPAI> CBJEKGBGGFM(CancellationToken masterLockedCodeBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000135")]
	[CompilerGenerated]
	private struct PKBCECANKFO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public BLOMICIKJHN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public NFGCOFFCAHB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private MLOHCGOKCMF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private NBKAILCGOBA <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private JELNMBMFAJB <loadLogic>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private HNBAHPJPPAI <saveReloadMessage>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private TaskAwaiter<HNBAHPJPPAI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x8B88080", Offset = "0x8B87480", VA = "0x188B88080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x8B88F70", Offset = "0x8B88370", VA = "0x188B88F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40004A3")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x40004A4")]
	private static readonly AKNCNLDICPO BJLNEJCBJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004A5")]
	private readonly int IIIICGCPFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	[CanBeNull]
	private readonly NAODMFNDKAH MMMALGMIIMN;

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0x8B6E3E0", Offset = "0x8B6D7E0", VA = "0x188B6E3E0")]
	public BLOMICIKJHN(Guid PADGMLDAJOI, JNGEBJCPLIA IDEPICHODDC, int IIIICGCPFGI, NAODMFNDKAH MMMALGMIIMN, BHMBHHAEFLE MJKLKOKDNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0x8B6DF20", Offset = "0x8B6D320", VA = "0x188B6DF20", Slot = "8")]
	[AsyncStateMachine(typeof(PKBCECANKFO))]
	protected override Task EEJIKKFOKMB(NFGCOFFCAHB PJGCMFIFJNB, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0x8B6E230", Offset = "0x8B6D630", VA = "0x188B6E230")]
	private void NBOIOPDGMEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0x8B6E060", Offset = "0x8B6D460", VA = "0x188B6E060")]
	private void HGGANFFICPM(CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, NBKAILCGOBA KKPBBNLOJBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000136")]
internal class CHPGJFHLDMO : KKGNFEOCIOB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000137")]
	[CompilerGenerated]
	private struct IIDFHAIOCPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public CHPGJFHLDMO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private NBKAILCGOBA <roomEvent>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private long <superRoomId>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private long <subRoomId>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private EILAOANGAEC <currentRoomSave>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private JAKNEJKGEIC<ReadOnlySequence<byte>> <subroomDataBlobHandle>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private TaskAwaiter<EILAOANGAEC> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private TaskAwaiter<ReadOnlySequence<byte>> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private TaskAwaiter<LFHDKPIJJCJ> <>u__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private TaskAwaiter <>u__4;

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x8B7AFC0", Offset = "0x8B7A3C0", VA = "0x188B7AFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C3F0", Offset = "0x8B7B7F0", VA = "0x188B7C3F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004C1")]
	private readonly int IIIICGCPFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40004C2")]
	private readonly NAODMFNDKAH MMMALGMIIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40004C3")]
	private Func<NCAEELCEENN, NCAEELCEENN> NBPDBOJPCGN;

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0x8B6F590", Offset = "0x8B6E990", VA = "0x188B6F590")]
	public CHPGJFHLDMO(Guid PADGMLDAJOI, JNGEBJCPLIA IDEPICHODDC, int IIIICGCPFGI, NAODMFNDKAH MMMALGMIIMN, Func<NCAEELCEENN, NCAEELCEENN> NBPDBOJPCGN, BHMBHHAEFLE MJKLKOKDNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0x8B6F460", Offset = "0x8B6E860", VA = "0x188B6F460", Slot = "7")]
	[AsyncStateMachine(typeof(IIDFHAIOCPJ))]
	protected override Task KHINMJLLPMJ(NFGCOFFCAHB PJGCMFIFJNB, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000138")]
internal abstract class FEGMPGAEEEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D2")]
	public readonly KKGNFEOCIOB LHGELCIPFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D3")]
	public readonly NFGCOFFCAHB DPOPNMLAKCG;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public IJIEICICPPB JDGMIPEIBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x8B769B0", Offset = "0x8B75DB0", VA = "0x188B769B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public CJGDJMIKAIC MJABACAOHLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x8B76800", Offset = "0x8B75C00", VA = "0x188B76800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0x8B76A00", Offset = "0x8B75E00", VA = "0x188B76A00")]
	protected FEGMPGAEEEE(NFGCOFFCAHB PJGCMFIFJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0x8B76890", Offset = "0x8B75C90", VA = "0x188B76890")]
	protected void GJFBEGANDPI(string HGPMMHKALDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal struct EODJELMBNAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004D4")]
	public Dictionary<Guid, List<OHJDDFABGKG>> FJMBIJMEIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004D5")]
	public Dictionary<Guid, List<OHJDDFABGKG>> CCOJLDGBJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004D6")]
	public Dictionary<Guid, List<OHJDDFABGKG>> FMBNNBEDMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004D7")]
	public List<Guid> INGIGCNOIMA;

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0x8B735F0", Offset = "0x8B729F0", VA = "0x188B735F0")]
	public static EODJELMBNAJ DIJAEKOIPED(IJIEICICPPB LHIJBEJLBFF, HHALHAFODBO LNIPIHKBBJE, PJKBEIHEIIE EOJHGNPAAAI)
	{
		return default(EODJELMBNAJ);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200013B")]
internal struct NIAJHKMPPDO
{
	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810")]
	public static NIAJHKMPPDO CEOONNIFPHP()
	{
		return default(NIAJHKMPPDO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
internal struct FNBLNBOMKEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	public readonly MBLNIACGJFP MOJKGMPPOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	public readonly EOHPFFLACLH HOKAHLLJNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004DD")]
	public readonly Guid? GCDGOJIGOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004DE")]
	public readonly IReadOnlyCollection<NCDNOPDHNPA> MBBBOJDGOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004DF")]
	public readonly IReadOnlyCollection<NCDNOPDHNPA> LOMDMIGODGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004E0")]
	public readonly APAGCNALJKL PNHJPDOBEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40004E1")]
	public readonly APAGCNALJKL IAOLPELEMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004E2")]
	public readonly GJNECDDAEBM FANLGPHJHGO;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public bool HNPPFGOLIML
	{
		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x8B778E0", Offset = "0x8B76CE0", VA = "0x188B778E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0x8B77970", Offset = "0x8B76D70", VA = "0x188B77970")]
	public FNBLNBOMKEN(MBLNIACGJFP MOJKGMPPOOM, EOHPFFLACLH HOKAHLLJNIL, Guid? GCDGOJIGOMN, IReadOnlyList<NCDNOPDHNPA> MBBBOJDGOAD, IReadOnlyCollection<NCDNOPDHNPA> LOMDMIGODGN, APAGCNALJKL PNHJPDOBEAP, APAGCNALJKL IAOLPELEMJE, GJNECDDAEBM FANLGPHJHGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
internal struct KBOHKCGLAPA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004E3")]
	private readonly NFGCOFFCAHB PJGCMFIFJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004E4")]
	private readonly Guid LEPFIPKMFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004E5")]
	private bool DLGALHBKJDJ;

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0x8B7E990", Offset = "0x8B7DD90", VA = "0x188B7E990")]
	public static KBOHKCGLAPA LCLBJCKBBKC(NFGCOFFCAHB PJGCMFIFJNB)
	{
		return default(KBOHKCGLAPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0x134DFE0", Offset = "0x134D3E0", VA = "0x18134DFE0")]
	public void LDAFEBIDFLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0x8B7E740", Offset = "0x8B7DB40", VA = "0x188B7E740", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0x8B7E9C0", Offset = "0x8B7DDC0", VA = "0x188B7E9C0")]
	private KBOHKCGLAPA(NFGCOFFCAHB PJGCMFIFJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0x8B7E750", Offset = "0x8B7DB50", VA = "0x188B7E750")]
	private void IOPKBLIEELK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0x8B7E6A0", Offset = "0x8B7DAA0", VA = "0x188B7E6A0")]
	private Func<Guid, bool> BCFGCOPDOOL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
internal class JELNMBMFAJB : FEGMPGAEEEE, NHPEHMDHCFM
{
	[Cpp2IlInjected.Token(Token = "0x200013F")]
	public delegate Task<HHALHAFODBO> HNCNGHCIBFK(PJKBEIHEIIE NGIAGNLBILI, NHDMGGKCHPC KIAHDDEKMJC, MOMLBLNPBLC AMFBNPOGHAA, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000140")]
	[CompilerGenerated]
	private struct EPCHEDCBDAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public JELNMBMFAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public BGMNPHKELEH request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private KBOHKCGLAPA <lifetime>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private TaskAwaiter<HNBAHPJPPAI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005A1")]
		[Cpp2IlInjected.Address(RVA = "0x8B90C60", Offset = "0x8B90060", VA = "0x188B90C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A2")]
		[Cpp2IlInjected.Address(RVA = "0x8B913A0", Offset = "0x8B907A0", VA = "0x188B913A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000141")]
	[CompilerGenerated]
	private struct BCNDBGBHPNE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public AsyncTaskMethodBuilder<HNBAHPJPPAI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public JELNMBMFAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public BGMNPHKELEH request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <syncTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private TaskAwaiter<HNBAHPJPPAI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A3")]
		[Cpp2IlInjected.Address(RVA = "0x8B8AD80", Offset = "0x8B8A180", VA = "0x188B8AD80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A4")]
		[Cpp2IlInjected.Address(RVA = "0x8B8B1B0", Offset = "0x8B8A5B0", VA = "0x188B8B1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000142")]
	[CompilerGenerated]
	private struct LEAJOMNJAOO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public JELNMBMFAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public BGMNPHKELEH request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <loadRoomLocalTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x8B97F50", Offset = "0x8B97350", VA = "0x188B97F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x8B98410", Offset = "0x8B97810", VA = "0x188B98410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[CompilerGenerated]
	private sealed class ICOHCPDKLII
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
			public AsyncTaskMethodBuilder<FNBLNBOMKEN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000512")]
			public ICOHCPDKLII <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000513")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000514")]
			private FNBLNBOMKEN <innerData>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000515")]
			private TaskAwaiter<HHALHAFODBO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000516")]
			private TaskAwaiter<FNBLNBOMKEN> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x8B9F600", Offset = "0x8B9EA00", VA = "0x188B9F600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x8B9FEC0", Offset = "0x8B9F2C0", VA = "0x188B9FEC0", Slot = "5")]
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
			public AsyncTaskMethodBuilder<PJKBEIHEIIE> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000519")]
			public ICOHCPDKLII <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400051A")]
			public CancellationToken innerCancellation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400051B")]
			private PJKBEIHEIIE <innerPhaseArgs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400051C")]
			private TaskAwaiter<HHALHAFODBO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400051D")]
			private TaskAwaiter<PJKBEIHEIIE> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0x8B9FF30", Offset = "0x8B9F330", VA = "0x188B9FF30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0x8BA0580", Offset = "0x8B9F980", VA = "0x188BA0580", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		public JELNMBMFAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public BGMNPHKELEH request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		public MOMLBLNPBLC preDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		public MOMLBLNPBLC downloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		public FNBLNBOMKEN data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public MOMLBLNPBLC postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		public PJKBEIHEIIE phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		public HIGDFOFBOPO.DABADIHPCNE <>9__5;

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public ICOHCPDKLII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x8B95350", Offset = "0x8B94750", VA = "0x188B95350")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__1>d))]
		internal Task<FNBLNBOMKEN> BEOFFKLIOJJ(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x8B95520", Offset = "0x8B94920", VA = "0x188B95520")]
		[AsyncStateMachine(typeof(<<LoadRoomLocal>b__3>d))]
		internal Task<PJKBEIHEIIE> KMLILGANALD(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x8B954A0", Offset = "0x8B948A0", VA = "0x188B954A0")]
		internal void FBHLMJFDDPC(long downloaded, long total)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x8B954E0", Offset = "0x8B948E0", VA = "0x188B954E0")]
		internal Task JAMODENGJBK(CancellationToken innerCancellation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x8B95640", Offset = "0x8B94A40", VA = "0x188B95640")]
		internal Task NIPKGJKMCEF(CancellationToken innerCancellation)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CompilerGenerated]
	private struct EGAMEFECJNM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		public JELNMBMFAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		public BGMNPHKELEH request;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		public CancellationToken externalCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private ICOHCPDKLII <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private TaskAwaiter<FNBLNBOMKEN> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private TaskAwaiter<PJKBEIHEIIE> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private TaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x8B8EFC0", Offset = "0x8B8E3C0", VA = "0x188B8EFC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B8FC90", Offset = "0x8B8F090", VA = "0x188B8FC90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000148")]
	[CompilerGenerated]
	private struct JLGDJHNNDLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		public JELNMBMFAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		public PJKBEIHEIIE phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		public MOMLBLNPBLC postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private TaskAwaiter<HHALHAFODBO> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private NHDMGGKCHPC <timedYielder>5__2;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x8B95BC0", Offset = "0x8B94FC0", VA = "0x188B95BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x8B96A20", Offset = "0x8B95E20", VA = "0x188B96A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private struct MHIEBMNDDCK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		public JELNMBMFAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x8B9B000", Offset = "0x8B9A400", VA = "0x188B9B000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x8B9B7E0", Offset = "0x8B9ABE0", VA = "0x188B9B7E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private struct EGLEICGKBAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		public JELNMBMFAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		public PJKBEIHEIIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		public MOMLBLNPBLC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <legacyLoadRoomDataTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private TaskAwaiter<HHALHAFODBO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x8B8FCF0", Offset = "0x8B8F0F0", VA = "0x188B8FCF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x8B90530", Offset = "0x8B8F930", VA = "0x188B90530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private struct OKIOBCAOMBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		public AsyncTaskMethodBuilder<HHALHAFODBO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		public JELNMBMFAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		public PJKBEIHEIIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		public MOMLBLNPBLC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <destroyAndRebuildObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private TaskAwaiter<HHALHAFODBO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x8B9DA90", Offset = "0x8B9CE90", VA = "0x188B9DA90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x8B9EA50", Offset = "0x8B9DE50", VA = "0x188B9EA50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[CompilerGenerated]
	private struct MCMPEOANACE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		public AsyncTaskMethodBuilder<HHALHAFODBO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		public JELNMBMFAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		public PJKBEIHEIIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		public MOMLBLNPBLC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		public NHDMGGKCHPC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private TaskAwaiter<HHALHAFODBO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x8B99E80", Offset = "0x8B99280", VA = "0x188B99E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x8B9AF90", Offset = "0x8B9A390", VA = "0x188B9AF90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200014D")]
	[CompilerGenerated]
	private struct GPELAFDHJCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		public AsyncTaskMethodBuilder<HHALHAFODBO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		public JELNMBMFAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		public HHALHAFODBO operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		public MOMLBLNPBLC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		public PJKBEIHEIIE deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private TaskAwaiter<HHALHAFODBO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x8B935F0", Offset = "0x8B929F0", VA = "0x188B935F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x8B93840", Offset = "0x8B92C40", VA = "0x188B93840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class LJMGGGGIABB
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
			public AsyncTaskMethodBuilder<HHALHAFODBO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400056F")]
			public LJMGGGGIABB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000570")]
			public CancellationToken mlToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000571")]
			private NEJBKFDPNPN <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000572")]
			private TaskAwaiter<HHALHAFODBO> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0x8BA05F0", Offset = "0x8B9F9F0", VA = "0x188BA05F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0x8BA0AC0", Offset = "0x8B9FEC0", VA = "0x188BA0AC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		public JELNMBMFAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		public HNCNGHCIBFK masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		public PJKBEIHEIIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		public NHDMGGKCHPC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		public MOMLBLNPBLC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		public HHALHAFODBO initialState;

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public LJMGGGGIABB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x8B989A0", Offset = "0x8B97DA0", VA = "0x188B989A0")]
		[AsyncStateMachine(typeof(<<MasterLockedPhaseChangeBlock>b__0>d))]
		internal Task<HHALHAFODBO> LGJJLIIIBGJ(CancellationToken mlToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000150")]
	[CompilerGenerated]
	private struct LCADDHPNAPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		public AsyncTaskMethodBuilder<HHALHAFODBO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		public JELNMBMFAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public HNCNGHCIBFK masterLockedCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public PJKBEIHEIIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public NHDMGGKCHPC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		public MOMLBLNPBLC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private TaskAwaiter<HHALHAFODBO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005C9")]
		[Cpp2IlInjected.Address(RVA = "0x8B97410", Offset = "0x8B96810", VA = "0x188B97410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CA")]
		[Cpp2IlInjected.Address(RVA = "0x8B97930", Offset = "0x8B96D30", VA = "0x188B97930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000151")]
	[CompilerGenerated]
	private struct LCLDGMIDEGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		public JELNMBMFAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000581")]
		public PJKBEIHEIIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000582")]
		public MOMLBLNPBLC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private HHALHAFODBO <legacyEndPhase>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private IEnumerator<HHALHAFODBO> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private TaskAwaiter<HHALHAFODBO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x8B979A0", Offset = "0x8B96DA0", VA = "0x188B979A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x8B97EF0", Offset = "0x8B972F0", VA = "0x188B97EF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000152")]
	[CompilerGenerated]
	private struct EFENFAKHKEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		public JELNMBMFAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		public PJKBEIHEIIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

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
		[Cpp2IlInjected.Address(RVA = "0x8B8EC70", Offset = "0x8B8E070", VA = "0x188B8EC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x8B8EF60", Offset = "0x8B8E360", VA = "0x188B8EF60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000153")]
	[CompilerGenerated]
	private struct AAGKMCFPFAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		public JELNMBMFAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		public PJKBEIHEIIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x8B89BB0", Offset = "0x8B88FB0", VA = "0x188B89BB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D0")]
		[Cpp2IlInjected.Address(RVA = "0x8B89DE0", Offset = "0x8B891E0", VA = "0x188B89DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000154")]
	[CompilerGenerated]
	private sealed class DPFAPBEMMLH
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
			public AsyncTaskMethodBuilder<HHALHAFODBO> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000599")]
			public DPFAPBEMMLH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400059A")]
			public PJKBEIHEIIE data;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400059B")]
			public MOMLBLNPBLC progressTracker;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400059C")]
			public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400059D")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400059E")]
			private TaskAwaiter<HHALHAFODBO> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400059F")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005A0")]
			private TaskAwaiter<HEKBAMHGADC> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x8BA0B30", Offset = "0x8B9FF30", VA = "0x188BA0B30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0x8BA15F0", Offset = "0x8BA09F0", VA = "0x188BA15F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		public JELNMBMFAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		public CMCGANNOGKF mainLoadService;

		[Cpp2IlInjected.Token(Token = "0x60005D1")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public DPFAPBEMMLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x8B8EB10", Offset = "0x8B8DF10", VA = "0x188B8EB10")]
		[AsyncStateMachine(typeof(<<RoomV2LoadLogic>b__0>d))]
		internal Task<HHALHAFODBO> ICCEDLMNPIA(PJKBEIHEIIE data, NHDMGGKCHPC _, MOMLBLNPBLC progressTracker, CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer, CancellationToken cancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000156")]
	[CompilerGenerated]
	private struct IBDDPHMMLBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		public JELNMBMFAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		public PJKBEIHEIIE phaseArgs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		public CancellationToken innerCancellation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		public MOMLBLNPBLC postDownloadProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private DPFAPBEMMLH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private NHDMGGKCHPC <timedYielder>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private TaskAwaiter<HHALHAFODBO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x8B944A0", Offset = "0x8B938A0", VA = "0x188B944A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x8B952F0", Offset = "0x8B946F0", VA = "0x188B952F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CompilerGenerated]
	private struct FIJHHKFHAHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		public JELNMBMFAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		public PJKBEIHEIIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x8B93110", Offset = "0x8B92510", VA = "0x188B93110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x8B93510", Offset = "0x8B92910", VA = "0x188B93510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CompilerGenerated]
	private struct CHEABONIAKP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		public AsyncTaskMethodBuilder<HHALHAFODBO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		public JELNMBMFAJB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		public PJKBEIHEIIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		public MOMLBLNPBLC progressTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <deserializeAllObjectsTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private TaskAwaiter<HHALHAFODBO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x8B8D510", Offset = "0x8B8C910", VA = "0x188B8D510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x8B8DB30", Offset = "0x8B8CF30", VA = "0x188B8DB30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40004E6")]
	private readonly ACAHCPOBLDI ANCIFJLIEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40004E7")]
	private readonly ACAHCPOBLDI KIMJMKGFGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40004E8")]
	private readonly EOLAJDKNPJP CDNGDNLHLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40004E9")]
	private readonly EEGFNEJKBGP DBBJFMDKEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40004EA")]
	private readonly HPJBBHOLPMJ GPFHCEGCNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40004EB")]
	private ProfilerCounterValue<int> NPOCJPHKDKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40004EC")]
	private readonly JIIIHNJCLKF MPCNELMOGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40004ED")]
	private readonly NOFPNMHOLJE NFIHGODFMOO;

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private JNGEBJCPLIA BEBMHIJNKBL
	{
		[Cpp2IlInjected.Token(Token = "0x600057B")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C960", Offset = "0x8B7BD60", VA = "0x188B7C960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400001B")]
	public event NBADGDDEIDG IEONFJOOMBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000579")]
		[Cpp2IlInjected.Address(RVA = "0x8B7D070", Offset = "0x8B7C470", VA = "0x188B7D070", Slot = "4")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600057A")]
		[Cpp2IlInjected.Address(RVA = "0x8B7E200", Offset = "0x8B7D600", VA = "0x188B7E200", Slot = "5")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0x8B7E3C0", Offset = "0x8B7D7C0", VA = "0x188B7E3C0")]
	public JELNMBMFAJB(NFGCOFFCAHB PJGCMFIFJNB, NOFPNMHOLJE NFIHGODFMOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0x8B7D700", Offset = "0x8B7CB00", VA = "0x188B7D700")]
	[AsyncStateMachine(typeof(EPCHEDCBDAA))]
	public Task KPPPBAECAKA(BGMNPHKELEH IDLJGJGIGEG, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0x8B7DAF0", Offset = "0x8B7CEF0", VA = "0x188B7DAF0")]
	[AsyncStateMachine(typeof(BCNDBGBHPNE))]
	private Task<HNBAHPJPPAI> MFMFOBLFGHI(BGMNPHKELEH IDLJGJGIGEG, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0x8B7D1C0", Offset = "0x8B7C5C0", VA = "0x188B7D1C0")]
	[AsyncStateMachine(typeof(LEAJOMNJAOO))]
	private Task HCNIIBEEKIG(BGMNPHKELEH IDLJGJGIGEG, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0x8B7E0A0", Offset = "0x8B7D4A0", VA = "0x188B7E0A0")]
	[AsyncStateMachine(typeof(EGAMEFECJNM))]
	private Task OKDMODAODFI(BGMNPHKELEH IDLJGJGIGEG, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken LLFFMNBGPHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0x8B7CB80", Offset = "0x8B7BF80", VA = "0x188B7CB80")]
	[AsyncStateMachine(typeof(JLGDJHNNDLB))]
	private Task CBJEOKNGEKC(PJKBEIHEIIE PCEACAPBPFE, MOMLBLNPBLC HPIJBDBDIPO, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken IABAIKGAOFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0x8B7CE00", Offset = "0x8B7C200", VA = "0x188B7CE00")]
	[AsyncStateMachine(typeof(MHIEBMNDDCK))]
	private Task EGKCNLMGGKE(CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0x8B7D430", Offset = "0x8B7C830", VA = "0x188B7D430")]
	[AsyncStateMachine(typeof(EGLEICGKBAH))]
	private Task JACEGAGGNMM(PJKBEIHEIIE NGIAGNLBILI, MOMLBLNPBLC AMFBNPOGHAA, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0x8B7C800", Offset = "0x8B7BC00", VA = "0x188B7C800")]
	[AsyncStateMachine(typeof(OKIOBCAOMBA))]
	private Task<HHALHAFODBO> AFDEBOAIAPM(PJKBEIHEIIE NGIAGNLBILI, NHDMGGKCHPC IPBEDMLGBIB, MOMLBLNPBLC AMFBNPOGHAA, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0x8B7D580", Offset = "0x8B7C980", VA = "0x188B7D580")]
	[AsyncStateMachine(typeof(MCMPEOANACE))]
	private Task<HHALHAFODBO> JDDBNPCCBDE(PJKBEIHEIIE NGIAGNLBILI, NHDMGGKCHPC IPBEDMLGBIB, MOMLBLNPBLC AMFBNPOGHAA, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0x8B7D850", Offset = "0x8B7CC50", VA = "0x188B7D850")]
	[AsyncStateMachine(typeof(GPELAFDHJCL))]
	private Task<HHALHAFODBO> MCJPILHPFFO(HHALHAFODBO LNIPIHKBBJE, PJKBEIHEIIE EOJHGNPAAAI, MOMLBLNPBLC AMFBNPOGHAA, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ, bool DHPLJIIIHEP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0x8B7CCF0", Offset = "0x8B7C0F0", VA = "0x188B7CCF0")]
	private bool COHIJFAGBBF(PJKBEIHEIIE PCEACAPBPFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0x8B7DC50", Offset = "0x8B7D050", VA = "0x188B7DC50")]
	[AsyncStateMachine(typeof(LCADDHPNAPN))]
	protected Task<HHALHAFODBO> MLGLAPCAPFM(PJKBEIHEIIE NGIAGNLBILI, NHDMGGKCHPC IPBEDMLGBIB, MOMLBLNPBLC AMFBNPOGHAA, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ, HNCNGHCIBFK HLKMLIMCLNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0x8B7DDE0", Offset = "0x8B7D1E0", VA = "0x188B7DDE0")]
	[AsyncStateMachine(typeof(LCLDGMIDEGA))]
	private Task NKPBALIDEBP(PJKBEIHEIIE NGIAGNLBILI, MOMLBLNPBLC AMFBNPOGHAA, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x8B7E220", Offset = "0x8B7D620", VA = "0x188B7E220")]
	private void POPMIIEFBPG(HHALHAFODBO CLBGLGPKLNN, MOMLBLNPBLC AMFBNPOGHAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x8B7D300", Offset = "0x8B7C700", VA = "0x188B7D300")]
	private void HDPNEDCADGG(HHALHAFODBO EKDLPOPJBIK, [Out] HHALHAFODBO AHBHFNMAPEC, [Out] HHALHAFODBO BFDJHHJOOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x8B7D340", Offset = "0x8B7C740", VA = "0x188B7D340")]
	private Task<FNBLNBOMKEN> HNHBINJALAB(BGMNPHKELEH IDLJGJGIGEG, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x8B7D090", Offset = "0x8B7C490", VA = "0x188B7D090")]
	private Task<PJKBEIHEIIE> FAFKLCIHGDG(FNBLNBOMKEN NGIAGNLBILI, HIGDFOFBOPO.DABADIHPCNE HMNIKNLJBKD, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x8B7E270", Offset = "0x8B7D670", VA = "0x188B7E270")]
	[AsyncStateMachine(typeof(EFENFAKHKEG))]
	private Task PPLFLAMHHFJ(PJKBEIHEIIE NGIAGNLBILI, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ, bool GJMGODMPJKM = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x8B7D0D0", Offset = "0x8B7C4D0", VA = "0x188B7D0D0")]
	[AsyncStateMachine(typeof(AAGKMCFPFAH))]
	private Task GALGDCONNGO(PJKBEIHEIIE NGIAGNLBILI, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0x8B7D3A0", Offset = "0x8B7C7A0", VA = "0x188B7D3A0")]
	private Task IHFHJALLPIA(PJKBEIHEIIE NGIAGNLBILI, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x8B7E1E0", Offset = "0x8B7D5E0", VA = "0x188B7E1E0")]
	private Task OMALFLPEJOI(PJKBEIHEIIE NGIAGNLBILI, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x8B7CDE0", Offset = "0x8B7C1E0", VA = "0x188B7CDE0")]
	private Task DIPLILHBNNP(PJKBEIHEIIE NGIAGNLBILI, NHDMGGKCHPC IPBEDMLGBIB, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x8B7D380", Offset = "0x8B7C780", VA = "0x188B7D380")]
	private Task HPPFBLIALNO(PJKBEIHEIIE NGIAGNLBILI, NHDMGGKCHPC IPBEDMLGBIB, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x8B7D420", Offset = "0x8B7C820", VA = "0x188B7D420")]
	private static Task IMBEONFLDBN(CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0x8B7E080", Offset = "0x8B7D480", VA = "0x188B7E080")]
	private Task OJIOHNHLBPD(PJKBEIHEIIE NGIAGNLBILI, NHDMGGKCHPC IPBEDMLGBIB, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x8B7CCD0", Offset = "0x8B7C0D0", VA = "0x188B7CCD0")]
	private Task CFCLGEDJDHP(PJKBEIHEIIE NGIAGNLBILI, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0x8B7D3D0", Offset = "0x8B7C7D0", VA = "0x188B7D3D0")]
	private void IICDNEMAIGB(BGMNPHKELEH IDLJGJGIGEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0x8B7C990", Offset = "0x8B7BD90", VA = "0x188B7C990")]
	public void BBFAAEDMOFL(long DAKBFKLMPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	private static void OEICFIHCPDG(MBLNIACGJFP MOJKGMPPOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0x8B7DF30", Offset = "0x8B7D330", VA = "0x188B7DF30")]
	[AsyncStateMachine(typeof(IBDDPHMMLBM))]
	private Task OILFFIKDOLH(PJKBEIHEIIE PCEACAPBPFE, MOMLBLNPBLC HPIJBDBDIPO, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken IABAIKGAOFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0x8B7CA40", Offset = "0x8B7BE40", VA = "0x188B7CA40")]
	[AsyncStateMachine(typeof(FIJHHKFHAHL))]
	private Task BNEEIKAOHAG(PJKBEIHEIIE NGIAGNLBILI, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0x8B7D9D0", Offset = "0x8B7CDD0", VA = "0x188B7D9D0")]
	private static DAKCGOEDMGE MFEFAIGIGFP(PJKBEIHEIIE EOJHGNPAAAI)
	{
		return default(DAKCGOEDMGE);
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0x8B7CF10", Offset = "0x8B7C310", VA = "0x188B7CF10")]
	[AsyncStateMachine(typeof(CHEABONIAKP))]
	private Task<HHALHAFODBO> EHMBCKPNBHF(PJKBEIHEIIE NGIAGNLBILI, NHDMGGKCHPC IPBEDMLGBIB, MOMLBLNPBLC AMFBNPOGHAA, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	private void ECJCGPPAJKE(HHALHAFODBO GFHFBCFGNON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal struct JMMIMELLMLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005BD")]
	private JNGEBJCPLIA IDEPICHODDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005BE")]
	private PJKBEIHEIIE NGIAGNLBILI;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private IJIEICICPPB JDGMIPEIBAC
	{
		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x8B96D70", Offset = "0x8B96170", VA = "0x188B96D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0x8B96C90", Offset = "0x8B96090", VA = "0x188B96C90")]
	public static Task COBMPGJIBLC(JNGEBJCPLIA IDEPICHODDC, PJKBEIHEIIE NGIAGNLBILI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0x8B96A80", Offset = "0x8B95E80", VA = "0x188B96A80")]
	private void COBMPGJIBLC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015A")]
internal struct NBONIDJNAOP
{
	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0x8B9BE80", Offset = "0x8B9B280", VA = "0x188B9BE80")]
	public static Task COBMPGJIBLC(CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015B")]
internal struct PMNIOKJCDFL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015C")]
	[CompilerGenerated]
	private struct HHALIICIAJG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		public NFGCOFFCAHB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		public PJKBEIHEIIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005C5")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C6")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <outboundTrafficTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x8B93B80", Offset = "0x8B92F80", VA = "0x188B93B80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x8B940B0", Offset = "0x8B934B0", VA = "0x188B940B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0x8B9EAC0", Offset = "0x8B9DEC0", VA = "0x188B9EAC0")]
	[AsyncStateMachine(typeof(HHALIICIAJG))]
	public static Task COBMPGJIBLC(NFGCOFFCAHB PJGCMFIFJNB, PJKBEIHEIIE NGIAGNLBILI, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200015D")]
internal struct APEGCLKACFD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200015E")]
	[CompilerGenerated]
	private struct LMNOCGMABPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		public NFGCOFFCAHB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		public PJKBEIHEIIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		public NHDMGGKCHPC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private JNGEBJCPLIA <roomManager>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private IJIEICICPPB <callbacks>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private HHALHAFODBO <operationState>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private bool <isMaster>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private NEJBKFDPNPN <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private IDisposable <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		private List<(PersistenceView, MGLJJACBNLF)>.Enumerator <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private PersistenceView <view>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private MGLJJACBNLF <viewData>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x8B99140", Offset = "0x8B98540", VA = "0x188B99140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x8B99E20", Offset = "0x8B99220", VA = "0x188B99E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0x8B8A3D0", Offset = "0x8B897D0", VA = "0x188B8A3D0")]
	[AsyncStateMachine(typeof(LMNOCGMABPD))]
	public static Task COBMPGJIBLC(NFGCOFFCAHB PJGCMFIFJNB, PJKBEIHEIIE NGIAGNLBILI, NHDMGGKCHPC IPBEDMLGBIB, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0x8B8A1D0", Offset = "0x8B895D0", VA = "0x188B8A1D0")]
	private static void CEMDIAEBEEP(PersistenceView BPHIDAEMDAO, MGLJJACBNLF EGAMMPAFFJK, PJKBEIHEIIE NGIAGNLBILI, HHALHAFODBO LNIPIHKBBJE, bool DKMPDCECDLC)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000160")]
internal struct JNCOBLFFKJF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000161")]
	[CompilerGenerated]
	private struct LLMMIANPOHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		public JNGEBJCPLIA roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		public PJKBEIHEIIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private NEJBKFDPNPN <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005EA")]
		[Cpp2IlInjected.Address(RVA = "0x8B98AC0", Offset = "0x8B97EC0", VA = "0x188B98AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EB")]
		[Cpp2IlInjected.Address(RVA = "0x8B990E0", Offset = "0x8B984E0", VA = "0x188B990E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0x8B96DC0", Offset = "0x8B961C0", VA = "0x188B96DC0")]
	[AsyncStateMachine(typeof(LLMMIANPOHF))]
	public static Task COBMPGJIBLC(JNGEBJCPLIA IDEPICHODDC, PJKBEIHEIIE NGIAGNLBILI, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000162")]
internal struct BEMCCCBIEEM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000163")]
	[CompilerGenerated]
	private struct NGMEMHLPEAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		public JNGEBJCPLIA roomManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public PJKBEIHEIIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public NFGCOFFCAHB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public bool useCompletionMark;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BF60", Offset = "0x8B9B360", VA = "0x188B9BF60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x8B9C170", Offset = "0x8B9B570", VA = "0x188B9C170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000164")]
	[CompilerGenerated]
	private sealed class OEBPFLNMHIC
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
			public CIIMOEPMPCG<string>.MOMGGNPHIKH timer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005F4")]
			public CancellationToken token;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005F5")]
			public OEBPFLNMHIC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005F6")]
			private CIIMOEPMPCG<string>.MOMGGNPHIKH <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005F7")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005F7")]
			[Cpp2IlInjected.Address(RVA = "0x8BA1660", Offset = "0x8BA0A60", VA = "0x188BA1660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005F8")]
			[Cpp2IlInjected.Address(RVA = "0x8BA19F0", Offset = "0x8BA0DF0", VA = "0x188BA19F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		public Task destroyAllTask;

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public OEBPFLNMHIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x8B9D490", Offset = "0x8B9C890", VA = "0x188B9D490")]
		[AsyncStateMachine(typeof(<<Run>b__0>d))]
		internal Task AOLCBBCGOLI(CIIMOEPMPCG<string>.MOMGGNPHIKH timer, CancellationToken token)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000166")]
	[CompilerGenerated]
	private struct OAJBFBEBMCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		public BEMCCCBIEEM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private NEJBKFDPNPN <_>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		private TaskAwaiter<HNBAHPJPPAI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x8B9C820", Offset = "0x8B9BC20", VA = "0x188B9C820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x8B9D430", Offset = "0x8B9C830", VA = "0x188B9D430", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000167")]
	[CompilerGenerated]
	private sealed class NNJAONLHKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		public ICHMBANNAMC version;

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
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public NNJAONLHKPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x8B9C1D0", Offset = "0x8B9B5D0", VA = "0x188B9C1D0")]
		internal object IKGNAPPNCCO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x8B9C2B0", Offset = "0x8B9B6B0", VA = "0x188B9C2B0")]
		internal object OBFGODOODPL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40005E2")]
	private JNGEBJCPLIA IDEPICHODDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40005E3")]
	private PJKBEIHEIIE NGIAGNLBILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40005E4")]
	private NFGCOFFCAHB PJGCMFIFJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40005E5")]
	private bool GJMGODMPJKM;

	[Cpp2IlInjected.Token(Token = "0x40005E6")]
	private static readonly ByteString IHKMEIMALLA;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private IJIEICICPPB JDGMIPEIBAC
	{
		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x8B8BD60", Offset = "0x8B8B160", VA = "0x188B8BD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	private CJGDJMIKAIC MJABACAOHLE
	{
		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x8B8B220", Offset = "0x8B8A620", VA = "0x188B8B220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0x8B8B2C0", Offset = "0x8B8A6C0", VA = "0x188B8B2C0")]
	[AsyncStateMachine(typeof(NGMEMHLPEAD))]
	public static Task COBMPGJIBLC(JNGEBJCPLIA IDEPICHODDC, PJKBEIHEIIE NGIAGNLBILI, NFGCOFFCAHB PJGCMFIFJNB, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ, bool GJMGODMPJKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0x8B8B410", Offset = "0x8B8A810", VA = "0x188B8B410")]
	[AsyncStateMachine(typeof(OAJBFBEBMCE))]
	private Task COBMPGJIBLC(CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0x8B8B540", Offset = "0x8B8A940", VA = "0x188B8B540")]
	private void IFNNJKABOIA([NotNull] LCCHGCBPFIP DLNHHMNONFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0x8B8BD20", Offset = "0x8B8B120", VA = "0x188B8BD20")]
	private bool KFPHGEOIIOK(ICHMBANNAMC CDBBOGJDAGP, LCCHGCBPFIP DLNHHMNONFG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal struct BFDKOBCNPLG
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000169")]
	[CompilerGenerated]
	private struct BFKHAEKIFDD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		public AsyncTaskMethodBuilder<PJKBEIHEIIE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		public BFDKOBCNPLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		public HIGDFOFBOPO.DABADIHPCNE downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <downloadTimerScope>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		private TaskAwaiter<IReadOnlyCollection<NCDNOPDHNPA>> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		private TaskAwaiter<(DGHPMJAIBNO<PKPKOGNMCPP, KIBOPIAKFMB>, DGHPMJAIBNO<DAENPLLCOHN<LCCHGCBPFIP>, KIBOPIAKFMB>, DGHPMJAIBNO<DAENPLLCOHN<MNNMLCEECEP>, KIBOPIAKFMB>, DGHPMJAIBNO<DAENPLLCOHN<IEnumerable<ACJJNNKGIPF>>, KIBOPIAKFMB>, DGHPMJAIBNO<DAENPLLCOHN<GFFFBNOEAPJ>, KIBOPIAKFMB>)> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x8B8C6C0", Offset = "0x8B8BAC0", VA = "0x188B8C6C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x8B8D4A0", Offset = "0x8B8C8A0", VA = "0x188B8D4A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016A")]
	[CompilerGenerated]
	private struct EHLJLKIACLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		public AsyncTaskMethodBuilder<DGHPMJAIBNO<PKPKOGNMCPP, KIBOPIAKFMB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH downloadTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public BFDKOBCNPLG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		public IReadOnlyCollection<NCDNOPDHNPA> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		public IReadOnlyCollection<NCDNOPDHNPA> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		public long? roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		public long? subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		public HIGDFOFBOPO.DABADIHPCNE downloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		private TaskAwaiter<DGHPMJAIBNO<PKPKOGNMCPP, KIBOPIAKFMB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x8B90590", Offset = "0x8B8F990", VA = "0x188B90590", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x8B90BF0", Offset = "0x8B8FFF0", VA = "0x188B90BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000607")]
	private DPLHFNHOBFF<APAGCNALJKL, MNNMLCEECEP> MIKDPGPOFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000608")]
	private DPLHFNHOBFF<APAGCNALJKL, LCCHGCBPFIP> NHAEIGIANLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000609")]
	private DPLHFNHOBFF<GJNECDDAEBM, IEnumerable<ACJJNNKGIPF>> BDNAACAGIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400060A")]
	private DPLHFNHOBFF<long, GFFFBNOEAPJ> GBDAHLJBFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400060B")]
	private AGJEILLLEMO FOIPAHFAINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400060C")]
	private MBLNIACGJFP MOJKGMPPOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400060D")]
	private EOHPFFLACLH HOKAHLLJNIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400060E")]
	private Guid? GCDGOJIGOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400060F")]
	private IReadOnlyCollection<NCDNOPDHNPA> MBBBOJDGOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000610")]
	private Task<IReadOnlyCollection<NCDNOPDHNPA>> HNGJHKFELMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000611")]
	private APAGCNALJKL PNHJPDOBEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000612")]
	private APAGCNALJKL IAOLPELEMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000613")]
	private APAGCNALJKL? LIFPLFIEEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000614")]
	private GJNECDDAEBM FANLGPHJHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000615")]
	private CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN;

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0x8B8C220", Offset = "0x8B8B620", VA = "0x188B8C220")]
	public static Task<PJKBEIHEIIE> LNPIJLGMJAI(JNGEBJCPLIA IDEPICHODDC, [In] FNBLNBOMKEN NGIAGNLBILI, HIGDFOFBOPO.DABADIHPCNE HMNIKNLJBKD, CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0x8B8BE40", Offset = "0x8B8B240", VA = "0x188B8BE40")]
	[AsyncStateMachine(typeof(BFKHAEKIFDD))]
	private Task<PJKBEIHEIIE> COBMPGJIBLC(HIGDFOFBOPO.DABADIHPCNE HMNIKNLJBKD, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0x8B8BFF0", Offset = "0x8B8B3F0", VA = "0x188B8BFF0")]
	[AsyncStateMachine(typeof(EHLJLKIACLM))]
	private Task<DGHPMJAIBNO<PKPKOGNMCPP, KIBOPIAKFMB>> KENNFIMBDJK(Guid? GCDGOJIGOMN, IReadOnlyCollection<NCDNOPDHNPA> MBBBOJDGOAD, IReadOnlyCollection<NCDNOPDHNPA> LOMDMIGODGN, long? DCONEHIDLCB, long? OBCIDCBDAAN, HIGDFOFBOPO.DABADIHPCNE HMNIKNLJBKD, CIIMOEPMPCG<string>.MOMGGNPHIKH FAKEGGIAHBA, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
internal struct CMKCJHOJNAJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016C")]
	[CompilerGenerated]
	private struct NPCEENECKBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		public AsyncTaskMethodBuilder<FNBLNBOMKEN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		public CMKCJHOJNAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <subTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private TaskAwaiter<FNBLNBOMKEN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x8B9C360", Offset = "0x8B9B760", VA = "0x188B9C360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x8B9C7B0", Offset = "0x8B9BBB0", VA = "0x188B9C7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200016D")]
	[CompilerGenerated]
	private struct JKJHDOGKOCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		public AsyncTaskMethodBuilder<FNBLNBOMKEN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		public CMKCJHOJNAJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		private TaskAwaiter<FNBLNBOMKEN> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x8B956D0", Offset = "0x8B94AD0", VA = "0x188B956D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x8B95B50", Offset = "0x8B94F50", VA = "0x188B95B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200016E")]
	[CompilerGenerated]
	private sealed class HAODFJNIOHD
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
			public HAODFJNIOHD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000655")]
			private CIIMOEPMPCG<string>.MOMGGNPHIKH <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000656")]
			private TaskAwaiter<GELNHKAAEAP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000657")]
			private TaskAwaiter<EILAOANGAEC> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x8B9EC00", Offset = "0x8B9E000", VA = "0x188B9EC00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0x8B9F5A0", Offset = "0x8B9E9A0", VA = "0x188B9F5A0", Slot = "5")]
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
		public JPLOJOIMKCI roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		public IJIEICICPPB callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		public Guid? unityAssetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		public APAGCNALJKL superRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		public APAGCNALJKL subRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		public long subRoomDataSaveId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400064D")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400064E")]
		public IReadOnlyList<NCDNOPDHNPA> unitySubAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		public IReadOnlyList<NCDNOPDHNPA> referencedUnityAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		public Guid roomAssetsSnapshotId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		public MBLNIACGJFP roomDetails;

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public HAODFJNIOHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0xFB8DA0", Offset = "0xFB81A0", VA = "0x180FB8DA0")]
		internal bool ONLFPLIPNJE(EOHPFFLACLH sr)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x8B938B0", Offset = "0x8B92CB0", VA = "0x188B938B0")]
		[AsyncStateMachine(typeof(<<FetchRoomLoadDetails>g__getRoomSaveData|0>d))]
		internal Task CNIICPLBIEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x8B93980", Offset = "0x8B92D80", VA = "0x188B93980")]
		internal Task<GJNECDDAEBM> MCGLAHLEPCJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000170")]
	[CompilerGenerated]
	private struct FIGBNIHFMOA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		public AsyncTaskMethodBuilder<FNBLNBOMKEN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		public JPLOJOIMKCI roomLoadDataProviderOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		public IJIEICICPPB callbacks;

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
		public APAGCNALJKL superRoomBlobName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private HAODFJNIOHD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private EOHPFFLACLH <subroom>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private Task<GJNECDDAEBM> <getRoomLoadDTOTask>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private TaskAwaiter<MBLNIACGJFP> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private TaskAwaiter<GJNECDDAEBM> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x8B920F0", Offset = "0x8B914F0", VA = "0x188B920F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x8B930A0", Offset = "0x8B924A0", VA = "0x188B930A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400062D")]
	private IJIEICICPPB LHIJBEJLBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400062E")]
	private EOLAJDKNPJP CDNGDNLHLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400062F")]
	private JPLOJOIMKCI BBCMJDBCPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000630")]
	private CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000631")]
	private long DCONEHIDLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000632")]
	private long JLNBCNHEKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000633")]
	private long DEMDBAHMNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000634")]
	private string CKLCBBHHKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000635")]
	private APAGCNALJKL ODMDJNFCDKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000636")]
	private Guid POIJCCGACHM;

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0x8B8E060", Offset = "0x8B8D460", VA = "0x188B8E060")]
	public static Task<FNBLNBOMKEN> LNPIJLGMJAI(JNGEBJCPLIA IDEPICHODDC, BGMNPHKELEH IDLJGJGIGEG, CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0x8B8DBA0", Offset = "0x8B8CFA0", VA = "0x188B8DBA0")]
	[AsyncStateMachine(typeof(NPCEENECKBI))]
	private Task<FNBLNBOMKEN> COBMPGJIBLC(CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x8B8DEF0", Offset = "0x8B8D2F0", VA = "0x188B8DEF0")]
	[AsyncStateMachine(typeof(JKJHDOGKOCH))]
	private Task<FNBLNBOMKEN> HNHBINJALAB(CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x8B8DD20", Offset = "0x8B8D120", VA = "0x188B8DD20")]
	[AsyncStateMachine(typeof(FIGBNIHFMOA))]
	private static Task<FNBLNBOMKEN> HNHBINJALAB(IJIEICICPPB LHIJBEJLBFF, JPLOJOIMKCI BBCMJDBCPNP, long DCONEHIDLCB, long JLNBCNHEKAJ, long DEMDBAHMNFM, string CKLCBBHHKPN, APAGCNALJKL ODMDJNFCDKP, Guid POIJCCGACHM, CancellationToken GMKBGHHNCDJ, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x8B8DCF0", Offset = "0x8B8D0F0", VA = "0x188B8DCF0")]
	private void FIBLKGFFJEH(MBLNIACGJFP MOJKGMPPOOM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
internal struct MJHLLOCAMNH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000172")]
	[CompilerGenerated]
	private struct COJOLFBBHBN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		public MJHLLOCAMNH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		private float <nextResendTime>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600061C")]
		[Cpp2IlInjected.Address(RVA = "0x8B8E2B0", Offset = "0x8B8D6B0", VA = "0x188B8E2B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x8B8E840", Offset = "0x8B8DC40", VA = "0x188B8E840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400066B")]
	private IJIEICICPPB LHIJBEJLBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400066C")]
	private PJKBEIHEIIE NGIAGNLBILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400066D")]
	private CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400066E")]
	private float MEEEHBKFEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400066F")]
	private float ODCNDNEAGNA;

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0x8B9BB80", Offset = "0x8B9AF80", VA = "0x188B9BB80")]
	public static Task MDMMCDOMCJA(JNGEBJCPLIA IDEPICHODDC, PJKBEIHEIIE NGIAGNLBILI, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0x8B9B9A0", Offset = "0x8B9ADA0", VA = "0x188B9B9A0")]
	[AsyncStateMachine(typeof(COJOLFBBHBN))]
	public Task COBMPGJIBLC(CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x8B9BD20", Offset = "0x8B9B120", VA = "0x188B9BD20")]
	private static void NPBHFCAIEKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x8B9B840", Offset = "0x8B9AC40", VA = "0x188B9B840")]
	private void AICIGMGFLEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x8B9BAC0", Offset = "0x8B9AEC0", VA = "0x188B9BAC0")]
	private static float EELCMFJEILD(IJIEICICPPB LHIJBEJLBFF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x8B9BE60", Offset = "0x8B9B260", VA = "0x188B9BE60")]
	private static float OBJMPMOMJLM()
	{
		return default(float);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000174")]
internal struct DCKJDGNIDNM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000175")]
	[CompilerGenerated]
	private struct BBKBIELNNCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public NFGCOFFCAHB operationContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public PJKBEIHEIIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private KKGNFEOCIOB <operation>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private JNGEBJCPLIA <roomManager>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private FBALAFFDJOO.BPDKIKNKJGO <instantiations>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		private TaskAwaiter<HNBAHPJPPAI> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x8B8A520", Offset = "0x8B89920", VA = "0x188B8A520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x8B8AD20", Offset = "0x8B8A120", VA = "0x188B8AD20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000176")]
	[CompilerGenerated]
	private struct AEDBGFPNDPD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x8B89E40", Offset = "0x8B89240", VA = "0x188B89E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x8B8A170", Offset = "0x8B89570", VA = "0x188B8A170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x8B8E960", Offset = "0x8B8DD60", VA = "0x188B8E960")]
	[AsyncStateMachine(typeof(BBKBIELNNCF))]
	public static Task COBMPGJIBLC(NFGCOFFCAHB PJGCMFIFJNB, PJKBEIHEIIE NGIAGNLBILI, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x8B8EAA0", Offset = "0x8B8DEA0", VA = "0x188B8EAA0")]
	private static Task<HNBAHPJPPAI> IDLKGFICIKF(NFGCOFFCAHB PJGCMFIFJNB, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x8B8E8A0", Offset = "0x8B8DCA0", VA = "0x188B8E8A0")]
	[AsyncStateMachine(typeof(AEDBGFPNDPD))]
	private static Task AGDCPPPEBKL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
internal struct JPAHDLBNJLE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000178")]
	[CompilerGenerated]
	private struct EPHLGPGACFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		public JPAHDLBNJLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600062D")]
		[Cpp2IlInjected.Address(RVA = "0x8B91400", Offset = "0x8B90800", VA = "0x188B91400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062E")]
		[Cpp2IlInjected.Address(RVA = "0x8B91B90", Offset = "0x8B90F90", VA = "0x188B91B90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000179")]
	[CompilerGenerated]
	private sealed class FLOAHOMOANM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public FLOAHOMOANM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x8B93570", Offset = "0x8B92970", VA = "0x188B93570")]
		internal object KDANAANGHKP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017A")]
	[CompilerGenerated]
	private struct OIGHJKMIEMF : IAsyncStateMachine
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
		public JPAHDLBNJLE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x8B9D5B0", Offset = "0x8B9C9B0", VA = "0x188B9D5B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000632")]
		[Cpp2IlInjected.Address(RVA = "0x8B9DA30", Offset = "0x8B9CE30", VA = "0x188B9DA30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400068A")]
	private bool JPJHNJGIMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400068B")]
	private CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400068C")]
	private JNGEBJCPLIA IDEPICHODDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400068D")]
	private CancellationToken GMKBGHHNCDJ;

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x8B96FD0", Offset = "0x8B963D0", VA = "0x188B96FD0")]
	public static Task DEKJHHAEKJL(JNGEBJCPLIA IDEPICHODDC, bool JPJHNJGIMMH, CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN, CancellationToken KCJNNEDMKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x8B96EE0", Offset = "0x8B962E0", VA = "0x188B96EE0")]
	[AsyncStateMachine(typeof(EPHLGPGACFP))]
	private Task COBMPGJIBLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x8B97040", Offset = "0x8B96440", VA = "0x188B97040")]
	[AsyncStateMachine(typeof(OIGHJKMIEMF))]
	private Task IEKHECCKAAP(bool HLKMKJFACNJ, string CGAJOJLBJOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810")]
	private bool CBPHGEKNDAM(bool JPJHNJGIMMH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
internal struct KMMFEAEEINK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017C")]
	[CompilerGenerated]
	private struct LEDJDDOOKLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006A2")]
		public KMMFEAEEINK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006A3")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x8B98470", Offset = "0x8B97870", VA = "0x188B98470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000637")]
		[Cpp2IlInjected.Address(RVA = "0x8B98930", Offset = "0x8B97D30", VA = "0x188B98930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200017D")]
	[CompilerGenerated]
	private sealed class IPBALFFJECJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		public string sceneName;

		[Cpp2IlInjected.Token(Token = "0x6000638")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public IPBALFFJECJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x8B95680", Offset = "0x8B94A80", VA = "0x188B95680")]
		internal object KDANAANGHKP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200017E")]
	[CompilerGenerated]
	private struct FGAACFHFGFA : IAsyncStateMachine
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
		public KMMFEAEEINK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x8B91BF0", Offset = "0x8B90FF0", VA = "0x188B91BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x8B92080", Offset = "0x8B91480", VA = "0x188B92080", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400069D")]
	private BEJBGPBLLEF GFGOMPGLFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400069E")]
	private CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400069F")]
	private JNGEBJCPLIA IDEPICHODDC;

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x8B97170", Offset = "0x8B96570", VA = "0x188B97170")]
	public static Task<Scene> AAMHBFAOEBL(JNGEBJCPLIA IDEPICHODDC, BEJBGPBLLEF LDHOJNPPDLC, CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x8B971C0", Offset = "0x8B965C0", VA = "0x188B971C0")]
	[AsyncStateMachine(typeof(LEDJDDOOKLO))]
	private Task<Scene> COBMPGJIBLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0x8B972D0", Offset = "0x8B966D0", VA = "0x188B972D0")]
	[AsyncStateMachine(typeof(FGAACFHFGFA))]
	private Task<Scene> IEKHECCKAAP(string CGAJOJLBJOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
internal struct HPJBBHOLPMJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000180")]
	[CompilerGenerated]
	private struct AADCFDDFPPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		public AsyncTaskMethodBuilder<HHALHAFODBO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		public HPJBBHOLPMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		public HHALHAFODBO nextPhase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public bool skipHandlers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		public PJKBEIHEIIE deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <moveToPhaseTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private Guid <handlersGuid>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private TaskAwaiter<HHALHAFODBO> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x8BA1F30", Offset = "0x8BA1330", VA = "0x188BA1F30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x8BA29D0", Offset = "0x8BA1DD0", VA = "0x188BA29D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000181")]
	[CompilerGenerated]
	private struct HLFLBEALEHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		public AsyncTaskMethodBuilder<HHALHAFODBO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		public HPJBBHOLPMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006BE")]
		public HHALHAFODBO state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private TaskAwaiter<HNBAHPJPPAI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000644")]
		[Cpp2IlInjected.Address(RVA = "0x8BACF00", Offset = "0x8BAC300", VA = "0x188BACF00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000645")]
		[Cpp2IlInjected.Address(RVA = "0x8BAD1E0", Offset = "0x8BAC5E0", VA = "0x188BAD1E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006AC")]
	private readonly NFGCOFFCAHB PJGCMFIFJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006AD")]
	private readonly EOLAJDKNPJP CDNGDNLHLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006AE")]
	private readonly EEGFNEJKBGP DBBJFMDKEMA;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	private KKGNFEOCIOB LHGELCIPFOO
	{
		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0x6F42BE0", Offset = "0x6F41FE0", VA = "0x186F42BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0x8B94440", Offset = "0x8B93840", VA = "0x188B94440")]
	public HPJBBHOLPMJ(NFGCOFFCAHB PJGCMFIFJNB, EOLAJDKNPJP CDNGDNLHLDP, EEGFNEJKBGP DBBJFMDKEMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0x8B94110", Offset = "0x8B93510", VA = "0x188B94110")]
	[AsyncStateMachine(typeof(AADCFDDFPPP))]
	public Task<HHALHAFODBO> AIAMIANLIEM(HHALHAFODBO KIANBKBEOFF, PJKBEIHEIIE EOJHGNPAAAI, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ, bool DHPLJIIIHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0x8B94290", Offset = "0x8B93690", VA = "0x188B94290")]
	[AsyncStateMachine(typeof(HLFLBEALEHC))]
	private Task<HHALHAFODBO> DONJPMFNBCG(CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, HHALHAFODBO JPDKKKJJNLC, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0x8B943F0", Offset = "0x8B937F0", VA = "0x188B943F0")]
	private bool FHAJAJHOJCN(HHALHAFODBO HPGCLEOOJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0x8B94420", Offset = "0x8B93820", VA = "0x188B94420")]
	private void GJFBEGANDPI(string KMNBOEKAFCD)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000182")]
internal struct IIIOMHEEEBH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000183")]
	[CompilerGenerated]
	private struct BJBEMFDOLHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		public KKGNFEOCIOB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		public PJKBEIHEIIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		public NHDMGGKCHPC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		private NEJBKFDPNPN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		private List<(PersistenceView, MGLJJACBNLF)>.Enumerator <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		private (PersistenceView, MGLJJACBNLF) <pair>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4070", Offset = "0x8BA3470", VA = "0x188BA4070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4740", Offset = "0x8BA3B40", VA = "0x188BA4740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0x8BAE010", Offset = "0x8BAD410", VA = "0x188BAE010")]
	[AsyncStateMachine(typeof(BJBEMFDOLHJ))]
	public static Task COBMPGJIBLC(KKGNFEOCIOB GKJPEAFFBEP, PJKBEIHEIIE NGIAGNLBILI, NHDMGGKCHPC IPBEDMLGBIB, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000184")]
internal struct LDIKPFACJIN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000185")]
	[CompilerGenerated]
	private struct FBMAHLKHPEP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		public KKGNFEOCIOB operation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		public PJKBEIHEIIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		public NHDMGGKCHPC timedYielder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private bool <isMaster>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		private ICHMBANNAMC <DEPRECATED_version>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		private NEJBKFDPNPN <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		private IDisposable <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		private List<(PersistenceView, MGLJJACBNLF)>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private PersistenceView <view>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		private MGLJJACBNLF <viewData>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x8BA9C80", Offset = "0x8BA9080", VA = "0x188BA9C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA560", Offset = "0x8BA9960", VA = "0x188BAA560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0x8BB26F0", Offset = "0x8BB1AF0", VA = "0x188BB26F0")]
	[AsyncStateMachine(typeof(FBMAHLKHPEP))]
	public static Task COBMPGJIBLC(KKGNFEOCIOB GKJPEAFFBEP, PJKBEIHEIIE NGIAGNLBILI, NHDMGGKCHPC IPBEDMLGBIB, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
public struct COHJOAKOKJN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000187")]
	[CompilerGenerated]
	private struct MLJAIFEBPCA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		public AsyncTaskMethodBuilder<DGHPMJAIBNO<PKPKOGNMCPP, KIBOPIAKFMB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		public COHJOAKOKJN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		public HIGDFOFBOPO.DABADIHPCNE preloadProgressCallback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private TaskAwaiter<DGHPMJAIBNO<PKPKOGNMCPP, KIBOPIAKFMB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB3E90", Offset = "0x8BB3290", VA = "0x188BB3E90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4510", Offset = "0x8BB3910", VA = "0x188BB4510", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40006DB")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006DC")]
	private long HKGMDDCCMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006DD")]
	private long PJPONKMKJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006DE")]
	private Guid? OGLAIGOGOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40006DF")]
	private IReadOnlyCollection<NCDNOPDHNPA> DNMCIFHIKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40006E0")]
	private IReadOnlyCollection<NCDNOPDHNPA> AMBHNMNINHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40006E1")]
	private AGJEILLLEMO EHFMHEPBDGI;

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0x8BA53C0", Offset = "0x8BA47C0", VA = "0x188BA53C0")]
	public static Task<DGHPMJAIBNO<PKPKOGNMCPP, KIBOPIAKFMB>> LNPIJLGMJAI(long DCONEHIDLCB, long JLNBCNHEKAJ, EILAOANGAEC PLPGDNCDOHB, HIGDFOFBOPO.DABADIHPCNE EHPOCPDDEAA, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0x8BA5260", Offset = "0x8BA4660", VA = "0x188BA5260")]
	[AsyncStateMachine(typeof(MLJAIFEBPCA))]
	private Task<DGHPMJAIBNO<PKPKOGNMCPP, KIBOPIAKFMB>> COBMPGJIBLC(HIGDFOFBOPO.DABADIHPCNE EHPOCPDDEAA, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
internal struct FBALAFFDJOO
{
	[Cpp2IlInjected.Token(Token = "0x2000189")]
	public struct BPDKIKNKJGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		public List<LGBKJPKBIKB> IIDNJOGGAHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		public List<MGLJJACBNLF> ELMCCOGHMBG;

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0xBFDA60", Offset = "0xBFCE60", VA = "0x180BFDA60")]
		public BPDKIKNKJGO(List<LGBKJPKBIKB> IIDNJOGGAHJ, List<MGLJJACBNLF> ELMCCOGHMBG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018A")]
	[CompilerGenerated]
	private sealed class PCIMIHDNCAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		public IEnumerable<LGBKJPKBIKB> instantiationRequests;

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public PCIMIHDNCAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000658")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6330", Offset = "0x8BB5730", VA = "0x188BB6330")]
		internal object ALCFEDIABCC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40006E9")]
	private JNGEBJCPLIA IDEPICHODDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40006EA")]
	private PJKBEIHEIIE NGIAGNLBILI;

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	private IJIEICICPPB JDGMIPEIBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x8BA9C30", Offset = "0x8BA9030", VA = "0x188BA9C30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0x8BA91F0", Offset = "0x8BA85F0", VA = "0x188BA91F0")]
	public static BPDKIKNKJGO COBMPGJIBLC(JNGEBJCPLIA IDEPICHODDC, PJKBEIHEIIE NGIAGNLBILI)
	{
		return default(BPDKIKNKJGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000653")]
	[Cpp2IlInjected.Address(RVA = "0x8BA9250", Offset = "0x8BA8650", VA = "0x188BA9250")]
	private BPDKIKNKJGO COBMPGJIBLC()
	{
		return default(BPDKIKNKJGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000654")]
	[Cpp2IlInjected.Address(RVA = "0x8BA9680", Offset = "0x8BA8A80", VA = "0x188BA9680")]
	private BPDKIKNKJGO LKAOGNHOHCL(LCCHGCBPFIP DLNHHMNONFG, ICHMBANNAMC BCFOJALMLBH)
	{
		return default(BPDKIKNKJGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x8BA94B0", Offset = "0x8BA88B0", VA = "0x188BA94B0")]
	private bool FPMIFDCHEJE(IEnumerable<LGBKJPKBIKB> IIDNJOGGAHJ)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200018B")]
internal struct EMDAACDCHOE
{
	[Cpp2IlInjected.Token(Token = "0x200018C")]
	[CompilerGenerated]
	private sealed class JCDLALKDBGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		public FBALAFFDJOO.BPDKIKNKJGO instantiations;

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public JCDLALKDBGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x8BAE1C0", Offset = "0x8BAD5C0", VA = "0x188BAE1C0")]
		internal object AOLCBBCGOLI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200018D")]
	[CompilerGenerated]
	private sealed class EOJCMMGMDLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		public PersistenceView instantiatedView;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		public Guid viewGuid;

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public EOJCMMGMDLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x8BA9160", Offset = "0x8BA8560", VA = "0x188BA9160")]
		internal object ICGFNMIHOKM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x8BA88D0", Offset = "0x8BA7CD0", VA = "0x188BA88D0")]
	public static void COBMPGJIBLC(KKGNFEOCIOB GKJPEAFFBEP, PJKBEIHEIIE NGIAGNLBILI, FBALAFFDJOO.BPDKIKNKJGO EKEJGOOICLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
internal class EEGFNEJKBGP
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200018F")]
	[CompilerGenerated]
	private struct MGHLPCHBPBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006F5")]
		public EEGFNEJKBGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006F6")]
		public HHALHAFODBO operationState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		public PJKBEIHEIIE deserializationData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB36C0", Offset = "0x8BB2AC0", VA = "0x188BB36C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB3E30", Offset = "0x8BB3230", VA = "0x188BB3E30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000190")]
	[CompilerGenerated]
	private sealed class OJNLLHFANDL
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
			public OJNLLHFANDL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000702")]
			public CancellationToken mlbToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000703")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0x8BB6F50", Offset = "0x8BB6350", VA = "0x188BB6F50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0x8BB7210", Offset = "0x8BB6610", VA = "0x188BB7210", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		public EEGFNEJKBGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		public PJKBEIHEIIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH handlerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		public Func<CancellationToken, Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public OJNLLHFANDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4FF0", Offset = "0x8BB43F0", VA = "0x188BB4FF0")]
		[AsyncStateMachine(typeof(<<RunAuthorityHandler>b__0>d))]
		internal Task MNINIKADENP(CancellationToken mlbToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000192")]
	[CompilerGenerated]
	private struct LFFNFGFIONM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		public EEGFNEJKBGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		public PJKBEIHEIIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		private OJNLLHFANDL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x8BB28B0", Offset = "0x8BB1CB0", VA = "0x188BB28B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2DE0", Offset = "0x8BB21E0", VA = "0x188BB2DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000193")]
	[CompilerGenerated]
	private struct DDIBFMFLPGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		public EEGFNEJKBGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		public PJKBEIHEIIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000711")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000712")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000713")]
		private Dictionary<Guid, List<OHJDDFABGKG>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000714")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x8BA6710", Offset = "0x8BA5B10", VA = "0x188BA6710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x8BA6D20", Offset = "0x8BA6120", VA = "0x188BA6D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000194")]
	[CompilerGenerated]
	private struct FKADCENJMED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000715")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000716")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000717")]
		public EEGFNEJKBGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000718")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH timer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000719")]
		public PJKBEIHEIIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400071A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400071B")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400071C")]
		private Dictionary<Guid, List<OHJDDFABGKG>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400071D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x8BAA5C0", Offset = "0x8BA99C0", VA = "0x188BAA5C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAC60", Offset = "0x8BAA060", VA = "0x188BAAC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000195")]
	[CompilerGenerated]
	private sealed class EMEJFDCAJON
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
			public OHJDDFABGKG handler;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000726")]
			public EMEJFDCAJON <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000727")]
			private NEJBKFDPNPN <_>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000728")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600067C")]
			[Cpp2IlInjected.Address(RVA = "0x8BB6A80", Offset = "0x8BB5E80", VA = "0x188BB6A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600067D")]
			[Cpp2IlInjected.Address(RVA = "0x8BB6EF0", Offset = "0x8BB62F0", VA = "0x188BB6EF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400071E")]
		public GGHJILOGHJA runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400071F")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000720")]
		public List<OHJDDFABGKG> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000721")]
		public PJKBEIHEIIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000722")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public EMEJFDCAJON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x8BA8F70", Offset = "0x8BA8370", VA = "0x188BA8F70")]
		internal object FAHHAPKNKPF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x8BA9060", Offset = "0x8BA8460", VA = "0x188BA9060")]
		[AsyncStateMachine(typeof(<<InvokeMethodsInParallel>b__2>d))]
		internal Task INCEDMMJHKI(OHJDDFABGKG handler)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x8BA8E80", Offset = "0x8BA8280", VA = "0x188BA8E80")]
		internal object CHBCIOOMOGA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000198")]
	[CompilerGenerated]
	private struct NABMBPNIOEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400072C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400072D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400072E")]
		public GGHJILOGHJA runFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400072F")]
		public Guid handlerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000730")]
		public List<OHJDDFABGKG> methods;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000731")]
		public PJKBEIHEIIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000732")]
		public CancellationToken token;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000733")]
		private EMEJFDCAJON <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000734")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4580", Offset = "0x8BB3980", VA = "0x188BB4580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4A50", Offset = "0x8BB3E50", VA = "0x188BB4A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000199")]
	[CompilerGenerated]
	private struct DCKOGBLKONI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000735")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000736")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000737")]
		public EEGFNEJKBGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000738")]
		public PJKBEIHEIIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000739")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH timer;

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
		[Cpp2IlInjected.Address(RVA = "0x8BA60F0", Offset = "0x8BA54F0", VA = "0x188BA60F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x8BA66B0", Offset = "0x8BA5AB0", VA = "0x188BA66B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019A")]
	[CompilerGenerated]
	private sealed class IDPMOACJFCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public IDPMOACJFCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x8BADFA0", Offset = "0x8BAD3A0", VA = "0x188BADFA0")]
		internal object MKEADEHPIDK()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019B")]
	[CompilerGenerated]
	private struct LNGGNNGFOAD : IAsyncStateMachine
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
		public EEGFNEJKBGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		public PJKBEIHEIIE data;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2E40", Offset = "0x8BB2240", VA = "0x188BB2E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x8BB3300", Offset = "0x8BB2700", VA = "0x188BB3300", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019C")]
	[CompilerGenerated]
	private sealed class PIMDBOJJGCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public PIMDBOJJGCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6870", Offset = "0x8BB5C70", VA = "0x188BB6870")]
		internal object IFCOAOJLOGG()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200019D")]
	[CompilerGenerated]
	private struct PBAAFGIDIBF : IAsyncStateMachine
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
		public EEGFNEJKBGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		private NEJBKFDPNPN <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		private ByteString <completionMark>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		private TaskAwaiter<HNBAHPJPPAI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5C90", Offset = "0x8BB5090", VA = "0x188BB5C90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB62D0", Offset = "0x8BB56D0", VA = "0x188BB62D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200019E")]
	[CompilerGenerated]
	private sealed class MFAHCJHBLLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		public Guid handlerIdToRun;

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public MFAHCJHBLLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB3650", Offset = "0x8BB2A50", VA = "0x188BB3650")]
		internal object DIOLLKCJMDP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40006F1")]
	private readonly NFGCOFFCAHB PJGCMFIFJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40006F2")]
	private EODJELMBNAJ DBBJFMDKEMA;

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	private KKGNFEOCIOB LHGELCIPFOO
	{
		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x1278830", Offset = "0x1277C30", VA = "0x181278830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600065F")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	public EEGFNEJKBGP(NFGCOFFCAHB PJGCMFIFJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000660")]
	[Cpp2IlInjected.Address(RVA = "0x8BA75B0", Offset = "0x8BA69B0", VA = "0x188BA75B0")]
	[AsyncStateMachine(typeof(MGHLPCHBPBM))]
	public Task COBMPGJIBLC(HHALHAFODBO LNIPIHKBBJE, PJKBEIHEIIE EOJHGNPAAAI, CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000661")]
	[Cpp2IlInjected.Address(RVA = "0x8BA7F40", Offset = "0x8BA7340", VA = "0x188BA7F40")]
	[AsyncStateMachine(typeof(LFFNFGFIONM))]
	private Task MAOEPJPKAHG(PJKBEIHEIIE NGIAGNLBILI, CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000662")]
	[Cpp2IlInjected.Address(RVA = "0x8BA8080", Offset = "0x8BA7480", VA = "0x188BA8080")]
	[AsyncStateMachine(typeof(DDIBFMFLPGG))]
	private Task NNNGJHNOPPD(PJKBEIHEIIE NGIAGNLBILI, CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0x8BA7A10", Offset = "0x8BA6E10", VA = "0x188BA7A10")]
	[AsyncStateMachine(typeof(FKADCENJMED))]
	private Task GGIMKKCKDLD(PJKBEIHEIIE NGIAGNLBILI, CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0x8BA7280", Offset = "0x8BA6680", VA = "0x188BA7280")]
	[AsyncStateMachine(typeof(NABMBPNIOEK))]
	private Task AJLGJHOFJBP(Guid OJBMLNADPND, List<OHJDDFABGKG> ELIFEOAJGHG, GGHJILOGHJA FHLBIINPJEI, PJKBEIHEIIE NGIAGNLBILI, CancellationToken MONGIMOHLAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x8BA7B50", Offset = "0x8BA6F50", VA = "0x188BA7B50")]
	[AsyncStateMachine(typeof(DCKOGBLKONI))]
	private Task HEMELOHEFIK(PJKBEIHEIIE NGIAGNLBILI, CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000666")]
	[Cpp2IlInjected.Address(RVA = "0x8BA7E00", Offset = "0x8BA7200", VA = "0x188BA7E00")]
	[AsyncStateMachine(typeof(LNGGNNGFOAD))]
	private Task JAGOMGDPDOG(Guid IBLGAAHGNAC, PJKBEIHEIIE NGIAGNLBILI, CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000667")]
	[Cpp2IlInjected.Address(RVA = "0x8BA77B0", Offset = "0x8BA6BB0", VA = "0x188BA77B0")]
	[AsyncStateMachine(typeof(PBAAFGIDIBF))]
	private Task FFLLEPIEMGL(Guid IBLGAAHGNAC, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000668")]
	[Cpp2IlInjected.Address(RVA = "0x8BA78F0", Offset = "0x8BA6CF0", VA = "0x188BA78F0")]
	private void GCJNECPOEHE(Guid IBLGAAHGNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0x8BA7700", Offset = "0x8BA6B00", VA = "0x188BA7700")]
	private void EOIEGLELKFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0x8BA7C90", Offset = "0x8BA7090", VA = "0x188BA7C90")]
	public Guid HJGBEPENFAO(HHALHAFODBO CLBGLGPKLNN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x8BA73D0", Offset = "0x8BA67D0", VA = "0x188BA73D0")]
	[CompilerGenerated]
	private object BIAEIKLGDLD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
internal struct BAMFGECLPJI
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A0")]
	[CompilerGenerated]
	private struct JNGMCBJKEBA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		public BAMFGECLPJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		private IEnumerator<KOIEILAHJPM> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF060", Offset = "0x8BAE460", VA = "0x188BAF060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF6F0", Offset = "0x8BAEAF0", VA = "0x188BAF6F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000751")]
	private IJIEICICPPB LHIJBEJLBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000752")]
	private CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000753")]
	private CancellationToken GMKBGHHNCDJ;

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x8BA4000", Offset = "0x8BA3400", VA = "0x188BA4000")]
	public static Task KOGIJPLKIGI(IJIEICICPPB LHIJBEJLBFF, CIIMOEPMPCG<string>.MOMGGNPHIKH LLOEFCNKADN, CancellationToken KCJNNEDMKPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x8BA3F10", Offset = "0x8BA3310", VA = "0x188BA3F10")]
	[AsyncStateMachine(typeof(JNGMCBJKEBA))]
	private Task COBMPGJIBLC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
public readonly struct AHKALLEBELB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400075A")]
	public readonly bool CMKBNCIPFNP;

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x2CEA490", Offset = "0x2CE9890", VA = "0x182CEA490")]
	public AHKALLEBELB(bool MJOEDBNKBJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
public readonly struct NCAEELCEENN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400075B")]
	public readonly LCCHGCBPFIP? JMALBFLOABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400075C")]
	public readonly FEAHLBPNAJF PBNLHBFDHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400075D")]
	public readonly Guid? EGENNPOMEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400075E")]
	public readonly IReadOnlyList<Guid> GLEAMAONNKN;

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public IReadOnlyCollection<string> BCHOHMDMPPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4AB0", Offset = "0x8BB3EB0", VA = "0x188BB4AB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public IReadOnlyDictionary<long, int> DCJGOBLBMPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4AD0", Offset = "0x8BB3ED0", VA = "0x188BB4AD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x8BB4AF0", Offset = "0x8BB3EF0", VA = "0x188BB4AF0")]
	public NCAEELCEENN(LCCHGCBPFIP? PHIIDLOGBDN, FEAHLBPNAJF JLIEOBBGNEC, Guid? GCDGOJIGOMN, [Optional] IReadOnlyList<Guid>? IECPCNLAMNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A3")]
internal class GKHJHHJLBGJ : FEGMPGAEEEE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A4")]
	[CompilerGenerated]
	private struct EJIMKOPNGCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000764")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000765")]
		public AsyncTaskMethodBuilder<NCAEELCEENN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000766")]
		public GKHJHHJLBGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000767")]
		public long subroomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		public GHPJALIENGD serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		public EPBLMMCONNB roomSaveOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		private PersistenceView[] <activePersistenceViews>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400076C")]
		private StringBuilder <outputBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		private NEJBKFDPNPN <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x8BA81C0", Offset = "0x8BA75C0", VA = "0x188BA81C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x8BA8860", Offset = "0x8BA7C60", VA = "0x188BA8860", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	[CompilerGenerated]
	private sealed class IMOPJPCEIEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		public float time;

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public IMOPJPCEIEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x8BAE150", Offset = "0x8BAD550", VA = "0x188BAE150")]
		internal object NEAKKKJJAJA()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	[CompilerGenerated]
	private struct APLAGDOBFHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		public GKHJHHJLBGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		public PersistenceView[] activePersistenceViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		public StringBuilder outputBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		public GHPJALIENGD serializeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		private IMOPJPCEIEH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		private NEJBKFDPNPN <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		private CancellationTokenSource <cts>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		private PNBCFLDECIA<Task> <tasks>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400077A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006A5")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3300", Offset = "0x8BA2700", VA = "0x188BA3300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3EB0", Offset = "0x8BA32B0", VA = "0x188BA3EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400075F")]
	private readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x4000760")]
	private static readonly TimeSpan CCFBPKKNDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000761")]
	private readonly JAMDABLJEJB EFHLNOFBBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000762")]
	private readonly BALMPHCBGIC PJIDLDEIOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000763")]
	private readonly MDHHAEAKDCE CIPCGIAOACN;

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	[Cpp2IlInjected.Address(RVA = "0x8BACB70", Offset = "0x8BABF70", VA = "0x188BACB70")]
	public GKHJHHJLBGJ(NFGCOFFCAHB PJGCMFIFJNB, JAMDABLJEJB EFHLNOFBBFN, BALMPHCBGIC FAICEDGOOHN, MDHHAEAKDCE CIPCGIAOACN, AKNCNLDICPO CCLJCJDJCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x8BABC50", Offset = "0x8BAB050", VA = "0x188BABC50")]
	[AsyncStateMachine(typeof(EJIMKOPNGCF))]
	public Task<NCAEELCEENN> COFPFOKABJF(long JLNBCNHEKAJ, EPBLMMCONNB PJFNIKNLLIE, GHPJALIENGD JNHJNCKBLMG, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	[Cpp2IlInjected.Address(RVA = "0x8BACA10", Offset = "0x8BABE10", VA = "0x188BACA10")]
	private static bool PNLIPKMBGPN(PersistenceView BPHIDAEMDAO, [Out] MNNHGIPNIJI FMHLFJEEHMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x8BABB10", Offset = "0x8BAAF10", VA = "0x188BABB10")]
	[AsyncStateMachine(typeof(APLAGDOBFHB))]
	private Task BOILDIHCLFJ(GHPJALIENGD JNHJNCKBLMG, PersistenceView[] PIPIKOBIFPK, StringBuilder BJALAHOAIAB, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x8BABDA0", Offset = "0x8BAB1A0", VA = "0x188BABDA0")]
	private NCAEELCEENN DPOFOCLPGHL(long JLNBCNHEKAJ, EPBLMMCONNB PJFNIKNLLIE, GHPJALIENGD JNHJNCKBLMG, IEnumerable<PersistenceView> PIPIKOBIFPK, StringBuilder BJALAHOAIAB)
	{
		return default(NCAEELCEENN);
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x8BAC3B0", Offset = "0x8BAB7B0", VA = "0x188BAC3B0")]
	private LCCHGCBPFIP EFIEKOCAGCJ(long JLNBCNHEKAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x8BAB8C0", Offset = "0x8BAACC0", VA = "0x188BAB8C0")]
	private void AOOPMHGDEKE(LCCHGCBPFIP HFNMCHEPFHM, StringBuilder BJALAHOAIAB, IEnumerable<PersistenceView> PIPIKOBIFPK, [In] JJDEBGOFHIM GHGLDMJMCGK, LCJMAJINLIB MEGOKKDPNEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x8BAC570", Offset = "0x8BAB970", VA = "0x188BAC570")]
	private void LMHGJJNPJPO(LCCHGCBPFIP HFNMCHEPFHM, StringBuilder BJALAHOAIAB, PersistenceView BPHIDAEMDAO, LCJMAJINLIB MEGOKKDPNEE, [In] JJDEBGOFHIM GHGLDMJMCGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A8")]
internal class HPPNIEBCIMH : FEGMPGAEEEE
{
	[Cpp2IlInjected.Token(Token = "0x20001A9")]
	[CompilerGenerated]
	private sealed class NEFCNCJIJMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000780")]
		public OJKNGDHNBLO.EJPNMHDEOFI roomDataUpload;

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public NEFCNCJIJMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4BF0", Offset = "0x8BB3FF0", VA = "0x188BB4BF0")]
		internal object AMEFEOGAEPH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
	[CompilerGenerated]
	private struct CKMDKLDNEDI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000781")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000782")]
		public AsyncTaskMethodBuilder<(OJKNGDHNBLO.EJPNMHDEOFI roomDataUpload, OJKNGDHNBLO.EJPNMHDEOFI subRoomDataUpload)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000783")]
		public NCAEELCEENN roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000784")]
		public IJIEICICPPB callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000785")]
		private NEFCNCJIJMD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000786")]
		private byte[] <data>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000787")]
		private float <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000788")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000789")]
		private TaskAwaiter<OJKNGDHNBLO.EJPNMHDEOFI> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4970", Offset = "0x8BA3D70", VA = "0x188BA4970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x8BA51F0", Offset = "0x8BA45F0", VA = "0x188BA51F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AB")]
	[CompilerGenerated]
	private struct FNMIGFIFMBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400078A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400078B")]
		public AsyncTaskMethodBuilder<LFHDKPIJJCJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400078C")]
		public HPPNIEBCIMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400078D")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		public NAODMFNDKAH roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		public NCAEELCEENN roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		private TaskAwaiter<LFHDKPIJJCJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x8BAACC0", Offset = "0x8BAA0C0", VA = "0x188BAACC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAF60", Offset = "0x8BAA360", VA = "0x188BAAF60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AC")]
	[CompilerGenerated]
	private struct KCDGHPOIPAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		public AsyncTaskMethodBuilder<LFHDKPIJJCJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		public IJIEICICPPB callbacks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		public NCAEELCEENN roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		public BFBHDEBAEJJ ugcVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		public NAODMFNDKAH roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		private TaskAwaiter<(OJKNGDHNBLO.EJPNMHDEOFI roomDataUpload, OJKNGDHNBLO.EJPNMHDEOFI subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400079D")]
		private TaskAwaiter<LFHDKPIJJCJ> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x8BB07C0", Offset = "0x8BAFBC0", VA = "0x188BB07C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0E20", Offset = "0x8BB0220", VA = "0x188BB0E20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001AD")]
	[CompilerGenerated]
	private struct ADFPHPIJDOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400079E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400079F")]
		public AsyncTaskMethodBuilder<GELNHKAAEAP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007A0")]
		public HPPNIEBCIMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007A1")]
		public NCAEELCEENN roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007A2")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		public string studioSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		private TaskAwaiter<(OJKNGDHNBLO.EJPNMHDEOFI roomDataUpload, OJKNGDHNBLO.EJPNMHDEOFI subRoomDataUpload)> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		private TaskAwaiter<GELNHKAAEAP> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x8BA2DE0", Offset = "0x8BA21E0", VA = "0x188BA2DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x8BA3290", Offset = "0x8BA2690", VA = "0x188BA3290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001AE")]
	[CompilerGenerated]
	private sealed class DAHMKKIOEOM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20001AF")]
		private struct <<UploadRoomDataBlobAndSyncReload>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40007B0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40007B1")]
			public AsyncTaskMethodBuilder<HNBAHPJPPAI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007B2")]
			public DAHMKKIOEOM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007B3")]
			public CancellationToken masterLockedBlockCancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007B4")]
			private HNBAHPJPPAI <reloadMessage>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007B5")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007B6")]
			private TaskAwaiter<GELNHKAAEAP> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40007B7")]
			private TaskAwaiter<LFHDKPIJJCJ> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40007B8")]
			private TaskAwaiter<HNBAHPJPPAI> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60006BF")]
			[Cpp2IlInjected.Address(RVA = "0x8BB7270", Offset = "0x8BB6670", VA = "0x188BB7270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006C0")]
			[Cpp2IlInjected.Address(RVA = "0x8BB8470", Offset = "0x8BB7870", VA = "0x188BB8470", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		public HPPNIEBCIMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		public NCAEELCEENN roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007AC")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		public NAODMFNDKAH roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007AE")]
		public AHKALLEBELB roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007AF")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public DAHMKKIOEOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x8BA55B0", Offset = "0x8BA49B0", VA = "0x188BA55B0")]
		[AsyncStateMachine(typeof(<<UploadRoomDataBlobAndSyncReload>b__0>d))]
		internal Task<HNBAHPJPPAI> LHHKDGGCCJB(CancellationToken masterLockedBlockCancellationToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B0")]
	[CompilerGenerated]
	private struct ABGLBBEHDGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007B9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007BA")]
		public AsyncTaskMethodBuilder<HNBAHPJPPAI> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		public HPPNIEBCIMH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		public NCAEELCEENN roomSerializedData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		public int savingPlayerAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		public long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		public long subRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		public NAODMFNDKAH roomSaveRequestPayload;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		public AHKALLEBELB roomSaveAnalyticsInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40007C3")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40007C4")]
		private TaskAwaiter<HNBAHPJPPAI> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x8BA2A40", Offset = "0x8BA1E40", VA = "0x188BA2A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x8BA2D70", Offset = "0x8BA2170", VA = "0x188BA2D70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400077D")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x400077E")]
	private static readonly AKNCNLDICPO BJLNEJCBJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400077F")]
	private readonly DDFIJAHBHAB EBHGIPFDGJH;

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	private JNGEBJCPLIA BEBMHIJNKBL
	{
		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x8B7C960", Offset = "0x8B7BD60", VA = "0x188B7C960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x8BADF10", Offset = "0x8BAD310", VA = "0x188BADF10")]
	public HPPNIEBCIMH(NFGCOFFCAHB PJGCMFIFJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD6D0", Offset = "0x8BACAD0", VA = "0x188BAD6D0")]
	[AsyncStateMachine(typeof(CKMDKLDNEDI))]
	private static Task<(OJKNGDHNBLO.EJPNMHDEOFI, OJKNGDHNBLO.EJPNMHDEOFI)> DLHCHFEGKIE(IJIEICICPPB LHIJBEJLBFF, NCAEELCEENN GLJDKFPIHIE, long DCONEHIDLCB, long OBCIDCBDAAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x8BADB70", Offset = "0x8BACF70", VA = "0x188BADB70")]
	[AsyncStateMachine(typeof(FNMIGFIFMBM))]
	public Task<LFHDKPIJJCJ> LKAIGAEMCMG(int IIIICGCPFGI, [CanBeNull] NAODMFNDKAH MMMALGMIIMN, NCAEELCEENN GLJDKFPIHIE, long DCONEHIDLCB, long OBCIDCBDAAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD820", Offset = "0x8BACC20", VA = "0x188BAD820")]
	public static Task<LFHDKPIJJCJ> LKAIGAEMCMG(IJIEICICPPB LHIJBEJLBFF, int IIIICGCPFGI, [CanBeNull] NAODMFNDKAH MMMALGMIIMN, NCAEELCEENN GLJDKFPIHIE, long DCONEHIDLCB, long OBCIDCBDAAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x8BADCE0", Offset = "0x8BAD0E0", VA = "0x188BADCE0")]
	[AsyncStateMachine(typeof(KCDGHPOIPAD))]
	public static Task<LFHDKPIJJCJ> LKAIGAEMCMG(IJIEICICPPB LHIJBEJLBFF, int IIIICGCPFGI, [CanBeNull] NAODMFNDKAH MMMALGMIIMN, NCAEELCEENN GLJDKFPIHIE, long DCONEHIDLCB, long OBCIDCBDAAN, BFBHDEBAEJJ DGJNOJNLFKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD3A0", Offset = "0x8BAC7A0", VA = "0x188BAD3A0")]
	[AsyncStateMachine(typeof(ADFPHPIJDOC))]
	private Task<GELNHKAAEAP> CMOJPFMGKGC(string CKLCBBHHKPN, int IIIICGCPFGI, NCAEELCEENN GLJDKFPIHIE, long DCONEHIDLCB, long OBCIDCBDAAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD520", Offset = "0x8BAC920", VA = "0x188BAD520")]
	[AsyncStateMachine(typeof(ABGLBBEHDGH))]
	public Task<HNBAHPJPPAI> DGDOGFOABMG(int IIIICGCPFGI, NAODMFNDKAH? MMMALGMIIMN, NCAEELCEENN GLJDKFPIHIE, long DCONEHIDLCB, long OBCIDCBDAAN, AHKALLEBELB BOOMHOGHMLL, CIIMOEPMPCG<string>.MOMGGNPHIKH DNPJKHGOCDJ, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B1")]
public abstract class CDAJNEOJJNP<T> where T : CDAJNEOJJNP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C5")]
	internal readonly JNGEBJCPLIA EDCDOMFKKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C6")]
	private int? EIHJPHOHHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C7")]
	protected readonly Guid CKANHNHMJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40007C8")]
	protected readonly HFLIPKNADKN FDHGJENBDMG;

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	protected T ABKNLHDMJAN
	{
		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x6C97560", Offset = "0x6C96960", VA = "0x186C97560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x6C978D0", Offset = "0x6C96CD0", VA = "0x186C978D0")]
	internal CDAJNEOJJNP(JNGEBJCPLIA KHHGKGOBEGJ, HFLIPKNADKN DILMGLJEHEN, [Optional] Guid? PADGMLDAJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C5")]
	[Cpp2IlInjected.Address(RVA = "0x6C977F0", Offset = "0x6C96BF0", VA = "0x186C977F0")]
	private HNBAHPJPPAI NKJIAAEKDED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C6")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	protected virtual void JALLLKMHPLB(HNBAHPJPPAI AFDNIPHJHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C7")]
	[Cpp2IlInjected.Address(RVA = "0x6C975C0", Offset = "0x6C969C0", VA = "0x186C975C0")]
	public T CFDJFGLCLNK(NELIJLIGAOD GHOBDALFLGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C8")]
	[Cpp2IlInjected.Address(RVA = "0x6C97650", Offset = "0x6C96A50", VA = "0x186C97650")]
	public T EKMOJLBNMEP(int KFNNJACINNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C9")]
	[Cpp2IlInjected.Address(RVA = "0x6C976E0", Offset = "0x6C96AE0", VA = "0x186C976E0", Slot = "5")]
	public virtual Task<LALFMHKAHCO> JHAAKDODNGN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B2")]
public class PJDLMHFKGND : CDAJNEOJJNP<PJDLMHFKGND>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007C9")]
	private BGMNPHKELEH JPPAFNCCIMK;

	[Cpp2IlInjected.Token(Token = "0x60006CA")]
	[Cpp2IlInjected.Address(RVA = "0x8BB69B0", Offset = "0x8BB5DB0", VA = "0x188BB69B0")]
	internal PJDLMHFKGND(JNGEBJCPLIA KHHGKGOBEGJ, HFLIPKNADKN DILMGLJEHEN, [Optional] Guid? PADGMLDAJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CB")]
	[Cpp2IlInjected.Address(RVA = "0x7D11890", Offset = "0x7D10C90", VA = "0x187D11890")]
	public PJDLMHFKGND GNBCCHOGKCC(BGMNPHKELEH JPPAFNCCIMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CC")]
	[Cpp2IlInjected.Address(RVA = "0x8BB68E0", Offset = "0x8BB5CE0", VA = "0x188BB68E0", Slot = "4")]
	protected override void JALLLKMHPLB(HNBAHPJPPAI AFDNIPHJHMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B3")]
public class KEPELKDMLJM : CDAJNEOJJNP<KEPELKDMLJM>
{
	[Cpp2IlInjected.Token(Token = "0x20001B4")]
	internal enum KKHLPOJFEGP
	{
		[Cpp2IlInjected.Token(Token = "0x40007CE")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40007CF")]
		Disk,
		[Cpp2IlInjected.Token(Token = "0x40007D0")]
		RecNet
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001B5")]
	[CompilerGenerated]
	private struct JOLBBDFHLGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007D2")]
		public AsyncTaskMethodBuilder<LALFMHKAHCO> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D3")]
		public KEPELKDMLJM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007D4")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		private TaskAwaiter<LALFMHKAHCO> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0x8BB03B0", Offset = "0x8BAF7B0", VA = "0x188BB03B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x8BB0750", Offset = "0x8BAFB50", VA = "0x188BB0750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40007CA")]
	private KKHLPOJFEGP LPMMBBGCELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40007CB")]
	private string KLHKNEHBBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40007CC")]
	private NAODMFNDKAH JPPAFNCCIMK;

	[Cpp2IlInjected.Token(Token = "0x60006CD")]
	[Cpp2IlInjected.Address(RVA = "0x8BB11D0", Offset = "0x8BB05D0", VA = "0x188BB11D0")]
	internal KEPELKDMLJM(JNGEBJCPLIA KHHGKGOBEGJ, HFLIPKNADKN DILMGLJEHEN, [Optional] Guid? PADGMLDAJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006CE")]
	[Cpp2IlInjected.Address(RVA = "0x8BB10B0", Offset = "0x8BB04B0", VA = "0x188BB10B0")]
	public KEPELKDMLJM JBHGHCPAIEC(string GMABBLIJJKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006CF")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0E90", Offset = "0x8BB0290", VA = "0x188BB0E90")]
	public KEPELKDMLJM FODDCKBHCMB(bool GANCBNPNPPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D0")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0EF0", Offset = "0x8BB02F0", VA = "0x188BB0EF0")]
	public KEPELKDMLJM IECOEPHGKCI(bool IIGLEDIKJFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D1")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0F10", Offset = "0x8BB0310", VA = "0x188BB0F10")]
	public KEPELKDMLJM IKNDIEDDEIM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D2")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0F40", Offset = "0x8BB0340", VA = "0x188BB0F40", Slot = "4")]
	protected override void JALLLKMHPLB(HNBAHPJPPAI AFDNIPHJHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D3")]
	[Cpp2IlInjected.Address(RVA = "0x8BB10E0", Offset = "0x8BB04E0", VA = "0x188BB10E0", Slot = "5")]
	[AsyncStateMachine(typeof(JOLBBDFHLGO))]
	public override Task<LALFMHKAHCO> JHAAKDODNGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006D4")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0EB0", Offset = "0x8BB02B0", VA = "0x188BB0EB0")]
	[CompilerGenerated]
	[DebuggerHidden]
	private Task<LALFMHKAHCO> GLKNHFNCNHI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B6")]
internal static class CBFCKLMJOED
{
	[Cpp2IlInjected.Token(Token = "0x60006D7")]
	[Cpp2IlInjected.Address(RVA = "0x8BA4820", Offset = "0x8BA3C20", VA = "0x188BA4820")]
	public static void OGDJJENELLG(this CGAODEELHOF EEMCBLIAENB, AAKDENBOOJG IAFGJMENDAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006D8")]
	[Cpp2IlInjected.Address(RVA = "0x8BA47A0", Offset = "0x8BA3BA0", VA = "0x188BA47A0")]
	public static void HPNLBGNMHLL(this AAKDENBOOJG BAGPMCPHKKA, [Optional] string AFDNIPHJHMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001B7")]
public static class HNCBFBLLKIG
{
	[Cpp2IlInjected.Token(Token = "0x60006D9")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD300", Offset = "0x8BAC700", VA = "0x188BAD300")]
	public static APAGCNALJKL GBCIFFFFBNN(this CAKKBAGAGCH LBMJEJIFGJN)
	{
		return default(APAGCNALJKL);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DA")]
	[Cpp2IlInjected.Address(RVA = "0x8BAD250", Offset = "0x8BAC650", VA = "0x188BAD250")]
	public static CAKKBAGAGCH AMFBKFFOGLM(this APAGCNALJKL ALDMKIMALCK)
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
			[Cpp2IlInjected.Token(Token = "0x40007D9")]
			public MHKDGKFABOE ValidationReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40007DA")]
			public bool HandleAsOtherReason;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007DB")]
			public MHKDGKFABOE HandleAs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007DC")]
			public string ValidationReasonName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007DD")]
			public string ReasonMessage;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007DE")]
			public bool HandledInCode;

			[Cpp2IlInjected.Token(Token = "0x60006E1")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public ResultConfig()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		private static MHKDGKFABOE[] allValidationReasons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		[SerializeField]
		private List<ResultConfig> resultConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		private Dictionary<MHKDGKFABOE, ResultConfig> configDictionary;

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8A90", Offset = "0x8BB7E90", VA = "0x188BB8A90")]
		public bool GEMOGKIKKCN(MHKDGKFABOE LBMCPIPNPIC, [Out] ResultConfig HFDKCBHNBMB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x8BB92B0", Offset = "0x8BB86B0", VA = "0x188BB92B0")]
		public ResultConfig PDHKNDPFDPA(MHKDGKFABOE HBHJOPNAJMN, [Optional] HashSet<MHKDGKFABOE> FNIDDAGHCOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x8BB90C0", Offset = "0x8BB84C0", VA = "0x188BB90C0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x8BB8B00", Offset = "0x8BB7F00", VA = "0x188BB8B00", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0xCFA860", Offset = "0xCF9C60", VA = "0x180CFA860")]
		public ValidationResultConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BB")]
public class OFPHHNOOJIH : OGJJOHIHALN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BC")]
	[CompilerGenerated]
	private struct MCPOHOPKJBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		public OFPHHNOOJIH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007EB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x8BB3360", Offset = "0x8BB2760", VA = "0x188BB3360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x8BB35F0", Offset = "0x8BB29F0", VA = "0x188BB35F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20001BD")]
	[CompilerGenerated]
	private struct DPBGIKCMGKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40007EC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40007ED")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007EE")]
		public CIIMOEPMPCG<string>.MOMGGNPHIKH timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		public OGJJOHIHALN preEmptySceneHandler;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007F1")]
		private CIIMOEPMPCG<string>.MOMGGNPHIKH <ts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007F2")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x8BA6D80", Offset = "0x8BA6180", VA = "0x188BA6D80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x8BA7220", Offset = "0x8BA6620", VA = "0x188BA7220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007E4")]
	private readonly CFCEKDEOPKK NJBMGDFBECK;

	[Cpp2IlInjected.Token(Token = "0x40007E5")]
	private static readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public string GNMBEGPAGIN
	{
		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4EE0", Offset = "0x8BB42E0", VA = "0x188BB4EE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006E9")]
	[Cpp2IlInjected.Address(RVA = "0x8BB4C40", Offset = "0x8BB4040", VA = "0x188BB4C40")]
	[MKODAOGKIAA.PMDGGDAFIAI.CCGBOKDKPLD]
	internal static void CJOCKMMIJAN(JFAGCPCLAAF KOCCFDNNPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	[RecRoom.NoEngine.Common.Preserve]
	public OFPHHNOOJIH([PKIHAALFADL(null)] CFCEKDEOPKK NJBMGDFBECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EB")]
	[Cpp2IlInjected.Address(RVA = "0x8BB4CB0", Offset = "0x8BB40B0", VA = "0x188BB4CB0", Slot = "5")]
	[AsyncStateMachine(typeof(MCPOHOPKJBC))]
	public Task COBMPGJIBLC(CIIMOEPMPCG<string>.MOMGGNPHIKH JLIFGOINOEM, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006EC")]
	[Cpp2IlInjected.Address(RVA = "0x8BB4DC0", Offset = "0x8BB41C0", VA = "0x188BB4DC0")]
	[AsyncStateMachine(typeof(DPBGIKCMGKM))]
	private Task ENLGEPHFGLG(OGJJOHIHALN FECJHCJFEBC, CIIMOEPMPCG<string>.MOMGGNPHIKH JLIFGOINOEM, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001BE")]
public interface CFCEKDEOPKK : OGJJOHIHALN
{
}
[Cpp2IlInjected.Token(Token = "0x20001BF")]
public interface OGJJOHIHALN
{
	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	string GNMBEGPAGIN
	{
		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task COBMPGJIBLC(CIIMOEPMPCG<string>.MOMGGNPHIKH JLIFGOINOEM, CancellationToken GMKBGHHNCDJ);
}
[Cpp2IlInjected.Token(Token = "0x20001C0")]
public static class DBGIHLIKGKA
{
	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x8BA56E0", Offset = "0x8BA4AE0", VA = "0x188BA56E0")]
	[MKODAOGKIAA.PMDGGDAFIAI.CCGBOKDKPLD]
	internal static void IBCLJHGLFJL(JFAGCPCLAAF KOCCFDNNPHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C1")]
public interface HOAPKCGDNIL : IEquatable<HOAPKCGDNIL>
{
	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	DateTime BFHAPIJKOAK
	{
		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AEEDEEGFKMB();

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LLBHCEFKCLH(long DCONEHIDLCB, long JLNBCNHEKAJ, [Out] NCAEELCEENN GLJDKFPIHIE);
}
[Cpp2IlInjected.Token(Token = "0x20001C2")]
internal class OMMEIMEBLIH : BHFDIHOAMAC
{
	[Cpp2IlInjected.Token(Token = "0x20001C3")]
	[CompilerGenerated]
	private sealed class OHMNCPLDAEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007F5")]
		public GFFNCJJHNKA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F6")]
		public Exception ex;

		[Cpp2IlInjected.Token(Token = "0x6000701")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public OHMNCPLDAEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x8BB4F80", Offset = "0x8BB4380", VA = "0x188BB4F80")]
		internal object NKAJCOOAAKC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F3")]
	private readonly HOPNOJCKELC KLOBGFJNEOB;

	[Cpp2IlInjected.Token(Token = "0x1400001C")]
	public event Action<HOAPKCGDNIL> BNBNFDLOANH
	{
		[Cpp2IlInjected.Token(Token = "0x60006F8")]
		[Cpp2IlInjected.Address(RVA = "0x8BB51F0", Offset = "0x8BB45F0", VA = "0x188BB51F0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60006F9")]
		[Cpp2IlInjected.Address(RVA = "0x8BB5410", Offset = "0x8BB4810", VA = "0x188BB5410", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0xA75990", Offset = "0xA74D90", VA = "0x180A75990")]
	[UnityEngine.Scripting.Preserve]
	public OMMEIMEBLIH([PKIHAALFADL(null)] HOPNOJCKELC KLOBGFJNEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x8BB5990", Offset = "0x8BB4D90", VA = "0x188BB5990", Slot = "6")]
	public bool PMLNFMBEAKA(long DCONEHIDLCB, long JLNBCNHEKAJ, NCAEELCEENN GLJDKFPIHIE, GFFNCJJHNKA PLJIHINALMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FC")]
	[Cpp2IlInjected.Address(RVA = "0xF1F170", Offset = "0xF1E570", VA = "0x180F1F170")]
	private void JCLFCGLGCNP(HOAPKCGDNIL PGGNJLGKBOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FD")]
	[Cpp2IlInjected.Address(RVA = "0x8BB52A0", Offset = "0x8BB46A0", VA = "0x188BB52A0", Slot = "7")]
	public bool MBNBGHMAEBB(long DCONEHIDLCB, long JLNBCNHEKAJ, [Out] HOAPKCGDNIL NNKOPAHIOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FE")]
	[Cpp2IlInjected.Address(RVA = "0x8BB54C0", Offset = "0x8BB48C0", VA = "0x188BB54C0", Slot = "8")]
	public bool OGNNOGJEGKP(long DCONEHIDLCB, long JLNBCNHEKAJ, GFFNCJJHNKA PLJIHINALMN, [Out] HOAPKCGDNIL NNKOPAHIOCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006FF")]
	[Cpp2IlInjected.Address(RVA = "0x8BB5570", Offset = "0x8BB4970", VA = "0x188BB5570")]
	private void PMACCDAGJAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000700")]
	[Cpp2IlInjected.Address(RVA = "0x8BB50E0", Offset = "0x8BB44E0", VA = "0x188BB50E0", Slot = "9")]
	public void EAKDOKLFGID(long DCONEHIDLCB, long JLNBCNHEKAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001C5")]
internal abstract class JKBGODPLPMJ : HOPNOJCKELC
{
	[Cpp2IlInjected.Token(Token = "0x20001C6")]
	protected enum MMMALBJFMIE : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40007FB")]
		Read,
		[Cpp2IlInjected.Token(Token = "0x40007FC")]
		Write
	}

	[Cpp2IlInjected.Token(Token = "0x20001C7")]
	[CompilerGenerated]
	private sealed class JKNAFJNDELF : IEnumerable<HOAPKCGDNIL>, IEnumerable, IEnumerator<HOAPKCGDNIL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007FE")]
		private HOAPKCGDNIL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007FF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000800")]
		public JKBGODPLPMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000801")]
		private GFFNCJJHNKA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000802")]
		public GFFNCJJHNKA <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000803")]
		private FileInfo[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000804")]
		private int <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		private HOAPKCGDNIL System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0xFC9810", Offset = "0xFC8C10", VA = "0x180FC9810")]
		[DebuggerHidden]
		public JKNAFJNDELF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x8BAED30", Offset = "0x8BAE130", VA = "0x188BAED30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x8BAF010", Offset = "0x8BAE410", VA = "0x188BAF010", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x8BAEF60", Offset = "0x8BAE360", VA = "0x188BAEF60", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HOAPKCGDNIL> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x8BAEF60", Offset = "0x8BAE360", VA = "0x188BAEF60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C8")]
	[CompilerGenerated]
	private sealed class KNKLKIKCFHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000805")]
		public GFFNCJJHNKA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000806")]
		public FileInfo autosaveFileInfo;

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public KNKLKIKCFHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2650", Offset = "0x8BB1A50", VA = "0x188BB2650")]
		internal object PPKMHPOOKNM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20001C9")]
	[CompilerGenerated]
	private sealed class LFCNEJNEJIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000807")]
		public JKBGODPLPMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000808")]
		public FileInfo fileInfo;

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public LFCNEJNEJIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB2830", Offset = "0x8BB1C30", VA = "0x188BB2830")]
		internal void GNJOFJKOCIH(LJEAMDFNILP.HCKPHMCAPCJ ct, string msg)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40007F9")]
	private readonly object GCEANNLBKHN;

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	protected string JCIJEDAJBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000706")]
		[Cpp2IlInjected.Address(RVA = "0x8BAE8E0", Offset = "0x8BADCE0", VA = "0x188BAE8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public abstract GAKHGMFMELA CJEIFIKFCMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000707")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000708")]
	[Cpp2IlInjected.Address(RVA = "0x8BAECB0", Offset = "0x8BAE0B0", VA = "0x188BAECB0")]
	protected JKBGODPLPMJ([CanBeNull] string FIPOMCCHGNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000709")]
	[Cpp2IlInjected.Address(RVA = "0x8BAE300", Offset = "0x8BAD700", VA = "0x188BAE300", Slot = "5")]
	public bool DFHHJBPJKLF(long DCONEHIDLCB, long JLNBCNHEKAJ, GFFNCJJHNKA PLJIHINALMN, [Out] HOAPKCGDNIL PGGNJLGKBOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600070A")]
	[Cpp2IlInjected.Address(RVA = "0x8BAE270", Offset = "0x8BAD670", VA = "0x188BAE270", Slot = "6")]
	[IteratorStateMachine(typeof(JKNAFJNDELF))]
	public IEnumerable<HOAPKCGDNIL> DADLHGCCJGE(GFFNCJJHNKA PLJIHINALMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	internal abstract void KOJIKLMMHJN(Stream CBIGGICNIBM, long DCONEHIDLCB, long JLNBCNHEKAJ, NCAEELCEENN GLJDKFPIHIE);

	[Cpp2IlInjected.Token(Token = "0x600070C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	internal abstract bool BFPLGOPIJCH(Stream NFAFKGHKDHE, long DCONEHIDLCB, long JLNBCNHEKAJ, NMGOGNFKFCI LPOFMJIMEKI, [Out] NCAEELCEENN GLJDKFPIHIE);

	[Cpp2IlInjected.Token(Token = "0x600070D")]
	[Cpp2IlInjected.Address(RVA = "0x8BAE4F0", Offset = "0x8BAD8F0", VA = "0x188BAE4F0", Slot = "7")]
	public HOAPKCGDNIL FOBFDENHGKA(long DCONEHIDLCB, long JLNBCNHEKAJ, NCAEELCEENN GLJDKFPIHIE, GFFNCJJHNKA PLJIHINALMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600070E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	[NotNull]
	protected abstract FileInfo GFDHKLGPHDA(long DCONEHIDLCB, long JLNBCNHEKAJ, GFFNCJJHNKA PLJIHINALMN, MMMALBJFMIE CFCMKLJDGJO);

	[Cpp2IlInjected.Token(Token = "0x600070F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	[NotNull]
	protected abstract DirectoryInfo NGCCACDABED(GFFNCJJHNKA PLJIHINALMN, MMMALBJFMIE CFCMKLJDGJO);

	[Cpp2IlInjected.Token(Token = "0x6000710")]
	[Cpp2IlInjected.Address(RVA = "0x8BAE870", Offset = "0x8BADC70", VA = "0x188BAE870")]
	protected void IPJGBJAHJGP(LJEAMDFNILP.HCKPHMCAPCJ CNDPJFMIDHJ, string KMNBOEKAFCD, FileInfo HBDAAHJCJEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000711")]
	[Cpp2IlInjected.Address(RVA = "0x8BAE8F0", Offset = "0x8BADCF0", VA = "0x188BAE8F0")]
	internal bool MDGAMPDDKFH(FileInfo FMHKAFMKGLO, long DCONEHIDLCB, long JLNBCNHEKAJ, [Out] NCAEELCEENN GLJDKFPIHIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000712")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
	private void CGFAIHNLEGB(Exception GGJDDHMDBJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CA")]
internal class JNIBKAMELGI : JKBGODPLPMJ
{
	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public override GAKHGMFMELA CJEIFIKFCMD
	{
		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x14981E0", Offset = "0x14975E0", VA = "0x1814981E0", Slot = "8")]
		get
		{
			return default(GAKHGMFMELA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000720")]
	[Cpp2IlInjected.Address(RVA = "0x8BB0370", Offset = "0x8BAF770", VA = "0x188BB0370")]
	public JNIBKAMELGI([Optional] string FIPOMCCHGNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000721")]
	[Cpp2IlInjected.Address(RVA = "0x8BB02F0", Offset = "0x8BAF6F0", VA = "0x188BB02F0")]
	private void NPFHOBBBALP(GFFNCJJHNKA PLJIHINALMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000722")]
	[Cpp2IlInjected.Address(RVA = "0x8BAFF40", Offset = "0x8BAF340", VA = "0x188BAFF40", Slot = "9")]
	internal override void KOJIKLMMHJN(Stream CBIGGICNIBM, long DCONEHIDLCB, long JLNBCNHEKAJ, NCAEELCEENN GLJDKFPIHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000723")]
	[Cpp2IlInjected.Address(RVA = "0x8BAF750", Offset = "0x8BAEB50", VA = "0x188BAF750", Slot = "10")]
	internal override bool BFPLGOPIJCH(Stream NFAFKGHKDHE, long DCONEHIDLCB, long JLNBCNHEKAJ, NMGOGNFKFCI LPOFMJIMEKI, [Out] NCAEELCEENN GLJDKFPIHIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000724")]
	[Cpp2IlInjected.Address(RVA = "0x8BAFE50", Offset = "0x8BAF250", VA = "0x188BAFE50", Slot = "11")]
	protected override FileInfo GFDHKLGPHDA(long DCONEHIDLCB, long JLNBCNHEKAJ, GFFNCJJHNKA PLJIHINALMN, MMMALBJFMIE CFCMKLJDGJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000725")]
	[Cpp2IlInjected.Address(RVA = "0x8BB01F0", Offset = "0x8BAF5F0", VA = "0x188BB01F0", Slot = "12")]
	protected override DirectoryInfo NGCCACDABED(GFFNCJJHNKA PLJIHINALMN, MMMALBJFMIE CFCMKLJDGJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CB")]
internal sealed class KMEDOAFOEDK : JKBGODPLPMJ
{
	[Cpp2IlInjected.Token(Token = "0x4000809")]
	private static readonly byte[] PEENICAIFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400080A")]
	private readonly byte[] BDGPEKKHFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400080B")]
	private readonly byte[] LGOJENKLIKM;

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public override GAKHGMFMELA CJEIFIKFCMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x1A659D0", Offset = "0x1A64DD0", VA = "0x181A659D0", Slot = "8")]
		get
		{
			return default(GAKHGMFMELA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x8BB2560", Offset = "0x8BB1960", VA = "0x188BB2560")]
	public KMEDOAFOEDK([Optional] string FIPOMCCHGNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x8BB1FA0", Offset = "0x8BB13A0", VA = "0x188BB1FA0", Slot = "9")]
	internal override void KOJIKLMMHJN(Stream CBIGGICNIBM, long DCONEHIDLCB, long JLNBCNHEKAJ, NCAEELCEENN GLJDKFPIHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000729")]
	[Cpp2IlInjected.Address(RVA = "0x8BB1340", Offset = "0x8BB0740", VA = "0x188BB1340", Slot = "10")]
	internal override bool BFPLGOPIJCH(Stream NFAFKGHKDHE, long DCONEHIDLCB, long JLNBCNHEKAJ, NMGOGNFKFCI LPOFMJIMEKI, [Out] NCAEELCEENN GLJDKFPIHIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600072A")]
	[Cpp2IlInjected.Address(RVA = "0x8BB1EE0", Offset = "0x8BB12E0", VA = "0x188BB1EE0")]
	private void GILPCNEDPCA(byte[] FGHKEPJEKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x8BB1DB0", Offset = "0x8BB11B0", VA = "0x188BB1DB0", Slot = "11")]
	protected override FileInfo GFDHKLGPHDA(long DCONEHIDLCB, long JLNBCNHEKAJ, GFFNCJJHNKA PLJIHINALMN, MMMALBJFMIE CFCMKLJDGJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x8BB23C0", Offset = "0x8BB17C0", VA = "0x188BB23C0", Slot = "12")]
	protected override DirectoryInfo NGCCACDABED(GFFNCJJHNKA PLJIHINALMN, MMMALBJFMIE CFCMKLJDGJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001CD")]
public enum GAKHGMFMELA : byte
{
	[Cpp2IlInjected.Token(Token = "0x400080F")]
	INVALID = 0,
	[Cpp2IlInjected.Token(Token = "0x4000810")]
	CHECKSUM = 2,
	[Cpp2IlInjected.Token(Token = "0x4000811")]
	BETTER_FILE_LAYOUT = 3
}
[Cpp2IlInjected.Token(Token = "0x20001CE")]
internal class GGNFMIJPAJJ : HOPNOJCKELC
{
	[Cpp2IlInjected.Token(Token = "0x20001D0")]
	[CompilerGenerated]
	private sealed class PELHJGHKLCN : IEnumerable<HOAPKCGDNIL>, IEnumerable, IEnumerator<HOAPKCGDNIL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000818")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000819")]
		private HOAPKCGDNIL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400081A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400081B")]
		public GGNFMIJPAJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400081C")]
		private GFFNCJJHNKA autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400081D")]
		public GFFNCJJHNKA <>3__autosaveType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400081E")]
		private GAKHGMFMELA[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400081F")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000820")]
		private IEnumerator<HOAPKCGDNIL> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		private HOAPKCGDNIL System.Collections.Generic.IEnumerator<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0xFC9810", Offset = "0xFC8C10", VA = "0x180FC9810")]
		[DebuggerHidden]
		public PELHJGHKLCN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB67E0", Offset = "0x8BB5BE0", VA = "0x188BB67E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073E")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6400", Offset = "0x8BB5800", VA = "0x188BB6400", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB63B0", Offset = "0x8BB57B0", VA = "0x188BB63B0")]
		private void DKMCMBPCGHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x8BB6790", Offset = "0x8BB5B90", VA = "0x188BB6790", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x8BB66E0", Offset = "0x8BB5AE0", VA = "0x188BB66E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HOAPKCGDNIL> System.Collections.Generic.IEnumerable<RecRoom.RoomLoading.AutoSaves.IAutosaveRecord>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x8BB66E0", Offset = "0x8BB5AE0", VA = "0x188BB66E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000812")]
	private readonly GAKHGMFMELA[] BJOJLBNJKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000813")]
	private readonly Dictionary<GAKHGMFMELA, HOPNOJCKELC> LLGPOBIOGDC;

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public GAKHGMFMELA CJEIFIKFCMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000731")]
		[Cpp2IlInjected.Address(RVA = "0x8BAB540", Offset = "0x8BAA940", VA = "0x188BAB540", Slot = "4")]
		get
		{
			return default(GAKHGMFMELA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x8BAB570", Offset = "0x8BAA970", VA = "0x188BAB570")]
	[UnityEngine.Scripting.Preserve]
	public GGNFMIJPAJJ(params HOPNOJCKELC[] HOGCEBNDBEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x8BAB290", Offset = "0x8BAA690", VA = "0x188BAB290", Slot = "5")]
	public bool DFHHJBPJKLF(long DCONEHIDLCB, long JLNBCNHEKAJ, GFFNCJJHNKA PLJIHINALMN, [Out] HOAPKCGDNIL PGGNJLGKBOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x8BAAFD0", Offset = "0x8BAA3D0", VA = "0x188BAAFD0")]
	private void BBLAGKNAILL(int FCPCCOGALAG, long DCONEHIDLCB, long JLNBCNHEKAJ, GFFNCJJHNKA PLJIHINALMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000735")]
	[Cpp2IlInjected.Address(RVA = "0x8BAB200", Offset = "0x8BAA600", VA = "0x188BAB200", Slot = "6")]
	[IteratorStateMachine(typeof(PELHJGHKLCN))]
	public IEnumerable<HOAPKCGDNIL> DADLHGCCJGE(GFFNCJJHNKA PLJIHINALMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000736")]
	[Cpp2IlInjected.Address(RVA = "0x8BAB3E0", Offset = "0x8BAA7E0", VA = "0x188BAB3E0", Slot = "7")]
	public HOAPKCGDNIL FOBFDENHGKA(long DCONEHIDLCB, long JLNBCNHEKAJ, NCAEELCEENN GLJDKFPIHIE, GFFNCJJHNKA PLJIHINALMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D1")]
internal static class HFHBIJBKOBL
{
	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x8BACE40", Offset = "0x8BAC240", VA = "0x188BACE40")]
	internal static byte[] MHKDHKDBMLJ(byte[] FGHKEPJEKFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000746")]
	[Cpp2IlInjected.Address(RVA = "0x8BACDC0", Offset = "0x8BAC1C0", VA = "0x188BACDC0")]
	public static void EINAPDDGPNG(Stream GBHJNKNIPGA, byte[] PBDHJPIGFGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x8BACBE0", Offset = "0x8BABFE0", VA = "0x188BACBE0")]
	public static bool CCPGGANONJF(Stream GBHJNKNIPGA, long NAOACDPMNNH, NMGOGNFKFCI FDLKCDPFCHL, [Out] byte[] KHIGPLANGKO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D2")]
internal sealed class DBMOPNLDLOH : HOAPKCGDNIL, IEquatable<HOAPKCGDNIL>, IEquatable<DBMOPNLDLOH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000821")]
	private readonly JKBGODPLPMJ EACEPDKAHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000822")]
	public readonly FileInfo NJJBEHJIICA;

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public GAKHGMFMELA CJEIFIKFCMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x8406B70", Offset = "0x8405F70", VA = "0x188406B70", Slot = "9")]
		get
		{
			return default(GAKHGMFMELA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public DateTime BFHAPIJKOAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x8BA5EA0", Offset = "0x8BA52A0", VA = "0x188BA5EA0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600074A")]
	[Cpp2IlInjected.Address(RVA = "0x8BA5FE0", Offset = "0x8BA53E0", VA = "0x188BA5FE0")]
	public DBMOPNLDLOH(JKBGODPLPMJ KDNHINIMEFB, FileInfo FMHKAFMKGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074B")]
	[Cpp2IlInjected.Address(RVA = "0x8BA5F30", Offset = "0x8BA5330", VA = "0x188BA5F30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600074C")]
	[Cpp2IlInjected.Address(RVA = "0x8BA5AF0", Offset = "0x8BA4EF0", VA = "0x188BA5AF0", Slot = "5")]
	public void AEEDEEGFKMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x8BA5E60", Offset = "0x8BA5260", VA = "0x188BA5E60", Slot = "6")]
	public bool LLBHCEFKCLH(long DCONEHIDLCB, long JLNBCNHEKAJ, [Out] NCAEELCEENN GLJDKFPIHIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x8BA5D60", Offset = "0x8BA5160", VA = "0x188BA5D60", Slot = "7")]
	public bool Equals(HOAPKCGDNIL LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600074F")]
	[Cpp2IlInjected.Address(RVA = "0x8BA5CA0", Offset = "0x8BA50A0", VA = "0x188BA5CA0", Slot = "8")]
	public bool Equals(DBMOPNLDLOH LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x8BA5BB0", Offset = "0x8BA4FB0", VA = "0x188BA5BB0", Slot = "0")]
	public override bool Equals(object DEJGDIIDCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x8BA5DD0", Offset = "0x8BA51D0", VA = "0x188BA5DD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001D3")]
public delegate void NMGOGNFKFCI(LJEAMDFNILP.HCKPHMCAPCJ MNIBNBLDHGA, string AFDNIPHJHMO);
[Cpp2IlInjected.Token(Token = "0x20001D4")]
internal interface HOPNOJCKELC
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	GAKHGMFMELA CJEIFIKFCMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000754")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DFHHJBPJKLF(long DCONEHIDLCB, long JLNBCNHEKAJ, GFFNCJJHNKA PLJIHINALMN, [Out] HOAPKCGDNIL PGGNJLGKBOA);

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<HOAPKCGDNIL> DADLHGCCJGE(GFFNCJJHNKA PLJIHINALMN);

	[Cpp2IlInjected.Token(Token = "0x6000757")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HOAPKCGDNIL FOBFDENHGKA(long DCONEHIDLCB, long JLNBCNHEKAJ, NCAEELCEENN GLJDKFPIHIE, GFFNCJJHNKA PLJIHINALMN);
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
