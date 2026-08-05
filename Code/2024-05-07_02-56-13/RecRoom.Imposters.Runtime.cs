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
	private readonly struct FNCLKHMNNJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly EAKNHCIDKKL CILHDADEDKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string IOJNOHEFDDD;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x947190", Offset = "0x946390", VA = "0x180947190")]
		public FNCLKHMNNJC(EAKNHCIDKKL ILPPMMNKLPA, string CADINNPBOOI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct PBLLPKHMNHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public FNCLKHMNNJC queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6210A20", Offset = "0x620FC20", VA = "0x186210A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6210DC0", Offset = "0x620FFC0", VA = "0x186210DC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider IJHDHHHJNCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private AEKLEFMOAPE<FNCLKHMNNJC, GameObject> NDBFFHFGPHP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public CLCEIBOOIHE NCMDFFEPNEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7B6290", Offset = "0x7B5490", VA = "0x1807B6290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private AEKLEFMOAPE<FNCLKHMNNJC, GameObject> FMMFLHOOIEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x620C1D0", Offset = "0x620B3D0", VA = "0x18620C1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int MOPLKBMKBJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x620C180", Offset = "0x620B380", VA = "0x18620C180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x620BD50", Offset = "0x620AF50", VA = "0x18620BD50", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x620C110", Offset = "0x620B310", VA = "0x18620C110", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x620BE10", Offset = "0x620B010", VA = "0x18620BE10")]
	[AsyncStateMachine(typeof(PBLLPKHMNHO))]
	private Task<GameObject> FMCHKKKBDHP(FNCLKHMNNJC NFIBKBKFLIJ, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x620BF30", Offset = "0x620B130", VA = "0x18620BF30")]
	public Task<GameObject> LoadItemAsync(EAKNHCIDKKL ILPPMMNKLPA, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x620C330", Offset = "0x620B530", VA = "0x18620C330")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class EIKPIMMEPMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public EAKNHCIDKKL NBLHAJLMBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture HLOOBJAOBFH;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7B7CF0", Offset = "0x7B6EF0", VA = "0x1807B7CF0")]
		public EIKPIMMEPMA(EAKNHCIDKKL NGBMMHJOKMG, Texture AFMCPMEGELI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum OKFGNJKEJIL
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
	private class JCAEOJKFIDO : GCMEMNGCFAM<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct DMKCPLFFNIG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public JCAEOJKFIDO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x620ABC0", Offset = "0x6209DC0", VA = "0x18620ABC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x620B3C0", Offset = "0x620A5C0", VA = "0x18620B3C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly EAKNHCIDKKL NGBMMHJOKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture PMJBCJODPKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig IOFNPOFEBEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken AIHJHMPAHCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject GELKIJEJNMG;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override JGFOKFMCODN<Texture> CMPFEKILCEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x620E0D0", Offset = "0x620D2D0", VA = "0x18620E0D0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> HHDLJJOPIDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7B62D0", Offset = "0x7B54D0", VA = "0x1807B62D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x620E1C0", Offset = "0x620D3C0", VA = "0x18620E1C0")]
		public JCAEOJKFIDO(EAKNHCIDKKL NGBMMHJOKMG, RenderTexture PMJBCJODPKB, ImposterRenderConfig IOFNPOFEBEO, CancellationToken AIHJHMPAHCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x620DFE0", Offset = "0x620D1E0", VA = "0x18620DFE0")]
		[AsyncStateMachine(typeof(DMKCPLFFNIG))]
		private Task<Texture> DNBPHNJBEBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x620E130", Offset = "0x620D330", VA = "0x18620E130", Slot = "10")]
		protected override void KBMHJLMLMHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x620E140", Offset = "0x620D340", VA = "0x18620E140")]
		private static void OGLJGPNDIDO(GameObject GELKIJEJNMG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct IENGMFHKANJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x620C3B0", Offset = "0x620B5B0", VA = "0x18620C3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8A5FC0", Offset = "0x8A51C0", VA = "0x1808A5FC0", Slot = "5")]
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
	[MGMFHFICAPM(OILHINDHMGI.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private OKFGNJKEJIL size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[OMDFOEKIOGM("size", OKFGNJKEJIL.Custom)]
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
	private static int JJJCEHDFJOK;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture OKGKNHDABKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private JBCFAMDFOCB<GameObject> KBDJFFDAEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private GJKGGCLGKLL OFPKBKHEAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource MODHBCLCLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private IKCNFNMPLNN<Texture> DBICDKDGBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private EAKNHCIDKKL GKIAHODOKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture GLBACIGPIFP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int MOFGLBJEECJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x620DAC0", Offset = "0x620CCC0", VA = "0x18620DAC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x620DB10", Offset = "0x620CD10", VA = "0x18620DB10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture PLFPFKNPEIB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x620D170", Offset = "0x620C370", VA = "0x18620D170")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7B62F0", Offset = "0x7B54F0", VA = "0x1807B62F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private EAKNHCIDKKL NBLHAJLMBJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D10", Offset = "0x7B7F10", VA = "0x1807B8D10")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x620D320", Offset = "0x620C520", VA = "0x18620D320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool CNIIHNIOIOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x52F5BE0", Offset = "0x52F4DE0", VA = "0x1852F5BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int AJAPGAMCKEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x620D0D0", Offset = "0x620C2D0", VA = "0x18620D0D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x620D0C0", Offset = "0x620C2C0", VA = "0x18620D0C0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x620D5E0", Offset = "0x620C7E0", VA = "0x18620D5E0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x620D480", Offset = "0x620C680", VA = "0x18620D480")]
	private void MHMGBNDKDAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x620D9E0", Offset = "0x620CBE0", VA = "0x18620D9E0")]
	public void Set(EAKNHCIDKKL MCLICJNGIKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x620D9D0", Offset = "0x620CBD0", VA = "0x18620D9D0")]
	public void Set(Texture AFMCPMEGELI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x620D990", Offset = "0x620CB90", VA = "0x18620D990")]
	public void Set(EIKPIMMEPMA NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x620D160", Offset = "0x620C360", VA = "0x18620D160")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x620D790", Offset = "0x620C990", VA = "0x18620D790")]
	public void SetInternal(EAKNHCIDKKL MCLICJNGIKL, [Optional] Texture DHLKKPFJHPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x620D780", Offset = "0x620C980", VA = "0x18620D780")]
	public void SetCustomSize(int JAHDFIDMDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7BFEF0", Offset = "0x7BF0F0", VA = "0x1807BFEF0")]
	public void SetAntiAliasing(int IFFOKINPIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x620D6D0", Offset = "0x620C8D0", VA = "0x18620D6D0")]
	[AsyncStateMachine(typeof(IENGMFHKANJ))]
	private void PBFMHKEFACP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x620D500", Offset = "0x620C700", VA = "0x18620D500")]
	private void OBLKHPFLHDD(Texture AFMCPMEGELI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x620DA40", Offset = "0x620CC40", VA = "0x18620DA40")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, LJIOCCBGAEL
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float NDGGGJMGLFH = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "4")]
	public void PrepareImposter(KNCMBPEPLDC HELLICJGLED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x620D080", Offset = "0x620C280", VA = "0x18620D080")]
	public void SetReferencePoint(Vector3 CMGCCDJMKGB, Quaternion MGHFLNIAHPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x620CE90", Offset = "0x620C090", VA = "0x18620CE90")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x620D060", Offset = "0x620C260", VA = "0x18620D060")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x14AF3F0", Offset = "0x14AE5F0", VA = "0x1814AF3F0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct ENOEHAHNLDA
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static ENOEHAHNLDA DBAAOEFGKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float IPIBLDCLEAH;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4DE0", Offset = "0x1FE3FE0", VA = "0x181FE4DE0")]
	public ENOEHAHNLDA(float KCFPHJGAIEP)
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
		[MGMFHFICAPM(OILHINDHMGI.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int FIGNNPEKJKB = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int MPEPOLCICMN = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> PFCANPFDEHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool GJNIGJFGJJO;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x620DD10", Offset = "0x620CF10", VA = "0x18620DD10")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x620DC10", Offset = "0x620CE10", VA = "0x18620DC10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x620DF50", Offset = "0x620D150", VA = "0x18620DF50")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EAKNHCIDKKL
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string KOBDKJAEAKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	ENOEHAHNLDA ENOEHAHNLDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PKHFJHODAJJ;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> OJAMJKAOGCD(CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GKJJGGELFLC(EAKNHCIDKKL NOBJAPGNDAK);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OBGGKJLNPNM();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JOBCGBAJFHN();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JAPNJDAIHFN([Out] IKCNFNMPLNN<Texture> GLNLCKANCIL);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DHHLKFJCHJN
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x620AAD0", Offset = "0x6209CD0", VA = "0x18620AAD0")]
	public static bool ILEIBLEAPNF(EAKNHCIDKKL BHHJCAKOIAE, EAKNHCIDKKL MGJENGIDENB)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, LJIOCCBGAEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x620A980", Offset = "0x6209B80", VA = "0x18620A980", Slot = "4")]
		public void PrepareImposter(KNCMBPEPLDC HELLICJGLED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7B45D0", Offset = "0x7B37D0", VA = "0x1807B45D0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7B45D0", Offset = "0x7B37D0", VA = "0x1807B45D0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LJIOCCBGAEL
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(KNCMBPEPLDC HELLICJGLED);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BCECDLLGJMJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> OMANDPAPIAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> IJHJIFJLKBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CLCEIBOOIHE
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEAKCAMLIED(params Type[] CKIGCMBDDLG);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject JOCJCJOONGM(GameObject ICCEKMKAHCK, Transform BHNONFFBKHO, bool ANKHKPBBLNP = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T JOCJCJOONGM<T>(T ICCEKMKAHCK, Transform BHNONFFBKHO, bool ANKHKPBBLNP = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T JOCJCJOONGM<T>(GameObject ICCEKMKAHCK, Transform BHNONFFBKHO, bool ANKHKPBBLNP = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject JOCJCJOONGM(GameObject ICCEKMKAHCK, Transform BHNONFFBKHO, KNCMBPEPLDC HELLICJGLED, bool ANKHKPBBLNP);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BOCKHJPLIHH : IDisposable, CLCEIBOOIHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> DAEGDLNFCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> ECAGCAGEHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform BAEEBAJAHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> LFJBNFMCMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> MFNFKMDOMNA;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x620A3F0", Offset = "0x62095F0", VA = "0x18620A3F0")]
	[KEFCCLBEAOJ(CMEECPGEPNF.None)]
	public static void MOJFLBKELFO(LEHDPNIFNIH BFOBHJGOFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x620A540", Offset = "0x6209740", VA = "0x18620A540")]
	[Preserve]
	public BOCKHJPLIHH([GAGPBLHNPNO(null)] BCECDLLGJMJ GHIADONNPMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6209D10", Offset = "0x6208F10", VA = "0x186209D10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x620A4F0", Offset = "0x62096F0", VA = "0x18620A4F0", Slot = "5")]
	public void PEAKCAMLIED(params Type[] CKIGCMBDDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x620A2D0", Offset = "0x62094D0", VA = "0x18620A2D0", Slot = "6")]
	public GameObject JOCJCJOONGM(GameObject ICCEKMKAHCK, Transform BHNONFFBKHO, bool ANKHKPBBLNP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x26BEAA0", Offset = "0x26BDCA0", VA = "0x1826BEAA0", Slot = "7")]
	public T JOCJCJOONGM<T>(T ICCEKMKAHCK, Transform BHNONFFBKHO, bool ANKHKPBBLNP = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x26BEA30", Offset = "0x26BDC30", VA = "0x1826BEA30", Slot = "8")]
	public T JOCJCJOONGM<T>(GameObject ICCEKMKAHCK, Transform BHNONFFBKHO, bool ANKHKPBBLNP = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x620A360", Offset = "0x6209560", VA = "0x18620A360", Slot = "9")]
	public GameObject JOCJCJOONGM(GameObject ICCEKMKAHCK, Transform BHNONFFBKHO, KNCMBPEPLDC HELLICJGLED, bool ANKHKPBBLNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x26BEA60", Offset = "0x26BDC60", VA = "0x1826BEA60", Slot = "10")]
	public T JOCJCJOONGM<T>(GameObject ICCEKMKAHCK, Transform BHNONFFBKHO, KNCMBPEPLDC HELLICJGLED, bool ANKHKPBBLNP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x26BE480", Offset = "0x26BD680", VA = "0x1826BE480")]
	private T JOCJCJOONGM<T>(GameObject ICCEKMKAHCK, Transform BHNONFFBKHO, KNCMBPEPLDC HELLICJGLED, bool ANKHKPBBLNP, [Out] GameObject CGNGDOCLGBJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x26BDF40", Offset = "0x26BD140", VA = "0x1826BDF40")]
	private T IMNEOICLBOH<T>(GameObject OPEBICILKJE, KNCMBPEPLDC HELLICJGLED, bool ANKHKPBBLNP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6209A90", Offset = "0x6208C90", VA = "0x186209A90")]
	private void BFBGDFJKDEO(Component EFNFBPDAPGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6209DF0", Offset = "0x6208FF0", VA = "0x186209DF0")]
	private void HMCPHIPEOPF(Component EFNFBPDAPGP, KNCMBPEPLDC HELLICJGLED, bool ANKHKPBBLNP, bool DGPKGGGHKKM, [Optional] Type INNODOFHNHB, [Optional] Type NKMIJJKPAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6209BA0", Offset = "0x6208DA0", VA = "0x186209BA0")]
	private void DMBAAAIHIDO(GameObject OPEBICILKJE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct KNCMBPEPLDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> AIPODKAKFGE;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x297B8B0", Offset = "0x297AAB0", VA = "0x18297B8B0")]
	public KNCMBPEPLDC BHMONLIGLCO<T>(T FIDCPOMDIDE)
	{
		return default(KNCMBPEPLDC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x297C7B0", Offset = "0x297B9B0", VA = "0x18297C7B0")]
	public T OLBNKGLEPPK<T>(T FJPKGOAOIBJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x297BFE0", Offset = "0x297B1E0", VA = "0x18297BFE0")]
	public bool FBKMABELHLO<T>([Out] T FIDCPOMDIDE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct MIDJAHJJHCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool GGAGHKHFCCP;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xCCE730", Offset = "0xCCD930", VA = "0x180CCE730")]
	public MIDJAHJJHCM(bool IFNNCPABEBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct BNLCGEOHKBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool LJBHOAOOFMD;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6209A80", Offset = "0x6208C80", VA = "0x186209A80")]
	public BNLCGEOHKBM(bool KLJLLFDGMHJ)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7B45D0", Offset = "0x7B37D0", VA = "0x1807B45D0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, LJIOCCBGAEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6210E30", Offset = "0x6210030", VA = "0x186210E30", Slot = "4")]
		public void PrepareImposter(KNCMBPEPLDC HELLICJGLED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7B45D0", Offset = "0x7B37D0", VA = "0x1807B45D0")]
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
		public Bounds LKLJACCKJLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x620CD00", Offset = "0x620BF00", VA = "0x18620CD00")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x620CBD0", Offset = "0x620BDD0", VA = "0x18620CBD0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x620CB90", Offset = "0x620BD90", VA = "0x18620CB90")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x620CC10", Offset = "0x620BE10", VA = "0x18620CC10")]
		private void PEHGKGDLBBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7B45D0", Offset = "0x7B37D0", VA = "0x1807B45D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x620E390", Offset = "0x620D590", VA = "0x18620E390")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x620E380", Offset = "0x620D580", VA = "0x18620E380")]
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
		[Cpp2IlInjected.Address(RVA = "0x620DB80", Offset = "0x620CD80", VA = "0x18620DB80")]
		public void BBENHJMJKKL(Vector3 EEIGDNBGIKA, Quaternion IJNJPKLNGAL, float BNIMCGPDDCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x620DBB0", Offset = "0x620CDB0", VA = "0x18620DBB0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class NNKLBPFLNOF
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly Vector3 ILKNCGFDKGL;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly List<URPLight> BJMDLKFNGGF;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<Light> LBPNDKBAPPN;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Camera JONACKDAAPE;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<Renderer> ALCPEGJMMCE;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<ImposterBoundsOverride> BPAIDEBBEAM;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static AmbientMode PPMAACBMMOB;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static Color AHKAOGOACOI;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color LIDJEOMJCGD;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color IDGPFPCJGEP;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Cubemap FPKIPCDCIOL;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static bool CEBAINPJCAK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> CDEPBMGGEFL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x620E760", Offset = "0x620D960", VA = "0x18620E760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> PFPCJCFFNAH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x620F0C0", Offset = "0x620E2C0", VA = "0x18620F0C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera PBCKCGCFMMA
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x620F3D0", Offset = "0x620E5D0", VA = "0x18620F3D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x620E7B0", Offset = "0x620D9B0", VA = "0x18620E7B0")]
	public static void ANHKGODFKML(Vector3 GMPMLJLJDBO, Quaternion GLOKHFKNELJ, ImposterRenderConfig ECEPFMECGPI, bool FDGIJFNJAMK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6210440", Offset = "0x620F640", VA = "0x186210440")]
	private static void MINPNFNIHNB(Vector3 GMPMLJLJDBO, Quaternion GLOKHFKNELJ, URPLight FOKDJBAAFNC, ImposterRenderConfig.LightConfig CAAHNPIHJDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6210360", Offset = "0x620F560", VA = "0x186210360")]
	public static void MFKPHDCGGBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x620EBF0", Offset = "0x620DDF0", VA = "0x18620EBF0")]
	private static void FADCGHMIKDM(int NGFHIECEKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x620EA40", Offset = "0x620DC40", VA = "0x18620EA40")]
	public static void EJNFCJIKNPJ(ImposterRenderConfig ECEPFMECGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x620F600", Offset = "0x620E800", VA = "0x18620F600")]
	public static void HODAPIALBPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x620E420", Offset = "0x620D620", VA = "0x18620E420")]
	public static void AFKJNCMCPIO(GameObject HPHLIJAOBGM, RenderTexture PMJBCJODPKB, ImposterRenderConfig ECEPFMECGPI, ENOEHAHNLDA IDAFDFAIMLF, [Optional] Vector3? JMLOHLFBCIF, [Optional] Vector3? EJKOJMADIJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x620F6E0", Offset = "0x620E8E0", VA = "0x18620F6E0")]
	private static void IKGMBOEMNAI(GameObject HPHLIJAOBGM, RenderTexture PMJBCJODPKB, ImposterRenderConfig ECEPFMECGPI, ENOEHAHNLDA IDAFDFAIMLF, Vector3 JMLOHLFBCIF, Vector3 EJKOJMADIJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x620F110", Offset = "0x620E310", VA = "0x18620F110")]
	private static void GEHBIPBDHEO(GameObject HPHLIJAOBGM, Vector3 AEDEPHFCCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x620FD10", Offset = "0x620EF10", VA = "0x18620FD10")]
	private static void LIIPHHGMBNG(GameObject ICCEKMKAHCK, ImposterRenderConfig ECEPFMECGPI, ENOEHAHNLDA IDAFDFAIMLF, [Out] Vector3 KEICBJFBFKF, [Out] Quaternion JNPECBMILEI, [Out] float NDNEEBAHNOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6210760", Offset = "0x620F960", VA = "0x186210760")]
	public static RenderTexture PNAFMBGPFLF(int CPFEGDHJOBM, int OPAEHCFOMFA, RenderTextureFormat IHFDBLMLKMD = RenderTextureFormat.ARGB32)
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
		public struct NABBIFOJJDL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public ACJIGECFCHH AMNGBEKODNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public GameObject NJDHAMFJPGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public RenderTexture PLFPFKNPEIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public ImposterRenderConfig MJMLKCPJKPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public ENOEHAHNLDA ENOEHAHNLDA;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x620E3B0", Offset = "0x620D5B0", VA = "0x18620E3B0")]
			public NABBIFOJJDL(ACJIGECFCHH KOHDGMLINON, GameObject KFLHCCJIMJI, RenderTexture PMJBCJODPKB, ImposterRenderConfig IOFNPOFEBEO, ENOEHAHNLDA IDAFDFAIMLF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static AEKLEFMOAPE<NABBIFOJJDL, RenderTexture> AANNPPJJEJH;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly List<NABBIFOJJDL> ENJHGKCPPIL;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int BNFCCLJEAEA
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x620B810", Offset = "0x620AA10", VA = "0x18620B810")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x620B910", Offset = "0x620AB10", VA = "0x18620B910")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject HPHLIJAOBGM, RenderTexture PMJBCJODPKB, ImposterRenderConfig ECEPFMECGPI, ENOEHAHNLDA IDAFDFAIMLF, CancellationToken AIHJHMPAHCH, bool KHENPPBEBDH = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x620B430", Offset = "0x620A630", VA = "0x18620B430", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x620B880", Offset = "0x620AA80", VA = "0x18620B880", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x620B620", Offset = "0x620A820", VA = "0x18620B620")]
		private static Task<RenderTexture> CDCEKFOJPNI(NABBIFOJJDL OBAFHNEAOAP, CancellationToken AIHJHMPAHCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x620BD10", Offset = "0x620AF10", VA = "0x18620BD10")]
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
