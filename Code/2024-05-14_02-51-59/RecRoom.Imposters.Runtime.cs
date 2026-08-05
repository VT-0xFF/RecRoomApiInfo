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
	private readonly struct IJIMDMNDFHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly LOPJHCCJPFA CCANKGIKEPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string BMEHLGDELKA;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x95C330", Offset = "0x95AD30", VA = "0x18095C330")]
		public IJIMDMNDFHE(LOPJHCCJPFA ECIBOFOCIJG, string HICAJHCCFKD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct JNPPCJBAMLJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public IJIMDMNDFHE queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x635E9B0", Offset = "0x635D3B0", VA = "0x18635E9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x635ED50", Offset = "0x635D750", VA = "0x18635ED50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider DNHCFBPACPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private MPLEOKNNHLK<IJIMDMNDFHE, GameObject> ILPHBJFGOAP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ODCNBINMGBI FNLIDIJCHHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7C4AA0", Offset = "0x7C34A0", VA = "0x1807C4AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private MPLEOKNNHLK<IJIMDMNDFHE, GameObject> KLEDFIKMFDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x635A890", Offset = "0x6359290", VA = "0x18635A890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int BNKPPHDNJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x635A550", Offset = "0x6358F50", VA = "0x18635A550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x635A490", Offset = "0x6358E90", VA = "0x18635A490", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x635A9F0", Offset = "0x63593F0", VA = "0x18635A9F0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x635A5A0", Offset = "0x6358FA0", VA = "0x18635A5A0")]
	[AsyncStateMachine(typeof(JNPPCJBAMLJ))]
	private Task<GameObject> ILPKHNKOPAD(IJIMDMNDFHE IBDHDFBOGIG, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x635A6C0", Offset = "0x63590C0", VA = "0x18635A6C0")]
	public Task<GameObject> LoadItemAsync(LOPJHCCJPFA ECIBOFOCIJG, CancellationToken CFAFANOFDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x635AA60", Offset = "0x6359460", VA = "0x18635AA60")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class IPJCBGFMKNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public LOPJHCCJPFA ANAOENMFLIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture DGHPBMAMFNJ;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7D18F0", Offset = "0x7D02F0", VA = "0x1807D18F0")]
		public IPJCBGFMKNI(LOPJHCCJPFA ENMNAEPEJNL, Texture MGNEEDDHFPM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum LHMAMAGFNLE
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
	private class HENPDHNOKNE : DGPNADCMPPB<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct PICOABGFKFO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public HENPDHNOKNE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x635EEB0", Offset = "0x635D8B0", VA = "0x18635EEB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x635F6B0", Offset = "0x635E0B0", VA = "0x18635F6B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly LOPJHCCJPFA ENMNAEPEJNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture BFFPABKNLMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig ODLOCPDHFJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken CFAFANOFDNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject GKBNENEAJOE;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override NOCKNPDCDFN<Texture> FGCIIKBPCJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x635D1A0", Offset = "0x635BBA0", VA = "0x18635D1A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> MKMICJEMIPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7C5AC0", Offset = "0x7C44C0", VA = "0x1807C5AC0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x635D370", Offset = "0x635BD70", VA = "0x18635D370")]
		public HENPDHNOKNE(LOPJHCCJPFA ENMNAEPEJNL, RenderTexture BFFPABKNLMB, ImposterRenderConfig ODLOCPDHFJH, CancellationToken CFAFANOFDNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x635D200", Offset = "0x635BC00", VA = "0x18635D200")]
		[AsyncStateMachine(typeof(PICOABGFKFO))]
		private Task<Texture> PGFFGBKOHIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x635D190", Offset = "0x635BB90", VA = "0x18635D190", Slot = "10")]
		protected override void CPBJKKIAIDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x635D2F0", Offset = "0x635BCF0", VA = "0x18635D2F0")]
		private static void PHNDOEEAHIL(GameObject GKBNENEAJOE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct DEMMCBOIIMJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6359270", Offset = "0x6357C70", VA = "0x186359270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8B2120", Offset = "0x8B0B20", VA = "0x1808B2120", Slot = "5")]
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
	[JBAFOAIPPLI(PHOLEAOCMFP.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private LHMAMAGFNLE size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[HFAMGOOBNLK("size", LHMAMAGFNLE.Custom)]
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
	private static int ONEEEGJOJNA;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture GINKPFOACBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private EAECBNENIMI<GameObject> GEFIKMDANJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private GCGMANBCNNC PAHDHADBDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource NCPJPNOCKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NGGDDPJIFIN<Texture> MEGBNKENPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private LOPJHCCJPFA FHBNBJIBECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture FDDLILJOOJN;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int EGIMPMOADCA
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x635E480", Offset = "0x635CE80", VA = "0x18635E480")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x635E4D0", Offset = "0x635CED0", VA = "0x18635E4D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture FCBFFDMMKMF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x635DA80", Offset = "0x635C480", VA = "0x18635DA80")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AD0", Offset = "0x7C44D0", VA = "0x1807C5AD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private LOPJHCCJPFA ANAOENMFLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C6920", Offset = "0x7C5320", VA = "0x1807C6920")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x635DEF0", Offset = "0x635C8F0", VA = "0x18635DEF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool EENAMDGLJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1429C30", Offset = "0x1428630", VA = "0x181429C30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int FJNOEIJMMOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x635DDD0", Offset = "0x635C7D0", VA = "0x18635DDD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x635DA70", Offset = "0x635C470", VA = "0x18635DA70")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x635E050", Offset = "0x635CA50", VA = "0x18635E050")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x635DE70", Offset = "0x635C870", VA = "0x18635DE70")]
	private void EOPFHPPDNCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x635E3A0", Offset = "0x635CDA0", VA = "0x18635E3A0")]
	public void Set(LOPJHCCJPFA EPEAOIFDCKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x635E350", Offset = "0x635CD50", VA = "0x18635E350")]
	public void Set(Texture MGNEEDDHFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x635E360", Offset = "0x635CD60", VA = "0x18635E360")]
	public void Set(IPJCBGFMKNI AEJBOLFACJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x635DDC0", Offset = "0x635C7C0", VA = "0x18635DDC0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x635E150", Offset = "0x635CB50", VA = "0x18635E150")]
	public void SetInternal(LOPJHCCJPFA EPEAOIFDCKM, [Optional] Texture MFHKCPPMGCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x635E140", Offset = "0x635CB40", VA = "0x18635E140")]
	public void SetCustomSize(int PEDOCCGKAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C3EF0", VA = "0x1807C54F0")]
	public void SetAntiAliasing(int CIBNGMBDOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x635DD10", Offset = "0x635C710", VA = "0x18635DD10")]
	[AsyncStateMachine(typeof(DEMMCBOIIMJ))]
	private void BKKKPLMBFAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x635DC30", Offset = "0x635C630", VA = "0x18635DC30")]
	private void BFELPFNJKNM(Texture MGNEEDDHFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x635E400", Offset = "0x635CE00", VA = "0x18635E400")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, NGNKFFDJANI
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float NKINEFEIPOP = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "4")]
	public void PrepareImposter(EKHOBKMNPMK BJIJPHEEEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x635DA30", Offset = "0x635C430", VA = "0x18635DA30")]
	public void SetReferencePoint(Vector3 AFOLKIAHJCP, Quaternion JEMAGIAEKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x635D830", Offset = "0x635C230", VA = "0x18635D830")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x635DA10", Offset = "0x635C410", VA = "0x18635DA10")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x14D05F0", Offset = "0x14CEFF0", VA = "0x1814D05F0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KKHLOMPKDBH
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static KKHLOMPKDBH KIBOPPINPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float DKDLOGJCCCA;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x201A4F0", Offset = "0x2018EF0", VA = "0x18201A4F0")]
	public KKHLOMPKDBH(float LBLEFKKMOLF)
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
		[JBAFOAIPPLI(PHOLEAOCMFP.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int LIMBHICLJNF = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int IPBDIBCNPPN = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> EPGHPADOCLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool JGCFIMNCJKO;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x635E6E0", Offset = "0x635D0E0", VA = "0x18635E6E0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x635E5E0", Offset = "0x635CFE0", VA = "0x18635E5E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x635E920", Offset = "0x635D320", VA = "0x18635E920")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LOPJHCCJPFA
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string CCDCILGAPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	KKHLOMPKDBH KKHLOMPKDBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action IPPOIBIBDLC;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> DLOPCICEGNC(CancellationToken CFAFANOFDNJ);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NJBIEPJBEAH(LOPJHCCJPFA HKMMPHJFKEA);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DNMDNKBMAHB();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NJNIGDAFJLJ();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LMKINEHMLOL([Out] NGGDDPJIFIN<Texture> NBOIIOCDBLP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DHNPGGHDJGG
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6359A50", Offset = "0x6358450", VA = "0x186359A50")]
	public static bool KHDJENEBDLC(LOPJHCCJPFA IKEMKHDBIAN, LOPJHCCJPFA HBNFGGGIPEM)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, NGNKFFDJANI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6359120", Offset = "0x6357B20", VA = "0x186359120", Slot = "4")]
		public void PrepareImposter(EKHOBKMNPMK BJIJPHEEEMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7C34A0", Offset = "0x7C1EA0", VA = "0x1807C34A0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7C34A0", Offset = "0x7C1EA0", VA = "0x1807C34A0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface NGNKFFDJANI
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(EKHOBKMNPMK BJIJPHEEEMG);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface NBMMNGACION
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> DHBCCLEIPLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> LAFBLOBDGMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface ODCNBINMGBI
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GCJBAGBHCKE(params Type[] EIDHNKEHKMD);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject JJMCNPJGIEA(GameObject IGNCHADJNDE, Transform HHJLJBMAMDD, bool KGJDINJALJJ = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T JJMCNPJGIEA<T>(T IGNCHADJNDE, Transform HHJLJBMAMDD, bool KGJDINJALJJ = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T JJMCNPJGIEA<T>(GameObject IGNCHADJNDE, Transform HHJLJBMAMDD, bool KGJDINJALJJ = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject JJMCNPJGIEA(GameObject IGNCHADJNDE, Transform HHJLJBMAMDD, EKHOBKMNPMK BJIJPHEEEMG, bool KGJDINJALJJ);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BMJJBAPHMLL : IDisposable, ODCNBINMGBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> OIBCGBHHFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> GBKLIKFLLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform EOLPJOFELAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> GBONHEOLFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> MOIICLPIFKK;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6358490", Offset = "0x6356E90", VA = "0x186358490")]
	[JCOMPLNHMEG(AOHDMBIABEL.None)]
	public static void GHEMDLAGGBM(ICKBMMGCCPN NFHEIBLLDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6358CE0", Offset = "0x63576E0", VA = "0x186358CE0")]
	[Preserve]
	public BMJJBAPHMLL([JDJLHBHAJCP(null)] NBMMNGACION PEGEEJOCMII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6358360", Offset = "0x6356D60", VA = "0x186358360", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6358440", Offset = "0x6356E40", VA = "0x186358440", Slot = "5")]
	public void GCJBAGBHCKE(params Type[] EIDHNKEHKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6358AE0", Offset = "0x63574E0", VA = "0x186358AE0", Slot = "6")]
	public GameObject JJMCNPJGIEA(GameObject IGNCHADJNDE, Transform HHJLJBMAMDD, bool KGJDINJALJJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x271F160", Offset = "0x271DB60", VA = "0x18271F160", Slot = "7")]
	public T JJMCNPJGIEA<T>(T IGNCHADJNDE, Transform HHJLJBMAMDD, bool KGJDINJALJJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x271F130", Offset = "0x271DB30", VA = "0x18271F130", Slot = "8")]
	public T JJMCNPJGIEA<T>(GameObject IGNCHADJNDE, Transform HHJLJBMAMDD, bool KGJDINJALJJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6358A50", Offset = "0x6357450", VA = "0x186358A50", Slot = "9")]
	public GameObject JJMCNPJGIEA(GameObject IGNCHADJNDE, Transform HHJLJBMAMDD, EKHOBKMNPMK BJIJPHEEEMG, bool KGJDINJALJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x271F1D0", Offset = "0x271DBD0", VA = "0x18271F1D0", Slot = "10")]
	public T JJMCNPJGIEA<T>(GameObject IGNCHADJNDE, Transform HHJLJBMAMDD, EKHOBKMNPMK BJIJPHEEEMG, bool KGJDINJALJJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x271EBC0", Offset = "0x271D5C0", VA = "0x18271EBC0")]
	private T JJMCNPJGIEA<T>(GameObject IGNCHADJNDE, Transform HHJLJBMAMDD, EKHOBKMNPMK BJIJPHEEEMG, bool KGJDINJALJJ, [Out] GameObject JDIKNPOCKDM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x271F210", Offset = "0x271DC10", VA = "0x18271F210")]
	private T LOHADFEGAFJ<T>(GameObject PACDKKMGCFJ, EKHOBKMNPMK BJIJPHEEEMG, bool KGJDINJALJJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6358250", Offset = "0x6356C50", VA = "0x186358250")]
	private void BAJHKCMKBBJ(Component KLKCJLEHBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6358590", Offset = "0x6356F90", VA = "0x186358590")]
	private void HAPMOICBJKI(Component KLKCJLEHBJG, EKHOBKMNPMK BJIJPHEEEMG, bool KGJDINJALJJ, bool FAKPIIHNONB, [Optional] Type KAGAJCFBHEF, [Optional] Type LAJDNGNHOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6358B70", Offset = "0x6357570", VA = "0x186358B70")]
	private void LNDKCFGCDFP(GameObject PACDKKMGCFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct EKHOBKMNPMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> PNEHFFKDBOE;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x280B5A0", Offset = "0x2809FA0", VA = "0x18280B5A0")]
	public EKHOBKMNPMK NPHNBOIFMNI<T>(T GNMAOBOLLDB)
	{
		return default(EKHOBKMNPMK);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x280BCD0", Offset = "0x280A6D0", VA = "0x18280BCD0")]
	public T OIFPBAJNOAG<T>(T LFANPJOLHJB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x280ADD0", Offset = "0x28097D0", VA = "0x18280ADD0")]
	public bool NLEJDEABFNF<T>([Out] T GNMAOBOLLDB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct AFHFFIGINAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool JPPMEAAIKFE;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xCE6180", Offset = "0xCE4B80", VA = "0x180CE6180")]
	public AFHFFIGINAJ(bool KIIPEOIJECJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct LFPENFAPGIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool CAIBELMOPEI;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x635EE00", Offset = "0x635D800", VA = "0x18635EE00")]
	public LFPENFAPGIF(bool OHNKGAPCFAC)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7C34A0", Offset = "0x7C1EA0", VA = "0x1807C34A0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, NGNKFFDJANI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x635F720", Offset = "0x635E120", VA = "0x18635F720", Slot = "4")]
		public void PrepareImposter(EKHOBKMNPMK BJIJPHEEEMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7C34A0", Offset = "0x7C1EA0", VA = "0x1807C34A0")]
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
		public Bounds KBBJDNCPCNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x635D6A0", Offset = "0x635C0A0", VA = "0x18635D6A0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x635D660", Offset = "0x635C060", VA = "0x18635D660")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x635D620", Offset = "0x635C020", VA = "0x18635D620")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x635D530", Offset = "0x635BF30", VA = "0x18635D530")]
		private void IAOAHGKOBIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7C34A0", Offset = "0x7C1EA0", VA = "0x1807C34A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x635EE20", Offset = "0x635D820", VA = "0x18635EE20")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x635EE10", Offset = "0x635D810", VA = "0x18635EE10")]
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
		[Cpp2IlInjected.Address(RVA = "0x635E550", Offset = "0x635CF50", VA = "0x18635E550")]
		public void JLFNDGCBMPA(Vector3 OODCIEHPNID, Quaternion CBDKNBGBKBJ, float HICLEMOGIBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x635E580", Offset = "0x635CF80", VA = "0x18635E580")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class HEIACLAIGNJ
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly Vector3 BLBDIEJKIMA;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly List<URPLight> ENHKHDODIOK;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<Light> ODBEOIMCBBH;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Camera OJLIMHOODJP;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<Renderer> PPLCKAFJPPH;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<ImposterBoundsOverride> GAGAOOFECHK;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static AmbientMode ABOOLLMKEBC;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static Color FGIFBIKBFBJ;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color PGDDACGGGOJ;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color PJAAHPKMKME;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Cubemap CFMHMHIEFCD;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static bool GIBHPMMILCL;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> MNIJOMLOIMB
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x635BD70", Offset = "0x635A770", VA = "0x18635BD70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> BGDPKMJCDIO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x635BC40", Offset = "0x635A640", VA = "0x18635BC40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera NHLHMGGKFLE
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x635C3E0", Offset = "0x635ADE0", VA = "0x18635C3E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x635CCC0", Offset = "0x635B6C0", VA = "0x18635CCC0")]
	public static void PMENDNEAJLC(Vector3 OEGAIGIGMCB, Quaternion EHMFIFAHLEG, ImposterRenderConfig FLPEEPAOBIP, bool FJOAMPICBOI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x635BDC0", Offset = "0x635A7C0", VA = "0x18635BDC0")]
	private static void IGOBKOHHCEB(Vector3 OEGAIGIGMCB, Quaternion EHMFIFAHLEG, URPLight LIKINFIHBBJ, ImposterRenderConfig.LightConfig HJAEFMNGJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x635BC90", Offset = "0x635A690", VA = "0x18635BC90")]
	public static void GMJEHDLAFCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x635C630", Offset = "0x635B030", VA = "0x18635C630")]
	private static void OCGIOCDEGAL(int NDKLBGFHDCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x635CB00", Offset = "0x635B500", VA = "0x18635CB00")]
	public static void ONHFKKMCEKF(ImposterRenderConfig FLPEEPAOBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x635B0F0", Offset = "0x6359AF0", VA = "0x18635B0F0")]
	public static void EOIEEHHPPFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x635B290", Offset = "0x6359C90", VA = "0x18635B290")]
	public static void FFPDEIEALHD(GameObject KKLBFKCCGMC, RenderTexture BFFPABKNLMB, ImposterRenderConfig FLPEEPAOBIP, KKHLOMPKDBH CGBNCFHIHGH, [Optional] Vector3? BMNKAMFBHKJ, [Optional] Vector3? KEPHNHBEJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x635AAA0", Offset = "0x63594A0", VA = "0x18635AAA0")]
	private static void AMGHBDDKPMP(GameObject KKLBFKCCGMC, RenderTexture BFFPABKNLMB, ImposterRenderConfig FLPEEPAOBIP, KKHLOMPKDBH CGBNCFHIHGH, Vector3 BMNKAMFBHKJ, Vector3 KEPHNHBEJEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x635C0F0", Offset = "0x635AAF0", VA = "0x18635C0F0")]
	private static void IOEOEAKMLKK(GameObject KKLBFKCCGMC, Vector3 CELOCKHAAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x635B5D0", Offset = "0x6359FD0", VA = "0x18635B5D0")]
	private static void FGDFJKOAIMG(GameObject IGNCHADJNDE, ImposterRenderConfig FLPEEPAOBIP, KKHLOMPKDBH CGBNCFHIHGH, [Out] Vector3 JCEKBKFIJCN, [Out] Quaternion CGNLAABIDKB, [Out] float BNJHKMEIPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x635B1E0", Offset = "0x6359BE0", VA = "0x18635B1E0")]
	public static RenderTexture FDAIBAHIEMK(int CJHPDBBIODN, int IOMCLAJAMBC, RenderTextureFormat OPPPAIJEHEA = RenderTextureFormat.ARGB32)
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
		public struct MNLLCHMMNLM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public PFMMCNAEBBC MPJFKIPABLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public GameObject OMKDGCBPHLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public RenderTexture FCBFFDMMKMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public ImposterRenderConfig INPBJBDONCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public KKHLOMPKDBH KKHLOMPKDBH;

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x635EE40", Offset = "0x635D840", VA = "0x18635EE40")]
			public MNLLCHMMNLM(PFMMCNAEBBC LDIKDPIHFJE, GameObject GEFGAFELAPI, RenderTexture BFFPABKNLMB, ImposterRenderConfig ODLOCPDHFJH, KKHLOMPKDBH CGBNCFHIHGH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static MPLEOKNNHLK<MNLLCHMMNLM, RenderTexture> JJLPDNGLCPJ;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly List<MNLLCHMMNLM> FMOFIFCPFEG;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int HFGMBOIMJJO
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x6359D30", Offset = "0x6358730", VA = "0x186359D30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x635A030", Offset = "0x6358A30", VA = "0x18635A030")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject KKLBFKCCGMC, RenderTexture BFFPABKNLMB, ImposterRenderConfig FLPEEPAOBIP, KKHLOMPKDBH CGBNCFHIHGH, CancellationToken CFAFANOFDNJ, bool AHGMJGLCEEN = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6359B40", Offset = "0x6358540", VA = "0x186359B40", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6359F90", Offset = "0x6358990", VA = "0x186359F90", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6359DA0", Offset = "0x63587A0", VA = "0x186359DA0")]
		private static Task<RenderTexture> GEDCABMDIOI(MNLLCHMMNLM OHIKOHNOEMB, CancellationToken CFAFANOFDNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x635A450", Offset = "0x6358E50", VA = "0x18635A450")]
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
