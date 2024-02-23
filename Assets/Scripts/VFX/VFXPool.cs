using CosmicCuration.Enemy;
using CosmicCuration.PowerUps;
using CosmicCuration.Utilities;
using CosmicCuration.VFX;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXPool : GenericObjectPool<VFXController>
{

    private VFXView vfxPrefab;

    public VFXPool(VFXView vfxPrefab) => this.vfxPrefab = vfxPrefab;
    public VFXController GetVFX() => GetItem<VFXController>();

    protected override VFXController CreateItem<T>() => new VFXController(vfxPrefab);
}
