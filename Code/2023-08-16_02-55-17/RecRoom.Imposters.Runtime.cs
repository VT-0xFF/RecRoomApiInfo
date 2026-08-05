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
public class ImposterPreviewCustomFraming : MonoBehaviour, NJBDECJOCJK
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float HIGAKDFADAI = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "4")]
	public void PrepareImposter(PPIPAHAHKDN HPANENBGKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6DCC2F0", Offset = "0x6DCB4F0", VA = "0x186DCC2F0")]
	public void SetReferencePoint(Vector3 DGDMDKFMBBA, Quaternion KGFPECIFPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6DCC160", Offset = "0x6DCB360", VA = "0x186DCC160")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6DCC2C0", Offset = "0x6DCB4C0", VA = "0x186DCC2C0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6DCC330", Offset = "0x6DCB530", VA = "0x186DCC330")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class ILAJFEJIEHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public MDAEDFIOOJD IDALIALMEMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly Texture NAADNIBECNI;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x927D00", Offset = "0x926F00", VA = "0x180927D00")]
		public ILAJFEJIEHJ(MDAEDFIOOJD IKOMPEAOMAH, Texture BNHKLKELIKA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum IJKAPBEOMIE
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
	private class HHBFGDKOKAE : ODOCIMMOCAD<Texture>, LAFIHHFBOFA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class PCPJGPBLJPE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public HHBFGDKOKAE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private GameObject <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
			public PCPJGPBLJPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6DCECF0", Offset = "0x6DCDEF0", VA = "0x186DCECF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly MDAEDFIOOJD IKOMPEAOMAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly RenderTexture CCLKBFGIIGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly ImposterRenderConfig IEOIJNACBPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly CancellationToken MELLLMEKJLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private GameObject DKPPPIGHLPK;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public OOMFLHAHLDK<Texture> OBNMHPONIIK
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6DCBD50", Offset = "0x6DCAF50", VA = "0x186DCBD50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Task<Texture> HPADJMKFJAG
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x890860", Offset = "0x88FA60", VA = "0x180890860", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6DCBF90", Offset = "0x6DCB190", VA = "0x186DCBF90")]
		public HHBFGDKOKAE(MDAEDFIOOJD IKOMPEAOMAH, RenderTexture CCLKBFGIIGK, ImposterRenderConfig IEOIJNACBPP, CancellationToken MELLLMEKJLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6DCBDA0", Offset = "0x6DCAFA0", VA = "0x186DCBDA0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(PCPJGPBLJPE))]
		private Task<Texture> DKLBDGAOHLE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6DCBEF0", Offset = "0x6DCB0F0", VA = "0x186DCBEF0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6DCBF00", Offset = "0x6DCB100", VA = "0x186DCBF00")]
		private static void HGFIIJLEBBN(GameObject DKPPPIGHLPK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class OHOOJNOLEGI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public OHOOJNOLEGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6DCE510", Offset = "0x6DCD710", VA = "0x186DCE510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
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
	[FLLPKBPMDCP(PFIMANMCDOB.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private IJKAPBEOMIE size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	[HFEBOLHCHJD("size", 0)]
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
	private RenderTexture KIPELIHLAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private LIOCOMLDBDP<GameObject> LLCFKBAAHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private CICCNDFLPHA LCAJGLNPGCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private CancellationTokenSource OEIHHLAPKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private ODOCIMMOCAD<Texture> JLPFLGPAGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private MDAEDFIOOJD CCBLJMOJHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Texture LKEFIDCIODB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private RenderTexture DDCKOCGFKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6DCC3A0", Offset = "0x6DCB5A0", VA = "0x186DCC3A0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8C35B0", Offset = "0x8C27B0", VA = "0x1808C35B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private MDAEDFIOOJD IDALIALMEMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9B1AE0", Offset = "0x9B0CE0", VA = "0x1809B1AE0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6DCC530", Offset = "0x6DCB730", VA = "0x186DCC530")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool LNIJIFJMLMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xBAE330", Offset = "0xBAD530", VA = "0x180BAE330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int BNEDBNBDBMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6DCC380", Offset = "0x6DCB580", VA = "0x186DCC380")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6DCC370", Offset = "0x6DCB570", VA = "0x186DCC370")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6DCC8E0", Offset = "0x6DCBAE0", VA = "0x186DCC8E0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6DCC850", Offset = "0x6DCBA50", VA = "0x186DCC850")]
	private void JAMKCGFCODN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6DCCBF0", Offset = "0x6DCBDF0", VA = "0x186DCCBF0")]
	public void Set(MDAEDFIOOJD HLOAHOEKBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6DCCC40", Offset = "0x6DCBE40", VA = "0x186DCCC40")]
	public void Set(Texture BNHKLKELIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6DCCC00", Offset = "0x6DCBE00", VA = "0x186DCCC00")]
	public void Set(ILAJFEJIEHJ NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6DCC390", Offset = "0x6DCB590", VA = "0x186DCC390")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6DCC9E0", Offset = "0x6DCBBE0", VA = "0x186DCC9E0")]
	public void SetInternal(MDAEDFIOOJD HLOAHOEKBLL, [Optional] Texture JBGKJBFKNFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6DCC9D0", Offset = "0x6DCBBD0", VA = "0x186DCC9D0")]
	public void SetCustomSize(int DPHPEGNNJIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xBB0690", Offset = "0xBAF890", VA = "0x180BB0690")]
	public void SetAntiAliasing(int IHCJJCBEHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6DCC770", Offset = "0x6DCB970", VA = "0x186DCC770")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OHOOJNOLEGI))]
	private void IBGNAJOBEML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6DCC680", Offset = "0x6DCB880", VA = "0x186DCC680")]
	private void EMHEHNIDBCD(Texture BNHKLKELIKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6DCCC50", Offset = "0x6DCBE50", VA = "0x186DCCC50")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct AFNLJLEIAMN
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static AFNLJLEIAMN LLDDGPBIBIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float PIIFHMNIENG;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x28BFEF0", Offset = "0x28BF0F0", VA = "0x1828BFEF0")]
	public AFNLJLEIAMN(float EDEDIMNKIML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DeferredImposterSpawnManager : SingletonMonoBehaviour<DeferredImposterSpawnManager>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private readonly struct KIFBHCNHMGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly MDAEDFIOOJD FNLEBNDOEGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly string POPEMGEEHOC;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x949BA0", Offset = "0x948DA0", VA = "0x180949BA0")]
		public KIFBHCNHMGO(MDAEDFIOOJD EJMLIEPBJKP, string BIMCDJPIMPD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class LMLFHKBOPLE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public KIFBHCNHMGO queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public DeferredImposterSpawnManager <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private MDAEDFIOOJD <request>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private GameObject <imposter>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private GameObject <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public LMLFHKBOPLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6DCE050", Offset = "0x6DCD250", VA = "0x186DCE050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private IRecRoomQualityConfigProvider BFLBCOMILKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private HMFFJAPKCNP<KIFBHCNHMGO, GameObject> POEPGELMDDE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public CFKNJDACDDE PEPMIHELJGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x909DA0", Offset = "0x908FA0", VA = "0x180909DA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private HMFFJAPKCNP<KIFBHCNHMGO, GameObject> AONLLOEGANG
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6DCB920", Offset = "0x6DCAB20", VA = "0x186DCB920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private int NPDEBIPGKDL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6DCBC50", Offset = "0x6DCAE50", VA = "0x186DCBC50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6DCB6D0", Offset = "0x6DCA8D0", VA = "0x186DCB6D0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6DCBCA0", Offset = "0x6DCAEA0", VA = "0x186DCBCA0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6DCB780", Offset = "0x6DCA980", VA = "0x186DCB780")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LMLFHKBOPLE))]
	private Task<GameObject> FBHELFGLKGD(KIFBHCNHMGO BHHKBPBJLHJ, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6DCBA80", Offset = "0x6DCAC80", VA = "0x186DCBA80")]
	public Task<GameObject> LoadItemAsync(MDAEDFIOOJD EJMLIEPBJKP, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6DCBD10", Offset = "0x6DCAF10", VA = "0x186DCBD10")]
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
		[FLLPKBPMDCP(PFIMANMCDOB.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const int IOAPEFMBHPJ = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const int ELJMPLEBCCK = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly List<Material> GNMPBNKDCCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool DNOMHBLDKNP;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6DCCE30", Offset = "0x6DCC030", VA = "0x186DCCE30")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6DCCD40", Offset = "0x6DCBF40", VA = "0x186DCCD40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6DCD080", Offset = "0x6DCC280", VA = "0x186DCD080")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MDAEDFIOOJD
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	string BPAKMFAFPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	AFNLJLEIAMN AFNLJLEIAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action IMJHBIJFMMF;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> GBBOFIECKIJ(CancellationToken MELLLMEKJLC);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AIODCINPHKB(MDAEDFIOOJD JMNBIHILIIC);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BMMFJKCDGEE();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LFMDAGKJMHN();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LCBCFCPPGHP(out ODOCIMMOCAD<Texture> DNOPEOKPNFL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class AOOHNJLEGIA
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6DC8E20", Offset = "0x6DC8020", VA = "0x186DC8E20")]
	public static bool IBKCGJPFLIJ(MDAEDFIOOJD MOPNJJINJOD, MDAEDFIOOJD MCHJGAOEFEH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OLMEBLHOHEP
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	IEnumerable<Type> KGPBOJPPLPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> MPOMGEBAPEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x89BCA0", Offset = "0x89AEA0", VA = "0x18089BCA0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface CFKNJDACDDE
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GameObject PFMKIECNBCB(GameObject NJPHBJKHIEL, Transform OJEMCPHOKBP, bool NANALDIPEII = false);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T PFMKIECNBCB<T>(T NJPHBJKHIEL, Transform OJEMCPHOKBP, bool NANALDIPEII = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T PFMKIECNBCB<T>(GameObject NJPHBJKHIEL, Transform OJEMCPHOKBP, bool NANALDIPEII = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject PFMKIECNBCB(GameObject NJPHBJKHIEL, Transform OJEMCPHOKBP, PPIPAHAHKDN HPANENBGKED, bool NANALDIPEII);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class BOJNCKNDLNP
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly List<URPLight> HMMGJPHIOJG;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly Vector3 CELOJEOIFMK;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly Vector3 DEAHOLHFPPO;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static Camera NILIECAEPFC;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static readonly List<Renderer> KBPNGMLJIGD;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static AmbientMode PGJALLBGDLF;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static Color ABIPKJBIBDK;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static Color GBENNPABMPK;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static Color EPEDHGNJEIM;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static Cubemap OGNOHJHOOBI;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static bool NKPJBNMPAPP;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static Camera GDBAKMCAJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6DC8F00", Offset = "0x6DC8100", VA = "0x186DC8F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6DCA460", Offset = "0x6DC9660", VA = "0x186DCA460")]
	public static void LLNLLFKCEBE(Vector3 AHCAMJGCIEN, Quaternion FNLGOIIJFHF, ImposterRenderConfig JAINOKNFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6DC9C30", Offset = "0x6DC8E30", VA = "0x186DC9C30")]
	private static void GNIDHJCOBBJ(Vector3 AHCAMJGCIEN, Quaternion FNLGOIIJFHF, URPLight GHOKPEJOMHN, ImposterRenderConfig.LightConfig HAJKIDHBFLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6DC9140", Offset = "0x6DC8340", VA = "0x186DC9140")]
	public static void BGHACFJOKJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6DCA090", Offset = "0x6DC9290", VA = "0x186DCA090")]
	private static void KFICMNHPIKJ(int NOJKMDAJNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6DC9F10", Offset = "0x6DC9110", VA = "0x186DC9F10")]
	public static void JPMLLFBDKDK(ImposterRenderConfig JAINOKNFFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6DC9B30", Offset = "0x6DC8D30", VA = "0x186DC9B30")]
	public static void GLKIBPJGPBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6DCA6E0", Offset = "0x6DC98E0", VA = "0x186DCA6E0")]
	public static void MLGCGGHDKNN(GameObject CBEABNFBMLH, RenderTexture CCLKBFGIIGK, ImposterRenderConfig JAINOKNFFAP, AFNLJLEIAMN LPGDGCFLIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6DC9530", Offset = "0x6DC8730", VA = "0x186DC9530")]
	private static void FBIHECDIJPL(GameObject CBEABNFBMLH, RenderTexture CCLKBFGIIGK, ImposterRenderConfig JAINOKNFFAP, AFNLJLEIAMN LPGDGCFLIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6DCA8B0", Offset = "0x6DC9AB0", VA = "0x186DCA8B0")]
	private static void OCFLIOGDOLD(GameObject CBEABNFBMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6DC9230", Offset = "0x6DC8430", VA = "0x186DC9230")]
	public static void DPFJBCMDFMD(GameObject NJPHBJKHIEL, Vector3 OJMAIBAJJKP, Vector3 CCHCPIJPAKK, float OALNNEINBFI, AFNLJLEIAMN LPGDGCFLIKE, out Vector3 KGDECCDLADM, out Quaternion HHDLLGDODCH, out float FFINCCPGJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6DC9A90", Offset = "0x6DC8C90", VA = "0x186DC9A90")]
	public static RenderTexture GDLGPIAHAMP(int CEBEKFANDMD, int CPPKAEGLEMG)
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public struct NPEOFDBBNGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public MGJKNPFOJOG CHJHKAOFFND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public GameObject KEHAADNGLGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public RenderTexture DDCKOCGFKOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public ImposterRenderConfig NBBHLDIOBLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public AFNLJLEIAMN AFNLJLEIAMN;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6DCE4A0", Offset = "0x6DCD6A0", VA = "0x186DCE4A0")]
			public NPEOFDBBNGH(MGJKNPFOJOG HBNJPDHFEKF, GameObject AAKAGLCGEEC, RenderTexture CCLKBFGIIGK, ImposterRenderConfig IEOIJNACBPP, AFNLJLEIAMN LPGDGCFLIKE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static HMFFJAPKCNP<NPEOFDBBNGH, RenderTexture> PHODCCOJGHJ;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static readonly List<NPEOFDBBNGH> ALCBNHILEEP;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private static int JFFBECPACMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6DCAFF0", Offset = "0x6DCA1F0", VA = "0x186DCAFF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6DCB2D0", Offset = "0x6DCA4D0", VA = "0x186DCB2D0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject CBEABNFBMLH, RenderTexture CCLKBFGIIGK, ImposterRenderConfig JAINOKNFFAP, AFNLJLEIAMN LPGDGCFLIKE, CancellationToken MELLLMEKJLC, bool CNELMAOLBFG = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6DCAE00", Offset = "0x6DCA000", VA = "0x186DCAE00", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6DCB230", Offset = "0x6DCA430", VA = "0x186DCB230", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6DCB060", Offset = "0x6DCA260", VA = "0x186DCB060")]
		private static Task<RenderTexture> LCAIAIDGBJI(NPEOFDBBNGH JKAGKOIBFFJ, CancellationToken MELLLMEKJLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6DCB690", Offset = "0x6DCA890", VA = "0x186DCB690")]
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
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x6DCE480", Offset = "0x6DCD680", VA = "0x186DCE480")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x6DCE460", Offset = "0x6DCD660", VA = "0x186DCE460")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[ColorUsage(false, true)]
		[Header("Environment Lighting")]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6DCCCF0", Offset = "0x6DCBEF0", VA = "0x186DCCCF0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class KKHJDFIHBHD : IDisposable, CFKNJDACDDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly HashSet<Type> NHEMGMPELHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly HashSet<Type> OKCBABAJPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private Transform HOBMPLMMGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly List<Component> MKAHPFJPMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> JKFHCEEFMLK;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6DCD100", Offset = "0x6DCC300", VA = "0x186DCD100")]
	[GKCPJLBLCDF(EHLDMJJGFKP.None)]
	public static void COJDMCIPHFF(JFLMNMMPBBG AKLNKNCLGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6DCDC10", Offset = "0x6DCCE10", VA = "0x186DCDC10")]
	[Preserve]
	public KKHJDFIHBHD([NDGONEEEGIA(null)] OLMEBLHOHEP PJCHMDINCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6DCD890", Offset = "0x6DCCA90", VA = "0x186DCD890", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6DCDB80", Offset = "0x6DCCD80", VA = "0x186DCDB80", Slot = "5")]
	public GameObject PFMKIECNBCB(GameObject NJPHBJKHIEL, Transform OJEMCPHOKBP, bool NANALDIPEII = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1CD5360", Offset = "0x1CD4560", VA = "0x181CD5360", Slot = "6")]
	public T PFMKIECNBCB<T>(T NJPHBJKHIEL, Transform OJEMCPHOKBP, bool NANALDIPEII = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1CD53D0", Offset = "0x1CD45D0", VA = "0x181CD53D0", Slot = "7")]
	public T PFMKIECNBCB<T>(GameObject NJPHBJKHIEL, Transform OJEMCPHOKBP, bool NANALDIPEII = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6DCDAF0", Offset = "0x6DCCCF0", VA = "0x186DCDAF0", Slot = "8")]
	public GameObject PFMKIECNBCB(GameObject NJPHBJKHIEL, Transform OJEMCPHOKBP, PPIPAHAHKDN HPANENBGKED, bool NANALDIPEII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1CD5400", Offset = "0x1CD4600", VA = "0x181CD5400", Slot = "9")]
	public T PFMKIECNBCB<T>(GameObject NJPHBJKHIEL, Transform OJEMCPHOKBP, PPIPAHAHKDN HPANENBGKED, bool NANALDIPEII) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x1CD5450", Offset = "0x1CD4650", VA = "0x181CD5450")]
	private T PFMKIECNBCB<T>(GameObject NJPHBJKHIEL, Transform OJEMCPHOKBP, PPIPAHAHKDN HPANENBGKED, bool NANALDIPEII, out GameObject NCINOCMBPBO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1CD4DB0", Offset = "0x1CD3FB0", VA = "0x181CD4DB0")]
	private T EPMNLCNGACJ<T>(GameObject HAAGKPEGEHP, PPIPAHAHKDN HPANENBGKED, bool NANALDIPEII) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6DCD1F0", Offset = "0x6DCC3F0", VA = "0x186DCD1F0")]
	private void CPIHHODJOAH(Component HPFFEAJFMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6DCD320", Offset = "0x6DCC520", VA = "0x186DCD320")]
	private void DNEMLFELLDJ(Component HPFFEAJFMNI, PPIPAHAHKDN HPANENBGKED, bool NANALDIPEII, bool CEDLAOKLMNG, [Optional] Type OBIMPKAGFPL, [Optional] Type OHNLHCPFLGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6DCD990", Offset = "0x6DCCB90", VA = "0x186DCD990")]
	private void EOBLEABPDIK(GameObject HAAGKPEGEHP)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class CenterInImposter : MonoBehaviour, NJBDECJOCJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6DCACA0", Offset = "0x6DC9EA0", VA = "0x186DCACA0", Slot = "4")]
		public void PrepareImposter(PPIPAHAHKDN HPANENBGKED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x89BCA0", Offset = "0x89AEA0", VA = "0x18089BCA0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x89BCA0", Offset = "0x89AEA0", VA = "0x18089BCA0")]
		public KeepImposterUpright()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct PPIPAHAHKDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private Dictionary<Type, object> FOBIFJJGJJF;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x2352B70", Offset = "0x2351D70", VA = "0x182352B70")]
	public PPIPAHAHKDN BNDJKAKDCIM<T>(T ODCLEMGPINN)
	{
		return default(PPIPAHAHKDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x23538D0", Offset = "0x2352AD0", VA = "0x1823538D0")]
	public T MCKGCJAFOEM<T>(T HMGHIIACOGF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2353030", Offset = "0x2352230", VA = "0x182353030")]
	public bool FCPLDEOENIG<T>(out T ODCLEMGPINN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct MNNLJJJBMMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool BIFCNJGAMBJ;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xE6A120", Offset = "0xE69320", VA = "0x180E6A120")]
	public MNNLJJJBMMH(bool GIKLPCHPLKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct BDHNBKLJOGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public readonly bool EOIMEFHGPHF;

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6DC8EF0", Offset = "0x6DC80F0", VA = "0x186DC8EF0")]
	public BDHNBKLJOGE(bool BMFMPNODEHN)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class ScaleInImposter : MonoBehaviour, NJBDECJOCJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6DCF480", Offset = "0x6DCE680", VA = "0x186DCF480", Slot = "4")]
		public void PrepareImposter(PPIPAHAHKDN HPANENBGKED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x89BCA0", Offset = "0x89AEA0", VA = "0x18089BCA0")]
		public ScaleInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface NJBDECJOCJK
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(PPIPAHAHKDN HPANENBGKED);
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
