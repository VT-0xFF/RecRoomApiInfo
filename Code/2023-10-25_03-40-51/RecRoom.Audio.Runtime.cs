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
public enum JJLINMLOIGM
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum PDCPFJMNNHH
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	LowPitch = 0,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	None = 1,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	HighPitch = 2,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	RadioLowPitch = 10,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Radio = 11,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	RadioHighPitch = 12,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	LoudspeakerLowPitch = 20,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Loudspeaker = 21,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	LoudspeakerHighPitch = 22
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum BNKPCELHCLE
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Voice,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Sfx,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Music,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Ambience
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct CFFFLLFFEGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly BNKPCELHCLE JHKJABGKPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string BEHOPBLAKJB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5B94D00", Offset = "0x5B93B00", VA = "0x185B94D00")]
	public CFFFLLFFEGA(BNKPCELHCLE EFDHEOHHEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5B94DA0", Offset = "0x5B93BA0", VA = "0x185B94DA0")]
	public CFFFLLFFEGA(BNKPCELHCLE EFDHEOHHEJB, string MDDNKMNCGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5B94C70", Offset = "0x5B93A70", VA = "0x185B94C70")]
	public bool BINOAPOHADF(BNKPCELHCLE LKABJMAAFDI, string LANAHCBHGKC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum EEKBBNLPPKH
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Linear
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class AACEPIOOLMA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5B948D0", Offset = "0x5B936D0", VA = "0x185B948D0")]
	public static void PCJGAJACKKM(this AudioSource HHKMFANOOIO, AudioRolloff IIHKGINNKHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class KHDGFJPGJBA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5B94E50", Offset = "0x5B93C50", VA = "0x185B94E50")]
	public static float ACHENAHJLBE(float FIADGJMANPP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5B94E10", Offset = "0x5B93C10", VA = "0x185B94E10")]
	public static float ABOBFJEOBPB(float OFJFCCBABFL)
	{
		return default(float);
	}
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class AudioRolloff
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private const float ROLL_OFF_SCALE = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AudioRolloffMode rolloffMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public float maxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Tooltip("Only used if the rolloffMode is custom, this is the red volumetric curve. Distance(x axis) in this curve is normalized.")]
		public AnimationCurve customCurve;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5B94990", Offset = "0x5B93790", VA = "0x185B94990")]
		public float BOLMJLJFNOP(float IPBAIIHEFMJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5B94C50", Offset = "0x5B93A50", VA = "0x185B94C50")]
		public AudioRolloff()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface INCGBAKKJJF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int IABCCFOPMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, NMLCLDAMLCH> CDEGJCCGIHN();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IList<(string, CFFFLLFFEGA)> ICLFBMKBNNF();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioMixerGroup JOMNDPNKKLA(BNKPCELHCLE EFDHEOHHEJB);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AudioMixerGroup MLILLFCDHFB(CFFFLLFFEGA KHILAJLNCGB);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	SFXAudioSource ICKOBBDJOFA(RecRoomAudioClip LABCMGPEAHA, Transform CINMLPIBEEK, [Optional] AudioRolloff AHCCIJCALNM, [Optional] Action<SFXAudioSource> ODAEGLCIPCH, [Optional] CFFFLLFFEGA? EFDHEOHHEJB);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EHOLEKLOLON(SFXAudioSource BEJEKHHHPIH);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	SFXAudioSource BHPFAEGDGDO(RecRoomAudioClip[] DJKAODIFINI, bool CPJALOAGKPK = false, float OLOFOMLBOFI = 1f, [Optional] Action<SFXAudioSource> ODAEGLCIPCH, [Optional] CFFFLLFFEGA? EFDHEOHHEJB);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	SFXAudioSource CDCGBFMFBDA(RecRoomAudioClip[] DJKAODIFINI, Transform CINMLPIBEEK, [Optional] AudioRolloff AHCCIJCALNM, bool CPJALOAGKPK = false, [Optional] Action<SFXAudioSource> ODAEGLCIPCH, [Optional] CFFFLLFFEGA? EFDHEOHHEJB);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource DEEOFGLCAFC(RecRoomAudioClip HNNMDLMBCEP, Vector3 HPBLMHBHKBO, bool CGEABOINIED, [Optional] AudioRolloff AHCCIJCALNM, [Optional] Action<SFXAudioSource> ODAEGLCIPCH, [Optional] CFFFLLFFEGA? EFDHEOHHEJB);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource LFCOGEGHHAO(RecRoomAudioClip EHJDDABDKBL, [Optional] Action<SFXAudioSource> ODAEGLCIPCH, [Optional] CFFFLLFFEGA? EFDHEOHHEJB);
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RecRoomAudioClip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AudioClip audioClip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		[Header("Volume")]
		private bool configureVolumeInDecibel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private float volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[Range(0f, 2f)]
		[Header("Pitch")]
		public float pitchVariation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Range(-1f, 1f)]
		public float pitchShift;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Header("Other")]
		public TextAsset subtitles;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float LinearVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5B95790", Offset = "0x5B94590", VA = "0x185B95790")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x5B957E0", Offset = "0x5B945E0", VA = "0x185B957E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5B95740", Offset = "0x5B94540", VA = "0x185B95740")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5B95750", Offset = "0x5B94550", VA = "0x185B95750")]
		public RecRoomAudioClip(AudioClip EHJDDABDKBL)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CreateAssetMenu(menuName = "RecRoom/Config/Rec Room Audio Clip Pool Config", fileName = "RecRoomAudioClipPoolConfig")]
	public class RecRoomAudioClipPoolConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		private RecRoomAudioClip[] audioClips;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public RecRoomAudioClip[] AudioClips
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5B95670", Offset = "0x5B94470", VA = "0x185B95670")]
		public bool MBMMLKMIICE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x84A0A0", Offset = "0x848EA0", VA = "0x18084A0A0")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class SFXAudioSource : MonoBehaviour, CHFFMHOOGFH.MAIHFOICHBD
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct OIPGBGGCNIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public float? JAHHFOGMOGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public float? HGEHLCBGLEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Vector3 AGIKFLCLFIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Transform CCALADGGCIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public AudioRolloff NLMBINILPFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public float LMIOIOLEGJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public float HEHEPKDNGAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public BNKPCELHCLE? JHKJABGKPGI;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public float LOHLBHMEGCD
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x5B955F0", Offset = "0x5B943F0", VA = "0x185B955F0")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public BNKPCELHCLE OCBODJFFCMO
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x5B955A0", Offset = "0x5B943A0", VA = "0x185B955A0")]
				get
				{
					return default(BNKPCELHCLE);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct KPPHNJMGJHB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public OIPGBGGCNIB playParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public AudioClip clip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5B94EB0", Offset = "0x5B93CB0", VA = "0x185B94EB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5B95470", Offset = "0x5B94270", VA = "0x185B95470", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class MHLBHKJAPEK : IEnumerator<JHKLHFOKPOC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private JHKLHFOKPOC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private JHKLHFOKPOC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x761980", Offset = "0x760780", VA = "0x180761980")]
			[DebuggerHidden]
			public MHLBHKJAPEK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x75D2D0", Offset = "0x75C0D0", VA = "0x18075D2D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x5B954D0", Offset = "0x5B942D0", VA = "0x185B954D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x5B95550", Offset = "0x5B94350", VA = "0x185B95550", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public bool Is3DSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private Action<SFXAudioSource> LOKKOGJPKHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private GJDHHHJOJJP AFBEKNCILFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[DBHJNHHAHKH(PBHAFHEAPLG.Self, false, false, false)]
		[SerializeField]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private HHNMHMLGNNC IMFACDLBICH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private INCGBAKKJJF NDKCEOGOMEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private float MGJCNBKIAAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private float KAFGJJFEMKD;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const string NDEBHAEMDAK = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Transform CCALADGGCIG
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x763870", Offset = "0x762670", VA = "0x180763870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x763890", Offset = "0x762690", VA = "0x180763890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int GBFHPPEKJAA
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5B96E20", Offset = "0x5B95C20", VA = "0x185B96E20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool FFNPCNKKEAP
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x5B96F00", Offset = "0x5B95D00", VA = "0x185B96F00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool ODHEMFPFFCL
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5B96EE0", Offset = "0x5B95CE0", VA = "0x185B96EE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float JAHHFOGMOGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5B96F20", Offset = "0x5B95D20", VA = "0x185B96F20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float BJEBFNJNBHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5B96E40", Offset = "0x5B95C40", VA = "0x185B96E40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5B95870", Offset = "0x5B94670", VA = "0x185B95870")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5B959A0", Offset = "0x5B947A0", VA = "0x185B959A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5B96D60", Offset = "0x5B95B60", VA = "0x185B96D60")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5B96D40", Offset = "0x5B95B40", VA = "0x185B96D40")]
		public void UpdateVolume(float ALNFJGDKCJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5B96B30", Offset = "0x5B95930", VA = "0x185B96B30")]
		public void UpdatePitch(float BBHNICGDLKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5B96A90", Offset = "0x5B95890", VA = "0x185B96A90")]
		public void UpdateDopplerLevel(float OAOGEHIDJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5B96CA0", Offset = "0x5B95AA0", VA = "0x185B96CA0")]
		public void UpdateSpatialBlend(float CBMHOFPEJFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5B969C0", Offset = "0x5B957C0", VA = "0x185B969C0")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5B96380", Offset = "0x5B95180", VA = "0x185B96380")]
		public void Play(AudioClip EHJDDABDKBL, float ALNFJGDKCJO, Vector3 HPBLMHBHKBO, float IGNLNOFJPMD, float HGHNJOOEDDF, AudioRolloff IIHKGINNKHE, [Optional] Action<SFXAudioSource> HNLDIOJBHJA, [Optional] CFFFLLFFEGA? EFDHEOHHEJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5B96230", Offset = "0x5B95030", VA = "0x185B96230")]
		[AsyncStateMachine(typeof(KPPHNJMGJHB))]
		public Task PlayAsync(AudioClip EHJDDABDKBL, OIPGBGGCNIB JFMBFMGIKEN, CancellationToken BCCDJHNACKO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5B95B30", Offset = "0x5B94930", VA = "0x185B95B30")]
		private void PBGIEOOEEAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5B95950", Offset = "0x5B94750", VA = "0x185B95950")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5B969F0", Offset = "0x5B957F0", VA = "0x185B969F0")]
		public void Scrub(float BGDOPOOMALL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5B96A50", Offset = "0x5B95850", VA = "0x185B96A50")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5B968F0", Offset = "0x5B956F0", VA = "0x185B968F0")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5B96870", Offset = "0x5B95670", VA = "0x185B96870")]
		[IteratorStateMachine(typeof(MHLBHKJAPEK))]
		public IEnumerator<JHKLHFOKPOC> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5B95940", Offset = "0x5B94740", VA = "0x185B95940", Slot = "4")]
		private void LHHOAEGAGDB(bool MMCBDJIKKAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x75F1C0", Offset = "0x75DFC0", VA = "0x18075F1C0")]
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
