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
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69848A0", Offset = "0x6982EA0", VA = "0x1869848A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x888570", Offset = "0x886B70", VA = "0x180888570")]
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
		[Cpp2IlInjected.Address(RVA = "0x8885B0", Offset = "0x886BB0", VA = "0x1808885B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class AFHHLCLFGBH : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x15B7D00", Offset = "0x15B6300", VA = "0x1815B7D00")]
	public AFHHLCLFGBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, FDEOFPEJOOF, HGJOFNIJINE, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85F4B0", Offset = "0x85DAB0", VA = "0x18085F4B0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x85F460", Offset = "0x85DA60", VA = "0x18085F460", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x98BFE0", Offset = "0x98A5E0", VA = "0x18098BFE0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash CMIFMCLDAIC);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x942CD0", Offset = "0x9412D0", VA = "0x180942CD0")]
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
	[SerializeField]
	[HideInInspector]
	[ReadOnlyField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6985B60", Offset = "0x6984160", VA = "0x186985B60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6985B20", Offset = "0x6984120", VA = "0x186985B20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6985BA0", Offset = "0x69841A0", VA = "0x186985BA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6985D50", Offset = "0x6984350", VA = "0x186985D50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6985CC0", Offset = "0x69842C0", VA = "0x186985CC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9A4C70", Offset = "0x9A3270", VA = "0x1809A4C70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9A4C60", Offset = "0x9A3260", VA = "0x1809A4C60")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6985AE0", Offset = "0x69840E0", VA = "0x186985AE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6985C30", Offset = "0x6984230", VA = "0x186985C30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6985550", Offset = "0x6983B50", VA = "0x186985550")]
	public void CopyBounds(SavedExtents OGEIJLCLBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6985A30", Offset = "0x6984030", VA = "0x186985A30")]
	public void SetLocalSpaceBounds(Bounds JHDCGCOBPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xC865C0", Offset = "0xC84BC0", VA = "0x180C865C0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6985A20", Offset = "0x6984020", VA = "0x186985A20")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6985580", Offset = "0x6983B80", VA = "0x186985580")]
	private void FGBKNGDPLNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6985800", Offset = "0x6983E00", VA = "0x186985800")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6984F10", Offset = "0x6983510", VA = "0x186984F10")]
	public static void CalculateLocalBoundsFor(GameObject BBKKNFIIKNJ, [Out] Bounds JHDCGCOBPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6985740", Offset = "0x6983D40", VA = "0x186985740")]
	private static void OEHKFIMONIB(Bounds PNLANOPNMAC, Color EIFPFLKPFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6985A50", Offset = "0x6984050", VA = "0x186985A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x85D1A0", Offset = "0x85B7A0", VA = "0x18085D1A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x85F4A0", Offset = "0x85DAA0", VA = "0x18085F4A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x10B55A0", Offset = "0x10B3BA0", VA = "0x1810B55A0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4A2A250", Offset = "0x4A28850", VA = "0x184A2A250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "4")]
	public virtual void LJOHGMOKMAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
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
	[AFHHLCLFGBH]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4A29D80", Offset = "0x4A28380", VA = "0x184A29D80", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4A28460", Offset = "0x4A26A60", VA = "0x184A28460", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4A2A140", Offset = "0x4A28740", VA = "0x184A2A140")]
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
	private sealed class BHOKGGMEADP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public BHOKGGMEADP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4F1CE00", Offset = "0x4F1B400", VA = "0x184F1CE00")]
		internal int DHLBMAMPMMA(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[AFHHLCLFGBH]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x381D1D0", Offset = "0x381B7D0", VA = "0x18381D1D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x381D230", Offset = "0x381B830", VA = "0x18381D230", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x381D0A0", Offset = "0x381B6A0", VA = "0x18381D0A0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey MNBFPOFIDHA]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x381D160", Offset = "0x381B760", VA = "0x18381D160", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x381CF40", Offset = "0x381B540", VA = "0x18381CF40", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x381CBE0", Offset = "0x381B1E0", VA = "0x18381CBE0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x381BFA0", Offset = "0x381A5A0", VA = "0x18381BFA0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x381BF40", Offset = "0x381A540", VA = "0x18381BF40", Slot = "14")]
	protected virtual string LAAMEEOPPBE(TKeyVal NGLGOJFDCHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x381BE00", Offset = "0x381A400", VA = "0x18381BE00", Slot = "4")]
	public bool ContainsKey(TKey MNBFPOFIDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x381CDB0", Offset = "0x381B3B0", VA = "0x18381CDB0", Slot = "5")]
	public bool TryGetValue(TKey MNBFPOFIDHA, [Out] TVal FEBGGALLBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x381BE60", Offset = "0x381A460", VA = "0x18381BE60", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x381BE60", Offset = "0x381A460", VA = "0x18381BE60", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x381CE10", Offset = "0x381B410", VA = "0x18381CE10")]
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
	[SerializeReference]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x85D1B0", Offset = "0x85B7B0", VA = "0x18085D1B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x85F4B0", Offset = "0x85DAB0", VA = "0x18085F4B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3CD9BE0", Offset = "0x3CD81E0", VA = "0x183CD9BE0")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[AFHHLCLFGBH]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4A2B4B0", Offset = "0x4A29AB0", VA = "0x184A2B4B0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4A2AA30", Offset = "0x4A29030", VA = "0x184A2AA30", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4A2A140", Offset = "0x4A28740", VA = "0x184A2A140")]
	protected SerializedReferenceDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EGJCNJONBMD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class NJHEPNOJOFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float HDINCNEOFLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T MDPJKNKDANF;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public NJHEPNOJOFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class AMPKLEOFHLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public AMPKLEOFHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3D83B40", Offset = "0x3D82140", VA = "0x183D83B40")]
		internal bool PJNMLMNBNLO(NJHEPNOJOFK sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly float JPFLLKEAIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly float JJNAKADPAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private List<NJHEPNOJOFK> IMOHMEMBPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private NFELCFMNOIH<NJHEPNOJOFK> BKMPJBDFGIM;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int BBGBLIMOEJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x37EB5E0", Offset = "0x37E9BE0", VA = "0x1837EB5E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x37EBD10", Offset = "0x37EA310", VA = "0x1837EBD10")]
	public EGJCNJONBMD(float ELGMNOKMKND, float MKPADNIABEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x37EB8A0", Offset = "0x37E9EA0", VA = "0x1837EB8A0")]
	public bool KAMAJBEHPKD(float ECKAMDKCMCB, T FEBGGALLBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x37EAEA0", Offset = "0x37E94A0", VA = "0x1837EAEA0")]
	public IEnumerable<T> GHEKPOBHPNP(float ECKAMDKCMCB, [Optional] float? PDCMNHNNCFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x37EBA90", Offset = "0x37EA090", VA = "0x1837EBA90")]
	public void KFLPEIEEDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x37EBB50", Offset = "0x37EA150", VA = "0x1837EBB50")]
	private void OCAJNCNPPHB(float ECKAMDKCMCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class GBLMHEBBHAF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct NPNBLABBDCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public T MDPJKNKDANF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public float CPBLIPMHMEN;
	}

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static float JHDDAONLAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private List<T> BPLMHJBOIOC;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const int BEIHAHGJJEC = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NPNBLABBDCF[] NMHOKLPDKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int HCKKMFBHGCH;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float KBOBBGOGEEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA988E0", Offset = "0xA96EE0", VA = "0x180A988E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAB03B0", Offset = "0xAAE9B0", VA = "0x180AB03B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0E90", Offset = "0x3CBF490", VA = "0x183CC0E90")]
	public GBLMHEBBHAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0ED0", Offset = "0x3CBF4D0", VA = "0x183CC0ED0")]
	public GBLMHEBBHAF(int PPOFLGDKIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3CBFE70", Offset = "0x3CBE470", VA = "0x183CBFE70")]
	public void AGMNBECNIJC(float ECKAMDKCMCB, T FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0C60", Offset = "0x3CBF260", VA = "0x183CC0C60")]
	public void KFLPEIEEDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0A00", Offset = "0x3CBF000", VA = "0x183CC0A00")]
	public bool KBHLNHIMADO(float CIOIJMFDMLL, float EBBCEECIMAI, [Out] T FEBGGALLBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3CC01E0", Offset = "0x3CBE7E0", VA = "0x183CC01E0")]
	public bool CAKEAFNDNBC(float CIOIJMFDMLL, float EBBCEECIMAI, [Out] T FEBGGALLBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0400", Offset = "0x3CBEA00", VA = "0x183CC0400")]
	public void FPDIAPEGKLO(float CIOIJMFDMLL, float EBBCEECIMAI, List<T> KGHDKIBNGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3CBFF80", Offset = "0x3CBE580", VA = "0x183CBFF80")]
	private int AOKEBKKBCKG(int OLINDBDGOBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3CC03B0", Offset = "0x3CBE9B0", VA = "0x183CC03B0")]
	private void EGCKHFLAJEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T KFIJAAIBOJJ();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T KFJELKBPBIE(T FEBGGALLBNN, float GJMDIBEDCBL);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T CGICGNAPDOP(T MIGBCLGIEPA, T MMACHIKDDMH);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T OEKJKHGKJHD(T MIGBCLGIEPA, T MMACHIKDDMH);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class EEBCFINGKID : GBLMHEBBHAF<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x86DB80", Offset = "0x86C180", VA = "0x18086DB80", Slot = "4")]
	protected override Vector3 KFIJAAIBOJJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6981750", Offset = "0x697FD50", VA = "0x186981750", Slot = "5")]
	protected override Vector3 KFJELKBPBIE(Vector3 FEBGGALLBNN, float GJMDIBEDCBL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6981700", Offset = "0x697FD00", VA = "0x186981700", Slot = "6")]
	protected override Vector3 CGICGNAPDOP(Vector3 MIGBCLGIEPA, Vector3 MMACHIKDDMH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6981790", Offset = "0x697FD90", VA = "0x186981790", Slot = "7")]
	protected override Vector3 OEKJKHGKJHD(Vector3 MIGBCLGIEPA, Vector3 MMACHIKDDMH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6981810", Offset = "0x697FE10", VA = "0x186981810")]
	public EEBCFINGKID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class LIKKJPNBEHO
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2C16AE0", Offset = "0x2C150E0", VA = "0x182C16AE0")]
	public static NOHAONPGECK<T1, T2> KKJEMJBKDLP<T1, T2>(T1 PGBICCEMLCJ, T2 KMCMPNCOKCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2C16B80", Offset = "0x2C15180", VA = "0x182C16B80")]
	public static FAEOPJIEBNG<T1, T2, T3> KKJEMJBKDLP<T1, T2, T3>(T1 PGBICCEMLCJ, T2 KMCMPNCOKCJ, T3 BCACLONGLLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4556CF0", Offset = "0x45552F0", VA = "0x184556CF0")]
	internal static int NBCPGHDIBBG(int PHFFBDEGPEI, int CJNBMCGCENP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5D441B0", Offset = "0x5D427B0", VA = "0x185D441B0")]
	internal static int NBCPGHDIBBG(int PHFFBDEGPEI, int CJNBMCGCENP, int OMFFIODFFON)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NOHAONPGECK<T1, T2> : IComparable<NOHAONPGECK<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T1 AIMGDKIGBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T2 CLDEHAHKLBM;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x45FEF60", Offset = "0x45FD560", VA = "0x1845FEF60")]
	public NOHAONPGECK(T1 PGBICCEMLCJ, T2 KMCMPNCOKCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x45FD360", Offset = "0x45FB960", VA = "0x1845FD360", Slot = "4")]
	public int CompareTo(NOHAONPGECK<T1, T2> OGEIJLCLBIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x45FD9E0", Offset = "0x45FBFE0", VA = "0x1845FD9E0", Slot = "0")]
	public override bool Equals(object OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x45FE390", Offset = "0x45FC990", VA = "0x1845FE390", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x45FE5B0", Offset = "0x45FCBB0", VA = "0x1845FE5B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class FAEOPJIEBNG<T1, T2, T3> : IComparable<FAEOPJIEBNG<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly T1 AIMGDKIGBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly T2 CLDEHAHKLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T3 ANHCDNJHHKI;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3B730D0", Offset = "0x3B716D0", VA = "0x183B730D0")]
	public FAEOPJIEBNG(T1 PGBICCEMLCJ, T2 KMCMPNCOKCJ, T3 BCACLONGLLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x3B728C0", Offset = "0x3B70EC0", VA = "0x183B728C0", Slot = "4")]
	public int CompareTo(FAEOPJIEBNG<T1, T2, T3> OGEIJLCLBIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x3B72A20", Offset = "0x3B71020", VA = "0x183B72A20", Slot = "0")]
	public override bool Equals(object OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x3B72D60", Offset = "0x3B71360", VA = "0x183B72D60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x3B72E00", Offset = "0x3B71400", VA = "0x183B72E00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T MDPJKNKDANF
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2334A50", Offset = "0x2333050", VA = "0x182334A50")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2334A10", Offset = "0x2333010", VA = "0x182334A10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float BGKLNEHELKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9A4C30", Offset = "0x9A3230", VA = "0x1809A4C30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4C8FD50", Offset = "0x4C8E350", VA = "0x184C8FD50")]
	public T PBBLJMHCCGK(float GJMDIBEDCBL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4C8FAF0", Offset = "0x4C8E0F0", VA = "0x184C8FAF0")]
	public T GKGKEGDLAMH(float GJMDIBEDCBL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T CHJOOLHJJKE(T MIGBCLGIEPA, T MMACHIKDDMH, float GJMDIBEDCBL);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6982B60", Offset = "0x6981160", VA = "0x186982B60", Slot = "4")]
	protected override float CHJOOLHJJKE(float MIGBCLGIEPA, float MMACHIKDDMH, float GJMDIBEDCBL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6982BA0", Offset = "0x69811A0", VA = "0x186982BA0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xF46460", Offset = "0xF44A60", VA = "0x180F46460", Slot = "4")]
	protected override Vector3 CHJOOLHJJKE(Vector3 MIGBCLGIEPA, Vector3 MMACHIKDDMH, float GJMDIBEDCBL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6986B20", Offset = "0x6985120", VA = "0x186986B20")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6981160", Offset = "0x697F760", VA = "0x186981160", Slot = "4")]
	protected override Color CHJOOLHJJKE(Color MIGBCLGIEPA, Color MMACHIKDDMH, float GJMDIBEDCBL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6981220", Offset = "0x697F820", VA = "0x186981220")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OFJPLEHOENJ : GBDFEPNDLNG<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6984990", Offset = "0x6982F90", VA = "0x186984990")]
	public OFJPLEHOENJ(int HDGFIGFBKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6984920", Offset = "0x6982F20", VA = "0x186984920", Slot = "6")]
	protected override uint JNNMHAFMGLM(uint CMIFMCLDAIC, string FEBGGALLBNN)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class BHHOLMLEMAN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly IDisposable HHHOBHGDEHO;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	public BHHOLMLEMAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct GBIDLJPLLNG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> KKNLJHONLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int FKFKCGOCLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int FCNGPOACKJB;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3CB63C0", Offset = "0x3CB49C0", VA = "0x183CB63C0")]
	private GBIDLJPLLNG(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> JPEPGLOFHGE, int DKJGIHJPFLJ, int AIBDHEKBKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x3CB62B0", Offset = "0x3CB48B0", VA = "0x183CB62B0")]
	public static GBIDLJPLLNG<T> NKOJKFHACJH()
	{
		return default(GBIDLJPLLNG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x3CB5B50", Offset = "0x3CB4150", VA = "0x183CB5B50")]
	public (int, int, Task<T>) KCIDMAHGBBJ(int PJCEMACCFLL, [Optional] CancellationToken NNGMAHIDECE, double OPCFFCHKCFF = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3CB3F20", Offset = "0x3CB2520", VA = "0x183CB3F20")]
	public void EODKBHGAFGA(int PJCEMACCFLL, int AIBDHEKBKOH, [In] T JKLHKLABFHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class HGAFILOEAHN
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6982C60", Offset = "0x6981260", VA = "0x186982C60")]
	public static GBIDLJPLLNG<DHABIOOJNOJ> NKOJKFHACJH()
	{
		return default(GBIDLJPLLNG<DHABIOOJNOJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6982BE0", Offset = "0x69811E0", VA = "0x186982BE0")]
	public static void EODKBHGAFGA([In] this GBIDLJPLLNG<DHABIOOJNOJ> ELMHNMGFNPC, int PJCEMACCFLL, int AIBDHEKBKOH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class NFGBMIEKGOH<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<TKey, TVal> PNBFCPGJJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TVal, TKey> NMKIAGBIDGE;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int NCPJPJDHEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x359ECF0", Offset = "0x359D2F0", VA = "0x18359ECF0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool AJPOMKOKGAO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public ICollection<TKey> JLCPGPNHAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x37E6EE0", Offset = "0x37E54E0", VA = "0x1837E6EE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public ICollection<TVal> AHHFPMECDNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x4574860", Offset = "0x4572E60", VA = "0x184574860", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TVal ECHCHHAAKAL
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x45747F0", Offset = "0x4572DF0", VA = "0x1845747F0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x45748C0", Offset = "0x4572EC0", VA = "0x1845748C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public TKey ECHCHHAAKAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x45742C0", Offset = "0x45728C0", VA = "0x1845742C0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4573D60", Offset = "0x4572360", VA = "0x184573D60", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x45745C0", Offset = "0x4572BC0", VA = "0x1845745C0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4573D10", Offset = "0x4572310", VA = "0x184573D10", Slot = "9")]
	public void Add(TKey MNBFPOFIDHA, TVal FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x4573C30", Offset = "0x4572230", VA = "0x184573C30", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> OKNDMMHNIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x44E6B90", Offset = "0x44E5190", VA = "0x1844E6B90", Slot = "8")]
	public bool ContainsKey(TKey MNBFPOFIDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4573E50", Offset = "0x4572450", VA = "0x184573E50", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> OKNDMMHNIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4574540", Offset = "0x4572B40", VA = "0x184574540", Slot = "10")]
	public bool Remove(TKey MNBFPOFIDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4574500", Offset = "0x4572B00", VA = "0x184574500", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> OKNDMMHNIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4574660", Offset = "0x4572C60", VA = "0x184574660", Slot = "11")]
	public bool TryGetValue(TKey MNBFPOFIDHA, [Out] TVal FEBGGALLBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4574100", Offset = "0x4572700", VA = "0x184574100", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4573E90", Offset = "0x4572490", VA = "0x184573E90", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] NMHOKLPDKBK, int IBKDGIHHMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x45741A0", Offset = "0x45727A0", VA = "0x1845741A0")]
	public bool NCAHNJJKPNF(TVal MNBFPOFIDHA, [Out] TKey FEBGGALLBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x4574320", Offset = "0x4572920", VA = "0x184574320")]
	private void NPOAPANFEEP(TKey MNBFPOFIDHA, TVal GAELHANIPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4573F20", Offset = "0x4572520", VA = "0x184573F20")]
	private void DJPDKNAJAGJ(TKey MNBFPOFIDHA, TVal GAELHANIPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x45739E0", Offset = "0x4571FE0", VA = "0x1845739E0")]
	private bool ALFBGNPHAAN(TKey MNBFPOFIDHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x45746C0", Offset = "0x4572CC0", VA = "0x1845746C0")]
	public NFGBMIEKGOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class ONEMPPAFAMO<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private ONEMPPAFAMO<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x3868B90", Offset = "0x3867190", VA = "0x183868B90", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x386E290", Offset = "0x386C890", VA = "0x18386E290", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x386FFB0", Offset = "0x386E5B0", VA = "0x18386FFB0")]
		public Enumerator(ONEMPPAFAMO<T> KGHDKIBNGIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x386D640", Offset = "0x386BC40", VA = "0x18386D640", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x386DD60", Offset = "0x386C360", VA = "0x18386DD60", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x386BAF0", Offset = "0x386A0F0", VA = "0x18386BAF0")]
		private void EGCPLGLJIPL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private T[] PFDOCCGACIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int CHEJIFFIDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private int DKGEKHELJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private int PKICDAADPKG;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int NCPJPJDHEHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x473A470", Offset = "0x4738A70", VA = "0x18473A470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public T ECHCHHAAKAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x473A940", Offset = "0x4738F40", VA = "0x18473A940")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x473A4B0", Offset = "0x4738AB0", VA = "0x18473A4B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x473AC00", Offset = "0x4739200", VA = "0x18473AC00")]
	public ONEMPPAFAMO(int HDGFIGFBKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4739E00", Offset = "0x4738400", VA = "0x184739E00")]
	public void AGMNBECNIJC(T GJMDIBEDCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x473A620", Offset = "0x4738C20", VA = "0x18473A620")]
	public void KFLPEIEEDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x473A060", Offset = "0x4738660", VA = "0x18473A060")]
	public void AHHOCIECACM(int FDDANCOAHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x473A7C0", Offset = "0x4738DC0", VA = "0x18473A7C0")]
	public void NFOKJEMMIBI(T[] NMHOKLPDKBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x473A3F0", Offset = "0x47389F0", VA = "0x18473A3F0")]
	public Enumerator CPHKKMADKBM()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x473AA90", Offset = "0x4739090", VA = "0x18473AA90", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x473AA90", Offset = "0x4739090", VA = "0x18473AA90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x473A170", Offset = "0x4738770", VA = "0x18473A170")]
	private int CFMPEBFENPB(int EBDMAJMOJLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x473A140", Offset = "0x4738740", VA = "0x18473A140")]
	private int AOALPHPHMIB(int EBDMAJMOJLN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class FKNKKEIANCA<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate Task<TResult> FOBJCCNGMHP(TRequest FALAJMPCHDK, CancellationToken NNGMAHIDECE);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public enum JLGOLBOAGIB
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class PIPCKNPEELA
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private const float CMEPHBPIMIO = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TimeSpan PCNMBOPGFIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int KAJCAKGHAGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public JLGOLBOAGIB PPPFBCHLJBH;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public static readonly PIPCKNPEELA NEJLCIDCLHL;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float ABDJBEICHKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x481DA20", Offset = "0x481C020", VA = "0x18481DA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan OCCABNDANCI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x481DA90", Offset = "0x481C090", VA = "0x18481DA90")]
		public PIPCKNPEELA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private readonly struct MMFKEJDMLFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly TRequest FALAJMPCHDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly CancellationToken NNGMAHIDECE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly TaskCompletionSource<TResult> LPLEFMNFOII;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x450B9B0", Offset = "0x4509FB0", VA = "0x18450B9B0")]
		public MMFKEJDMLFI(TRequest FALAJMPCHDK, TaskCompletionSource<TResult> LPLEFMNFOII, CancellationToken NNGMAHIDECE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct BAFPENNPDDF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public FKNKKEIANCA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4ECE880", Offset = "0x4ECCE80", VA = "0x184ECE880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4ECF4B0", Offset = "0x4ECDAB0", VA = "0x184ECF4B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct CBJFEBJJCOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public FKNKKEIANCA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private MMFKEJDMLFI <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4FC0190", Offset = "0x4FBE790", VA = "0x184FC0190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4FC14F0", Offset = "0x4FBFAF0", VA = "0x184FC14F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly CancellationTokenSource EDFDBKHCOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<MMFKEJDMLFI> EAFJNAHMAMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly PIPCKNPEELA ECOFDMIANDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly FOBJCCNGMHP JBMDGOLKJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Task GKLDNNBLGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int CAACPKBEAGG;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3BC6A10", Offset = "0x3BC5010", VA = "0x183BC6A10")]
	public FKNKKEIANCA(FOBJCCNGMHP JBMDGOLKJEJ, [Optional] PIPCKNPEELA ECOFDMIANDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3BC5FE0", Offset = "0x3BC45E0", VA = "0x183BC5FE0")]
	public Task<TResult> GNLFBNACACI(TRequest FALAJMPCHDK, CancellationToken NNGMAHIDECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3BC5DE0", Offset = "0x3BC43E0", VA = "0x183BC5DE0")]
	private void DCEAFKFEBNC(MMFKEJDMLFI LLILFLFFOHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4EC0", Offset = "0x3BC34C0", VA = "0x183BC4EC0")]
	[AsyncStateMachine(typeof(FKNKKEIANCA<, >.BAFPENNPDDF))]
	private Task AKEDCGOBHNP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3BC5A20", Offset = "0x3BC4020", VA = "0x183BC5A20")]
	private MMFKEJDMLFI CGECMFIKMOO()
	{
		return default(MMFKEJDMLFI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3BC5220", Offset = "0x3BC3820", VA = "0x183BC5220")]
	[AsyncStateMachine(typeof(FKNKKEIANCA<, >.CBJFEBJJCOK))]
	private Task ANNAAHHKCIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3BC4DB0", Offset = "0x3BC33B0", VA = "0x183BC4DB0")]
	private void AFKFGKCAEOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3BC5FA0", Offset = "0x3BC45A0", VA = "0x183BC5FA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class FJHBOFMMNCM<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly List<T> MNNCEMFBNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private HashSet<T> COICLAFDNFL;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int NCPJPJDHEHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x359ECF0", Offset = "0x359D2F0", VA = "0x18359ECF0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool AJPOMKOKGAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T ECHCHHAAKAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x274BED0", Offset = "0x274A4D0", VA = "0x18274BED0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3BB5770", Offset = "0x3BB3D70", VA = "0x183BB5770", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3813740", Offset = "0x3811D40", VA = "0x183813740", Slot = "11")]
	public void Add(T OKNDMMHNIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3BB4C80", Offset = "0x3BB3280", VA = "0x183BB4C80")]
	public bool HJOEBKGBEIE(T OKNDMMHNIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3BB5460", Offset = "0x3BB3A60", VA = "0x183BB5460", Slot = "15")]
	public bool Remove(T OKNDMMHNIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3BB4BF0", Offset = "0x3BB31F0", VA = "0x183BB4BF0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3BB5600", Offset = "0x3BB3C00", VA = "0x183BB5600", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3BB4A80", Offset = "0x3BB3080", VA = "0x183BB4A80", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3BB4B30", Offset = "0x3BB3130", VA = "0x183BB4B30", Slot = "13")]
	public bool Contains(T OKNDMMHNIOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3BB4B90", Offset = "0x3BB3190", VA = "0x183BB4B90", Slot = "14")]
	public void CopyTo(T[] NMHOKLPDKBK, int IBKDGIHHMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3BB4EA0", Offset = "0x3BB34A0", VA = "0x183BB4EA0", Slot = "6")]
	public int IndexOf(T OKNDMMHNIOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3BB5050", Offset = "0x3BB3650", VA = "0x183BB5050", Slot = "7")]
	public void Insert(int EBDMAJMOJLN, T OKNDMMHNIOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3BB5300", Offset = "0x3BB3900", VA = "0x183BB5300", Slot = "8")]
	public void RemoveAt(int EBDMAJMOJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3BB5640", Offset = "0x3BB3C40", VA = "0x183BB5640")]
	public FJHBOFMMNCM()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x21DB7E0", Offset = "0x21D9DE0", VA = "0x1821DB7E0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x69860F0", Offset = "0x69846F0", VA = "0x1869860F0")]
		public SerializedGuid([In] Guid DHEKBCJKGBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6985FC0", Offset = "0x69845C0", VA = "0x186985FC0")]
		public static SerializedGuid HDGLIHNBEFD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6985E40", Offset = "0x6984440", VA = "0x186985E40")]
		public static SerializedGuid CPCINBJINAI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6985DE0", Offset = "0x69843E0", VA = "0x186985DE0")]
		public bool BNJOFFCHEKO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x69860C0", Offset = "0x69846C0", VA = "0x1869860C0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6986040", Offset = "0x6984640", VA = "0x186986040", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6985EE0", Offset = "0x69844E0", VA = "0x186985EE0", Slot = "7")]
		public bool Equals(SerializedGuid OGEIJLCLBIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6985F20", Offset = "0x6984520", VA = "0x186985F20", Slot = "0")]
		public override bool Equals(object CDBNFNMIHPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6985FB0", Offset = "0x69845B0", VA = "0x186985FB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6985EB0", Offset = "0x69844B0", VA = "0x186985EB0", Slot = "6")]
		public int CompareTo(SerializedGuid OGEIJLCLBIC)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class JAHMNJJONBL : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly Type DFJHDMEFJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly string HLKECGOJOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool BJCJCKBJPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly bool MNFBEJFGJAO;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6982EC0", Offset = "0x69814C0", VA = "0x186982EC0")]
	public JAHMNJJONBL(Type CGKDOHLMJCP, string ELOLIJAOGMF, bool JPMADBEGIAE = false, bool ILPMDIKDNLM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class NEGKJPNCLPM<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public readonly struct BPAILEBJHDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly long EKHHPDFLEDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly long BNDGAFCKPEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly int GEEDGOKFCOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly int LCEPMPFBFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly bool CAPAKBMGLGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly string EFGPIBFIGPM;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4F380B0", Offset = "0x4F366B0", VA = "0x184F380B0")]
		public BPAILEBJHDN(long EKHHPDFLEDJ, int GEEDGOKFCOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4F38120", Offset = "0x4F36720", VA = "0x184F38120")]
		public BPAILEBJHDN(long EKHHPDFLEDJ, long BNDGAFCKPEF, int GEEDGOKFCOF, int LCEPMPFBFAK, bool CAPAKBMGLGG, string EFGPIBFIGPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4F38060", Offset = "0x4F36660", VA = "0x184F38060")]
		public int KMJAIMBKCBN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4F37FE0", Offset = "0x4F365E0", VA = "0x184F37FE0")]
		public int GFLBCDBLHBD(int FMCJBOFDAJF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x4F38000", Offset = "0x4F36600", VA = "0x184F38000")]
		public double GJAPFDJMCHE()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4F37F40", Offset = "0x4F36540", VA = "0x184F37F40")]
		public BPAILEBJHDN BJDBPKDPPNL(long BNDGAFCKPEF, int LCEPMPFBFAK)
		{
			return default(BPAILEBJHDN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class GBKOFALFHEN : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private struct NEMDLGGLGIF<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public GBKOFALFHEN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public Func<GBKOFALFHEN, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private GBKOFALFHEN <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x45723F0", Offset = "0x45709F0", VA = "0x1845723F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x3D488D0", Offset = "0x3D46ED0", VA = "0x183D488D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public readonly TKey MFNGEPMCPEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly NEGKJPNCLPM<TKey> CIAFJLABOOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public readonly CHNLCLDOCNE CNCAEGCNGHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private List<GBKOFALFHEN> LGBIOCEMEJI;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string DFHLDBCEIBK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3CBFAF0", Offset = "0x3CBE0F0", VA = "0x183CBFAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<GBKOFALFHEN> JNKICKAFHCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x3CBF8C0", Offset = "0x3CBDEC0", VA = "0x183CBF8C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public BPAILEBJHDN OGMALDNLMID
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x3CBF640", Offset = "0x3CBDC40", VA = "0x183CBF640")]
			[CompilerGenerated]
			get
			{
				return default(BPAILEBJHDN);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x3CBFAC0", Offset = "0x3CBE0C0", VA = "0x183CBFAC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3CBFB50", Offset = "0x3CBE150", VA = "0x183CBFB50")]
		internal GBKOFALFHEN(NEGKJPNCLPM<TKey> CIAFJLABOOB, TKey MNBFPOFIDHA, CHNLCLDOCNE CNCAEGCNGHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3CBF900", Offset = "0x3CBDF00", VA = "0x183CBF900")]
		public GBKOFALFHEN KMAGBGOMDEO(TKey MNBFPOFIDHA, [Optional] CHNLCLDOCNE? OOLEFJNBDJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2A8F790", Offset = "0x2A8DD90", VA = "0x182A8F790")]
		[AsyncStateMachine(typeof(NEMDLGGLGIF<>))]
		public Task<T> OLDMJIFMDNM<T>(TKey MNBFPOFIDHA, Func<GBKOFALFHEN, Task<T>> MMBIFBKCHGP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3CBF660", Offset = "0x3CBDC60", VA = "0x183CBF660", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class KDAPPMNLCOF : IEnumerable<(TKey, List<TKey>, BPAILEBJHDN)>, IEnumerable, IEnumerator<(TKey, List<TKey>, BPAILEBJHDN)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private (TKey key, List<TKey> path, BPAILEBJHDN timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public NEGKJPNCLPM<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private IEnumerator<(TKey key, List<TKey> path, BPAILEBJHDN timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, BPAILEBJHDN) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x21CEC60", Offset = "0x21CD260", VA = "0x1821CEC60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, BPAILEBJHDN));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x41D0810", Offset = "0x41CEE10", VA = "0x1841D0810", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x21CED50", Offset = "0x21CD350", VA = "0x1821CED50")]
		[DebuggerHidden]
		public KDAPPMNLCOF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x39CF030", Offset = "0x39CD630", VA = "0x1839CF030", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x41D02E0", Offset = "0x41CE8E0", VA = "0x1841D02E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x41D0690", Offset = "0x41CEC90", VA = "0x1841D0690")]
		private void OGHBNIPNCAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x41D07C0", Offset = "0x41CEDC0", VA = "0x1841D07C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x41D06E0", Offset = "0x41CECE0", VA = "0x1841D06E0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, BPAILEBJHDN)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x37DE0C0", Offset = "0x37DC6C0", VA = "0x1837DE0C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class IJNIGDLAOFF : IEnumerable<(TKey, List<TKey>, BPAILEBJHDN)>, IEnumerable, IEnumerator<(TKey, List<TKey>, BPAILEBJHDN)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private (TKey key, List<TKey> path, BPAILEBJHDN timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private GBKOFALFHEN timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public GBKOFALFHEN <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public NEGKJPNCLPM<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IEnumerator<GBKOFALFHEN> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private IEnumerator<(TKey key, List<TKey> path, BPAILEBJHDN timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, BPAILEBJHDN) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x21CEC60", Offset = "0x21CD260", VA = "0x1821CEC60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, BPAILEBJHDN));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x3E4BF00", Offset = "0x3E4A500", VA = "0x183E4BF00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x21CED50", Offset = "0x21CD350", VA = "0x1821CED50")]
		[DebuggerHidden]
		public IJNIGDLAOFF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3E4BF60", Offset = "0x3E4A560", VA = "0x183E4BF60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3E4B530", Offset = "0x3E49B30", VA = "0x183E4B530", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3E4BD10", Offset = "0x3E4A310", VA = "0x183E4BD10")]
		private void OGHBNIPNCAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3E4B4D0", Offset = "0x3E49AD0", VA = "0x183E4B4D0")]
		private void MKLBAOAGFDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3E4BEB0", Offset = "0x3E4A4B0", VA = "0x183E4BEB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3E4BD70", Offset = "0x3E4A370", VA = "0x183E4BD70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, BPAILEBJHDN)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3E4BE70", Offset = "0x3E4A470", VA = "0x183E4BE70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly Action<TKey, BPAILEBJHDN, CHNLCLDOCNE> BKJAEJJMOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Action<TKey, BPAILEBJHDN, CHNLCLDOCNE> OBPHBNBIKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Action<NEGKJPNCLPM<TKey>, CHNLCLDOCNE> EAAKIHONPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly CHNLCLDOCNE CNCAEGCNGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly GBKOFALFHEN JGDIBFDOFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool PCNGABNNECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int PADKNNNOHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Stopwatch MJOGFKHBCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int DAEGFLIDNAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private string ICMPHKKOKDF;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public GBKOFALFHEN DJOCCILLCFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string DFHLDBCEIBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x861750", Offset = "0x85FD50", VA = "0x180861750")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x45721D0", Offset = "0x45707D0", VA = "0x1845721D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4572230", Offset = "0x4570830", VA = "0x184572230")]
	public NEGKJPNCLPM(TKey OLNECDCDGMK, CHNLCLDOCNE CNCAEGCNGHI, [Optional] int? GEEDGOKFCOF, [Optional][CanBeNull] Stopwatch MJOGFKHBCOI, [Optional] Action<TKey, BPAILEBJHDN, CHNLCLDOCNE> BKJAEJJMOMI, [Optional] Action<TKey, BPAILEBJHDN, CHNLCLDOCNE> OBPHBNBIKAO, [Optional] Action<NEGKJPNCLPM<TKey>, CHNLCLDOCNE> EAAKIHONPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4571ED0", Offset = "0x45704D0", VA = "0x184571ED0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4572030", Offset = "0x4570630", VA = "0x184572030")]
	[IteratorStateMachine(typeof(NEGKJPNCLPM<>.KDAPPMNLCOF))]
	public IEnumerable<(TKey, List<TKey>, BPAILEBJHDN)> NFAKNPKIHME()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x45720E0", Offset = "0x45706E0", VA = "0x1845720E0")]
	[IteratorStateMachine(typeof(NEGKJPNCLPM<>.IJNIGDLAOFF))]
	private IEnumerable<(TKey, List<TKey>, BPAILEBJHDN)> NFAKNPKIHME(List<TKey> DLMOEDNDKJK, GBKOFALFHEN CLOBAOOEDCO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4571FB0", Offset = "0x45705B0", VA = "0x184571FB0")]
	private (long, int) HCBBJHBHCMD()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class ONDHHICFMIG<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut HFDDFKDPPFH(NEGKJPNCLPM<TKey> CIAFJLABOOB);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	protected ONDHHICFMIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class DCMABFPEPBP<TKey> : ONDHHICFMIG<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate string AJJKPDCKHPN(TKey MNBFPOFIDHA);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5860E00", Offset = "0x585F400", VA = "0x185860E00")]
	private static string DDFHFPGMMPJ(TKey MNBFPOFIDHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5860E40", Offset = "0x585F440", VA = "0x185860E40", Slot = "4")]
	public override string HFDDFKDPPFH(NEGKJPNCLPM<TKey> CIAFJLABOOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x5860F30", Offset = "0x585F530", VA = "0x185860F30")]
	public string HFDDFKDPPFH(NEGKJPNCLPM<TKey> CIAFJLABOOB, [NotNull] AJJKPDCKHPN HGIFKCHMFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string GMEKOJABCGM(NEGKJPNCLPM<TKey> CIAFJLABOOB, [NotNull] AJJKPDCKHPN HGIFKCHMFKG);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x37DBDE0", Offset = "0x37DA3E0", VA = "0x1837DBDE0")]
	protected DCMABFPEPBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class MNJFJAOFMDO<TKey> : ONDHHICFMIG<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate string DDMJMABHNHE(TKey MNBFPOFIDHA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string OKOOJBAIMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly double HDCGMGCLCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly bool MDAGLBIJBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly int IAOJMJKKCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly ISet<string> EEFAJFHEGEL;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x450DBA0", Offset = "0x450C1A0", VA = "0x18450DBA0")]
	private static string DDFHFPGMMPJ(TKey MNBFPOFIDHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x450E7D0", Offset = "0x450CDD0", VA = "0x18450E7D0")]
	public MNJFJAOFMDO(string OKOOJBAIMPH = "F2", double HDCGMGCLCCC = double.MaxValue, bool MDAGLBIJBHN = false, int IAOJMJKKCNM = int.MaxValue, [Optional] ISet<string> EEFAJFHEGEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x450DBE0", Offset = "0x450C1E0", VA = "0x18450DBE0", Slot = "4")]
	public override Dictionary<string, string> HFDDFKDPPFH(NEGKJPNCLPM<TKey> CIAFJLABOOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x450E5A0", Offset = "0x450CBA0", VA = "0x18450E5A0")]
	private bool MGLBLPGGIEI(string KOCPCKPHLDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x450DCD0", Offset = "0x450C2D0", VA = "0x18450DCD0")]
	public Dictionary<string, string> HFDDFKDPPFH(NEGKJPNCLPM<TKey> CIAFJLABOOB, DDMJMABHNHE HGIFKCHMFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x450E320", Offset = "0x450C920", VA = "0x18450E320")]
	private string JNCLCDGBNFA(StringBuilder PJHBGOJOGCG, List<TKey> LBKPEOEKELE, DDMJMABHNHE HGIFKCHMFKG, bool MGLILGMEIGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x450E670", Offset = "0x450CC70", VA = "0x18450E670")]
	private static void ONLCOHHKOGJ(StringBuilder NNDIIAMIDHC, string BCKHMCHOPHP, bool GDAGKDAFPKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class FCLJHFNJOLH<TKey> : DCMABFPEPBP<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct DDKHDHIBIND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AJJKPDCKHPN keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static FCLJHFNJOLH<TKey> HHHOBHGDEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly string[] KLKLOJNPKKF;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3B84890", Offset = "0x3B82E90", VA = "0x183B84890")]
	private FCLJHFNJOLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3B837F0", Offset = "0x3B81DF0", VA = "0x183B837F0", Slot = "5")]
	protected override string GMEKOJABCGM(NEGKJPNCLPM<TKey> CIAFJLABOOB, AJJKPDCKHPN HGIFKCHMFKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3B84630", Offset = "0x3B82C30", VA = "0x183B84630")]
	[CompilerGenerated]
	internal static string LNPMOOGDJEA(string NPGCDPAJEGD, TKey MNBFPOFIDHA, DDKHDHIBIND P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class HNBBCGPODMG : NEGKJPNCLPM<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class ECMMHFLOFBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Action<HNBBCGPODMG, CHNLCLDOCNE> callback;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public ECMMHFLOFBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6981670", Offset = "0x697FC70", VA = "0x186981670")]
		internal void OBGFLFOBBKI(NEGKJPNCLPM<string> timer, CHNLCLDOCNE log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6982D70", Offset = "0x6981370", VA = "0x186982D70")]
	public HNBBCGPODMG(CHNLCLDOCNE CNCAEGCNGHI, [Optional] string CLHKEAHONNK, [Optional] int? GEEDGOKFCOF, [Optional] Stopwatch MJOGFKHBCOI, [Optional] Action<string, BPAILEBJHDN, CHNLCLDOCNE> BKJAEJJMOMI, [Optional] Action<string, BPAILEBJHDN, CHNLCLDOCNE> OBPHBNBIKAO, [Optional] Action<HNBBCGPODMG, CHNLCLDOCNE> EAAKIHONPIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6982CB0", Offset = "0x69812B0", VA = "0x186982CB0")]
	private static Action<NEGKJPNCLPM<string>, CHNLCLDOCNE> HDPFKGGBCDB(Action<HNBBCGPODMG, CHNLCLDOCNE> MAPPKFKPMBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class BLPAAFKODPD
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class FKKINBOJGHJ : BLPAAFKODPD
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static BLPAAFKODPD HHHOBHGDEHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x6982A20", Offset = "0x6981020", VA = "0x186982A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float EOEBNHBIELJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xAA2760", Offset = "0xAA0D60", VA = "0x180AA2760", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6982B10", Offset = "0x6981110", VA = "0x186982B10")]
		public FKKINBOJGHJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static BLPAAFKODPD BHFJIGAAKGJ;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static BLPAAFKODPD NEJLCIDCLHL
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6980B50", Offset = "0x697F150", VA = "0x186980B50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float EOEBNHBIELJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
	protected BLPAAFKODPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface IPNLIBBOHIC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool JEDAHGMJAJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface JPDJGJBEGGO<T> : IPNLIBBOHIC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	[NotNull]
	Task<T> AFLJMNBJEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	[NotNull]
	DNKNPFLFPMI<T> GGOHKAHNAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class EIOHAFHMKJK
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x29F63B0", Offset = "0x29F49B0", VA = "0x1829F63B0")]
	public static JPDJGJBEGGO<TResource> KAOPHKLACEM<TResource, TId>(this LJONMJGPMEC<TId, TResource> GIPKBENJJKM, TId KAGKMEDPMHO, [Optional] Func<TId, CancellationToken, Task<TResource>>? LBCIKNOEINF) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class FCELJCABGEH
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class EIAILBLOMAO<T> : LNCPEPHDNEM<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T?> AFLJMNBJEMA
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override DNKNPFLFPMI<T?> GGOHKAHNAFO
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x37ECFB0", Offset = "0x37EB5B0", VA = "0x1837ECFB0")]
		public EIAILBLOMAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "10")]
		protected override void HBFHKMBGDJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class EHKELDCBMCO<T> : LNCPEPHDNEM<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly T JFGILOINJHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Action<T>? HIGGGMLLMGF;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> AFLJMNBJEMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x8634D0", Offset = "0x861AD0", VA = "0x1808634D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override DNKNPFLFPMI<T> GGOHKAHNAFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x8632E0", Offset = "0x8618E0", VA = "0x1808632E0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x37ECB00", Offset = "0x37EB100", VA = "0x1837ECB00")]
		public EHKELDCBMCO(T PNLPKKJIAIJ, Action<T>? BBIGAGCAOBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x37EC8B0", Offset = "0x37EAEB0", VA = "0x1837EC8B0", Slot = "10")]
		protected override void HBFHKMBGDJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class AEIKFHFDMFA<T> : LNCPEPHDNEM<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override Task<T> AFLJMNBJEMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override DNKNPFLFPMI<T> GGOHKAHNAFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3C76BC0", Offset = "0x3C751C0", VA = "0x183C76BC0")]
		public AEIKFHFDMFA(Exception OOIEOIIANBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "10")]
		protected override void HBFHKMBGDJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class NJMEMLOALHP<T> : LNCPEPHDNEM<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct FCOFKIMCNLH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public Task<JPDJGJBEGGO<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<JPDJGJBEGGO<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x3B85BD0", Offset = "0x3B841D0", VA = "0x183B85BD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x3B86110", Offset = "0x3B84710", VA = "0x183B86110", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct JBFBDLECPAI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public Task<JPDJGJBEGGO<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<JPDJGJBEGGO<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x40037A0", Offset = "0x4001DA0", VA = "0x1840037A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x4003C20", Offset = "0x4002220", VA = "0x184003C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly Task<JPDJGJBEGGO<T>> CLIIECCGAFE;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override Task<T> AFLJMNBJEMA
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override DNKNPFLFPMI<T> GGOHKAHNAFO
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x860D20", Offset = "0x85F320", VA = "0x180860D20", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x4588EE0", Offset = "0x45874E0", VA = "0x184588EE0")]
		public NJMEMLOALHP(Task<JPDJGJBEGGO<T>> OOOMFPPINLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x4588970", Offset = "0x4586F70", VA = "0x184588970", Slot = "10")]
		protected override void HBFHKMBGDJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x4588BE0", Offset = "0x45871E0", VA = "0x184588BE0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(NJMEMLOALHP<>.FCOFKIMCNLH))]
		internal static Task<T> NGHIHDLOLIF(Task<JPDJGJBEGGO<T>> OOOMFPPINLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x4588A00", Offset = "0x4587000", VA = "0x184588A00")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(NJMEMLOALHP<>.JBFBDLECPAI))]
		internal static Task MBKHCFHBLGD(Task<JPDJGJBEGGO<T>> OOOMFPPINLE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class BGEKDIKLBKF<TIn, TOut> : LNCPEPHDNEM<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct HOANBKGGNLM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x3D4F710", Offset = "0x3D4DD10", VA = "0x183D4F710", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x3D4FDD0", Offset = "0x3D4E3D0", VA = "0x183D4FDD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly JPDJGJBEGGO<TIn> CAEGDFOKNBP;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<TOut> AFLJMNBJEMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override DNKNPFLFPMI<TOut> GGOHKAHNAFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x860D20", Offset = "0x85F320", VA = "0x180860D20", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x4F0F060", Offset = "0x4F0D660", VA = "0x184F0F060")]
		public BGEKDIKLBKF(JPDJGJBEGGO<TIn> BNOMFPLIIJF, Func<TIn, TOut> EKDJNEHKDFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x4F0ECA0", Offset = "0x4F0D2A0", VA = "0x184F0ECA0", Slot = "10")]
		protected override void HBFHKMBGDJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x4F0ED40", Offset = "0x4F0D340", VA = "0x184F0ED40")]
		[AsyncStateMachine(typeof(BGEKDIKLBKF<, >.HOANBKGGNLM))]
		[CompilerGenerated]
		internal static Task<TOut> PALBCNCGDPB(Task<TIn> KMDNOPFMODC, Func<TIn, TOut> EKDJNEHKDFO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C210", Offset = "0x2B4A810", VA = "0x182B4C210")]
	public static JPDJGJBEGGO<T> IJMGMBPJJCI<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2B4C160", Offset = "0x2B4A760", VA = "0x182B4C160")]
	public static JPDJGJBEGGO<T> FNEAJOGDMLO<T>(T JKLHKLABFHH, [Optional] Action<T>? BBIGAGCAOBD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2973880", Offset = "0x2971E80", VA = "0x182973880")]
	public static JPDJGJBEGGO<T> HPONHJANEDP<T>(Exception OOIEOIIANBN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2973880", Offset = "0x2971E80", VA = "0x182973880")]
	public static JPDJGJBEGGO<T> KIJDMECPHDP<T>(Task<JPDJGJBEGGO<T>> OOOMFPPINLE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2972330", Offset = "0x2970930", VA = "0x182972330")]
	public static JPDJGJBEGGO<TOut> BFKELEPPJNO<TOut, TIn>(JPDJGJBEGGO<TIn> NNBIOLHDGAK, Func<TIn, TOut> EKDJNEHKDFO) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class LNCPEPHDNEM<T> : JPDJGJBEGGO<T>, IPNLIBBOHIC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly string DBMABPDIHLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly DHCKKIGFMDM GHFEHJLKLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool PCNGABNNECG;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool JEDAHGMJAJE
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xC5F2F0", Offset = "0xC5D8F0", VA = "0x180C5F2F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public abstract Task<T> AFLJMNBJEMA
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public abstract DNKNPFLFPMI<T> GGOHKAHNAFO
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x42E7BB0", Offset = "0x42E61B0", VA = "0x1842E7BB0")]
	public LNCPEPHDNEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x42E7780", Offset = "0x42E5D80", VA = "0x1842E7780", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void HBFHKMBGDJM();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class BHFGOAJJHAJ<TTask, T> : LNCPEPHDNEM<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class JPMNEJFFALJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public JPMNEJFFALJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x358C550", Offset = "0x358AB50", VA = "0x18358C550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x358CAC0", Offset = "0x358B0C0", VA = "0x18358CAC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public BHFGOAJJHAJ<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public JPMNEJFFALJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4109F40", Offset = "0x4108540", VA = "0x184109F40")]
		[AsyncStateMachine(typeof(BHFGOAJJHAJ<, >.JPMNEJFFALJ.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> JJLIMNKGICP(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Task<T> OOOMFPPINLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	protected readonly CancellationTokenSource NIGBFOEDEML;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public override Task<T> AFLJMNBJEMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override DNKNPFLFPMI<T> GGOHKAHNAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x4F12AF0", Offset = "0x4F110F0", VA = "0x184F12AF0")]
	protected BHFGOAJJHAJ(TTask OOOMFPPINLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x4F12890", Offset = "0x4F10E90", VA = "0x184F12890", Slot = "10")]
	protected override void HBFHKMBGDJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T CFEHEPKABBF(TTask PGJMIAFJKLJ);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void AHBMJEGDPFO();
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class PLGPLHFCJNN<T> : LNCPEPHDNEM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly OCANDJCDBAG<Task<T>> GAKBOKKFGAM;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public override Task<T> AFLJMNBJEMA
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3B735C0", Offset = "0x3B71BC0", VA = "0x183B735C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public override DNKNPFLFPMI<T> GGOHKAHNAFO
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x4821AA0", Offset = "0x48200A0", VA = "0x184821AA0")]
	public PLGPLHFCJNN(OCANDJCDBAG<Task<T>> MOBHKNHIBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4821A80", Offset = "0x4820080", VA = "0x184821A80", Slot = "10")]
	protected override void HBFHKMBGDJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class MHJODBDAMMM
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static readonly HashAlgorithmName OEOADMCGCFM;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly ThreadLocal<IncrementalHash> IEMAGIBEIFJ;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6984040", Offset = "0x6982640", VA = "0x186984040")]
	public static int MBDIJDNPFPG(this FDEOFPEJOOF GOOIJOGLMPJ, IncrementalHash CMIFMCLDAIC, byte[] DBLDAPECCAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x69843F0", Offset = "0x69829F0", VA = "0x1869843F0")]
	public static bool MDPNLNCHLKI([CanBeNull] this FDEOFPEJOOF GOOIJOGLMPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6984450", Offset = "0x6982A50", VA = "0x186984450")]
	public static bool MDPNLNCHLKI([CanBeNull] this FDEOFPEJOOF GOOIJOGLMPJ, [Out] string BDGJCBKBDPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x69840C0", Offset = "0x69826C0", VA = "0x1869840C0")]
	public static bool MDPNLNCHLKI([CanBeNull] this FDEOFPEJOOF GOOIJOGLMPJ, IncrementalHash CMIFMCLDAIC, byte[] DBLDAPECCAK, [Out] string BDGJCBKBDPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6983FB0", Offset = "0x69825B0", VA = "0x186983FB0")]
	private static bool JMGNKPBDDJO(byte[] EAMIBBJFJMF, Span<byte> DKAMIPFPOMG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class DLDBJEBPNJP
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6981260", Offset = "0x697F860", VA = "0x186981260")]
	public static int DBDEPKEMIEJ(HashAlgorithmName EOMIKLGKCJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x69813B0", Offset = "0x697F9B0", VA = "0x1869813B0")]
	public static int MBDIJDNPFPG(this HGJOFNIJINE OCPMHFGDANL, byte[] KKCJEOELHPE, IncrementalHash CMIFMCLDAIC, byte[] EGLAHPIIGMO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface HGJOFNIJINE
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash CMIFMCLDAIC);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface FDEOFPEJOOF : HGJOFNIJINE
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	[CanBeNull]
	byte[] OHAFDLDENAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	[CanBeNull]
	byte[] IEKGBBBGFHM
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class FHIDECLKACD
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static bool OIAPMKGOPGM;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly ArrayPool<byte> JBGBOLJHCMO;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly ArrayPool<char> DHFOMKAJGJP;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly Encoding NIGELKAHBBG;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly ThreadLocal<Encoder> AMICLOAKIPA;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2B506E0", Offset = "0x2B4ECE0", VA = "0x182B506E0")]
	public static void MDNGPNPELEP<T>(this IncrementalHash EIDLJHDFACN, [CanBeNull] T NNFKLCEBDGC) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2B50020", Offset = "0x2B4E620", VA = "0x182B50020")]
	public static void DJENKOHLAPL<T>(this IncrementalHash EIDLJHDFACN, [CanBeNull] T OCPMHFGDANL) where T : HGJOFNIJINE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x2B507A0", Offset = "0x2B4EDA0", VA = "0x182B507A0")]
	public static void PFIAFIFGNNH<T>(this IncrementalHash EIDLJHDFACN, [CanBeNull] IList<T> EJFIGJMKGDI) where T : HGJOFNIJINE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6981F50", Offset = "0x6980550", VA = "0x186981F50")]
	private static bool GPPFEMAMBHH([CanBeNull] HGJOFNIJINE OCPMHFGDANL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6981FE0", Offset = "0x69805E0", VA = "0x186981FE0")]
	public static void HHNEOJOLLII(this IncrementalHash CMIFMCLDAIC, string? PNBCKAPKKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6981D80", Offset = "0x6980380", VA = "0x186981D80")]
	public static void FMBAHBKMBFI(this IncrementalHash CMIFMCLDAIC, long ICBFKNBCFDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x69823E0", Offset = "0x69809E0", VA = "0x1869823E0")]
	public static void IBGIKFGOLME(this IncrementalHash CMIFMCLDAIC, int LHCBKPBMGJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6981930", Offset = "0x697FF30", VA = "0x186981930")]
	public static void BOIGHPBNNNJ(this IncrementalHash CMIFMCLDAIC, short OIMONFMCJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6981C70", Offset = "0x6980270", VA = "0x186981C70")]
	public static void EHNNNLHMKOA(this IncrementalHash CMIFMCLDAIC, byte HMHPGMLHLFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6981B00", Offset = "0x6980100", VA = "0x186981B00")]
	public static void CNNMBIHMFGC(this IncrementalHash CMIFMCLDAIC, bool PMOOEMIAGPE, bool HJDEELFKEHN = false, bool ILFKBPGLFEH = false, bool ACKJHOGGOIP = false, bool HILMJDFKJKI = false, bool JNMMDPGFFBP = false, bool MCLIIGIHHKI = false, bool DCENEBPEMEB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2B500B0", Offset = "0x2B4E6B0", VA = "0x182B500B0")]
	public static void HKJJHGIJFFD<T>(this IncrementalHash CMIFMCLDAIC, T FKJJEAOFBOH) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x69825B0", Offset = "0x6980BB0", VA = "0x1869825B0")]
	public static void JLLOALGBKJL(this IncrementalHash CMIFMCLDAIC, float JNOPFPCFAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x69818D0", Offset = "0x697FED0", VA = "0x1869818D0")]
	public static void BNLNKNAMFEI(this IncrementalHash CMIFMCLDAIC, ulong ALLHFOPHHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6981870", Offset = "0x697FE70", VA = "0x186981870")]
	public static void BHMLDPLIIBB(this IncrementalHash CMIFMCLDAIC, uint GMNBFEFMABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6982610", Offset = "0x6980C10", VA = "0x186982610")]
	public static void MKLEBFCOIBL(this IncrementalHash CMIFMCLDAIC, ushort CEIOEOLADGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6982670", Offset = "0x6980C70", VA = "0x186982670")]
	public static void OEMBNHEPPNG(this IncrementalHash CMIFMCLDAIC, Vector3 NDAPAMABNMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class DLNCLGMBAAF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6981610", Offset = "0x697FC10", VA = "0x186981610")]
	public DLNCLGMBAAF(string DICMABMCPKO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class JCPCJNGBKPA<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal class JBEFIHFEHHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public TNode ELMHNMGFNPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public TNode LPFOFJIMHOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public AKEKJDACDKO NHEAJDGKBEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public List<AKEKJDACDKO> HGGNCFACPGO;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public JBEFIHFEHHL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal struct AKEKJDACDKO : IComparable<AKEKJDACDKO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int EDPFBBHDDLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public TClaimant GOEPGMACANE;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xEB3A60", Offset = "0xEB2060", VA = "0x180EB3A60")]
		public AKEKJDACDKO(int EDPFBBHDDLB, TClaimant GOEPGMACANE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3CA0620", Offset = "0x3C9EC20", VA = "0x183CA0620")]
		public bool BEINGOMBEBJ([In] AKEKJDACDKO OGEIJLCLBIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3CA0690", Offset = "0x3C9EC90", VA = "0x183CA0690")]
		public bool JLEGHOOLKCN([In] AKEKJDACDKO OGEIJLCLBIC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3CA0680", Offset = "0x3C9EC80", VA = "0x183CA0680", Slot = "4")]
		public int CompareTo(AKEKJDACDKO OGEIJLCLBIC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3CA06A0", Offset = "0x3C9ECA0", VA = "0x183CA06A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum GFKDCCBNAAO
	{
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class JAALENKDILJ : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public JCPCJNGBKPA<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8A8AC0", Offset = "0x8A70C0", VA = "0x1808A8AC0")]
		[DebuggerHidden]
		public JAALENKDILJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4001BC0", Offset = "0x40001C0", VA = "0x184001BC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4001DA0", Offset = "0x40003A0", VA = "0x184001DA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4001CA0", Offset = "0x40002A0", VA = "0x184001CA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x37ED5D0", Offset = "0x37EBBD0", VA = "0x1837ED5D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly NFELCFMNOIH<JBEFIHFEHHL> BLDDNMMMOOM;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly NFELCFMNOIH<List<AKEKJDACDKO>> ABPBEPMGIPH;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static int DAJGEHCNILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal readonly Dictionary<TClaimant, TNode> OHLCELJKDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	internal readonly Dictionary<TNode, JBEFIHFEHHL> AAOGDNONLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private GFKDCCBNAAO EPPOJBGBBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool KKDPLHMNJCD;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode BBOGCHMHHBK(TNode FNNLHNNHGAD);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void MELIPIHKLFK(TNode FNNLHNNHGAD, TClaimant DKDKDHEKPKC, TClaimant EDBGAFFPDOA);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4007A60", Offset = "0x4006060", VA = "0x184007A60")]
	public JCPCJNGBKPA(GFKDCCBNAAO EPPOJBGBBFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4005E70", Offset = "0x4004470", VA = "0x184005E70")]
	public void AANKEGICCPM(TNode FNNLHNNHGAD, TNode MFKKDCMMKOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4007480", Offset = "0x4005A80", VA = "0x184007480")]
	public void OHEKOIOLOCO(TClaimant GOEPGMACANE, TNode IHCIPKOPEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4006500", Offset = "0x4004B00", VA = "0x184006500", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4006790", Offset = "0x4004D90", VA = "0x184006790")]
	private void FBJEOIANLJN(TClaimant GOEPGMACANE, TNode KGHBEHPFNKM, TNode IHCIPKOPEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x4006720", Offset = "0x4004D20", VA = "0x184006720")]
	private int EMEKIJCALJL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x4006B60", Offset = "0x4005160", VA = "0x184006B60")]
	private void HKMEIGHAHFE(TClaimant GOEPGMACANE, TNode BFKCPNHBOII, TNode HILIGGLCJMG, int JOGABHJMLCP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x4005F40", Offset = "0x4004540", VA = "0x184005F40")]
	private void DAICLHDONNA(AKEKJDACDKO JKAJBBKFBNE, JBEFIHFEHHL OEOKIAMGKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x4006860", Offset = "0x4004E60", VA = "0x184006860")]
	private void HFNHBOKJHPP(TClaimant GOEPGMACANE, TNode BFKCPNHBOII, TNode HILIGGLCJMG, int JOGABHJMLCP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x4007620", Offset = "0x4005C20", VA = "0x184007620")]
	private void OKKNFGDEDDM(AKEKJDACDKO JKAJBBKFBNE, TNode FNNLHNNHGAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x4006390", Offset = "0x4004990", VA = "0x184006390")]
	private void DPHFPKBKCJI(AKEKJDACDKO JKAJBBKFBNE, JBEFIHFEHHL OEOKIAMGKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x4007320", Offset = "0x4005920", VA = "0x184007320")]
	private void OBCEDLLGICI(JBEFIHFEHHL OEOKIAMGKMI, bool DGABBJCBJLH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x4006020", Offset = "0x4004620", VA = "0x184006020")]
	private void DKLKJHINCAN(JBEFIHFEHHL OEOKIAMGKMI, TNode MFKKDCMMKOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x4007050", Offset = "0x4005650", VA = "0x184007050")]
	[IteratorStateMachine(typeof(JCPCJNGBKPA<, >.JAALENKDILJ))]
	private IEnumerable<TNode> LPBDANNLBJF(TNode BFKCPNHBOII, TNode HILIGGLCJMG, bool HFEFCLOGOOE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x4007760", Offset = "0x4005D60", VA = "0x184007760")]
	private JBEFIHFEHHL PHIEGIMHIHB(TNode FNNLHNNHGAD, TNode LPFOFJIMHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x4006EC0", Offset = "0x40054C0", VA = "0x184006EC0")]
	private JBEFIHFEHHL KFBAJEDOPHP(TNode FNNLHNNHGAD, TNode LPFOFJIMHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x4007150", Offset = "0x4005750", VA = "0x184007150")]
	private void NIBAPBDDIKG(JBEFIHFEHHL OEOKIAMGKMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class GBDFEPNDLNG<T> : IEnumerable<GBDFEPNDLNG<T>.EBLDHMGGHLL>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct EBLDHMGGHLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public T FEBGGALLBNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public int EBDMAJMOJLN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class JCIPCAFCAKK : IEnumerator<EBLDHMGGHLL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private GBDFEPNDLNG<T> DJDHJPFPAPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int EBDMAJMOJLN;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x381D560", Offset = "0x381BB60", VA = "0x18381D560", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public EBLDHMGGHLL LAAEJDPDOMN
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x4005530", Offset = "0x4003B30", VA = "0x184005530", Slot = "4")]
			get
			{
				return default(EBLDHMGGHLL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4005440", Offset = "0x4003A40", VA = "0x184005440")]
		public JCIPCAFCAKK(GBDFEPNDLNG<T> DJDHJPFPAPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x4005340", Offset = "0x4003940", VA = "0x184005340", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3874BF0", Offset = "0x38731F0", VA = "0x183874BF0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xA17B50", Offset = "0xA16150", VA = "0x180A17B50", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private struct KLDPFKENJPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public bool JMDJDCNEHHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public T FEBGGALLBNN;
	}

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private const int FGJEGFPOELB = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Dictionary<T, int> PDBPCGJDLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private KLDPFKENJPN[] LFDCNMDNJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private int OGJJIENHKJA;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public int EGAEDGDCHDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x89D480", Offset = "0x89BA80", VA = "0x18089D480")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x89CB70", Offset = "0x89B170", VA = "0x18089CB70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int NCPJPJDHEHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x359ECF0", Offset = "0x359D2F0", VA = "0x18359ECF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2120", Offset = "0x3CB0720", VA = "0x183CB2120")]
	public GBDFEPNDLNG(int HDGFIGFBKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2660", Offset = "0x3CB0C60", VA = "0x183CB2660")]
	public GBDFEPNDLNG(EBLDHMGGHLL[] MMMMMIHPOAO, bool LMEGBJDIEHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3CB1FB0", Offset = "0x3CB05B0", VA = "0x183CB1FB0")]
	public int MNAHBHEKLPN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3CB1570", Offset = "0x3CAFB70", VA = "0x183CB1570")]
	private int HELFCLPOHIF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3CB1F50", Offset = "0x3CB0550", VA = "0x183CB1F50", Slot = "6")]
	protected virtual uint JNNMHAFMGLM(uint CMIFMCLDAIC, T FEBGGALLBNN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3CB1E90", Offset = "0x3CB0490", VA = "0x183CB1E90")]
	public bool JHEKNKIBEGE(T FEBGGALLBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3CB1E00", Offset = "0x3CB0400", VA = "0x183CB1E00")]
	public int JGBKBKKICGD(T FEBGGALLBNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3CB1240", Offset = "0x3CAF840", VA = "0x183CB1240")]
	public T BKBHIMDHMLK(int EBDMAJMOJLN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3CB1A00", Offset = "0x3CB0000", VA = "0x183CB1A00")]
	public bool HJOEBKGBEIE(T FEBGGALLBNN, bool GEOMJJNBJBL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3CB1790", Offset = "0x3CAFD90", VA = "0x183CB1790")]
	public bool HJOEBKGBEIE(T FEBGGALLBNN, int EBDMAJMOJLN, bool GEOMJJNBJBL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x3CB12B0", Offset = "0x3CAF8B0", VA = "0x183CB12B0")]
	private int CACKAPNBAHI(int CHEJIFFIDLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2080", Offset = "0x3CB0680", VA = "0x183CB2080", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3CB2080", Offset = "0x3CB0680", VA = "0x183CB2080", Slot = "4")]
	private IEnumerator<EBLDHMGGHLL> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class NFELCFMNOIH<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly Stack<T> HFEKFICPOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly List<T> CJGIMAMNILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly int AOFKALEHCPK;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x4573590", Offset = "0x4571B90", VA = "0x184573590")]
	public static NFELCFMNOIH<T> NKHLIBJAFKP(int HDGFIGFBKEK = 0, int AOFKALEHCPK = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x4573220", Offset = "0x4571820", VA = "0x184573220")]
	public static NFELCFMNOIH<T> GNJFJIOOFDH(int HDGFIGFBKEK = 0, int AOFKALEHCPK = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x4573770", Offset = "0x4571D70", VA = "0x184573770")]
	public NFELCFMNOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x45737C0", Offset = "0x4571DC0", VA = "0x1845737C0")]
	public NFELCFMNOIH(int HDGFIGFBKEK, int AOFKALEHCPK = int.MaxValue, bool OPBNABHDMMI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4572D80", Offset = "0x4571380", VA = "0x184572D80")]
	public T BCNBEMFJJAE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x4573690", Offset = "0x4571C90", VA = "0x184573690")]
	public void OCKLLMDPOLJ(T FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4573120", Offset = "0x4571720", VA = "0x184573120")]
	private void EJCLAADJFEC(T FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x4572F40", Offset = "0x4571540", VA = "0x184572F40")]
	private void CLCCFGMCKPA(T FEBGGALLBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x4572F90", Offset = "0x4571590", VA = "0x184572F90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4573320", Offset = "0x4571920", VA = "0x184573320")]
	private void LKIHHMMBLMK(IEnumerable<T> EGCOBBLGNBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class NAHKBHDEGBO<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Dictionary<int, T> LPGLBEOCAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private T MEEAHAIHAPL;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public virtual T CPEGGIFMMDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x85F4B0", Offset = "0x85DAB0", VA = "0x18085F4B0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x4568DE0", Offset = "0x45673E0", VA = "0x184568DE0")]
	public bool OGECAKANLGB(T FEBGGALLBNN, int EDPFBBHDDLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x4568AD0", Offset = "0x45670D0", VA = "0x184568AD0")]
	public bool GDEOFMCKIAN(int EDPFBBHDDLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x45688D0", Offset = "0x4566ED0", VA = "0x1845688D0")]
	public T DDMBOJPFEDJ(int JMMKDNFBNEF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x4568CA0", Offset = "0x45672A0", VA = "0x184568CA0")]
	private bool OFMJOCAKMAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4568B80", Offset = "0x4567180", VA = "0x184568B80")]
	public bool NCAHNJJKPNF(int EDPFBBHDDLB, [Out] T FEBGGALLBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4568F40", Offset = "0x4567540", VA = "0x184568F40")]
	public NAHKBHDEGBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class PHGNBMPIPLB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	protected struct LNHIHBLPOBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public T MDPJKNKDANF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int CPMKPPFMBJK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	protected readonly List<LNHIHBLPOBN> PFDOCCGACIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private T CCFHHIKEIEC;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int NCPJPJDHEHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x359ECF0", Offset = "0x359D2F0", VA = "0x18359ECF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4814F10", Offset = "0x4813510", VA = "0x184814F10")]
	public bool GJJPBLIIILJ(T FEBGGALLBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4814E50", Offset = "0x4813450", VA = "0x184814E50")]
	public void AGMNBECNIJC(T FEBGGALLBNN, int EDPFBBHDDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4815420", Offset = "0x4813A20", VA = "0x184815420")]
	public bool PJEMHMBEIPM(T FEBGGALLBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x48151F0", Offset = "0x48137F0", VA = "0x1848151F0")]
	public void KFLPEIEEDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4815140", Offset = "0x4813740", VA = "0x184815140")]
	public T HOALJAILPHH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x48152A0", Offset = "0x48138A0", VA = "0x1848152A0")]
	protected void KNMNKGEHDDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4815630", Offset = "0x4813C30", VA = "0x184815630")]
	public PHGNBMPIPLB()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[SerializeField]
		[FOAPFLEFDGH(NABHOIFJJJN.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x6984B10", Offset = "0x6983110", VA = "0x186984B10")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x6984DE0", Offset = "0x69833E0", VA = "0x186984DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x6984CF0", Offset = "0x69832F0", VA = "0x186984CF0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x6984A60", Offset = "0x6983060", VA = "0x186984A60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x6984D30", Offset = "0x6983330", VA = "0x186984D30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x6984C40", Offset = "0x6983240", VA = "0x186984C40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x69849E0", Offset = "0x6982FE0", VA = "0x1869849E0")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x49EDFD0", Offset = "0x49EC5D0", VA = "0x1849EDFD0", Slot = "4")]
		public virtual T OGLACEOFNLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class LBKGANIHMML : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Dictionary<byte, BNIOFOBPAIP> JOIMEPLLEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly NFELCFMNOIH<BNIOFOBPAIP> LOGIPNHCNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly bool ODDCAEKCHGH;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public BNIOFOBPAIP IJDLDOHKPGC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x85D1C0", Offset = "0x85B7C0", VA = "0x18085D1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x85D1B0", Offset = "0x85B7B0", VA = "0x18085D1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector2 ECHEMMILOGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xE10140", Offset = "0xE0E740", VA = "0x180E10140")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x110DB70", Offset = "0x110C170", VA = "0x18110DB70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private Vector2 HGKOGFPEGKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x1168900", Offset = "0x1166F00", VA = "0x181168900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Vector2 MMPHDDDHKMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6983A10", Offset = "0x6982010", VA = "0x186983A10")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x865690", Offset = "0x863C90", VA = "0x180865690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int FLBGBGNDMHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x862F60", Offset = "0x861560", VA = "0x180862F60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8632F0", Offset = "0x8618F0", VA = "0x1808632F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6983EF0", Offset = "0x69824F0", VA = "0x186983EF0")]
	public LBKGANIHMML(Bounds ADFCMDNNDCI, Vector2[] MMGIDAEKANO, int INIGLLFNONK, byte CHEJIFFIDLB, float CDIIKJJJJGF = 0f, [Optional] NFELCFMNOIH<BNIOFOBPAIP> LOGIPNHCNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6982F30", Offset = "0x6981530", VA = "0x186982F30")]
	public void BNAMDAHBHMD(Bounds ADFCMDNNDCI, Vector2[] MMGIDAEKANO, int INIGLLFNONK, byte CHEJIFFIDLB, float CDIIKJJJJGF = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6983B80", Offset = "0x6982180", VA = "0x186983B80")]
	public BNIOFOBPAIP MBHPCKMOLNO(byte EBDMAJMOJLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6983A90", Offset = "0x6982090", VA = "0x186983A90")]
	public void IGHOEFFEOMA(Vector3 LPBGBJBIAOJ, float GALKNINHPFC, float ODHGIAJOGGF, List<byte> GOINOJBCPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6983B60", Offset = "0x6982160", VA = "0x186983B60")]
	public void KIAHEHPAKGO(BNIOFOBPAIP.KIHFEPCBNJE EACIGAFEHBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6983E00", Offset = "0x6982400", VA = "0x186983E00")]
	public static int NEPGAHPKNDA(Vector2[] MMGIDAEKANO, int INIGLLFNONK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6983780", Offset = "0x6981D80", VA = "0x186983780")]
	private BNIOFOBPAIP CGHBKEFOPCO(byte EBDMAJMOJLN, BNIOFOBPAIP.AJANHCLOCFH CCKOPPJEHKN, BNIOFOBPAIP LPFOFJIMHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x69833D0", Offset = "0x69819D0", VA = "0x1869833D0")]
	private void CGDKHMOEIBO(BNIOFOBPAIP LPFOFJIMHOE, Vector2[] MMGIDAEKANO, int JEPHCMFAPNG, int ABKLBDNODDK, int EFIENGFOALH, int PEFJDDPELFO, float CDIIKJJJJGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6983BE0", Offset = "0x69821E0", VA = "0x186983BE0")]
	private void MNAOCFAALHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x69839B0", Offset = "0x6981FB0", VA = "0x1869839B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6983A30", Offset = "0x6982030", VA = "0x186983A30", Slot = "1")]
	~LBKGANIHMML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class BNIOFOBPAIP
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum AJANHCLOCFH
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public enum KIHFEPCBNJE
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public byte EPFHNBBFJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public Vector3 LKNPMDMPMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public Vector3 BONHNBEOKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public Vector3 KNLBMBGNGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public Vector3 BMBIIGPKMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public AJANHCLOCFH HMKCLOAJDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public BNIOFOBPAIP LFKOPKGONIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public List<BNIOFOBPAIP> NFIFCNCKDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public bool DKMNNBKOIDL;

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6981140", Offset = "0x697F740", VA = "0x186981140")]
	public BNIOFOBPAIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6981000", Offset = "0x697F600", VA = "0x186981000")]
	public void MOGHPDEAFIL(BNIOFOBPAIP IKNBKKNKJDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	public void KIAHEHPAKGO(int CMLKOJCEKPL, KIHFEPCBNJE EACIGAFEHBO, int MLCOGACEDDA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6980D70", Offset = "0x697F370", VA = "0x186980D70")]
	public void IGHOEFFEOMA(List<byte> GOINOJBCPMJ, Vector3 LPBGBJBIAOJ, float GALKNINHPFC, float ODHGIAJOGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6980FD0", Offset = "0x697F5D0", VA = "0x186980FD0")]
	public bool KBFPCANFBBG(Vector3 CBJGMPIDMJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6980D40", Offset = "0x697F340", VA = "0x186980D40")]
	public bool HKKOBAHJELN(Vector3 CBJGMPIDMJB, float ALPKHGMGMJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6980CB0", Offset = "0x697F2B0", VA = "0x186980CB0")]
	public void HGDANEHJCNG()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public struct PMAJAJIGPJA<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private readonly List<Component> MNNCEMFBNNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private readonly bool BANAOFIMGGK;

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x42876C0", Offset = "0x4285CC0", VA = "0x1842876C0")]
			public PMAJAJIGPJA(List<Component> MNNCEMFBNNK, bool BANAOFIMGGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x48232E0", Offset = "0x48218E0", VA = "0x1848232E0")]
			public ONPNKPJOEHO<T> CPHKKMADKBM()
			{
				return default(ONPNKPJOEHO<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x4823350", Offset = "0x4821950", VA = "0x184823350", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x4823350", Offset = "0x4821950", VA = "0x184823350", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		public struct ONPNKPJOEHO<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private readonly List<Component> MNNCEMFBNNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			private readonly bool BANAOFIMGGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private int EBDMAJMOJLN;

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public T LAAEJDPDOMN
			{
				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x473E1E0", Offset = "0x473C7E0", VA = "0x18473E1E0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x473E170", Offset = "0x473C770", VA = "0x18473E170", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x473E1B0", Offset = "0x473C7B0", VA = "0x18473E1B0")]
			public ONPNKPJOEHO(List<Component> MNNCEMFBNNK, bool BANAOFIMGGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x473E0B0", Offset = "0x473C6B0", VA = "0x18473E0B0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x473E0C0", Offset = "0x473C6C0", VA = "0x18473E0C0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x3863D20", Offset = "0x3862320", VA = "0x183863D20", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x6986800", Offset = "0x6984E00", VA = "0x186986800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6986600", Offset = "0x6984C00", VA = "0x186986600")]
		private void HGDANEHJCNG(GameObject KBPNAOHFMLJ, bool EFJJGJMLHPN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6986570", Offset = "0x6984B70", VA = "0x186986570")]
		public static void HGDANEHJCNG(GameObject KBPNAOHFMLJ, ToolHierarchyCache GIPKBENJJKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6986120", Offset = "0x6984720", VA = "0x186986120")]
		public void ADGMNHLMPHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x2E7CC70", Offset = "0x2E7B270", VA = "0x182E7CC70")]
		public void ENCMEPNOJEG<T>(Action<T> IJDJHMGAIOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2E7CBD0", Offset = "0x2E7B1D0", VA = "0x182E7CBD0")]
		public T CLMKCKBLIDM<T>(bool BANAOFIMGGK = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2E7CEB0", Offset = "0x2E7B4B0", VA = "0x182E7CEB0")]
		public PMAJAJIGPJA<T> LMIHLLOJAEE<T>(bool BANAOFIMGGK = false) where T : class
		{
			return default(PMAJAJIGPJA<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6986130", Offset = "0x6984730", VA = "0x186986130")]
		public List<Component> CMOLBOPPNIK(Type BDKLEMDNAFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6986480", Offset = "0x6984A80", VA = "0x186986480", Slot = "4")]
		public bool Equals(ToolHierarchyCache OEMFOJFNECE, ToolHierarchyCache DPKOFHFGJKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6986500", Offset = "0x6984B00", VA = "0x186986500", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache CDBNFNMIHPK)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class FNOJIEIECGO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int HDGFIGFBKEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int NPECJGBLEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private List<T> IFKANDOEAII;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int NCPJPJDHEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3B735C0", Offset = "0x3B71BC0", VA = "0x183B735C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public T PKGJKBJFPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3C06810", Offset = "0x3C04E10", VA = "0x183C06810")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public T NHLLMIHPNEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3C063F0", Offset = "0x3C049F0", VA = "0x183C063F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public T CIBPBCEJOII
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3C06550", Offset = "0x3C04B50", VA = "0x183C06550")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x3C06960", Offset = "0x3C04F60", VA = "0x183C06960")]
	public FNOJIEIECGO(int HDGFIGFBKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x3C06280", Offset = "0x3C04880", VA = "0x183C06280")]
	public void AGMNBECNIJC(T PDOLIFPDINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x3C065E0", Offset = "0x3C04BE0", VA = "0x183C065E0")]
	public void KFLPEIEEDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x3C06640", Offset = "0x3C04C40", VA = "0x183C06640")]
	public void MNLNNJEMEDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x3C068F0", Offset = "0x3C04EF0", VA = "0x183C068F0")]
	public void OOMONGBIACN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x3C065D0", Offset = "0x3C04BD0", VA = "0x183C065D0")]
	public void JOGDAIGFCLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class NMPIMEDMHBJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private struct NFBNOCEPMOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public int CPMKPPFMBJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public T MDPJKNKDANF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly Dictionary<object, NFBNOCEPMOB> LPGLBEOCAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly EqualityComparer<T> OGDPDBCECDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private T MEEAHAIHAPL;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public virtual T CPEGGIFMMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x9B1630", Offset = "0x9AFC30", VA = "0x1809B1630", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x45F79C0", Offset = "0x45F5FC0", VA = "0x1845F79C0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool IFHHIAJABFM
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x45F7B20", Offset = "0x45F6120", VA = "0x1845F7B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public object LNHPHLGEJGI
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x860D00", Offset = "0x85F300", VA = "0x180860D00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x860D10", Offset = "0x85F310", VA = "0x180860D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x45FB2A0", Offset = "0x45F98A0", VA = "0x1845FB2A0")]
	public bool OGECAKANLGB(T FEBGGALLBNN, object PNPIGCGKNPI, int EDPFBBHDDLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x45F7A60", Offset = "0x45F6060", VA = "0x1845F7A60")]
	public bool GDEOFMCKIAN(object PNPIGCGKNPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x45F7F10", Offset = "0x45F6510", VA = "0x1845F7F10")]
	public bool NCAHNJJKPNF(object PNPIGCGKNPI, [Out] T FEBGGALLBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x4574860", Offset = "0x4572E60", VA = "0x184574860")]
	public void KFLPEIEEDCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x45F8B10", Offset = "0x45F7110", VA = "0x1845F8B10")]
	private bool OFMJOCAKMAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x45FBFC0", Offset = "0x45FA5C0", VA = "0x1845FBFC0")]
	public NMPIMEDMHBJ()
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
