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
	private readonly struct HPBLANEGMAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly EBMFGAPBAPI BJJPFMEJDOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string DKCABFIGINA;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA93C90", Offset = "0xA92890", VA = "0x180A93C90")]
		public HPBLANEGMAE(EBMFGAPBAPI HOONFAMCPBB, string FCOBEKIDIGM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct PNMHLJDBCMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public HPBLANEGMAE queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x68F70D0", Offset = "0x68F5CD0", VA = "0x1868F70D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x68F7470", Offset = "0x68F6070", VA = "0x1868F7470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider MMECCLPIILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private MNNNHMPELMA<HPBLANEGMAE, GameObject> GBPCBLKOEMF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FIEFLPKDNED POHLCONJPIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x843330", Offset = "0x841F30", VA = "0x180843330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private MNNNHMPELMA<HPBLANEGMAE, GameObject> KJKMAIDEOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x68F36B0", Offset = "0x68F22B0", VA = "0x1868F36B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int FKPDIJJABIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x68F3420", Offset = "0x68F2020", VA = "0x1868F3420")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68F3240", Offset = "0x68F1E40", VA = "0x1868F3240", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x68F3640", Offset = "0x68F2240", VA = "0x1868F3640", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68F3300", Offset = "0x68F1F00", VA = "0x1868F3300")]
	[AsyncStateMachine(typeof(PNMHLJDBCMP))]
	private Task<GameObject> JFKAOCCECDP(HPBLANEGMAE AFOCOIGIJKG, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x68F3470", Offset = "0x68F2070", VA = "0x1868F3470")]
	public Task<GameObject> LoadItemAsync(EBMFGAPBAPI HOONFAMCPBB, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x68F3810", Offset = "0x68F2410", VA = "0x1868F3810")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class LDIBCGEMJHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public EBMFGAPBAPI GCFCONBFGHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture HMCCANAJOCB;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8503D0", Offset = "0x84EFD0", VA = "0x1808503D0")]
		public LDIBCGEMJHA(EBMFGAPBAPI DABEFJPGIOO, Texture BHCOMKIMBKF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum HONBMADIBGK
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
	private class IPLMDNOBPPD : OOLEBKHFHKL<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct PJLCANJGABL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public IPLMDNOBPPD <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x68F6860", Offset = "0x68F5460", VA = "0x1868F6860", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x68F7060", Offset = "0x68F5C60", VA = "0x1868F7060", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly EBMFGAPBAPI DABEFJPGIOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture BLEEEMPLKKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig HKINIEGGNHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken MPLCHGMFENA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject MHCKPPEKCFK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override NDHCMKMDIDG<Texture> PBELOHMCGHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x68F3A40", Offset = "0x68F2640", VA = "0x1868F3A40", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> JEAFLJMJAPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x843220", Offset = "0x841E20", VA = "0x180843220", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x68F3AA0", Offset = "0x68F26A0", VA = "0x1868F3AA0")]
		public IPLMDNOBPPD(EBMFGAPBAPI DABEFJPGIOO, RenderTexture BLEEEMPLKKI, ImposterRenderConfig HKINIEGGNHF, CancellationToken MPLCHGMFENA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x68F38D0", Offset = "0x68F24D0", VA = "0x1868F38D0")]
		[AsyncStateMachine(typeof(PJLCANJGABL))]
		private Task<Texture> JLEIMNCMDBF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x68F38C0", Offset = "0x68F24C0", VA = "0x1868F38C0", Slot = "10")]
		protected override void JCJBLJHFBNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68F39C0", Offset = "0x68F25C0", VA = "0x1868F39C0")]
		private static void OGMMKKLIIAB(GameObject MHCKPPEKCFK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct LIFLKFEEMAC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x68F5FF0", Offset = "0x68F4BF0", VA = "0x1868F5FF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9DD860", Offset = "0x9DC460", VA = "0x1809DD860", Slot = "5")]
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
	[HHMHLCBPJEC(LBBGAALIOCK.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private HONBMADIBGK size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[GMAEJEFPPFN("size", HONBMADIBGK.Custom)]
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
	private static int BDMLOCOBBJK;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture MFMNKCDNDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private IHOBMNIOBJJ<GameObject> JBMFNLPJFDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private LKPPGGKMHON HFPMNLONBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource BMBBMOBAEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private OBOGMAPJNLF<Texture> JFDHMBIHJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private EBMFGAPBAPI AKKGPNEDMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture LCDIOCNALMI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int DIDFAALGJBG
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x68F4BE0", Offset = "0x68F37E0", VA = "0x1868F4BE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x68F4C30", Offset = "0x68F3830", VA = "0x1868F4C30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture HGGGLFEKFGG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x68F41B0", Offset = "0x68F2DB0", VA = "0x1868F41B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x843230", Offset = "0x841E30", VA = "0x180843230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private EBMFGAPBAPI GCFCONBFGHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8432E0", Offset = "0x841EE0", VA = "0x1808432E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x68F45D0", Offset = "0x68F31D0", VA = "0x1868F45D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool CHHNJLLLNMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x156A980", Offset = "0x1569580", VA = "0x18156A980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int OKEDIMNDGAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x68F4480", Offset = "0x68F3080", VA = "0x1868F4480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x68F41A0", Offset = "0x68F2DA0", VA = "0x1868F41A0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x68F47B0", Offset = "0x68F33B0", VA = "0x1868F47B0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x68F4730", Offset = "0x68F3330", VA = "0x1868F4730")]
	private void NIDDFKPNEAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68F4AC0", Offset = "0x68F36C0", VA = "0x1868F4AC0")]
	public void Set(EBMFGAPBAPI DGFPOPHIPIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x68F4AB0", Offset = "0x68F36B0", VA = "0x1868F4AB0")]
	public void Set(Texture BHCOMKIMBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x68F4AD0", Offset = "0x68F36D0", VA = "0x1868F4AD0")]
	public void Set(LDIBCGEMJHA GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x68F4390", Offset = "0x68F2F90", VA = "0x1868F4390")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x68F48B0", Offset = "0x68F34B0", VA = "0x1868F48B0")]
	public void SetInternal(EBMFGAPBAPI DGFPOPHIPIN, [Optional] Texture DCCMMJCJEFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x68F48A0", Offset = "0x68F34A0", VA = "0x1868F48A0")]
	public void SetCustomSize(int FKNLMPJJCMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x84B8D0", Offset = "0x84A4D0", VA = "0x18084B8D0")]
	public void SetAntiAliasing(int DCGINALMBFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x68F4520", Offset = "0x68F3120", VA = "0x1868F4520")]
	[AsyncStateMachine(typeof(LIFLKFEEMAC))]
	private void FILJIIKPPAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68F43A0", Offset = "0x68F2FA0", VA = "0x1868F43A0")]
	private void DHBNJIJOHEH(Texture BHCOMKIMBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x68F4B60", Offset = "0x68F3760", VA = "0x1868F4B60")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, FGAPLKONGHE
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float DFPCGDDEIGK = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "4")]
	public void PrepareImposter(FNMOFGMGHOD ENFOCCMDNKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x68F4160", Offset = "0x68F2D60", VA = "0x1868F4160")]
	public void SetReferencePoint(Vector3 FKKCBKBCNEL, Quaternion MFHPKPAOAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x68F3F60", Offset = "0x68F2B60", VA = "0x1868F3F60")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x68F4140", Offset = "0x68F2D40", VA = "0x1868F4140")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x15DE800", Offset = "0x15DD400", VA = "0x1815DE800")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct NJHLGKINPPP
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static NJHLGKINPPP MFDKFFEGHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float OCKANGCIIKJ;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x21469F0", Offset = "0x21455F0", VA = "0x1821469F0")]
	public NJHLGKINPPP(float OBLLDOINOOE)
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
		[HHMHLCBPJEC(LBBGAALIOCK.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int FDMECIKFBAK = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int AOLPLMHCAIK = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> GAEMPNJHOHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool CBGMPBDOLGP;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x68F4E40", Offset = "0x68F3A40", VA = "0x1868F4E40")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x68F4D40", Offset = "0x68F3940", VA = "0x1868F4D40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x68F5090", Offset = "0x68F3C90", VA = "0x1868F5090")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EBMFGAPBAPI
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string NIHBCBEIOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	NJHLGKINPPP NJHLGKINPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action KCGCKDBNEEG;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> KNMHHCJOIFJ(CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JKCMFHCJCFJ(EBMFGAPBAPI OCNJFCPHJLD);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AJBNKCDBONL();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GDLCGOPBEOP();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ILKIEGMPJDL([Out] OBOGMAPJNLF<Texture> ADCLAICHCJA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BFLDBGONBAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x68F0040", Offset = "0x68EEC40", VA = "0x1868F0040")]
	public static bool PELNDFIFLOD(EBMFGAPBAPI JCHABLAGODJ, EBMFGAPBAPI BHPMNFCCPAA)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, FGAPLKONGHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x68F27A0", Offset = "0x68F13A0", VA = "0x1868F27A0", Slot = "4")]
		public void PrepareImposter(FNMOFGMGHOD ENFOCCMDNKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x846CB0", Offset = "0x8458B0", VA = "0x180846CB0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x846CB0", Offset = "0x8458B0", VA = "0x180846CB0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FGAPLKONGHE
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(FNMOFGMGHOD ENFOCCMDNKP);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface HGHHFHGGCJK
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> HCDANAFKKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> BHGBLCHGMCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FIEFLPKDNED
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EDEHGMMFBOC(params Type[] IIHAEOJGBKP);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject KFOKJCPOMKI(GameObject ICDGFAMNJCJ, Transform GPMGJNAOOEP, bool AJOKEIOPLOJ = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T KFOKJCPOMKI<T>(T ICDGFAMNJCJ, Transform GPMGJNAOOEP, bool AJOKEIOPLOJ = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T KFOKJCPOMKI<T>(GameObject ICDGFAMNJCJ, Transform GPMGJNAOOEP, bool AJOKEIOPLOJ = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject KFOKJCPOMKI(GameObject ICDGFAMNJCJ, Transform GPMGJNAOOEP, FNMOFGMGHOD ENFOCCMDNKP, bool AJOKEIOPLOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JNNALACJNOE : IDisposable, FIEFLPKDNED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> MFIOBHJAFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> PJLAMAJPCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform HECLIOKIGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> NEJIFLCMEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> DOAJDGPLGPP;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x68F5710", Offset = "0x68F4310", VA = "0x1868F5710")]
	[FJJFAIMPJIC(JBEKPLNNIEC.None)]
	public static void GBNHEMCAJHC(LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x68F5BA0", Offset = "0x68F47A0", VA = "0x1868F5BA0")]
	[Preserve]
	public JNNALACJNOE([GOICEJLKLIB(null)] HGHHFHGGCJK LMHNDEPFBPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x68F5120", Offset = "0x68F3D20", VA = "0x1868F5120", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x68F5200", Offset = "0x68F3E00", VA = "0x1868F5200", Slot = "5")]
	public void EDEHGMMFBOC(params Type[] IIHAEOJGBKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x68F5B10", Offset = "0x68F4710", VA = "0x1868F5B10", Slot = "6")]
	public GameObject KFOKJCPOMKI(GameObject ICDGFAMNJCJ, Transform GPMGJNAOOEP, bool AJOKEIOPLOJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0210", Offset = "0x2B9EE10", VA = "0x182BA0210", Slot = "7")]
	public T KFOKJCPOMKI<T>(T ICDGFAMNJCJ, Transform GPMGJNAOOEP, bool AJOKEIOPLOJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2BA0300", Offset = "0x2B9EF00", VA = "0x182BA0300", Slot = "8")]
	public T KFOKJCPOMKI<T>(GameObject ICDGFAMNJCJ, Transform GPMGJNAOOEP, bool AJOKEIOPLOJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x68F5A80", Offset = "0x68F4680", VA = "0x1868F5A80", Slot = "9")]
	public GameObject KFOKJCPOMKI(GameObject ICDGFAMNJCJ, Transform GPMGJNAOOEP, FNMOFGMGHOD ENFOCCMDNKP, bool AJOKEIOPLOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2BA02A0", Offset = "0x2B9EEA0", VA = "0x182BA02A0", Slot = "10")]
	public T KFOKJCPOMKI<T>(GameObject ICDGFAMNJCJ, Transform GPMGJNAOOEP, FNMOFGMGHOD ENFOCCMDNKP, bool AJOKEIOPLOJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x2B9FC90", Offset = "0x2B9E890", VA = "0x182B9FC90")]
	private T KFOKJCPOMKI<T>(GameObject ICDGFAMNJCJ, Transform GPMGJNAOOEP, FNMOFGMGHOD ENFOCCMDNKP, bool AJOKEIOPLOJ, [Out] GameObject CCKAHMDFKHG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2B9F7F0", Offset = "0x2B9E3F0", VA = "0x182B9F7F0")]
	private T ACMAOMNNNJP<T>(GameObject OLFFLDPKCIP, FNMOFGMGHOD ENFOCCMDNKP, bool AJOKEIOPLOJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x68F5800", Offset = "0x68F4400", VA = "0x1868F5800")]
	private void GCJAKJNGINF(Component KDODEFMCLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x68F5250", Offset = "0x68F3E50", VA = "0x1868F5250")]
	private void FBGLNPLOEIO(Component KDODEFMCLKH, FNMOFGMGHOD ENFOCCMDNKP, bool AJOKEIOPLOJ, bool IMADPACOEMN, [Optional] Type GHMOAPEAKNH, [Optional] Type GPNOLIPLBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x68F5910", Offset = "0x68F4510", VA = "0x1868F5910")]
	private void IKONEMEFMBA(GameObject OLFFLDPKCIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct FNMOFGMGHOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> FIKFGCACGJE;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2AF83A0", Offset = "0x2AF6FA0", VA = "0x182AF83A0")]
	public FNMOFGMGHOD CBGDEMCKLAL<T>(T DNBOMFAEEGH)
	{
		return default(FNMOFGMGHOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2AF8AD0", Offset = "0x2AF76D0", VA = "0x182AF8AD0")]
	public T HCNFCFFAFEI<T>(T NJMAFDCOBGL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2AF8BE0", Offset = "0x2AF77E0", VA = "0x182AF8BE0")]
	public bool KEKFKPJEKCC<T>([Out] T DNBOMFAEEGH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct NKFONLHIGOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool GOKOCCIDFCM;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xE21B70", Offset = "0xE20770", VA = "0x180E21B70")]
	public NKFONLHIGOL(bool AAPDNLMCDFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct LAMIBDGIIJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool MGGHDPFIBCD;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x68F5FE0", Offset = "0x68F4BE0", VA = "0x1868F5FE0")]
	public LAMIBDGIIJA(bool ECLMFFPDEDO)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x846CB0", Offset = "0x8458B0", VA = "0x180846CB0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, FGAPLKONGHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x68F74E0", Offset = "0x68F60E0", VA = "0x1868F74E0", Slot = "4")]
		public void PrepareImposter(FNMOFGMGHOD ENFOCCMDNKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x846CB0", Offset = "0x8458B0", VA = "0x180846CB0")]
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
		public Bounds PIELLLKAELA
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x68F3DD0", Offset = "0x68F29D0", VA = "0x1868F3DD0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x68F3D90", Offset = "0x68F2990", VA = "0x1868F3D90")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x68F3D50", Offset = "0x68F2950", VA = "0x1868F3D50")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x68F3C60", Offset = "0x68F2860", VA = "0x1868F3C60")]
		private void BFHENAKALGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x846CB0", Offset = "0x8458B0", VA = "0x180846CB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x68F6800", Offset = "0x68F5400", VA = "0x1868F6800")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x68F67F0", Offset = "0x68F53F0", VA = "0x1868F67F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x68F4CB0", Offset = "0x68F38B0", VA = "0x1868F4CB0")]
		public void FFAADOOGCNP(Vector3 KALBBOPGHPI, Quaternion AGNEHCPJLIA, float COLINBLCBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x68F4CE0", Offset = "0x68F38E0", VA = "0x1868F4CE0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class BMPIAKKGINN
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly Vector3 LAGHANLDJPM;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly List<URPLight> CHPOCNDAEFB;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<Light> MNJGPNHKFCH;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Camera HFIGDLPNGGO;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<Renderer> PFHMJLLGNPO;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<ImposterBoundsOverride> DOBOHDDKPBP;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static AmbientMode DHPEOKKELFD;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static Color GLKOPAKBAII;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color LFAHBDJPMKA;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color AJPHFKMBGLI;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Cubemap ALPJDGLEKNC;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static bool AEJONOCPKEF;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> IFOKMPFDEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x68F15D0", Offset = "0x68F01D0", VA = "0x1868F15D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> DMPEILEFPHB
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x68F0A90", Offset = "0x68EF690", VA = "0x1868F0A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera HCOLFHBKGBB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x68F1D40", Offset = "0x68F0940", VA = "0x1868F1D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x68F0E10", Offset = "0x68EFA10", VA = "0x1868F0E10")]
	public static void FEGHDCFOCMI(Vector3 CJFELCJIOGH, Quaternion PELGAEHDKOG, ImposterRenderConfig FFHCPCNGHIJ, bool LKDPCKEJJGF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x68F0AE0", Offset = "0x68EF6E0", VA = "0x1868F0AE0")]
	private static void DOFOCLOGEJN(Vector3 CJFELCJIOGH, Quaternion PELGAEHDKOG, URPLight PBAIOBJIHGF, ImposterRenderConfig.LightConfig HADKGNMFDHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x68F1F90", Offset = "0x68F0B90", VA = "0x1868F1F90")]
	public static void NFLFLNHOAKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x68F11A0", Offset = "0x68EFDA0", VA = "0x1868F11A0")]
	private static void HKAMPOIELJG(int COOEGOFAAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x68F2070", Offset = "0x68F0C70", VA = "0x1868F2070")]
	public static void NNGDEMDPCIP(ImposterRenderConfig FFHCPCNGHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x68F10B0", Offset = "0x68EFCB0", VA = "0x1868F10B0")]
	public static void GCHECJECCCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x68F2230", Offset = "0x68F0E30", VA = "0x1868F2230")]
	public static void PIFBDIFIONM(GameObject FMKHLDJNFIB, RenderTexture BLEEEMPLKKI, ImposterRenderConfig FFHCPCNGHIJ, NJHLGKINPPP CJGCFMLAAAE, [Optional] Vector3? FEFHPGNECIN, [Optional] Vector3? CKGMLJHOKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x68F1620", Offset = "0x68F0220", VA = "0x1868F1620")]
	private static void KAFIMJAHIEB(GameObject FMKHLDJNFIB, RenderTexture BLEEEMPLKKI, ImposterRenderConfig FFHCPCNGHIJ, NJHLGKINPPP CJGCFMLAAAE, Vector3 FEFHPGNECIN, Vector3 CKGMLJHOKOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x68F07A0", Offset = "0x68EF3A0", VA = "0x1868F07A0")]
	private static void AFKOOJFKNIM(GameObject FMKHLDJNFIB, Vector3 KHMOCIKFMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x68F0130", Offset = "0x68EED30", VA = "0x1868F0130")]
	private static void AENJABNEOCO(GameObject ICDGFAMNJCJ, ImposterRenderConfig FFHCPCNGHIJ, NJHLGKINPPP CJGCFMLAAAE, [Out] Vector3 IEHKMLHNKBG, [Out] Quaternion MGHECMANOJD, [Out] float OCKJCLENPNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x68F1C70", Offset = "0x68F0870", VA = "0x1868F1C70")]
	public static RenderTexture KFDKNNFFMGK(int CLIMOHDCDNO, int GDDDJAHAGIA, RenderTextureFormat KKEJAEKDBIN = RenderTextureFormat.ARGB32, string IDFFGKLFNDC = "[ImposterRendering]Preview")
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
		public struct GIFAOGNHMNG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public POMDOHCOGFA PGNNKKHNJGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public GameObject OAGJGFBALHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public RenderTexture HGGGLFEKFGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public ImposterRenderConfig ACMHOAEIHEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public NJHLGKINPPP NJHLGKINPPP;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x68F3850", Offset = "0x68F2450", VA = "0x1868F3850")]
			public GIFAOGNHMNG(POMDOHCOGFA PIPFPJFIAEF, GameObject DOJFDPJBFDB, RenderTexture BLEEEMPLKKI, ImposterRenderConfig HKINIEGGNHF, NJHLGKINPPP CJGCFMLAAAE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static MNNNHMPELMA<GIFAOGNHMNG, RenderTexture> PHNDAANFPKG;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly List<GIFAOGNHMNG> IIPPNHMJDGE;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int PLOAEPHLLJP
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x68F28F0", Offset = "0x68F14F0", VA = "0x1868F28F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x68F2DE0", Offset = "0x68F19E0", VA = "0x1868F2DE0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject FMKHLDJNFIB, RenderTexture BLEEEMPLKKI, ImposterRenderConfig FFHCPCNGHIJ, NJHLGKINPPP CJGCFMLAAAE, CancellationToken MPLCHGMFENA, bool HNJKCICOKFC = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x68F2B50", Offset = "0x68F1750", VA = "0x1868F2B50", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x68F2D40", Offset = "0x68F1940", VA = "0x1868F2D40", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x68F2960", Offset = "0x68F1560", VA = "0x1868F2960")]
		private static Task<RenderTexture> AKBKPHOHNBJ(GIFAOGNHMNG GGAPCJAEPBA, CancellationToken MPLCHGMFENA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x68F3200", Offset = "0x68F1E00", VA = "0x1868F3200")]
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
