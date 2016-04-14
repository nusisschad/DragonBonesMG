﻿using DragonBonesMG.Core;
using DragonBonesMG.Curves;
using DragonBonesMG.JsonData;

namespace DragonBonesMG.Animation {
    public class BoneFrame : Frame {

        public DbTransform Transform;

        internal BoneFrame(int startFrame, BoneFrameData f) {
            StartFrame = startFrame;
            Transform = new DbTransform(f.Transform);
            TweenCurve = TweenFactory.FromArray(f.TweenCurve);
        }

    }
}