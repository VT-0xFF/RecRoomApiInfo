using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
using RecRoom.Core.DataStructures;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x74CAB10", Offset = "0x74C9110", VA = "0x1874CAB10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x97C6E0", Offset = "0x97ACE0", VA = "0x18097C6E0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x97C720", Offset = "0x97AD20", VA = "0x18097C720")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EKEHNNDIDIK : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1E0FC40", Offset = "0x1E0E240", VA = "0x181E0FC40")]
	public EKEHNNDIDIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, GJNJIONJAFL, AKLCOKKIAMD, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9529B0", Offset = "0x950FB0", VA = "0x1809529B0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x952A00", Offset = "0x951000", VA = "0x180952A00", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB13490", Offset = "0xB11A90", VA = "0x180B13490", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash MGPEIJNPFNJ);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xA447A0", Offset = "0xA42DA0", VA = "0x180A447A0")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[ReadOnlyField]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[ReadOnlyField]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x74CBD90", Offset = "0x74CA390", VA = "0x1874CBD90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x74CBD50", Offset = "0x74CA350", VA = "0x1874CBD50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x74CBDD0", Offset = "0x74CA3D0", VA = "0x1874CBDD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x74CBF80", Offset = "0x74CA580", VA = "0x1874CBF80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x74CBEF0", Offset = "0x74CA4F0", VA = "0x1874CBEF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xD791D0", Offset = "0xD777D0", VA = "0x180D791D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xBE18B0", Offset = "0xBDFEB0", VA = "0x180BE18B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x74CBD10", Offset = "0x74CA310", VA = "0x1874CBD10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x74CBE60", Offset = "0x74CA460", VA = "0x1874CBE60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x74CB7B0", Offset = "0x74C9DB0", VA = "0x1874CB7B0")]
	public void CopyBounds(SavedExtents OKCHLIEAIJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x74CBC60", Offset = "0x74CA260", VA = "0x1874CBC60")]
	public void SetLocalSpaceBounds(Bounds KLCGDCHIPOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x11EC290", Offset = "0x11EA890", VA = "0x1811EC290")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x74CBC50", Offset = "0x74CA250", VA = "0x1874CBC50")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x74CB7E0", Offset = "0x74C9DE0", VA = "0x1874CB7E0")]
	private void GHEEMHAKDMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x74CBA50", Offset = "0x74CA050", VA = "0x1874CBA50")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x74CB140", Offset = "0x74C9740", VA = "0x1874CB140")]
	public static void CalculateLocalBoundsFor(GameObject HHDLNMHBJJD, [Out] Bounds KLCGDCHIPOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x74CB990", Offset = "0x74C9F90", VA = "0x1874CB990")]
	private static void MBHOMJJMPAG(Bounds PPCFCAEIJMM, Color OPLPABIPAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x74CBC80", Offset = "0x74CA280", VA = "0x1874CBC80")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9501A0", Offset = "0x94E7A0", VA = "0x1809501A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x959480", Offset = "0x957A80", VA = "0x180959480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1685A70", Offset = "0x1684070", VA = "0x181685A70")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x531C950", Offset = "0x531AF50", VA = "0x18531C950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "4")]
	public virtual void JDDJGPDOBJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[EKEHNNDIDIK]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x531C4C0", Offset = "0x531AAC0", VA = "0x18531C4C0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x531B090", Offset = "0x5319690", VA = "0x18531B090", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x531C870", Offset = "0x531AE70", VA = "0x18531C870")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class BGJJGABNIMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public BGJJGABNIMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x589FE70", Offset = "0x589E470", VA = "0x18589FE70")]
		internal int BEMCIDOBLFC(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[EKEHNNDIDIK]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4082810", Offset = "0x4080E10", VA = "0x184082810", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4082870", Offset = "0x4080E70", VA = "0x184082870", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x40826F0", Offset = "0x4080CF0", VA = "0x1840826F0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey LKMGECEEGEE]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x40827B0", Offset = "0x4080DB0", VA = "0x1840827B0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x40825A0", Offset = "0x4080BA0", VA = "0x1840825A0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x40821B0", Offset = "0x40807B0", VA = "0x1840821B0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4081570", Offset = "0x407FB70", VA = "0x184081570", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4082390", Offset = "0x4080990", VA = "0x184082390", Slot = "14")]
	protected virtual string POHGANAOPIG(TKeyVal ONFJMGPMMKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4081470", Offset = "0x407FA70", VA = "0x184081470", Slot = "4")]
	public bool ContainsKey(TKey LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4082420", Offset = "0x4080A20", VA = "0x184082420", Slot = "5")]
	public bool TryGetValue(TKey LKMGECEEGEE, [Out] TVal KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x40814D0", Offset = "0x407FAD0", VA = "0x1840814D0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x40814D0", Offset = "0x407FAD0", VA = "0x1840814D0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4082480", Offset = "0x4080A80", VA = "0x184082480")]
	protected EditableSerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class SerializedReferenceKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[SerializeField]
	[SerializeReference]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x950400", Offset = "0x94EA00", VA = "0x180950400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9529B0", Offset = "0x950FB0", VA = "0x1809529B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	protected SerializedReferenceKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class SerializedReferenceDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class SerializedReferenceKeyValuePair : SerializedReferenceKeyVal<TKey, TVal>
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x401CFF0", Offset = "0x401B5F0", VA = "0x18401CFF0")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[EKEHNNDIDIK]
	[SerializeField]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x531E340", Offset = "0x531C940", VA = "0x18531E340")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x531DB80", Offset = "0x531C180", VA = "0x18531DB80", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x531D130", Offset = "0x531B730", VA = "0x18531D130", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class BDMKJAENPEG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct EADFPOHNMLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T DEDOPNLMLPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float MPAJGOMHHLL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int MFAMJBCHJLN = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float FAKCCAHJMJM = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly EADFPOHNMLA[] CJFOOLJEHLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int BLHHOFFHFDA;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float CCOGJBBLCJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xAB0F60", Offset = "0xAAF560", VA = "0x180AB0F60")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xAFE310", Offset = "0xAFC910", VA = "0x180AFE310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T IJOKMEENCFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9529B0", Offset = "0x950FB0", VA = "0x1809529B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x589BA50", Offset = "0x589A050", VA = "0x18589BA50")]
	protected BDMKJAENPEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x589B9B0", Offset = "0x5899FB0", VA = "0x18589B9B0")]
	protected BDMKJAENPEG(int IBMHAIHIDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x589B7D0", Offset = "0x5899DD0", VA = "0x18589B7D0")]
	public void HBHDBABAKDP(float KGDKBIOOEOP, T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool PIBBGNLICCF(float LCHOJPBPMKM, float BIOJJDPHHHF, [Out] T KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool FPONNCIDEJI(float LCHOJPBPMKM, float BIOJJDPHHHF, [Out] T KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x589B8E0", Offset = "0x5899EE0", VA = "0x18589B8E0")]
	public void KKIOKOIHHPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HDLPKPIGIHE : BDMKJAENPEG<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x74C90F0", Offset = "0x74C76F0", VA = "0x1874C90F0", Slot = "4")]
	public override bool PIBBGNLICCF(float LCHOJPBPMKM, float BIOJJDPHHHF, [Out] Vector3 KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x74C8FB0", Offset = "0x74C75B0", VA = "0x1874C8FB0", Slot = "5")]
	public override bool FPONNCIDEJI(float LCHOJPBPMKM, float BIOJJDPHHHF, [Out] Vector3 KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x74C9250", Offset = "0x74C7850", VA = "0x1874C9250")]
	public HDLPKPIGIHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class EIALEOFKHJH
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3271150", Offset = "0x326F750", VA = "0x183271150")]
	public static CANEJCIOAKL<T1, T2> OILMBKHFGKP<T1, T2>(T1 GBBKNPJIAFP, T2 BGIPELEGIPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x32711F0", Offset = "0x326F7F0", VA = "0x1832711F0")]
	public static BBDPDAJNEAB<T1, T2, T3> OILMBKHFGKP<T1, T2, T3>(T1 GBBKNPJIAFP, T2 BGIPELEGIPK, T3 MOOIKGDOEEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x4E6BBC0", Offset = "0x4E6A1C0", VA = "0x184E6BBC0")]
	internal static int ICMJHMEEHHA(int BEHOJNPABMJ, int LHBGKAHLPEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6772B50", Offset = "0x6771150", VA = "0x186772B50")]
	internal static int ICMJHMEEHHA(int BEHOJNPABMJ, int LHBGKAHLPEJ, int MPEAEKJOCEP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CANEJCIOAKL<T1, T2> : IComparable<CANEJCIOAKL<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 ECAKFCOMCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 BOHFFOLPHFN;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5A65DA0", Offset = "0x5A643A0", VA = "0x185A65DA0")]
	public CANEJCIOAKL(T1 GBBKNPJIAFP, T2 BGIPELEGIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5A64050", Offset = "0x5A62650", VA = "0x185A64050", Slot = "4")]
	public int CompareTo(CANEJCIOAKL<T1, T2> OKCHLIEAIJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5A64650", Offset = "0x5A62C50", VA = "0x185A64650", Slot = "0")]
	public override bool Equals(object OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5A65100", Offset = "0x5A63700", VA = "0x185A65100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5A655D0", Offset = "0x5A63BD0", VA = "0x185A655D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BBDPDAJNEAB<T1, T2, T3> : IComparable<BBDPDAJNEAB<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 ECAKFCOMCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 BOHFFOLPHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 AOPMNFAFLHC;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5899C90", Offset = "0x5898290", VA = "0x185899C90")]
	public BBDPDAJNEAB(T1 GBBKNPJIAFP, T2 BGIPELEGIPK, T3 MOOIKGDOEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5899320", Offset = "0x5897920", VA = "0x185899320", Slot = "4")]
	public int CompareTo(BBDPDAJNEAB<T1, T2, T3> OKCHLIEAIJP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x58996F0", Offset = "0x5897CF0", VA = "0x1858996F0", Slot = "0")]
	public override bool Equals(object OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x58998A0", Offset = "0x5897EA0", VA = "0x1858998A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5899AE0", Offset = "0x58980E0", VA = "0x185899AE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AnimationCurve MEKOEBHOABO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T BKDFHECHJKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xD98C40", Offset = "0xD97240", VA = "0x180D98C40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T HHFDJFGAPKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xAA1810", Offset = "0xA9FE10", VA = "0x180AA1810")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T DEDOPNLMLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x29354C0", Offset = "0x2933AC0", VA = "0x1829354C0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2935710", Offset = "0x2933D10", VA = "0x182935710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float KLMKKBNCOFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA9A9B0", Offset = "0xA98FB0", VA = "0x180A9A9B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x55A2200", Offset = "0x55A0800", VA = "0x1855A2200")]
	public T CAODICGHFIO(float CHBEBLKFDBC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x55A2700", Offset = "0x55A0D00", VA = "0x1855A2700")]
	public T MNBIGCGLFEE(float CHBEBLKFDBC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T KBBDEOMJCFA(T CLHNCHKFPON, T KMNANLEEDKO, float CHBEBLKFDBC);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x74C8E70", Offset = "0x74C7470", VA = "0x1874C8E70", Slot = "4")]
	protected override float KBBDEOMJCFA(float CLHNCHKFPON, float KMNANLEEDKO, float CHBEBLKFDBC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x74C8EB0", Offset = "0x74C74B0", VA = "0x1874C8EB0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1501600", Offset = "0x14FFC00", VA = "0x181501600", Slot = "4")]
	protected override Vector3 KBBDEOMJCFA(Vector3 CLHNCHKFPON, Vector3 KMNANLEEDKO, float CHBEBLKFDBC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x74CCD90", Offset = "0x74CB390", VA = "0x1874CCD90")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x74C6C80", Offset = "0x74C5280", VA = "0x1874C6C80", Slot = "4")]
	protected override Color KBBDEOMJCFA(Color CLHNCHKFPON, Color KMNANLEEDKO, float CHBEBLKFDBC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x74C6D40", Offset = "0x74C5340", VA = "0x1874C6D40")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class AOIEJOLMHIO : PGPEJIODKCL<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x74C6990", Offset = "0x74C4F90", VA = "0x1874C6990")]
	public AOIEJOLMHIO(int CCAKDDNOMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x74C6920", Offset = "0x74C4F20", VA = "0x1874C6920", Slot = "6")]
	protected override uint DPOHEDINKDL(uint MGPEIJNPFNJ, string KBGCCIOIGBD)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class BAJBDNNJIPL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable IMFIEPMCPDC;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	public BAJBDNNJIPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct NDANCIKFOCO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> FFGHBHLDKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int BCFCGIBGIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int AOPNFALECDA;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4E6DDC0", Offset = "0x4E6C3C0", VA = "0x184E6DDC0")]
	private NDANCIKFOCO(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> PKGIOODIPNM, int AGBKCKBBIIL, int IENEKJIPKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4E8B4D0", Offset = "0x4E89AD0", VA = "0x184E8B4D0")]
	public static NDANCIKFOCO<T> FEOBEKOIKMG()
	{
		return default(NDANCIKFOCO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4E8BCF0", Offset = "0x4E8A2F0", VA = "0x184E8BCF0")]
	public (int, int, Task<T>) FPHFDELOAPN(int CGHBAOIKKLL, [Optional] CancellationToken LAEIHJHNGEK, double HKPDGGGHFLH = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4E8D460", Offset = "0x4E8BA60", VA = "0x184E8D460")]
	public void NBJFHPDHLPA(int CGHBAOIKKLL, int IENEKJIPKDG, [In] T BIEIOPPGBOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class BEGJFHNCNPJ
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x74C6AC0", Offset = "0x74C50C0", VA = "0x1874C6AC0")]
	public static NDANCIKFOCO<IDMEFNAINAN> FEOBEKOIKMG()
	{
		return default(NDANCIKFOCO<IDMEFNAINAN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x74C6B10", Offset = "0x74C5110", VA = "0x1874C6B10")]
	public static void NBJFHPDHLPA([In] this NDANCIKFOCO<IDMEFNAINAN> JDCFMPOHCEA, int CGHBAOIKKLL, int IENEKJIPKDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class MIPJNHEPHAG<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> JIELCLBMFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> BJGAAHFPGEI;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3D45830", Offset = "0x3D43E30", VA = "0x183D45830", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool NJEEMOHCODN
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> OLFFBNADHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x455F360", Offset = "0x455D960", VA = "0x18455F360", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> JKLIKDPGFIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x45597B0", Offset = "0x4557DB0", VA = "0x1845597B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4DEE630", Offset = "0x4DECC30", VA = "0x184DEE630", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4DEE6D0", Offset = "0x4DECCD0", VA = "0x184DEE6D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4DEE0C0", Offset = "0x4DEC6C0", VA = "0x184DEE0C0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4DEDD10", Offset = "0x4DEC310", VA = "0x184DEDD10", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4DEE410", Offset = "0x4DECA10", VA = "0x184DEE410", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4DEDA20", Offset = "0x4DEC020", VA = "0x184DEDA20", Slot = "9")]
	public void Add(TKey LKMGECEEGEE, TVal KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4DEDA70", Offset = "0x4DEC070", VA = "0x184DEDA70", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> MBDDOPABDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4DEDDB0", Offset = "0x4DEC3B0", VA = "0x184DEDDB0", Slot = "8")]
	public bool ContainsKey(TKey LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4DEDE00", Offset = "0x4DEC400", VA = "0x184DEDE00", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> MBDDOPABDGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4DEE350", Offset = "0x4DEC950", VA = "0x184DEE350", Slot = "10")]
	public bool Remove(TKey LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4DEE3D0", Offset = "0x4DEC9D0", VA = "0x184DEE3D0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> MBDDOPABDGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4DEE4B0", Offset = "0x4DECAB0", VA = "0x184DEE4B0", Slot = "11")]
	public bool TryGetValue(TKey LKMGECEEGEE, [Out] TVal KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4DEDFC0", Offset = "0x4DEC5C0", VA = "0x184DEDFC0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4DEDE80", Offset = "0x4DEC480", VA = "0x184DEDE80", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] CJFOOLJEHLK, int BJJLGILDBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4DEDF60", Offset = "0x4DEC560", VA = "0x184DEDF60")]
	public bool GMJNAAAPBAP(TVal LKMGECEEGEE, [Out] TKey KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4DED860", Offset = "0x4DEBE60", VA = "0x184DED860")]
	private void ACLKKFBGJDN(TKey LKMGECEEGEE, TVal DGOEGFOLJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4DEDB50", Offset = "0x4DEC150", VA = "0x184DEDB50")]
	private void CGDGAPFFMIN(TKey LKMGECEEGEE, TVal DGOEGFOLJJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4DEE230", Offset = "0x4DEC830", VA = "0x184DEE230")]
	private bool LFGMPFNBDCL(TKey LKMGECEEGEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4DEE510", Offset = "0x4DECB10", VA = "0x184DEE510")]
	public MIPJNHEPHAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class GPDIDABDGDI<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private GPDIDABDGDI<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x1088140", Offset = "0x1086740", VA = "0x181088140", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x40E5BC0", Offset = "0x40E41C0", VA = "0x1840E5BC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x40E6F90", Offset = "0x40E5590", VA = "0x1840E6F90")]
		public Enumerator(GPDIDABDGDI<T> DEEIKCMDENK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x40E4710", Offset = "0x40E2D10", VA = "0x1840E4710", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x40E54F0", Offset = "0x40E3AF0", VA = "0x1840E54F0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x40E5300", Offset = "0x40E3900", VA = "0x1840E5300")]
		private void PMDEHNIEOEH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] ONOIJFJJLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int EKDINNHMJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int PHHAFJOKPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int EPKMALKPPHD;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x45BF710", Offset = "0x45BDD10", VA = "0x1845BF710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x45BF410", Offset = "0x45BDA10", VA = "0x1845BF410")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x45BE490", Offset = "0x45BCA90", VA = "0x1845BE490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x45BFA30", Offset = "0x45BE030", VA = "0x1845BFA30")]
	public GPDIDABDGDI(int CCAKDDNOMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x45BEAA0", Offset = "0x45BD0A0", VA = "0x1845BEAA0")]
	public void HBHDBABAKDP(T CHBEBLKFDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x45BF620", Offset = "0x45BDC20", VA = "0x1845BF620")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x45BF640", Offset = "0x45BDC40", VA = "0x1845BF640")]
	public void KPINJGJFDAH(int BBEJNKBNMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x45BD9B0", Offset = "0x45BBFB0", VA = "0x1845BD9B0")]
	public void DCNHFJIJBBF(T[] CJFOOLJEHLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x45BD940", Offset = "0x45BBF40", VA = "0x1845BD940")]
	public Enumerator BNIMLGJMJBK()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x45BF7D0", Offset = "0x45BDDD0", VA = "0x1845BF7D0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x45BF7D0", Offset = "0x45BDDD0", VA = "0x1845BF7D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x45BEF80", Offset = "0x45BD580", VA = "0x1845BEF80")]
	private int JCHKHMJJKEH(int EAHKFAJBNDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x45BEBC0", Offset = "0x45BD1C0", VA = "0x1845BEBC0")]
	private int IPEJKBMEKHF(int EAHKFAJBNDN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class EDKFEDBHBOL<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> JFGBDKDLEJL(TRequest NEMAHPGAGLG, CancellationToken LAEIHJHNGEK);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum AAHNIMPLBFA
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class CJMJPGJKLEL
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float IMHAHMHMNAP = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan MGMHIEBDNAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int NLALFEJCGND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AAHNIMPLBFA FKLKEDMMMAE;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly CJMJPGJKLEL MPDPNCAPBBE;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float ECKECGACNLC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x5B5FC40", Offset = "0x5B5E240", VA = "0x185B5FC40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan CAFIDJCMIDI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x5B5FD90", Offset = "0x5B5E390", VA = "0x185B5FD90")]
		public CJMJPGJKLEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct PAKFHMBJKLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest NEMAHPGAGLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken LAEIHJHNGEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> MECOEADPMKH;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x50D8F20", Offset = "0x50D7520", VA = "0x1850D8F20")]
		public PAKFHMBJKLL(TRequest NEMAHPGAGLG, TaskCompletionSource<TResult> MECOEADPMKH, CancellationToken LAEIHJHNGEK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct IONJFGBHOHC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public EDKFEDBHBOL<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x4797390", Offset = "0x4795990", VA = "0x184797390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4797790", Offset = "0x4795D90", VA = "0x184797790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct MFBCMJCIELI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public EDKFEDBHBOL<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private PAKFHMBJKLL <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4DC8A00", Offset = "0x4DC7000", VA = "0x184DC8A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4DC9C30", Offset = "0x4DC8230", VA = "0x184DC9C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource ABJBANGOLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<PAKFHMBJKLL> MEHFPGDCPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly CJMJPGJKLEL ADOJODGNLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly JFGBDKDLEJL OFEJHKIKBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task AOPMJENHGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int LGBEMPAJIMF;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x404DB90", Offset = "0x404C190", VA = "0x18404DB90")]
	public EDKFEDBHBOL(JFGBDKDLEJL OFEJHKIKBPG, [Optional] CJMJPGJKLEL ADOJODGNLDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x404C5C0", Offset = "0x404ABC0", VA = "0x18404C5C0")]
	public Task<TResult> BMAKLANMMBJ(TRequest NEMAHPGAGLG, CancellationToken LAEIHJHNGEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x404D3C0", Offset = "0x404B9C0", VA = "0x18404D3C0")]
	private void KIELEBCOCGC(PAKFHMBJKLL CKHHAIMJCIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x404D7E0", Offset = "0x404BDE0", VA = "0x18404D7E0")]
	[AsyncStateMachine(typeof(EDKFEDBHBOL<, >.IONJFGBHOHC))]
	private Task OEDHGHDEGDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x404CB20", Offset = "0x404B120", VA = "0x18404CB20")]
	private PAKFHMBJKLL IGJBNFDMGEF()
	{
		return default(PAKFHMBJKLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x404DAA0", Offset = "0x404C0A0", VA = "0x18404DAA0")]
	[AsyncStateMachine(typeof(EDKFEDBHBOL<, >.MFBCMJCIELI))]
	private Task OFPCMPIDPAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x404C8E0", Offset = "0x404AEE0", VA = "0x18404C8E0")]
	private void DAKFNFOACNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x404CAE0", Offset = "0x404B0E0", VA = "0x18404CAE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class GCINEMJDAHE<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> BHMKCPLLJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> DFDAIABIAHM;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x3D45830", Offset = "0x3D43E30", VA = "0x183D45830", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool NJEEMOHCODN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x3443BB0", Offset = "0x34421B0", VA = "0x183443BB0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x44D2210", Offset = "0x44D0810", VA = "0x1844D2210", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4452D40", Offset = "0x4451340", VA = "0x184452D40", Slot = "11")]
	public void Add(T MBDDOPABDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x44D18E0", Offset = "0x44CFEE0", VA = "0x1844D18E0")]
	public bool HFHDPLKFOBI(T MBDDOPABDGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x44D1F70", Offset = "0x44D0570", VA = "0x1844D1F70", Slot = "15")]
	public bool Remove(T MBDDOPABDGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x44D1750", Offset = "0x44CFD50", VA = "0x1844D1750", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x449CAF0", Offset = "0x449B0F0", VA = "0x18449CAF0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x44D1600", Offset = "0x44CFC00", VA = "0x1844D1600", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x44D16A0", Offset = "0x44CFCA0", VA = "0x1844D16A0", Slot = "13")]
	public bool Contains(T MBDDOPABDGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x44D16F0", Offset = "0x44CFCF0", VA = "0x1844D16F0", Slot = "14")]
	public void CopyTo(T[] CJFOOLJEHLK, int BJJLGILDBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x44D19E0", Offset = "0x44CFFE0", VA = "0x1844D19E0", Slot = "6")]
	public int IndexOf(T MBDDOPABDGG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x44D1A40", Offset = "0x44D0040", VA = "0x1844D1A40", Slot = "7")]
	public void Insert(int EAHKFAJBNDN, T MBDDOPABDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x44D1CD0", Offset = "0x44D02D0", VA = "0x1844D1CD0", Slot = "8")]
	public void RemoveAt(int EAHKFAJBNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x44D20F0", Offset = "0x44D06F0", VA = "0x1844D20F0")]
	public GCINEMJDAHE()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x27B2200", Offset = "0x27B0800", VA = "0x1827B2200")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x74CC320", Offset = "0x74CA920", VA = "0x1874CC320")]
		public SerializedGuid([In] Guid JINNLDEOCMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x74CC120", Offset = "0x74CA720", VA = "0x1874CC120")]
		public static SerializedGuid HKBELKAOBLP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x74CC1A0", Offset = "0x74CA7A0", VA = "0x1874CC1A0")]
		public static SerializedGuid OBOALHDENEC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x74CC2C0", Offset = "0x74CA8C0", VA = "0x1874CC2C0")]
		public bool PMLNJMJFBKO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x74CC290", Offset = "0x74CA890", VA = "0x1874CC290", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x74CC210", Offset = "0x74CA810", VA = "0x1874CC210", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x74CC040", Offset = "0x74CA640", VA = "0x1874CC040", Slot = "7")]
		public bool Equals(SerializedGuid OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x74CC080", Offset = "0x74CA680", VA = "0x1874CC080", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x74CC110", Offset = "0x74CA710", VA = "0x1874CC110", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x74CC010", Offset = "0x74CA610", VA = "0x1874CC010", Slot = "6")]
		public int CompareTo(SerializedGuid OKCHLIEAIJP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class OHAMBBNIBBN : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type JKPDLOBBLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string EOBJDAGFCPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool AKIGJFICNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool PMJLEDPENKJ;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x74CAB90", Offset = "0x74C9190", VA = "0x1874CAB90")]
	public OHAMBBNIBBN(Type CNBCEOGAJPF, string MEBJKOKIDMA, bool KLLIJONGICL = false, bool NPPCDILNICE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public interface MMOHBJDEMML<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int BNOMMEAJKDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> HNHPKHABCDE(float KGDKBIOOEOP, [Optional] float? FGFPILMKAEJ);

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DHFANEEOKFH(float KGDKBIOOEOP, T KBGCCIOIGBD);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KKIOKOIHHPE();
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[Obsolete("Use ITimeSeriesRollingWindow<T> instead")]
public class JBOOKKIDKKF<T> : MMOHBJDEMML<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class CDPJFAOLCEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float CAPILIHKBGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T DEDOPNLMLPL;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public CDPJFAOLCEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class CHIHIDPAOKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public CHIHIDPAOKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5B5B680", Offset = "0x5B59C80", VA = "0x185B5B680")]
		internal bool FMNGENOGKMD(CDPJFAOLCEK sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly float ABGKBLAGCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly float NBEFHOMJHLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<CDPJFAOLCEK> GDLKGNBDAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private AJBFHMILPDB<CDPJFAOLCEK> MMEBKBJJHHJ;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int BNOMMEAJKDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x49B6440", Offset = "0x49B4A40", VA = "0x1849B6440", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x49B66D0", Offset = "0x49B4CD0", VA = "0x1849B66D0")]
	public JBOOKKIDKKF(float ANDPFDICNMC, float ACJJKADAMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x49B5920", Offset = "0x49B3F20", VA = "0x1849B5920", Slot = "6")]
	public bool DHFANEEOKFH(float KGDKBIOOEOP, T KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x49B6020", Offset = "0x49B4620", VA = "0x1849B6020", Slot = "5")]
	public IEnumerable<T> HNHPKHABCDE(float KGDKBIOOEOP, float? FGFPILMKAEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x49B6390", Offset = "0x49B4990", VA = "0x1849B6390", Slot = "7")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x49B6520", Offset = "0x49B4B20", VA = "0x1849B6520")]
	private void OOKABCBFHDO(float KGDKBIOOEOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class GPAEHHALEEJ<T> : MMOHBJDEMML<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private readonly struct GDDFCACDPKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly T DEDOPNLMLPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float CAPILIHKBGB;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x44D6720", Offset = "0x44D4D20", VA = "0x1844D6720")]
		public GDDFCACDPKA(T KBGCCIOIGBD, float KGDKBIOOEOP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class PMGOKNJDHBJ : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public GPAEHHALEEJ<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float <>3__time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private float? minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float? <>3__minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private int <count>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xD37BA0", Offset = "0xD361A0", VA = "0x180D37BA0")]
		[DebuggerHidden]
		public PMGOKNJDHBJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x510BC30", Offset = "0x510A230", VA = "0x18510BC30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x510C1B0", Offset = "0x510A7B0", VA = "0x18510C1B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x510C080", Offset = "0x510A680", VA = "0x18510C080", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x45860D0", Offset = "0x45846D0", VA = "0x1845860D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly float ANDPFDICNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly float ACJJKADAMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<GDDFCACDPKA> GDLKGNBDAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int EKDINNHMJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int EIPDLABJDCE;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int BNOMMEAJKDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x954460", Offset = "0x952A60", VA = "0x180954460", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x45BD5B0", Offset = "0x45BBBB0", VA = "0x1845BD5B0")]
	public GPAEHHALEEJ(float ANDPFDICNMC, float ACJJKADAMND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x45BCB20", Offset = "0x45BB120", VA = "0x1845BCB20", Slot = "6")]
	public bool DHFANEEOKFH(float KGDKBIOOEOP, T KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x45BCF60", Offset = "0x45BB560", VA = "0x1845BCF60", Slot = "8")]
	public int HOEIOPNDBAB(float KGDKBIOOEOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x45BCDE0", Offset = "0x45BB3E0", VA = "0x1845BCDE0", Slot = "5")]
	[IteratorStateMachine(typeof(GPAEHHALEEJ<>.PMGOKNJDHBJ))]
	public IEnumerable<T> HNHPKHABCDE(float KGDKBIOOEOP, float? FGFPILMKAEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x45BD320", Offset = "0x45BB920", VA = "0x1845BD320", Slot = "7")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x45BD230", Offset = "0x45BB830", VA = "0x1845BD230")]
	private void KELGPMBHFIM(float KGDKBIOOEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x45BCFB0", Offset = "0x45BB5B0", VA = "0x1845BCFB0")]
	private GDDFCACDPKA ICMAGNOACJK()
	{
		return default(GDDFCACDPKA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class FGFDKLMANEA<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public readonly struct LPKEPHHLKMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly long JBBOAGKKPIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly long EDBJIMKMBLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly int NGLDOEKHAPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly int AIIJBAECDCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool FGGOBHBAMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string HCMCKPOLBNP;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4BD6660", Offset = "0x4BD4C60", VA = "0x184BD6660")]
		public LPKEPHHLKMM(long JBBOAGKKPIB, int NGLDOEKHAPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4BD6630", Offset = "0x4BD4C30", VA = "0x184BD6630")]
		public LPKEPHHLKMM(long JBBOAGKKPIB, long EDBJIMKMBLL, int NGLDOEKHAPH, int AIIJBAECDCA, bool FGGOBHBAMOM, string HCMCKPOLBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4BD6540", Offset = "0x4BD4B40", VA = "0x184BD6540")]
		public int HNBOJAOAKOB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4BD64C0", Offset = "0x4BD4AC0", VA = "0x184BD64C0")]
		public int BAGMOMHIFGB(int MMDHFPBBBFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4BD64E0", Offset = "0x4BD4AE0", VA = "0x184BD64E0")]
		public double GGCNPGPNNMP()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4BD6590", Offset = "0x4BD4B90", VA = "0x184BD6590")]
		public LPKEPHHLKMM JJFOMGBMLIM(long EDBJIMKMBLL, int AIIJBAECDCA)
		{
			return default(LPKEPHHLKMM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class ICBJPFEBGDJ : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private struct OGFNNEFACOE<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public ICBJPFEBGDJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<ICBJPFEBGDJ, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private ICBJPFEBGDJ <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x50052F0", Offset = "0x50038F0", VA = "0x1850052F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x477D850", Offset = "0x477BE50", VA = "0x18477D850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TKey PJGLJNJMAMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly FGFDKLMANEA<TKey> ACNLNBKGHCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly IBCMILIKEJG DDKJAEALMGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<ICBJPFEBGDJ> MLLPPDFFEEE;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string JGPLMPPFDGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x47628B0", Offset = "0x4760EB0", VA = "0x1847628B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<ICBJPFEBGDJ> OAHIIDOOIJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x4762D30", Offset = "0x4761330", VA = "0x184762D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public LPKEPHHLKMM EKIKCDGCDBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x4762890", Offset = "0x4760E90", VA = "0x184762890")]
			[CompilerGenerated]
			get
			{
				return default(LPKEPHHLKMM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x4762B50", Offset = "0x4761150", VA = "0x184762B50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4762D70", Offset = "0x4761370", VA = "0x184762D70")]
		internal ICBJPFEBGDJ(FGFDKLMANEA<TKey> ACNLNBKGHCE, TKey LKMGECEEGEE, IBCMILIKEJG DDKJAEALMGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4762B80", Offset = "0x4761180", VA = "0x184762B80")]
		public ICBJPFEBGDJ NGDEIMEMDOG(TKey LKMGECEEGEE, [Optional] IBCMILIKEJG? ELDBAGFCBIE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x358C880", Offset = "0x358AE80", VA = "0x18358C880")]
		[AsyncStateMachine(typeof(OGFNNEFACOE<>))]
		public Task<T> FKMHKIANPDK<T>(TKey LKMGECEEGEE, Func<ICBJPFEBGDJ, Task<T>> BPHLLBLGCAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4762900", Offset = "0x4760F00", VA = "0x184762900", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class HIMBHPNHKPI : IEnumerable<(TKey, List<TKey>, LPKEPHHLKMM)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LPKEPHHLKMM)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private (TKey key, List<TKey> path, LPKEPHHLKMM timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public FGFDKLMANEA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<(TKey key, List<TKey> path, LPKEPHHLKMM timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private (TKey, List<TKey>, LPKEPHHLKMM) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x279E180", Offset = "0x279C780", VA = "0x18279E180", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LPKEPHHLKMM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x46828D0", Offset = "0x4680ED0", VA = "0x1846828D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x279E270", Offset = "0x279C870", VA = "0x18279E270")]
		[DebuggerHidden]
		public HIMBHPNHKPI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x441D6D0", Offset = "0x441BCD0", VA = "0x18441D6D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4682410", Offset = "0x4680A10", VA = "0x184682410", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x46823C0", Offset = "0x46809C0", VA = "0x1846823C0")]
		private void ACIHHJJLKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4682880", Offset = "0x4680E80", VA = "0x184682880", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x46827B0", Offset = "0x4680DB0", VA = "0x1846827B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LPKEPHHLKMM)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x4438B00", Offset = "0x4437100", VA = "0x184438B00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class FLHHJDBGHKG : IEnumerable<(TKey, List<TKey>, LPKEPHHLKMM)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LPKEPHHLKMM)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private (TKey key, List<TKey> path, LPKEPHHLKMM timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private ICBJPFEBGDJ timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public ICBJPFEBGDJ <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public FGFDKLMANEA<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator<ICBJPFEBGDJ> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<(TKey key, List<TKey> path, LPKEPHHLKMM timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private (TKey, List<TKey>, LPKEPHHLKMM) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x279E180", Offset = "0x279C780", VA = "0x18279E180", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LPKEPHHLKMM));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x44307B0", Offset = "0x442EDB0", VA = "0x1844307B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x279E270", Offset = "0x279C870", VA = "0x18279E270")]
		[DebuggerHidden]
		public FLHHJDBGHKG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4430810", Offset = "0x442EE10", VA = "0x184430810", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x442FE60", Offset = "0x442E460", VA = "0x18442FE60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x442FDA0", Offset = "0x442E3A0", VA = "0x18442FDA0")]
		private void ACIHHJJLKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x442FE00", Offset = "0x442E400", VA = "0x18442FE00")]
		private void CHJIKJDKKOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x4430760", Offset = "0x442ED60", VA = "0x184430760", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4430620", Offset = "0x442EC20", VA = "0x184430620", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LPKEPHHLKMM)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x4430720", Offset = "0x442ED20", VA = "0x184430720", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Action<TKey, LPKEPHHLKMM, IBCMILIKEJG> GLHOPLEIKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Action<TKey, LPKEPHHLKMM, IBCMILIKEJG> BCFPCKMGELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Action<FGFDKLMANEA<TKey>, IBCMILIKEJG> CODDEAMCOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly ICBJPFEBGDJ OJFJOFOPDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool LIABCKHNDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int BKCDJKHDEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Stopwatch CFOIMBGPCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly int CPANNGAJEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private string LHNBBDGOACI;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public ICBJPFEBGDJ ACNMAEGKFHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x954BC0", Offset = "0x9531C0", VA = "0x180954BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	public string JGPLMPPFDGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x956D70", Offset = "0x955370", VA = "0x180956D70")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4420CA0", Offset = "0x441F2A0", VA = "0x184420CA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4420F50", Offset = "0x441F550", VA = "0x184420F50")]
	public FGFDKLMANEA(TKey AMMHLMPHJNC, IBCMILIKEJG DDKJAEALMGF, [Optional] int? NGLDOEKHAPH, [Optional][CanBeNull] Stopwatch CFOIMBGPCMC, [Optional] Action<TKey, LPKEPHHLKMM, IBCMILIKEJG> GLHOPLEIKOA, [Optional] Action<TKey, LPKEPHHLKMM, IBCMILIKEJG> BCFPCKMGELH, [Optional] Action<FGFDKLMANEA<TKey>, IBCMILIKEJG> CODDEAMCOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4420D00", Offset = "0x441F300", VA = "0x184420D00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4420DD0", Offset = "0x441F3D0", VA = "0x184420DD0")]
	[IteratorStateMachine(typeof(FGFDKLMANEA<>.HIMBHPNHKPI))]
	public IEnumerable<(TKey, List<TKey>, LPKEPHHLKMM)> OKKDBNIAAHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4420E70", Offset = "0x441F470", VA = "0x184420E70")]
	[IteratorStateMachine(typeof(FGFDKLMANEA<>.FLHHJDBGHKG))]
	private IEnumerable<(TKey, List<TKey>, LPKEPHHLKMM)> OKKDBNIAAHF(List<TKey> DPEONNMDCPO, ICBJPFEBGDJ NHGJLMMOIBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4420C20", Offset = "0x441F220", VA = "0x184420C20")]
	private (long, int) BGFEMNIAACL()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class MGAAGOHENGF<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut OGABHELEOAP(FGFDKLMANEA<TKey> ACNLNBKGHCE);

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	protected MGAAGOHENGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class OOPCMCOFIFC<TKey> : MGAAGOHENGF<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public delegate string FDMMDEFCIPJ(TKey LKMGECEEGEE);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5032D80", Offset = "0x5031380", VA = "0x185032D80")]
	private static string LBGCFAIHGFJ(TKey LKMGECEEGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5032DC0", Offset = "0x50313C0", VA = "0x185032DC0", Slot = "4")]
	public override string OGABHELEOAP(FGFDKLMANEA<TKey> ACNLNBKGHCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5032EA0", Offset = "0x50314A0", VA = "0x185032EA0")]
	public string OGABHELEOAP(FGFDKLMANEA<TKey> ACNLNBKGHCE, [NotNull] FDMMDEFCIPJ CFAPLNKNFIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string DFODICCKMEC(FGFDKLMANEA<TKey> ACNLNBKGHCE, [NotNull] FDMMDEFCIPJ CFAPLNKNFIH);

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x44356C0", Offset = "0x4433CC0", VA = "0x1844356C0")]
	protected OOPCMCOFIFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class KIBLFINBBBG<TKey> : MGAAGOHENGF<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate string ALNNMPMNKOO(TKey LKMGECEEGEE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string DAPCFPJOBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly double HIDNGFPHGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly bool HJNNEEADOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly int FKHJOKMOAJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ISet<string> BIHMIKDJMFE;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x4AB5D20", Offset = "0x4AB4320", VA = "0x184AB5D20")]
	private static string LBGCFAIHGFJ(TKey LKMGECEEGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4AB66F0", Offset = "0x4AB4CF0", VA = "0x184AB66F0")]
	public KIBLFINBBBG(string DAPCFPJOBCE = "F2", double HIDNGFPHGBL = double.MaxValue, bool HJNNEEADOBJ = false, int FKHJOKMOAJI = int.MaxValue, [Optional] ISet<string> BIHMIKDJMFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x4AB6610", Offset = "0x4AB4C10", VA = "0x184AB6610", Slot = "4")]
	public override Dictionary<string, string> OGABHELEOAP(FGFDKLMANEA<TKey> ACNLNBKGHCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4AB5AE0", Offset = "0x4AB40E0", VA = "0x184AB5AE0")]
	private bool EHDBNKPAKKI(string LDHHFEGBKBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4AB5FD0", Offset = "0x4AB45D0", VA = "0x184AB5FD0")]
	public Dictionary<string, string> OGABHELEOAP(FGFDKLMANEA<TKey> ACNLNBKGHCE, ALNNMPMNKOO CFAPLNKNFIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4AB5D60", Offset = "0x4AB4360", VA = "0x184AB5D60")]
	private string LJGKKHMKJAC(StringBuilder HAFFMBAJIGP, List<TKey> MMFDEJPCFBK, ALNNMPMNKOO CFAPLNKNFIH, bool IBGBHOPGLIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4AB5BC0", Offset = "0x4AB41C0", VA = "0x184AB5BC0")]
	private static void KBMNLKIGCKH(StringBuilder CDIDDJHFGHL, string PONDKFDIPFO, bool HGGJFPHPCHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class IBHHMIJCLMJ<TKey> : OOPCMCOFIFC<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct OCBLPCAKDCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public FDMMDEFCIPJ keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static IBHHMIJCLMJ<TKey> IMFIEPMCPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly string[] IGKNDLOIDAD;

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x47613A0", Offset = "0x475F9A0", VA = "0x1847613A0")]
	private IBHHMIJCLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4760320", Offset = "0x475E920", VA = "0x184760320", Slot = "5")]
	protected override string DFODICCKMEC(FGFDKLMANEA<TKey> ACNLNBKGHCE, FDMMDEFCIPJ CFAPLNKNFIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x4761160", Offset = "0x475F760", VA = "0x184761160")]
	[CompilerGenerated]
	internal static string GNOAIFIIHIO(string HIGICKHMPJA, TKey LKMGECEEGEE, OCBLPCAKDCO P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public sealed class KKGKLENEBCC : FGFDKLMANEA<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class AKMAPPACFDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Action<KKGKLENEBCC, IBCMILIKEJG> callback;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public AKMAPPACFDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x74C6890", Offset = "0x74C4E90", VA = "0x1874C6890")]
		internal void GNFPAFPEHLE(FGFDKLMANEA<string> timer, IBCMILIKEJG log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x74C9950", Offset = "0x74C7F50", VA = "0x1874C9950")]
	public KKGKLENEBCC(IBCMILIKEJG DDKJAEALMGF, [Optional] string KDCJEBLDBJH, [Optional] int? NGLDOEKHAPH, [Optional] Stopwatch CFOIMBGPCMC, [Optional] Action<string, LPKEPHHLKMM, IBCMILIKEJG> GLHOPLEIKOA, [Optional] Action<string, LPKEPHHLKMM, IBCMILIKEJG> BCFPCKMGELH, [Optional] Action<KKGKLENEBCC, IBCMILIKEJG> CODDEAMCOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x74C9890", Offset = "0x74C7E90", VA = "0x1874C9890")]
	private static Action<FGFDKLMANEA<string>, IBCMILIKEJG> GIBPACNAJBI(Action<KKGKLENEBCC, IBCMILIKEJG> IJCKFHFIADK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public abstract class EMNGBPGDJPK
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private class HPAGDLBKLJI : EMNGBPGDJPK
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static EMNGBPGDJPK IMFIEPMCPDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x74C9740", Offset = "0x74C7D40", VA = "0x1874C9740")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override float OOGBABHPKLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xFF26C0", Offset = "0xFF0CC0", VA = "0x180FF26C0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x74C9840", Offset = "0x74C7E40", VA = "0x1874C9840")]
		public HPAGDLBKLJI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static EMNGBPGDJPK CEEJKKOBOEJ;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static EMNGBPGDJPK MPDPNCAPBBE
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x74C8400", Offset = "0x74C6A00", VA = "0x1874C8400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract float OOGBABHPKLI
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	protected EMNGBPGDJPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public interface BELJNJGLPJA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool MOBPININNFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface EBHOPDBMNPK<T> : BELJNJGLPJA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	Task<T> NIBNOJEINFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[NotNull]
	NEEPBAPEEOL<T> EHEMMIMPHDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public static class HNOCMNJEGEP
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x33F1370", Offset = "0x33EF970", VA = "0x1833F1370")]
	public static EBHOPDBMNPK<TResource> CFIKKDMOODK<TResource, TId>(this KDGGAAKPFMI<TId, TResource> HIDLDGNDFHN, TId KGHCKLKGJKM, [Optional] Func<TId, CancellationToken, Task<TResource>>? MKJPDHHACCF) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class KFOFMPCPPED
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private sealed class LEDODBDBOAH<T> : IBMEPBNFOMN<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T?> NIBNOJEINFE
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override NEEPBAPEEOL<T?> EHEMMIMPHDN
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x4BB4CE0", Offset = "0x4BB32E0", VA = "0x184BB4CE0")]
		public LEDODBDBOAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "10")]
		protected override void KOCGEEKMMPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class PMJFLODHFJD<T> : IBMEPBNFOMN<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly T DLLKKBMIKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Action<T>? HEANOJFNKDG;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> NIBNOJEINFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x952DD0", Offset = "0x9513D0", VA = "0x180952DD0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override NEEPBAPEEOL<T> EHEMMIMPHDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x9529D0", Offset = "0x950FD0", VA = "0x1809529D0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x510CC30", Offset = "0x510B230", VA = "0x18510CC30")]
		public PMJFLODHFJD(T GINGHILKALC, Action<T>? BKAIFAJPEJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x510C9F0", Offset = "0x510AFF0", VA = "0x18510C9F0", Slot = "10")]
		protected override void KOCGEEKMMPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class MGKFBHINOAO<T> : IBMEPBNFOMN<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<T> NIBNOJEINFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override NEEPBAPEEOL<T> EHEMMIMPHDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x4DCD6B0", Offset = "0x4DCBCB0", VA = "0x184DCD6B0")]
		public MGKFBHINOAO(Exception JNJDMGFBFDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "10")]
		protected override void KOCGEEKMMPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class KCCEDCKHJMH<T> : IBMEPBNFOMN<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct LLIIAAKFKFO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Task<EBHOPDBMNPK<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<EBHOPDBMNPK<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x4BC3160", Offset = "0x4BC1760", VA = "0x184BC3160", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x4BC3B40", Offset = "0x4BC2140", VA = "0x184BC3B40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct HHHLJJBIDMC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Task<EBHOPDBMNPK<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<EBHOPDBMNPK<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x467FE60", Offset = "0x467E460", VA = "0x18467FE60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x4680320", Offset = "0x467E920", VA = "0x184680320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly Task<EBHOPDBMNPK<T>> MPKKFNBDEJH;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Task<T> NIBNOJEINFE
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override NEEPBAPEEOL<T> EHEMMIMPHDN
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x9529E0", Offset = "0x950FE0", VA = "0x1809529E0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x4A9AC10", Offset = "0x4A99210", VA = "0x184A9AC10")]
		public KCCEDCKHJMH(Task<EBHOPDBMNPK<T>> CBPINBDBDCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x4A9A930", Offset = "0x4A98F30", VA = "0x184A9A930", Slot = "10")]
		protected override void KOCGEEKMMPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x4A9A650", Offset = "0x4A98C50", VA = "0x184A9A650")]
		[AsyncStateMachine(typeof(KCCEDCKHJMH<>.LLIIAAKFKFO))]
		[CompilerGenerated]
		internal static Task<T> DKMNELHLIGM(Task<EBHOPDBMNPK<T>> CBPINBDBDCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x4A9AA50", Offset = "0x4A99050", VA = "0x184A9AA50")]
		[AsyncStateMachine(typeof(KCCEDCKHJMH<>.HHHLJJBIDMC))]
		[CompilerGenerated]
		internal static Task OCMKDAMLFMC(Task<EBHOPDBMNPK<T>> CBPINBDBDCO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	private sealed class GPABADCAJND<TIn, TOut> : IBMEPBNFOMN<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct KABJOGBJMLF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x4A91290", Offset = "0x4A8F890", VA = "0x184A91290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x4554130", Offset = "0x4552730", VA = "0x184554130", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly EBHOPDBMNPK<TIn> DEBKIEJDHCG;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Task<TOut> NIBNOJEINFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override NEEPBAPEEOL<TOut> EHEMMIMPHDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9529E0", Offset = "0x950FE0", VA = "0x1809529E0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x45BC6F0", Offset = "0x45BACF0", VA = "0x1845BC6F0")]
		public GPABADCAJND(EBHOPDBMNPK<TIn> GNGLLPGHGBH, Func<TIn, TOut> DJFFEOOKLFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x45BC6A0", Offset = "0x45BACA0", VA = "0x1845BC6A0", Slot = "10")]
		protected override void KOCGEEKMMPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x45BC4D0", Offset = "0x45BAAD0", VA = "0x1845BC4D0")]
		[AsyncStateMachine(typeof(GPABADCAJND<, >.KABJOGBJMLF))]
		[CompilerGenerated]
		internal static Task<TOut> FCNJNALGLIA(Task<TIn> JNEEHFAADNH, Func<TIn, TOut> DJFFEOOKLFI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x34AA470", Offset = "0x34A8A70", VA = "0x1834AA470")]
	public static EBHOPDBMNPK<T> DGEEMDAPOEK<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x34AA4F0", Offset = "0x34A8AF0", VA = "0x1834AA4F0")]
	public static EBHOPDBMNPK<T> KKNKEABJGIL<T>(T BIEIOPPGBOB, [Optional] Action<T>? BKAIFAJPEJC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3199380", Offset = "0x3197980", VA = "0x183199380")]
	public static EBHOPDBMNPK<T> DKFKIFIBHGC<T>(Exception JNJDMGFBFDL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3199380", Offset = "0x3197980", VA = "0x183199380")]
	public static EBHOPDBMNPK<T> KKJHHKOBDJE<T>(Task<EBHOPDBMNPK<T>> CBPINBDBDCO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x31891A0", Offset = "0x31877A0", VA = "0x1831891A0")]
	public static EBHOPDBMNPK<TOut> KECLKMNFMIH<TOut, TIn>(EBHOPDBMNPK<TIn> ILIIBOPHLDK, Func<TIn, TOut> DJFFEOOKLFI) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class IBMEPBNFOMN<T> : EBHOPDBMNPK<T>, BELJNJGLPJA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly string LKGNFHILCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly ANEFDAMIPJL JFLLGCNBCBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool LIABCKHNDHI;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool MOBPININNFE
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xB45090", Offset = "0xB43690", VA = "0x180B45090", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract Task<T> NIBNOJEINFE
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract NEEPBAPEEOL<T> EHEMMIMPHDN
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x47620A0", Offset = "0x47606A0", VA = "0x1847620A0")]
	public IBMEPBNFOMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4761DE0", Offset = "0x47603E0", VA = "0x184761DE0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void KOCGEEKMMPP();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class IDPINFFBPGI<TTask, T> : IBMEPBNFOMN<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class ONOCMLCFMIF
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public ONOCMLCFMIF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x3D34110", Offset = "0x3D32710", VA = "0x183D34110", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x3D343D0", Offset = "0x3D329D0", VA = "0x183D343D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public IDPINFFBPGI<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public ONOCMLCFMIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x502A440", Offset = "0x5028A40", VA = "0x18502A440")]
		[AsyncStateMachine(typeof(IDPINFFBPGI<, >.ONOCMLCFMIF.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> NBACEKEDELD(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Task<T> CBPINBDBDCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly CancellationTokenSource PMAMMIAHALH;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override Task<T> NIBNOJEINFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override NEEPBAPEEOL<T> EHEMMIMPHDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x47713D0", Offset = "0x476F9D0", VA = "0x1847713D0")]
	protected IDPINFFBPGI(TTask CBPINBDBDCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4771380", Offset = "0x476F980", VA = "0x184771380", Slot = "10")]
	protected override void KOCGEEKMMPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T DHKALHEMICK(TTask OJHAAGOGBNE);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void DHGLNKNCHGP();
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class OCPDJKHGLJM<T> : IBMEPBNFOMN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly KFDDALGMHJI<Task<T>> PKCAOLKNFIF;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override Task<T> NIBNOJEINFE
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x457C180", Offset = "0x457A780", VA = "0x18457C180", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override NEEPBAPEEOL<T> EHEMMIMPHDN
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x4FEA220", Offset = "0x4FE8820", VA = "0x184FEA220")]
	public OCPDJKHGLJM(KFDDALGMHJI<Task<T>> DOLJNDGNFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x4FEA200", Offset = "0x4FE8800", VA = "0x184FEA200", Slot = "10")]
	protected override void KOCGEEKMMPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public static class FGNIBJIIOCP
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly HashAlgorithmName BLDGHPMNHIK;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly ThreadLocal<IncrementalHash> OCKBBJILPGE;

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x74C8CA0", Offset = "0x74C72A0", VA = "0x1874C8CA0")]
	public static int HADMDIIPMHF(this GJNJIONJAFL NKHIGAOONKE, IncrementalHash MGPEIJNPFNJ, byte[] HCBCPDBKAPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x74C8C40", Offset = "0x74C7240", VA = "0x1874C8C40")]
	public static bool DOCBADGCJLJ([CanBeNull] this GJNJIONJAFL NKHIGAOONKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x74C8600", Offset = "0x74C6C00", VA = "0x1874C8600")]
	public static bool DOCBADGCJLJ([CanBeNull] this GJNJIONJAFL NKHIGAOONKE, [Out] string IFMHONGNKHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x74C8910", Offset = "0x74C6F10", VA = "0x1874C8910")]
	public static bool DOCBADGCJLJ([CanBeNull] this GJNJIONJAFL NKHIGAOONKE, IncrementalHash MGPEIJNPFNJ, byte[] HCBCPDBKAPC, [Out] string IFMHONGNKHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x74C8570", Offset = "0x74C6B70", VA = "0x1874C8570")]
	private static bool CGBFMBCFODB(byte[] PLFLANKIJFA, Span<byte> BPHENBJJBHA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class ELCMLCEPCPF
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x74C82B0", Offset = "0x74C68B0", VA = "0x1874C82B0")]
	public static int NCJKMFKJGHP(HashAlgorithmName GAEIOCIOKGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x74C8050", Offset = "0x74C6650", VA = "0x1874C8050")]
	public static int HADMDIIPMHF(this AKLCOKKIAMD OAPKHAIAMBK, byte[] PNDKHGKDAIK, IncrementalHash MGPEIJNPFNJ, byte[] LCJNMAGHHNI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface AKLCOKKIAMD
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash MGPEIJNPFNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface GJNJIONJAFL : AKLCOKKIAMD
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] HEJPDEGNILB
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[CanBeNull]
	byte[] DHEHLHDCJAC
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class DCEFFPPLLBK
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static bool GODELGOMELD;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ArrayPool<byte> GNFNDMBOLGH;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ArrayPool<char> GPJBHMDDMHI;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Encoding OFHHKKKGNPH;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ThreadLocal<Encoder> PCGAOEIGEIJ;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3243540", Offset = "0x3241B40", VA = "0x183243540")]
	public static void BEKPJPKNACI<T>(this IncrementalHash BGEKIPEFNNL, [CanBeNull] T MEFMJJOMDFE) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3243B20", Offset = "0x3242120", VA = "0x183243B20")]
	public static void DKKGKNCPOAH<T>(this IncrementalHash BGEKIPEFNNL, [CanBeNull] T OAPKHAIAMBK) where T : AKLCOKKIAMD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3243600", Offset = "0x3241C00", VA = "0x183243600")]
	public static void DHCOHEALKOG<T>(this IncrementalHash BGEKIPEFNNL, [CanBeNull] IList<T> OGPCJCBGIHN) where T : AKLCOKKIAMD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x74C7780", Offset = "0x74C5D80", VA = "0x1874C7780")]
	private static bool HPLGCCOLHOJ([CanBeNull] AKLCOKKIAMD OAPKHAIAMBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x74C7010", Offset = "0x74C5610", VA = "0x1874C7010")]
	public static void EAKEKDJKLIE(this IncrementalHash MGPEIJNPFNJ, string? FPOEJCPHIMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x74C6D80", Offset = "0x74C5380", VA = "0x1874C6D80")]
	public static void ADGOMJMJIDL(this IncrementalHash MGPEIJNPFNJ, long PHHFPCMDPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x74C7AF0", Offset = "0x74C60F0", VA = "0x1874C7AF0")]
	public static void PMPAIEBCBED(this IncrementalHash MGPEIJNPFNJ, int AGHNODDBJGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x74C7920", Offset = "0x74C5F20", VA = "0x1874C7920")]
	public static void PMJCBEBMOAN(this IncrementalHash MGPEIJNPFNJ, short PBMAMGNIEEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x74C7810", Offset = "0x74C5E10", VA = "0x1874C7810")]
	public static void KIBGLEJDJOO(this IncrementalHash MGPEIJNPFNJ, byte CCGOIOPBFMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x74C75B0", Offset = "0x74C5BB0", VA = "0x1874C75B0")]
	public static void GPAEMOOKJGB(this IncrementalHash MGPEIJNPFNJ, bool MOPEKJHNIBC, bool KKGJOBNFHII = false, bool KGEJADIAMJE = false, bool BBHKCNGKGMA = false, bool OPNKOGBKOMO = false, bool JIBLNMHJPNF = false, bool BDDDNDFIDLK = false, bool IGLFFLMPING = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3243BB0", Offset = "0x32421B0", VA = "0x183243BB0")]
	public static void MGKMAMBENIC<T>(this IncrementalHash MGPEIJNPFNJ, T JJFHAAOAACO) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x74C6F50", Offset = "0x74C5550", VA = "0x1874C6F50")]
	public static void APDGNDCHGIM(this IncrementalHash MGPEIJNPFNJ, float MDNLGMAHEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x74C7720", Offset = "0x74C5D20", VA = "0x1874C7720")]
	public static void HIMMAHIJOII(this IncrementalHash MGPEIJNPFNJ, ulong IBKDLCMDGIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x74C6FB0", Offset = "0x74C55B0", VA = "0x1874C6FB0")]
	public static void DAHMGAICLMH(this IncrementalHash MGPEIJNPFNJ, uint MKIKPGJFBDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x74C7550", Offset = "0x74C5B50", VA = "0x1874C7550")]
	public static void GIJDDMOKMAN(this IncrementalHash MGPEIJNPFNJ, ushort CHHABJJMDEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x74C7420", Offset = "0x74C5A20", VA = "0x1874C7420")]
	public static void EGFPDAHKAJO(this IncrementalHash MGPEIJNPFNJ, Vector3 DIKMDGBFJLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public class BCHPOHENKOJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x74C6A60", Offset = "0x74C5060", VA = "0x1874C6A60")]
	public BCHPOHENKOJ(string MIALAMIFNLM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class HKGDPMOAOOK
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public delegate void BHLAFMNIMNB(ushort BLAKIIPJCDE, ushort KEANEGKAODJ, ushort LAKMCLMLEJG, ushort DLAKCLNLEGB);

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void EINKAOFFLAO(ushort FJDKGIJPICA, ushort DKPMLPJJDJI);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void OAKIALGBHFD();

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const ushort ANOMIFEGDJP = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
	protected HKGDPMOAOOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public abstract class DAKKCFAFGBP<T> : HKGDPMOAOOK where T : DAKKCFAFGBP<T>.IKNOCHLMCII
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public interface IKNOCHLMCII
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		EINKAOFFLAO LPIHLPMKEOD
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		EINKAOFFLAO NDJPEGCHKDC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		OAKIALGBHFD ICGOBMKAMEM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<uint, T> ACDKCMGEPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private OAKIALGBHFD DHPLNLJEAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private OAKIALGBHFD DBPODFNNCKE;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool HHHFMIOIODH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xBB40B0", Offset = "0xBB26B0", VA = "0x180BB40B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x950420", Offset = "0x94EA20", VA = "0x180950420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort LLGKIMJLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x62F42F0", Offset = "0x62F28F0", VA = "0x1862F42F0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x62F4310", Offset = "0x62F2910", VA = "0x1862F4310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort CFAEIPNCHGO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x62F42E0", Offset = "0x62F28E0", VA = "0x1862F42E0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x62F4390", Offset = "0x62F2990", VA = "0x1862F4390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort KKHCPCCAGDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xC7EB00", Offset = "0xC7D100", VA = "0x180C7EB00")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xC7EC60", Offset = "0xC7D260", VA = "0x180C7EC60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort IDKCEILNBLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x62F46A0", Offset = "0x62F2CA0", VA = "0x1862F46A0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x62F3E50", Offset = "0x62F2450", VA = "0x1862F3E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool MBLNODJLLHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x1573F10", Offset = "0x1572510", VA = "0x181573F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool PIGIJMPFCOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xD36510", Offset = "0xD34B10", VA = "0x180D36510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event BHLAFMNIMNB FFGPJODNCKA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x62F4450", Offset = "0x62F2A50", VA = "0x1862F4450")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x62F4240", Offset = "0x62F2840", VA = "0x1862F4240")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x62F4190", Offset = "0x62F2790", VA = "0x1862F4190")]
	private T CDOJPIOLPBG(ushort OKFPOGHDMMF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x62F3E60", Offset = "0x62F2460", VA = "0x1862F3E60")]
	private T AKKIEFCECFP(ushort OKFPOGHDMMF, ushort EDFKFMIILHD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x62F46B0", Offset = "0x62F2CB0", VA = "0x1862F46B0")]
	protected T OHPOHIJGGBF(uint IHPDNFMIHPP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x62F4720", Offset = "0x62F2D20", VA = "0x1862F4720")]
	protected DAKKCFAFGBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x62F4600", Offset = "0x62F2C00", VA = "0x1862F4600")]
	public void LMCBACGBCHJ(ushort IFPMJFLCNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x62F4640", Offset = "0x62F2C40", VA = "0x1862F4640")]
	public void LMCBACGBCHJ(ushort IFPMJFLCNLG, ushort FHMLGPIJOCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x62F44F0", Offset = "0x62F2AF0", VA = "0x1862F44F0", Slot = "4")]
	protected virtual void LMCBACGBCHJ(uint AGNMOKIJEOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x62F3620", Offset = "0x62F1C20", VA = "0x1862F3620")]
	protected void ACHANLKDFBK(uint AGNMOKIJEOC, uint JOKBIJBKGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x62F43A0", Offset = "0x62F29A0", VA = "0x1862F43A0")]
	protected void IPFBACIIBJE(ushort OKFPOGHDMMF, ushort EDFKFMIILHD, T CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x62F4330", Offset = "0x62F2930", VA = "0x1862F4330")]
	private void IJDMKHAFAIJ(uint IHPDNFMIHPP, T CEGAGHAOIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x62F3F20", Offset = "0x62F2520", VA = "0x1862F3F20")]
	protected void BIHOJMHMDPD(float HIBCBLOKLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x62F4320", Offset = "0x62F2920", VA = "0x1862F4320")]
	protected uint GJFMCBEBKLG(ushort OKFPOGHDMMF, ushort EDFKFMIILHD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x62F4710", Offset = "0x62F2D10", VA = "0x1862F4710")]
	protected ushort PPIAEHPEEAI(uint MJPHEMOABKG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x62F4300", Offset = "0x62F2900", VA = "0x1862F4300")]
	protected ushort EHNEMBOLLJF(uint MJPHEMOABKG)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public abstract class AEJNPLOBCCL : DAKKCFAFGBP<AEJNPLOBCCL.LGCMODGLHIF>
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class LGCMODGLHIF : IKNOCHLMCII
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public EINKAOFFLAO LPIHLPMKEOD
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x950400", Offset = "0x94EA00", VA = "0x180950400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public EINKAOFFLAO NDJPEGCHKDC
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x9529B0", Offset = "0x950FB0", VA = "0x1809529B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public OAKIALGBHFD ICGOBMKAMEM
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x952A00", Offset = "0x951000", VA = "0x180952A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public LGCMODGLHIF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x74C6720", Offset = "0x74C4D20", VA = "0x1874C6720")]
	public void KEMONPFHHHH(ushort CIADLKNJPHH, EINKAOFFLAO NCPALIAHJPF, EINKAOFFLAO JGHKOICLLNP, OAKIALGBHFD OCIEANDEEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x74C6640", Offset = "0x74C4C40", VA = "0x1874C6640")]
	public void KEMONPFHHHH(ushort OKFPOGHDMMF, ushort EDFKFMIILHD, EINKAOFFLAO NCPALIAHJPF, EINKAOFFLAO JGHKOICLLNP, OAKIALGBHFD OCIEANDEEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x74C6800", Offset = "0x74C4E00", VA = "0x1874C6800")]
	public void PLJNMJIHBJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x74C6850", Offset = "0x74C4E50", VA = "0x1874C6850")]
	protected AEJNPLOBCCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class GGAINOJCJPJ : AEJNPLOBCCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool LAMMAOBONGB;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool KFMLNKJFEGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE930", Offset = "0xAACF30", VA = "0x180AAE930")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xBA6DE0", Offset = "0xBA53E0", VA = "0x180BA6DE0")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x74C8F50", Offset = "0x74C7550", VA = "0x1874C8F50")]
	public void HPHCPPKCEKM(ushort DHFNAGBHKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x74C8EF0", Offset = "0x74C74F0", VA = "0x1874C8EF0")]
	public void HPHCPPKCEKM(ushort DHFNAGBHKCH, ushort PPGMGOEEPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x74C6850", Offset = "0x74C4E50", VA = "0x1874C6850")]
	public GGAINOJCJPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public abstract class PICBGAGJNIG<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	internal class FKIKCCJFACP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TNode JDCFMPOHCEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TNode LDIAONMHHPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public NJANMHNOOBK ADMEOFCKKPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public List<NJANMHNOOBK> CFBMIKMKDIH;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public FKIKCCJFACP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal struct NJANMHNOOBK : IComparable<NJANMHNOOBK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int DKBNIPNLNJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TClaimant JKOEKMKNDNK;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x1445330", Offset = "0x1443930", VA = "0x181445330")]
		public NJANMHNOOBK(int DKBNIPNLNJH, TClaimant JKOEKMKNDNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4ED91E0", Offset = "0x4ED77E0", VA = "0x184ED91E0")]
		public bool NMBIEENKKPK([In] NJANMHNOOBK OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4ED91D0", Offset = "0x4ED77D0", VA = "0x184ED91D0")]
		public bool JJCMBCBBCMP([In] NJANMHNOOBK OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4ED91C0", Offset = "0x4ED77C0", VA = "0x184ED91C0", Slot = "4")]
		public int CompareTo(NJANMHNOOBK OKCHLIEAIJP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4ED9240", Offset = "0x4ED7840", VA = "0x184ED9240", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public enum LJIDILOJHOK
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class IIOPCEOKEGJ : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public PICBGAGJNIG<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0xD37BA0", Offset = "0xD361A0", VA = "0x180D37BA0")]
		[DebuggerHidden]
		public IIOPCEOKEGJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x477A640", Offset = "0x4778C40", VA = "0x18477A640", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x477A820", Offset = "0x4778E20", VA = "0x18477A820", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x477A720", Offset = "0x4778D20", VA = "0x18477A720", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x441D640", Offset = "0x441BC40", VA = "0x18441D640", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly AJBFHMILPDB<FKIKCCJFACP> CGIHKOAOOJC;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly AJBFHMILPDB<List<NJANMHNOOBK>> EAOIGOKOCOF;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static int AMKCELBMEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	internal readonly Dictionary<TClaimant, TNode> LANFLIBPLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	internal readonly Dictionary<TNode, FKIKCCJFACP> MOAGJPKCEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private LJIDILOJHOK OALDHMLLKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool NLNPPHMOFNH;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode KLKMJAGJCKK(TNode HPEELAFENFB);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void DFBIJAGPPCN(TNode HPEELAFENFB, TClaimant NEHMBMIMNKH, TClaimant LLFJOPCPFHM);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5101940", Offset = "0x50FFF40", VA = "0x185101940")]
	public PICBGAGJNIG(LJIDILOJHOK OALDHMLLKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5101530", Offset = "0x50FFB30", VA = "0x185101530")]
	public void PEJJKFLMNFP(TNode HPEELAFENFB, TNode DFDGPBFKIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x51015F0", Offset = "0x50FFBF0", VA = "0x1851015F0")]
	public void PJFPMNEHKKB(TClaimant JKOEKMKNDNK, TNode HFAHJLIIBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x51005C0", Offset = "0x50FEBC0", VA = "0x1851005C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5101050", Offset = "0x50FF650", VA = "0x185101050")]
	private void HKMGMAFFMGP(TClaimant JKOEKMKNDNK, TNode IIOJHGIDFCI, TNode HFAHJLIIBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5101340", Offset = "0x50FF940", VA = "0x185101340")]
	private int NAPHNGLPKIM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x51007D0", Offset = "0x50FEDD0", VA = "0x1851007D0")]
	private void EJKHFKJJJJH(TClaimant JKOEKMKNDNK, TNode NFKKFDNNPKM, TNode LGNIHKABDBC, int KGNBOIDKMCM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5101120", Offset = "0x50FF720", VA = "0x185101120")]
	private void JCINDLAKIDB(NJANMHNOOBK BPCNLEDMJDA, FKIKCCJFACP NAKBEFGIDDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x51000B0", Offset = "0x50FE6B0", VA = "0x1851000B0")]
	private void BACMLELPLKC(TClaimant JKOEKMKNDNK, TNode NFKKFDNNPKM, TNode LGNIHKABDBC, int KGNBOIDKMCM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x51003A0", Offset = "0x50FE9A0", VA = "0x1851003A0")]
	private void BLOBELNOFNA(NJANMHNOOBK BPCNLEDMJDA, TNode HPEELAFENFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x50FFE40", Offset = "0x50FE440", VA = "0x1850FFE40")]
	private void ACGCNMJOKIA(NJANMHNOOBK BPCNLEDMJDA, FKIKCCJFACP NAKBEFGIDDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x51011F0", Offset = "0x50FF7F0", VA = "0x1851011F0")]
	private void MADANCLEBBP(FKIKCCJFACP NAKBEFGIDDJ, bool NLKOBGGEIMF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5100B20", Offset = "0x50FF120", VA = "0x185100B20")]
	private void FPHPFPBOKHE(FKIKCCJFACP NAKBEFGIDDJ, TNode DFDGPBFKIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x51004D0", Offset = "0x50FEAD0", VA = "0x1851004D0")]
	[IteratorStateMachine(typeof(PICBGAGJNIG<, >.IIOPCEOKEGJ))]
	private IEnumerable<TNode> DBFGGGNKHGG(TNode NFKKFDNNPKM, TNode LGNIHKABDBC, bool PKMICHNDCGL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x50FFFA0", Offset = "0x50FE5A0", VA = "0x1850FFFA0")]
	private FKIKCCJFACP ANNALDKIKAC(TNode HPEELAFENFB, TNode LDIAONMHHPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x51013B0", Offset = "0x50FF9B0", VA = "0x1851013B0")]
	private FKIKCCJFACP NGIHEAHDIPB(TNode HPEELAFENFB, TNode LDIAONMHHPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5100E90", Offset = "0x50FF490", VA = "0x185100E90")]
	private void HDEHJDBLMBN(FKIKCCJFACP NAKBEFGIDDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class PGPEJIODKCL<T> : IEnumerable<PGPEJIODKCL<T>.DCGOPFJHPKF>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public struct DCGOPFJHPKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public T KBGCCIOIGBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int EAHKFAJBNDN;
	}

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class CIKENNBOJCK : IEnumerator<DCGOPFJHPKF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private PGPEJIODKCL<T> JAGFBALGAPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int EAHKFAJBNDN;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x40829F0", Offset = "0x4080FF0", VA = "0x1840829F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public DCGOPFJHPKF FJMLFGNPDDN
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x5B5C870", Offset = "0x5B5AE70", VA = "0x185B5C870", Slot = "4")]
			get
			{
				return default(DCGOPFJHPKF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x5B5C830", Offset = "0x5B5AE30", VA = "0x185B5C830")]
		public CIKENNBOJCK(PGPEJIODKCL<T> JAGFBALGAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x5B5C7B0", Offset = "0x5B5ADB0", VA = "0x185B5C7B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x40DE910", Offset = "0x40DCF10", VA = "0x1840DE910", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xF6DAD0", Offset = "0xF6C0D0", VA = "0x180F6DAD0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private struct POKEHHHPNHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool HGOPPLOOAPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public T KBGCCIOIGBD;
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int PCLJNJBMHKB = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<T, int> OMFDHAFAIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private POKEHHHPNHH[] AJIIGDCKFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int DONFGMMIDKK;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int FPHPIECAIFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x991F60", Offset = "0x990560", VA = "0x180991F60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x9915B0", Offset = "0x98FBB0", VA = "0x1809915B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x3D45830", Offset = "0x3D43E30", VA = "0x183D45830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x50E5C70", Offset = "0x50E4270", VA = "0x1850E5C70")]
	public PGPEJIODKCL(int CCAKDDNOMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x50E5420", Offset = "0x50E3A20", VA = "0x1850E5420")]
	public PGPEJIODKCL(DCGOPFJHPKF[] HHKLNILIGOD, bool ACLMJHMHDLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x50E52C0", Offset = "0x50E38C0", VA = "0x1850E52C0")]
	public int ONEFCEBIMHF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x50E4570", Offset = "0x50E2B70", VA = "0x1850E4570")]
	private int BGJEACAGHHB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x50E4A40", Offset = "0x50E3040", VA = "0x1850E4A40", Slot = "6")]
	protected virtual uint DPOHEDINKDL(uint MGPEIJNPFNJ, T KBGCCIOIGBD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x50E5200", Offset = "0x50E3800", VA = "0x1850E5200")]
	public bool NKNKPAELMGK(T KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x50E5100", Offset = "0x50E3700", VA = "0x1850E5100")]
	public int MJGCPNEONAH(T KBGCCIOIGBD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x50E5040", Offset = "0x50E3640", VA = "0x1850E5040")]
	public T KBDHOHCCAKN(int EAHKFAJBNDN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x50E4F90", Offset = "0x50E3590", VA = "0x1850E4F90")]
	public bool HFHDPLKFOBI(T KBGCCIOIGBD, bool LBHIBNMEMDO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x50E4D30", Offset = "0x50E3330", VA = "0x1850E4D30")]
	public bool HFHDPLKFOBI(T KBGCCIOIGBD, int EAHKFAJBNDN, bool LBHIBNMEMDO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x50E49A0", Offset = "0x50E2FA0", VA = "0x1850E49A0")]
	private int COENKJHHILC(int EKDINNHMJFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x50E5380", Offset = "0x50E3980", VA = "0x1850E5380", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x50E5380", Offset = "0x50E3980", VA = "0x1850E5380", Slot = "4")]
	private IEnumerator<DCGOPFJHPKF> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class AJBFHMILPDB<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly Stack<T> DFPGJPGNKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<T> FKPHPEFFEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly int FPCEEBAJBNG;

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x48B2060", Offset = "0x48B0660", VA = "0x1848B2060")]
	public static AJBFHMILPDB<T> OEIHPKOBFOJ(int CCAKDDNOMFJ = 0, int FPCEEBAJBNG = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x48B18E0", Offset = "0x48AFEE0", VA = "0x1848B18E0")]
	public static AJBFHMILPDB<T> CJOFJODOHHJ(int CCAKDDNOMFJ = 0, int FPCEEBAJBNG = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x48B2360", Offset = "0x48B0960", VA = "0x1848B2360")]
	public AJBFHMILPDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x48B2150", Offset = "0x48B0750", VA = "0x1848B2150")]
	public AJBFHMILPDB(int CCAKDDNOMFJ, int FPCEEBAJBNG = int.MaxValue, bool COHEDEOGLPL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x48B1E90", Offset = "0x48B0490", VA = "0x1848B1E90")]
	public T OCHIEBOHGDJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x48B1800", Offset = "0x48AFE00", VA = "0x1848B1800")]
	public void BHDLIGCHPAN(T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x48B19D0", Offset = "0x48AFFD0", VA = "0x1848B19D0")]
	private void DBNKIGOEFLK(T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x48B1E50", Offset = "0x48B0450", VA = "0x1848B1E50")]
	private void MHHILEHAPLK(T KBGCCIOIGBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x48B1AD0", Offset = "0x48B00D0", VA = "0x1848B1AD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x48B1C60", Offset = "0x48B0260", VA = "0x1848B1C60")]
	private void KMPFLKCFILD(IEnumerable<T> BMKDAHEBDHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class CNFJEBJIPCB<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Dictionary<int, T> EIEEOCBNIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private T ENDNLINEDDD;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T DCEJFAOFMGL
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x9529B0", Offset = "0x950FB0", VA = "0x1809529B0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5C48950", Offset = "0x5C46F50", VA = "0x185C48950")]
	public bool FJAEOODAFCM(T KBGCCIOIGBD, int DKBNIPNLNJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x44317E0", Offset = "0x442FDE0", VA = "0x1844317E0")]
	public bool OANKGFLJIAB(int DKBNIPNLNJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x5C48AF0", Offset = "0x5C470F0", VA = "0x185C48AF0")]
	public T IPIHAOGMIFO(int LKLLMHOCFFN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x5C48F30", Offset = "0x5C47530", VA = "0x185C48F30")]
	private bool MFBCGPJFHLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x5C48A90", Offset = "0x5C47090", VA = "0x185C48A90")]
	public bool GMJNAAAPBAP(int DKBNIPNLNJH, [Out] T KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x49D6950", Offset = "0x49D4F50", VA = "0x1849D6950")]
	public CNFJEBJIPCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class BFMAEEMINOB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	protected struct DCPOINHHOFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T DEDOPNLMLPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int MOEAGHOMEOM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	protected readonly List<DCPOINHHOFI> ONOIJFJJLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private T MIEJMJEFGAG;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x3D45830", Offset = "0x3D43E30", VA = "0x183D45830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x589F370", Offset = "0x589D970", VA = "0x18589F370")]
	public bool HBIAGPPOPJF(T KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x589F1E0", Offset = "0x589D7E0", VA = "0x18589F1E0")]
	public void HBHDBABAKDP(T KBGCCIOIGBD, int DKBNIPNLNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x589F930", Offset = "0x589DF30", VA = "0x18589F930")]
	public bool OCDDHDAHAOD(T KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x589F760", Offset = "0x589DD60", VA = "0x18589F760")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x589F800", Offset = "0x589DE00", VA = "0x18589F800")]
	public T NFIEKFOCNHN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x589EEE0", Offset = "0x589D4E0", VA = "0x18589EEE0")]
	protected void DEDAIFKIBLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x589FCA0", Offset = "0x589E2A0", VA = "0x18589FCA0")]
	public BFMAEEMINOB()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x74CAD40", Offset = "0x74C9340", VA = "0x1874CAD40")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x74CB010", Offset = "0x74C9610", VA = "0x1874CB010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x74CAF20", Offset = "0x74C9520", VA = "0x1874CAF20")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x74CAC90", Offset = "0x74C9290", VA = "0x1874CAC90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x74CAF60", Offset = "0x74C9560", VA = "0x1874CAF60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x74CAE70", Offset = "0x74C9470", VA = "0x1874CAE70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x74CAC00", Offset = "0x74C9200", VA = "0x1874CAC00")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x52E10B0", Offset = "0x52DF6B0", VA = "0x1852E10B0", Slot = "4")]
		public virtual T MHOIHENGDGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class LPKAAIKFLNI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private Dictionary<byte, HOFCLBIMKMP> MMCOFDGFOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly AJBFHMILPDB<HOFCLBIMKMP> MEMHKMJDHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly bool DLJLEONFJLL;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public HOFCLBIMKMP AOPEGNLNMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x950400", Offset = "0x94EA00", VA = "0x180950400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector2 EJLKDNEFCCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x13BD080", Offset = "0x13BB680", VA = "0x1813BD080")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0xAF2910", Offset = "0xAF0F10", VA = "0x180AF2910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	private Vector2 LOHJCFHFMDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xB65960", Offset = "0xB63F60", VA = "0x180B65960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector2 DGJJMMMIMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x74CAA30", Offset = "0x74C9030", VA = "0x1874CAA30")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x956CB0", Offset = "0x9552B0", VA = "0x180956CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int CNFEKDNCACP
	{
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x952DE0", Offset = "0x9513E0", VA = "0x180952DE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x9529F0", Offset = "0x950FF0", VA = "0x1809529F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x74CAA50", Offset = "0x74C9050", VA = "0x1874CAA50")]
	public LPKAAIKFLNI(Bounds FDAECNIODOF, Vector2[] DOIDPIABCIK, int CGIELBEDAIP, byte EKDINNHMJFC, float JNPIENLKIAC = 0f, [Optional] AJBFHMILPDB<HOFCLBIMKMP> MEMHKMJDHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x74C9FA0", Offset = "0x74C85A0", VA = "0x1874C9FA0")]
	public void GOIAGOGDGCF(Bounds FDAECNIODOF, Vector2[] DOIDPIABCIK, int CGIELBEDAIP, byte EKDINNHMJFC, float JNPIENLKIAC = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x74C9EE0", Offset = "0x74C84E0", VA = "0x1874C9EE0")]
	public HOFCLBIMKMP FHPKHIFPBJH(byte EAHKFAJBNDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x74CA740", Offset = "0x74C8D40", VA = "0x1874CA740")]
	public void OIELBLCHPLG(Vector3 NDADPNJPMFO, float PDMGANPIBAC, float FDEKCLGIEMI, List<byte> FCOHHBGCDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x74C9AA0", Offset = "0x74C80A0", VA = "0x1874C9AA0")]
	public void CJOBFEBKEJP(HOFCLBIMKMP.KKPNHGHEJBM DHLKILMAGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x74CA430", Offset = "0x74C8A30", VA = "0x1874CA430")]
	public static int HNEMHCGCKBP(Vector2[] DOIDPIABCIK, int CGIELBEDAIP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x74CA510", Offset = "0x74C8B10", VA = "0x1874CA510")]
	private HOFCLBIMKMP LHFNIEHFMGF(byte EAHKFAJBNDN, HOFCLBIMKMP.IGKMPIOBMHD FMLNOLNOIMH, HOFCLBIMKMP LDIAONMHHPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x74C9AC0", Offset = "0x74C80C0", VA = "0x1874C9AC0")]
	private void CNNPJDDEEOP(HOFCLBIMKMP LDIAONMHHPK, Vector2[] DOIDPIABCIK, int BDPBAFOOBGN, int OOEBPLCDDAC, int MNLODGJEKPF, int INJDBOOGMEN, float JNPIENLKIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x74CA810", Offset = "0x74C8E10", VA = "0x1874CA810")]
	private void OMJNJIDJPGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x74C9E80", Offset = "0x74C8480", VA = "0x1874C9E80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x74C9F40", Offset = "0x74C8540", VA = "0x1874C9F40", Slot = "1")]
	~LPKAAIKFLNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class HOFCLBIMKMP
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public enum IGKMPIOBMHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public enum KKPNHGHEJBM
	{
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public byte AOALABMLPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public Vector3 IOLANELHHKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public Vector3 NGPEAGCEMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public Vector3 JLBFGLPGLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public Vector3 KKLMMMJNMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public IGKMPIOBMHD OBJIKJPGLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public HOFCLBIMKMP IACMILFIJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public List<HOFCLBIMKMP> LCGCPHCKLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public bool OLGCHCDLLFP;

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x74C9720", Offset = "0x74C7D20", VA = "0x1874C9720")]
	public HOFCLBIMKMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x74C92C0", Offset = "0x74C78C0", VA = "0x1874C92C0")]
	public void FCMEIMELBLA(HOFCLBIMKMP DJHFBAMKFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60")]
	public void CJOBFEBKEJP(int DKHHCALAOBL, KKPNHGHEJBM DHLKILMAGOF, int IEDDIGKIIBL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x74C94C0", Offset = "0x74C7AC0", VA = "0x1874C94C0")]
	public void OIELBLCHPLG(List<byte> FCOHHBGCDNA, Vector3 NDADPNJPMFO, float PDMGANPIBAC, float FDEKCLGIEMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x74C9290", Offset = "0x74C7890", VA = "0x1874C9290")]
	public bool CGONKALIBHI(Vector3 ILGJMEDBDKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x74C9490", Offset = "0x74C7A90", VA = "0x1874C9490")]
	public bool JJDGOOHGPBK(Vector3 ILGJMEDBDKJ, float AHDGNGLLOEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x74C9400", Offset = "0x74C7A00", VA = "0x1874C9400")]
	public void HPHCPPKCEKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public interface BAMPFGJHMOM
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	ToolHierarchyCache HEKOHKIMFFE
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200007B")]
		public struct BIOJDIAIJFO<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private readonly List<Component> BHMKCPLLJPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private readonly bool CBEDACPCFBF;

			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x15917E0", Offset = "0x158FDE0", VA = "0x1815917E0")]
			public BIOJDIAIJFO(List<Component> BHMKCPLLJPF, bool CBEDACPCFBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x58A7590", Offset = "0x58A5B90", VA = "0x1858A7590")]
			public GDKKAEEJNLB<T> BNIMLGJMJBK()
			{
				return default(GDKKAEEJNLB<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x58A75F0", Offset = "0x58A5BF0", VA = "0x1858A75F0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x58A75F0", Offset = "0x58A5BF0", VA = "0x1858A75F0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public struct GDKKAEEJNLB<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			private readonly List<Component> BHMKCPLLJPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			private readonly bool CBEDACPCFBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private int EAHKFAJBNDN;

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public T FJMLFGNPDDN
			{
				[Cpp2IlInjected.Token(Token = "0x6000261")]
				[Cpp2IlInjected.Address(RVA = "0x44DB440", Offset = "0x44D9A40", VA = "0x1844DB440", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x44DB3D0", Offset = "0x44D99D0", VA = "0x1844DB3D0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x44DB410", Offset = "0x44D9A10", VA = "0x1844DB410")]
			public GDKKAEEJNLB(List<Component> BHMKCPLLJPF, bool CBEDACPCFBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x44DB310", Offset = "0x44D9910", VA = "0x1844DB310", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x44DB320", Offset = "0x44D9920", VA = "0x1844DB320", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x40D0BC0", Offset = "0x40CF1C0", VA = "0x1840D0BC0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x74CCA30", Offset = "0x74CB030", VA = "0x1874CCA30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x74CC790", Offset = "0x74CAD90", VA = "0x1874CC790")]
		private void HPHCPPKCEKM(GameObject CLIDGPLIAOB, bool MHOOEDPKADD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x74CC900", Offset = "0x74CAF00", VA = "0x1874CC900")]
		public static void HPHCPPKCEKM(GameObject CLIDGPLIAOB, ToolHierarchyCache HIDLDGNDFHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x74CC990", Offset = "0x74CAF90", VA = "0x1874CC990")]
		public void MKCIDOLIGBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x3790330", Offset = "0x378E930", VA = "0x183790330")]
		public void GFKOOFNGMHP<T>(Action<T> PJDAFKMDDCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x3790570", Offset = "0x378EB70", VA = "0x183790570")]
		public T NHKPAFEOOFH<T>(bool CBEDACPCFBF = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x3790270", Offset = "0x378E870", VA = "0x183790270")]
		public BIOJDIAIJFO<T> GALDFEKGHJG<T>(bool CBEDACPCFBF = false) where T : class
		{
			return default(BIOJDIAIJFO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x74CC350", Offset = "0x74CA950", VA = "0x1874CC350")]
		public List<Component> DNIMOIANDDG(Type BMIPLDLMPCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x74CC6A0", Offset = "0x74CACA0", VA = "0x1874CC6A0", Slot = "4")]
		public bool Equals(ToolHierarchyCache IKAEODCKAIP, ToolHierarchyCache ACCJFOPIMAB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x74CC720", Offset = "0x74CAD20", VA = "0x1874CC720", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache GMFKPONAANG)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class AACAJIHHNEA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int CCAKDDNOMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int GNBNOAIPBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private List<T> BHJLHIOPPEJ;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x457C180", Offset = "0x457A780", VA = "0x18457C180")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T ELELLAAAAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x457C0B0", Offset = "0x457A6B0", VA = "0x18457C0B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T AMAEKDFPONF
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x457BF00", Offset = "0x457A500", VA = "0x18457BF00")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T DBMKPKCKAOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x457BD30", Offset = "0x457A330", VA = "0x18457BD30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x457C230", Offset = "0x457A830", VA = "0x18457C230")]
	public AACAJIHHNEA(int CCAKDDNOMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x457BB60", Offset = "0x457A160", VA = "0x18457BB60")]
	public void HBHDBABAKDP(T HLNLKLPFHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x457BEA0", Offset = "0x457A4A0", VA = "0x18457BEA0")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x457BDB0", Offset = "0x457A3B0", VA = "0x18457BDB0")]
	public void JPKAOKHGGJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x457C1D0", Offset = "0x457A7D0", VA = "0x18457C1D0")]
	public void POLABFEHBLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x457BA00", Offset = "0x457A000", VA = "0x18457BA00")]
	public void BCHAADBEKFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x457B970", Offset = "0x4579F70", VA = "0x18457B970")]
	public List<T> BBIMDPLNOCD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class GJKLJJDNPDD<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	private struct FFBJODABCDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public int MOEAGHOMEOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public T DEDOPNLMLPL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly Dictionary<object, FFBJODABCDC> EIEEOCBNIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly EqualityComparer<T> NIIKEIGHEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T ENDNLINEDDD;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public virtual T DCEJFAOFMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0xBCBF80", Offset = "0xBCA580", VA = "0x180BCBF80", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x45580A0", Offset = "0x45566A0", VA = "0x1845580A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool EBCBNNJAAMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x455C540", Offset = "0x455AB40", VA = "0x18455C540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public object MDKHHJCKLPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x954BC0", Offset = "0x9531C0", VA = "0x180954BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x954470", Offset = "0x952A70", VA = "0x180954470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x4558720", Offset = "0x4556D20", VA = "0x184558720")]
	public bool FJAEOODAFCM(T KBGCCIOIGBD, object LAAJFAFNFCN, int DKBNIPNLNJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x455C5A0", Offset = "0x455ABA0", VA = "0x18455C5A0")]
	public bool OANKGFLJIAB(object LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x4558FA0", Offset = "0x45575A0", VA = "0x184558FA0")]
	public bool GMJNAAAPBAP(object LAAJFAFNFCN, [Out] T KBGCCIOIGBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x45597B0", Offset = "0x4557DB0", VA = "0x1845597B0")]
	public void KKIOKOIHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x4559E60", Offset = "0x4558460", VA = "0x184559E60")]
	private bool MFBCGPJFHLP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x455C660", Offset = "0x455AC60", VA = "0x18455C660")]
	public GJKLJJDNPDD()
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
