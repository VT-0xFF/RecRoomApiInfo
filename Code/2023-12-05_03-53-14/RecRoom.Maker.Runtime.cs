using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using Photon.Pun;
using RecRoom.Core.Creation;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class ConfigurableSubpiece : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private Collider[] colliders;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private Renderer[] hoverRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public MKFPLDNDPJC<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MINOLIAPBDK PBCOLOEPHHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x773AC0", Offset = "0x772EC0", VA = "0x180773AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x77A180", Offset = "0x779580", VA = "0x18077A180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Collider[] AECLLEOMFNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Renderer[] LGHOOGKONLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x775A80", Offset = "0x774E80", VA = "0x180775A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<MINOLIAPBDK> PMJFDKEBNBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x5E3B0F0", Offset = "0x5E3A4F0", VA = "0x185E3B0F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x5E3B1A0", Offset = "0x5E3A5A0", VA = "0x185E3B1A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5E3AD80", Offset = "0x5E3A180", VA = "0x185E3AD80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5E3AE30", Offset = "0x5E3A230", VA = "0x185E3AE30")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5E3AEA0", Offset = "0x5E3A2A0", VA = "0x185E3AEA0")]
		public void SetIConfigurable(MINOLIAPBDK CKNMFGPICAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5E3AD90", Offset = "0x5E3A190", VA = "0x185E3AD90")]
		public void ChangeCollidersAndRenderers(Collider[] NAJJLGPMICL, Renderer[] EBLHMJNNKEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5E3AFD0", Offset = "0x5E3A3D0", VA = "0x185E3AFD0")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E3AE80", Offset = "0x5E3A280", VA = "0x185E3AE80")]
		public void RunConfigurationSpecialActions(MINOLIAPBDK ODKKLBLNDBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E3B060", Offset = "0x5E3A460", VA = "0x185E3B060")]
		public ConfigurableSubpiece()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LKKMDJNNJHG
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BNICNDKGHBI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddIsAnimated(object NOEAHPPKHNC);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveIsAnimated(object NOEAHPPKHNC);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FBEGNLGDKFB
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RegisterConfigurablePiece(ConfigurableSubpiece CHLDDNCEHAJ);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void UnregisterConfigurablePiece(ConfigurableSubpiece CHLDDNCEHAJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ConfigurableSubpiece GetConfigurableSubpiece(Collider BIJOEIBHHKE);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BILLCHBIAPL
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GameObject JPJEGCALIHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Guid DHABNILJAEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string MFBMONNEDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string CGILMJHCICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Vector3 OMGILIJPGJA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Vector3 ELIFPOBKNDD
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Quaternion KNDKENIBGOE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Quaternion NPADIBBPDLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float DNBOKGBADOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float ADHBEPCMAGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 IBDNNELKDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 FLLMAGEEAPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool OOKLGHMCJNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "20")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	MINOLIAPBDK PBCOLOEPHHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	HDDDEKMGPOM KMGCNCICGEF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action IJFBFNPGMHK;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool CanUpdateDeformation(Vector3 ICFPFIDPILG, float KBNDLLIGNJE, float BPFDPBLALKH);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void UpdateDeformation(Vector3 ICFPFIDPILG, float KBNDLLIGNJE, bool PPJCAHNDCII, Space FMJNCFCCJFK);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool CanBeRaycasted(Collider BIJOEIBHHKE);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FODIFGEDIHE
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool DALJMPLIJIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool HCBOFGMHEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Vector3 DMCIJAAKFDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Vector3 LAMGOINGGBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool CHJFKNAPNBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool HGHDICGHCAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool PKEIPHHNJEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool FNPBNGCGKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool MIBJAJFHEEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool DBJAKKDFHFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "27")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnCreatedBySpawning();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnSelected();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnTranslationStart();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OnRotationStart();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OnScaleStart();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OnDeformStart();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnTranslated();

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnRotated();

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnScaled();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OnDeformed(Vector3 IOFDIOPJENL);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OnTranslationFinished();

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OnRotationFinished();

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void OnScaleFinished();

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void OnDeformationFinished();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OnDeselected();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void OnHoverStart(KKJFJLIMGLO DILMPJMFJDD, Collider ALIDPDAOCOK);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OnHovering(KKJFJLIMGLO DILMPJMFJDD, Collider ALIDPDAOCOK);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OnHoverFinished(KKJFJLIMGLO DILMPJMFJDD);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void Translate(Vector3 BNKOGEMEBLD);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void Rotate(Quaternion PJONJDBLJGO);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool Scale(float KMHALLDFFIA);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task DeleteAsync();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JNGMMOKAKEL
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FDPNMJLFAID([In] Vector3 EIGNGOOKPHI, [In] Vector3 MOLHDBHIKBL, Vector3 FKDEIBAGLCG, Vector3 CEGMEAOIEDE);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface LALMLMMBFJK
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool LALPPCINPFK
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	EFHEONJKJKH EOKHJGIGIOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MasterDespawn();

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task RequestMasterDespawn();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MEMPEANEHPF
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool HOBLAHMDEPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	MCNBDHLCDNE MLOEDMKDJEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<bool> EPFKJEDPMEP;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LocalPlayerTakeAuthority();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void TransferOwnership(int FABKHEFNLNL);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GBNAOCOJGEF GetCulprit(PCFOHALKECO DGFBFGIDMHC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GANMOEDILHE
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	IEnumerable<JCEDPLKFADL.PBDCCGDINIK> HGKBKNAHFLP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddNavMeshSupportRestriction(JCEDPLKFADL.PBDCCGDINIK IHONLEBIAPL);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveNavMeshSupportRestriction(JCEDPLKFADL.PBDCCGDINIK IHONLEBIAPL);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OPNBEBMHDDF
{
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PPHICEOLDCI
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool BLIOCCFIEMM
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool JADLFLCPIIP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface JJFPJJJFADM
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int KNBBJACICCP
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderSelection(GHFIMCBPLGK? CDCGDKCJIKG);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderOutline(JOCLECOGMBP? IFAKMPHDBCJ);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RenderWorldFadeMask();

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Bounds GetWorldBounds();

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PCFOHALKECO CanBeSelected();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MONMHIHACIG
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool LJBJNJICJHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CostInfo KCLOLKPPMCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool PMILMKMBDKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool GHHEODFJPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool BFCIBLPPMNN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool ABFHMHGBDIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool JECKKDHJLHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	IEnumerable<Collider> JMFEOBCKMFO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	DMJGEJAMMMC? KOPOHMDLOOP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool MMPIBJHLNMI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool MHHKGOMJCIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface JIIKNHAIPAE
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PCFOHALKECO CanPerformUndoRedoOnObject();

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GetTransformationDataForUndoRedo([Out] Vector3 JCADPOBEOPO, [Out] Quaternion KCLDFAAPKAB, [Out] float IJNDHAAJICE, [Out] Vector3 HPELMFGPFPJ);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetTransformationDataForUndoRedo(Vector3? JCADPOBEOPO, Quaternion? KCLDFAAPKAB, float? IJNDHAAJICE, Vector3? HPELMFGPFPJ);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OOEGLPFEKCG
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	object EGJOHNIEKKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Type HNDBJCGNDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	Guid IHOGJPHNGOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MINOLIAPBDK
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	IReadOnlyList<MIOLHKMEILC> IDEGFJNGPBL
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string CGILMJHCICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string LCLNPJACLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool ECMFHABJICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<string> BANCLAFLHJA;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<MINOLIAPBDK> CAPGFIFOFOG;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<FOACLMNMAOB, LINLONPPKCA> JGHNHOGPHNB;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action PPJLKFCFFNN;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void Reset();

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void ConfigurableWillShow();

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ConfigurableWillHide();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LBEPBFEFJMN
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool CLKJNKLHFFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct JCEDPLKFADL
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate EEOEJEPIGHC PBDCCGDINIK();

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IEnumerable<PBDCCGDINIK> FPGIECKHFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<PBDCCGDINIK> FILIHOPBIKF;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public IEnumerable<PBDCCGDINIK> DIDGCELIPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5E3C340", Offset = "0x5E3B740", VA = "0x185E3C340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C0D0", Offset = "0x5E3B4D0", VA = "0x185E3C0D0")]
	public void BKKEPFPDOJH(PBDCCGDINIK IHONLEBIAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5E3C2E0", Offset = "0x5E3B6E0", VA = "0x185E3C2E0")]
	public bool HBMDGHADMGB(PBDCCGDINIK IHONLEBIAPL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum EEOEJEPIGHC
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NotSupported,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Supported
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class HDDDEKMGPOM
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const int EDHIHJOAAGP = -1;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const long PJHJNABDOOD = -1L;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ODBIGLGKPCE<Guid, ObscuredLong, ObscuredInt, ObscuredBool> PMDAODMCOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private PNDFGEHIOAO<ObscuredBool, ObscuredInt, ObscuredInt> CMJCFJLKGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private MonoBehaviourPun EPJCHCPCJIA;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Guid LPPBCCGFKGL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5E3BCE0", Offset = "0x5E3B0E0", VA = "0x185E3BCE0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public long KDDBPFGLCIB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5E3B620", Offset = "0x5E3AA20", VA = "0x185E3B620")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int MAPOGMAIFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5E3BB10", Offset = "0x5E3AF10", VA = "0x185E3BB10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool GKFGNKJJFBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5E3B250", Offset = "0x5E3A650", VA = "0x185E3B250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool NAKEIFLPKKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5E3B6C0", Offset = "0x5E3AAC0", VA = "0x185E3B6C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int NNNGNDAJBEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5E3BBA0", Offset = "0x5E3AFA0", VA = "0x185E3BBA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int IDDFBIJEJEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5E3B3F0", Offset = "0x5E3A7F0", VA = "0x185E3B3F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool HCPFLMOECIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5E3BD50", Offset = "0x5E3B150", VA = "0x185E3BD50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BD90", Offset = "0x5E3B190", VA = "0x185E3BD90")]
	public HDDDEKMGPOM(MonoBehaviourPun OCBMIGOKMJB, string MEJKLCMADIB, Guid JCFIODOCMIJ, long LFKPIJCMOPL, int HPELJJLLKNN, bool NFJNHPNHKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B480", Offset = "0x5E3A880", VA = "0x185E3B480")]
	public void GCNICLFECAC(GBNAOCOJGEF KEEIIJLDJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B2E0", Offset = "0x5E3A6E0", VA = "0x185E3B2E0")]
	public void FPOLIGCFCDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B750", Offset = "0x5E3AB50", VA = "0x185E3B750")]
	public void GJHPIDDJMKM(Guid LODJEBKHAIK, long LFKPIJCMOPL, int HPELJJLLKNN, bool NFJNHPNHKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B910", Offset = "0x5E3AD10", VA = "0x185E3B910")]
	public void GJHPIDDJMKM(HDDDEKMGPOM LFMLAKDHEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BAA0", Offset = "0x5E3AEA0", VA = "0x185E3BAA0")]
	public void GKDENJKPCCB(PGCHABGJLDO KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3BC30", Offset = "0x5E3B030", VA = "0x185E3BC30")]
	public void OIOOLHGIBCH(PGCHABGJLDO KKOACPFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3B9E0", Offset = "0x5E3ADE0", VA = "0x185E3B9E0")]
	public static PGCHABGJLDO GJMHAGBFGGB(Guid JCFIODOCMIJ, long LFKPIJCMOPL, int BOBOOCFANOD, bool NFJNHPNHKFE)
	{
		return null;
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
