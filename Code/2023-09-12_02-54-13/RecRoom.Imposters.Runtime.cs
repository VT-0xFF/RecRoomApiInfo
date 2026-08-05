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
public class ImposterPreviewCustomFraming : MonoBehaviour, HEEELEEOPIF
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float NLBKAFAMIJG = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "4")]
	public void PrepareImposter(LEHNJAODHGJ NPOLKGPPPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x70530F0", Offset = "0x70524F0", VA = "0x1870530F0")]
	public void SetReferencePoint(Vector3 IEGBDEAOAGE, Quaternion IKMDCPAAKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7052F60", Offset = "0x7052360", VA = "0x187052F60")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x70530C0", Offset = "0x70524C0", VA = "0x1870530C0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7053130", Offset = "0x7052530", VA = "0x187053130")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class DLOICOFHGIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public OLDGAOPLBBP CEBGBFDFCIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly Texture HLGBNMPMDDB;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8C50F0", Offset = "0x8C44F0", VA = "0x1808C50F0")]
		public DLOICOFHGIA(OLDGAOPLBBP LJKCBDPEEAG, Texture FFBJCPPFNGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum AIHEAPCGEFM
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		Custom = 0,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		XS_128 = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		S_256 = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		M_512 = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		L_1024 = 0x400,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		XL_2048 = 0x800
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private class APKEOCFHPMB : IBBDJDIFPNE<Texture>, GLADGLPLHBG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class NNCFPPOOFKB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public APKEOCFHPMB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private GameObject <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
			public NNCFPPOOFKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7054510", Offset = "0x7053910", VA = "0x187054510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly OLDGAOPLBBP LJKCBDPEEAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly RenderTexture KGGGPIHPNOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly ImposterRenderConfig IFIPIAPDCNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly CancellationToken ODBDCIFDKPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private GameObject IDCAEHFMOFJ;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public KDCMFGDLEKL<Texture> BLNJFOLBIHG
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x704E4B0", Offset = "0x704D8B0", VA = "0x18704E4B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Task<Texture> JFAGMJGDMIN
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x823B60", Offset = "0x822F60", VA = "0x180823B60", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x704E590", Offset = "0x704D990", VA = "0x18704E590")]
		public APKEOCFHPMB(OLDGAOPLBBP LJKCBDPEEAG, RenderTexture KGGGPIHPNOJ, ImposterRenderConfig IFIPIAPDCNN, CancellationToken ODBDCIFDKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x704E360", Offset = "0x704D760", VA = "0x18704E360")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(NNCFPPOOFKB))]
		private Task<Texture> EPBPEHDBKIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x704E350", Offset = "0x704D750", VA = "0x18704E350", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x704E500", Offset = "0x704D900", VA = "0x18704E500")]
		private static void KLEKCDANIPJ(GameObject IDCAEHFMOFJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class BGLKPHHGFIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Texture <initTexture>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Texture <texture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Texture <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Exception <ex>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<Texture> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public BGLKPHHGFIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x704E760", Offset = "0x704DB60", VA = "0x18704E760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
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
	[ADFAGCEIIIB(BLGBJPBFLHB.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private AIHEAPCGEFM size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	[NJBIPLMLOIA("size", 0)]
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

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static int DJFDAGGCCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private RenderTexture POCBJPGAPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private MLLKJEFEBMF<GameObject> MPDPNDMPCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private PMFPAFFNEKC CKEKIHKBPBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private CancellationTokenSource OCLAFKPHAEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private IBBDJDIFPNE<Texture> GONKDIKGNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private OLDGAOPLBBP INEDNAIMFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private Texture NHHEDCHAJGP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static int PCHLIOLDMBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7053BD0", Offset = "0x7052FD0", VA = "0x187053BD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7053C30", Offset = "0x7053030", VA = "0x187053C30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private RenderTexture DEANCHPJEAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7053420", Offset = "0x7052820", VA = "0x187053420")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB9A340", Offset = "0xB99740", VA = "0x180B9A340")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private OLDGAOPLBBP CEBGBFDFCIP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x99C4F0", Offset = "0x99B8F0", VA = "0x18099C4F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x70532D0", Offset = "0x70526D0", VA = "0x1870532D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool FBPOGAFHINL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x409A7C0", Offset = "0x4099BC0", VA = "0x18409A7C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private int CLOOFGLEJFC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7053190", Offset = "0x7052590", VA = "0x187053190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7053170", Offset = "0x7052570", VA = "0x187053170")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7053690", Offset = "0x7052A90", VA = "0x187053690")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7053240", Offset = "0x7052640", VA = "0x187053240")]
	private void HIOBAGIEFBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7053AE0", Offset = "0x7052EE0", VA = "0x187053AE0")]
	public void Set(OLDGAOPLBBP GGKAOFGACBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7053AD0", Offset = "0x7052ED0", VA = "0x187053AD0")]
	public void Set(Texture FFBJCPPFNGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7053A90", Offset = "0x7052E90", VA = "0x187053A90")]
	public void Set(DLOICOFHGIA AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7053180", Offset = "0x7052580", VA = "0x187053180")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7053880", Offset = "0x7052C80", VA = "0x187053880")]
	public void SetInternal(OLDGAOPLBBP GGKAOFGACBM, [Optional] Texture DHCMONHKOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7053870", Offset = "0x7052C70", VA = "0x187053870")]
	public void SetCustomSize(int BOCNPKEPECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xD9E490", Offset = "0xD9D890", VA = "0x180D9E490")]
	public void SetAntiAliasing(int IHHDFJFOHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x70535B0", Offset = "0x70529B0", VA = "0x1870535B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BGLKPHHGFIM))]
	private void OOLGIIALKCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7053780", Offset = "0x7052B80", VA = "0x187053780")]
	private void PPOMMGKFHMH(Texture FFBJCPPFNGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7053B30", Offset = "0x7052F30", VA = "0x187053B30")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct CBNIGKFKGJG
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static CBNIGKFKGJG OLJPAJMFJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public float GPCGIBABJHM;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2E15AA0", Offset = "0x2E14EA0", VA = "0x182E15AA0")]
	public CBNIGKFKGJG(float DMNCMGGMBFN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DeferredImposterSpawnManager : SingletonMonoBehaviour<DeferredImposterSpawnManager>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private readonly struct EOEAOIHNJLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly OLDGAOPLBBP JOCPGLLKBFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public readonly string MODHFGFBPKE;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xD06A00", Offset = "0xD05E00", VA = "0x180D06A00")]
		public EOEAOIHNJLO(OLDGAOPLBBP MMIPJICJKDM, string JGDEGEIMMMJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class MFJJKJJKPFP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public EOEAOIHNJLO queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public DeferredImposterSpawnManager <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private OLDGAOPLBBP <request>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private GameObject <imposter>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private GameObject <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
		public MFJJKJJKPFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7054100", Offset = "0x7053500", VA = "0x187054100", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private IRecRoomQualityConfigProvider KNFIJOBOBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private FBCMANEJHMD<EOEAOIHNJLO, GameObject> JNDLJMPGGNK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DGDKEOJKMPI MJKAFJFLAFL
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8C5080", Offset = "0x8C4480", VA = "0x1808C5080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private FBCMANEJHMD<EOEAOIHNJLO, GameObject> HEDKDCCLDDI
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7050EE0", Offset = "0x70502E0", VA = "0x187050EE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private int AAJFDMGHHOC
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7050E90", Offset = "0x7050290", VA = "0x187050E90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7050A70", Offset = "0x704FE70", VA = "0x187050A70", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7051040", Offset = "0x7050440", VA = "0x187051040", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7050B20", Offset = "0x704FF20", VA = "0x187050B20")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MFJJKJJKPFP))]
	private Task<GameObject> DCKAJIGDOLJ(EOEAOIHNJLO OKGHCNPKEFF, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7050CC0", Offset = "0x70500C0", VA = "0x187050CC0")]
	public Task<GameObject> LoadItemAsync(OLDGAOPLBBP MMIPJICJKDM, CancellationToken ODBDCIFDKPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x70510B0", Offset = "0x70504B0", VA = "0x1870510B0")]
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
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		[ADFAGCEIIIB(BLGBJPBFLHB.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const int GMJMCAEIIFF = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private const int ILBEAAKMHCM = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly List<Material> POCPAFOOBCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private bool GFCLDGJFHEN;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7053DF0", Offset = "0x70531F0", VA = "0x187053DF0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7053D00", Offset = "0x7053100", VA = "0x187053D00")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7054040", Offset = "0x7053440", VA = "0x187054040")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OLDGAOPLBBP
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string LJMOHOAKBKN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	CBNIGKFKGJG CBNIGKFKGJG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action ADALOHHBAGP;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> MCGEONJBMFM(CancellationToken ODBDCIFDKPJ);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DJEDHDKNJHJ(OLDGAOPLBBP ICELKIGIKKP);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ECGLDBIBFCN();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LKANMDIGMDJ();

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CBKLOIBBMFN(out IBBDJDIFPNE<Texture> AKMFELPOCFL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HJLGKOHDHOM
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7052E90", Offset = "0x7052290", VA = "0x187052E90")]
	public static bool DNOALHFKMGG(OLDGAOPLBBP GBIOAKNKAEB, OLDGAOPLBBP NGMEAOKIKKG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FDOEGAILOMG
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> FKCDFHOCHEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> DBMCMDCPPOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DGDKEOJKMPI
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GameObject HAJAMHGECOC(GameObject OGOBDKNMJKA, Transform OJBGDMNECON, bool FLAIHAOPCHN = false);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T HAJAMHGECOC<T>(T OGOBDKNMJKA, Transform OJBGDMNECON, bool FLAIHAOPCHN = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T HAJAMHGECOC<T>(GameObject OGOBDKNMJKA, Transform OJBGDMNECON, bool FLAIHAOPCHN = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject HAJAMHGECOC(GameObject OGOBDKNMJKA, Transform OJBGDMNECON, LEHNJAODHGJ NPOLKGPPPJC, bool FLAIHAOPCHN);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class FILPADOAPPP
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly List<URPLight> LAPOGADCJLP;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly Vector3 DGNBHILMHDN;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly Vector3 GIEMMJPGBHH;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static Camera DKCDBEJAGOL;

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private static readonly List<Renderer> CHJNKFJGKFJ;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static AmbientMode PAJBGIFKIGF;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static Color BLODEKAHDKO;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static Color LMMNNNAFONA;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static Color JKECEHAFJAC;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static Cubemap OGIKPIMOKNC;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static bool PLFDAIGKCEC;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static Camera AHGAGODMCIO
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7051F00", Offset = "0x7051300", VA = "0x187051F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7051930", Offset = "0x7050D30", VA = "0x187051930")]
	public static void IABOLFBMGGD(Vector3 EEJDOENIGKK, Quaternion NFBHGLJIKII, ImposterRenderConfig MNINJIHHNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7052A70", Offset = "0x7051E70", VA = "0x187052A70")]
	private static void NPKJJDNGALF(Vector3 EEJDOENIGKK, Quaternion NFBHGLJIKII, URPLight AJFACLDFMNM, ImposterRenderConfig.LightConfig HPNHCACAALJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7051840", Offset = "0x7050C40", VA = "0x187051840")]
	public static void EJAHMPAKODE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x70526A0", Offset = "0x7051AA0", VA = "0x1870526A0")]
	private static void NJIBKIPEPAL(int PMCAPNNHNCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7051D80", Offset = "0x7051180", VA = "0x187051D80")]
	public static void JLHOGNBCLOK(ImposterRenderConfig MNINJIHHNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7051490", Offset = "0x7050890", VA = "0x187051490")]
	public static void CKKCOCDMFLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7051BB0", Offset = "0x7050FB0", VA = "0x187051BB0")]
	public static void JLFFGCFILJM(GameObject AJBDGLGLCEK, RenderTexture KGGGPIHPNOJ, ImposterRenderConfig MNINJIHHNAD, CBNIGKFKGJG AFHOLOJONFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7052140", Offset = "0x7051540", VA = "0x187052140")]
	private static void NANENLGFFKI(GameObject AJBDGLGLCEK, RenderTexture KGGGPIHPNOJ, ImposterRenderConfig MNINJIHHNAD, CBNIGKFKGJG AFHOLOJONFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7051590", Offset = "0x7050990", VA = "0x187051590")]
	private static void EDEMOODEBGB(GameObject AJBDGLGLCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7051190", Offset = "0x7050590", VA = "0x187051190")]
	public static void CGEJHAEBJHA(GameObject OGOBDKNMJKA, Vector3 MNEHJJMOAAG, Vector3 OMCNKCAEAPN, float NKNEDBPKEBM, CBNIGKFKGJG AFHOLOJONFB, out Vector3 GCJJCKPEHGP, out Quaternion IKKJFGOLINC, out float KENLLNBEJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x70510F0", Offset = "0x70504F0", VA = "0x1870510F0")]
	public static RenderTexture BFEPONDFBAM(int PPNABNHFNMB, int DPJCAKENMMD)
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
		public struct PFJNHFDMOLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public LGAKEDCJAKH BLNJACJPPFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public GameObject BPIIGPHNHJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public RenderTexture DEANCHPJEAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public ImposterRenderConfig FHGLPKHNJOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public CBNIGKFKGJG CBNIGKFKGJG;

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7054CA0", Offset = "0x70540A0", VA = "0x187054CA0")]
			public PFJNHFDMOLD(LGAKEDCJAKH LNIBEAPDNEC, GameObject HAMGLJLGDHP, RenderTexture KGGGPIHPNOJ, ImposterRenderConfig IFIPIAPDCNN, CBNIGKFKGJG AFHOLOJONFB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private static FBCMANEJHMD<PFJNHFDMOLD, RenderTexture> BGJJOEPNJEC;

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static readonly List<PFJNHFDMOLD> EJIPOOLKALD;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private static int EMMPDHBMDLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x7050390", Offset = "0x704F790", VA = "0x187050390")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7050670", Offset = "0x704FA70", VA = "0x187050670")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject AJBDGLGLCEK, RenderTexture KGGGPIHPNOJ, ImposterRenderConfig MNINJIHHNAD, CBNIGKFKGJG AFHOLOJONFB, CancellationToken ODBDCIFDKPJ, bool ELNLDMCIEKL = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x70501A0", Offset = "0x704F5A0", VA = "0x1870501A0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x70505D0", Offset = "0x704F9D0", VA = "0x1870505D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7050400", Offset = "0x704F800", VA = "0x187050400")]
		private static Task<RenderTexture> LPENPGLOJNP(PFJNHFDMOLD DJJDPFFFHHI, CancellationToken ODBDCIFDKPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7050A30", Offset = "0x704FE30", VA = "0x187050A30")]
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
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			[Range(0.1f, 10f)]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000062")]
				[Cpp2IlInjected.Address(RVA = "0x70540E0", Offset = "0x70534E0", VA = "0x1870540E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x70540C0", Offset = "0x70534C0", VA = "0x1870540C0")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7053CB0", Offset = "0x70530B0", VA = "0x187053CB0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CENKCJKEPMC : IDisposable, DGDKEOJKMPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly HashSet<Type> DKLOBKOLHPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly HashSet<Type> FGJOMMJPAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private Transform HEHJBCEGCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly List<Component> BAJKGGLBJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> LEDIGCDAHJP;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x704FB10", Offset = "0x704EF10", VA = "0x18704FB10")]
	[PGKDFPMEDOJ(CDFBKAGHDGH.None)]
	public static void PIJPEIOOLKO(IFJJAPHPIAE DOJDGHDKCLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x704FC00", Offset = "0x704F000", VA = "0x18704FC00")]
	[Preserve]
	public CENKCJKEPMC([JLJFOFICIEA(null)] FDOEGAILOMG HEDBKPGNNGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x704F0F0", Offset = "0x704E4F0", VA = "0x18704F0F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x704F280", Offset = "0x704E680", VA = "0x18704F280", Slot = "5")]
	public GameObject HAJAMHGECOC(GameObject OGOBDKNMJKA, Transform OJBGDMNECON, bool FLAIHAOPCHN = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x21C0CE0", Offset = "0x21C00E0", VA = "0x1821C0CE0", Slot = "6")]
	public T HAJAMHGECOC<T>(T OGOBDKNMJKA, Transform OJBGDMNECON, bool FLAIHAOPCHN = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x21C0DA0", Offset = "0x21C01A0", VA = "0x1821C0DA0", Slot = "7")]
	public T HAJAMHGECOC<T>(GameObject OGOBDKNMJKA, Transform OJBGDMNECON, bool FLAIHAOPCHN = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x704F1F0", Offset = "0x704E5F0", VA = "0x18704F1F0", Slot = "8")]
	public GameObject HAJAMHGECOC(GameObject OGOBDKNMJKA, Transform OJBGDMNECON, LEHNJAODHGJ NPOLKGPPPJC, bool FLAIHAOPCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x21C0D50", Offset = "0x21C0150", VA = "0x1821C0D50", Slot = "9")]
	public T HAJAMHGECOC<T>(GameObject OGOBDKNMJKA, Transform OJBGDMNECON, LEHNJAODHGJ NPOLKGPPPJC, bool FLAIHAOPCHN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x21C07C0", Offset = "0x21BFBC0", VA = "0x1821C07C0")]
	private T HAJAMHGECOC<T>(GameObject OGOBDKNMJKA, Transform OJBGDMNECON, LEHNJAODHGJ NPOLKGPPPJC, bool FLAIHAOPCHN, out GameObject DBNIJFBBOOL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x21C0DD0", Offset = "0x21C01D0", VA = "0x1821C0DD0")]
	private T NGJHBICOBFE<T>(GameObject NNAKJIJAOJG, LEHNJAODHGJ NPOLKGPPPJC, bool FLAIHAOPCHN) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x704F310", Offset = "0x704E710", VA = "0x18704F310")]
	private void HEEDJLIGEEA(Component EGEAFOFCJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x704F5A0", Offset = "0x704E9A0", VA = "0x18704F5A0")]
	private void OMPIOEGDONL(Component EGEAFOFCJOI, LEHNJAODHGJ NPOLKGPPPJC, bool FLAIHAOPCHN, bool EHHALDEEEKK, [Optional] Type BENJEPEDHCF, [Optional] Type LLPGBNNDMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x704F440", Offset = "0x704E840", VA = "0x18704F440")]
	private void KAIBHFLCGFI(GameObject NNAKJIJAOJG)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class CenterInImposter : MonoBehaviour, HEEELEEOPIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7050040", Offset = "0x704F440", VA = "0x187050040", Slot = "4")]
		public void PrepareImposter(LEHNJAODHGJ NPOLKGPPPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
		public KeepImposterUpright()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LEHNJAODHGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private Dictionary<Type, object> MCIKOHKIPFE;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2378590", Offset = "0x2377990", VA = "0x182378590")]
	public LEHNJAODHGJ AFLFAPDAOKF<T>(T EHMHLFBIKEK)
	{
		return default(LEHNJAODHGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x23794C0", Offset = "0x23788C0", VA = "0x1823794C0")]
	public T PHGLOPEHIMO<T>(T CHKFHALGEFG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2378CC0", Offset = "0x23780C0", VA = "0x182378CC0")]
	public bool HBBLEOHJDFE<T>(out T EHMHLFBIKEK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct HMJAEMPIGLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool JLPEJOLDILN;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xCA7800", Offset = "0xCA6C00", VA = "0x180CA7800")]
	public HMJAEMPIGLH(bool NHKALKCKBFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct BJNEIBLGOFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public readonly bool EBGNFCMOKBG;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x704F0A0", Offset = "0x704E4A0", VA = "0x18704F0A0")]
	public BJNEIBLGOFP(bool JAJEODKEEDO)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class ScaleInImposter : MonoBehaviour, HEEELEEOPIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7054D10", Offset = "0x7054110", VA = "0x187054D10", Slot = "4")]
		public void PrepareImposter(LEHNJAODHGJ NPOLKGPPPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
		public ScaleInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface HEEELEEOPIF
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(LEHNJAODHGJ NPOLKGPPPJC);
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
