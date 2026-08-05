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
public class ImposterPreviewCustomFraming : MonoBehaviour, HDEBGJDAOOP
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float NMJNBNAACCF = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "4")]
	public void PrepareImposter(DEMPFPLJFKJ BPFIFAEKGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x712A840", Offset = "0x7129840", VA = "0x18712A840")]
	public void SetReferencePoint(Vector3 KOFDECELOKC, Quaternion IHOLFEDLPLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x712A6B0", Offset = "0x71296B0", VA = "0x18712A6B0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x712A810", Offset = "0x7129810", VA = "0x18712A810")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x712A880", Offset = "0x7129880", VA = "0x18712A880")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class CGEHKMALJJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public NGDMJKHOENM DDPLFIAONIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly Texture JCPNEPKMAFJ;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xAEDF80", Offset = "0xAECF80", VA = "0x180AEDF80")]
		public CGEHKMALJJE(NGDMJKHOENM CDEEPPOAONO, Texture HCCFKEMJLAB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum NEGDGKBDPGE
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		Custom = 0,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		XS_128 = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		S_256 = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		M_512 = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		L_1024 = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		XL_2048 = 0x800
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private class MEBCIOALFDJ : ODMBHKBFLMB<Texture>, EEODJMNJAJN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class DBJLEDEKBJP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public MEBCIOALFDJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private GameObject <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public DBJLEDEKBJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7128E90", Offset = "0x7127E90", VA = "0x187128E90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly NGDMJKHOENM CDEEPPOAONO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly RenderTexture MJMBKADGEKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly ImposterRenderConfig JDJPBJLBOIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly CancellationToken OAGBBBCDIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private GameObject NNJLKLLCIOF;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private GAEMIFNLIHB COIDHFLHKPH
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x712B830", Offset = "0x712A830", VA = "0x18712B830", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IBHBGBJGJHP<Texture> IABNJDEAEMC
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x712B8D0", Offset = "0x712A8D0", VA = "0x18712B8D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Task ACPPNALHHAL
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9132C0", Offset = "0x9122C0", VA = "0x1809132C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Task<Texture> OMMAKDBEKBB
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x9132C0", Offset = "0x9122C0", VA = "0x1809132C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x712B920", Offset = "0x712A920", VA = "0x18712B920")]
		public MEBCIOALFDJ(NGDMJKHOENM CDEEPPOAONO, RenderTexture MJMBKADGEKP, ImposterRenderConfig JDJPBJLBOIK, CancellationToken OAGBBBCDIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x712B6D0", Offset = "0x712A6D0", VA = "0x18712B6D0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(DBJLEDEKBJP))]
		private Task<Texture> DAMMGHMIHIL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x712B820", Offset = "0x712A820", VA = "0x18712B820", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x712B840", Offset = "0x712A840", VA = "0x18712B840")]
		private static void LDCDMBJDHHP(GameObject NNJLKLLCIOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class MIHEKFKALLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Texture <initTexture>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Texture <texture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Texture <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Exception <ex>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<Texture> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public MIHEKFKALLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x712BAF0", Offset = "0x712AAF0", VA = "0x18712BAF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	[Header("General")]
	[Tooltip("Texture shown when the imposter texture is not available")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[SerializeField]
	[JHDFHPMJCIE(KDNNMHJGNJH.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private NEGDGKBDPGE size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	[OKAEPIMCOGM("size", 0)]
	[Tooltip("Custom pixel size for rendered imposter")]
	private int customSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[SerializeField]
	private int antiAliasing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[SerializeField]
	[Tooltip("Configuration specifying render properties for the imposter")]
	private ImposterRenderConfig imposterRenderConfig;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private RenderTexture EJJNOPLJCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private ELJHPGFEACM<GameObject> DENLMCHBAGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private BEKPINHCBFC HDHLLKJBJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private CancellationTokenSource IGGNLLGJDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private ODMBHKBFLMB<Texture> JKEIMDJKDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private NGDMJKHOENM HOALEOIOBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Texture HKJAGEBOJBL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private RenderTexture NAKCDECEEHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x712AB50", Offset = "0x7129B50", VA = "0x18712AB50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x914F70", Offset = "0x913F70", VA = "0x180914F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private NGDMJKHOENM DDPLFIAONIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x992280", Offset = "0x991280", VA = "0x180992280")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x712ACE0", Offset = "0x7129CE0", VA = "0x18712ACE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool PLOCNMMDIOL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x41F2830", Offset = "0x41F1830", VA = "0x1841F2830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int HPAPBLFHEJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x712AB40", Offset = "0x7129B40", VA = "0x18712AB40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x712A8C0", Offset = "0x71298C0", VA = "0x18712A8C0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x712AE30", Offset = "0x7129E30", VA = "0x18712AE30")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x712A8D0", Offset = "0x71298D0", VA = "0x18712A8D0")]
	private void BPLCKBLAKLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x712B190", Offset = "0x712A190", VA = "0x18712B190")]
	public void Set(NGDMJKHOENM MEBDMHGABHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x712B140", Offset = "0x712A140", VA = "0x18712B140")]
	public void Set(Texture HCCFKEMJLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x712B150", Offset = "0x712A150", VA = "0x18712B150")]
	public void Set(CGEHKMALJJE CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x712A960", Offset = "0x7129960", VA = "0x18712A960")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x712AF30", Offset = "0x7129F30", VA = "0x18712AF30")]
	public void SetInternal(NGDMJKHOENM MEBDMHGABHO, [Optional] Texture LKIDIEBONKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x712AF20", Offset = "0x7129F20", VA = "0x18712AF20")]
	public void SetCustomSize(int KGGICHLGMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xA49D20", Offset = "0xA48D20", VA = "0x180A49D20")]
	public void SetAntiAliasing(int CEGGIMMPFPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x712AA60", Offset = "0x7129A60", VA = "0x18712AA60")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MIHEKFKALLK))]
	private void HOAPNFDLIEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x712A970", Offset = "0x7129970", VA = "0x18712A970")]
	private void DBDEDEFGKMF(Texture HCCFKEMJLAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x712B1A0", Offset = "0x712A1A0", VA = "0x18712B1A0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct KOIDOEFKKDB
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static KOIDOEFKKDB AGNECIKBBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float BADHKOCIBBP;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x23588C0", Offset = "0x23578C0", VA = "0x1823588C0")]
	public KOIDOEFKKDB(float CMHDCHMKOMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DeferredImposterSpawnManager : SingletonMonoBehaviour<DeferredImposterSpawnManager>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private readonly struct HCGDLJHKGKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly NGDMJKHOENM DEEPGPGBAGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly string NLMFJPMHDOF;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA891D0", Offset = "0xA881D0", VA = "0x180A891D0")]
		public HCGDLJHKGKP(NGDMJKHOENM CELFKHEOLOM, string LHJOKPNKNEM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class NPEGFMKMAGF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public HCGDLJHKGKP queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public DeferredImposterSpawnManager <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private NGDMJKHOENM <request>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private GameObject <imposter>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private GameObject <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public NPEGFMKMAGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x712C2D0", Offset = "0x712B2D0", VA = "0x18712C2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private IRecRoomQualityConfigProvider PFCNCEDEAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private JCABIFMMAGJ<HCGDLJHKGKP, GameObject> FNJGBOJOAAL;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public ECJEPMNGLII MLEGFKKIJND
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9132E0", Offset = "0x9122E0", VA = "0x1809132E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private JCABIFMMAGJ<HCGDLJHKGKP, GameObject> GMBNGDJAFDD
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x712A140", Offset = "0x7129140", VA = "0x18712A140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private int FNKAIKDHAII
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x712A470", Offset = "0x7129470", VA = "0x18712A470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7129EF0", Offset = "0x7128EF0", VA = "0x187129EF0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x712A4C0", Offset = "0x71294C0", VA = "0x18712A4C0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7129FA0", Offset = "0x7128FA0", VA = "0x187129FA0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(NPEGFMKMAGF))]
	private Task<GameObject> FDMLNMEIIHE(HCGDLJHKGKP POHGJPAJLNE, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x712A2A0", Offset = "0x71292A0", VA = "0x18712A2A0")]
	public Task<GameObject> LoadItemAsync(NGDMJKHOENM CELFKHEOLOM, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x712A530", Offset = "0x7129530", VA = "0x18712A530")]
	public DeferredImposterSpawnManager()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[JHDFHPMJCIE(KDNNMHJGNJH.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const int FNFEOJAGPMN = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const int BGNOBMANGPO = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly List<Material> PKOLNAPLFKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool EPELDLCNFAL;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x712B380", Offset = "0x712A380", VA = "0x18712B380")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x712B290", Offset = "0x712A290", VA = "0x18712B290")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x712B5D0", Offset = "0x712A5D0", VA = "0x18712B5D0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NGDMJKHOENM
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string EBNPALLNLDF
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	KOIDOEFKKDB KOIDOEFKKDB
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action ALJNPMPEPEP;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> FAOGHFHBMGP(CancellationToken OAGBBBCDIGC);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PKLANLJFCJB(NGDMJKHOENM BKLMLPFOMCO);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DILNMDEGBDM();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EDNBOHODPJB();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MEGCAIFEBDB(out ODMBHKBFLMB<Texture> CHPGPODLMAN);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HJFIMFDLMIL
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x712A5E0", Offset = "0x71295E0", VA = "0x18712A5E0")]
	public static bool ONKAGDLHKPP(NGDMJKHOENM EJMIMHEFMPL, NGDMJKHOENM BEHLLCJCHEF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface PMKBNJHJEAC
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> MBNKLABMDLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<Type> KPHOEHIGCPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x85F0C0", Offset = "0x85E0C0", VA = "0x18085F0C0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface ECJEPMNGLII
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CLDKILJIEDN(params Type[] PHJPHNEMKCN);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PGJKAAGABCC(params Type[] PHJPHNEMKCN);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject LBLFOGBEBML(GameObject HPPLDHGJPNF, Transform DJAGPEDCGHG, bool GFNKIDBENLA = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T LBLFOGBEBML<T>(T HPPLDHGJPNF, Transform DJAGPEDCGHG, bool GFNKIDBENLA = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T LBLFOGBEBML<T>(GameObject HPPLDHGJPNF, Transform DJAGPEDCGHG, bool GFNKIDBENLA = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject LBLFOGBEBML(GameObject HPPLDHGJPNF, Transform DJAGPEDCGHG, DEMPFPLJFKJ BPFIFAEKGCN, bool GFNKIDBENLA);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T LBLFOGBEBML<T>(GameObject HPPLDHGJPNF, Transform DJAGPEDCGHG, DEMPFPLJFKJ BPFIFAEKGCN, bool GFNKIDBENLA) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T LBLFOGBEBML<T>(T HPPLDHGJPNF, Transform DJAGPEDCGHG, DEMPFPLJFKJ BPFIFAEKGCN, bool GFNKIDBENLA) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class BONNNLDFEEO
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly List<URPLight> AAFLFBCADHA;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly Vector3 BFBLIACBCHC;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly Vector3 PDJFLBANJEI;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static Camera DOGCHLEHFFK;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public const string POMAJCACADK = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const MPEHHHKKEME HDBCIBBAKMC = MPEHHHKKEME.Water;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly List<Renderer> EGLIFBCDPGE;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static AmbientMode PADJOLIOMMH;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static Color ONHJCGHODFO;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static Color OKKEHMCMCCJ;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static Color EKMKPIJBPHH;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static Cubemap NHHHIFDIKDB;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private static bool DOFOFFDBLDA;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static Camera BIPHEJKFIBN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7125DA0", Offset = "0x7124DA0", VA = "0x187125DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7127280", Offset = "0x7126280", VA = "0x187127280")]
	public static void IDNODEHDNLE(Vector3 PNGBPPEENNN, Quaternion ABPPMOLFDMD, ImposterRenderConfig KNLICKEBNPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x71268F0", Offset = "0x71258F0", VA = "0x1871268F0")]
	private static void EHHDNGAPALD(Vector3 PNGBPPEENNN, Quaternion ABPPMOLFDMD, URPLight APMNLNMDEDP, ImposterRenderConfig.LightConfig GLJDKGLOBOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7127500", Offset = "0x7126500", VA = "0x187127500")]
	public static void MIONLADHGAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7127790", Offset = "0x7126790", VA = "0x187127790")]
	private static void OGOHACLPBOE(int JMKIKLIHGPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7126770", Offset = "0x7125770", VA = "0x187126770")]
	public static void EFOLENLBKBB(ImposterRenderConfig KNLICKEBNPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7127180", Offset = "0x7126180", VA = "0x187127180")]
	public static void FKKKJEDOKHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7125BD0", Offset = "0x7124BD0", VA = "0x187125BD0")]
	public static void BKCPBKGJLHN(GameObject KBKMFKKHONH, RenderTexture MJMBKADGEKP, ImposterRenderConfig KNLICKEBNPP, KOIDOEFKKDB MJMMBJGDIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7126210", Offset = "0x7125210", VA = "0x187126210")]
	private static void DIEIIJNMJMN(GameObject KBKMFKKHONH, RenderTexture MJMBKADGEKP, ImposterRenderConfig KNLICKEBNPP, KOIDOEFKKDB MJMMBJGDIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7126BD0", Offset = "0x7125BD0", VA = "0x187126BD0")]
	private static void FDLANMDFJLE(GameObject KBKMFKKHONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x71275F0", Offset = "0x71265F0", VA = "0x1871275F0")]
	public static void NKGNJDFBGKE(List<Renderer> AKAENKBCAHF, List<Material> ODHKEIIOFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7126E80", Offset = "0x7125E80", VA = "0x187126E80")]
	public static void FDLOEEKCJAC(GameObject HPPLDHGJPNF, Vector3 EBEPFKMCEJL, Vector3 HGHDJFKCMBD, float PKNLJKDNKPD, KOIDOEFKKDB MJMMBJGDIPM, out Vector3 CGEFAHABLDN, out Quaternion POENFPEGAAF, out float NFMOLFNPKNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7127B60", Offset = "0x7126B60", VA = "0x187127B60")]
	public static RenderTexture PHAOGIAJKPL(int CAFDPIOMONE, int LGDEBCOFIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7125FE0", Offset = "0x7124FE0", VA = "0x187125FE0")]
	public static void CMAJPPDEPJH()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public struct HGPAFMOMEJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public NHFPGJIFDOB PMGOCGJKJPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public GameObject KMEJAFFAIEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public RenderTexture NAKCDECEEHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public ImposterRenderConfig OHCFHPLCPME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public KOIDOEFKKDB KOIDOEFKKDB;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x712A570", Offset = "0x7129570", VA = "0x18712A570")]
			public HGPAFMOMEJA(NHFPGJIFDOB LNFEMDDJPIK, GameObject AHKJHIKDMBE, RenderTexture MJMBKADGEKP, ImposterRenderConfig JDJPBJLBOIK, KOIDOEFKKDB MJMMBJGDIPM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static JCABIFMMAGJ<HGPAFMOMEJA, RenderTexture> NCNDFIGPJGF;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly List<HGPAFMOMEJA> OKNKPPJAGDG;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private static int NIODPFHDFEG
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x71299E0", Offset = "0x71289E0", VA = "0x1871299E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7129AF0", Offset = "0x7128AF0", VA = "0x187129AF0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject KBKMFKKHONH, RenderTexture MJMBKADGEKP, ImposterRenderConfig KNLICKEBNPP, KOIDOEFKKDB MJMMBJGDIPM, CancellationToken OAGBBBCDIGC, bool HPAMCJFAMNG = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7129620", Offset = "0x7128620", VA = "0x187129620", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7129A50", Offset = "0x7128A50", VA = "0x187129A50", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7129810", Offset = "0x7128810", VA = "0x187129810")]
		private static Task<RenderTexture> JLPJHCILPNA(HGPAFMOMEJA DNMLFCFLCDF, CancellationToken OAGBBBCDIGC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7129EB0", Offset = "0x7128EB0", VA = "0x187129EB0")]
		public DeferredImposterRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CreateAssetMenu]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x712B6B0", Offset = "0x712A6B0", VA = "0x18712B6B0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x712B690", Offset = "0x712A690", VA = "0x18712B690")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ColorUsage(false, true)]
		[Header("Environment Lighting")]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x712B240", Offset = "0x712A240", VA = "0x18712B240")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CIEKEJOMHLF : IDisposable, ECJEPMNGLII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly HashSet<Type> KKLEEGNDABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly HashSet<Type> KHCOOPBADDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private Transform LIAJPBHLPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly List<Component> DEMOMBKOPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> KABKGNAOOED;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7128530", Offset = "0x7127530", VA = "0x187128530")]
	[FBCFLFBFGIL(LAFFCBAHJKM.None)]
	public static void HBFKEFNCHDO(CNALHHIKJDD DBGHBAHCJKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x71288F0", Offset = "0x71278F0", VA = "0x1871288F0")]
	[Preserve]
	public CIEKEJOMHLF([JFLEHDEIONF(null)] PMKBNJHJEAC JHDPECEDCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7128430", Offset = "0x7127430", VA = "0x187128430", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x71283E0", Offset = "0x71273E0", VA = "0x1871283E0", Slot = "5")]
	public void CLDKILJIEDN(params Type[] PHJPHNEMKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x71288A0", Offset = "0x71278A0", VA = "0x1871288A0", Slot = "6")]
	public void PGJKAAGABCC(params Type[] PHJPHNEMKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7128620", Offset = "0x7127620", VA = "0x187128620", Slot = "7")]
	public GameObject LBLFOGBEBML(GameObject HPPLDHGJPNF, Transform DJAGPEDCGHG, bool GFNKIDBENLA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2C92880", Offset = "0x2C91880", VA = "0x182C92880", Slot = "8")]
	public T LBLFOGBEBML<T>(T HPPLDHGJPNF, Transform DJAGPEDCGHG, bool GFNKIDBENLA = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2C92E10", Offset = "0x2C91E10", VA = "0x182C92E10", Slot = "9")]
	public T LBLFOGBEBML<T>(GameObject HPPLDHGJPNF, Transform DJAGPEDCGHG, bool GFNKIDBENLA = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x71286B0", Offset = "0x71276B0", VA = "0x1871286B0", Slot = "10")]
	public GameObject LBLFOGBEBML(GameObject HPPLDHGJPNF, Transform DJAGPEDCGHG, DEMPFPLJFKJ BPFIFAEKGCN, bool GFNKIDBENLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2C92E40", Offset = "0x2C91E40", VA = "0x182C92E40", Slot = "11")]
	public T LBLFOGBEBML<T>(GameObject HPPLDHGJPNF, Transform DJAGPEDCGHG, DEMPFPLJFKJ BPFIFAEKGCN, bool GFNKIDBENLA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2C927F0", Offset = "0x2C917F0", VA = "0x182C927F0", Slot = "12")]
	public T LBLFOGBEBML<T>(T HPPLDHGJPNF, Transform DJAGPEDCGHG, DEMPFPLJFKJ BPFIFAEKGCN, bool GFNKIDBENLA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2C928F0", Offset = "0x2C918F0", VA = "0x182C928F0")]
	private T LBLFOGBEBML<T>(GameObject HPPLDHGJPNF, Transform DJAGPEDCGHG, DEMPFPLJFKJ BPFIFAEKGCN, bool GFNKIDBENLA, out GameObject LJNJCPNJOCD) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2C92240", Offset = "0x2C91240", VA = "0x182C92240")]
	private T KPIHIPKBPNL<T>(GameObject LAPEIFCGFLM, DEMPFPLJFKJ BPFIFAEKGCN, bool GFNKIDBENLA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7127D40", Offset = "0x7126D40", VA = "0x187127D40")]
	private void ABMLJLPJAEE(Component GDOIACLJEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7127E70", Offset = "0x7126E70", VA = "0x187127E70")]
	private void BCOKECMIIBO(Component GDOIACLJEDE, DEMPFPLJFKJ BPFIFAEKGCN, bool GFNKIDBENLA, bool PAPCJBLOOLD, [Optional] Type HDDCACDIPKJ, [Optional] Type FFEBMIBKCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7128740", Offset = "0x7127740", VA = "0x187128740")]
	private void LPDCAEOJIKF(GameObject LAPEIFCGFLM)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class CenterInImposter : MonoBehaviour, HDEBGJDAOOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7128D30", Offset = "0x7127D30", VA = "0x187128D30", Slot = "4")]
		public void PrepareImposter(DEMPFPLJFKJ BPFIFAEKGCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x85F0C0", Offset = "0x85E0C0", VA = "0x18085F0C0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x85F0C0", Offset = "0x85E0C0", VA = "0x18085F0C0")]
		public KeepImposterUpright()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct DEMPFPLJFKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private Dictionary<Type, object> DFCHOLKMIIF;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x23E20E0", Offset = "0x23E10E0", VA = "0x1823E20E0")]
	public DEMPFPLJFKJ DGLJBNFHKAF<T>(T BGGMKIACJEA)
	{
		return default(DEMPFPLJFKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x23E2730", Offset = "0x23E1730", VA = "0x1823E2730")]
	public T FLFDNJDANPO<T>(T PNJDHPAJOAO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x23E27F0", Offset = "0x23E17F0", VA = "0x1823E27F0")]
	public bool OLPFKLCKDPK<T>(out T BGGMKIACJEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct KPEKCANEKBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool FBMILFNGFEK;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1B30280", Offset = "0x1B2F280", VA = "0x181B30280")]
	public KPEKCANEKBM(bool LKKMFEEKLHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct OOMFFGAKJOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool FHCKNBKGBHH;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x712C6E0", Offset = "0x712B6E0", VA = "0x18712C6E0")]
	public OOMFFGAKJOI(bool JBHCOCHLHAJ)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class ScaleInImposter : MonoBehaviour, HDEBGJDAOOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x712C6F0", Offset = "0x712B6F0", VA = "0x18712C6F0", Slot = "4")]
		public void PrepareImposter(DEMPFPLJFKJ BPFIFAEKGCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x85F0C0", Offset = "0x85E0C0", VA = "0x18085F0C0")]
		public ScaleInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface HDEBGJDAOOP
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(DEMPFPLJFKJ BPFIFAEKGCN);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class MHGFMJKAFPI
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MHGFMJKAFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xBB9C20", Offset = "0xBB8C20", VA = "0x180BB9C20")]
	public static string KILOLNAHAFI(byte[] BKIADALNNFJ, byte[] EEICCMPLMOJ)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
