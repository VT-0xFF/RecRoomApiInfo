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
public class ImposterPreviewCustomFraming : MonoBehaviour, DFGOJPONONJ
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float EMLCLCPDBFI = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "4")]
	public void PrepareImposter(HKIMPMDKHJK FBDHILNJDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x18301F0", Offset = "0x182EFF0", VA = "0x1818301F0")]
	public void SetReferencePoint(Vector3 HCAOBCCCBLG, Quaternion FEODNHIOGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1830060", Offset = "0x182EE60", VA = "0x181830060")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x18301C0", Offset = "0x182EFC0", VA = "0x1818301C0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1830230", Offset = "0x182F030", VA = "0x181830230")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class CKMBFALGABO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public ONHBIEAGBEK EFHIDHLJAIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly Texture BGGBOGPFJBP;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x91A870", Offset = "0x919670", VA = "0x18091A870")]
		public CKMBFALGABO(ONHBIEAGBEK KBCKDFHLEMK, Texture FPPMMLIBFIN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum ABDNIBLDNIC
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
	private class DGBABHKACMO : GGADDACMMKK<Texture>, PDJBOIBDJHI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class MKPOFLPFEGA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public DGBABHKACMO <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
			public MKPOFLPFEGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x18324C0", Offset = "0x18312C0", VA = "0x1818324C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly ONHBIEAGBEK KBCKDFHLEMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly RenderTexture PHLOOGOKCHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly ImposterRenderConfig ADDELCENKMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly CancellationToken KIMBGNGMOGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private GameObject KNIHFFIAPKK;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private NONMCJIBNII HKLDOAOFCPF
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x182CD50", Offset = "0x182BB50", VA = "0x18182CD50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public AHPDIJDJLKD<Texture> CFCKFGNBBBF
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x182CB10", Offset = "0x182B910", VA = "0x18182CB10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Task NPJBNIGJPFK
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x81BCC0", Offset = "0x81AAC0", VA = "0x18081BCC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Task<Texture> JGPPEGPPDOC
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x81BCC0", Offset = "0x81AAC0", VA = "0x18081BCC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x182CD60", Offset = "0x182BB60", VA = "0x18182CD60")]
		public DGBABHKACMO(ONHBIEAGBEK KBCKDFHLEMK, RenderTexture PHLOOGOKCHA, ImposterRenderConfig ADDELCENKMO, CancellationToken KIMBGNGMOGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x182CB70", Offset = "0x182B970", VA = "0x18182CB70")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(MKPOFLPFEGA))]
		private Task<Texture> JFJCGHIIIKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x182CB60", Offset = "0x182B960", VA = "0x18182CB60", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x182CCC0", Offset = "0x182BAC0", VA = "0x18182CCC0")]
		private static void MIEAKNJBLJP(GameObject KNIHFFIAPKK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class AEELNGCDPHB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public AEELNGCDPHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x182C080", Offset = "0x182AE80", VA = "0x18182C080", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
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
	[CAILPCABGNE(PNNHMCGEKHG.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private ABDNIBLDNIC size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	[EFOKCIAHEIC("size", 0)]
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
	private RenderTexture HMGNILCAIMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CKBECKAEMDL<GameObject> FGAJBGHCFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private CEEENLABNNK MAMPKCAKOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private CancellationTokenSource DHPHKDAADNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private GGADDACMMKK<Texture> BJFONHMJHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private ONHBIEAGBEK KONKLMODAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Texture DGLLMCOIPOO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private RenderTexture OAFJOEPFAMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1830410", Offset = "0x182F210", VA = "0x181830410")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x922C40", Offset = "0x921A40", VA = "0x180922C40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private ONHBIEAGBEK EFHIDHLJAIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9318F0", Offset = "0x9306F0", VA = "0x1809318F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1830670", Offset = "0x182F470", VA = "0x181830670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool AAPJOFNELLL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD3F3C0", Offset = "0xD3E1C0", VA = "0x180D3F3C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int CKCFJGPKPLB
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1830280", Offset = "0x182F080", VA = "0x181830280")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1830270", Offset = "0x182F070", VA = "0x181830270")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x18307C0", Offset = "0x182F5C0", VA = "0x1818307C0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x18302A0", Offset = "0x182F0A0", VA = "0x1818302A0")]
	private void DPODDNCNKCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1830AE0", Offset = "0x182F8E0", VA = "0x181830AE0")]
	public void Set(ONHBIEAGBEK CPJCBBLLEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1830B30", Offset = "0x182F930", VA = "0x181830B30")]
	public void Set(Texture FPPMMLIBFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1830AF0", Offset = "0x182F8F0", VA = "0x181830AF0")]
	public void Set(CKMBFALGABO KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1830290", Offset = "0x182F090", VA = "0x181830290")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x18308C0", Offset = "0x182F6C0", VA = "0x1818308C0")]
	public void SetInternal(ONHBIEAGBEK CPJCBBLLEKH, [Optional] Texture NOAAJECIEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x18308B0", Offset = "0x182F6B0", VA = "0x1818308B0")]
	public void SetCustomSize(int MJHBEKNMLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x958740", Offset = "0x957540", VA = "0x180958740")]
	public void SetAntiAliasing(int AFGDPIGAPBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1830330", Offset = "0x182F130", VA = "0x181830330")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(AEELNGCDPHB))]
	private void FLDBINNMJNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1830580", Offset = "0x182F380", VA = "0x181830580")]
	private void LFEMKOKIOPG(Texture FPPMMLIBFIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1830B40", Offset = "0x182F940", VA = "0x181830B40")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct IDAGEHMKNOA
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static IDAGEHMKNOA HFALOFJOILE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float DOBIJIEEPLH;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xF741A0", Offset = "0xF72FA0", VA = "0x180F741A0")]
	public IDAGEHMKNOA(float NDNIDBNEMHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DeferredImposterSpawnManager : SingletonMonoBehaviour<DeferredImposterSpawnManager>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private readonly struct ODBMDKMPMBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly ONHBIEAGBEK BDLDMDCDABN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly string EKLOELJJDOP;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAFE080", Offset = "0xAFCE80", VA = "0x180AFE080")]
		public ODBMDKMPMBJ(ONHBIEAGBEK GMOLEGNGCMC, string IEHCDBOLIOG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class KGOPGDJNIEL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public ODBMDKMPMBJ queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public DeferredImposterSpawnManager <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private ONHBIEAGBEK <request>5__1;

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
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public KGOPGDJNIEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1832090", Offset = "0x1830E90", VA = "0x181832090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private IRecRoomQualityConfigProvider BBEJJEFCDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private JGOBHBHFKIP<ODBMDKMPMBJ, GameObject> LILADFDCJIO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public HACNKBEKCFB FGJHCEKNAKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7F63B0", Offset = "0x7F51B0", VA = "0x1807F63B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private JGOBHBHFKIP<ODBMDKMPMBJ, GameObject> BELEJIGDIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x182DA50", Offset = "0x182C850", VA = "0x18182DA50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private int GBPBGIACCCK
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x182DBB0", Offset = "0x182C9B0", VA = "0x18182DBB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x182D800", Offset = "0x182C600", VA = "0x18182D800", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x182DDD0", Offset = "0x182CBD0", VA = "0x18182DDD0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x182D8B0", Offset = "0x182C6B0", VA = "0x18182D8B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(KGOPGDJNIEL))]
	private Task<GameObject> BAGMMNCKFKD(ODBMDKMPMBJ MAHAGCLFLEN, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x182DC00", Offset = "0x182CA00", VA = "0x18182DC00")]
	public Task<GameObject> LoadItemAsync(ONHBIEAGBEK GMOLEGNGCMC, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x182DE40", Offset = "0x182CC40", VA = "0x18182DE40")]
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
		[CAILPCABGNE(PNNHMCGEKHG.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const int FLDPEOAKOGG = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const int KKMDFNGJLHB = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly List<Material> ACFDKPNFGGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool HKLBMMJHBPF;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1830D20", Offset = "0x182FB20", VA = "0x181830D20")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1830C30", Offset = "0x182FA30", VA = "0x181830C30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1830F60", Offset = "0x182FD60", VA = "0x181830F60")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ONHBIEAGBEK
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string FHMEOIMOMPL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IDAGEHMKNOA IDAGEHMKNOA
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action FGCBNPBFMGN;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> GNFFLEGEHLP(CancellationToken KIMBGNGMOGB);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DGKAGCDIIHH(ONHBIEAGBEK FGBEDAPNDEP);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HKEDIBHLIAH();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GLPMGBBICDF();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MPLHMIOJNNJ(out GGADDACMMKK<Texture> JNLAFCBJHLF);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KCFGBGAIJPE
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x1831FB0", Offset = "0x1830DB0", VA = "0x181831FB0")]
	public static bool GMMCOHFELCM(ONHBIEAGBEK PCLBJBGHFKJ, ONHBIEAGBEK OFOKLFMNONP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface COGBNJOLHKM
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> NAGLLNGMFDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<Type> BNCJJDIICGH
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
		[Cpp2IlInjected.Address(RVA = "0x98DDD0", Offset = "0x98CBD0", VA = "0x18098DDD0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HACNKBEKCFB
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACBPHBJIMHN(params Type[] MECLDLOMGDJ);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HIJEKJPPCAL(params Type[] MECLDLOMGDJ);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject IPENEAEPAKE(GameObject NDMDIDJLLII, Transform GMBPOBACJJI, bool GBLMHNOPODP = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T IPENEAEPAKE<T>(T NDMDIDJLLII, Transform GMBPOBACJJI, bool GBLMHNOPODP = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T IPENEAEPAKE<T>(GameObject NDMDIDJLLII, Transform GMBPOBACJJI, bool GBLMHNOPODP = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject IPENEAEPAKE(GameObject NDMDIDJLLII, Transform GMBPOBACJJI, HKIMPMDKHJK FBDHILNJDOE, bool GBLMHNOPODP);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T IPENEAEPAKE<T>(GameObject NDMDIDJLLII, Transform GMBPOBACJJI, HKIMPMDKHJK FBDHILNJDOE, bool GBLMHNOPODP) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T IPENEAEPAKE<T>(T NDMDIDJLLII, Transform GMBPOBACJJI, HKIMPMDKHJK FBDHILNJDOE, bool GBLMHNOPODP) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class EPKICKHAOCE
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly List<URPLight> OADOOKONLCP;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly Vector3 GMCELAINHKF;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly Vector3 CCIEFEMPKPL;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static Camera PJNFFLAFHEG;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public const string GPLAAGLEECM = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const FOCIDJNPDBE NBHICLDMHOL = FOCIDJNPDBE.Water;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly List<Renderer> BKBNPKGHGAO;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static AmbientMode EHBFFJLEBON;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static Color OJBKLNLIOAN;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static Color FFIFLHLEEDN;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static Color PAAPEMFFMEC;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static Cubemap BJJKDDBCAOO;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private static bool FHDOJMEGACB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static Camera LHCLHIKGAFK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x182F280", Offset = "0x182E080", VA = "0x18182F280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x182E9A0", Offset = "0x182D7A0", VA = "0x18182E9A0")]
	public static void GEBCHHCNIGD(Vector3 NGLGBPIGPMD, Quaternion EIPPEBFBMEL, ImposterRenderConfig JICGILIKLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x182EF70", Offset = "0x182DD70", VA = "0x18182EF70")]
	private static void INIJBJGNBFD(Vector3 NGLGBPIGPMD, Quaternion EIPPEBFBMEL, URPLight LDHMELKHHIB, ImposterRenderConfig.LightConfig HANMNPKBGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x182E710", Offset = "0x182D510", VA = "0x18182E710")]
	public static void FFAKPAJCIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x182E240", Offset = "0x182D040", VA = "0x18182E240")]
	private static void EAFJOGHMECI(int MBGJNJLCDDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x182E0C0", Offset = "0x182CEC0", VA = "0x18182E0C0")]
	public static void BMOFJHLOGAP(ImposterRenderConfig JICGILIKLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x182E610", Offset = "0x182D410", VA = "0x18182E610")]
	public static void ENIFEMFBKMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x182F9C0", Offset = "0x182E7C0", VA = "0x18182F9C0")]
	public static void MNBEFDCAFPB(GameObject FMPPPEEDMLC, RenderTexture PHLOOGOKCHA, ImposterRenderConfig JICGILIKLDM, IDAGEHMKNOA CLILEIKPEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x182F4C0", Offset = "0x182E2C0", VA = "0x18182F4C0")]
	private static void MGFAHOOEOCK(GameObject FMPPPEEDMLC, RenderTexture PHLOOGOKCHA, ImposterRenderConfig JICGILIKLDM, IDAGEHMKNOA CLILEIKPEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x182ECC0", Offset = "0x182DAC0", VA = "0x18182ECC0")]
	private static void HFOJPNGBCPM(GameObject FMPPPEEDMLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x182E800", Offset = "0x182D600", VA = "0x18182E800")]
	public static void FMONKAJGMIF(List<Renderer> GEEKICILKAP, List<Material> APMGFPICHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x182FB90", Offset = "0x182E990", VA = "0x18182FB90")]
	public static void NFAEHONBAGM(GameObject NDMDIDJLLII, Vector3 NOLGBLKHJJJ, Vector3 HDFNOHAIHPP, float EPADGJPNBJL, IDAGEHMKNOA CLILEIKPEIF, out Vector3 LKPEGOJLAMG, out Quaternion KDMFPEJGMKD, out float JJEIDMFNDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x182EC20", Offset = "0x182DA20", VA = "0x18182EC20")]
	public static RenderTexture HBNBPNEKIIN(int OAIIPMIIANM, int JGPNGKDAHKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x182DE90", Offset = "0x182CC90", VA = "0x18182DE90")]
	public static void ANBMJNFIBOO()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public struct FPHLIEDLCBG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public JONKAPABINE LPMJENPJDAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public GameObject FHEAEAGIFNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public RenderTexture OAFJOEPFAMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public ImposterRenderConfig ANIJBPDDFJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public IDAGEHMKNOA IDAGEHMKNOA;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x182FFB0", Offset = "0x182EDB0", VA = "0x18182FFB0")]
			public FPHLIEDLCBG(JONKAPABINE PBHKCILCHEH, GameObject FHPEGINHLJN, RenderTexture PHLOOGOKCHA, ImposterRenderConfig ADDELCENKMO, IDAGEHMKNOA CLILEIKPEIF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static JGOBHBHFKIP<FPHLIEDLCBG, RenderTexture> AKPHHDAJNKG;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly List<FPHLIEDLCBG> JMHADPMAHDI;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private static int PNIFDJMOMCE
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x182D2F0", Offset = "0x182C0F0", VA = "0x18182D2F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x182D400", Offset = "0x182C200", VA = "0x18182D400")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject FMPPPEEDMLC, RenderTexture PHLOOGOKCHA, ImposterRenderConfig JICGILIKLDM, IDAGEHMKNOA CLILEIKPEIF, CancellationToken KIMBGNGMOGB, bool NLCHHALLJJA = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x182CF30", Offset = "0x182BD30", VA = "0x18182CF30", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x182D360", Offset = "0x182C160", VA = "0x18182D360", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x182D120", Offset = "0x182BF20", VA = "0x18182D120")]
		private static Task<RenderTexture> JNEGHPMHKGL(FPHLIEDLCBG IHFBBCIAGHG, CancellationToken KIMBGNGMOGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x182D7C0", Offset = "0x182C5C0", VA = "0x18182D7C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x18324A0", Offset = "0x18312A0", VA = "0x1818324A0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x1832480", Offset = "0x1831280", VA = "0x181832480")]
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
		[Cpp2IlInjected.Address(RVA = "0x1830BE0", Offset = "0x182F9E0", VA = "0x181830BE0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class KBONFLKOGOF : IDisposable, HACNKBEKCFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly HashSet<Type> LAOAJNCPMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly HashSet<Type> KPIBMJGHEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private Transform CPLPFMLANFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly List<Component> HJHCOHKBGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> KJNPGGHOFCI;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1831190", Offset = "0x182FF90", VA = "0x181831190")]
	[GIEEOCCBBIJ(PFHGMCKNAFN.None)]
	public static void COJJPFAEHHI(OBEPLHILJNL PIOBINFNKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1831B70", Offset = "0x1830970", VA = "0x181831B70")]
	[Preserve]
	public KBONFLKOGOF([DNPFPOCMFCA(null)] COGBNJOLHKM FCHNHKMMICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1831280", Offset = "0x1830080", VA = "0x181831280", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1830FE0", Offset = "0x182FDE0", VA = "0x181830FE0", Slot = "5")]
	public void ACBPHBJIMHN(params Type[] MECLDLOMGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x18314B0", Offset = "0x18302B0", VA = "0x1818314B0", Slot = "6")]
	public void HIJEKJPPCAL(params Type[] MECLDLOMGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1831A50", Offset = "0x1830850", VA = "0x181831A50", Slot = "7")]
	public GameObject IPENEAEPAKE(GameObject NDMDIDJLLII, Transform GMBPOBACJJI, bool GBLMHNOPODP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2E47C10", Offset = "0x2E46A10", VA = "0x182E47C10", Slot = "8")]
	public T IPENEAEPAKE<T>(T NDMDIDJLLII, Transform GMBPOBACJJI, bool GBLMHNOPODP = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2E47D10", Offset = "0x2E46B10", VA = "0x182E47D10", Slot = "9")]
	public T IPENEAEPAKE<T>(GameObject NDMDIDJLLII, Transform GMBPOBACJJI, bool GBLMHNOPODP = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x1831AE0", Offset = "0x18308E0", VA = "0x181831AE0", Slot = "10")]
	public GameObject IPENEAEPAKE(GameObject NDMDIDJLLII, Transform GMBPOBACJJI, HKIMPMDKHJK FBDHILNJDOE, bool GBLMHNOPODP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2E48270", Offset = "0x2E47070", VA = "0x182E48270", Slot = "11")]
	public T IPENEAEPAKE<T>(GameObject NDMDIDJLLII, Transform GMBPOBACJJI, HKIMPMDKHJK FBDHILNJDOE, bool GBLMHNOPODP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2E47C80", Offset = "0x2E46A80", VA = "0x182E47C80", Slot = "12")]
	public T IPENEAEPAKE<T>(T NDMDIDJLLII, Transform GMBPOBACJJI, HKIMPMDKHJK FBDHILNJDOE, bool GBLMHNOPODP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2E47D40", Offset = "0x2E46B40", VA = "0x182E47D40")]
	private T IPENEAEPAKE<T>(GameObject NDMDIDJLLII, Transform GMBPOBACJJI, HKIMPMDKHJK FBDHILNJDOE, bool GBLMHNOPODP, out GameObject NLHNMPDKODG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2E47670", Offset = "0x2E46470", VA = "0x182E47670")]
	private T FGAJDGCGMNG<T>(GameObject KKHNMHOFPEF, HKIMPMDKHJK FBDHILNJDOE, bool GBLMHNOPODP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1831380", Offset = "0x1830180", VA = "0x181831380")]
	private void GIGGGHIFIPK(Component AMMGBKBHPFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1831500", Offset = "0x1830300", VA = "0x181831500")]
	private void INCAOFABCAK(Component AMMGBKBHPFA, HKIMPMDKHJK FBDHILNJDOE, bool GBLMHNOPODP, bool FMAOGOLPGCC, [Optional] Type PPFNIPICKIE, [Optional] Type GLFFJBFGMOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x1831030", Offset = "0x182FE30", VA = "0x181831030")]
	private void CLGINEHNBOB(GameObject KKHNMHOFPEF)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class CenterInImposter : MonoBehaviour, DFGOJPONONJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x182C9A0", Offset = "0x182B7A0", VA = "0x18182C9A0", Slot = "4")]
		public void PrepareImposter(HKIMPMDKHJK FBDHILNJDOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x98DDD0", Offset = "0x98CBD0", VA = "0x18098DDD0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x98DDD0", Offset = "0x98CBD0", VA = "0x18098DDD0")]
		public KeepImposterUpright()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct HKIMPMDKHJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private Dictionary<Type, object> MIGHKGPAPNE;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x31E2640", Offset = "0x31E1440", VA = "0x1831E2640")]
	public HKIMPMDKHJK MDELLMLPPIN<T>(T MFGBNMFDMAB)
	{
		return default(HKIMPMDKHJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x31E2520", Offset = "0x31E1320", VA = "0x1831E2520")]
	public T KOLGIMOOKDG<T>(T DGNBLLFJDJH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x31E1D80", Offset = "0x31E0B80", VA = "0x1831E1D80")]
	public bool BBJAFPAMNLG<T>(out T MFGBNMFDMAB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct DFBHLHLKOOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool DIBOCNDIBDP;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x182CB00", Offset = "0x182B900", VA = "0x18182CB00")]
	public DFBHLHLKOOC(bool KHIBDLJMKMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct EALNFHOKONH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool EDAIKPAECFA;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x182DE80", Offset = "0x182CC80", VA = "0x18182DE80")]
	public EALNFHOKONH(bool LEJIPNKLLFO)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class ScaleInImposter : MonoBehaviour, DFGOJPONONJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1832C20", Offset = "0x1831A20", VA = "0x181832C20", Slot = "4")]
		public void PrepareImposter(HKIMPMDKHJK FBDHILNJDOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x98DDD0", Offset = "0x98CBD0", VA = "0x18098DDD0")]
		public ScaleInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface DFGOJPONONJ
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(HKIMPMDKHJK FBDHILNJDOE);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class HGBHIGOCPLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public HGBHIGOCPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8AA350", Offset = "0x8A9150", VA = "0x1808AA350")]
	public static string GPDLHKANJHK(byte[] OEIGPAJDAPF, byte[] EKAHBFHGOCF)
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
