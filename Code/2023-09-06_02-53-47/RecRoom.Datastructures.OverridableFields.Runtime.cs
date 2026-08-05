using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using Google.Protobuf;
using JetBrains.Annotations;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface PNBPGJCJOLE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MOIEDDFLCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object BENHJEBBPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AINOOGLLMBC<T> : PNBPGJCJOLE
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T INKIKMDHKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FEACOLBDIFP<T> : AINOOGLLMBC<T>, PNBPGJCJOLE
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool MOIEDDFLCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T INKIKMDHKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KBFJFELNHHA<T> : FEACOLBDIFP<T>, AINOOGLLMBC<T>, PNBPGJCJOLE
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool HLMJGDKJGJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Utils.OverridableFields
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct OverridableVector3 : AINOOGLLMBC<Vector3>, PNBPGJCJOLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private Vector3 value;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x486B080", Offset = "0x4869680", VA = "0x18486B080", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x6FC5740", Offset = "0x6FC3D40", VA = "0x186FC5740", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x6FC5790", Offset = "0x6FC3D90", VA = "0x186FC5790", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5720", Offset = "0x6FC3D20", VA = "0x186FC5720")]
		public OverridableVector3(Vector3 MOLEJFDINLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5680", Offset = "0x6FC3C80", VA = "0x186FC5680", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5650", Offset = "0x6FC3C50", VA = "0x186FC5650")]
		public static OverridableVector3 LBBGOAOJJNO(Vector3 PMMAPONKBCK)
		{
			return default(OverridableVector3);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableInt : AINOOGLLMBC<int>, PNBPGJCJOLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private int value;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x486B080", Offset = "0x4869680", VA = "0x18486B080", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6FC5590", Offset = "0x6FC3B90", VA = "0x186FC5590", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x1E79A20", Offset = "0x1E78020", VA = "0x181E79A20", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6FC54F0", Offset = "0x6FC3AF0", VA = "0x186FC54F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct OverridableString : AINOOGLLMBC<string>, PNBPGJCJOLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private string value;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x486B080", Offset = "0x4869680", VA = "0x18486B080", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x3A94B60", Offset = "0x3A93160", VA = "0x183A94B60", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x3A94B60", Offset = "0x3A93160", VA = "0x183A94B60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6FC55E0", Offset = "0x6FC3BE0", VA = "0x186FC55E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : FEACOLBDIFP<InnerType>, AINOOGLLMBC<InnerType>, PNBPGJCJOLE where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract bool MOIEDDFLCLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public abstract InnerType INKIKMDHKDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public object BENHJEBBPOK
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x224C780", Offset = "0x224AD80", VA = "0x18224C780", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x276E580", Offset = "0x276CB80", VA = "0x18276E580")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x276E640", Offset = "0x276CC40", VA = "0x18276E640")]
		public MutableOverridableBase(bool DNMLPEGBNIN, [NotNull] InnerType MOLEJFDINLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x276DBE0", Offset = "0x276C1E0", VA = "0x18276DBE0", Slot = "15")]
		public void GAFLCLCJFAN(AINOOGLLMBC<InnerType> ANDLCCCCAHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x276E270", Offset = "0x276C870", VA = "0x18276E270", Slot = "16")]
		public void MOAONFLIEIF(AINOOGLLMBC<InnerType> FKJGPCABBJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x276DEE0", Offset = "0x276C4E0", VA = "0x18276DEE0", Slot = "17")]
		public virtual void KINBCCGCMFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType FONOOMCMIJC();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void EPLCFPDNADP(ProtobufType IGCHMMLFPHK);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void DPGMBLJMMHO(byte[] CAIKNDOECOL);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public abstract class SerializedMutableOverridableBase<T, InnerType, ProtobufType> : MutableOverridableBase<T, InnerType, ProtobufType> where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private InnerType value;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public override bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xCB1500", Offset = "0xCAFB00", VA = "0x180CB1500", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x979740", Offset = "0x977D40", VA = "0x180979740", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7EEED0", Offset = "0x7ED4D0", VA = "0x1807EEED0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x10281C0", Offset = "0x10267C0", VA = "0x1810281C0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xE24370", Offset = "0xE22970", VA = "0x180E24370")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2494160", Offset = "0x2492760", VA = "0x182494160")]
		public SerializedMutableOverridableBase(bool DNMLPEGBNIN, InnerType MOLEJFDINLH)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, JNJJBNEOMAO>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5490", Offset = "0x6FC3A90", VA = "0x186FC5490")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5420", Offset = "0x6FC3A20", VA = "0x186FC5420")]
		public MutableOverridableObscuredInt(bool DNMLPEGBNIN, ObscuredInt MOLEJFDINLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5350", Offset = "0x6FC3950", VA = "0x186FC5350", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC50D0", Offset = "0x6FC36D0", VA = "0x186FC50D0", Slot = "20")]
		public override void DPGMBLJMMHO(byte[] CAIKNDOECOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5180", Offset = "0x6FC3780", VA = "0x186FC5180", Slot = "19")]
		public override void EPLCFPDNADP(JNJJBNEOMAO IGCHMMLFPHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5250", Offset = "0x6FC3850", VA = "0x186FC5250", Slot = "18")]
		public override JNJJBNEOMAO FONOOMCMIJC()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, EFINAPKBNME>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5000", Offset = "0x6FC3600", VA = "0x186FC5000")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6FC5060", Offset = "0x6FC3660", VA = "0x186FC5060")]
		public MutableOverridableObscuredFloat(bool DNMLPEGBNIN, ObscuredFloat MOLEJFDINLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4F30", Offset = "0x6FC3530", VA = "0x186FC4F30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4C90", Offset = "0x6FC3290", VA = "0x186FC4C90", Slot = "20")]
		public override void DPGMBLJMMHO(byte[] CAIKNDOECOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4D40", Offset = "0x6FC3340", VA = "0x186FC4D40", Slot = "19")]
		public override void EPLCFPDNADP(EFINAPKBNME IGCHMMLFPHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4E20", Offset = "0x6FC3420", VA = "0x186FC4E20", Slot = "18")]
		public override EFINAPKBNME FONOOMCMIJC()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, BIDFHDEAAEB>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3F80", Offset = "0x6FC2580", VA = "0x186FC3F80")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4C20", Offset = "0x6FC3220", VA = "0x186FC4C20")]
		public MutableOverridableObscuredBool(bool DNMLPEGBNIN, ObscuredBool MOLEJFDINLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4B50", Offset = "0x6FC3150", VA = "0x186FC4B50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4870", Offset = "0x6FC2E70", VA = "0x186FC4870", Slot = "20")]
		public override void DPGMBLJMMHO(byte[] CAIKNDOECOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4920", Offset = "0x6FC2F20", VA = "0x186FC4920", Slot = "19")]
		public override void EPLCFPDNADP(BIDFHDEAAEB IGCHMMLFPHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4A00", Offset = "0x6FC3000", VA = "0x186FC4A00", Slot = "18")]
		public override BIDFHDEAAEB FONOOMCMIJC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4B00", Offset = "0x6FC3100", VA = "0x186FC4B00", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, KBFJFELNHHA<ObscuredBool>, FEACOLBDIFP<ObscuredBool>, AINOOGLLMBC<ObscuredBool>, PNBPGJCJOLE
	{
		[Cpp2IlInjected.Token(Token = "0x17000015")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x9B4500", Offset = "0x9B2B00", VA = "0x1809B4500", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x9B5480", Offset = "0x9B3A80", VA = "0x1809B5480", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3F80", Offset = "0x6FC2580", VA = "0x186FC3F80")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3F00", Offset = "0x6FC2500", VA = "0x186FC3F00")]
		public void GAFLCLCJFAN(MutableOverridableDefaultableObscuredBool FKJGPCABBJN)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, JNJJBNEOMAO> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x4FAD440", Offset = "0x4FABA40", VA = "0x184FAD440", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4FAD520", Offset = "0x4FABB20", VA = "0x184FAD520", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2288970", Offset = "0x2286F70", VA = "0x182288970")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4FAD410", Offset = "0x4FABA10", VA = "0x184FAD410")]
		public SerializedMutableOverridableObscuredEnum(bool DNMLPEGBNIN, TObsEnum MOLEJFDINLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4FAD2E0", Offset = "0x4FAB8E0", VA = "0x184FAD2E0", Slot = "18")]
		public sealed override JNJJBNEOMAO FONOOMCMIJC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4FAD1C0", Offset = "0x4FAB7C0", VA = "0x184FAD1C0", Slot = "19")]
		public sealed override void EPLCFPDNADP(JNJJBNEOMAO IGCHMMLFPHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4FAD110", Offset = "0x4FAB710", VA = "0x184FAD110", Slot = "20")]
		public sealed override void DPGMBLJMMHO(byte[] CAIKNDOECOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4FAD3B0", Offset = "0x4FAB9B0", VA = "0x184FAD3B0", Slot = "17")]
		public sealed override void KINBCCGCMFP()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, ODHNAHODPMM>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6FC47A0", Offset = "0x6FC2DA0", VA = "0x186FC47A0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6FC47E0", Offset = "0x6FC2DE0", VA = "0x186FC47E0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6FC46B0", Offset = "0x6FC2CB0", VA = "0x186FC46B0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4740", Offset = "0x6FC2D40", VA = "0x186FC4740")]
		public MutableOverridableListObscuredString(bool DNMLPEGBNIN, List<ObscuredString> MOLEJFDINLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6FC4610", Offset = "0x6FC2C10", VA = "0x186FC4610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6FC45A0", Offset = "0x6FC2BA0", VA = "0x186FC45A0", Slot = "17")]
		public override void KINBCCGCMFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6FC3FF0", Offset = "0x6FC25F0", VA = "0x186FC3FF0", Slot = "20")]
		public override void DPGMBLJMMHO(byte[] CAIKNDOECOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6FC40A0", Offset = "0x6FC26A0", VA = "0x186FC40A0", Slot = "19")]
		public override void EPLCFPDNADP(ODHNAHODPMM IGCHMMLFPHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6FC43C0", Offset = "0x6FC29C0", VA = "0x186FC43C0", Slot = "18")]
		public override ODHNAHODPMM FONOOMCMIJC()
		{
			return null;
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
