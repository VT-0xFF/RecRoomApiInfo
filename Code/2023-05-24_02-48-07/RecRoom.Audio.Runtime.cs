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
public enum ODCKBGLODPN
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum PKMKGIBLOHC
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
public enum HGGFCMAFMII
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
public struct PJKCCGIJPLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly HGGFCMAFMII JOLJIBDENEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string DENAEPOLFFH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F886F0", Offset = "0x6F872F0", VA = "0x186F886F0")]
	public PJKCCGIJPLF(HGGFCMAFMII JDLACFAPCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F88790", Offset = "0x6F87390", VA = "0x186F88790")]
	public PJKCCGIJPLF(HGGFCMAFMII JDLACFAPCLJ, string KDJHMLJEHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F88660", Offset = "0x6F87260", VA = "0x186F88660")]
	public bool DAKLFOOFGHF(HGGFCMAFMII JMLGJPGCMDA, string BODDPNLIPPP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum IFNANPDELKA
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Linear
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface AOHHOPAIALB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int NOKAPGCFJCO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, MKEHFBIKBJP> JLDKCOPAKPI();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IList<(string, PJKCCGIJPLF)> ANABAKDGMDM();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioMixerGroup HEADAFHJHJF(HGGFCMAFMII JDLACFAPCLJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AudioMixerGroup LGNLALNFNDF(PJKCCGIJPLF NDCIHNFEBAM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JGEMKFCDDML(AudioSource MKELFMFCLAL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	SFXAudioSource EHPBLKOIGMD(RecRoomAudioClip ILAGKMAKNHE, Transform KOELHPAEPAK, [Optional] AudioRolloff HKOJMOGINHK, [Optional] Action<SFXAudioSource> FELPNCCDHPA, [Optional] PJKCCGIJPLF? JDLACFAPCLJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MPLFLKEOMIC(SFXAudioSource MKELFMFCLAL);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	SFXAudioSource LMJIFBOHHAC(RecRoomAudioClip[] KFGNNMOMCOE, bool JINBPBCANEJ = false, float AIJILACHINM = 1f, [Optional] Action<SFXAudioSource> FELPNCCDHPA, [Optional] PJKCCGIJPLF? JDLACFAPCLJ);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource GLBFAPGMGGE(RecRoomAudioClip[] KFGNNMOMCOE, Transform KOELHPAEPAK, [Optional] AudioRolloff HKOJMOGINHK, bool JINBPBCANEJ = false, [Optional] Action<SFXAudioSource> FELPNCCDHPA, [Optional] PJKCCGIJPLF? JDLACFAPCLJ);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource MDFNHKMIFGB(RecRoomAudioClip KPDLGJFCNBM, Vector3 DBMHGAAIFOA, bool NOPPEOIOCFK, [Optional] AudioRolloff HKOJMOGINHK, [Optional] Action<SFXAudioSource> FELPNCCDHPA, [Optional] PJKCCGIJPLF? JDLACFAPCLJ);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	SFXAudioSource EAIOANGODCL(RecRoomAudioClip OPJHALPBNLF, [Optional] Action<SFXAudioSource> FELPNCCDHPA, [Optional] PJKCCGIJPLF? JDLACFAPCLJ);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class KLAHOBPNIEP
{
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public const float CIDNAMFEDOD = -80f;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public const float KKLMKDOCFOG = 0f;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6F87F10", Offset = "0x6F86B10", VA = "0x186F87F10")]
	public static float PACBJJKDBMG(float IOBJKFEMDLH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6F87EE0", Offset = "0x6F86AE0", VA = "0x186F87EE0")]
	public static float BAKJIGNOPIC(float EGIMJPGEAHM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public KLAHOBPNIEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class DPFIBIONGMK
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6F87D50", Offset = "0x6F86950", VA = "0x186F87D50")]
	public static void JGEMKFCDDML(this AudioSource NFCKPBMOANM, AudioRolloff CGLMNNOMPLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6F87E10", Offset = "0x6F86A10", VA = "0x186F87E10")]
	public static void KADJPBNJNMO(this AudioSource MKELFMFCLAL, RecRoomAudioClip NFPEOKNAGGO)
	{
	}
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AudioRolloff
	{
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const float ROLL_OFF_SCALE = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AudioRolloffMode rolloffMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float maxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[Tooltip("Only used if the rolloffMode is custom, this is the red volumetric curve. Distance(x axis) in this curve is normalized.")]
		public AnimationCurve customCurve;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6F87980", Offset = "0x6F86580", VA = "0x186F87980")]
		public float LFCMGJKFPLD(float CIKEFFDMPDJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6F87C40", Offset = "0x6F86840", VA = "0x186F87C40")]
		public AudioRolloff()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RecRoomAudioClip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AudioClip audioClip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		[Header("Volume")]
		private bool configureVolumeInDecibel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private float volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Header("Pitch")]
		[Range(0f, 0f)]
		public float pitchVariation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[Range(-1f, 1f)]
		public float pitchShift;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[Header("Other")]
		public TextAsset subtitles;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float LinearVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6F88B10", Offset = "0x6F87710", VA = "0x186F88B10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6F88BA0", Offset = "0x6F877A0", VA = "0x186F88BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float DecibelVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6F88AB0", Offset = "0x6F876B0", VA = "0x186F88AB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6F88B50", Offset = "0x6F87750", VA = "0x186F88B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6F88A40", Offset = "0x6F87640", VA = "0x186F88A40")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6F88A60", Offset = "0x6F87660", VA = "0x186F88A60")]
		public RecRoomAudioClip(AudioClip OPJHALPBNLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6F888D0", Offset = "0x6F874D0", VA = "0x186F888D0")]
		public bool EKPJNDPEBEC(RecRoomAudioClip MDHJAFNLPON)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CreateAssetMenu]
	public class RecRoomAudioClipPoolConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		private RecRoomAudioClip[] audioClips;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RecRoomAudioClip[] AudioClips
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F88800", Offset = "0x6F87400", VA = "0x186F88800")]
		public bool KEKBDEEFCBL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x12EAAC0", Offset = "0x12E96C0", VA = "0x1812EAAC0")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class SFXAudioSource : MonoBehaviour, GJIONPIMLDK.BDAHNLFJBMH
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct LGMDDBBBEDO
		{
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private const float FHJGILPKNOC = 0.5f;

			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private const float OEMDKDFCJLC = 1f;

			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private const HGGFCMAFMII GDMGPJHDIIG = HGGFCMAFMII.Sfx;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public float? FJHCGCLEEAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public float? OLOPNOAKKAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public Vector3 LBFMGBCNOAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public Transform LGPMHCELGGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public AudioRolloff MGECMBCOABF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public float DIPCNEJGIDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public float JDHLJGMDALA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public HGGFCMAFMII? JOLJIBDENEB;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public float EILKOBDNDFH
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x6F87F60", Offset = "0x6F86B60", VA = "0x186F87F60")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public HGGFCMAFMII OIMKBKADBNI
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x6F87FF0", Offset = "0x6F86BF0", VA = "0x186F87FF0")]
				get
				{
					return default(HGGFCMAFMII);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class MDFBANANKAK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public AudioClip clip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public LGMDDBBBEDO playParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private float <pitch>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
			public MDFBANANKAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6F88040", Offset = "0x6F86C40", VA = "0x186F88040", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class BICMFMGEFKF : IEnumerator<EDDHBDCNFKM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private EDDHBDCNFKM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private EDDHBDCNFKM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x83B7A0", Offset = "0x83A3A0", VA = "0x18083B7A0")]
			[DebuggerHidden]
			public BICMFMGEFKF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7F0010", Offset = "0x7EEC10", VA = "0x1807F0010", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6F87C60", Offset = "0x6F86860", VA = "0x186F87C60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6F87D10", Offset = "0x6F86910", VA = "0x186F87D10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public bool Is3DSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private Action<SFXAudioSource> LJKEMKANALO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private OHBOPDKGAGN IKGCHFDDFGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		[HHGPBADECGL(MGNIEFNKKLA.Self, false, false, false)]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private LALKFIOPJMN AGCDOFBDLGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private AOHHOPAIALB OBGKDOHCIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private float LMDFBMDIPIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private float HBBBBCHJPDI;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const string HPOBNFOGPMA = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Transform LGPMHCELGGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x84D780", Offset = "0x84C380", VA = "0x18084D780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8A4420", Offset = "0x8A3020", VA = "0x1808A4420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int KPKBLOLKHPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6F8A300", Offset = "0x6F88F00", VA = "0x186F8A300")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool IKDJMMOCELA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6F8A3F0", Offset = "0x6F88FF0", VA = "0x186F8A3F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool AOBEAPDPHKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6F8A3D0", Offset = "0x6F88FD0", VA = "0x186F8A3D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float FJHCGCLEEAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6F8A410", Offset = "0x6F89010", VA = "0x186F8A410")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float GADFGGEDKNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6F8A320", Offset = "0x6F88F20", VA = "0x186F8A320")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6F88C20", Offset = "0x6F87820", VA = "0x186F88C20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6F894F0", Offset = "0x6F880F0", VA = "0x186F894F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6F8A1D0", Offset = "0x6F88DD0", VA = "0x186F8A1D0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6F8A1B0", Offset = "0x6F88DB0", VA = "0x186F8A1B0")]
		public void UpdateVolume(float ODJGEOBKCKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6F89F90", Offset = "0x6F88B90", VA = "0x186F89F90")]
		public void UpdatePitch(float JFEKDICHAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6F89EF0", Offset = "0x6F88AF0", VA = "0x186F89EF0")]
		public void UpdateDopplerLevel(float MLPEBFENEOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6F8A110", Offset = "0x6F88D10", VA = "0x186F8A110")]
		public void UpdateSpatialBlend(float DAEBCLHPPMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6F89E10", Offset = "0x6F88A10", VA = "0x186F89E10")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6F89850", Offset = "0x6F88450", VA = "0x186F89850")]
		public void Play(AudioClip OPJHALPBNLF, float ODJGEOBKCKA, Vector3 DBMHGAAIFOA, float EEAJJLEOFAI, float PKIODELHKJB, AudioRolloff CGLMNNOMPLD, [Optional] Action<SFXAudioSource> LAANJNHOJHC, [Optional] PJKCCGIJPLF? JDLACFAPCLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6F89690", Offset = "0x6F88290", VA = "0x186F89690")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(MDFBANANKAK))]
		public Task PlayAsync(AudioClip OPJHALPBNLF, LGMDDBBBEDO JOJENOJEBME, CancellationToken GFFFFCALMCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F88D40", Offset = "0x6F87940", VA = "0x186F88D40")]
		private void OANMFOFEADF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6F88CF0", Offset = "0x6F878F0", VA = "0x186F88CF0")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6F89E40", Offset = "0x6F88A40", VA = "0x186F89E40")]
		public void Scrub(float EAJNKPCKLBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6F89EB0", Offset = "0x6F88AB0", VA = "0x186F89EB0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6F89D20", Offset = "0x6F88920", VA = "0x186F89D20")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6F89CB0", Offset = "0x6F888B0", VA = "0x186F89CB0")]
		[IteratorStateMachine(typeof(BICMFMGEFKF))]
		public IEnumerator<EDDHBDCNFKM> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6F88CE0", Offset = "0x6F878E0", VA = "0x186F88CE0", Slot = "4")]
		private void GDGAJDDBHOA(bool JACPCCGHLHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6F8A2A0", Offset = "0x6F88EA0", VA = "0x186F8A2A0")]
		public SFXAudioSource()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class PFBBJKPLBFC
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
	public PFBBJKPLBFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1DDAC60", Offset = "0x1DD9860", VA = "0x181DDAC60")]
	public static string NIMNBIGPMKB(byte[] DCFEDNINKHD, byte[] LFMKEJPAGIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
