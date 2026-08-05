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
public class ImposterPreviewCustomFraming : MonoBehaviour, OCNMCNDDOPN
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float ILLBCNCKOID = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "4")]
	public void PrepareImposter(EGIAALPNPFM DAKKAABHBLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x156F7A0", Offset = "0x156DFA0", VA = "0x18156F7A0")]
	public void SetReferencePoint(Vector3 CLLBFIHFGKG, Quaternion ANNMEOBLHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x156F610", Offset = "0x156DE10", VA = "0x18156F610")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x156F770", Offset = "0x156DF70", VA = "0x18156F770")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x156F7E0", Offset = "0x156DFE0", VA = "0x18156F7E0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class PDEJNGBHDKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public LJEAIIFNNOA LCKEMPKIOAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly Texture EOMJKPMGIDO;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8AC4E0", Offset = "0x8AACE0", VA = "0x1808AC4E0")]
		public PDEJNGBHDKD(LJEAIIFNNOA AFMGJDCGGPO, Texture KMIIAOHPJMH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum OBEIDIHMKKO
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
	private class PLELFIJMBPH : global::BMMLLBKLJDM<Texture>, FNEGELMJDBM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class KFNKLHBDHLP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public PLELFIJMBPH <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
			public KFNKLHBDHLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x15726F0", Offset = "0x1570EF0", VA = "0x1815726F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly LJEAIIFNNOA AFMGJDCGGPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly RenderTexture APJLDMINMBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly ImposterRenderConfig OLPPPDJPDOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly CancellationToken GFFFFCALMCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private GameObject DGOANAFBANA;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private EILHPPDHBHH LOKNNCIAKDP
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x1572F00", Offset = "0x1571700", VA = "0x181572F00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public global::NBFPPJGKGOH<Texture> NFMMEGLCENH
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x1572FB0", Offset = "0x15717B0", VA = "0x181572FB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Task NMOONEGGGJP
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7F2A40", Offset = "0x7F1240", VA = "0x1807F2A40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Task<Texture> DAKHKMPDFGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7F2A40", Offset = "0x7F1240", VA = "0x1807F2A40", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1573150", Offset = "0x1571950", VA = "0x181573150")]
		public PLELFIJMBPH(LJEAIIFNNOA AFMGJDCGGPO, RenderTexture APJLDMINMBA, ImposterRenderConfig OLPPPDJPDOP, CancellationToken GFFFFCALMCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1573000", Offset = "0x1571800", VA = "0x181573000")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(KFNKLHBDHLP))]
		private Task<Texture> LMPEHGKHBEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1572F10", Offset = "0x1571710", VA = "0x181572F10", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1572F20", Offset = "0x1571720", VA = "0x181572F20")]
		private static void KOBDNIICEHJ(GameObject DGOANAFBANA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class DODPGJKLMKP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public DODPGJKLMKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x156C8E0", Offset = "0x156B0E0", VA = "0x18156C8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
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
	[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private OBEIDIHMKKO size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	[LEKNNDJMFFO("size", 0)]
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
	private RenderTexture GPAAKJLEEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private global::BGJGABMFCLG<GameObject> FMPDMBBKLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private OHBOPDKGAGN FJCHFGDOHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private CancellationTokenSource MFGBDLCLLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private global::BMMLLBKLJDM<Texture> DAJCNEECECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private LJEAIIFNNOA FEBMKCEJNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Texture LBHNNDMHKHI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private RenderTexture GNHGLJPNDLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x156F930", Offset = "0x156E130", VA = "0x18156F930")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8B4930", Offset = "0x8B3130", VA = "0x1808B4930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private LJEAIIFNNOA LCKEMPKIOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8C3600", Offset = "0x8C1E00", VA = "0x1808C3600")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x156FB30", Offset = "0x156E330", VA = "0x18156FB30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool FFGKDNKLKLC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xBA59E0", Offset = "0xBA41E0", VA = "0x180BA59E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int AGPODICDIPI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x156FD60", Offset = "0x156E560", VA = "0x18156FD60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x156F820", Offset = "0x156E020", VA = "0x18156F820")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x156FD70", Offset = "0x156E570", VA = "0x18156FD70")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x156FAA0", Offset = "0x156E2A0", VA = "0x18156FAA0")]
	private void MMHBCFLHBIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x15700D0", Offset = "0x156E8D0", VA = "0x1815700D0")]
	public void Set(LJEAIIFNNOA DGLLCGJLNLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x15700E0", Offset = "0x156E8E0", VA = "0x1815700E0")]
	public void Set(Texture KMIIAOHPJMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1570090", Offset = "0x156E890", VA = "0x181570090")]
	public void Set(PDEJNGBHDKD ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x156F830", Offset = "0x156E030", VA = "0x18156F830")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x156FE70", Offset = "0x156E670", VA = "0x18156FE70")]
	public void SetInternal(LJEAIIFNNOA DGLLCGJLNLJ, [Optional] Texture IOEPJOONFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x156FE60", Offset = "0x156E660", VA = "0x18156FE60")]
	public void SetCustomSize(int PJFIIFBPLJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x92D760", Offset = "0x92BF60", VA = "0x18092D760")]
	public void SetAntiAliasing(int MNKFBJLCGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x156FC80", Offset = "0x156E480", VA = "0x18156FC80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DODPGJKLMKP))]
	private void NGKNKFOGBBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x156F840", Offset = "0x156E040", VA = "0x18156F840")]
	private void EAKIMODNLAC(Texture KMIIAOHPJMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x15700F0", Offset = "0x156E8F0", VA = "0x1815700F0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct JDKMFKHMHCI
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static JDKMFKHMHCI APGNBAMKAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float ILPBFLFCIEA;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xD7EA20", Offset = "0xD7D220", VA = "0x180D7EA20")]
	public JDKMFKHMHCI(float LCEBKNHBOBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DeferredImposterSpawnManager : SingletonMonoBehaviour<DeferredImposterSpawnManager>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private readonly struct DJNHDOPDHGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly LJEAIIFNNOA EINOEIBJFEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly string HFLCPAHPIIE;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9E1370", Offset = "0x9DFB70", VA = "0x1809E1370")]
		public DJNHDOPDHGG(LJEAIIFNNOA OCJEDADKJLF, string EEJDHAPFKNI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class GBJNOKMGEHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public DJNHDOPDHGG queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public DeferredImposterSpawnManager <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private LJEAIIFNNOA <request>5__1;

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
		[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
		public GBJNOKMGEHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x156E160", Offset = "0x156C960", VA = "0x18156E160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x80EA80", Offset = "0x80D280", VA = "0x18080EA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private IRecRoomQualityConfigProvider JNOBNHEGMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private global::EKFJNFEBJEA<DJNHDOPDHGG, GameObject> NLBDDJCCKHD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public HBBJBLLKAOJ FHELKJMKHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x811A70", Offset = "0x810270", VA = "0x180811A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private global::EKFJNFEBJEA<DJNHDOPDHGG, GameObject> AOCNPLAPNPF
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x156DBD0", Offset = "0x156C3D0", VA = "0x18156DBD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private int MMGJDJDLEEN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x156DB80", Offset = "0x156C380", VA = "0x18156DB80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x156DAD0", Offset = "0x156C2D0", VA = "0x18156DAD0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x156E0A0", Offset = "0x156C8A0", VA = "0x18156E0A0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x156DD30", Offset = "0x156C530", VA = "0x18156DD30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GBJNOKMGEHC))]
	private Task<GameObject> LCKLDJIOBOB(DJNHDOPDHGG LMGMAEINKGL, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x156DED0", Offset = "0x156C6D0", VA = "0x18156DED0")]
	public Task<GameObject> LoadItemAsync(LJEAIIFNNOA OCJEDADKJLF, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x156E110", Offset = "0x156C910", VA = "0x18156E110")]
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
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const int GADFALHHOFH = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const int PCFLMGECJOC = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly List<Material> ICMJGMIGNLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool IDCCGOFMKNG;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x15702D0", Offset = "0x156EAD0", VA = "0x1815702D0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x15701E0", Offset = "0x156E9E0", VA = "0x1815701E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1570510", Offset = "0x156ED10", VA = "0x181570510")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LJEAIIFNNOA
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string HMPMLLDNGND
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	JDKMFKHMHCI JDKMFKHMHCI
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action GMGEBILFMIP;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> CMMADNPIMFL(CancellationToken GFFFFCALMCA);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EKPJNDPEBEC(LJEAIIFNNOA MDHJAFNLPON);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NLBOGODDJOG();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CINPHEGNHPN();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool KNPGCLFEPCH(out global::BMMLLBKLJDM<Texture> FNJANAKJLDD);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class IPDMCODKDGM
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x156F530", Offset = "0x156DD30", VA = "0x18156F530")]
	public static bool DMBEMLHFGOC(LJEAIIFNNOA JALCDPDCPKK, LJEAIIFNNOA LGFENKCCKGF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EFKJJFLPOLL
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> LAOJGMGGDLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<Type> JIJLNMGJPPJ
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
		[Cpp2IlInjected.Address(RVA = "0x9080F0", Offset = "0x9068F0", VA = "0x1809080F0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HBBJBLLKAOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LJGKFLOFOMF(params Type[] LONDNADJAMP);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GIKHMBHAAJI(params Type[] LONDNADJAMP);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject DJLEIACDDEM(GameObject OGIDMIHPCNI, Transform ONIJEEBBCHK, bool PFFEMFBBGJJ = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T DJLEIACDDEM<T>(T OGIDMIHPCNI, Transform ONIJEEBBCHK, bool PFFEMFBBGJJ = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T DJLEIACDDEM<T>(GameObject OGIDMIHPCNI, Transform ONIJEEBBCHK, bool PFFEMFBBGJJ = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject DJLEIACDDEM(GameObject OGIDMIHPCNI, Transform ONIJEEBBCHK, EGIAALPNPFM DAKKAABHBLK, bool PFFEMFBBGJJ);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T DJLEIACDDEM<T>(GameObject OGIDMIHPCNI, Transform ONIJEEBBCHK, EGIAALPNPFM DAKKAABHBLK, bool PFFEMFBBGJJ) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T DJLEIACDDEM<T>(T OGIDMIHPCNI, Transform ONIJEEBBCHK, EGIAALPNPFM DAKKAABHBLK, bool PFFEMFBBGJJ) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JAOIFFFPBAN
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly List<URPLight> JMLEIGPDIKL;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly Vector3 AMFOEALKDKP;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly Vector3 MHIPEPAGNHA;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static Camera HAIMBEEPMFO;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public const string GICLDOIKFAN = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const NLBIGDDFJFI AHAEFNDHCLO = NLBIGDDFJFI.Water;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly List<Renderer> OEBHCGNIFIA;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static AmbientMode HFKMOBPBPIO;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static Color MAGFOIFIALK;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static Color GEAHAEOIOII;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static Color NJPHHBIPFFD;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static Cubemap NGPPOIEFCFJ;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private static bool HLDDCJHIBNP;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static Camera EMPNPOKOKBB
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1570F30", Offset = "0x156F730", VA = "0x181570F30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x15708E0", Offset = "0x156F0E0", VA = "0x1815708E0")]
	public static void DBMMJGDADPD(Vector3 CLEFCGBNPNA, Quaternion NJJEPJLMCLJ, ImposterRenderConfig HLNAJLKNPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1571590", Offset = "0x156FD90", VA = "0x181571590")]
	private static void OJCLOCKANLB(Vector3 CLEFCGBNPNA, Quaternion NJJEPJLMCLJ, URPLight PABFEEAANNI, ImposterRenderConfig.LightConfig EMJLEMMMNIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x15722A0", Offset = "0x1570AA0", VA = "0x1815722A0")]
	public static void PCHPHAGNOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1570B60", Offset = "0x156F360", VA = "0x181570B60")]
	private static void ECMHEIEOHHH(int LCAIBBJLOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1571170", Offset = "0x156F970", VA = "0x181571170")]
	public static void MOHDBHNEDMD(ImposterRenderConfig HLNAJLKNPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x15712F0", Offset = "0x156FAF0", VA = "0x1815712F0")]
	public static void NHJDCFBDNGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1572390", Offset = "0x1570B90", VA = "0x181572390")]
	public static void PDOIOOAAGMD(GameObject MBOKNPAOKBL, RenderTexture APJLDMINMBA, ImposterRenderConfig HLNAJLKNPMJ, JDKMFKHMHCI NIPNINKPPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1571DA0", Offset = "0x15705A0", VA = "0x181571DA0")]
	private static void OLIGBFEFBKK(GameObject MBOKNPAOKBL, RenderTexture APJLDMINMBA, ImposterRenderConfig HLNAJLKNPMJ, JDKMFKHMHCI NIPNINKPPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1570630", Offset = "0x156EE30", VA = "0x181570630")]
	private static void BDFIAOEPHFG(GameObject MBOKNPAOKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x15713F0", Offset = "0x156FBF0", VA = "0x1815713F0")]
	public static void NNILJDMMKLH(List<Renderer> KIIOMKKNNNM, List<Material> MMGPBBGPFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1571AD0", Offset = "0x15702D0", VA = "0x181571AD0")]
	public static void OKDLEJJMHDF(GameObject OGIDMIHPCNI, Vector3 AGIJMIAONCI, Vector3 BLNJLJGEKAM, float ANKAELJOKCD, JDKMFKHMHCI NIPNINKPPEB, out Vector3 GKOPGMDOIID, out Quaternion OKFAHMKIBPM, out float NKGBDPBNICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1570590", Offset = "0x156ED90", VA = "0x181570590")]
	public static RenderTexture AFGIAJFIDFE(int JJJHCGPEBDK, int BABILIHBNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x15718A0", Offset = "0x15700A0", VA = "0x1815718A0")]
	public static void OJMCNNKKOFF()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public struct NAOIFCEDLIP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public GIELIJKIODJ AICEHFEIDDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public GameObject MLHPDOHAPIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public RenderTexture GNHGLJPNDLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public ImposterRenderConfig NBEFLLKOCFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public JDKMFKHMHCI JDKMFKHMHCI;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x1572E90", Offset = "0x1571690", VA = "0x181572E90")]
			public NAOIFCEDLIP(GIELIJKIODJ INGDMDMAGEN, GameObject CLIDDMJPMEO, RenderTexture APJLDMINMBA, ImposterRenderConfig OLPPPDJPDOP, JDKMFKHMHCI NIPNINKPPEB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static global::EKFJNFEBJEA<NAOIFCEDLIP, RenderTexture> AJKKEKMAJOK;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly List<NAOIFCEDLIP> FELEFJFAMMP;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private static int KJIICOPOBDM
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x156D3F0", Offset = "0x156BBF0", VA = "0x18156D3F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x156D6D0", Offset = "0x156BED0", VA = "0x18156D6D0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject MBOKNPAOKBL, RenderTexture APJLDMINMBA, ImposterRenderConfig HLNAJLKNPMJ, JDKMFKHMHCI NIPNINKPPEB, CancellationToken GFFFFCALMCA, bool NBPIJFGFLFI = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x156D200", Offset = "0x156BA00", VA = "0x18156D200", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x156D630", Offset = "0x156BE30", VA = "0x18156D630", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x156D460", Offset = "0x156BC60", VA = "0x18156D460")]
		private static Task<RenderTexture> OMFCHGIFEOM(NAOIFCEDLIP ODEMEOHLDBB, CancellationToken GFFFFCALMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x156DA90", Offset = "0x156C290", VA = "0x18156DA90")]
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
				[Cpp2IlInjected.Address(RVA = "0x1572E70", Offset = "0x1571670", VA = "0x181572E70")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1572E50", Offset = "0x1571650", VA = "0x181572E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x1570190", Offset = "0x156E990", VA = "0x181570190")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GGADFKLDBAH : IDisposable, HBBJBLLKAOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly HashSet<Type> EHDPNFMGNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly HashSet<Type> PCFFHNDBLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private Transform DHGFABAGOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly List<Component> NKPBGGDFGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> HOGFKAFNDBO;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x156EFA0", Offset = "0x156D7A0", VA = "0x18156EFA0")]
	[BBAPFPLPODF(EDNJEIFHIMJ.None)]
	public static void LECKBAIJAMJ(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x156F0E0", Offset = "0x156D8E0", VA = "0x18156F0E0")]
	[Preserve]
	public GGADFKLDBAH([ACEKLAKDMBL(null)] EFKJJFLPOLL MLCOBAPNNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x156EBC0", Offset = "0x156D3C0", VA = "0x18156EBC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x156F090", Offset = "0x156D890", VA = "0x18156F090", Slot = "5")]
	public void LJGKFLOFOMF(params Type[] LONDNADJAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x156EF50", Offset = "0x156D750", VA = "0x18156EF50", Slot = "6")]
	public void GIKHMBHAAJI(params Type[] LONDNADJAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x156EAA0", Offset = "0x156D2A0", VA = "0x18156EAA0", Slot = "7")]
	public GameObject DJLEIACDDEM(GameObject OGIDMIHPCNI, Transform ONIJEEBBCHK, bool PFFEMFBBGJJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x30B6640", Offset = "0x30B4E40", VA = "0x1830B6640", Slot = "8")]
	public T DJLEIACDDEM<T>(T OGIDMIHPCNI, Transform ONIJEEBBCHK, bool PFFEMFBBGJJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x30B6610", Offset = "0x30B4E10", VA = "0x1830B6610", Slot = "9")]
	public T DJLEIACDDEM<T>(GameObject OGIDMIHPCNI, Transform ONIJEEBBCHK, bool PFFEMFBBGJJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x156EB30", Offset = "0x156D330", VA = "0x18156EB30", Slot = "10")]
	public GameObject DJLEIACDDEM(GameObject OGIDMIHPCNI, Transform ONIJEEBBCHK, EGIAALPNPFM DAKKAABHBLK, bool PFFEMFBBGJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x30B6530", Offset = "0x30B4D30", VA = "0x1830B6530", Slot = "11")]
	public T DJLEIACDDEM<T>(GameObject OGIDMIHPCNI, Transform ONIJEEBBCHK, EGIAALPNPFM DAKKAABHBLK, bool PFFEMFBBGJJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x30B6580", Offset = "0x30B4D80", VA = "0x1830B6580", Slot = "12")]
	public T DJLEIACDDEM<T>(T OGIDMIHPCNI, Transform ONIJEEBBCHK, EGIAALPNPFM DAKKAABHBLK, bool PFFEMFBBGJJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x30B6000", Offset = "0x30B4800", VA = "0x1830B6000")]
	private T DJLEIACDDEM<T>(GameObject OGIDMIHPCNI, Transform ONIJEEBBCHK, EGIAALPNPFM DAKKAABHBLK, bool PFFEMFBBGJJ, out GameObject JHPLDFHCGNI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x30B5A60", Offset = "0x30B4260", VA = "0x1830B5A60")]
	private T AJBKBKHDJAB<T>(GameObject ALBKEDBKENG, EGIAALPNPFM DAKKAABHBLK, bool PFFEMFBBGJJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x156ECC0", Offset = "0x156D4C0", VA = "0x18156ECC0")]
	private void FECNDDBMGJI(Component DPLEBJGMEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x156E550", Offset = "0x156CD50", VA = "0x18156E550")]
	private void BKGCMNKBNPM(Component DPLEBJGMEDE, EGIAALPNPFM DAKKAABHBLK, bool PFFEMFBBGJJ, bool KIMEAFAGDMP, [Optional] Type KGIMPKAGGLI, [Optional] Type DBEBFAELKGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x156EDF0", Offset = "0x156D5F0", VA = "0x18156EDF0")]
	private void GHPAHHDFDCD(GameObject ALBKEDBKENG)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class CenterInImposter : MonoBehaviour, OCNMCNDDOPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x156C780", Offset = "0x156AF80", VA = "0x18156C780", Slot = "4")]
		public void PrepareImposter(EGIAALPNPFM DAKKAABHBLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9080F0", Offset = "0x9068F0", VA = "0x1809080F0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9080F0", Offset = "0x9068F0", VA = "0x1809080F0")]
		public KeepImposterUpright()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct EGIAALPNPFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private Dictionary<Type, object> MKIMKPGMJBF;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2F502C0", Offset = "0x2F4EAC0", VA = "0x182F502C0")]
	public EGIAALPNPFM OLBGCODNBJK<T>(T BBALKNFFLHI)
	{
		return default(EGIAALPNPFM);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2F51190", Offset = "0x2F4F990", VA = "0x182F51190")]
	public T PNBJHLBKMLC<T>(T IGBKLJLDCLC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2F509F0", Offset = "0x2F4F1F0", VA = "0x182F509F0")]
	public bool PFLIDDOFNIB<T>(out T BBALKNFFLHI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct GAFIKCKOMEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool AMLPCLLMMCA;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x156E150", Offset = "0x156C950", VA = "0x18156E150")]
	public GAFIKCKOMEN(bool FDOPLFDOAPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct IDICONIHNIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool CPPILANOODB;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x156F520", Offset = "0x156DD20", VA = "0x18156F520")]
	public IDICONIHNIG(bool MFEDLBODBMO)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class ScaleInImposter : MonoBehaviour, OCNMCNDDOPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1573320", Offset = "0x1571B20", VA = "0x181573320", Slot = "4")]
		public void PrepareImposter(EGIAALPNPFM DAKKAABHBLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9080F0", Offset = "0x9068F0", VA = "0x1809080F0")]
		public ScaleInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface OCNMCNDDOPN
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(EGIAALPNPFM DAKKAABHBLK);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x819400", Offset = "0x817C00", VA = "0x180819400")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xBC23C0", Offset = "0xBC0BC0", VA = "0x180BC23C0")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
