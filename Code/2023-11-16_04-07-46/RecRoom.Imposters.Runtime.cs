using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.Core.DataStructures;
using RecRoom.Core.Imposters;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DeferredImposterSpawnManager : SingletonMonoBehaviour<DeferredImposterSpawnManager>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private readonly struct OHCMHHKADEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly BENAOJKJAMG NCKJJEDKBKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string GHBCCHGNIIG;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7F7E80", Offset = "0x7F6E80", VA = "0x1807F7E80")]
		public OHCMHHKADEB(BENAOJKJAMG MEMLFAMPHOE, string ADNIEBEKHMI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct HKGDDIJPFMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public OHCMHHKADEB queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5E01580", Offset = "0x5E00580", VA = "0x185E01580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E01920", Offset = "0x5E00920", VA = "0x185E01920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider DCILKBILOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private MBBCDDLAPMP<OHCMHHKADEB, GameObject> MEPHNKLOLGH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public PECJHCDPHGG ODJIHIKIBDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x76F210", Offset = "0x76E210", VA = "0x18076F210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x76F1A0", Offset = "0x76E1A0", VA = "0x18076F1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private MBBCDDLAPMP<OHCMHHKADEB, GameObject> MGDAMAAFFGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5E01140", Offset = "0x5E00140", VA = "0x185E01140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int IENMOOHBJBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5E01480", Offset = "0x5E00480", VA = "0x185E01480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E00F60", Offset = "0x5DFFF60", VA = "0x185E00F60", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5E014D0", Offset = "0x5E004D0", VA = "0x185E014D0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E01020", Offset = "0x5E00020", VA = "0x185E01020")]
	[AsyncStateMachine(typeof(HKGDDIJPFMB))]
	private Task<GameObject> IKBNLBAGOJJ(OHCMHHKADEB JILOGHPONFC, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5E012A0", Offset = "0x5E002A0", VA = "0x185E012A0")]
	public Task<GameObject> LoadItemAsync(BENAOJKJAMG MEMLFAMPHOE, CancellationToken JEBPNJAPHEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5E01540", Offset = "0x5E00540", VA = "0x185E01540")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class OPCILPPOICA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public BENAOJKJAMG MFLDADNJMGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture DLMBELCNGKM;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x77EB20", Offset = "0x77DB20", VA = "0x18077EB20")]
		public OPCILPPOICA(BENAOJKJAMG MKFLLGMKNPD, Texture ALGCGDPDEAF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum PMMCFJOOCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Custom = 0,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		XS_128 = 0x80,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		S_256 = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		M_512 = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		L_1024 = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		XL_2048 = 0x800
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class ALIFNHCNKGG : JFNGNMHHJFA<Texture>, BCEPPIOGDMP, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct DIHCGHEMLFA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ALIFNHCNKGG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5DFDCB0", Offset = "0x5DFCCB0", VA = "0x185DFDCB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5DFE4C0", Offset = "0x5DFD4C0", VA = "0x185DFE4C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly BENAOJKJAMG MKFLLGMKNPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture FOPBKILMOKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig FEDFDJEMJPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken JEBPNJAPHEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject KCOHDACJFNK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public FFKFAKMNOMC<Texture> CCIMJCDPLMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5DFC960", Offset = "0x5DFB960", VA = "0x185DFC960", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Task<Texture> AOAGMFCPOKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x76F1D0", Offset = "0x76E1D0", VA = "0x18076F1D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5DFCB40", Offset = "0x5DFBB40", VA = "0x185DFCB40")]
		public ALIFNHCNKGG(BENAOJKJAMG MKFLLGMKNPD, RenderTexture FOPBKILMOKB, ImposterRenderConfig FEDFDJEMJPP, CancellationToken JEBPNJAPHEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5DFCA50", Offset = "0x5DFBA50", VA = "0x185DFCA50")]
		[AsyncStateMachine(typeof(DIHCGHEMLFA))]
		private Task<Texture> MOLILFCMCJG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5DFCA40", Offset = "0x5DFBA40", VA = "0x185DFCA40", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5DFC9C0", Offset = "0x5DFB9C0", VA = "0x185DFC9C0")]
		private static void DOLEDLOEALL(GameObject KCOHDACJFNK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct LFMAGDOBHFK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<Texture> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5E02E20", Offset = "0x5E01E20", VA = "0x185E02E20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8C2E60", Offset = "0x8C1E60", VA = "0x1808C2E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[Tooltip("Texture shown when the imposter texture is not available")]
	[SerializeField]
	[Header("General")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[APIEEPBMFLD(CDNIJDNCOPP.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private PMMCFJOOCCJ size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[IKMELONFGFM("size", PMMCFJOOCCJ.Custom)]
	[Tooltip("Custom pixel size for rendered imposter")]
	[SerializeField]
	private int customSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	private int antiAliasing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[Tooltip("Configuration specifying render properties for the imposter")]
	private ImposterRenderConfig imposterRenderConfig;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static int KKPKCFENHJI;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture NKKAFBNEANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private JJIIDPOJLFF<GameObject> PJNMGBJCGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private FJLNLHOHLGA LPNOCOLMIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource OCCBKDMNJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private JFNGNMHHJFA<Texture> JPLDMHHFEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private BENAOJKJAMG CIIDCKKIBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture FFJEDKHGMNP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int MHIDIFIEHLC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E028E0", Offset = "0x5E018E0", VA = "0x185E028E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5E02930", Offset = "0x5E01930", VA = "0x185E02930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture EFMBHMIDKNO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E01ED0", Offset = "0x5E00ED0", VA = "0x185E01ED0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x774F70", Offset = "0x773F70", VA = "0x180774F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private BENAOJKJAMG MFLDADNJMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7738A0", Offset = "0x7728A0", VA = "0x1807738A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5E02350", Offset = "0x5E01350", VA = "0x185E02350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool IDBADONLHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4FCCFB0", Offset = "0x4FCBFB0", VA = "0x184FCCFB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int GKABBDKBIHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E020A0", Offset = "0x5E010A0", VA = "0x185E020A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5E02080", Offset = "0x5E01080", VA = "0x185E02080")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5E024B0", Offset = "0x5E014B0", VA = "0x185E024B0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5E02140", Offset = "0x5E01140", VA = "0x185E02140")]
	private void HOCNNBLCEFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5E02800", Offset = "0x5E01800", VA = "0x185E02800")]
	public void Set(BENAOJKJAMG HGPOEAHHJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5E027B0", Offset = "0x5E017B0", VA = "0x185E027B0")]
	public void Set(Texture ALGCGDPDEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5E027C0", Offset = "0x5E017C0", VA = "0x185E027C0")]
	public void Set(OPCILPPOICA APPJEOKOGAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E02090", Offset = "0x5E01090", VA = "0x185E02090")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E025B0", Offset = "0x5E015B0", VA = "0x185E025B0")]
	public void SetInternal(BENAOJKJAMG HGPOEAHHJMB, [Optional] Texture BPCIGFGJEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E025A0", Offset = "0x5E015A0", VA = "0x185E025A0")]
	public void SetCustomSize(int IKHMODMMFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x779FE0", Offset = "0x778FE0", VA = "0x180779FE0")]
	public void SetAntiAliasing(int EIFIEMIJBFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5E021C0", Offset = "0x5E011C0", VA = "0x185E021C0")]
	[AsyncStateMachine(typeof(LFMAGDOBHFK))]
	private void JBPCNMBADOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E02270", Offset = "0x5E01270", VA = "0x185E02270")]
	private void LDCBCIBFCJB(Texture ALGCGDPDEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E02860", Offset = "0x5E01860", VA = "0x185E02860")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, ILDHMOMLCNB
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float HNEDPOCADAL = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x770CB0", Offset = "0x76FCB0", VA = "0x180770CB0", Slot = "4")]
	public void PrepareImposter(DKGNCOLBLCL DFHMEJDFNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5E01E90", Offset = "0x5E00E90", VA = "0x185E01E90")]
	public void SetReferencePoint(Vector3 LGJKNOILLNC, Quaternion ODJCGHEELMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5E01C90", Offset = "0x5E00C90", VA = "0x185E01C90")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E01E70", Offset = "0x5E00E70", VA = "0x185E01E70")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1335090", Offset = "0x1334090", VA = "0x181335090")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct LFDGMEDEAOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static LFDGMEDEAOJ GIMFAEHFMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float ONJELEEIAFB;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2011770", Offset = "0x2010770", VA = "0x182011770")]
	public LFDGMEDEAOJ(float OAGCCGFMKKM)
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		[APIEEPBMFLD(CDNIJDNCOPP.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int EDHPJFMDGIN = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int KCIGJLGDNDF = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> CIPLFJFHHFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool MMFKIAAGNNE;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5E02B10", Offset = "0x5E01B10", VA = "0x185E02B10")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5E02A10", Offset = "0x5E01A10", VA = "0x185E02A10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5E02D50", Offset = "0x5E01D50", VA = "0x185E02D50")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BENAOJKJAMG
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string JGCBHBNMOCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	LFDGMEDEAOJ LFDGMEDEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action NBHGEKMDONA;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> CMNHBBCIDHD(CancellationToken JEBPNJAPHEL);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NEFHOPBHDGD(BENAOJKJAMG EJEDDDCGMMB);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LJNOPHOGOFF();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NECLCJDDAFE();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EEHAOFFHBPN([Out] JFNGNMHHJFA<Texture> EKOMOMGIEFH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MKCKGJPLOAK
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5E03660", Offset = "0x5E02660", VA = "0x185E03660")]
	public static bool KPMOFJIMIHN(BENAOJKJAMG FMNPGFADFOG, BENAOJKJAMG BFIJDFJBBJJ)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, ILDHMOMLCNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5DFDB60", Offset = "0x5DFCB60", VA = "0x185DFDB60", Slot = "4")]
		public void PrepareImposter(DKGNCOLBLCL DFHMEJDFNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x770CA0", Offset = "0x76FCA0", VA = "0x180770CA0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x770CA0", Offset = "0x76FCA0", VA = "0x180770CA0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface ILDHMOMLCNB
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(DKGNCOLBLCL DFHMEJDFNAL);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface ILKIJLMBHNG
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> DLBOPCBHDFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> JAMINNCPCPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface PECJHCDPHGG
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GameObject GDAIMPPNHLD(GameObject NEMHBMOBONB, Transform IGPIMCJILMM, bool MFECJDFNJMG = false);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T GDAIMPPNHLD<T>(T NEMHBMOBONB, Transform IGPIMCJILMM, bool MFECJDFNJMG = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T GDAIMPPNHLD<T>(GameObject NEMHBMOBONB, Transform IGPIMCJILMM, bool MFECJDFNJMG = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject GDAIMPPNHLD(GameObject NEMHBMOBONB, Transform IGPIMCJILMM, DKGNCOLBLCL DFHMEJDFNAL, bool MFECJDFNJMG);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class CFHLJPLFMDF : IDisposable, PECJHCDPHGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> PAAHPLFOGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> CEEJICEBHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform CHIOGDEKAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> CHLDPJNFPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> ALOLAMMLCMI;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD4B0", Offset = "0x5DFC4B0", VA = "0x185DFD4B0")]
	[PKDJMILODMH(OMIAJJHDDGO.None)]
	public static void KIGOHJFFCIM(EIABFOFJCDK KMOLABGHAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD720", Offset = "0x5DFC720", VA = "0x185DFD720")]
	[Preserve]
	public CFHLJPLFMDF([KHIPNIHHNOH(null)] ILKIJLMBHNG NFOLAHJKFMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5DFCCC0", Offset = "0x5DFBCC0", VA = "0x185DFCCC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD390", Offset = "0x5DFC390", VA = "0x185DFD390", Slot = "5")]
	public GameObject GDAIMPPNHLD(GameObject NEMHBMOBONB, Transform IGPIMCJILMM, bool MFECJDFNJMG = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x23286B0", Offset = "0x23276B0", VA = "0x1823286B0", Slot = "6")]
	public T GDAIMPPNHLD<T>(T NEMHBMOBONB, Transform IGPIMCJILMM, bool MFECJDFNJMG = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2328110", Offset = "0x2327110", VA = "0x182328110", Slot = "7")]
	public T GDAIMPPNHLD<T>(GameObject NEMHBMOBONB, Transform IGPIMCJILMM, bool MFECJDFNJMG = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD420", Offset = "0x5DFC420", VA = "0x185DFD420", Slot = "8")]
	public GameObject GDAIMPPNHLD(GameObject NEMHBMOBONB, Transform IGPIMCJILMM, DKGNCOLBLCL DFHMEJDFNAL, bool MFECJDFNJMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x23280D0", Offset = "0x23270D0", VA = "0x1823280D0", Slot = "9")]
	public T GDAIMPPNHLD<T>(GameObject NEMHBMOBONB, Transform IGPIMCJILMM, DKGNCOLBLCL DFHMEJDFNAL, bool MFECJDFNJMG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2328140", Offset = "0x2327140", VA = "0x182328140")]
	private T GDAIMPPNHLD<T>(GameObject NEMHBMOBONB, Transform IGPIMCJILMM, DKGNCOLBLCL DFHMEJDFNAL, bool MFECJDFNJMG, [Out] GameObject GMHKMBKKFPG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2327C30", Offset = "0x2326C30", VA = "0x182327C30")]
	private T DKCJDMNAMHG<T>(GameObject GFBHJHHLEFD, DKGNCOLBLCL DFHMEJDFNAL, bool MFECJDFNJMG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5DFCDA0", Offset = "0x5DFBDA0", VA = "0x185DFCDA0")]
	private void FFAALLBPNHH(Component NDABCGGAOCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5DFCEB0", Offset = "0x5DFBEB0", VA = "0x185DFCEB0")]
	private void FHGDOIJIJDK(Component NDABCGGAOCM, DKGNCOLBLCL DFHMEJDFNAL, bool MFECJDFNJMG, bool KFJIEEDJMJG, [Optional] Type LEEMHNGHEPJ, [Optional] Type EOJADGKIBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5DFD5B0", Offset = "0x5DFC5B0", VA = "0x185DFD5B0")]
	private void PGKFMLAOGHH(GameObject GFBHJHHLEFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct DKGNCOLBLCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> LFOEGNCOGCO;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x23666C0", Offset = "0x23656C0", VA = "0x1823666C0")]
	public DKGNCOLBLCL GBPMDEJOJHE<T>(T LBNNKLHNDAF)
	{
		return default(DKGNCOLBLCL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2366DF0", Offset = "0x2365DF0", VA = "0x182366DF0")]
	public T GJNMDDLIIAA<T>(T ELMPJJEOKEH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2365EF0", Offset = "0x2364EF0", VA = "0x182365EF0")]
	public bool FKFDJGDIAKO<T>([Out] T LBNNKLHNDAF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct CIFIJCFPKPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool APMNCHLEGOH;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xBAF9F0", Offset = "0xBAE9F0", VA = "0x180BAF9F0")]
	public CIFIJCFPKPB(bool JLMBLCLOELG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct NGGJBOFBPKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool ELBKOPAGAIH;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5E03750", Offset = "0x5E02750", VA = "0x185E03750")]
	public NGGJBOFBPKC(bool HPOLCKHKEPC)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x770CA0", Offset = "0x76FCA0", VA = "0x180770CA0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, ILDHMOMLCNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5E03760", Offset = "0x5E02760", VA = "0x185E03760", Slot = "4")]
		public void PrepareImposter(DKGNCOLBLCL DFHMEJDFNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x770CA0", Offset = "0x76FCA0", VA = "0x180770CA0")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ImposterBoundsOverride : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Bounds imposterBounds;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Bounds BNNFABIGFAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5E01B00", Offset = "0x5E00B00", VA = "0x185E01B00")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5E01AC0", Offset = "0x5E00AC0", VA = "0x185E01AC0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5E01A80", Offset = "0x5E00A80", VA = "0x185E01A80")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5E01990", Offset = "0x5E00990", VA = "0x185E01990")]
		private void GKHONBDDCCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x770CA0", Offset = "0x76FCA0", VA = "0x180770CA0")]
		public ImposterBoundsOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CreateAssetMenu(fileName = "ImposterRenderConfig", menuName = "RecRoom/Imposters/Imposter Render Config")]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x5E03640", Offset = "0x5E02640", VA = "0x185E03640")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5E03630", Offset = "0x5E02630", VA = "0x185E03630")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5E029B0", Offset = "0x5E019B0", VA = "0x185E029B0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class DMHBGMGGGOA
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<URPLight> OPBEFAOFNJH;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Vector3 EBAMIPNIANA;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly Vector3 HLKLJDFMJGG;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static Camera HKOKFFDBJLI;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly List<Renderer> CPJCFPCNBKE;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly List<ImposterBoundsOverride> JMBONEOLOLA;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static AmbientMode OBAFAFNIKLL;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color KJMEKJMMBNK;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Color ILLIGLNDPGO;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Color NOLEONDBCHN;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static Cubemap MICGCAHGJKB;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static bool HPHHBDOFLNA;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera NNIJMCEOAGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5DFE530", Offset = "0x5DFD530", VA = "0x185DFE530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF950", Offset = "0x5DFE950", VA = "0x185DFF950")]
	public static void LMNJLLLIGIM(Vector3 NNFMELPHMKM, Quaternion IJHJGBJNIGF, ImposterRenderConfig KHMHOMPAGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFBC0", Offset = "0x5DFEBC0", VA = "0x185DFFBC0")]
	private static void OHPLCIPALOJ(Vector3 NNFMELPHMKM, Quaternion IJHJGBJNIGF, URPLight EPNHEKPCLML, ImposterRenderConfig.LightConfig NBBLDCGGDPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF600", Offset = "0x5DFE600", VA = "0x185DFF600")]
	public static void IMJOJCFIDEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF280", Offset = "0x5DFE280", VA = "0x185DFF280")]
	private static void IFOEHOJIJAG(int GOHJHOKMGBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF6E0", Offset = "0x5DFE6E0", VA = "0x185DFF6E0")]
	public static void KODCKFBMJEN(ImposterRenderConfig KHMHOMPAGOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF190", Offset = "0x5DFE190", VA = "0x185DFF190")]
	public static void HOJKMHAHMJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5DFEFC0", Offset = "0x5DFDFC0", VA = "0x185DFEFC0")]
	public static void HKNJHGPJFAB(GameObject KDAMENAKJJL, RenderTexture FOPBKILMOKB, ImposterRenderConfig KHMHOMPAGOM, LFDGMEDEAOJ ALCBLHCHOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE9E0", Offset = "0x5DFD9E0", VA = "0x185DFE9E0")]
	private static void FKKODEHLEHE(GameObject KDAMENAKJJL, RenderTexture FOPBKILMOKB, ImposterRenderConfig KHMHOMPAGOM, LFDGMEDEAOJ ALCBLHCHOIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5DFE740", Offset = "0x5DFD740", VA = "0x185DFE740")]
	private static void EPILDHNDBDA(GameObject KDAMENAKJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5DFFEF0", Offset = "0x5DFEEF0", VA = "0x185DFFEF0")]
	public static void PKCPNIKKIIK(GameObject NEMHBMOBONB, Vector3 GNMMIHKHGON, Vector3 HAPAOCKOJHG, float LKEDKLBJDGO, LFDGMEDEAOJ ALCBLHCHOIH, [Out] Vector3 MGKEJPHNLMN, [Out] Quaternion ANBOEGCINJL, [Out] float LAJOAMFMBKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5DFF8A0", Offset = "0x5DFE8A0", VA = "0x185DFF8A0")]
	public static RenderTexture LEIDOPLFDKG(int MFEOMIOJEPD, int ODOFMKIIGFF, RenderTextureFormat DBCIFBLNDEG = RenderTextureFormat.ARGB32)
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public struct LMEJNHOOGDB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public NLHOOGKAONG DKNMKJPEKAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public GameObject BIBLAOGFGJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public RenderTexture EFMBHMIDKNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public ImposterRenderConfig JOHPJNIFEIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public LFDGMEDEAOJ LFDGMEDEAOJ;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5E035C0", Offset = "0x5E025C0", VA = "0x185E035C0")]
			public LMEJNHOOGDB(NLHOOGKAONG CAMMLDAMHLP, GameObject BOBHLPHMDLM, RenderTexture FOPBKILMOKB, ImposterRenderConfig FEDFDJEMJPP, LFDGMEDEAOJ ALCBLHCHOIH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static MBBCDDLAPMP<LMEJNHOOGDB, RenderTexture> OBNCFLDPLHP;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly List<LMEJNHOOGDB> AGLMBBCPIJN;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int CDJKPAINGAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5E00850", Offset = "0x5DFF850", VA = "0x185E00850")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5E00B00", Offset = "0x5DFFB00", VA = "0x185E00B00")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject KDAMENAKJJL, RenderTexture FOPBKILMOKB, ImposterRenderConfig KHMHOMPAGOM, LFDGMEDEAOJ ALCBLHCHOIH, CancellationToken JEBPNJAPHEL, bool NFICJCAICEG = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5E00660", Offset = "0x5DFF660", VA = "0x185E00660", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5E00A60", Offset = "0x5DFFA60", VA = "0x185E00A60", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5E008C0", Offset = "0x5DFF8C0", VA = "0x185E008C0")]
		private static Task<RenderTexture> LOAFLCEENLM(LMEJNHOOGDB HAAMKIPOJAD, CancellationToken JEBPNJAPHEL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5E00F20", Offset = "0x5DFFF20", VA = "0x185E00F20")]
		public DeferredImposterRenderer()
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
