using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.Audio;
using UnityEngine;
using UnityEngine.Audio;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class IJKDDNDFPGP
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x67FA8B0", Offset = "0x67F98B0", VA = "0x1867FA8B0")]
	public static void GBIKIMHHKBL(this AudioSource HHJCKGKCDJE, AudioRolloff IBNMNGEIPCO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class CMIHHFBFKIM
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x67FA810", Offset = "0x67F9810", VA = "0x1867FA810")]
	public static float IMMHJHBJCAI(float CFBJEBNGEEJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x67FA870", Offset = "0x67F9870", VA = "0x1867FA870")]
	public static float JBELJDKHLOD(float LPGBOLOKNOE)
	{
		return default(float);
	}
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class AudioRolloff
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float ROLL_OFF_SCALE = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public AudioRolloffMode rolloffMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public float minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public float maxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[Tooltip("Only used if the rolloffMode is custom, this is the red volumetric curve. Distance(x axis) in this curve is normalized.")]
		public AnimationCurve customCurve;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x67FA530", Offset = "0x67F9530", VA = "0x1867FA530")]
		public float POLHFAKIIHJ(float DLALHMLKGGJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x67FA7F0", Offset = "0x67F97F0", VA = "0x1867FA7F0")]
		public AudioRolloff()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface PKDCLLCKLIK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int KOFFIINMIIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, HGBNDFBPIAF> IBNNLBCOPHL();

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IList<(string, ALNANGBGNMK)> JIKGOMALJDK();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioMixerGroup GBCABGFBNCN(AMFPAFBOMPO FAJHEEIDPLC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AudioMixerGroup MAKNCINJKMH(ALNANGBGNMK NBDAJJNHLLJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	SFXAudioSource MDECFODKALF(RecRoomAudioClip KHAKAFNIKHB, Transform BCEHPPGPEPB, [Optional] AudioRolloff CJMGPNPGPKH, [Optional] Action<SFXAudioSource> BLCBADCENGA, [Optional] ALNANGBGNMK? FAJHEEIDPLC);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LMNAFLHMEDL(SFXAudioSource OEOLGCANFBD);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	SFXAudioSource FFIIBHMDLDE(RecRoomAudioClip[] JPFIIIKCJFK, bool DJPGLJNPPKB = false, float IMMLIEJHEOH = 1f, [Optional] Action<SFXAudioSource> BLCBADCENGA, [Optional] ALNANGBGNMK? FAJHEEIDPLC);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	SFXAudioSource FLHBBEDKPBE(RecRoomAudioClip[] JPFIIIKCJFK, Transform BCEHPPGPEPB, [Optional] AudioRolloff CJMGPNPGPKH, bool DJPGLJNPPKB = false, [Optional] Action<SFXAudioSource> BLCBADCENGA, [Optional] ALNANGBGNMK? FAJHEEIDPLC);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource LADGDPONDDC(RecRoomAudioClip MAGKNJGFCMC, Vector3 BJEINPMOICP, bool FPNNFFNLGKO, [Optional] AudioRolloff CJMGPNPGPKH, [Optional] Action<SFXAudioSource> BLCBADCENGA, [Optional] ALNANGBGNMK? FAJHEEIDPLC);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource BDJDGJHPNMJ(RecRoomAudioClip KHOLGJPCLAD, [Optional] Action<SFXAudioSource> BLCBADCENGA, [Optional] ALNANGBGNMK? FAJHEEIDPLC);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "10")]
	JMPIHICOHFM IEPBCGNGNLI(SFXAudioSource OEOLGCANFBD, float PECDJCPDFAH, float DACHNPNJPDB);
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class RecRoomAudioClip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public AudioClip audioClip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		[Header("Volume")]
		private bool configureVolumeInDecibel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private float volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Header("Pitch")]
		[Range(0f, 2f)]
		public float pitchVariation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[Range(-1f, 1f)]
		public float pitchShift;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[Header("Other")]
		public TextAsset subtitles;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float LinearVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x67FAC30", Offset = "0x67F9C30", VA = "0x1867FAC30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x67FAC80", Offset = "0x67F9C80", VA = "0x1867FAC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x67FABE0", Offset = "0x67F9BE0", VA = "0x1867FABE0")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x67FABF0", Offset = "0x67F9BF0", VA = "0x1867FABF0")]
		public RecRoomAudioClip(AudioClip KHOLGJPCLAD)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CreateAssetMenu(menuName = "RecRoom/Config/Rec Room Audio Clip Pool Config", fileName = "RecRoomAudioClipPoolConfig")]
	public class RecRoomAudioClipPoolConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		private RecRoomAudioClip[] audioClips;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public RecRoomAudioClip[] AudioClips
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x67FAB10", Offset = "0x67F9B10", VA = "0x1867FAB10")]
		public bool NBMPGCJPKIM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8D0B80", Offset = "0x8CFB80", VA = "0x1808D0B80")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class SFXAudioSource : MonoBehaviour, JDOMIFMNLFH.GMMEIFIFMGC
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public struct KJNELAMNCLK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public float? DOOPPNJGPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public float? COINIFDNPNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public Vector3 PDDAFFCJCDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Transform MFBFIHLAOEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public AudioRolloff OGDFEDOLHMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public float ACMJBBKLPBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public float OBBGMOCKIFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public AMFPAFBOMPO? LJILLKDBOJM;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public float IDFPPFLOPML
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x67FA970", Offset = "0x67F9970", VA = "0x1867FA970")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public AMFPAFBOMPO JMMPNBIGEGC
			{
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x67FA9F0", Offset = "0x67F99F0", VA = "0x1867FA9F0")]
				get
				{
					return default(AMFPAFBOMPO);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private struct ALNBHJCDOFM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public KJNELAMNCLK playParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AudioClip clip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x67F9F10", Offset = "0x67F8F10", VA = "0x1867F9F10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x67FA4D0", Offset = "0x67F94D0", VA = "0x1867FA4D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class OBIMJCGAEHO : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private MBMMHILCGCA <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
			[DebuggerHidden]
			public OBIMJCGAEHO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x67FAA40", Offset = "0x67F9A40", VA = "0x1867FAA40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x67FAAC0", Offset = "0x67F9AC0", VA = "0x1867FAAC0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public bool Is3DSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private Action<SFXAudioSource> LCAMEPNDAFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private PGGFJFHOMCP PHPGHOCMCCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		[AIILLFBIOKD(CKKEEFADMDD.Self, false, false, false)]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private IMFFKMNFHIF NEENGLMKMOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private PKDCLLCKLIK OLCJCAMJKCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private float MMDPLOOIGMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private float HDAFCNDIMPB;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const string KJBECOIIIBP = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Transform MFBFIHLAOEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x868820", Offset = "0x867820", VA = "0x180868820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x868800", Offset = "0x867800", VA = "0x180868800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int LOHMHFGOEDH
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x67FC2C0", Offset = "0x67FB2C0", VA = "0x1867FC2C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool BOMJOEKDDEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x67FC3A0", Offset = "0x67FB3A0", VA = "0x1867FC3A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool LFNOEDIGBOC
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x67FC380", Offset = "0x67FB380", VA = "0x1867FC380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float DOOPPNJGPKM
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x67FC3C0", Offset = "0x67FB3C0", VA = "0x1867FC3C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float BJIBKPBIHLE
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x67FC2E0", Offset = "0x67FB2E0", VA = "0x1867FC2E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x67FAD10", Offset = "0x67F9D10", VA = "0x1867FAD10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x67FAE40", Offset = "0x67F9E40", VA = "0x1867FAE40")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x67FC200", Offset = "0x67FB200", VA = "0x1867FC200")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x67FC1E0", Offset = "0x67FB1E0", VA = "0x1867FC1E0")]
		public void UpdateVolume(float BNACJCJGHHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x67FBFD0", Offset = "0x67FAFD0", VA = "0x1867FBFD0")]
		public void UpdatePitch(float ACPFNGEIJIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x67FBF30", Offset = "0x67FAF30", VA = "0x1867FBF30")]
		public void UpdateDopplerLevel(float GJDLOACDNJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x67FC140", Offset = "0x67FB140", VA = "0x1867FC140")]
		public void UpdateSpatialBlend(float JDLGALFNINB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x67FBE60", Offset = "0x67FAE60", VA = "0x1867FBE60")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x67FB820", Offset = "0x67FA820", VA = "0x1867FB820")]
		public void Play(AudioClip KHOLGJPCLAD, float BNACJCJGHHI, Vector3 BJEINPMOICP, float DCAFBGKKCBO, float NEBNIHJNFHL, AudioRolloff IBNMNGEIPCO, [Optional] Action<SFXAudioSource> CIOOPKEHANJ, [Optional] ALNANGBGNMK? FAJHEEIDPLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x67FB6D0", Offset = "0x67FA6D0", VA = "0x1867FB6D0")]
		[AsyncStateMachine(typeof(ALNBHJCDOFM))]
		public Task PlayAsync(AudioClip KHOLGJPCLAD, KJNELAMNCLK LKIKCLIIBNG, CancellationToken DADBOHKBJNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x67FAFD0", Offset = "0x67F9FD0", VA = "0x1867FAFD0")]
		private void PCHLPIIHEGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x67FADE0", Offset = "0x67F9DE0", VA = "0x1867FADE0")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x67FBE90", Offset = "0x67FAE90", VA = "0x1867FBE90")]
		public void Scrub(float IKBJFKDEOPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x67FBEF0", Offset = "0x67FAEF0", VA = "0x1867FBEF0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x67FBD90", Offset = "0x67FAD90", VA = "0x1867FBD90")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x67FBD10", Offset = "0x67FAD10", VA = "0x1867FBD10")]
		[IteratorStateMachine(typeof(OBIMJCGAEHO))]
		public IEnumerator<MBMMHILCGCA> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x67FAE30", Offset = "0x67F9E30", VA = "0x1867FAE30", Slot = "4")]
		private void MOJEPLKLGJI(bool GMNLPDCHGDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x866340", Offset = "0x865340", VA = "0x180866340")]
		public SFXAudioSource()
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
