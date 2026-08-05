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
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
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
	private readonly struct DGPBGNLNFJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly DHMKECHGJDG FPMLIJHLIDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string HEIDAHJIDHB;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9E2EE0", Offset = "0x9E20E0", VA = "0x1809E2EE0")]
		public DGPBGNLNFJH(DHMKECHGJDG KFPICODFPEF, string CAOLAKPGBJI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct CHHBLNCDBOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public DGPBGNLNFJH queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x762F990", Offset = "0x762EB90", VA = "0x18762F990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x762FD50", Offset = "0x762EF50", VA = "0x18762FD50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider MBEDBNKCOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private FIIPNJENADE<DGPBGNLNFJH, GameObject> NJGJCIALGLF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public EGAFEDLEKOI ELOANNHCMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9642A0", Offset = "0x9634A0", VA = "0x1809642A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private FIIPNJENADE<DGPBGNLNFJH, GameObject> AHMMGFDCNMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7630A50", Offset = "0x762FC50", VA = "0x187630A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int LAPAGDONNJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7630920", Offset = "0x762FB20", VA = "0x187630920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7630970", Offset = "0x762FB70", VA = "0x187630970", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7630EA0", Offset = "0x76300A0", VA = "0x187630EA0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7630BB0", Offset = "0x762FDB0", VA = "0x187630BB0")]
	[AsyncStateMachine(typeof(CHHBLNCDBOP))]
	private Task<GameObject> KCKPMPOPPLB(DGPBGNLNFJH DHMGACIKEFI, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7630CD0", Offset = "0x762FED0", VA = "0x187630CD0")]
	public Task<GameObject> LoadItemAsync(DHMKECHGJDG KFPICODFPEF, CancellationToken KPIINMODKFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7630F10", Offset = "0x7630110", VA = "0x187630F10")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class AEJBOJNCNKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public DHMKECHGJDG AAOIJCKHMDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture CJIFKNGELEJ;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x96FF10", Offset = "0x96F110", VA = "0x18096FF10")]
		public AEJBOJNCNKO(DHMKECHGJDG OEDOGOEHOEE, Texture GOADEEFLEJA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum MNPEHKGCFJK
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
	private class KAFGHNMHMKA : MNGGIKHPNHD<Texture2D>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct FANCGKJFCEP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public AsyncTaskMethodBuilder<Texture2D> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public KAFGHNMHMKA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x7630F50", Offset = "0x7630150", VA = "0x187630F50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7631740", Offset = "0x7630940", VA = "0x187631740", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly DHMKECHGJDG OEDOGOEHOEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture EFAGDBACPEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig BHNBEDGGJMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken KPIINMODKFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Texture2D AFDAFLNPHDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private GameObject DOEEDEKMCLH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override JBBNLHPJHLB<Texture2D> LCCFCMKKLEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7633DA0", Offset = "0x7632FA0", VA = "0x187633DA0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture2D> GANLIOAONNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x96A6B0", Offset = "0x9698B0", VA = "0x18096A6B0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7633E00", Offset = "0x7633000", VA = "0x187633E00")]
		public KAFGHNMHMKA(DHMKECHGJDG OEDOGOEHOEE, RenderTexture EFAGDBACPEN, ImposterRenderConfig BHNBEDGGJMB, CancellationToken KPIINMODKFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7633C80", Offset = "0x7632E80", VA = "0x187633C80")]
		[AsyncStateMachine(typeof(FANCGKJFCEP))]
		private Task<Texture2D> DHCPHDHJCDI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7633D70", Offset = "0x7632F70", VA = "0x187633D70", Slot = "10")]
		protected override void EDGCODLIKNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7633C00", Offset = "0x7632E00", VA = "0x187633C00")]
		private static void AIKDJONMILO(GameObject DOEEDEKMCLH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct ONKAKLECNJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private TaskAwaiter<Texture2D> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x76340B0", Offset = "0x76332B0", VA = "0x1876340B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9C8C70", Offset = "0x9C7E70", VA = "0x1809C8C70", Slot = "5")]
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
	[KPPBIEPJJJL(ADOEJJMOABO.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private MNPEHKGCFJK size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[Tooltip("Custom pixel size for rendered imposter")]
	[NNIBNKKKMAE("size", MNPEHKGCFJK.Custom)]
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
	private static int OOJHEFJNPPH;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture KDLDBJBKCIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private HICPMPENMIB<GameObject> HHIKAJMBLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private EMKGHLOECBM LOOCGAPDHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource IFEDHDENNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private CAFFOJNOKAH<Texture2D> NBJKLFBNNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private DHMKECHGJDG IECFBNMAJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture IMLBINHMPMP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int FNFLGJJBPGK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x76336C0", Offset = "0x76328C0", VA = "0x1876336C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7633710", Offset = "0x7632910", VA = "0x187633710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture FGEFPAKFOOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x76330B0", Offset = "0x76322B0", VA = "0x1876330B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x964EE0", Offset = "0x9640E0", VA = "0x180964EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private DHMKECHGJDG AAOIJCKHMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x961670", Offset = "0x960870", VA = "0x180961670")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7632DF0", Offset = "0x7631FF0", VA = "0x187632DF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool GIMHNHEPGBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1F86830", Offset = "0x1F85A30", VA = "0x181F86830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int AKIJHEKNAEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7632CB0", Offset = "0x7631EB0", VA = "0x187632CB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7632C90", Offset = "0x7631E90", VA = "0x187632C90")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7633290", Offset = "0x7632490", VA = "0x187633290")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7632F50", Offset = "0x7632150", VA = "0x187632F50")]
	private void LPFMLJNKBGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x76335E0", Offset = "0x76327E0", VA = "0x1876335E0")]
	public void Set(DHMKECHGJDG JIPGNGDFELO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x76335D0", Offset = "0x76327D0", VA = "0x1876335D0")]
	public void Set(Texture GOADEEFLEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7633590", Offset = "0x7632790", VA = "0x187633590")]
	public void Set(AEJBOJNCNKO OMFJNFBDJCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7632CA0", Offset = "0x7631EA0", VA = "0x187632CA0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7633390", Offset = "0x7632590", VA = "0x187633390")]
	public void SetInternal(DHMKECHGJDG JIPGNGDFELO, [Optional] Texture CFNMNNGCECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7633380", Offset = "0x7632580", VA = "0x187633380")]
	public void SetCustomSize(int CGKKIEDKNFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x96E8A0", Offset = "0x96DAA0", VA = "0x18096E8A0")]
	public void SetAntiAliasing(int HNNLKOIBIGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7632D40", Offset = "0x7631F40", VA = "0x187632D40")]
	[AsyncStateMachine(typeof(ONKAKLECNJA))]
	private void GNJDILKCEAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7632FD0", Offset = "0x76321D0", VA = "0x187632FD0")]
	private void NGPCBOGHNIG(Texture GOADEEFLEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7633640", Offset = "0x7632840", VA = "0x187633640")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, CGIHEKGKAHE
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private const float GEOINIBGIHK = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "4")]
	public void PrepareImposter(BICDGOCBKKB BNHLGDBCCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7632C50", Offset = "0x7631E50", VA = "0x187632C50")]
	public void SetReferencePoint(Vector3 CHBIEDJMOLB, Quaternion OAJCDGBGAPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7632A60", Offset = "0x7631C60", VA = "0x187632A60")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7632C30", Offset = "0x7631E30", VA = "0x187632C30")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1C7C8B0", Offset = "0x1C7BAB0", VA = "0x181C7C8B0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct OFLLGLNMEIM
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static OFLLGLNMEIM FMJNNBBIECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public float CHAFPICHDAG;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x27C06A0", Offset = "0x27BF8A0", VA = "0x1827C06A0")]
	public OFLLGLNMEIM(float ACEODJLGNJF)
	{
	}
}
namespace _AssemblyRegistry.RecRoom_Imposters_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7634BA0", Offset = "0x7633DA0", VA = "0x187634BA0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2493E30", Offset = "0x2493030", VA = "0x182493E30")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		[KPPBIEPJJJL(ADOEJJMOABO.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int GELAHLIPPAI = 2500;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private const int BHPDPEIFBGG = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly List<Material> LMJIFGKPAGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool CMJLIMBELAM;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7633920", Offset = "0x7632B20", VA = "0x187633920")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7633820", Offset = "0x7632A20", VA = "0x187633820")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7633B70", Offset = "0x7632D70", VA = "0x187633B70")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DHMKECHGJDG
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string PHFIAFCGFKE
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	OFLLGLNMEIM OFLLGLNMEIM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action PLBKGIBMBOD;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> PHECLJEMCDM(CancellationToken KPIINMODKFJ);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KHINHIECPGD(DHMKECHGJDG LDKNLBHIGFL);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EDPBEOONAEJ();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KLLNIMCFKGM();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool IBMFBEDKLBA(uint? OGNADHPEEJC, [Out] CAFFOJNOKAH<Texture2D> DBLCFLAPMKD);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class GEODNECENMB
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x76317B0", Offset = "0x76309B0", VA = "0x1876317B0")]
	public static bool IDILDLFNJPJ(DHMKECHGJDG POFNDNJKJAH, DHMKECHGJDG EBELOCFDGMP)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, CGIHEKGKAHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x762FDC0", Offset = "0x762EFC0", VA = "0x18762FDC0", Slot = "4")]
		public void PrepareImposter(BICDGOCBKKB BNHLGDBCCDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x962DF0", Offset = "0x961FF0", VA = "0x180962DF0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x962DF0", Offset = "0x961FF0", VA = "0x180962DF0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface CGIHEKGKAHE
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(BICDGOCBKKB BNHLGDBCCDH);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface OJIHFLNEOGP
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> PILLJMCAHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> LDEMPDOKPMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface EGAFEDLEKOI
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BBKADOJOMGO(params Type[] APBODBEJAPM);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject ECEPPPICADG(GameObject NMLMOMLHFNF, Transform JNGEIJHHFEP, bool IDBNGMJBHMJ = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T ECEPPPICADG<T>(T NMLMOMLHFNF, Transform JNGEIJHHFEP, bool IDBNGMJBHMJ = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T ECEPPPICADG<T>(GameObject NMLMOMLHFNF, Transform JNGEIJHHFEP, bool IDBNGMJBHMJ = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject ECEPPPICADG(GameObject NMLMOMLHFNF, Transform JNGEIJHHFEP, BICDGOCBKKB BNHLGDBCCDH, bool IDBNGMJBHMJ);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class HAJIJPGJPMB : IDisposable, EGAFEDLEKOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> OCEILBGLONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HashSet<Type> NJIBLNIOIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Transform OHGNBBMLMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<Component> GMCILEBCNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> BEPLOLECHEG;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7631FA0", Offset = "0x76311A0", VA = "0x187631FA0")]
	[LDKBBAENJDF.JPBGCAANJAC]
	public static void JHIKJAALCJE(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7632320", Offset = "0x7631520", VA = "0x187632320")]
	[UnityEngine.Scripting.Preserve]
	public HAJIJPGJPMB([KMMHIEIDBEA(null)] OJIHFLNEOGP EDLMABNGLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7631DA0", Offset = "0x7630FA0", VA = "0x187631DA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x76318A0", Offset = "0x7630AA0", VA = "0x1876318A0", Slot = "5")]
	public void BBKADOJOMGO(params Type[] APBODBEJAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7631F10", Offset = "0x7631110", VA = "0x187631F10", Slot = "6")]
	public GameObject ECEPPPICADG(GameObject NMLMOMLHFNF, Transform JNGEIJHHFEP, bool IDBNGMJBHMJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x34A3600", Offset = "0x34A2800", VA = "0x1834A3600", Slot = "7")]
	public T ECEPPPICADG<T>(T NMLMOMLHFNF, Transform JNGEIJHHFEP, bool IDBNGMJBHMJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x34A36F0", Offset = "0x34A28F0", VA = "0x1834A36F0", Slot = "8")]
	public T ECEPPPICADG<T>(GameObject NMLMOMLHFNF, Transform JNGEIJHHFEP, bool IDBNGMJBHMJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7631E80", Offset = "0x7631080", VA = "0x187631E80", Slot = "9")]
	public GameObject ECEPPPICADG(GameObject NMLMOMLHFNF, Transform JNGEIJHHFEP, BICDGOCBKKB BNHLGDBCCDH, bool IDBNGMJBHMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x34A3690", Offset = "0x34A2890", VA = "0x1834A3690", Slot = "10")]
	public T ECEPPPICADG<T>(GameObject NMLMOMLHFNF, Transform JNGEIJHHFEP, BICDGOCBKKB BNHLGDBCCDH, bool IDBNGMJBHMJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x34A3740", Offset = "0x34A2940", VA = "0x1834A3740")]
	private T ECEPPPICADG<T>(GameObject NMLMOMLHFNF, Transform JNGEIJHHFEP, BICDGOCBKKB BNHLGDBCCDH, bool IDBNGMJBHMJ, [Out] GameObject GFOFPKBMPJL) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x34A30A0", Offset = "0x34A22A0", VA = "0x1834A30A0")]
	private T AKFBEJOCDEO<T>(GameObject LNIONOAAAEO, BICDGOCBKKB BNHLGDBCCDH, bool IDBNGMJBHMJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x76320A0", Offset = "0x76312A0", VA = "0x1876320A0")]
	private void MIGNDNCFAMH(Component BNCELPABAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x76318F0", Offset = "0x7630AF0", VA = "0x1876318F0")]
	private void DGMLLGICADM(Component BNCELPABAGA, BICDGOCBKKB BNHLGDBCCDH, bool IDBNGMJBHMJ, bool NELMHJFMDNO, [Optional] Type LAMKFCHFMPP, [Optional] Type NHHCAJPDLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x76321B0", Offset = "0x76313B0", VA = "0x1876321B0")]
	private void MMKJIPHBCJK(GameObject LNIONOAAAEO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct BICDGOCBKKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Dictionary<Type, object> LBEDPBFNIKG;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x31FB600", Offset = "0x31FA800", VA = "0x1831FB600")]
	public BICDGOCBKKB GFIEJLHFJLN<T>(T KDJFIJOJGFA)
	{
		return default(BICDGOCBKKB);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x31FC510", Offset = "0x31FB710", VA = "0x1831FC510")]
	public T NKAAMPBENGI<T>(T OGPHJJMKHNA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x31FBD30", Offset = "0x31FAF30", VA = "0x1831FBD30")]
	public bool NHGJGBKEDKC<T>([Out] T KDJFIJOJGFA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct EOBELMPEBMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool GHNAAAPIBHE;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x27C0C30", Offset = "0x27BFE30", VA = "0x1827C0C30")]
	public EOBELMPEBMK(bool ODKKGJKCPNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct MBPEPGNOJLB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly bool NDECBGIIONO;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7633FF0", Offset = "0x76331F0", VA = "0x187633FF0")]
	public MBPEPGNOJLB(bool OKCOFGOPPFK)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x962DF0", Offset = "0x961FF0", VA = "0x180962DF0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, CGIHEKGKAHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x76348F0", Offset = "0x7633AF0", VA = "0x1876348F0", Slot = "4")]
		public void PrepareImposter(BICDGOCBKKB BNHLGDBCCDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x962DF0", Offset = "0x961FF0", VA = "0x180962DF0")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ImposterBoundsOverride : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private Bounds imposterBounds;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Bounds JEHJDMLOJHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x76328D0", Offset = "0x7631AD0", VA = "0x1876328D0")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7632890", Offset = "0x7631A90", VA = "0x187632890")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7632850", Offset = "0x7631A50", VA = "0x187632850")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7632760", Offset = "0x7631960", VA = "0x187632760")]
		private void LGPPELNCEBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x962DF0", Offset = "0x961FF0", VA = "0x180962DF0")]
		public ImposterBoundsOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CreateAssetMenu(fileName = "ImposterRenderConfig", menuName = "RecRoom/Imposters/Imposter Render Config")]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			[Range(0.1f, 10f)]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x7633FD0", Offset = "0x76331D0", VA = "0x187633FD0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7633FC0", Offset = "0x76331C0", VA = "0x187633FC0")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public float cameraOffsetMaxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Tooltip("Get initial camera position to capture the bounds of an imposter.")]
		public bool frameCameraToImposterBounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[NNIBNKKKMAE("frameCameraToImposterBounds", true)]
		public float heightCenterOffsetDivisor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[Tooltip("If the player is using FBA, modify the position of the camera.")]
		public Vector3 fullBodyPositionModifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Header("Auto Rotation")]
		public bool autoRotateYawImposter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[NNIBNKKKMAE("autoRotateYawImposter", true)]
		public float autoRotateDegreesPerSecond;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[HideInInspector]
		public bool useExplicitCameraComposition;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[HideInInspector]
		public Vector3 explicitCameraPositionOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[HideInInspector]
		public Quaternion explicitCameraRotationOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[HideInInspector]
		public float explicitCameraOrthographicSize;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7633780", Offset = "0x7632980", VA = "0x187633780")]
		public void MHFKPOLKNAL(Vector3 AMJLEEFMHCK, Quaternion FINENPOOIOK, float JPMBGFCNNBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x76337B0", Offset = "0x76329B0", VA = "0x1876337B0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class BMLHDFODBMF
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly Vector3 JFNDCJNDGBG;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static readonly List<URPLight> GCCMIOCCFPP;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static readonly List<Light> OCBDGMNNIGP;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Camera KKEGABLMPNF;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static readonly List<Renderer> CLANHNDCAHD;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static readonly List<ImposterBoundsOverride> MHOONAJPLGI;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static AmbientMode IHFMCMCEJHK;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static Color CFMJOHFHLHC;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static Color LDGPHGGBDNN;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static Color JHJJMFAECKL;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private static Cubemap LNLEHKGIAHH;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private static bool MCLKMNLGFEP;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> LOAEOHHIAAG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x762D800", Offset = "0x762CA00", VA = "0x18762D800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> IODNOKHJLIC
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x762D2C0", Offset = "0x762C4C0", VA = "0x18762D2C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera NJEIMBKFEJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x762E1F0", Offset = "0x762D3F0", VA = "0x18762E1F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x762EFF0", Offset = "0x762E1F0", VA = "0x18762EFF0")]
	public static void NBPGENLLCMB(Vector3 IDPHCIONAIA, Quaternion KBHHMLEIAFB, ImposterRenderConfig LOJLAIPLFCM, bool BFBFBFDABBL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x762E420", Offset = "0x762D620", VA = "0x18762E420")]
	private static void JCHEBEEEEBM(Vector3 IDPHCIONAIA, Quaternion KBHHMLEIAFB, URPLight DJIHDEHAIND, ImposterRenderConfig.LightConfig OJCPEPAJIND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x762E740", Offset = "0x762D940", VA = "0x18762E740")]
	public static void JPJENBNBOKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x762F360", Offset = "0x762E560", VA = "0x18762F360")]
	private static void POBPNOHAKHD(int KFMOIKPHCLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x762D650", Offset = "0x762C850", VA = "0x18762D650")]
	public static void EGBFBNLJHAK(ImposterRenderConfig LOJLAIPLFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x762F280", Offset = "0x762E480", VA = "0x18762F280")]
	public static void PHNIIHDHLKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x762D310", Offset = "0x762C510", VA = "0x18762D310")]
	public static void EDCMPBEMEGJ(GameObject DPEDNOFALJA, RenderTexture EFAGDBACPEN, ImposterRenderConfig LOJLAIPLFCM, OFLLGLNMEIM DAKIMNKPCIP, [Optional] Vector3? MPHKMBBHLLF, [Optional] Vector3? KLMBJKICOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x762DBC0", Offset = "0x762CDC0", VA = "0x18762DBC0")]
	private static void FNBNCMFHIPJ(GameObject DPEDNOFALJA, RenderTexture EFAGDBACPEN, ImposterRenderConfig LOJLAIPLFCM, OFLLGLNMEIM DAKIMNKPCIP, Vector3 MPHKMBBHLLF, Vector3 KLMBJKICOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x762E820", Offset = "0x762DA20", VA = "0x18762E820")]
	private static void LMLPMBIIFPN(GameObject DPEDNOFALJA, Vector3 BGDPGKJBAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x762D850", Offset = "0x762CA50", VA = "0x18762D850")]
	public static void FEFMGCAGPOP(Bounds BAEDHNPDIHB, ImposterRenderConfig LOJLAIPLFCM, [Out] Vector3 FLHLBCNDCIL, [Out] Quaternion JJFAEBCANGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x762EAE0", Offset = "0x762DCE0", VA = "0x18762EAE0")]
	private static void LPEDHDKPOLA(GameObject NMLMOMLHFNF, ImposterRenderConfig LOJLAIPLFCM, OFLLGLNMEIM DAKIMNKPCIP, [Out] Vector3 FLHLBCNDCIL, [Out] Quaternion JJFAEBCANGJ, [Out] float BNIELKGKCCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x762D1F0", Offset = "0x762C3F0", VA = "0x18762D1F0")]
	public static RenderTexture ALAPKCKLHDG(int KIGDGKLPLAM, int CONNODFECMD, RenderTextureFormat FLMAPKGOONP = RenderTextureFormat.ARGB32, string JOOPNBOHNBC = "[ImposterRendering]Preview")
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public struct OHNAOELGEEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public NAKKDJDPCNK KPGBHIEHFIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public GameObject AFEBKBHNIEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public RenderTexture FGEFPAKFOOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public ImposterRenderConfig JKFNBHHHGMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public OFLLGLNMEIM OFLLGLNMEIM;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7634040", Offset = "0x7633240", VA = "0x187634040")]
			public OHNAOELGEEO(NAKKDJDPCNK DKIHAOLPIJN, GameObject CKHDPEDAPKB, RenderTexture EFAGDBACPEN, ImposterRenderConfig BHNBEDGGJMB, OFLLGLNMEIM DAKIMNKPCIP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private static FIIPNJENADE<OHNAOELGEEO, RenderTexture> JCPOCCDAMFG;

		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private static readonly List<OHNAOELGEEO> CANKDJEKGOI;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int AEAAAOFPOJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x76303C0", Offset = "0x762F5C0", VA = "0x1876303C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x76304E0", Offset = "0x762F6E0", VA = "0x1876304E0")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject DPEDNOFALJA, RenderTexture EFAGDBACPEN, ImposterRenderConfig LOJLAIPLFCM, OFLLGLNMEIM DAKIMNKPCIP, CancellationToken KPIINMODKFJ, bool PJOLEMBGAFM = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x762FF10", Offset = "0x762F110", VA = "0x18762FF10", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7630450", Offset = "0x762F650", VA = "0x187630450", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7630120", Offset = "0x762F320", VA = "0x187630120")]
		private static Task<RenderTexture> CFMNHJJKKMG(OHNAOELGEEO GCNJKBANBOC, CancellationToken KPIINMODKFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x76308E0", Offset = "0x762FAE0", VA = "0x1876308E0")]
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
