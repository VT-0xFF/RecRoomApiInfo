using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mono.Math;
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
	private readonly struct AEJMIMJCOEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly DFLPHAADPHN MBOODNJHCCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string HEOCCDCMFEI;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x777A10", Offset = "0x776C10", VA = "0x180777A10")]
		public AEJMIMJCOEJ(DFLPHAADPHN JALJCACICHM, string KBIEAGHEDBI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct DKNCMICIIEJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AEJMIMJCOEJ queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x638EC10", Offset = "0x638DE10", VA = "0x18638EC10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x638EF50", Offset = "0x638E150", VA = "0x18638EF50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider NPKCODKDOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private global::CJKFHLCLKLH<AEJMIMJCOEJ, GameObject> HNOJNMFHIKG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public MGCJFJALFNJ DAIJJHHHGJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6E7140", Offset = "0x6E6340", VA = "0x1806E7140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private global::CJKFHLCLKLH<AEJMIMJCOEJ, GameObject> PGEBGMGNJFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x638F980", Offset = "0x638EB80", VA = "0x18638F980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int CBMFJGPCAFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x638FE70", Offset = "0x638F070", VA = "0x18638FE70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x638F8D0", Offset = "0x638EAD0", VA = "0x18638F8D0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x638FE00", Offset = "0x638F000", VA = "0x18638FE00", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x638FAE0", Offset = "0x638ECE0", VA = "0x18638FAE0")]
	[AsyncStateMachine(typeof(DKNCMICIIEJ))]
	private Task<GameObject> JOPHIPOHPAH(AEJMIMJCOEJ LPGELLFPBFO, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x638FC30", Offset = "0x638EE30", VA = "0x18638FC30")]
	public Task<GameObject> LoadItemAsync(DFLPHAADPHN JALJCACICHM, CancellationToken OLHHOODBFDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x638FEC0", Offset = "0x638F0C0", VA = "0x18638FEC0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class HIJBAIPMFHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public DFLPHAADPHN NOEACBMPFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly Texture HOHBMPGOINA;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6C76E0", Offset = "0x6C68E0", VA = "0x1806C76E0")]
		public HIJBAIPMFHC(DFLPHAADPHN LOJJGPONDKL, Texture IGCBGLPMGJK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum LMGPCOINOLG
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Custom = 0,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		XS_128 = 0x80,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		S_256 = 0x100,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		M_512 = 0x200,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		L_1024 = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		XL_2048 = 0x800
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class FBKMCHOEGFI : global::KDDHCJEKEOC<Texture>, HKCEDMFMCPJ, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct CCGKDADJAHF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public FBKMCHOEGFI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x638E360", Offset = "0x638D560", VA = "0x18638E360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x638EA60", Offset = "0x638DC60", VA = "0x18638EA60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly DFLPHAADPHN LOJJGPONDKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly RenderTexture PBCNPEOJNIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly ImposterRenderConfig IJMNMLDIMHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly CancellationToken OLHHOODBFDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private GameObject LHDIHKMFIDF;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private PMOAFBNPLHC MCBFIENEHFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x63917C0", Offset = "0x63909C0", VA = "0x1863917C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public global::HCPIAAEIKCB<Texture> NKJMNAHLMMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6391650", Offset = "0x6390850", VA = "0x186391650", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Task IPIPBJAONCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6DD6F0", Offset = "0x6DC8F0", VA = "0x1806DD6F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Task<Texture> JDLFEMNJEDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6DD6F0", Offset = "0x6DC8F0", VA = "0x1806DD6F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x63917D0", Offset = "0x63909D0", VA = "0x1863917D0")]
		public FBKMCHOEGFI(DFLPHAADPHN LOJJGPONDKL, RenderTexture PBCNPEOJNIM, ImposterRenderConfig IJMNMLDIMHC, CancellationToken OLHHOODBFDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x63916A0", Offset = "0x63908A0", VA = "0x1863916A0")]
		[AsyncStateMachine(typeof(CCGKDADJAHF))]
		private Task<Texture> OOPEHMIFICA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x63915B0", Offset = "0x63907B0", VA = "0x1863915B0", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x63915C0", Offset = "0x63907C0", VA = "0x1863915C0")]
		private static void FNOFLLNGJHB(GameObject LHDIHKMFIDF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct PHJBJCCNEHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<Texture> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6394AD0", Offset = "0x6393CD0", VA = "0x186394AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6D0AD0", Offset = "0x6CFCD0", VA = "0x1806D0AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	[Header("General")]
	[Tooltip("Texture shown when the imposter texture is not available")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private LMGPCOINOLG size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[Tooltip("Custom pixel size for rendered imposter")]
	[JLJIECADMGK("size", 0)]
	private int customSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	private int antiAliasing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[Tooltip("Configuration specifying render properties for the imposter")]
	private ImposterRenderConfig imposterRenderConfig;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private RenderTexture NMCDFFEEHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private global::BPGHEFONOCE<GameObject> IICIGKPFMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private MONKECHCONN NHFNGOJBIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private CancellationTokenSource BMLBNCLOPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private global::KDDHCJEKEOC<Texture> MNAHMACHBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private DFLPHAADPHN CLOOGGMDOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Texture KDBEPEMKOFO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private RenderTexture GOHNPEDCEJN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6393F20", Offset = "0x6393120", VA = "0x186393F20")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6CE5A0", Offset = "0x6CD7A0", VA = "0x1806CE5A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private DFLPHAADPHN NOEACBMPFJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6DD780", Offset = "0x6DC980", VA = "0x1806DD780")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6394120", Offset = "0x6393320", VA = "0x186394120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool PPHLMHHBKAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8B25C0", Offset = "0x8B17C0", VA = "0x1808B25C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int ODHGAFNNEDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6393F10", Offset = "0x6393110", VA = "0x186393F10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6393D30", Offset = "0x6392F30", VA = "0x186393D30")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6394270", Offset = "0x6393470", VA = "0x186394270")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6394090", Offset = "0x6393290", VA = "0x186394090")]
	private void GPPKLHLLJNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x63945E0", Offset = "0x63937E0", VA = "0x1863945E0")]
	public void Set(DFLPHAADPHN FDHGPOHAJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x63945D0", Offset = "0x63937D0", VA = "0x1863945D0")]
	public void Set(Texture IGCBGLPMGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6394590", Offset = "0x6393790", VA = "0x186394590")]
	public void Set(HIJBAIPMFHC JFBPNBNBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6393E10", Offset = "0x6393010", VA = "0x186393E10")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6394370", Offset = "0x6393570", VA = "0x186394370")]
	public void SetInternal(DFLPHAADPHN FDHGPOHAJGG, [Optional] Texture MFHGAOMDMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6394360", Offset = "0x6393560", VA = "0x186394360")]
	public void SetCustomSize(int NDMDEKJEBEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x72E640", Offset = "0x72D840", VA = "0x18072E640")]
	public void SetAntiAliasing(int IEIGKIOFAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6393D40", Offset = "0x6392F40", VA = "0x186393D40")]
	[AsyncStateMachine(typeof(PHJBJCCNEHL))]
	private void BLICJGLHBHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6393E20", Offset = "0x6393020", VA = "0x186393E20")]
	private void DCOHFKMEMPG(Texture IGCBGLPMGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x63945F0", Offset = "0x63937F0", VA = "0x1863945F0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, OMLMIEKPNLF
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const float AFIADKMLPDF = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "4")]
	public void PrepareImposter(MIJGGDHPBBB OOMECLFFJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6393CF0", Offset = "0x6392EF0", VA = "0x186393CF0")]
	public void SetReferencePoint(Vector3 HHJBJKMLAEE, Quaternion LLGKGFNMLGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6393B60", Offset = "0x6392D60", VA = "0x186393B60")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6393CC0", Offset = "0x6392EC0", VA = "0x186393CC0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x107CC60", Offset = "0x107BE60", VA = "0x18107CC60")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KNOCMPMFAKM
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static KNOCMPMFAKM CFLNDNPMHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float HMGNCIFOOML;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x2E31D20", Offset = "0x2E30F20", VA = "0x182E31D20")]
	public KNOCMPMFAKM(float AKLGLDLPDCK)
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const int GNFBHCFCEKL = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const int JBPPGCEMHAI = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly List<Material> HABGIDFKEFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool FOKBMLMPAPK;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x63947A0", Offset = "0x63939A0", VA = "0x1863947A0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x63946B0", Offset = "0x63938B0", VA = "0x1863946B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x63949E0", Offset = "0x6393BE0", VA = "0x1863949E0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DFLPHAADPHN
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string DKCCGENCKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	KNOCMPMFAKM KNOCMPMFAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action MEANEPJIINL;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> FPJJELPDJHJ(CancellationToken OLHHOODBFDC);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MONGDJMFKMD(DFLPHAADPHN IHIJPIJNLJM);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CJMPMGKFELO();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BGBPAACEOPD();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OHPELPEHIBE(out global::KDDHCJEKEOC<Texture> DCOBKPHNKBH);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GBHDIIPADNE
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6391970", Offset = "0x6390B70", VA = "0x186391970")]
	public static bool EMNMGKDAMKK(DFLPHAADPHN DCFKDNCKOMB, DFLPHAADPHN HNMOBJPIOEB)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, OMLMIEKPNLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x638EAB0", Offset = "0x638DCB0", VA = "0x18638EAB0", Slot = "4")]
		public void PrepareImposter(MIJGGDHPBBB OOMECLFFJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xE24550", Offset = "0xE23750", VA = "0x180E24550")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xE24550", Offset = "0xE23750", VA = "0x180E24550")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface OMLMIEKPNLF
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(MIJGGDHPBBB OOMECLFFJIL);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PAJFFLJMAKH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> GBMJGHAKONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<Type> DLNGLNFENJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface MGCJFJALFNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BCOMGPILOHE(params Type[] CDFICLLHOEC);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LEFLFKEMCNE(params Type[] CDFICLLHOEC);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject FMGBMFEJFKK(GameObject NMEDHGOIPNG, Transform GPFONCECPBK, bool FDGGHNALPDE = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T FMGBMFEJFKK<T>(T NMEDHGOIPNG, Transform GPFONCECPBK, bool FDGGHNALPDE = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T FMGBMFEJFKK<T>(GameObject NMEDHGOIPNG, Transform GPFONCECPBK, bool FDGGHNALPDE = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject FMGBMFEJFKK(GameObject NMEDHGOIPNG, Transform GPFONCECPBK, MIJGGDHPBBB OOMECLFFJIL, bool FDGGHNALPDE);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T FMGBMFEJFKK<T>(GameObject NMEDHGOIPNG, Transform GPFONCECPBK, MIJGGDHPBBB OOMECLFFJIL, bool FDGGHNALPDE) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T FMGBMFEJFKK<T>(T NMEDHGOIPNG, Transform GPFONCECPBK, MIJGGDHPBBB OOMECLFFJIL, bool FDGGHNALPDE) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EBMIGKJBCBA : IDisposable, MGCJFJALFNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly HashSet<Type> GAHCNLECMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly HashSet<Type> OKLPHNFAPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform EEICIFMAIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly List<Component> OMAPDHIAICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> ODFPGAJMBON;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x63906F0", Offset = "0x638F8F0", VA = "0x1863906F0")]
	[ELNMOMKNGKB(LBAHANGFDMJ.None)]
	public static void HBBPIOBOEHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6390AD0", Offset = "0x638FCD0", VA = "0x186390AD0")]
	[Preserve]
	public EBMIGKJBCBA([CNHALHMHHIC(null)] PAJFFLJMAKH AJGNIBMJLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x63904D0", Offset = "0x638F6D0", VA = "0x1863904D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6390480", Offset = "0x638F680", VA = "0x186390480", Slot = "5")]
	public void BCOMGPILOHE(params Type[] CDFICLLHOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x63907F0", Offset = "0x638F9F0", VA = "0x1863907F0", Slot = "6")]
	public void LEFLFKEMCNE(params Type[] CDFICLLHOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x63905D0", Offset = "0x638F7D0", VA = "0x1863905D0", Slot = "7")]
	public GameObject FMGBMFEJFKK(GameObject NMEDHGOIPNG, Transform GPFONCECPBK, bool FDGGHNALPDE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x1F96450", Offset = "0x1F95650", VA = "0x181F96450", Slot = "8")]
	public T FMGBMFEJFKK<T>(T NMEDHGOIPNG, Transform GPFONCECPBK, bool FDGGHNALPDE = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x1F965A0", Offset = "0x1F957A0", VA = "0x181F965A0", Slot = "9")]
	public T FMGBMFEJFKK<T>(GameObject NMEDHGOIPNG, Transform GPFONCECPBK, bool FDGGHNALPDE = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6390660", Offset = "0x638F860", VA = "0x186390660", Slot = "10")]
	public GameObject FMGBMFEJFKK(GameObject NMEDHGOIPNG, Transform GPFONCECPBK, MIJGGDHPBBB OOMECLFFJIL, bool FDGGHNALPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1F96550", Offset = "0x1F95750", VA = "0x181F96550", Slot = "11")]
	public T FMGBMFEJFKK<T>(GameObject NMEDHGOIPNG, Transform GPFONCECPBK, MIJGGDHPBBB OOMECLFFJIL, bool FDGGHNALPDE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x1F964C0", Offset = "0x1F956C0", VA = "0x181F964C0", Slot = "12")]
	public T FMGBMFEJFKK<T>(T NMEDHGOIPNG, Transform GPFONCECPBK, MIJGGDHPBBB OOMECLFFJIL, bool FDGGHNALPDE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x1F95F20", Offset = "0x1F95120", VA = "0x181F95F20")]
	private T FMGBMFEJFKK<T>(GameObject NMEDHGOIPNG, Transform GPFONCECPBK, MIJGGDHPBBB OOMECLFFJIL, bool FDGGHNALPDE, out GameObject FDHLNDMFLOJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x1F965D0", Offset = "0x1F957D0", VA = "0x181F965D0")]
	private T GOKOELLFJEL<T>(GameObject OOKBNBHDPPG, MIJGGDHPBBB OOMECLFFJIL, bool FDGGHNALPDE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x63909A0", Offset = "0x638FBA0", VA = "0x1863909A0")]
	private void OOBJABDFJGA(Component BGHFDNDJKMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x638FF30", Offset = "0x638F130", VA = "0x18638FF30")]
	private void AIOAAGGHMBK(Component BGHFDNDJKMA, MIJGGDHPBBB OOMECLFFJIL, bool FDGGHNALPDE, bool JPMFBKMNLCJ, [Optional] Type MFHFFCEHMJO, [Optional] Type MLKAFHHFOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6390840", Offset = "0x638FA40", VA = "0x186390840")]
	private void LJFENJOFMCH(GameObject OOKBNBHDPPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct MIJGGDHPBBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Dictionary<Type, object> DFFKHODFDCL;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3081B80", Offset = "0x3080D80", VA = "0x183081B80")]
	public MIJGGDHPBBB HDECKBNAIGA<T>(T CFMAPONGMKH)
	{
		return default(MIJGGDHPBBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x30822B0", Offset = "0x30814B0", VA = "0x1830822B0")]
	public T JLPNHBINJFC<T>(T EOBGHKICABG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x30813E0", Offset = "0x30805E0", VA = "0x1830813E0")]
	public bool GIGJNHOBOLH<T>(out T CFMAPONGMKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct KAGNBADEMEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool KPDFPIOKCDF;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xE99070", Offset = "0xE98270", VA = "0x180E99070")]
	public KAGNBADEMEL(bool AOPGABPPNOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct ANEKFPBIPKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool NEDCKJMHMHC;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x638E350", Offset = "0x638D550", VA = "0x18638E350")]
	public ANEKFPBIPKA(bool KBCJNGHFEGM)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xE24550", Offset = "0xE23750", VA = "0x180E24550")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, OMLMIEKPNLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6395260", Offset = "0x6394460", VA = "0x186395260", Slot = "4")]
		public void PrepareImposter(MIJGGDHPBBB OOMECLFFJIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xE24550", Offset = "0xE23750", VA = "0x180E24550")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CreateAssetMenu]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x6394AB0", Offset = "0x6393CB0", VA = "0x186394AB0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6394AA0", Offset = "0x6393CA0", VA = "0x186394AA0")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6394670", Offset = "0x6393870", VA = "0x186394670")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class IFAMPHAIFIC
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<URPLight> HGCJAPIOLKF;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly Vector3 KCJFJKLPACK;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly Vector3 FBJFJNHOLCB;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static Camera ABMDJJFCNPD;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public const string CFOBANPADLB = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public const BPCMFKIKLIM BEEELPLPOEH = BPCMFKIKLIM.Water;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly List<Renderer> HJIBPOHGPMF;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static AmbientMode ABPDILMGELP;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static Color INMCBEHDAFH;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static Color AHGNECGHKAE;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color MALFIGOLIHF;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Cubemap GEBFIJAONNE;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static bool MGAJFABOEMB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera JOPMOMDLGGK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6392A10", Offset = "0x6391C10", VA = "0x186392A10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6392790", Offset = "0x6391990", VA = "0x186392790")]
	public static void KLEKJKOJEGI(Vector3 GPPIIBMDEAP, Quaternion KBHOIHDFKHN, ImposterRenderConfig BMLKGLFJDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6393340", Offset = "0x6392540", VA = "0x186393340")]
	private static void NBLNMBDDLLJ(Vector3 GPPIIBMDEAP, Quaternion KBHOIHDFKHN, URPLight PPJELJDFMIO, ImposterRenderConfig.LightConfig LLHKLMKKLFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6391F50", Offset = "0x6391150", VA = "0x186391F50")]
	public static void DPPDANJLNDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6392C40", Offset = "0x6391E40", VA = "0x186392C40")]
	private static void MNDBBCBKHIH(int BOFOJCNMEPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6393890", Offset = "0x6392A90", VA = "0x186393890")]
	public static void PIGHKOONONH(ImposterRenderConfig BMLKGLFJDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6393240", Offset = "0x6392440", VA = "0x186393240")]
	public static void MOLICGFMIDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6392040", Offset = "0x6391240", VA = "0x186392040")]
	public static void GJIDFFCNBKK(GameObject FENKPJMJONM, RenderTexture PBCNPEOJNIM, ImposterRenderConfig BMLKGLFJDLM, KNOCMPMFAKM AGPLIKFNKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6391A50", Offset = "0x6390C50", VA = "0x186391A50")]
	private static void CFAOJLLCIEH(GameObject FENKPJMJONM, RenderTexture PBCNPEOJNIM, ImposterRenderConfig BMLKGLFJDLM, KNOCMPMFAKM AGPLIKFNKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6392210", Offset = "0x6391410", VA = "0x186392210")]
	private static void HPEKANDHFJC(GameObject FENKPJMJONM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x63936F0", Offset = "0x63928F0", VA = "0x1863936F0")]
	public static void OPOOCLCAALF(List<Renderer> ENLPAGILIHH, List<Material> MKIFPALGFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x63924C0", Offset = "0x63916C0", VA = "0x1863924C0")]
	public static void KIMAOKILMBD(GameObject NMEDHGOIPNG, Vector3 AAPKPEAFLKO, Vector3 MIJHBLGIGBC, float BCFJHIAIBGG, KNOCMPMFAKM AGPLIKFNKOC, out Vector3 KLKAFLMFJAM, out Quaternion CHCKLNMPGJC, out float AJMPDCJMEIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6393650", Offset = "0x6392850", VA = "0x186393650")]
	public static RenderTexture NMGLGGFDODF(int HMEFMFINFBK, int OELIKJHOPLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6393010", Offset = "0x6392210", VA = "0x186393010")]
	public static void MNDHPOMNPPE()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public struct EJPCKGEJEFK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public AEOJOFIFGIK EBODDHNLHKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public GameObject MNALPLCIONM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public RenderTexture GOHNPEDCEJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public ImposterRenderConfig OOLKNBBEABK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public KNOCMPMFAKM KNOCMPMFAKM;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6391540", Offset = "0x6390740", VA = "0x186391540")]
			public EJPCKGEJEFK(AEOJOFIFGIK MNPLPCBLMHP, GameObject BGLHIKBADGP, RenderTexture PBCNPEOJNIM, ImposterRenderConfig IJMNMLDIMHC, KNOCMPMFAKM AGPLIKFNKOC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static global::CJKFHLCLKLH<EJPCKGEJEFK, RenderTexture> MCNNNBBIJHO;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly List<EJPCKGEJEFK> GCDGGKMDCJA;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int KONLFOGAMME
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x638F190", Offset = "0x638E390", VA = "0x18638F190")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x638F470", Offset = "0x638E670", VA = "0x18638F470")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject FENKPJMJONM, RenderTexture PBCNPEOJNIM, ImposterRenderConfig BMLKGLFJDLM, KNOCMPMFAKM AGPLIKFNKOC, CancellationToken OLHHOODBFDC, bool BHIOHDFLBGJ = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x638EFA0", Offset = "0x638E1A0", VA = "0x18638EFA0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x638F3D0", Offset = "0x638E5D0", VA = "0x18638F3D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x638F200", Offset = "0x638E400", VA = "0x18638F200")]
		private static Task<RenderTexture> NCFCNFNIDHD(EJPCKGEJEFK MFGCLCFDOEF, CancellationToken OLHHOODBFDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x638F860", Offset = "0x638EA60", VA = "0x18638F860")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class EGIIOKJKKGL
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static byte[] LAFDEEMEPDM;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static int AHBPGGLKEKP;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static int MAHPDNGMMFO;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static BigInteger NMOJFJKJLEG;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public EGIIOKJKKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6390F10", Offset = "0x6390110", VA = "0x186390F10")]
	private static string CIEKLEOAFAL(byte[] GPHMIGDKMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6391020", Offset = "0x6390220", VA = "0x186391020")]
	public static string NOFFLEGCGLA(byte[] NPNCGJAPKIL, bool FBFFLNHILGA)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
