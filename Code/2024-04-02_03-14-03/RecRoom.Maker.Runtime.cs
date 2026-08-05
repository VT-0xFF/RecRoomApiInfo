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
using Unity.Profiling;
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
		public BFGGANIGMAO<ConfigurableSubpiece, Collider[], Collider[]> OnCollidersChanged;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public DBPGDIPGEAO AFNFPNLKKKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7B5340", Offset = "0x7B3F40", VA = "0x1807B5340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7B5350", Offset = "0x7B3F50", VA = "0x1807B5350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Collider[] IIJCIBCFMFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Renderer[] DKKDBFPDBKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7B2920", Offset = "0x7B1520", VA = "0x1807B2920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<DBPGDIPGEAO> BJLLPLKFGJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x61640B0", Offset = "0x6162CB0", VA = "0x1861640B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6164160", Offset = "0x6162D60", VA = "0x186164160")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6163D40", Offset = "0x6162940", VA = "0x186163D40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6163DF0", Offset = "0x61629F0", VA = "0x186163DF0")]
		public void Destroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6163E60", Offset = "0x6162A60", VA = "0x186163E60")]
		public void SetIConfigurable(DBPGDIPGEAO AGCNIKPHHKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6163D50", Offset = "0x6162950", VA = "0x186163D50")]
		public void ChangeCollidersAndRenderers(Collider[] AHFAFGNKJAK, Renderer[] DALOOKDGHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6163F90", Offset = "0x6162B90", VA = "0x186163F90")]
		public void ValidateCollidersAndRenderers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6163E40", Offset = "0x6162A40", VA = "0x186163E40")]
		public void RunConfigurationSpecialActions(DBPGDIPGEAO IOEFOEHFODK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6164020", Offset = "0x6162C20", VA = "0x186164020")]
		public ConfigurableSubpiece()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NLAIOPKINHH
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool AAOABOKFMNK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddIsAnimated(object DGPOLLDAHJK);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveIsAnimated(object DGPOLLDAHJK);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BBIDHKBPCCK
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void RegisterConfigurablePiece(ConfigurableSubpiece MKJHDGINKMP);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void UnregisterConfigurablePiece(ConfigurableSubpiece MKJHDGINKMP);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ConfigurableSubpiece GetConfigurableSubpiece(Collider HBMPMDPKNON);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EMCEBNOPPLA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	GameObject JPLPKEPDGKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Guid FKJIBAFALJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string PEJAGGFBEOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string IEJOFNINHLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Vector3 NENGMJCMOOD
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Vector3 ADMMPHIELJP
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Quaternion AOJJKMGFBBF
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Quaternion IMKNHDNNIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "13")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float FKFDJAKAOIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float HALBHNAEBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Vector3 AKCHMFALJKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Vector3 GMMLOGHNEOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "19")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool MIFLAEGHBPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "20")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	DBPGDIPGEAO AFNFPNLKKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	FGCJPJNJOCF ICNHJKMFDHN
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action MMFKHCCHAJF;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "23")]
	bool CanUpdateDeformation(Vector3 FABPKFNGDIB, float JKBBAJJHKKF, float ADLFLMKIJHN);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void UpdateDeformation(Vector3 FABPKFNGDIB, float JKBBAJJHKKF, bool JOABOFMFKKJ, Space GOABIBLCKPH);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	bool CanBeRaycasted(Collider HBMPMDPKNON);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BLEOIAGNJHC
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool ANADIMAJLHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool IGFAGILCNHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Vector3 CMKNNCBBJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	Vector3 FPFELAHENOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool IPAOFABMHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MLBEFMHOKFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool ILDKDFFMDLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool EFKIFEPFKLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool GAEPNAEPCBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool GKEGBDJNCFA
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
	void OnDeformed(Vector3 LLJHDIHPPPL);

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
	void OnHoverStart(BKLNJCPBHNE MILMKHJOBAL, Collider HFKFCPOBAOJ);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OnHovering(BKLNJCPBHNE MILMKHJOBAL, Collider HFKFCPOBAOJ);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void OnHoverFinished(BKLNJCPBHNE MILMKHJOBAL);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void Translate(Vector3 IOIAANFDDEB);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void Rotate(Quaternion JOCOMEIHOPO);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool Scale(float MHDIGCPHMNA);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "31")]
	Task DeleteAsync();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IJIKGAHDIPC
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GHFGPKMOLCN([In] Vector3 OABPANPBJFB, [In] Vector3 MPBHICGGLEH, Vector3 IEDPPEKLFMD, Vector3 JJMOIFJMOBF);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface ABHAELNHCHM
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool HJEMEPFJAOA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	IDAAIAHGGDM MFFDLLGOAIO
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
public interface KPDNEKJEKLK
{
	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool EINBKFKJIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	OENIFGBAIBC CJOBBENJEAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<bool> NIIGENHOFJP;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LocalPlayerTakeAuthority();

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void TransferOwnership(int JKACOBBNCAA);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "6")]
	PGGNJPENPEC GetCulprit(NIDJCDKEMDF FCBKBJLBDII);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ADCBJCMJAHG
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	IEnumerable<LLFGGOFJKFJ.HPJHCHNLCCA> HPJBKAPIGGK
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AddNavMeshSupportRestriction(LLFGGOFJKFJ.HPJHCHNLCCA JJJJLFGHFEN);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RemoveNavMeshSupportRestriction(LLFGGOFJKFJ.HPJHCHNLCCA JJJJLFGHFEN);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BHKFFGANGMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool JGBEKMBEPIK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool GHFILMDHPOE
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GLLEEGKICNC
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	int ICMBDCLDHBA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RenderSelection(JCCMDILNKCC? PLMIJHEPEDP);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void RenderOutline(HMGGEEBIJCM? PGMGJAILCNF);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void RenderWorldFadeMask();

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Bounds GetWorldBounds();

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NIDJCDKEMDF CanBeSelected();
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GFKLLIEFBJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool BPGMPLHOKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	CostInfo HIKGOKILFAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool DHJBMHKGOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool CAMIBAEINNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool AGKCCMCIEGN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool FFFLFCHOKJN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool OPENOMKJLLN
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	IEnumerable<Collider> ONBLPMLJJPH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	GLJJLCFKOMO? OMEPNMABNDE
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool JEKKOPCOBIP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool CKGMCNHEGNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface AAAMGLNGCHI
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NIDJCDKEMDF CanPerformUndoRedoOnObject();

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GetTransformationDataForUndoRedo([Out] Vector3 GMKEEAOHFFK, [Out] Quaternion MJCNDCDLGEO, [Out] float LEGOINJIMOE, [Out] Vector3 PIIIADJMIDP);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void SetTransformationDataForUndoRedo(Vector3? GMKEEAOHFFK, Quaternion? MJCNDCDLGEO, float? LEGOINJIMOE, Vector3? PIIIADJMIDP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KLMHJNABCKP
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	object DPHAGHHJKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	Type IKMBAFGDMCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	Guid HBJJLLLKJEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DBPGDIPGEAO
{
	[Cpp2IlInjected.Token(Token = "0x17000034")]
	IReadOnlyList<GFAGCDBCKBA> FOLKMNEDNOK
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	string IEJOFNINHLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	string IHMAIFJBDOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool CBDMCJHEAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<string> OFNNKHAAJJC;

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<DBPGDIPGEAO> CBGOHKJPENC;

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action<FKOAJOMIMHD, AFFOEHFIEPL> CAJHDJKMOBP;

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action JCPGMCAAJJI;

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
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface ODHNGAHONAJ
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool DJHCBDHCPME
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct LLFGGOFJKFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate DDAPMPOFJCI HPJHCHNLCCA();

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IEnumerable<HPJHCHNLCCA> LHJKHCFLEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private List<HPJHCHNLCCA> JJHCHNGOBBF;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public IEnumerable<HPJHCHNLCCA> DMIMOLPJAEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x61652B0", Offset = "0x6163EB0", VA = "0x1861652B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x61650A0", Offset = "0x6163CA0", VA = "0x1861650A0")]
	public void BGJHDHHBMPP(HPJHCHNLCCA JJJJLFGHFEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6165250", Offset = "0x6163E50", VA = "0x186165250")]
	public bool DMBJGENFJDP(HPJHCHNLCCA JJJJLFGHFEN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum DDAPMPOFJCI
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NotSupported,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	Supported
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FGCJPJNJOCF
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const int DGPNOKMGFFN = -1;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const long JLCBJLEJJAM = -1L;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private MHEHNNEEEDO<Guid, ObscuredLong, ObscuredInt, ObscuredBool> AIDNDHGLCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private DENEHLILBPP<ObscuredBool, ObscuredInt, ObscuredInt> JEKLAACGBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private MonoBehaviourPun EGGCNLDBDMK;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Guid GFMOKBCNCOA
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6164210", Offset = "0x6162E10", VA = "0x186164210")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public long GAJGGJFEGDN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6164C30", Offset = "0x6163830", VA = "0x186164C30")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int PHAGNKJAIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6164CD0", Offset = "0x61638D0", VA = "0x186164CD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool BAJDOFJPMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6164AA0", Offset = "0x61636A0", VA = "0x186164AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool OFIIHOFCDAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6164280", Offset = "0x6162E80", VA = "0x186164280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int CCCGMOOPHCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6164800", Offset = "0x6163400", VA = "0x186164800")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int FFDOIJBLKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6164660", Offset = "0x6163260", VA = "0x186164660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool DJKHCKFFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6164B30", Offset = "0x6163730", VA = "0x186164B30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6164D60", Offset = "0x6163960", VA = "0x186164D60")]
	public FGCJPJNJOCF(MonoBehaviourPun PPIBMJAAJHM, string AIKAMFADJJE, Guid OPBBOOFKAFI, long KECPCPOOANK, int OPNNHKLAFFB, bool FAMLLBJJMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6164890", Offset = "0x6163490", VA = "0x186164890")]
	public void MGOOBHHHNLJ(PGGNJPENPEC BCMPIBCHBFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x61646F0", Offset = "0x61632F0", VA = "0x1861646F0")]
	public void KLAJPDDLPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6164310", Offset = "0x6162F10", VA = "0x186164310")]
	public void HAJAGMDCLHL(Guid BHNPGOEMKPE, long KECPCPOOANK, int OPNNHKLAFFB, bool FAMLLBJJMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x61644E0", Offset = "0x61630E0", VA = "0x1861644E0")]
	public void HAJAGMDCLHL(FGCJPJNJOCF NAFFCAIMPLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6164A30", Offset = "0x6163630", VA = "0x186164A30")]
	public void NAHKHEAAMPB(PNNNDDCHIMP KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x61645B0", Offset = "0x61631B0", VA = "0x1861645B0")]
	public void HODJFGHJJAO(PNNNDDCHIMP KOMCCCIEHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6164B70", Offset = "0x6163770", VA = "0x186164B70")]
	public static PNNNDDCHIMP PDDEABMCOON(Guid OPBBOOFKAFI, long KECPCPOOANK, int BAFDOHMICLF, bool FAMLLBJJMJB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class PNHKMIEGHBG
{
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public static CGCFLAHJDPK<Vector3> ODIGJNNOJFK;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static CGCFLAHJDPK<Vector3> NLBLPJLLOOB;

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6167650", Offset = "0x6166250", VA = "0x186167650", Slot = "4")]
	protected virtual void HHDKECKNFOH(Vector3 MEMEEBHMOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x61675C0", Offset = "0x61661C0", VA = "0x1861675C0", Slot = "5")]
	protected virtual void AKGBPHNDOAJ(Vector3 MEMEEBHMOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
	protected PNHKMIEGHBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
internal class LNGBKMKCNHA : PNHKMIEGHBG
{
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x61653F0", Offset = "0x6163FF0", VA = "0x1861653F0")]
	public void NCFHEMJNBFI(Vector3 GMKEEAOHFFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x61653C0", Offset = "0x6163FC0", VA = "0x1861653C0")]
	public void CALFIBLKGLF(Vector3 GMKEEAOHFFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6165420", Offset = "0x6164020", VA = "0x186165420")]
	public LNGBKMKCNHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NBNDCJODEKK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private static ProfilerMarker PPAJACIMHAO;

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private static ProfilerMarker CFBPIJOAIOC;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private static readonly string GBNBEINLDGK;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static readonly string CJEKBHLCMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly int[] DGJAMKOLBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private readonly int[] LEPEOBMOJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private GameObject IBINIALNLMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private MeshCollider BENGMCOGJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private GameObject KBAOPCBBHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private MeshFilter CAEEJMIEHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Mesh IMBJJKFLPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private Mesh AHBKEFFEJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Collider[] DLLDJDAANNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private List<Collider> INDPNMMOBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private Vector3[] GOIPMDCPAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private Vector3 KJLLHJJPCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Vector3 NGJPMBCPFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Quaternion DFNPALHFLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private Vector3[] GFGEBMKMBLF;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private Mesh PPHJOICINBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B50", Offset = "0x7B1750", VA = "0x1807B2B50")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x61657E0", Offset = "0x61643E0", VA = "0x1861657E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private Mesh CEDFFAFGNCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B1640", Offset = "0x7B0240", VA = "0x1807B1640")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6166150", Offset = "0x6164D50", VA = "0x186166150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private int LNMBFHFDMDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6166FB0", Offset = "0x6165BB0", VA = "0x186166FB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public IEnumerable<Collider> MLPCHLECNKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6165A40", Offset = "0x6164640", VA = "0x186165A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x61670F0", Offset = "0x6165CF0", VA = "0x1861670F0")]
	public NBNDCJODEKK(Material AIEJDMDIMJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6165980", Offset = "0x6164580", VA = "0x186165980", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6165AF0", Offset = "0x61646F0", VA = "0x186165AF0")]
	public void HAOCDHLNIDO(Vector2 ENCKNJCCMDB, Vector2 IHGBGNBEGOB, Camera JGPDJKGMCDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6166590", Offset = "0x6165190", VA = "0x186166590")]
	public void NFDKHGGGMDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6165B90", Offset = "0x6164790", VA = "0x186165B90")]
	private IEnumerable<Collider> HKNEFMPICFO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6165830", Offset = "0x6164430", VA = "0x186165830")]
	private void CAPODGKHPKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x61665D0", Offset = "0x61651D0", VA = "0x1861665D0")]
	private void OFMFFALJFAL(Material PKJODJFPANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x61661A0", Offset = "0x6164DA0", VA = "0x1861661A0")]
	private void IMKEGDBAKHP(Vector2 ENCKNJCCMDB, Vector2 IHGBGNBEGOB, Camera JGPDJKGMCDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6166730", Offset = "0x6165330", VA = "0x186166730")]
	private void PNCOEIPNICI(Vector2 ENCKNJCCMDB, Vector2 IHGBGNBEGOB, Camera JGPDJKGMCDE, Vector2 IJBKIBFIFHJ, Vector2 OKIJMMHNOKJ, Vector3 FOFONHCDCAO, Vector3 DBPDADJCEMK, Vector3 MCCGALEGHLH, Vector3 LPIFLBGNIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6165770", Offset = "0x6164370", VA = "0x186165770")]
	private void AKHJFFFDNLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6165470", Offset = "0x6164070", VA = "0x186165470")]
	private void AKFHJKGCHCC(Vector3 GEDAPKJIIDK, Vector3 FOFONHCDCAO, Vector3 DBPDADJCEMK, Vector3 MCCGALEGHLH, Vector3 LPIFLBGNIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6165A50", Offset = "0x6164650", VA = "0x186165A50")]
	private void GABIIFJJHKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BNPBNOAEGOO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private HAOAONENPGJ<T> OJPMGPKOODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private OPGNIKPOIIK<T> CKCKOIMKHKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private List<T> EEPOCNOECDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private List<T> HLDDKALLIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private List<T> MGNPPIFPKDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private List<T> EJAOJJCHFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private List<T> NGEBCJDFECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private List<T> OGDCGPADDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private JLGHPGEIFDK HJPHBEGAFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private LNGBKMKCNHA CFLLDHDHCPA;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x47FC470", Offset = "0x47FB070", VA = "0x1847FC470")]
	public BNPBNOAEGOO(HAOAONENPGJ<T> OJPMGPKOODM, OPGNIKPOIIK<T> CKCKOIMKHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x47FA3B0", Offset = "0x47F8FB0", VA = "0x1847FA3B0")]
	public void GJNOBIEAGDP(JLGHPGEIFDK HJPHBEGAFCD = JLGHPGEIFDK.Add)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x47FA510", Offset = "0x47F9110", VA = "0x1847FA510")]
	public void MGOAJAIPMDN(IEnumerable<Collider> LOEPLNOIFLL, Vector3 IKPCKGFHECP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x47FA480", Offset = "0x47F9080", VA = "0x1847FA480")]
	public bool JHCCGLOBJDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x47FA360", Offset = "0x47F8F60", VA = "0x1847FA360")]
	[CompilerGenerated]
	private bool CAJKGFIBMPE(T KLNIMOGOBLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x47FA2D0", Offset = "0x47F8ED0", VA = "0x1847FA2D0")]
	[CompilerGenerated]
	private bool BGLDCMKENNE(T KLNIMOGOBLK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum JLGHPGEIFDK
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Add,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	Remove
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
