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
	private readonly struct DLLPIIIEEKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly ENIMPNMNCKA LMPHMOENLKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string BKMLLKACEBD;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAB1600", Offset = "0xAAFE00", VA = "0x180AB1600")]
		public DLLPIIIEEKJ(ENIMPNMNCKA LFFFFGABCMN, string HNFJBCFMDLN)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct GDHPLMIJKHG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public DLLPIIIEEKJ queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x68F8AC0", Offset = "0x68F72C0", VA = "0x1868F8AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x68F8E60", Offset = "0x68F7660", VA = "0x1868F8E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider IBMINJBFKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private LLNBPHOHMNO<DLLPIIIEEKJ, GameObject> FECCBBNONIC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public DJNGHJDKJGL AIEKMAMCBGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x852890", Offset = "0x851090", VA = "0x180852890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private LLNBPHOHMNO<DLLPIIIEEKJ, GameObject> GNCABEBFCAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x68F7CF0", Offset = "0x68F64F0", VA = "0x1868F7CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int KIGBCLCJABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x68F7F70", Offset = "0x68F6770", VA = "0x1868F7F70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68F7C30", Offset = "0x68F6430", VA = "0x1868F7C30", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x68F8190", Offset = "0x68F6990", VA = "0x1868F8190", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68F7E50", Offset = "0x68F6650", VA = "0x1868F7E50")]
	[AsyncStateMachine(typeof(GDHPLMIJKHG))]
	private Task<GameObject> GGGKPKFBMBF(DLLPIIIEEKJ OHPHHLFKEGH, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x68F7FC0", Offset = "0x68F67C0", VA = "0x1868F7FC0")]
	public Task<GameObject> LoadItemAsync(ENIMPNMNCKA LFFFFGABCMN, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x68F8200", Offset = "0x68F6A00", VA = "0x1868F8200")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class CGPKFJBFLBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public ENIMPNMNCKA ABABHNOPLBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture FILIFCKICEL;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x85F050", Offset = "0x85D850", VA = "0x18085F050")]
		public CGPKFJBFLBC(ENIMPNMNCKA HHAEKJNKJFG, Texture IPABEBMKKAM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum KAIJGJNJGCL
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
	private class GLMNBDJJABC : MDDCCCKDBFD<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct AJADCKDIMOI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public GLMNBDJJABC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x68F67F0", Offset = "0x68F4FF0", VA = "0x1868F67F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x68F6FF0", Offset = "0x68F57F0", VA = "0x1868F6FF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly ENIMPNMNCKA HHAEKJNKJFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture LHBPPPBOGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig IFAHGLHGPLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken MPLGBOFHPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject EGILDIFIBOP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override MAKKFMNHCEA<Texture> AOBKCEMGLKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x68F8FC0", Offset = "0x68F77C0", VA = "0x1868F8FC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> GJLNBAMLKBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855160", VA = "0x180856960", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x68F90B0", Offset = "0x68F78B0", VA = "0x1868F90B0")]
		public GLMNBDJJABC(ENIMPNMNCKA HHAEKJNKJFG, RenderTexture LHBPPPBOGCG, ImposterRenderConfig IFAHGLHGPLP, CancellationToken MPLGBOFHPLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x68F8ED0", Offset = "0x68F76D0", VA = "0x1868F8ED0")]
		[AsyncStateMachine(typeof(AJADCKDIMOI))]
		private Task<Texture> LKKJOIOIELO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x68F9020", Offset = "0x68F7820", VA = "0x1868F9020", Slot = "10")]
		protected override void MDIOCFABDCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68F9030", Offset = "0x68F7830", VA = "0x1868F9030")]
		private static void PMHDBJJGKBJ(GameObject EGILDIFIBOP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct EOAILNPEGPA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x68F8240", Offset = "0x68F6A40", VA = "0x1868F8240", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9EB410", Offset = "0x9E9C10", VA = "0x1809EB410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	[Tooltip("Texture shown when the imposter texture is not available")]
	[Header("General")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[CIHMDBDDPOM(LEHCEJJDOON.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private KAIJGJNJGCL size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[AHAGJGNEDIE("size", KAIJGJNJGCL.Custom)]
	[SerializeField]
	private int customSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	private int antiAliasing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[Tooltip("Configuration specifying render properties for the imposter")]
	[SerializeField]
	private ImposterRenderConfig imposterRenderConfig;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static int NDJEBFANHJC;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture GKHJCLFPDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private PHBOGIKMHKK<GameObject> DBDEHGFIJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private HBGKBCMOMOE ACOPLEOHKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource NPCICLIMLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private GBMNPHMLGKB<Texture> IMPACABBJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private ENIMPNMNCKA DKEKABJIDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture EBPDPKOMNFP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int LPNCFDFODJM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x68FA1F0", Offset = "0x68F89F0", VA = "0x1868FA1F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x68FA240", Offset = "0x68F8A40", VA = "0x1868FA240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture CAELAKPOIKK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x68F9A60", Offset = "0x68F8260", VA = "0x1868F9A60")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x856AA0", Offset = "0x8552A0", VA = "0x180856AA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private ENIMPNMNCKA ABABHNOPLBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x856A90", Offset = "0x855290", VA = "0x180856A90")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x68F97C0", Offset = "0x68F7FC0", VA = "0x1868F97C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool DNOMKCPEEHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1587ED0", Offset = "0x15866D0", VA = "0x181587ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int MIFGMBBNMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x68F9D20", Offset = "0x68F8520", VA = "0x1868F9D20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x68F97B0", Offset = "0x68F7FB0", VA = "0x1868F97B0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x68F9DC0", Offset = "0x68F85C0", VA = "0x1868F9DC0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x68F9920", Offset = "0x68F8120", VA = "0x1868F9920")]
	private void BKFEOLJCBIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68FA0D0", Offset = "0x68F88D0", VA = "0x1868FA0D0")]
	public void Set(ENIMPNMNCKA OKNKGNFBBAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x68FA0C0", Offset = "0x68F88C0", VA = "0x1868FA0C0")]
	public void Set(Texture IPABEBMKKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x68FA0E0", Offset = "0x68F88E0", VA = "0x1868FA0E0")]
	public void Set(CGPKFJBFLBC JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x68F99A0", Offset = "0x68F81A0", VA = "0x1868F99A0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x68F9EC0", Offset = "0x68F86C0", VA = "0x1868F9EC0")]
	public void SetInternal(ENIMPNMNCKA OKNKGNFBBAK, [Optional] Texture OANBBHLCBEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x68F9EB0", Offset = "0x68F86B0", VA = "0x1868F9EB0")]
	public void SetCustomSize(int EDABBBOIFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x858FB0", Offset = "0x8577B0", VA = "0x180858FB0")]
	public void SetAntiAliasing(int AIANMDPGLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x68F99B0", Offset = "0x68F81B0", VA = "0x1868F99B0")]
	[AsyncStateMachine(typeof(EOAILNPEGPA))]
	private void FHDOIKFEJMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68F9C40", Offset = "0x68F8440", VA = "0x1868F9C40")]
	private void HLLBKMGPDDL(Texture IPABEBMKKAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x68FA170", Offset = "0x68F8970", VA = "0x1868FA170")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, EKLLAADFCPH
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float NNAJOEMFFND = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "4")]
	public void PrepareImposter(OBAPJMOCHBF LDMPLMIKDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x68F9770", Offset = "0x68F7F70", VA = "0x1868F9770")]
	public void SetReferencePoint(Vector3 NJGBBMKGAPK, Quaternion IJKPBDDGPGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x68F9570", Offset = "0x68F7D70", VA = "0x1868F9570")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x68F9750", Offset = "0x68F7F50", VA = "0x1868F9750")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x15F7090", Offset = "0x15F5890", VA = "0x1815F7090")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct DKBNIECPPOH
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static DKBNIECPPOH DLGENOFLPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float CCCKNIBDDMI;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x216D9B0", Offset = "0x216C1B0", VA = "0x18216D9B0")]
	public DKBNIECPPOH(float MIOGALGFKIB)
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
		[CIHMDBDDPOM(LEHCEJJDOON.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int MLCCGIKGFDJ = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int IGCOANGMCKP = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> KFIPHENHOPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool KDLPLBHOAEM;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x68FA450", Offset = "0x68F8C50", VA = "0x1868FA450")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x68FA350", Offset = "0x68F8B50", VA = "0x1868FA350")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x68FA6A0", Offset = "0x68F8EA0", VA = "0x1868FA6A0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ENIMPNMNCKA
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string OFHFAAMHODN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	DKBNIECPPOH DKBNIECPPOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action GACBJEDPEKF;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> AKHMACILMGM(CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MFANNBJAAHE(ENIMPNMNCKA OKGBBGMIACH);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BAOCNENGLLG();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NNIJGGCIFAO();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool EEBEFPOEMMF([Out] GBMNPHMLGKB<Texture> GJEEGDPJOGP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DNIAFOCLMCD
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x68F71F0", Offset = "0x68F59F0", VA = "0x1868F71F0")]
	public static bool ILKJEKAFIKL(ENIMPNMNCKA DPIMACKCMGA, ENIMPNMNCKA CLFCMEGFGPG)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, EKLLAADFCPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x68F7060", Offset = "0x68F5860", VA = "0x1868F7060", Slot = "4")]
		public void PrepareImposter(OBAPJMOCHBF LDMPLMIKDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852A80", VA = "0x180854280")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852A80", VA = "0x180854280")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface EKLLAADFCPH
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(OBAPJMOCHBF LDMPLMIKDPA);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NPAHAACKBKN
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> GJPNHAGHKOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> BOFNCDHMFPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface DJNGHJDKJGL
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LCIAGPCBPJH(params Type[] DGLFPPDJICE);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject OEEBGIHKACK(GameObject OGCFILPLNFJ, Transform BMBBFJPOJEB, bool MAHGNEOOKFI = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T OEEBGIHKACK<T>(T OGCFILPLNFJ, Transform BMBBFJPOJEB, bool MAHGNEOOKFI = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T OEEBGIHKACK<T>(GameObject OGCFILPLNFJ, Transform BMBBFJPOJEB, bool MAHGNEOOKFI = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject OEEBGIHKACK(GameObject OGCFILPLNFJ, Transform BMBBFJPOJEB, OBAPJMOCHBF LDMPLMIKDPA, bool MAHGNEOOKFI);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MAAAKMJNOHF : IDisposable, DJNGHJDKJGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> KOLIPBCLMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> GIBGJCJEHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform OCAMCONODBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> KFILKGPGMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> EMNGECJENBE;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x68FA950", Offset = "0x68F9150", VA = "0x1868FA950")]
	[GDGALFJPCGE(JMIPDAHBNNG.None)]
	public static void ECBJKBNABGH(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x68FB1F0", Offset = "0x68F99F0", VA = "0x1868FB1F0")]
	[Preserve]
	public MAAAKMJNOHF([OMAPKKAGFIL(null)] NPAHAACKBKN MHMFIDMMKMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x68FA870", Offset = "0x68F9070", VA = "0x1868FA870", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x68FAF10", Offset = "0x68F9710", VA = "0x1868FAF10", Slot = "5")]
	public void LCIAGPCBPJH(params Type[] DGLFPPDJICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x68FAF60", Offset = "0x68F9760", VA = "0x1868FAF60", Slot = "6")]
	public GameObject OEEBGIHKACK(GameObject OGCFILPLNFJ, Transform BMBBFJPOJEB, bool MAHGNEOOKFI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2C1AB60", Offset = "0x2C19360", VA = "0x182C1AB60", Slot = "7")]
	public T OEEBGIHKACK<T>(T OGCFILPLNFJ, Transform BMBBFJPOJEB, bool MAHGNEOOKFI = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2C1B1E0", Offset = "0x2C199E0", VA = "0x182C1B1E0", Slot = "8")]
	public T OEEBGIHKACK<T>(GameObject OGCFILPLNFJ, Transform BMBBFJPOJEB, bool MAHGNEOOKFI = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x68FAFF0", Offset = "0x68F97F0", VA = "0x1868FAFF0", Slot = "9")]
	public GameObject OEEBGIHKACK(GameObject OGCFILPLNFJ, Transform BMBBFJPOJEB, OBAPJMOCHBF LDMPLMIKDPA, bool MAHGNEOOKFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2C1AB00", Offset = "0x2C19300", VA = "0x182C1AB00", Slot = "10")]
	public T OEEBGIHKACK<T>(GameObject OGCFILPLNFJ, Transform BMBBFJPOJEB, OBAPJMOCHBF LDMPLMIKDPA, bool MAHGNEOOKFI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2C1ABF0", Offset = "0x2C193F0", VA = "0x182C1ABF0")]
	private T OEEBGIHKACK<T>(GameObject OGCFILPLNFJ, Transform BMBBFJPOJEB, OBAPJMOCHBF LDMPLMIKDPA, bool MAHGNEOOKFI, [Out] GameObject GKANFBOFLDD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2C1A5A0", Offset = "0x2C18DA0", VA = "0x182C1A5A0")]
	private T MGLHIMAPEJE<T>(GameObject NBDLDMDNCAL, OBAPJMOCHBF LDMPLMIKDPA, bool MAHGNEOOKFI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x68FA760", Offset = "0x68F8F60", VA = "0x1868FA760")]
	private void ABOFNDBDOJJ(Component INPAFGCEBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x68FAA50", Offset = "0x68F9250", VA = "0x1868FAA50")]
	private void GAIFAKNIAGF(Component INPAFGCEBHH, OBAPJMOCHBF LDMPLMIKDPA, bool MAHGNEOOKFI, bool GGGFCFBOCPE, [Optional] Type IKEFIEELPJA, [Optional] Type LKNDGJOLLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x68FB080", Offset = "0x68F9880", VA = "0x1868FB080")]
	private void OPKLMBJDKFK(GameObject NBDLDMDNCAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct OBAPJMOCHBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> PMFAKBLHCLK;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2CAF240", Offset = "0x2CADA40", VA = "0x182CAF240")]
	public OBAPJMOCHBF OLOHHMDPKEO<T>(T DCPJLNEPGKC)
	{
		return default(OBAPJMOCHBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2CAF130", Offset = "0x2CAD930", VA = "0x182CAF130")]
	public T JMJOGDIBBHK<T>(T LIAHLPBCKNO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2CAE950", Offset = "0x2CAD150", VA = "0x182CAE950")]
	public bool FFKNBABIJFJ<T>([Out] T DCPJLNEPGKC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct ALLNLILKFED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool KOLIPAPDGLK;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x216D990", Offset = "0x216C190", VA = "0x18216D990")]
	public ALLNLILKFED(bool PCAMCMACDJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct FCDLHIEALBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool NKKKCJAADKH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x68F8A40", Offset = "0x68F7240", VA = "0x1868F8A40")]
	public FCDLHIEALBI(bool BLFOMPKAMGE)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852A80", VA = "0x180854280")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, EKLLAADFCPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x68FDCA0", Offset = "0x68FC4A0", VA = "0x1868FDCA0", Slot = "4")]
		public void PrepareImposter(OBAPJMOCHBF LDMPLMIKDPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852A80", VA = "0x180854280")]
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
		public Bounds POJGNIALDKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x68F93E0", Offset = "0x68F7BE0", VA = "0x1868F93E0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x68F93A0", Offset = "0x68F7BA0", VA = "0x1868F93A0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x68F9360", Offset = "0x68F7B60", VA = "0x1868F9360")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x68F9270", Offset = "0x68F7A70", VA = "0x1868F9270")]
		private void IEDINMOGHGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852A80", VA = "0x180854280")]
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
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			[Range(0.1f, 10f)]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600006A")]
				[Cpp2IlInjected.Address(RVA = "0x68FA740", Offset = "0x68F8F40", VA = "0x1868FA740")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x68FA730", Offset = "0x68F8F30", VA = "0x1868FA730")]
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
		public float cameraOffsetMaxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[ColorUsage(false, true)]
		[Header("Environment Lighting")]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[HideInInspector]
		public bool useExplicitCameraComposition;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[HideInInspector]
		public Vector3 explicitCameraPositionOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[HideInInspector]
		public Quaternion explicitCameraRotationOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[HideInInspector]
		public float explicitCameraOrthographicSize;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x68FA2C0", Offset = "0x68F8AC0", VA = "0x1868FA2C0")]
		public void MAALOMOBCFK(Vector3 NEPAJBPGFBJ, Quaternion HJOKGKGAMMH, float PHNNFIHLMAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x68FA2F0", Offset = "0x68F8AF0", VA = "0x1868FA2F0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class OFHMOHECKOD
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly Vector3 IDJENEILIJA;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly List<URPLight> LIPGODGABDO;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<Light> POKEIJIHOEP;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Camera CHCHOJAEEDI;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<Renderer> HIKOAPNJLGJ;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<ImposterBoundsOverride> ENILEKGDNBB;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static AmbientMode LBCJJMFDEKM;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static Color HIJEEJBNINA;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color HLOGDCCHCDF;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color PIMDJBCOKHI;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Cubemap IDKBCLFBOFN;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static bool EFELNGHMLAC;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> KBAIKHJPALG
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x68FC3B0", Offset = "0x68FABB0", VA = "0x1868FC3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> PHOIGFCPEIN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x68FDA20", Offset = "0x68FC220", VA = "0x1868FDA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera LOBNLKGCLDH
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x68FD530", Offset = "0x68FBD30", VA = "0x1868FD530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x68FD780", Offset = "0x68FBF80", VA = "0x1868FD780")]
	public static void MPKGPELMAFI(Vector3 CJFHJHPMOOL, Quaternion ENGOJMNMCKD, ImposterRenderConfig DCBGILCCPFH, bool GCMCLBCMJEB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x68FBF90", Offset = "0x68FA790", VA = "0x1868FBF90")]
	private static void DBKGGGEGLMO(Vector3 CJFHJHPMOOL, Quaternion ENGOJMNMCKD, URPLight IDHIHINLIAM, ImposterRenderConfig.LightConfig GPNACIMONOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x68FD450", Offset = "0x68FBC50", VA = "0x1868FD450")]
	public static void JIKIFNBAGPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x68FC810", Offset = "0x68FB010", VA = "0x1868FC810")]
	private static void HCAIINAJHHM(int HOGPCLHDNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x68FCC40", Offset = "0x68FB440", VA = "0x1868FCC40")]
	public static void HCGIOGALCGI(ImposterRenderConfig DCBGILCCPFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x68FC2C0", Offset = "0x68FAAC0", VA = "0x1868FC2C0")]
	public static void ECLAOBAMFMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x68FC4D0", Offset = "0x68FACD0", VA = "0x1868FC4D0")]
	public static void GEBMMJLHPNE(GameObject ABOBFGIKPEE, RenderTexture LHBPPPBOGCG, ImposterRenderConfig DCBGILCCPFH, DKBNIECPPOH LONAIJJDHNG, [Optional] Vector3? EBIOECFLNIB, [Optional] Vector3? DGGLPGMIGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x68FCE00", Offset = "0x68FB600", VA = "0x1868FCE00")]
	private static void JFKKBJJDGHE(GameObject ABOBFGIKPEE, RenderTexture LHBPPPBOGCG, ImposterRenderConfig DCBGILCCPFH, DKBNIECPPOH LONAIJJDHNG, Vector3 EBIOECFLNIB, Vector3 DGGLPGMIGGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x68FBCA0", Offset = "0x68FA4A0", VA = "0x1868FBCA0")]
	private static void ALPGLCPAODI(GameObject ABOBFGIKPEE, Vector3 OCDEKNFLBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x68FB630", Offset = "0x68F9E30", VA = "0x1868FB630")]
	private static void AFOLCNBDNEH(GameObject OGCFILPLNFJ, ImposterRenderConfig DCBGILCCPFH, DKBNIECPPOH LONAIJJDHNG, [Out] Vector3 DPKEOGLOINP, [Out] Quaternion CLDPBHHHGMN, [Out] float HHNMBGADJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x68FC400", Offset = "0x68FAC00", VA = "0x1868FC400")]
	public static RenderTexture EMEFKGCCBLH(int FNKAMPFNBJB, int IJAJOPPBLCP, RenderTextureFormat BGOCEECJDJL = RenderTextureFormat.ARGB32, string AIDGLECBAHJ = "[ImposterRendering]Preview")
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
		public struct FPPCOHNBCOA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CNPNGJHMILJ HBIKLDFHJPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public GameObject FKAIKAALJHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public RenderTexture CAELAKPOIKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public ImposterRenderConfig NAKALJBEMIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public DKBNIECPPOH DKBNIECPPOH;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x68F8A50", Offset = "0x68F7250", VA = "0x1868F8A50")]
			public FPPCOHNBCOA(CNPNGJHMILJ KEGEDGBLGGL, GameObject MJCPOBGFMHM, RenderTexture LHBPPPBOGCG, ImposterRenderConfig IFAHGLHGPLP, DKBNIECPPOH LONAIJJDHNG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static LLNBPHOHMNO<FPPCOHNBCOA, RenderTexture> MOLDEJGFINM;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly List<FPPCOHNBCOA> AHBCKHEGDLN;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int IBPIPHCLDNE
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x68F74D0", Offset = "0x68F5CD0", VA = "0x1868F74D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x68F77D0", Offset = "0x68F5FD0", VA = "0x1868F77D0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject ABOBFGIKPEE, RenderTexture LHBPPPBOGCG, ImposterRenderConfig DCBGILCCPFH, DKBNIECPPOH LONAIJJDHNG, CancellationToken MPLGBOFHPLM, bool NIDGNKHECHL = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x68F72E0", Offset = "0x68F5AE0", VA = "0x1868F72E0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x68F7730", Offset = "0x68F5F30", VA = "0x1868F7730", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x68F7540", Offset = "0x68F5D40", VA = "0x1868F7540")]
		private static Task<RenderTexture> OPCPKFLHDBE(FPPCOHNBCOA GELJBOGFANH, CancellationToken MPLGBOFHPLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x68F7BF0", Offset = "0x68F63F0", VA = "0x1868F7BF0")]
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
