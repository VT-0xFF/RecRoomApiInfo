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
	[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "4")]
	public void PrepareImposter(EGIAALPNPFM DAKKAABHBLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7F10", Offset = "0x6EB6B10", VA = "0x186EB7F10")]
	public void SetReferencePoint(Vector3 CLLBFIHFGKG, Quaternion ANNMEOBLHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7D80", Offset = "0x6EB6980", VA = "0x186EB7D80")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7EE0", Offset = "0x6EB6AE0", VA = "0x186EB7EE0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7F50", Offset = "0x6EB6B50", VA = "0x186EB7F50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9138A0", Offset = "0x9124A0", VA = "0x1809138A0")]
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
	private class PLELFIJMBPH : BMMLLBKLJDM<Texture>, FNEGELMJDBM, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
			public KFNKLHBDHLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6EBAE60", Offset = "0x6EB9A60", VA = "0x186EBAE60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6EBB670", Offset = "0x6EBA270", VA = "0x186EBB670", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public NBFPPJGKGOH<Texture> NFMMEGLCENH
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6EBB720", Offset = "0x6EBA320", VA = "0x186EBB720", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Task NMOONEGGGJP
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x838FF0", Offset = "0x837BF0", VA = "0x180838FF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Task<Texture> DAKHKMPDFGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x838FF0", Offset = "0x837BF0", VA = "0x180838FF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6EBB8C0", Offset = "0x6EBA4C0", VA = "0x186EBB8C0")]
		public PLELFIJMBPH(LJEAIIFNNOA AFMGJDCGGPO, RenderTexture APJLDMINMBA, ImposterRenderConfig OLPPPDJPDOP, CancellationToken GFFFFCALMCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6EBB770", Offset = "0x6EBA370", VA = "0x186EBB770")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(KFNKLHBDHLP))]
		private Task<Texture> LMPEHGKHBEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6EBB680", Offset = "0x6EBA280", VA = "0x186EBB680", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6EBB690", Offset = "0x6EBA290", VA = "0x186EBB690")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public DODPGJKLMKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6EB5060", Offset = "0x6EB3C60", VA = "0x186EB5060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
	private BGJGABMFCLG<GameObject> FMPDMBBKLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private OHBOPDKGAGN FJCHFGDOHFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private CancellationTokenSource MFGBDLCLLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private BMMLLBKLJDM<Texture> DAJCNEECECG;

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
		[Cpp2IlInjected.Address(RVA = "0x6EB80A0", Offset = "0x6EB6CA0", VA = "0x186EB80A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x89C6B0", Offset = "0x89B2B0", VA = "0x18089C6B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private LJEAIIFNNOA LCKEMPKIOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x839090", Offset = "0x837C90", VA = "0x180839090")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6EB82A0", Offset = "0x6EB6EA0", VA = "0x186EB82A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool FFGKDNKLKLC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA90E10", Offset = "0xA8FA10", VA = "0x180A90E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int AGPODICDIPI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6EB84D0", Offset = "0x6EB70D0", VA = "0x186EB84D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7F90", Offset = "0x6EB6B90", VA = "0x186EB7F90")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6EB84E0", Offset = "0x6EB70E0", VA = "0x186EB84E0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6EB8210", Offset = "0x6EB6E10", VA = "0x186EB8210")]
	private void MMHBCFLHBIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6EB8840", Offset = "0x6EB7440", VA = "0x186EB8840")]
	public void Set(LJEAIIFNNOA DGLLCGJLNLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6EB8850", Offset = "0x6EB7450", VA = "0x186EB8850")]
	public void Set(Texture KMIIAOHPJMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6EB8800", Offset = "0x6EB7400", VA = "0x186EB8800")]
	public void Set(PDEJNGBHDKD ECNGHFJBIJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7FA0", Offset = "0x6EB6BA0", VA = "0x186EB7FA0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6EB85E0", Offset = "0x6EB71E0", VA = "0x186EB85E0")]
	public void SetInternal(LJEAIIFNNOA DGLLCGJLNLJ, [Optional] Texture IOEPJOONFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6EB85D0", Offset = "0x6EB71D0", VA = "0x186EB85D0")]
	public void SetCustomSize(int PJFIIFBPLJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8A3620", Offset = "0x8A2220", VA = "0x1808A3620")]
	public void SetAntiAliasing(int MNKFBJLCGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6EB83F0", Offset = "0x6EB6FF0", VA = "0x186EB83F0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DODPGJKLMKP))]
	private void NGKNKFOGBBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7FB0", Offset = "0x6EB6BB0", VA = "0x186EB7FB0")]
	private void EAKIMODNLAC(Texture KMIIAOHPJMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6EB8860", Offset = "0x6EB7460", VA = "0x186EB8860")]
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
	[Cpp2IlInjected.Address(RVA = "0xBFBE30", Offset = "0xBFAA30", VA = "0x180BFBE30")]
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
		[Cpp2IlInjected.Address(RVA = "0x91E4D0", Offset = "0x91D0D0", VA = "0x18091E4D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public GBJNOKMGEHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6EB68D0", Offset = "0x6EB54D0", VA = "0x186EB68D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7F3010", Offset = "0x7F1C10", VA = "0x1807F3010", Slot = "5")]
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
	private EKFJNFEBJEA<DJNHDOPDHGG, GameObject> NLBDDJCCKHD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public HBBJBLLKAOJ FHELKJMKHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7F6030", Offset = "0x7F4C30", VA = "0x1807F6030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private EKFJNFEBJEA<DJNHDOPDHGG, GameObject> AOCNPLAPNPF
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6350", Offset = "0x6EB4F50", VA = "0x186EB6350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private int MMGJDJDLEEN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6300", Offset = "0x6EB4F00", VA = "0x186EB6300")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6EB6250", Offset = "0x6EB4E50", VA = "0x186EB6250", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6EB6820", Offset = "0x6EB5420", VA = "0x186EB6820", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6EB64B0", Offset = "0x6EB50B0", VA = "0x186EB64B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(GBJNOKMGEHC))]
	private Task<GameObject> LCKLDJIOBOB(DJNHDOPDHGG LMGMAEINKGL, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6EB6650", Offset = "0x6EB5250", VA = "0x186EB6650")]
	public Task<GameObject> LoadItemAsync(LJEAIIFNNOA OCJEDADKJLF, CancellationToken GFFFFCALMCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6EB6890", Offset = "0x6EB5490", VA = "0x186EB6890")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EB8A40", Offset = "0x6EB7640", VA = "0x186EB8A40")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6EB8950", Offset = "0x6EB7550", VA = "0x186EB8950")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6EB8C80", Offset = "0x6EB7880", VA = "0x186EB8C80")]
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
	bool KNPGCLFEPCH(out BMMLLBKLJDM<Texture> FNJANAKJLDD);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class IPDMCODKDGM
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7CA0", Offset = "0x6EB68A0", VA = "0x186EB7CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87DF50", Offset = "0x87CB50", VA = "0x18087DF50")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EB96A0", Offset = "0x6EB82A0", VA = "0x186EB96A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9050", Offset = "0x6EB7C50", VA = "0x186EB9050")]
	public static void DBMMJGDADPD(Vector3 CLEFCGBNPNA, Quaternion NJJEPJLMCLJ, ImposterRenderConfig HLNAJLKNPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9D00", Offset = "0x6EB8900", VA = "0x186EB9D00")]
	private static void OJCLOCKANLB(Vector3 CLEFCGBNPNA, Quaternion NJJEPJLMCLJ, URPLight PABFEEAANNI, ImposterRenderConfig.LightConfig EMJLEMMMNIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6EBAA10", Offset = "0x6EB9610", VA = "0x186EBAA10")]
	public static void PCHPHAGNOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6EB92D0", Offset = "0x6EB7ED0", VA = "0x186EB92D0")]
	private static void ECMHEIEOHHH(int LCAIBBJLOEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6EB98E0", Offset = "0x6EB84E0", VA = "0x186EB98E0")]
	public static void MOHDBHNEDMD(ImposterRenderConfig HLNAJLKNPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9A60", Offset = "0x6EB8660", VA = "0x186EB9A60")]
	public static void NHJDCFBDNGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6EBAB00", Offset = "0x6EB9700", VA = "0x186EBAB00")]
	public static void PDOIOOAAGMD(GameObject MBOKNPAOKBL, RenderTexture APJLDMINMBA, ImposterRenderConfig HLNAJLKNPMJ, JDKMFKHMHCI NIPNINKPPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6EBA510", Offset = "0x6EB9110", VA = "0x186EBA510")]
	private static void OLIGBFEFBKK(GameObject MBOKNPAOKBL, RenderTexture APJLDMINMBA, ImposterRenderConfig HLNAJLKNPMJ, JDKMFKHMHCI NIPNINKPPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6EB8DA0", Offset = "0x6EB79A0", VA = "0x186EB8DA0")]
	private static void BDFIAOEPHFG(GameObject MBOKNPAOKBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9B60", Offset = "0x6EB8760", VA = "0x186EB9B60")]
	public static void NNILJDMMKLH(List<Renderer> KIIOMKKNNNM, List<Material> MMGPBBGPFEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6EBA240", Offset = "0x6EB8E40", VA = "0x186EBA240")]
	public static void OKDLEJJMHDF(GameObject OGIDMIHPCNI, Vector3 AGIJMIAONCI, Vector3 BLNJLJGEKAM, float ANKAELJOKCD, JDKMFKHMHCI NIPNINKPPEB, out Vector3 GKOPGMDOIID, out Quaternion OKFAHMKIBPM, out float NKGBDPBNICK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6EB8D00", Offset = "0x6EB7900", VA = "0x186EB8D00")]
	public static RenderTexture AFGIAJFIDFE(int JJJHCGPEBDK, int BABILIHBNMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6EBA010", Offset = "0x6EB8C10", VA = "0x186EBA010")]
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
			[Cpp2IlInjected.Address(RVA = "0x6EBB600", Offset = "0x6EBA200", VA = "0x186EBB600")]
			public NAOIFCEDLIP(GIELIJKIODJ INGDMDMAGEN, GameObject CLIDDMJPMEO, RenderTexture APJLDMINMBA, ImposterRenderConfig OLPPPDJPDOP, JDKMFKHMHCI NIPNINKPPEB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static EKFJNFEBJEA<NAOIFCEDLIP, RenderTexture> AJKKEKMAJOK;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly List<NAOIFCEDLIP> FELEFJFAMMP;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private static int KJIICOPOBDM
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6EB5B70", Offset = "0x6EB4770", VA = "0x186EB5B70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6EB5E50", Offset = "0x6EB4A50", VA = "0x186EB5E50")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject MBOKNPAOKBL, RenderTexture APJLDMINMBA, ImposterRenderConfig HLNAJLKNPMJ, JDKMFKHMHCI NIPNINKPPEB, CancellationToken GFFFFCALMCA, bool NBPIJFGFLFI = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6EB5980", Offset = "0x6EB4580", VA = "0x186EB5980", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6EB5DB0", Offset = "0x6EB49B0", VA = "0x186EB5DB0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6EB5BE0", Offset = "0x6EB47E0", VA = "0x186EB5BE0")]
		private static Task<RenderTexture> OMFCHGIFEOM(NAOIFCEDLIP ODEMEOHLDBB, CancellationToken GFFFFCALMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6EB6210", Offset = "0x6EB4E10", VA = "0x186EB6210")]
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
				[Cpp2IlInjected.Address(RVA = "0x6EBB5E0", Offset = "0x6EBA1E0", VA = "0x186EBB5E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6EBB5C0", Offset = "0x6EBA1C0", VA = "0x186EBB5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EB8900", Offset = "0x6EB7500", VA = "0x186EB8900")]
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
	[Cpp2IlInjected.Address(RVA = "0x6EB7710", Offset = "0x6EB6310", VA = "0x186EB7710")]
	[BBAPFPLPODF(EDNJEIFHIMJ.None)]
	public static void LECKBAIJAMJ(MHOBEFMLEFD JMIFLNNGBHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7850", Offset = "0x6EB6450", VA = "0x186EB7850")]
	[Preserve]
	public GGADFKLDBAH([ACEKLAKDMBL(null)] EFKJJFLPOLL MLCOBAPNNKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7330", Offset = "0x6EB5F30", VA = "0x186EB7330", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7800", Offset = "0x6EB6400", VA = "0x186EB7800", Slot = "5")]
	public void LJGKFLOFOMF(params Type[] LONDNADJAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6EB76C0", Offset = "0x6EB62C0", VA = "0x186EB76C0", Slot = "6")]
	public void GIKHMBHAAJI(params Type[] LONDNADJAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7210", Offset = "0x6EB5E10", VA = "0x186EB7210", Slot = "7")]
	public GameObject DJLEIACDDEM(GameObject OGIDMIHPCNI, Transform ONIJEEBBCHK, bool PFFEMFBBGJJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2D03F80", Offset = "0x2D02B80", VA = "0x182D03F80", Slot = "8")]
	public T DJLEIACDDEM<T>(T OGIDMIHPCNI, Transform ONIJEEBBCHK, bool PFFEMFBBGJJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2D03F50", Offset = "0x2D02B50", VA = "0x182D03F50", Slot = "9")]
	public T DJLEIACDDEM<T>(GameObject OGIDMIHPCNI, Transform ONIJEEBBCHK, bool PFFEMFBBGJJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6EB72A0", Offset = "0x6EB5EA0", VA = "0x186EB72A0", Slot = "10")]
	public GameObject DJLEIACDDEM(GameObject OGIDMIHPCNI, Transform ONIJEEBBCHK, EGIAALPNPFM DAKKAABHBLK, bool PFFEMFBBGJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2D03E70", Offset = "0x2D02A70", VA = "0x182D03E70", Slot = "11")]
	public T DJLEIACDDEM<T>(GameObject OGIDMIHPCNI, Transform ONIJEEBBCHK, EGIAALPNPFM DAKKAABHBLK, bool PFFEMFBBGJJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2D03EC0", Offset = "0x2D02AC0", VA = "0x182D03EC0", Slot = "12")]
	public T DJLEIACDDEM<T>(T OGIDMIHPCNI, Transform ONIJEEBBCHK, EGIAALPNPFM DAKKAABHBLK, bool PFFEMFBBGJJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2D03940", Offset = "0x2D02540", VA = "0x182D03940")]
	private T DJLEIACDDEM<T>(GameObject OGIDMIHPCNI, Transform ONIJEEBBCHK, EGIAALPNPFM DAKKAABHBLK, bool PFFEMFBBGJJ, out GameObject JHPLDFHCGNI) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2D033A0", Offset = "0x2D01FA0", VA = "0x182D033A0")]
	private T AJBKBKHDJAB<T>(GameObject ALBKEDBKENG, EGIAALPNPFM DAKKAABHBLK, bool PFFEMFBBGJJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7430", Offset = "0x6EB6030", VA = "0x186EB7430")]
	private void FECNDDBMGJI(Component DPLEBJGMEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6EB6CC0", Offset = "0x6EB58C0", VA = "0x186EB6CC0")]
	private void BKGCMNKBNPM(Component DPLEBJGMEDE, EGIAALPNPFM DAKKAABHBLK, bool PFFEMFBBGJJ, bool KIMEAFAGDMP, [Optional] Type KGIMPKAGGLI, [Optional] Type DBEBFAELKGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6EB7560", Offset = "0x6EB6160", VA = "0x186EB7560")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EB4F00", Offset = "0x6EB3B00", VA = "0x186EB4F00", Slot = "4")]
		public void PrepareImposter(EGIAALPNPFM DAKKAABHBLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x87DF50", Offset = "0x87CB50", VA = "0x18087DF50")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x87DF50", Offset = "0x87CB50", VA = "0x18087DF50")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A59B80", Offset = "0x2A58780", VA = "0x182A59B80")]
	public EGIAALPNPFM OLBGCODNBJK<T>(T BBALKNFFLHI)
	{
		return default(EGIAALPNPFM);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2A5AA50", Offset = "0x2A59650", VA = "0x182A5AA50")]
	public T PNBJHLBKMLC<T>(T IGBKLJLDCLC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2A5A2B0", Offset = "0x2A58EB0", VA = "0x182A5A2B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1133470", Offset = "0x1132070", VA = "0x181133470")]
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
	[Cpp2IlInjected.Address(RVA = "0x6EB7C90", Offset = "0x6EB6890", VA = "0x186EB7C90")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EBBA90", Offset = "0x6EBA690", VA = "0x186EBBA90", Slot = "4")]
		public void PrepareImposter(EGIAALPNPFM DAKKAABHBLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x87DF50", Offset = "0x87CB50", VA = "0x18087DF50")]
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
	[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1901CE0", Offset = "0x19008E0", VA = "0x181901CE0")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
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
