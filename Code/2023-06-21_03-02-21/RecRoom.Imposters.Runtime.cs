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
public class ImposterPreviewCustomFraming : MonoBehaviour, ILNBECODPNG
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float ALHOOHACJNJ = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "4")]
	public void PrepareImposter(LLGIHILHCNJ OGEINKONADM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x14AD3E0", Offset = "0x14AC5E0", VA = "0x1814AD3E0")]
	public void SetReferencePoint(Vector3 PMKBAJECIHL, Quaternion KOMNMIFOANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x14AD250", Offset = "0x14AC450", VA = "0x1814AD250")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x14AD3B0", Offset = "0x14AC5B0", VA = "0x1814AD3B0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x14AD420", Offset = "0x14AC620", VA = "0x1814AD420")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class PCIECAJKIPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public FPHOHHJGEEN NOEFIIKBNPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly Texture DEKKOHOIKHM;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8D7200", Offset = "0x8D6400", VA = "0x1808D7200")]
		public PCIECAJKIPN(FPHOHHJGEEN JDHOKKKGNHJ, Texture DBFELDODGMH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum AGIHEFGLOBH
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
	private class JECLMCCLMGO : GHFDPPJAELF<Texture>, AEAAPGKBHMO, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class IOLECHOIGNL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public JECLMCCLMGO <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
			public IOLECHOIGNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x14ACAC0", Offset = "0x14ABCC0", VA = "0x1814ACAC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly FPHOHHJGEEN JDHOKKKGNHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly RenderTexture FDCIHCMJLHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly ImposterRenderConfig BIJJNHFMGHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly CancellationToken PLEKJLHDOLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private GameObject OIGIINMOAGN;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private OOPPNGPPPLE LBPPKDMGKBB
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x14AE3E0", Offset = "0x14AD5E0", VA = "0x1814AE3E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public NHJDNADPIAN<Texture> GJKBIGEEPND
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x14AE3F0", Offset = "0x14AD5F0", VA = "0x1814AE3F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Task KCBMFLPLCDM
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x825260", Offset = "0x824460", VA = "0x180825260", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Task<Texture> CMLFGHHIHFL
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x825260", Offset = "0x824460", VA = "0x180825260", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x14AE440", Offset = "0x14AD640", VA = "0x1814AE440")]
		public JECLMCCLMGO(FPHOHHJGEEN JDHOKKKGNHJ, RenderTexture FDCIHCMJLHG, ImposterRenderConfig BIJJNHFMGHK, CancellationToken PLEKJLHDOLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x14AE1F0", Offset = "0x14AD3F0", VA = "0x1814AE1F0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(IOLECHOIGNL))]
		private Task<Texture> ABJEADIIPLE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x14AE3D0", Offset = "0x14AD5D0", VA = "0x1814AE3D0", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x14AE340", Offset = "0x14AD540", VA = "0x1814AE340")]
		private static void AJEOFCNDNLJ(GameObject OIGIINMOAGN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class DDAFLJGONFC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public DDAFLJGONFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x14A9F10", Offset = "0x14A9110", VA = "0x1814A9F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
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
	[IMEOLICHDCN(OANOIFMCHLE.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private AGIHEFGLOBH size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	[FDKNKMFDEBB("size", 0)]
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
	private RenderTexture NAMGCJOOIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private DADEODBJPBG<GameObject> BMHPAMIFEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private MMEJLKMBIHL OMAJALOINDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private CancellationTokenSource AKHLKBFAFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private GHFDPPJAELF<Texture> NAAMECEHPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private FPHOHHJGEEN BKEIHKPDDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Texture NDPANDCNJJI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private RenderTexture GFIGOIJBOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x14AD670", Offset = "0x14AC870", VA = "0x1814AD670")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8DF670", Offset = "0x8DE870", VA = "0x1808DF670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private FPHOHHJGEEN NOEFIIKBNPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8EE430", Offset = "0x8ED630", VA = "0x1808EE430")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x14AD490", Offset = "0x14AC690", VA = "0x1814AD490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool FDMDNNOFGGF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC65170", Offset = "0xC64370", VA = "0x180C65170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int KMGCBCBPBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x14AD470", Offset = "0x14AC670", VA = "0x1814AD470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x14AD460", Offset = "0x14AC660", VA = "0x1814AD460")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x14AD800", Offset = "0x14ACA00", VA = "0x1814AD800")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x14AD5E0", Offset = "0x14AC7E0", VA = "0x1814AD5E0")]
	private void HGHBFJOCEPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x14ADCE0", Offset = "0x14ACEE0", VA = "0x1814ADCE0")]
	public void Set(FPHOHHJGEEN OKLBDCCAEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x14ADCF0", Offset = "0x14ACEF0", VA = "0x1814ADCF0")]
	public void Set(Texture DBFELDODGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x14ADD00", Offset = "0x14ACF00", VA = "0x1814ADD00")]
	public void Set(PCIECAJKIPN ACKOJNNBEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x14AD480", Offset = "0x14AC680", VA = "0x1814AD480")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x14ADAD0", Offset = "0x14ACCD0", VA = "0x1814ADAD0")]
	public void SetInternal(FPHOHHJGEEN OKLBDCCAEDI, [Optional] Texture MHAGMAMCFPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x14ADAC0", Offset = "0x14ACCC0", VA = "0x1814ADAC0")]
	public void SetCustomSize(int NCIOCHMNFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x9568B0", Offset = "0x955AB0", VA = "0x1809568B0")]
	public void SetAntiAliasing(int MCNKFOKIOJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x14AD9E0", Offset = "0x14ACBE0", VA = "0x1814AD9E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DDAFLJGONFC))]
	private void PGHONFLCOLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x14AD8F0", Offset = "0x14ACAF0", VA = "0x1814AD8F0")]
	private void PAAOPEHAMPN(Texture DBFELDODGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x14ADD40", Offset = "0x14ACF40", VA = "0x1814ADD40")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct PALODGPKBGK
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static PALODGPKBGK PEPDAMPINBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float KMNLNDPBIFC;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xE09FB0", Offset = "0xE091B0", VA = "0x180E09FB0")]
	public PALODGPKBGK(float KDIBLKHFGGP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DeferredImposterSpawnManager : SingletonMonoBehaviour<DeferredImposterSpawnManager>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private readonly struct OKANMKDLNNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly FPHOHHJGEEN NEDMMKGAKCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly string OIHJKBDOAMP;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA5F7B0", Offset = "0xA5E9B0", VA = "0x180A5F7B0")]
		public OKANMKDLNNN(FPHOHHJGEEN HCAFCNIMAND, string PPNOBJNGMCH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class EIJBJCHEMLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public OKANMKDLNNN queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public DeferredImposterSpawnManager <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private FPHOHHJGEEN <request>5__1;

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
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public EIJBJCHEMLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x14AB640", Offset = "0x14AA840", VA = "0x1814AB640", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private IRecRoomQualityConfigProvider PBFNJPMLMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private LLNGBCKEOML<OKANMKDLNNN, GameObject> LOFLPKMABBF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public HILOPBGNBEA CHBHJFPDHDA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x844AA0", Offset = "0x843CA0", VA = "0x180844AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private LLNGBCKEOML<OKANMKDLNNN, GameObject> LLCGFOFKLGM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x14AB4A0", Offset = "0x14AA6A0", VA = "0x1814AB4A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private int ABCGEDLINLA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x14AB070", Offset = "0x14AA270", VA = "0x1814AB070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x14AAFC0", Offset = "0x14AA1C0", VA = "0x1814AAFC0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x14AB430", Offset = "0x14AA630", VA = "0x1814AB430", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x14AB290", Offset = "0x14AA490", VA = "0x1814AB290")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EIJBJCHEMLC))]
	private Task<GameObject> NPEBIIDDAHH(OKANMKDLNNN KNCBPECLAOJ, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x14AB0C0", Offset = "0x14AA2C0", VA = "0x1814AB0C0")]
	public Task<GameObject> LoadItemAsync(FPHOHHJGEEN HCAFCNIMAND, CancellationToken PLEKJLHDOLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x14AB600", Offset = "0x14AA800", VA = "0x1814AB600")]
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
		[IMEOLICHDCN(OANOIFMCHLE.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const int APMDDAHBJJE = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const int EKBDIGGEKNM = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly List<Material> CNMEOGIBEBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool DMMIKLALGCC;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x14ADF20", Offset = "0x14AD120", VA = "0x1814ADF20")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x14ADE30", Offset = "0x14AD030", VA = "0x1814ADE30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x14AE170", Offset = "0x14AD370", VA = "0x1814AE170")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FPHOHHJGEEN
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string KDHKMLHKIIB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	PALODGPKBGK PALODGPKBGK
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action CFANDLFMLEN;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> CFNGONLPNPL(CancellationToken PLEKJLHDOLP);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MOLLMHANNGD(FPHOHHJGEEN HPOECFLNEOJ);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BMKIFABJAJJ();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FFBIADLKOOM();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OIFICBPCNIM(out GHFDPPJAELF<Texture> CBLMMHJPIFE);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KKFDALLKOAF
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x14AE610", Offset = "0x14AD810", VA = "0x1814AE610")]
	public static bool GCGDIKDOOLL(FPHOHHJGEEN HAKNBFGJADL, FPHOHHJGEEN BDFEMBAODKJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface IAEKGPELCJB
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> MFBLPFFJGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<Type> NNAIPLFKNNO
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
		[Cpp2IlInjected.Address(RVA = "0x931070", Offset = "0x930270", VA = "0x180931070")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface HILOPBGNBEA
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NEOCGAALBHO(params Type[] OMNEJPNCJMO);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KOBKKPKEKKN(params Type[] OMNEJPNCJMO);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject CHKEOPPJCKN(GameObject AHDDCNOKJEA, Transform BLFIAOLNAKG, bool FENNEOPEFAA = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T CHKEOPPJCKN<T>(T AHDDCNOKJEA, Transform BLFIAOLNAKG, bool FENNEOPEFAA = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T CHKEOPPJCKN<T>(GameObject AHDDCNOKJEA, Transform BLFIAOLNAKG, bool FENNEOPEFAA = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject CHKEOPPJCKN(GameObject AHDDCNOKJEA, Transform BLFIAOLNAKG, LLGIHILHCNJ OGEINKONADM, bool FENNEOPEFAA);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T CHKEOPPJCKN<T>(GameObject AHDDCNOKJEA, Transform BLFIAOLNAKG, LLGIHILHCNJ OGEINKONADM, bool FENNEOPEFAA) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T CHKEOPPJCKN<T>(T AHDDCNOKJEA, Transform BLFIAOLNAKG, LLGIHILHCNJ OGEINKONADM, bool FENNEOPEFAA) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class BPFDKENLCFC
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly List<URPLight> MAFKOFIKKPJ;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly Vector3 OHOOLCDKIIP;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly Vector3 MGKAJEGEKHN;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static Camera PKAKMDGIABJ;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public const string FIAFJIFMLDD = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const KLGJFPLDNDD GKLAJEJBEGC = KLGJFPLDNDD.Water;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly List<Renderer> LDMAOHHKCFE;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static AmbientMode LJGPKCAHFIN;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static Color FADNOLINKIO;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static Color DCOANLHNOKM;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static Color PIHCHDBGFMI;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static Cubemap LLJKJHEICDE;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private static bool GNNDENJMOPE;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static Camera PFMCPOGGNDN
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x14A90F0", Offset = "0x14A82F0", VA = "0x1814A90F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x14A8120", Offset = "0x14A7320", VA = "0x1814A8120")]
	public static void AMEENJMNLAM(Vector3 GAJFMLHOLKP, Quaternion MLAECCKBNOH, ImposterRenderConfig NJHGKGKCMBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x14A7E40", Offset = "0x14A7040", VA = "0x1814A7E40")]
	private static void AFIEPIJIIFI(Vector3 GAJFMLHOLKP, Quaternion MLAECCKBNOH, URPLight ALHNBBFJGBE, ImposterRenderConfig.LightConfig HKJOPEDFFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x14A9330", Offset = "0x14A8530", VA = "0x1814A9330")]
	public static void MCMPGAGDEGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x14A96D0", Offset = "0x14A88D0", VA = "0x1814A96D0")]
	private static void NNBBHPMOMBJ(int AOANAOIKHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x14A83A0", Offset = "0x14A75A0", VA = "0x1814A83A0")]
	public static void CJJPBIDGDNM(ImposterRenderConfig NJHGKGKCMBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x14A8520", Offset = "0x14A7720", VA = "0x1814A8520")]
	public static void EPHGAIDKBBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x14A9AA0", Offset = "0x14A8CA0", VA = "0x1814A9AA0")]
	public static void OGMNJGODLGJ(GameObject KLGOPMIBEAK, RenderTexture FDCIHCMJLHG, ImposterRenderConfig NJHGKGKCMBP, PALODGPKBGK PCEAHGDKGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x14A8850", Offset = "0x14A7A50", VA = "0x1814A8850")]
	private static void FNDCDJKBFGP(GameObject KLGOPMIBEAK, RenderTexture FDCIHCMJLHG, ImposterRenderConfig NJHGKGKCMBP, PALODGPKBGK PCEAHGDKGEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x14A9420", Offset = "0x14A8620", VA = "0x1814A9420")]
	private static void MKMBEBFMBCF(GameObject KLGOPMIBEAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x14A7CA0", Offset = "0x14A6EA0", VA = "0x1814A7CA0")]
	public static void ABAOKBAFLAM(List<Renderer> DFDHOBCLAMA, List<Material> FPKACBNFPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x14A8DF0", Offset = "0x14A7FF0", VA = "0x1814A8DF0")]
	public static void HICGNJNOFBL(GameObject AHDDCNOKJEA, Vector3 CNGLJLNIHDI, Vector3 HILOPHGOOML, float NEGGCJKNDHO, PALODGPKBGK PCEAHGDKGEA, out Vector3 KNMDMPCJIFM, out Quaternion AJIHBBOEHND, out float KNMAPHKCFCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x14A8D50", Offset = "0x14A7F50", VA = "0x1814A8D50")]
	public static RenderTexture GICKDIKGJGC(int MBFLADEHOFK, int ONCHOOACJKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x14A8620", Offset = "0x14A7820", VA = "0x1814A8620")]
	public static void FAJODEJJPMD()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public struct HJPPHGIGLIM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public DAFGDOMLDFF AIJCKJJIIGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public GameObject HBGMJIMLGAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public RenderTexture GFIGOIJBOBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public ImposterRenderConfig DKONLDHECHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public PALODGPKBGK PALODGPKBGK;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x14ACA50", Offset = "0x14ABC50", VA = "0x1814ACA50")]
			public HJPPHGIGLIM(DAFGDOMLDFF IPHCMLMIPHN, GameObject LGJDPHOPJND, RenderTexture FDCIHCMJLHG, ImposterRenderConfig BIJJNHFMGHK, PALODGPKBGK PCEAHGDKGEA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static LLNGBCKEOML<HJPPHGIGLIM, RenderTexture> KBHJOJGNOLM;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly List<HJPPHGIGLIM> JNMNAACDLAI;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private static int GAFIPCHADHC
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x14AAAB0", Offset = "0x14A9CB0", VA = "0x1814AAAB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x14AABC0", Offset = "0x14A9DC0", VA = "0x1814AABC0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject KLGOPMIBEAK, RenderTexture FDCIHCMJLHG, ImposterRenderConfig NJHGKGKCMBP, PALODGPKBGK PCEAHGDKGEA, CancellationToken PLEKJLHDOLP, bool HICKDLNDNDO = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x14AA6F0", Offset = "0x14A98F0", VA = "0x1814AA6F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x14AAB20", Offset = "0x14A9D20", VA = "0x1814AAB20", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x14AA8E0", Offset = "0x14A9AE0", VA = "0x1814AA8E0")]
		private static Task<RenderTexture> FBEFJPPCKED(HJPPHGIGLIM KEFHMFJOAMH, CancellationToken PLEKJLHDOLP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x14AAF80", Offset = "0x14AA180", VA = "0x1814AAF80")]
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
				[Cpp2IlInjected.Address(RVA = "0x14AE710", Offset = "0x14AD910", VA = "0x1814AE710")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x14AE6F0", Offset = "0x14AD8F0", VA = "0x1814AE6F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x14ADDE0", Offset = "0x14ACFE0", VA = "0x1814ADDE0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GFKAFHGHNCJ : IDisposable, HILOPBGNBEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly HashSet<Type> KOAPMLMKGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly HashSet<Type> EKLODMDMGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private Transform FMEONAEDADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly List<Component> HJKNMLMDBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> PJMPOMBAGMP;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x14ABFC0", Offset = "0x14AB1C0", VA = "0x1814ABFC0")]
	[MPKPGFJAEKF(OJBJGAAILBP.None)]
	public static void CGPKALMGMIN(JLCNCEFHLIA HPKKDLHOJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x14AC600", Offset = "0x14AB800", VA = "0x1814AC600")]
	[Preserve]
	public GFKAFHGHNCJ([IDNKOMINBGM(null)] IAEKGPELCJB GNKKJFOHGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x14AC1D0", Offset = "0x14AB3D0", VA = "0x1814AC1D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x14AC5B0", Offset = "0x14AB7B0", VA = "0x1814AC5B0", Slot = "5")]
	public void NEOCGAALBHO(params Type[] OMNEJPNCJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x14AC560", Offset = "0x14AB760", VA = "0x1814AC560", Slot = "6")]
	public void KOBKKPKEKKN(params Type[] OMNEJPNCJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x14AC140", Offset = "0x14AB340", VA = "0x1814AC140", Slot = "7")]
	public GameObject CHKEOPPJCKN(GameObject AHDDCNOKJEA, Transform BLFIAOLNAKG, bool FENNEOPEFAA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2AFF6F0", Offset = "0x2AFE8F0", VA = "0x182AFF6F0", Slot = "8")]
	public T CHKEOPPJCKN<T>(T AHDDCNOKJEA, Transform BLFIAOLNAKG, bool FENNEOPEFAA = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2AFF760", Offset = "0x2AFE960", VA = "0x182AFF760", Slot = "9")]
	public T CHKEOPPJCKN<T>(GameObject AHDDCNOKJEA, Transform BLFIAOLNAKG, bool FENNEOPEFAA = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x14AC0B0", Offset = "0x14AB2B0", VA = "0x1814AC0B0", Slot = "10")]
	public GameObject CHKEOPPJCKN(GameObject AHDDCNOKJEA, Transform BLFIAOLNAKG, LLGIHILHCNJ OGEINKONADM, bool FENNEOPEFAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2AFF610", Offset = "0x2AFE810", VA = "0x182AFF610", Slot = "11")]
	public T CHKEOPPJCKN<T>(GameObject AHDDCNOKJEA, Transform BLFIAOLNAKG, LLGIHILHCNJ OGEINKONADM, bool FENNEOPEFAA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2AFF660", Offset = "0x2AFE860", VA = "0x182AFF660", Slot = "12")]
	public T CHKEOPPJCKN<T>(T AHDDCNOKJEA, Transform BLFIAOLNAKG, LLGIHILHCNJ OGEINKONADM, bool FENNEOPEFAA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2AFF790", Offset = "0x2AFE990", VA = "0x182AFF790")]
	private T CHKEOPPJCKN<T>(GameObject AHDDCNOKJEA, Transform BLFIAOLNAKG, LLGIHILHCNJ OGEINKONADM, bool FENNEOPEFAA, out GameObject ODOGEMMHJMG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2AFFCB0", Offset = "0x2AFEEB0", VA = "0x182AFFCB0")]
	private T KLGEJFDOBCL<T>(GameObject JBOGCBPFIGA, LLGIHILHCNJ OGEINKONADM, bool FENNEOPEFAA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x14AC2D0", Offset = "0x14AB4D0", VA = "0x1814AC2D0")]
	private void GMLEBBBIBMA(Component FEFGGGJBLPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x14ABA50", Offset = "0x14AAC50", VA = "0x1814ABA50")]
	private void BBOFJAKOLGJ(Component FEFGGGJBLPM, LLGIHILHCNJ OGEINKONADM, bool FENNEOPEFAA, bool CLAAMCHDCFN, [Optional] Type IHGPFNIEJDG, [Optional] Type MMHKPNCKKKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x14AC400", Offset = "0x14AB600", VA = "0x1814AC400")]
	private void IOAPFPAAELC(GameObject JBOGCBPFIGA)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class CenterInImposter : MonoBehaviour, ILNBECODPNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x14A9DB0", Offset = "0x14A8FB0", VA = "0x1814A9DB0", Slot = "4")]
		public void PrepareImposter(LLGIHILHCNJ OGEINKONADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x931070", Offset = "0x930270", VA = "0x180931070")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x931070", Offset = "0x930270", VA = "0x180931070")]
		public KeepImposterUpright()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct LLGIHILHCNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private Dictionary<Type, object> CDBGPFFKDPG;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x3348F80", Offset = "0x3348180", VA = "0x183348F80")]
	public LLGIHILHCNJ EBIKLMMGLOI<T>(T JCMMBHAMPCI)
	{
		return default(LLGIHILHCNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x3349EB0", Offset = "0x33490B0", VA = "0x183349EB0")]
	public T MEINKDCJHDP<T>(T DDGOMDBNGFF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x33496B0", Offset = "0x33488B0", VA = "0x1833496B0")]
	public bool IDJOIMMOOEO<T>(out T JCMMBHAMPCI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct HFNEODPILCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool PJFMLCPDJMA;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x14ACA40", Offset = "0x14ABC40", VA = "0x1814ACA40")]
	public HFNEODPILCB(bool IACHIBGANJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct LJBKJADDFAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool HHJEJFFJGCL;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x14AE6E0", Offset = "0x14AD8E0", VA = "0x1814AE6E0")]
	public LJBKJADDFAO(bool FHDBFHCOHDJ)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class ScaleInImposter : MonoBehaviour, ILNBECODPNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x14AE770", Offset = "0x14AD970", VA = "0x1814AE770", Slot = "4")]
		public void PrepareImposter(LLGIHILHCNJ OGEINKONADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x931070", Offset = "0x930270", VA = "0x180931070")]
		public ScaleInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface ILNBECODPNG
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(LLGIHILHCNJ OGEINKONADM);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class CGEPNPBBKEG
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
	public CGEPNPBBKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x892120", Offset = "0x891320", VA = "0x180892120")]
	public static string AADLLEBJPEC(byte[] MJAMHAEGDEA, byte[] ELNJHIHGPEE)
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
